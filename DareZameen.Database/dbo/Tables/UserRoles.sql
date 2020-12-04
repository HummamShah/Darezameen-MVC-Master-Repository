CREATE TABLE [dbo].[UserRoles]
(
	[Id] INT NOT NULL PRIMARY KEY identity(1,1),
	[UserId] nvarchar(128) NOT NULL,
	[Role] nvarchar(max),
	Constraint [FK_UserRole_User] foreign key ([UserId]) References [dbo].[AspNetUsers] ([Id]),
)
