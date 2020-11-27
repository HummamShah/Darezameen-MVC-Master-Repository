CREATE TABLE [dbo].[InventoryUtlities]
(
	[Id] INT NOT NULL PRIMARY KEY Identity(1,1),
	[InventoryId] int,
	[UtilityId] int,
	[IsActive] bit,
	[CreatedAt] datetime,
	[CreatedBy] nvarchar(max),
	[UpdatedAt] datetime,
	[UpdatedBy] nvarchar(max),
	Constraint [FK_InventoryUtility_Inventory] foreign key ([InventoryId]) References [dbo].[Inventory] ([Id]),
	Constraint [FK_InventoryUtility_Utility] foreign key ([UtilityId]) References [dbo].[Inventory] ([Id]),
)
