﻿namespace EClerx.MVC.Day26.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveCategoryFromProduct : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "Category");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Category", c => c.String());
        }
    }
}
