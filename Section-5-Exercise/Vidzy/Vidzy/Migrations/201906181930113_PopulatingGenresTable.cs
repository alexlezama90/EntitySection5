namespace Vidzy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatingGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Name) VALUES ('Comedy') ");
            Sql("INSERT INTO Genres (Name) VALUES ('Romantic') ");
            Sql("INSERT INTO Genres (Name) VALUES ('Horror') ");
            Sql("INSERT INTO Genres (Name) VALUES ('Action') ");

        }

        public override void Down()
        {
            Sql("TRUNCATE TABLE Genres");
        }
    }
}
