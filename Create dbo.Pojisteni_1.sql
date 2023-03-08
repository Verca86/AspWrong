USE [aspnet-AspBlog-7c6cd7c7-3d82-4e89-aaf8-2b5cae91b430]
GO

/****** Object: Table [dbo].[Pojisteni] Script Date: 08.03.2023 15:13:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Pojisteni] (
    [Id]                INT            IDENTITY (1, 1) NOT NULL,
    [PojistenyId]       INT            NULL,
    [Pojištění majetku] NVARCHAR (155) NULL,
    [Pojištení osob]    NVARCHAR (155) NULL,
    [Pojištění životní] NVARCHAR (155) NULL,
    [Pojištění úrazové] NVARCHAR (155) NULL,
    [Předmět pojištění] NVARCHAR (MAX) NULL,
    [Platnost od]       DATETIME       NULL,
    [Platnost do]       DATETIME       NULL,
    [Částka]            INT            NULL
);

INSERT INTO [Pojisteni] ([PojistenyId], [Pojištění majetku], [Pojištení osob], [Pojištění životní], [Pojištění úrazové], [Předmět pojištění], [Platnost od], [Platnost do], [Částka] ) VALUES
(1, 'Ano','Ne', 'Ne', 'Ne', 'Byt', 2021-02-21, 2029-02-21,1000000);

SELECT [Předmět pojištění], [Příjmení]
FROM [Pojisteni]
JOIN [Article1] ON [Pojisteni].[PojistenyId] = [Article1].[Id]
ORDER BY [Příjmení];
