-- Vytvoření nového databázového souboru SQL serveru Vyuka.mdf
CREATE DATABASE Vyuka;
GO

-- Použití nově vytvořené databáze
USE Vyuka;
GO

-- Vytvoření tabulky SeznamPredmetu
CREATE TABLE SeznamPredmetu (
    Zkratka NVARCHAR(10) PRIMARY KEY,
    NazevPredmetu NVARCHAR(100) NOT NULL
);
GO

-- Vytvoření tabulky SeznamStudentu
CREATE TABLE SeznamStudentu (
    IDStudenta INT PRIMARY KEY,
    Jmeno NVARCHAR(50) NOT NULL,
    Prijmeni NVARCHAR(50) NOT NULL,
    DatumNarozeni DATE NOT NULL
);
GO

-- Vytvoření spojovací tabulky pro vztah "mnoho k mnoha" mezi studenty a předměty
CREATE TABLE Zapis (
    IDStudenta INT,
    ZkratkaPredmetu NVARCHAR(10),
    FOREIGN KEY (IDStudenta) REFERENCES SeznamStudentu(IDStudenta),
    FOREIGN KEY (ZkratkaPredmetu) REFERENCES SeznamPredmetu(Zkratka),
    PRIMARY KEY (IDStudenta, ZkratkaPredmetu)
);
GO

-- Vytvoření tabulky Hodnoceni
CREATE TABLE Hodnoceni (
    IDStudenta INT,
    ZkratkaPredmetu NVARCHAR(10),
    DatumHodnoceni DATE,
    Hodnoceni INT,
    PRIMARY KEY (IDStudenta, ZkratkaPredmetu),
    FOREIGN KEY (IDStudenta) REFERENCES SeznamStudentu(IDStudenta),
    FOREIGN KEY (ZkratkaPredmetu) REFERENCES SeznamPredmetu(Zkratka)
);
GO

-- Naplnění tabulky SeznamPredmetu
INSERT INTO SeznamPredmetu (Zkratka, NazevPredmetu) VALUES
('MAT', 'Matematika'),
('CJL', 'Český jazyk a literatura'),
('INF', 'Informatika');

-- Naplnění tabulky SeznamStudentu
INSERT INTO SeznamStudentu (IDStudenta, Jmeno, Prijmeni, DatumNarozeni) VALUES
(1, 'Jan', 'Novák', '2000-01-15'),
(2, 'Eva', 'Nováková', '2001-03-20'),
(3, 'Petr', 'Svoboda', '2000-05-10'),
(4, 'Marie', 'Svobodová', '2001-07-25');

-- Naplnění tabulky Zapis
INSERT INTO Zapis (IDStudenta, ZkratkaPredmetu) VALUES
(1, 'MAT'),
(1, 'CJL'),
(2, 'MAT'),
(3, 'INF'),
(4, 'CJL'),
(4, 'INF');

-- Naplnění tabulky Hodnoceni
INSERT INTO Hodnoceni (IDStudenta, ZkratkaPredmetu, DatumHodnoceni, Hodnoceni) VALUES
(1, 'MAT', '2023-05-20', 85),
(1, 'CJL', '2023-06-10', 90),
(2, 'MAT', '2023-05-20', 88),
(3, 'INF', '2023-06-15', 92),
(4, 'CJL', '2023-06-10', 87),
(4, 'INF', '2023-06-15', 85);

-- SELECT dotazy

-- 1. Všechny studenty a předměty, které mají zapsané
SELECT S.Jmeno, S.Prijmeni, SP.NazevPredmetu
FROM SeznamStudentu S
LEFT JOIN Zapis Z ON S.IDStudenta = Z.IDStudenta
LEFT JOIN SeznamPredmetu SP ON Z.ZkratkaPredmetu = SP.Zkratka;

-- 2. Příjmení studentů a počet studentů s tímto příjmením
SELECT Prijmeni, COUNT(*) AS PocetStudentu
FROM SeznamStudentu
GROUP BY Prijmeni
ORDER BY PocetStudentu DESC;

-- 3. Předměty, ve kterých je zapsáno méně než 3 studenty
SELECT SP.Zkratka, SP.NazevPredmetu, COUNT(*) AS PocetStudentu
FROM SeznamPredmetu SP
LEFT JOIN Zapis Z ON SP.Zkratka = Z.ZkratkaPredmetu
GROUP BY SP.Zkratka, SP.NazevPredmetu
HAVING COUNT(*) < 3;

-- 4. Předměty s nejlepším, nejhorším a průměrným hodnocením a počet hodnocených studentů
SELECT 
    Z.ZkratkaPredmetu,
    MAX(H.Hodnoceni) AS NejlepsiHodnoceni,
    MIN(H.Hodnoceni) AS NejhorsiHodnoceni,
    AVG(H.Hodnoceni) AS PrumernyVysledek,
    COUNT(*) AS PocetHodnocenych
FROM Hodnoceni H
JOIN SeznamPredmetu Z ON H.ZkratkaPredmetu = Z.Zkratka
GROUP BY Z.ZkratkaPredmetu;
