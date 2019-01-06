namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5f8dca93-bb0f-4213-8cc0-b7615be02eff', N'guest@vidly.com', 0, N'AFD3TSGPUV6NMhzEfuohs+RlszfZ2+9qtsAoG0PKBnGJ9cX81nw4FcG0pV2WP1KqmA==', N'0c09d55f-def1-46fc-94f3-2c123a016565', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'bf3ad3ae-1ee6-41a8-b078-84905e043fb8', N'admin@vidly.com', 0, N'AH34QrkhpNyWKkpapLglLlGXm7w0zeYRUiEwxuH5yswYmi4GcWJ5f+fU60YQaOxa1w==', N'6423e4fe-bc51-4093-81db-caa0bec66d1c', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'fd901e0a-21bc-4a53-b4f4-169a0992eed4', N'canManageMovie')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'bf3ad3ae-1ee6-41a8-b078-84905e043fb8', N'fd901e0a-21bc-4a53-b4f4-169a0992eed4')

");
        }
        
        public override void Down()
        {
        }
    }
}
