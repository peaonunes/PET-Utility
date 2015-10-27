CREATE TABLE [dbo].[Ideas]
(
	[Id] INT NOT NULL IDENTITY(1,1), 
    [Title] NVARCHAR(255) NULL, 
    [Description] NVARCHAR(MAX) NULL, 
    [PETianoId] INT NULL, 
    CONSTRAINT [PK_dbo.Ideas] PRIMARY KEY CLUSTERED ([Id] ASC) ON [PRIMARY],
	CONSTRAINT [FK_dbo.Ideas_dbo.PETiano_PETianoId] FOREIGN KEY([PETianoId]) REFERENCES [dbo].[PETiano] ([Id])
)
