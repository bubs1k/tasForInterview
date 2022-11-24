CREATE TABLE [dbo].[Test] (
    [Id]              INT           IDENTITY (1, 1) NOT NULL,
    [Name]            NVARCHAR (50) NULL,
    [Surname]         NVARCHAR (50) NULL,
    [Birthday]        DATE          NULL,
    [Mesto_rozhdenya] NVARCHAR (50) NULL,
    [Phone]           NVARCHAR (50) NULL,
    [Email]           NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);