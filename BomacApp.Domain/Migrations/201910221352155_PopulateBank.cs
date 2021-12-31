namespace BomacApp.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBank : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Banks (Name) VALUES ('Fidelity Bank')");
            Sql("INSERT INTO Banks (Name) VALUES ('Access Bank')");
        }
        
        public override void Down()
        {
        }
    }
}
