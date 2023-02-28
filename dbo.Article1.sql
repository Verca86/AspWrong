CREATE TABLE [dbo].[Article1] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [Jméno]           NVARCHAR (MAX) NOT NULL,
    [Příjmení]        NVARCHAR (MAX) NOT NULL,
    [Adresa]          NVARCHAR (MAX) NOT NULL,
    [Obec]            NVARCHAR (MAX) NOT NULL,
    [PSČ]             INT            NOT NULL,
    [Telefon] NVARCHAR (MAX) NOT NULL,
    [Email] NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Article1] PRIMARY KEY CLUSTERED ([Id] ASC)
);

