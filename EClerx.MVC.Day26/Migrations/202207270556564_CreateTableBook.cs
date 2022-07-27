namespace EClerx.MVC.Day26.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableBook : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookId = c.String(nullable: false, maxLength: 128),
                        BookName = c.String(),
                    })
                .PrimaryKey(t => t.BookId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Books");
        }
    }
}
