using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CaveRadio.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "songs",
                columns: table => new
                {
                    song_id = table.Column<Guid>(type: "uuid", nullable: false),
                    song_name = table.Column<string>(type: "text", nullable: true),
                    song_artist = table.Column<string>(type: "text", nullable: true),
                    song_genre = table.Column<string>(type: "text", nullable: true),
                    song_path = table.Column<string>(type: "text", nullable: true),
                    song_image = table.Column<string>(type: "text", nullable: true),
                    song_uri = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_songs", x => x.song_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "songs");
        }
    }
}
