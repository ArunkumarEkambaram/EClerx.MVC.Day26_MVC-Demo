namespace EClerx.MVC.Day26.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DefaultDate : DbMigration
    {
        public override void Up()
        {
           // AlterColumn("dbo.Customers", "DateOfBirth", c => c.DateTime(defaultValueSql: "getdate()"));
            
        }
        
        public override void Down()
        {
        }
    }
}
