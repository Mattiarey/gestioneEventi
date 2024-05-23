CREATE DATABASE BluaReyEventi

USE BluaReyEventi
CREATE TABLE [User]
(
	Id_email INT IDENTITY (1,1) PRIMARY KEY,
	Email VARCHAR(255) NOT NULL,
	[Password] VARCHAR(255) NOT NULL,
	Nickname VARCHAR(255) NOT NULL,
	Nome VARCHAR(255) NOT NULL,
	Cognome VARCHAR(255) NOT NULL
)

USE BluaReyEventi
CREATE TABLE artisti
(
	id_artista INT IDENTITY (1,1) PRIMARY KEY,
	nome VARCHAR(255) NOT NULL
)

USE BluaReyEventi
CREATE TABLE eventi
(
	id_evento INT IDENTITY (1,1) PRIMARY KEY,
	titolo VARCHAR(255) NOT NULL,
	luogo VARCHAR(255) NOT NULL,
	[data] DATE NOT NULL,
	FK_artista INT REFERENCES artisti(id_artista)
)

USE BluaReyEventi
CREATE TABLE post
(
	id_post INT IDENTITY (1,1) PRIMARY KEY,
	titolo VARCHAR(255) NOT NULL,
	commento VARCHAR(255) NOT NULL,
	voto INT NOT NULL,
	FK_evento INT NOT NULL REFERENCES eventi(id_evento)
)