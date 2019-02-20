namespace EnrollmentApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNew : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Courses", "Title", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.Enrollments", "Grade", c => c.String(nullable: false));
            AlterColumn("dbo.Enrollments", "AssignedCampus", c => c.String(nullable: false));
            AlterColumn("dbo.Enrollments", "EnrollmentSemester", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Students", "LastName", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "LastName", c => c.String());
            AlterColumn("dbo.Students", "FirstName", c => c.String());
            AlterColumn("dbo.Enrollments", "EnrollmentSemester", c => c.String());
            AlterColumn("dbo.Enrollments", "AssignedCampus", c => c.String());
            AlterColumn("dbo.Enrollments", "Grade", c => c.String());
            AlterColumn("dbo.Courses", "Title", c => c.String());
        }
    }
}
