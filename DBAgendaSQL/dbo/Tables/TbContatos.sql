CREATE TABLE [dbo].[TbContatos] (
    [Id]       INT        IDENTITY (1, 1) NOT NULL,
    [nome]     NCHAR (50) NOT NULL,
    [email]    NCHAR (50) NOT NULL,
    [telefone] INT        NOT NULL,
    [empresa]  NCHAR (50) NOT NULL,
    [cargo]    NCHAR (50) NOT NULL,
    CONSTRAINT [PK__tmp_ms_x__3214EC07E52503DA] PRIMARY KEY CLUSTERED ([Id] ASC)
);

