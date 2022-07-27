namespace EClerx.MVC.Day26.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewRowToBook : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Books(BookId, BookName) values ('B1001','Book1'),('B1002', 'Book 2'),('B1003', 'Book 3')");
        }
        
        public override void Down()
        {
        }
    }
}
