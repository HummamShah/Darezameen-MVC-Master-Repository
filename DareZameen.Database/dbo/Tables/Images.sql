CREATE TABLE [dbo].[Images]
(
	[Id] INT NOT NULL PRIMARY KEY identity(1,1),
	[ImageUrl] nvarchar(max),
	[Description] nvarchar(max)
)
