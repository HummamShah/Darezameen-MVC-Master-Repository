CREATE TABLE [dbo].[SpecialLocation]
(
	[Id] INT Primary Key IDENTITY (1, 1) NOT NULL,
	[Name] nvarchar(max),
	[Description] nvarchar(max),
	[TotalBlocks] int,
	[TotalResidential] int,
	[TotalCommercial] int,
	  [CreatedAt] datetime,
  [CreatedBy] nvarchar(max),
  [UpdatedAt] datetime,
  [UpdatedBy] nvarchar(max)
)
