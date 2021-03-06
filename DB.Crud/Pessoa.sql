CREATE TABLE [dbo].[Pessoa]
(
	[Cpf] VARCHAR(14) NOT NULL, 
    [Nome] VARCHAR(50) NOT NULL, 
    [Carro] CHAR(1) NOT NULL, 
    [CarroRenavam] VARCHAR(10) NULL,
	PRIMARY KEY (Cpf),
)
