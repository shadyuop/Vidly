namespace VidlyT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SpecifyingGenreNameAccordingRefrence : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET GenreName = 'Comedy' WHERE Genre = 1");
            Sql("UPDATE Movies SET GenreName = 'Action' WHERE Genre = 2");
            Sql("UPDATE Movies SET GenreName = 'Thriller' WHERE Genre = 3");
            Sql("UPDATE Movies SET GenreName = 'Documentry' WHERE Genre = 4");
        }
        
        public override void Down()
        {
        }
    }
}
