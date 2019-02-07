namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUpdatedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"



INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'7602eeef-319a-4eae-aece-7e334c6da148', N'CanManageMovies')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'27283c18-2d38-4076-bbdf-dacdb42116a0', N'CanManageMoviesAndCustomers')


INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [IdentityNumber]) VALUES (N'be3e811c-e1ab-4a23-aba7-2f1e3038e999', N'admin@vrs.com', 0, N'AFPscTATeffNqF8Gd7tNuOPn7njhiexaWrFQqhmwS3CwQDx5wWZsu8RISSUGA8Hgkg==', N'3981402a-d2d8-4f11-a2aa-4cf30de7bd90', NULL, 0, 0, NULL, 1, 0, N'admin@vrs.com', 99082110738)
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [IdentityNumber]) VALUES (N'eb553586-5560-4927-934c-2fe35e976100', N'Pracownik1!@gmail.com', 0, N'ANotN6U2Ufu6Uhb0OOm7jUxqtMDfHoUxDodKqUtwO4vA81Npz5UV2KLuvL9xEQfo0g==', N'dd5a1885-76b7-4e8e-ad3a-009892b8308b', NULL, 0, 0, NULL, 1, 0, N'Pracownik1!@gmail.com', 97082110242)
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [IdentityNumber]) VALUES (N'e5a63721-c1e2-4047-b987-9cd617718958', N'admin@vidly.com', 0, N'AIQHUrMeQFihj6MjK5rUePx5yQi3N+A9YIozx8oo/9OJKKLdlxSZ0BzvKaJ3aWL2VQ==', N'df5e66a5-0e4c-4bf1-a737-7b1546dee56d', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com', 0)

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'be3e811c-e1ab-4a23-aba7-2f1e3038e999', N'27283c18-2d38-4076-bbdf-dacdb42116a0')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e5a63721-c1e2-4047-b987-9cd617718958', N'7602eeef-319a-4eae-aece-7e334c6da148')

            ");
        }
        
        public override void Down()
        {
        }
    }
}
