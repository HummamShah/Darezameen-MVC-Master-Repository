CREATE TABLE [dbo].[AssignedLocation]
(
	[Id] INT Primary Key IDENTITY (1, 1) NOT NULL,
	[SpecialLocationId] int not null,
	[AgentId] int not null,
	[IsActive] bit,
	  [CreatedAt] datetime,
  [CreatedBy] nvarchar(max),
  [UpdatedAt] datetime,
  [UpdatedBy] nvarchar(max),
	Constraint [FK_AL_SL] foreign key ([SpecialLocationId]) References [dbo].[SpecialLocation] ([Id]),
	Constraint [FK_AL_Agent] foreign key ([AgentId]) References [dbo].[Agent] ([Id])
)
