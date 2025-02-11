namespace WEBPEROJEM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabase : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PersonelBilgileris", "YakinAdSoyad", c => c.String(maxLength: 35));
            AlterColumn("dbo.PersonelBilgileris", "MedeniHal", c => c.String());
            DropColumn("dbo.PersonelBilgileris", "YakinAdSoyad");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PersonelBilgileris", "YakinAdSoyad", c => c.String(maxLength: 35));
            AlterColumn("dbo.PersonelBilgileris", "MedeniHal", c => c.Boolean(nullable: false));
            DropColumn("dbo.PersonelBilgileris", "YakinAdSoyad");
        }
    }
}
