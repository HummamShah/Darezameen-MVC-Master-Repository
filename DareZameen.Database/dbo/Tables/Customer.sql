CREATE TABLE [dbo].[Customer] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (MAX) NULL,
    [Contact1] NVARCHAR (MAX) NULL,
    [Contact2] NVARCHAR (MAX) NULL,
    [Address]  NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ([Id] ASC)
);

