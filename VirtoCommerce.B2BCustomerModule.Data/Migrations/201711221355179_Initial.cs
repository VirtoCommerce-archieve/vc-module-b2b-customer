namespace VirtoCommerce.B2BCustomerModule.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Member", new[] { "Name" });
            CreateTable(
                "dbo.Company",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Organization", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.CompanyMember",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Title = c.String(maxLength: 128),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contact", t => t.Id)
                .Index(t => t.Id);
            
            //Convert all existing Organization records to Company
            Sql("INSERT INTO dbo.Company (Id) SELECT Id FROM dbo.Organization");
            //Convert all existing Contact records to CompanyMember
            Sql("INSERT INTO dbo.CompanyMember (Id,IsActive) SELECT Id,1 FROM dbo.Contact");

            CreateTable(
                "dbo.Department",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        ParentId = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Member", t => t.Id)
                .Index(t => t.Id);
            
            AlterColumn("dbo.Member", "Name", c => c.String(maxLength: 128,
                annotations: new Dictionary<string, AnnotationValues>
                {
                    { 
                        "Name",
                        new AnnotationValues(oldValue: null, newValue: "IndexAnnotation: { IsUnique: True }")
                    },
                }));
            CreateIndex("dbo.Member", "Name");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Department", "Id", "dbo.Member");
            DropForeignKey("dbo.CompanyMember", "Id", "dbo.Contact");
            DropForeignKey("dbo.Company", "Id", "dbo.Organization");
            DropIndex("dbo.Department", new[] { "Id" });
            DropIndex("dbo.CompanyMember", new[] { "Id" });
            DropIndex("dbo.Company", new[] { "Id" });
            DropIndex("dbo.Member", new[] { "Name" });
            AlterColumn("dbo.Member", "Name", c => c.String(maxLength: 128,
                annotations: new Dictionary<string, AnnotationValues>
                {
                    { 
                        "Name",
                        new AnnotationValues(oldValue: "IndexAnnotation: { IsUnique: True }", newValue: null)
                    },
                }));
            DropTable("dbo.Department");
            DropTable("dbo.CompanyMember");
            DropTable("dbo.Company");
            CreateIndex("dbo.Member", "Name");
        }
    }
}
