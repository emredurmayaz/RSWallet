namespace RSWallet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedSector : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sectors",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Code = c.String(nullable: false, maxLength: 20),
                        Name = c.String(nullable: false, maxLength: 50),
                        IsDeleted = c.Boolean(nullable: false),
                        CreateAt = c.DateTime(nullable: false),
                        CreateBy = c.Guid(),
                        UpdateAt = c.DateTime(),
                        UpdateBy = c.Guid(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sectors");
        }
    }
}
