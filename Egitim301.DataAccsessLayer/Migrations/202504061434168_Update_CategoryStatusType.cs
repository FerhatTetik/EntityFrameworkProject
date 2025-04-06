namespace Egitim301.DataAccsessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_CategoryStatusType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "CategoryStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Categories", "CategoryStatus", c => c.String());
        }
    }
}
