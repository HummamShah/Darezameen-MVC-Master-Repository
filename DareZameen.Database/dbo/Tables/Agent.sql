CREATE TABLE [dbo].[Agent]
(
	[Id] INT NOT NULL PRIMARY KEY Identity(1,1),
	[UserId] nvarchar(128) not null,
	[FisrtName] nvarchar(max),
	[LastName] nvarchar(max),
	[Contact1] nvarchar(max),
	[Contact2] nvarchar(max),
	[Address] nvarchar(max),
	[Designation] int,
	[Email] nvarchar(max),
	[ImageUrl] nvarchar(max),
	[IsActive] bit,
	[CreatedAt] datetime,
	[CreatedBy] nvarchar(max),
	[UpdatedAt] datetime,
	[UpdatedBy] nvarchar(max),
	Constraint [FK_Agent_User] foreign key ([UserId]) References [dbo].[AspNetUsers] ([Id])

)
