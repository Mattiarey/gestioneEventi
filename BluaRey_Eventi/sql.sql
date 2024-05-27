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
CREATE TABLE categorie
(
	id_categoria INT IDENTITY (1,1) PRIMARY KEY,
	nome VARCHAR(255) NOT NULL
)

USE BluaReyEventi
CREATE TABLE eventi
(
	id_evento INT IDENTITY (1,1) PRIMARY KEY,
	titolo VARCHAR(255) NOT NULL,
	luogo VARCHAR(255) NOT NULL,
	provincia VARCHAR(2) NOT NULL,
	[data] DATE NOT NULL,
	FK_artista INT REFERENCES artisti(id_artista),
	FK_categorie INT REFERENCES categorie(id_categoria)
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

INSERT INTO categorie(nome) VALUES ('Cultura'), ('Musica'), ('Tecnologia'), ('Sportivi')