namespace BomacApp.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateState : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO States (Name) VALUES ('Abia' )");
            Sql("INSERT INTO States ( Name ) VALUES ('Adamawa' )");
            Sql("INSERT INTO States ( Name ) VALUES ('Akwa Ibom' )");
            Sql("INSERT INTO States (Name) VALUES ('Anambra' )");
            Sql("INSERT INTO States ( Name ) VALUES ('Bauchi' )");
            Sql("INSERT INTO States ( Name ) VALUES ('Bayelsa' )");
            Sql("INSERT INTO States (Name) VALUES ('Benue' )");
            Sql("INSERT INTO States ( Name ) VALUES ('Borno' )");
            Sql("INSERT INTO States ( Name ) VALUES ('Cross River' )");
            Sql("INSERT INTO States (Name) VALUES ('Delta' )");
            Sql("INSERT INTO States ( Name ) VALUES ('Ebonyi' )");
            Sql("INSERT INTO States ( Name ) VALUES ('Edo' )");
            Sql("INSERT INTO States (Name) VALUES ('Ekiti' )");
            Sql("INSERT INTO States ( Name ) VALUES ('Enugu' )");
            Sql("INSERT INTO States ( Name ) VALUES ('Gombe' )");
            Sql("INSERT INTO States (Name) VALUES ('Imo' )");
            Sql("INSERT INTO States ( Name ) VALUES ('Jigawa' )");
            Sql("INSERT INTO States ( Name ) VALUES ('Kaduna' )");
            Sql("INSERT INTO States (Name) VALUES ('Kano' )");
            Sql("INSERT INTO States ( Name ) VALUES ('Katsina')");
            Sql("INSERT INTO States ( Name ) VALUES ('Kebbi' )");
            Sql("INSERT INTO States (Name) VALUES ('Kogi' )");
            Sql("INSERT INTO States ( Name ) VALUES ('Kwara' )");
            Sql("INSERT INTO States ( Name ) VALUES ('Lagos' )");
            Sql("INSERT INTO States (Name) VALUES ('Nasarawa' )");
            Sql("INSERT INTO States ( Name ) VALUES ('Niger' )");
            Sql("INSERT INTO States ( Name ) VALUES ('Ogun' )");
            Sql("INSERT INTO States (Name) VALUES ('Ondo' )");
            Sql("INSERT INTO States ( Name ) VALUES ('Osun' )");
            Sql("INSERT INTO States ( Name ) VALUES ('Plateau' )");
            Sql("INSERT INTO States (Name) VALUES ('Rivers' )");
            Sql("INSERT INTO States ( Name ) VALUES ('Sokoto' )");
            Sql("INSERT INTO States ( Name ) VALUES ('Taraba' )");
            Sql("INSERT INTO States (Name) VALUES ('Yobe' )");
            Sql("INSERT INTO States ( Name ) VALUES ('Zamfara' )");
            Sql("INSERT INTO States ( Name ) VALUES ('FCT Abuja')");
        }

        public override void Down()
        {
        }
    }
}
