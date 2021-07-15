CREATE TABLE [dbo].[TbCompromissos] (
    [Id]         BIGINT        IDENTITY (1, 1) NOT NULL,
    [Assunto]    NCHAR (30)    NOT NULL,
    [Local]      NCHAR (40)    NOT NULL,
    [Id_Contato] INT           NULL,
    [DataInicio] DATETIME2 (7) NOT NULL,
    [DataFinal]  DATETIME2 (7) NOT NULL,
    CONSTRAINT [PK__TbCompro__3214EC0750C05912] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK__TbComprom__Id_Co__72C60C4A] FOREIGN KEY ([Id_Contato]) REFERENCES [dbo].[TbContatos] ([Id])
);

