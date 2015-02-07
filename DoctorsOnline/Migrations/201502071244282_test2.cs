namespace DoctorsOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AppointmentNo = c.Int(nullable: false),
                        AppointmentTime = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        PatientId = c.Int(nullable: false),
                        DoctorsInfo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .ForeignKey("dbo.DoctorsInfoes", t => t.DoctorsInfo_Id)
                .Index(t => t.PatientId)
                .Index(t => t.DoctorsInfo_Id);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PatientName = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        ActionDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Hospital_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Hospitals", t => t.Hospital_Id)
                .Index(t => t.Hospital_Id);
            
            CreateTable(
                "dbo.Areas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AreaName = c.String(),
                        Thana_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Thanas", t => t.Thana_Id)
                .Index(t => t.Thana_Id);
            
            CreateTable(
                "dbo.Hospitals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HospitalName = c.String(),
                        TotalDoctor = c.Int(nullable: false),
                        Compliance = c.String(),
                        Area_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Areas", t => t.Area_Id)
                .Index(t => t.Area_Id);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepartmentName = c.String(),
                        Hospital_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Hospitals", t => t.Hospital_Id)
                .Index(t => t.Hospital_Id);
            
            CreateTable(
                "dbo.DoctorsInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DoctorName = c.String(),
                        Qualification = c.String(),
                        Specialist = c.String(),
                        Gender = c.String(),
                        VisitingTime = c.DateTime(nullable: false),
                        Department_Id = c.Int(),
                        Hospital_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.Department_Id)
                .ForeignKey("dbo.Hospitals", t => t.Hospital_Id)
                .Index(t => t.Department_Id)
                .Index(t => t.Hospital_Id);
            
            CreateTable(
                "dbo.Thanas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ThanaName = c.String(),
                        DistrictId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Districts", t => t.DistrictId, cascadeDelete: true)
                .Index(t => t.DistrictId);
            
            CreateTable(
                "dbo.Districts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DistrictName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        FullName = c.String(),
                        Age = c.Int(nullable: false),
                        Gender = c.String(),
                        NId = c.Int(nullable: false),
                        Address = c.String(),
                        Phone = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        ActionDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserPasswords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SlNo = c.Int(nullable: false),
                        Password = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleName = c.Int(),
                        CreateDate = c.DateTime(nullable: false),
                        ActionDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserRoles", "User_Id", "dbo.Users");
            DropForeignKey("dbo.UserPasswords", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserInfoes", "UserId", "dbo.Users");
            DropForeignKey("dbo.Thanas", "DistrictId", "dbo.Districts");
            DropForeignKey("dbo.Areas", "Thana_Id", "dbo.Thanas");
            DropForeignKey("dbo.Patients", "Hospital_Id", "dbo.Hospitals");
            DropForeignKey("dbo.Departments", "Hospital_Id", "dbo.Hospitals");
            DropForeignKey("dbo.DoctorsInfoes", "Hospital_Id", "dbo.Hospitals");
            DropForeignKey("dbo.DoctorsInfoes", "Department_Id", "dbo.Departments");
            DropForeignKey("dbo.Appointments", "DoctorsInfo_Id", "dbo.DoctorsInfoes");
            DropForeignKey("dbo.Hospitals", "Area_Id", "dbo.Areas");
            DropForeignKey("dbo.Appointments", "PatientId", "dbo.Patients");
            DropIndex("dbo.UserRoles", new[] { "User_Id" });
            DropIndex("dbo.UserPasswords", new[] { "UserId" });
            DropIndex("dbo.UserInfoes", new[] { "UserId" });
            DropIndex("dbo.Thanas", new[] { "DistrictId" });
            DropIndex("dbo.DoctorsInfoes", new[] { "Hospital_Id" });
            DropIndex("dbo.DoctorsInfoes", new[] { "Department_Id" });
            DropIndex("dbo.Departments", new[] { "Hospital_Id" });
            DropIndex("dbo.Hospitals", new[] { "Area_Id" });
            DropIndex("dbo.Areas", new[] { "Thana_Id" });
            DropIndex("dbo.Patients", new[] { "Hospital_Id" });
            DropIndex("dbo.Appointments", new[] { "DoctorsInfo_Id" });
            DropIndex("dbo.Appointments", new[] { "PatientId" });
            DropTable("dbo.UserRoles");
            DropTable("dbo.UserPasswords");
            DropTable("dbo.Users");
            DropTable("dbo.UserInfoes");
            DropTable("dbo.Districts");
            DropTable("dbo.Thanas");
            DropTable("dbo.DoctorsInfoes");
            DropTable("dbo.Departments");
            DropTable("dbo.Hospitals");
            DropTable("dbo.Areas");
            DropTable("dbo.Patients");
            DropTable("dbo.Appointments");
        }
    }
}
