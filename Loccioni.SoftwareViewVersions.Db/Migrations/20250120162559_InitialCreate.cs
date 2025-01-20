using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Loccioni.SoftwareViewVersions.Db.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /*migrationBuilder.CreateTable(
                name: "benches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdPlant = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    UrlGit = table.Column<string>(type: "TEXT", nullable: false),
                    Tags = table.Column<string>(type: "TEXT", nullable: false),
                    Logo = table.Column<byte[]>(type: "BLOB", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_benches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    RagioneFiscale = table.Column<string>(type: "TEXT", nullable: false),
                    Tags = table.Column<string>(type: "TEXT", nullable: false),
                    Logo = table.Column<byte[]>(type: "BLOB", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "plants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdClient = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    State = table.Column<string>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    Latitude = table.Column<double>(type: "REAL", nullable: false),
                    Longitude = table.Column<double>(type: "REAL", nullable: false),
                    Tags = table.Column<string>(type: "TEXT", nullable: false),
                    Logo = table.Column<byte[]>(type: "BLOB", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_plants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "servers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    IdPlant = table.Column<int>(type: "INTEGER", nullable: false),
                    UrlGit = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_servers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "serverVersions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdServer = table.Column<int>(type: "INTEGER", nullable: false),
                    Version = table.Column<string>(type: "TEXT", nullable: false),
                    Supervisor = table.Column<string>(type: "TEXT", nullable: false),
                    Configurator = table.Column<string>(type: "TEXT", nullable: false),
                    WorkerHealth = table.Column<string>(type: "TEXT", nullable: false),
                    WorkerModels = table.Column<string>(type: "TEXT", nullable: false),
                    WorkerPrograms = table.Column<string>(type: "TEXT", nullable: false),
                    WorkerResource = table.Column<string>(type: "TEXT", nullable: false),
                    WorkerResults = table.Column<string>(type: "TEXT", nullable: false),
                    WorkerTopology = table.Column<string>(type: "TEXT", nullable: false),
                    WorkerWip = table.Column<string>(type: "TEXT", nullable: false),
                    UploaderHealth = table.Column<string>(type: "TEXT", nullable: false),
                    UploaderReport = table.Column<string>(type: "TEXT", nullable: false),
                    Link = table.Column<string>(type: "TEXT", nullable: false),
                    Tags = table.Column<string>(type: "TEXT", nullable: false),
                    RefPerson = table.Column<string>(type: "TEXT", nullable: false),
                    DateUpload = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_serverVersions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "updates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdBench = table.Column<int>(type: "INTEGER", nullable: false),
                    RefPerson = table.Column<string>(type: "TEXT", nullable: false),
                    DateUpload = table.Column<string>(type: "TEXT", nullable: false),
                    Projects = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_updates", x => x.Id);
                });*/
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "benches");

            migrationBuilder.DropTable(
                name: "clients");

            migrationBuilder.DropTable(
                name: "plants");

            migrationBuilder.DropTable(
                name: "servers");

            migrationBuilder.DropTable(
                name: "serverVersions");

            migrationBuilder.DropTable(
                name: "updates");
        }
    }
}
