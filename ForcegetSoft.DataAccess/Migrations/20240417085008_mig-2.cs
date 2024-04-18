using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ForcegetSoft.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Incoterms");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Incoterms",
                type: "varchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");
        }
    }
}
