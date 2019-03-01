namespace EnrollmentApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Reset1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Enrollments", "Notes", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Enrollments", "Notes", c => c.String(nullable: false));
        }
    }
}
