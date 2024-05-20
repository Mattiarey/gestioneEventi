USE MASTER

EXEC sp_attach_db @dbname = 'BluaReyEventi' , 

@filename1 = N'C:\Users\Utente\Desktop\BluaRey_Eventi\BluaReyEventi.mdf', 

@filename2 = N'C:\Users\Utente\Desktop\BluaRey_Eventi\BluaReyEventi.ldf'

USE BluaReyEventi
CREATE TABLE [User]
(
	Id_email INT IDENTITY (1,1) PRIMARY KEY,
	Email VARCHAR(255) NOT NULL,
	[Password] VARCHAR(255) NOT NULL
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
	FK_artista INT NOT NULL REFERENCES artisti(id_artista)
)