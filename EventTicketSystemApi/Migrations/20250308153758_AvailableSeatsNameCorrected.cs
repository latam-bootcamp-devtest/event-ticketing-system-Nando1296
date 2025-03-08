using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventTicketSystemApi.Migrations
{
    /// <inheritdoc />
    public partial class AvailableSeatsNameCorrected : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AvaibleSeats",
                table: "Events",
                newName: "AvailableSeats");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AvailableSeats",
                table: "Events",
                newName: "AvaibleSeats");
        }
    }
}
