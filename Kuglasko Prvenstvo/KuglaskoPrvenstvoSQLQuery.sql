CREATE DATABASE KuglaskoPrvenstvo;
GO;


CREATE TABLE KuglaskiTim (
    KuglaskiTimID INT IDENTITY(1,1) PRIMARY KEY,
    ImeKuglaskogTima NVARCHAR(100) NOT NULL,
    Opis NVARCHAR(255) NULL,
    KapitenID INT NULL
);

CREATE TABLE Igrac (
    IgracID INT IDENTITY(1,1) PRIMARY KEY,
    Ime NVARCHAR(50) NOT NULL,
    Prezime NVARCHAR(50) NOT NULL,
    DatumRodjenja DATE NOT NULL,
    KuglaskiTimID INT
);

CREATE TABLE Kapiten (
	KapitenID INT IDENTITY(1,1) PRIMARY KEY,
	Ime NVARCHAR(50) NOT NULL,
	Prezime NVARCHAR(50) NOT NULL,
	DatumRodjenja DATE NOT NULL,
	KuglaskiTimID INT NULL
);

INSERT INTO KuglaskiTim (ImeKuglaskogTima, Opis, KapitenID)
VALUES 
('Zvezde',    'Prvi tim Zvezde', 1),
('Brikston',  'Drugi tim Brikston', 2),
('Strajkeri', 'Treći tim Strajkeri', 3),
('Kauboji',   'Četvrti tim Kauboji', 4);


INSERT INTO Igrac (Ime, Prezime, DatumRodjenja, KuglaskiTimID) VALUES
('Vuk', 'Vujović', '1995-08-08', 1),
('Sara', 'Simić', '1996-01-16', 1),
('Bojan', 'Simić', '1994-03-03', 1),
('Maja', 'Simić', '1993-04-29', 1),
('Andrej', 'Anđelković', '1992-10-07', 1),
('Natalija', 'Nikolić', '1995-12-12', 1),
('Filip', 'Filić', '1996-05-15', 1),
('Tamara', 'Tomić', '1997-07-21', 1),
('Dušan', 'Dukić', '1991-02-10', 1),
('Milica', 'Miletić', '1993-11-11', 1);

INSERT INTO Igrac (Ime, Prezime, DatumRodjenja, KuglaskiTimID) VALUES
('Jovan', 'Jovanović', '1993-09-12', 2),
('Nikola', 'Jovanović', '1991-03-11', 2),
('Ivana', 'Ilić', '1993-07-22', 2),
('Lazar', 'Lukić', '1994-09-08', 2),
('Jelena', 'Janković', '1992-05-17', 2),
('Dejan', 'Dimitrijević', '1990-11-01', 2),
('Marina', 'Mladenović', '1995-10-02', 2),
('Ognjen', 'Obradović', '1996-06-06', 2),
('Katarina', 'Kostić', '1997-04-04', 2),
('Aleksandar', 'Aksentijević', '1990-01-19', 2);

INSERT INTO Igrac (Ime, Prezime, DatumRodjenja, KuglaskiTimID) VALUES
('Sanja', 'Savić', '1995-11-20', 3),
('Petar', 'Petrović', '1992-07-05', 3),
('Miloš', 'Milenković', '1990-01-25', 3),
('Teodora', 'Tasić', '1996-06-14', 3),
('Aleksa', 'Aleksić', '1995-04-30', 3),
('Kristina', 'Kovačević', '1997-10-13', 3),
('Đorđe', 'Đukić', '1994-02-02', 3),
('Jasmina', 'Jović', '1996-09-09', 3),
('Mladen', 'Milić', '1993-03-03', 3),
('Biljana', 'Bojović', '1992-12-12', 3);

INSERT INTO Igrac (Ime, Prezime, DatumRodjenja, KuglaskiTimID) VALUES
('Tanja', 'Tanasković', '1998-02-25', 4),
('David', 'Davidović', '1996-04-18', 4),
('Marija', 'Marinković', '1994-06-30', 4),
('Filip', 'Filipović', '1992-03-19', 4),
('Katarina', 'Krstić', '1993-12-09', 4),
('Nemanja', 'Novaković', '1991-02-27', 4),
('Anja', 'Avramović', '1995-05-05', 4),
('Uroš', 'Urošević', '1990-10-10', 4),
('Stefan', 'Stanić', '1996-08-08', 4),
('Mira', 'Mirković', '1994-01-01', 4);



INSERT INTO Kapiten(Ime, Prezime, DatumRodjenja, KuglaskiTimID)
VALUES 
('Marko', 'Marković', '1995-05-20', 1),
('Ana', 'Anić', '1996-08-15', 2),
('Stefan', 'Stefanović', '1994-12-01', 3),
('Milica', 'Milinković', '1997-03-10', 4);

ALTER TABLE KuglaskiTim
ADD CONSTRAINT FK_KuglaskiTim_Kapiten
FOREIGN KEY (KapitenID) REFERENCES Kapiten(KapitenID);

ALTER TABLE Igrac
ADD CONSTRAINT FK_Igrac_KuglaskiTim
FOREIGN KEY (KuglaskiTimID) REFERENCES KuglaskiTim(KuglaskiTimID);

ALTER TABLE Kapiten
ADD CONSTRAINT FK_Kapiten_KuglaskiTim
FOREIGN KEY (KuglaskiTimID) REFERENCES KuglaskiTim(KuglaskiTimID);



