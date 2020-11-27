CREATE TABLE [dbo].[Room]
(
	[Id] INT NOT NULL PRIMARY KEY Identity(1,1),
	[InventoryId] int ,
	[RoomType] int,
    [Size] decimal(18,3),
	[Windows] int,
	[IsAttachedBath] bit,
	[AttachedBathId] int,
	[ImageUrl] nvarchar(max),
	[Description] nvarchar(max),
	[CreatedAt] datetime,
	[CreatedBy] nvarchar(max),
	[UpdatedAt] datetime,
	[UpdatedBy] nvarchar(max),
	Constraint [FK_Room_Inventory] foreign key ([InventoryId]) References [dbo].[Inventory] ([Id]),
    Constraint [FK_Room_Room] foreign key ([AttachedBathId]) References [dbo].[Room] ([Id])
)
