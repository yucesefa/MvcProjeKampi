namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "WriterAddress", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Writers", "WriterAddress");
        }
    }
}
