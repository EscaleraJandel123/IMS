﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class Seeders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "departments",
                columns: new[] { "department_id", "ImagePath", "department", "description", "token" },
                values: new object[,]
                {
                    { 12, "/departments/IT.webp", "Information Technology (IT) Department", "Responsible for maintaining and securing the organization's IT infrastructure, ensuring smooth operation of systems, networks, and software.", "EYcLYD+5MDZefgLOMIoszTVmLL6YuHDc/r7gSnhjOMI=" },
                    { 13, "/departments/hr.webp", "Human Resources (HR) Department", "Handles employee-related issues, including recruitment, workplace policies, and conflict resolution.", "1L9JFDAOhdRAfr8WTE2TFseSIbmFznhF8G+YQYeQztU=" },
                    { 14, "/departments/facilities.webp", "Facilities Management Department", "Ensures the maintenance and safety of physical office spaces, including repairs and environmental concerns.", "6G7QdUkik1mqrvrGW7onUkJgMDX0uWCx8eO5CGPAafI=" },
                    { 15, "/departments/customer.webp", "Customer Support Department", "Addresses customer complaints, inquiries, and service-related issues to maintain customer satisfaction.", "WKGIl7ur+NipjdwcCelAQMAWgwI4+yUKRAUJ+rwnUrI=" },
                    { 16, "/departments/health and safety.webp", "Health and Safety Department", "Ensures workplace safety, compliance with health regulations, and handles medical emergencies.", "CfNwST/Pp0U9H/1bbkTQOQ308K05oiLvpcTGdLosZNA=" }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "user_id", "created_at", "department", "email", "full_name", "isRistrict", "password", "profile", "role", "token", "token_forgot" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 13, 2, 15, 7, 0, DateTimeKind.Unspecified), "NONE", "admin@gmail.com", "Admin", false, "$2a$11$A.0BKl3ASTqoRr8dLlWoPesgiVtaDMYEklsW.FqVYeaGEPKc.Djwi", "/uploads/db682a3e-8bd0-48de-986a-b89a678549ba_admin.jpg", "admin", "b4DmKmCKT3AwPc+6bLF60/wFgDmXGnfn8We9F31R8EA=", null },
                    { 3, new DateTime(2025, 3, 13, 2, 38, 39, 0, DateTimeKind.Unspecified), "IT", "escalerajandel@gmail.com", "Jandel L. Escalera", false, "$2a$11$Vn.lT8jQb5V/SotnvF/JGe4xSaGq2x6KFQP40rdkNxqee3YE4gERK", null, "user", "MSK56cHgAJi9kXNzg2PRB0sLzVtP9Z4ywk4lPHWUHLw=", null },
                    { 4, new DateTime(2025, 3, 14, 3, 12, 45, 0, DateTimeKind.Unspecified), "Information Technology (IT) Department", "moderator@gmail.com", "Moderator", false, "$2a$11$5p8lht/am/uAg96zUZpH4.ppxLkjcDstGjs5As/iNeuOTrVKMw/xa", null, "moderator", "HpI5vTPrFIYF9o0SYZ2lL3/3fWjJqJQQf+OF5G1JBqE=", null },
                    { 5, new DateTime(2025, 3, 14, 5, 19, 22, 0, DateTimeKind.Unspecified), "Security Operations (SecOps)", "moderator2@gmail.com", "Moderator2", false, "$2a$11$OPYGmhz7SBSyDcF/og2dZ.pZIYHYJFKMowMKo0yId24MOx1doeVNa", null, "moderator", "fh3mxIB++x2xSNY8h52gX0cGNImmEZc4EDRx9Nzq+js=", null },
                    { 6, new DateTime(2025, 3, 14, 6, 3, 46, 0, DateTimeKind.Unspecified), "NONE", "maria.santos@example.com", "Maria Santos", false, "$2a$11$/8EmvCVReBigVd5dTjbQmeatoWgapeEkclKXvY9G1FJ4xMi3IV442", null, "user", "ebISNl+Q/RQUtwr4BL8JVWpaFMpW8HocmMXf2viJA+A=", null },
                    { 7, new DateTime(2025, 3, 14, 6, 5, 21, 0, DateTimeKind.Unspecified), "NONE", "james.rodriguez@example.com", "James Rodriguez", false, "$2a$11$7dmhE9tPbZWCsP3EmdlwPOfGZ3Lgas.S/P0A3Gbb8IF/LqwQfqiQO", null, "user", "38rpDGoPp9nOZcCkeul3zmUy+qxEbW5sHwqvDb3x6fg=", null },
                    { 8, new DateTime(2025, 3, 14, 6, 7, 19, 0, DateTimeKind.Unspecified), "NONE", "angela.lopez@example.com", "Angela Lopez", false, "$2a$11$FRYxXUpMCqCvsLPrFd8rGOmNgLMjrHwbXbmoughA4W2vgiOHDNEhO", null, "user", "LvDhX4JQEvXfy7GwA0sBt8XDvg3GMIiZpomxNcPkw2Y=", null },
                    { 9, new DateTime(2025, 3, 14, 6, 9, 12, 0, DateTimeKind.Unspecified), "NONE", "mark.villanueva@example.com", "Mark Villanueva", false, "$2a$11$kcWTJg9vJlxTwfEaroqEReRpzSFioLPjlsVhfDnro1AvRe.U5XEPC", null, "user", "oQRPEsk16kyTQDIBiLmfDkG63sWdsq/ckVlxHKNSk6o=", null }
                });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "category_id", "category_name", "department_id", "description", "token" },
                values: new object[,]
                {
                    { 11, "Network Issues", 12, "Problems related to connectivity, slow internet, or outages.", "y9OZPbXXJSbnO3rdh3F6gsb2dzHxtrhV7rQhbDv1XI0=" },
                    { 12, "Software Bugs", 12, "Errors, crashes, or failures in company software.", "mtgoEtuRj5REx26u0DNqVsxFHWJu9bKlrlbwggkVyBY=" },
                    { 13, "Hardware Failures", 12, "Malfunctions in computers, printers, or servers.", "QXeqHRMrRNVDF0yeEbD9S6USghh/o/lC7zZxDjfPFro=" },
                    { 14, "Cybersecurity Threats", 12, "Phishing attacks, malware, or unauthorized access.", "EJuQxkEAHY6T0HYQsX3VPgwS4c8s/rvnrRPsu8nRRW4=" },
                    { 15, "Workplace Harassment", 13, "Reports of discrimination, bullying, or misconduct", "dc4groq/aaMlmRUx9df/8I6aZUuuGzXsWORVWB8iHsM=" },
                    { 16, "Payroll Issues", 13, "Salary discrepancies, tax concerns, or missing payments", "MIclgIu/YLVP+tzB51rAfKHwGHCWkOvt+Px/LHUfS7c=" },
                    { 17, "Attendance & Leave", 13, "Problems with leave applications, tardiness tracking, or shift scheduling", "NMjqjhP7u+1PywbJw3/wwWfguXP+bcSP3eUZzsV3xJw=" },
                    { 18, "Employee Benefits", 13, "Issues related to healthcare, insurance, or retirement plans.", "ibEe5hUL5PZGMXcUJflXDcVI3PfPKLJGEuIgEtxYSX8=" },
                    { 19, "Building Maintenance", 14, "Repairs for broken equipment, lighting, or air conditioning.", "yeYHizT9QjRo9RGoY5HzYzInthphnSVppTstTIKVdd4=" },
                    { 20, "Safety Hazards", 14, "Fire hazards, exposed wiring, or structural issues", "gK34Sfu/ziM6oyMbdOgIXgvRySa9lHqNusOmEUohCVs=" },
                    { 21, "Janitorial Services", 14, "Complaints regarding cleanliness or waste disposal.", "eFXqvuloVhXkT+Zq/aU1jaw/cfP1PqMtD4gUCM+hLpI=" },
                    { 22, "Security Concerns", 14, "Issues with access control, surveillance, or unauthorized entry.", "rvccCYQUAkBw7mJAnwyncMzk6QlDsaM+Y8S/linexjU=" },
                    { 23, "Product Defects", 15, "Issues with faulty or malfunctioning products", "hy6uZg8nR1nmym+b2UBrBOJiYCE6wzVmH2+SaPHUhD4=" },
                    { 24, "Billing Disputes", 15, "Overcharges, incorrect invoices, or refunds.", "l+fXeUVOHJLJMdDyFgbCvBw7Xo+AH8z+T6jHEbyncCI=" },
                    { 25, "Service Complaints", 15, "Delayed deliveries, poor service, or unresponsive support.", "NDxdk+RMKCooSgYQnRbs7eR54lNvdIxBn0tPpb1jVlA=" },
                    { 26, "Account Issues", 15, "Problems with login, password resets, or account suspension", "XndG/Zx19NQ+95a1Kz5ix5Hmo68zFiR8oPcPJk1eFp4=" },
                    { 27, "Workplace Injuries", 16, "Reporting accidents, injuries, or hazardous conditions", "dbjQ/wTKDNor9ZCFZl38BZrGscycG7vWYspk1i1IkpM=" },
                    { 28, "Health Code Violations", 16, "Unsanitary conditions, food safety, or medical concerns.", "3qQfElbe1OmAe3g2YxdrvYRHNRpHbqlXnANpenEmkV8=" },
                    { 29, "Fire Safety Issues", 16, "Fire alarm malfunctions, blocked exits, or fire drill concerns.", "Y6gxXphSXY/BwSBUgULKKnHY1nQN4ioEyRJq9tR1cQM=" },
                    { 30, "Ergonomic Concerns", 16, "Poor workstation setup causing discomfort or injury", "ppDJseg+d8dPcOrHewCLpayXF91upPU0UlOvpT+V43o=" }
                });

            migrationBuilder.InsertData(
                table: "incidents",
                columns: new[] { "incident_id", "assigned_too", "category", "department_id", "description", "priority", "reported_at", "status", "tittle", "token", "updated_at", "user_id" },
                values: new object[,]
                {
                    { 12, null, "Network Issues", 12, "The entire office lost internet connectivity around 10:30 AM. All employees are unable to access internal systems, emails, and cloud-based services. Restarting the router did not resolve the issue.", "High", new DateTime(2025, 3, 14, 6, 2, 22, 0, DateTimeKind.Unspecified), "Pending", "Network Outage in Main Office", "Qd/aT69LhRylvJFVd+GsPfEcSNgmKR1z+xX+0Z4zB/Y=", null, 3 },
                    { 13, null, "Payroll Issues", 13, "HR employees are unable to log in to the payroll system. Error message: 'Invalid Credentials' even though the credentials are correct.", "High", new DateTime(2025, 3, 14, 6, 4, 55, 0, DateTimeKind.Unspecified), "Pending", "Payroll System Login Failure", "UptZquhuvLGhM01qb1cmd9V9oPQKl0cuAx6GXsYH9RE=", null, 6 },
                    { 14, null, "Building Maintenance", 14, "Elevator in Building B is stuck on the 3rd floor. Employees are unable to use it, and the control panel is unresponsive.", "High", new DateTime(2025, 3, 14, 6, 6, 41, 0, DateTimeKind.Unspecified), "Pending", "Elevator Malfunction in Building B", "Q/8L3vjijELj2ApZvZ/RtlpzPNIsD/86Hq8D0vc7bHs=", null, 7 },
                    { 15, null, "Account Issues", 15, "The customer complaint tracking system crashes after submitting a complaint. This is affecting response times.", "High", new DateTime(2025, 3, 14, 6, 8, 45, 0, DateTimeKind.Unspecified), "Pending", "Customer Complaint System Not Responding", "5Zb+X3izbPijUY8celgVJ40PefnDxz75PSUdh6AcVbU=", null, 8 },
                    { 16, null, "Ergonomic Concerns", 16, "Some financial records for February 2025 are missing in the accounting system. The reports do not load correctly.", "High", new DateTime(2025, 3, 14, 6, 9, 58, 0, DateTimeKind.Unspecified), "Pending", "Missing Financial Reports in System", "kHmRUB+JBdxmh0JVdEdynvQs7Sl/SupcCYCE/PYC+Tw=", null, 9 },
                    { 17, 4, "Hardware Failures", 12, "The server suddenly shutdown and can't be opened.", "High", new DateTime(2025, 3, 15, 10, 27, 52, 0, DateTimeKind.Unspecified), "In Progress", "System Downtime", "d5nLpbAe8s6k5RZY/UxjrdMHyYDbQp2eaq7zgQsl6ck=", null, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "incidents",
                keyColumn: "incident_id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "incidents",
                keyColumn: "incident_id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "incidents",
                keyColumn: "incident_id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "incidents",
                keyColumn: "incident_id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "incidents",
                keyColumn: "incident_id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "incidents",
                keyColumn: "incident_id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "user_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "user_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "user_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "department_id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "department_id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "department_id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "department_id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "department_id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "user_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "user_id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "user_id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "user_id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "user_id",
                keyValue: 9);
        }
    }
}
