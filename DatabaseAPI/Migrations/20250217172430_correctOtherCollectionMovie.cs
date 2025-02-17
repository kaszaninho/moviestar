using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseAPI.Migrations
{
    /// <inheritdoc />
    public partial class correctOtherCollectionMovie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActorMovie_Movie_ActorMoviesId",
                table: "ActorMovie");

            migrationBuilder.DropForeignKey(
                name: "FK_Director_Movie_MovieId",
                table: "Director");

            migrationBuilder.DropIndex(
                name: "IX_Director_MovieId",
                table: "Director");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ActorMovie",
                table: "ActorMovie");

            migrationBuilder.DropIndex(
                name: "IX_ActorMovie_ActorsId",
                table: "ActorMovie");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Director");

            migrationBuilder.RenameColumn(
                name: "ActorMoviesId",
                table: "ActorMovie",
                newName: "MoviesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ActorMovie",
                table: "ActorMovie",
                columns: new[] { "ActorsId", "MoviesId" });

            migrationBuilder.CreateTable(
                name: "DirectorMovie",
                columns: table => new
                {
                    DirectorsId = table.Column<int>(type: "int", nullable: false),
                    MoviesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectorMovie", x => new { x.DirectorsId, x.MoviesId });
                    table.ForeignKey(
                        name: "FK_DirectorMovie_Director_DirectorsId",
                        column: x => x.DirectorsId,
                        principalTable: "Director",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DirectorMovie_Movie_MoviesId",
                        column: x => x.MoviesId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActorMovie_MoviesId",
                table: "ActorMovie",
                column: "MoviesId");

            migrationBuilder.CreateIndex(
                name: "IX_DirectorMovie_MoviesId",
                table: "DirectorMovie",
                column: "MoviesId");

            migrationBuilder.AddForeignKey(
                name: "FK_ActorMovie_Movie_MoviesId",
                table: "ActorMovie",
                column: "MoviesId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActorMovie_Movie_MoviesId",
                table: "ActorMovie");

            migrationBuilder.DropTable(
                name: "DirectorMovie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ActorMovie",
                table: "ActorMovie");

            migrationBuilder.DropIndex(
                name: "IX_ActorMovie_MoviesId",
                table: "ActorMovie");

            migrationBuilder.RenameColumn(
                name: "MoviesId",
                table: "ActorMovie",
                newName: "ActorMoviesId");

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Director",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ActorMovie",
                table: "ActorMovie",
                columns: new[] { "ActorMoviesId", "ActorsId" });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 1,
                column: "MovieId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 2,
                column: "MovieId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Director_MovieId",
                table: "Director",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_ActorMovie_ActorsId",
                table: "ActorMovie",
                column: "ActorsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ActorMovie_Movie_ActorMoviesId",
                table: "ActorMovie",
                column: "ActorMoviesId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Director_Movie_MovieId",
                table: "Director",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id");
        }
    }
}
