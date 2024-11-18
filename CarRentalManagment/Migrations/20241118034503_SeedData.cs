﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagment.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 11, 45, 3, 82, DateTimeKind.Local).AddTicks(46), new DateTime(2024, 11, 18, 11, 45, 3, 82, DateTimeKind.Local).AddTicks(56), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 11, 45, 3, 82, DateTimeKind.Local).AddTicks(58), new DateTime(2024, 11, 18, 11, 45, 3, 82, DateTimeKind.Local).AddTicks(58), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 11, 45, 3, 82, DateTimeKind.Local).AddTicks(228), new DateTime(2024, 11, 18, 11, 45, 3, 82, DateTimeKind.Local).AddTicks(228), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 11, 45, 3, 82, DateTimeKind.Local).AddTicks(229), new DateTime(2024, 11, 18, 11, 45, 3, 82, DateTimeKind.Local).AddTicks(230), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 11, 45, 3, 82, DateTimeKind.Local).AddTicks(295), new DateTime(2024, 11, 18, 11, 45, 3, 82, DateTimeKind.Local).AddTicks(295), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 11, 45, 3, 82, DateTimeKind.Local).AddTicks(297), new DateTime(2024, 11, 18, 11, 45, 3, 82, DateTimeKind.Local).AddTicks(297), "X5", "System" },
                    { 3, "System", new DateTime(2024, 11, 18, 11, 45, 3, 82, DateTimeKind.Local).AddTicks(298), new DateTime(2024, 11, 18, 11, 45, 3, 82, DateTimeKind.Local).AddTicks(299), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 18, 11, 45, 3, 82, DateTimeKind.Local).AddTicks(300), new DateTime(2024, 11, 18, 11, 45, 3, 82, DateTimeKind.Local).AddTicks(300), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
