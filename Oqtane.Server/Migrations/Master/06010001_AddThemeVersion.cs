using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Oqtane.Databases.Interfaces;
using Oqtane.Migrations.EntityBuilders;
using Oqtane.Repository;

namespace Oqtane.Migrations.Master
{
    [DbContext(typeof(MasterDBContext))]
    [Migration("Master.06.01.00.01")]
    public class AddThemeVersion : MultiDatabaseMigration
    {
        public AddThemeVersion(IDatabase database) : base(database)
        {
        }

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var themeEntityBuilder = new ThemeEntityBuilder(migrationBuilder, ActiveDatabase);
            themeEntityBuilder.AddStringColumn("Version", 50, true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // not implemented
        }
    }
}
