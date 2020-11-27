CREATE TABLE [dbo].[AreaWisePrice]
(
	[Id] INT NOT NULL PRIMARY KEY Identity(1,1),
	[SpecialLocationId] int,
	[PropertyTypeId] int,
	[CategoryId] int,
	[Size] decimal(18,3),
	[AveragePrice] decimal(18,3),
	[PlusMinus] decimal(18,3),
	[CreatedAt] datetime,
	[CreatedBy] nvarchar(max),
	[UpdatedAt] datetime,
	[UpdatedBy] nvarchar(max),
	Constraint [FK_Area_SpecialLocation] foreign key ([SpecialLocationId]) References [dbo].[SpecialLocation] ([Id]),
	Constraint [FK_Area_PropertyType] foreign key ([PropertyTypeId]) References [dbo].[PropertyType] ([Id]),
	Constraint [FK_Area_Category] foreign key ([CategoryId]) References [dbo].[Category] ([Id])
)
