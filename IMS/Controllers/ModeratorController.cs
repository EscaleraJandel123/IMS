﻿using IMS.Data;
using IMS.Models;
using IMS.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System.Security.Cryptography;

namespace IMS.Controllers
{
    [Authorize(Roles = "moderator")]
    public class ModeratorController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly LogService _logService;
        private readonly SessionService _sessionService;
        public ModeratorController(ApplicationDbContext context, LogService logService, SessionService sessionService)
        {
            _context = context;
            _logService = logService;
            _sessionService = sessionService;
        }
        public async Task<IActionResult> Index()
        {
            int userId = _sessionService.GetUserId();
            var userReports = await _context.incidents.
                                                Where(i => i.assigned_too == userId)
                                                .ToListAsync();

            ViewBag.TotalReports = userReports.Count;
            ViewBag.InProressReport = userReports.Count(i => i.status == "In Progress");
            ViewBag.ResolvedReports = userReports.Count(i => i.status == "Resolved");
            ViewBag.ClosedReports = userReports.Count(i => i.status == "Closed");
            ViewBag.UserId = userId;
            return View("Index", userReports);
        }

        public async Task<IActionResult> manageIncidents()
        {
            int userId = _sessionService.GetUserId();

            var incidents = await _context.incidents
                                          .Where(i => i.assigned_too == userId)
                                          .Where(i => i.status != "Closed")
                                          .ToListAsync();

            var updates = await _context.updates
                                      .Where(u => incidents.Select(i => i.incident_id).Contains(u.incident_id))
                                      .ToListAsync();

            var attachments = await _context.attachments.ToListAsync();

            var users = await _context.users.ToListAsync(); // Fetch all users
            // Combine incidents and only fetch attachments that match the incident_id
            var incidentList = incidents.Select(i => new IncidentViewModel
            {
                Incident = i,
                Attachments = attachments.Where(a => a.incident_id == i.incident_id).ToList(),
                User = users.FirstOrDefault(u => u.user_id == i.user_id),
                Updates = updates.Where(u => u.incident_id == i.incident_id).ToList()
            }).ToList();

            return View("manageIncidents", incidentList);
        }

        [HttpPost]
        public async Task<IActionResult> Resolve(int incidentId, int userid, string comments, IFormFile attach)
        {
            var token = Convert.ToBase64String(RandomNumberGenerator.GetBytes(32)); // Secure token
            string filePath = null;
            if (attach != null && attach.Length > 0)
            {
                var uploadsFolder = Path.Combine("wwwroot/uploads");
                if (!Directory.Exists(uploadsFolder))
                {
                    Directory.CreateDirectory(uploadsFolder);
                }

                filePath = Path.Combine(uploadsFolder, attach.FileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await attach.CopyToAsync(stream);
                }
            }

            // Save update
            var updates = new UpdatesModel
            {
                incident_id = incidentId,
                update_text = comments,
                user_id = userid,
                token = token,
                updated_at = DateTime.Now,
                attachments = filePath != null ? "/uploads/" + attach.FileName : null
            };

            _context.updates.Add(updates);


            await _context.SaveChangesAsync();

            // Find the existing incident
            var incident = await _context.incidents.FirstOrDefaultAsync(i => i.incident_id == incidentId);
            if (incident == null)
            {
                return NotFound();
            }

            // Update status
            incident.status = "Resolved";
            _context.incidents.Update(incident);

            _logService.AddLog(userid, $"Rosolved an incident: {incident.tittle}");
            await _context.SaveChangesAsync();

            return RedirectToAction("ManageIncidents");
        }

        public async Task<IActionResult> reviewReports()
        {
            int userId = _sessionService.GetUserId();
            var incidents = await _context.incidents
                                          .Where(i => i.assigned_too == userId)
                                          .Where(i => i.status == "Closed")
                                          .ToListAsync();

            var updates = await _context.updates
                                       .Where(u => incidents.Select(i => i.incident_id).Contains(u.incident_id))
                                       .ToListAsync();

            var attachments = await _context.attachments.ToListAsync();

            var users = await _context.users.ToListAsync(); // Fetch all users

            var Comments = await _context.comments.ToListAsync();
            // Combine incidents and only fetch attachments that match the incident_id
            var incidentList = incidents.Select(i => new IncidentViewModel
            {
                Incident = i,
                Attachments = attachments.Where(a => a.incident_id == i.incident_id).ToList(),
                User = users.FirstOrDefault(u => u.user_id == i.user_id),
                Updates = updates.Where(u => u.incident_id == i.incident_id).ToList(),
                Comments = Comments.Where(c => c.incident_id == i.incident_id).ToList(),
            }).ToList();

            return View("Reports", incidentList);
        }
    }
}
