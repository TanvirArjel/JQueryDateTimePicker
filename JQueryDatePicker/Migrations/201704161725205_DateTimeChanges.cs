namespace JQueryDatePicker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateTimeChanges : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "JoiningDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Students", "EnrollmentDateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "EnrollmentDateTime", c => c.DateTime());
            AlterColumn("dbo.Employees", "JoiningDate", c => c.DateTime());
        }
    }
}
