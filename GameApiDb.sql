CREATE DATABASE GameApiDb
GO

USE GameApiDb
GO

CREATE TABLE Games (
    Id INT PRIMARY KEY IDENTITY,
    Titulo VARCHAR(150) NOT NULL,
    Genero VARCHAR (50) NOT NULL,
	Descricao VARCHAR(250) NOT NULL,
    Disponivel BIT
	)
GO

INSERT INTO Game (Titulo, Genero, Descricao, Disponivel) 
VALUES ('League of legends', 'Moba' , 999999999)
GO

INSERT INTO Game (Titulo, Genero, Disponivel) 
VALUES ('Valorant', 'FPS', 99999999)
GO

-- UPDATE Game SET Titulo = 'Titulo A1' Where Id = 1;

 -- DELETE FROM Game WHERE Id = 1;

SELECT Id, Titulo, Genero, Descricao, Disponivel FROM Game
GO

CREATE TABLE Usuario (
    Id INT PRIMARY KEY IDENTITY,
    Email VARCHAR(255) NOT NULL UNIQUE,
    Senha VARCHAR(120) NOT NULL
)
GO

INSERT INTO Usuarios VALUES ('email@email.br', '1234')
GO

SELECT * FROM Usuarios WHERE email = 'email@email.br' AND senha = '1234'
GO

SELECT Id, Email FROM Usuario