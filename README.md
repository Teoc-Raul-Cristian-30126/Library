# Library

## System Requirements
To run this application, you need the following:
- **SQL Server 2019**  
- **Visual Studio 2019** 

## Configure the database
To configure the database, run the following SQL script:

```sql
CREATE DATABASE BibliotecaDB;
GO

USE BibliotecaDB;
GO

-- Tabel editura
CREATE TABLE Editura (
	IdEditura INT IDENTITY(1,1) PRIMARY KEY,
	NumeEditura NVARCHAR(100) NOT NULL
);

-- Tabel autor
CREATE TABLE Autor (
	IdAutor INT IDENTITY(1,1) PRIMARY KEY,
	NumeAutor NVARCHAR(100) NOT NULL,
	PrenumeAutor NVARCHAR(100) NOT NULL
);

-- Tabel carte
CREATE TABLE Carte (
	IdCarte INT IDENTITY(1,1) PRIMARY KEY,
	Titlu NVARCHAR(100) NOT NULL,
	AnPublicare INT NOT NULL,
	Descriere NVARCHAR(500),
	IdEditura INT FOREIGN KEY REFERENCES Editura(IdEditura)
);

-- Tabel legatura intre carte si autor
CREATE TABLE CarteAutor (
	IdCarte INT FOREIGN KEY REFERENCES Carte(IdCarte) ON DELETE CASCADE,
	IdAutor INT FOREIGN KEY REFERENCES Autor(IdAutor) ON DELETE CASCADE,
	PRIMARY KEY (IdCarte, IdAutor)
);

-- Inserare de edituri in tabela editura
INSERT INTO Editura (NumeEditura) VALUES
('Arthur'),
('Brumar'),
('Corint'),
('Gama'),
('Gramar');

-- Inserare de autori in tabela autor
INSERT INTO Autor (NumeAutor, PrenumeAutor) VALUES
('Rebreanu', 'Liviu'),
('Calinescu', 'George'),
('Sadoveanu', 'Mihail'),
('Preda', 'Marin'),
('Eminescu', 'Mihai');
```

![Database Diagram](/Images/Database_diagram.PNG)
