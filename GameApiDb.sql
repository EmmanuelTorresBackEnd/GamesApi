CREATE DATABASE GameApiDb
GO

USE GameApiDb
GO

CREATE TABLE Game (
    Id INT PRIMARY KEY IDENTITY,
    Titulo VARCHAR(150) NOT NULL,
    Genero VARCHAR (50) NOT NULL,
	Descricao VARCHAR(250) NOT NULL,
    Disponivel BIT
	)
GO

INSERT INTO Game (Titulo, Genero, Descricao, Disponivel) 
VALUES ('League of legends', 'Moba' ,'League of Legends � um jogo em equipes com mais de 140 Campe�es com os quais voc� pode fazer jogadas insanas. Jogue agora, � gr�tis!' , 999999999)
GO

INSERT INTO Game (Titulo, Genero, Descricao, Disponivel) 
VALUES ('Valorant', 'FPS', 'Um jogo de tiro competitivo 5x5 com personagens da Riot Games. Dispon�vel no mundo todo. Domine v�rias armas e habilidades diferentes e mostre do que � capaz. Alta letalidade. Esports. Precis�o. Jogo em Equipe. 5x5. Gratuito. Novos modos. Habilidades. Ranqueadas.' , 999999999)
GO

-- UPDATE Game SET Titulo = 'Titulo A1' Where Id = 1;

 -- DELETE FROM Game WHERE Id = 1;

SELECT Id, Titulo, Genero, Descricao, Disponivel FROM Game
GO

CREATE TABLE Usuario (
    Id INT PRIMARY KEY IDENTITY,
    Email VARCHAR(255) NOT NULL UNIQUE,
    Senha VARCHAR(120) NOT NULL,
	Tipo INT NOT NULL
)
GO

INSERT INTO Usuario VALUES ('email@email.br', '12345' , 0)
GO

SELECT * FROM Usuario WHERE email = 'email@email.br' AND senha = '12345'
GO

SELECT Id, Email, Senha, Tipo FROM Usuario