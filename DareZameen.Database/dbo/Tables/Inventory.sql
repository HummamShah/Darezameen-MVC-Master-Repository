CREATE TABLE [dbo].[Inventory]
(
  [Id] INT Primary Key IDENTITY (1, 1) NOT NULL,
  [AgentId] int null,
  [ReferenceId] int null,
  [CategoryId] int null,
  [PropertyTypeId] int null,
  [Size] decimal(18,3),
  [Address] nvarchar(max),
  [Demand] decimal (18,3),
  [Description] nvarchar(max),
  [Status] int,
  [QAComments] nvarchar(max),
  [IsApproved] bit,
  [TotalFloors] int,
  [AtFloor] int,
  [View] int,
  [IsRoofAvailable] bit,
  [RoofSize] decimal (18,3),
  [IsBasementAvailable] bit,
  [BasementSize] decimal(18,3),
  [SpecialLocationId] int,
  [CreatedAt] datetime,
  [CreatedBy] nvarchar(max),
  [UpdatedAt] datetime,
  [UpdatedBy] nvarchar(max),
  Constraint [FK_Inventory_Agent] foreign key ([AgentId]) References [dbo].[Agent] ([Id]),
    Constraint [FK_Inventory_Reference] foreign key ([ReferenceId]) References [dbo].[Reference] ([Id]),
      Constraint [FK_Inventory_Category] foreign key ([CategoryId]) References [dbo].[Category] ([Id]),
        Constraint [FK_Inventory_PropertyType] foreign key ([PropertyTypeId]) References [dbo].[PropertyType] ([Id])

)

