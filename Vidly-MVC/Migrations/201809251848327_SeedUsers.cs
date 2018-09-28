namespace Vidly_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'201bfe88-94b4-49dd-b62e-4c6952b269c7', N'guest@vidly.com', 0, N'AJto+/3llSMq6yAL67wqNQJt5ceMKdhgT/h6eO4X0ZDM69sQYBG+b6u1Bil/ufJsYw==', N'3798cffd-0fcf-43ad-8385-bd80aa6d1a66', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b74abe56-5ac8-4ae1-aae6-a0de2bba5d1a', N'admin@vidly.com', 0, N'AAjs6NEziJnGJZHUKh6EI5eatjrEGHTULTyTiAoszPjUYSFUxORMiewwLDR5ou7aFQ==', N'd9953af0-4c8b-4c7a-bd75-a72d3c11041c', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'4155f0d1-99fa-4306-8ee3-0d9bb85ab876', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b74abe56-5ac8-4ae1-aae6-a0de2bba5d1a', N'4155f0d1-99fa-4306-8ee3-0d9bb85ab876')
");
        }
        
        public override void Down()
        {
        }
    }
}
