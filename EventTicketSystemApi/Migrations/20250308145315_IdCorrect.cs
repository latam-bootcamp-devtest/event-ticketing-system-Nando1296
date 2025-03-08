using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventTicketSystemApi.Migrations
{
    /// <inheritdoc />
    public partial class IdCorrect : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Events",
                newName: "EventId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EventId",
                table: "Events",
                newName: "Id");
        }
    }
}
