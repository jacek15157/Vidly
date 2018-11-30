namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4ebf9240-6d10-4fed-b00b-6e2efcb1c713', N'jacek15157@gmail.com', 0, N'AAi8z+cOp2lzdt/f2Knrv8eDz+rkFwz7FlSIyOh/ZSATznLdupbkZVKXk6dpSHGYQA==', N'e2685735-d6d0-40df-8798-9188311e1332', NULL, 0, 0, NULL, 1, 0, N'jacek15157@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e5a63721-c1e2-4047-b987-9cd617718958', N'admin@vidly.com', 0, N'AHc55/n7GIfc8t3k5uUN4FDh3OFdinKPJQAYlN+r4BJMa0PR27y34gyREmNa31/k+w==', N'df5e66a5-0e4c-4bf1-a737-7b1546dee56d', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'7602eeef-319a-4eae-aece-7e334c6da148', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e5a63721-c1e2-4047-b987-9cd617718958', N'7602eeef-319a-4eae-aece-7e334c6da148')
");
        }
        
        public override void Down()
        {
        }
    }
}
