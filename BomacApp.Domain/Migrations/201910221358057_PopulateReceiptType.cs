namespace BomacApp.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateReceiptType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO ReceiptTypes (Name) VALUES ('Invoice')");
            Sql("INSERT INTO ReceiptTypes (Name) VALUES ('Way Bill')");
        }
        
        public override void Down()
        {
        }
    }
}
