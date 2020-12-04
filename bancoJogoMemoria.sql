CREATE DATABASE JogoMemoria;

GO

USE JogoMemoria;

CREATE TABLE Placar(
	ID		INT	IDENTITY,
	Nome	VARCHAR(50),
	Score	INT,
	CONSTRAINT Pk_Placar_ID PRIMARY KEY(ID)
);

select * from Placar;