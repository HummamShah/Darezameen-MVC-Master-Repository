CREATE TABLE [dbo].[Reference]
(
	[Id] INT NOT NULL PRIMARY KEY Identity(1,1),
	[Type] int,
	[Name] nvarchar(max),
	[Email] nvarchar(max),
	[Contact1] nvarchar(max),
	[Contact2] nvarchar(max),
)
