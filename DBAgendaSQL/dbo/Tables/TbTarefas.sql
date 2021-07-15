CREATE TABLE [dbo].[TbTarefas] (
    [Id]                  INT          IDENTITY (1, 1) NOT NULL,
    [Titulo]              VARCHAR (50) NOT NULL,
    [Prioridade]          INT          NOT NULL,
    [DataAbertura]        DATE         NOT NULL,
    [DataConclusao]       DATE         NULL,
    [PercentualConclusao] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

