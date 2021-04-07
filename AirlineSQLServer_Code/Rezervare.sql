SET DATEFORMAT DMY;

CREATE TABLE Rezervare
( Id_rezervare INT CONSTRAINT pk_rezervare PRIMARY KEY,
  Id_client INT FOREIGN KEY REFERENCES Client(Id_client) ON DELETE CASCADE,
  Data_achizitie DATE NOT NULL,
  Metoda_achizitie VARCHAR(30) NOT NULL,
  CONSTRAINT metoda_invalida CHECK (Metoda_achizitie IN ('Cash', 'Online', 'Ordin plata')),
  Pret INT NOT NULL
  -- Se poate plati doar in lei.
  )

  CREATE SEQUENCE Id_rezervare_seq  MAXVALUE 999999 INCREMENT BY 1 START WITH 1 NO CACHE  NO CYCLE;

  INSERT INTO Rezervare VALUES (NEXT VALUE FOR Id_rezervare_seq, 100, '20.11.2020', 'Cash', 300 )


INSERT INTO Rezervare VALUES (NEXT VALUE FOR Id_rezervare_seq, 101, '25.11.2020', 'Cash', 700 )


INSERT INTO Rezervare VALUES (NEXT VALUE FOR Id_rezervare_seq, 102, '18.10.2020', 'Online', 1200 )


INSERT INTO Rezervare VALUES (NEXT VALUE FOR Id_rezervare_seq, 103, '11.09.2020', 'Ordin plata', 800 )


INSERT INTO Rezervare VALUES (NEXT VALUE FOR Id_rezervare_seq, 104, '22.11.2020', 'Cash', 1300 )


INSERT INTO Rezervare VALUES (NEXT VALUE FOR Id_rezervare_seq, 105, '27.11.2020', 'Online', 750 )


INSERT INTO Rezervare VALUES (NEXT VALUE FOR Id_rezervare_seq, 106, '28.11.2020', 'Cash', 450 )


INSERT INTO Rezervare VALUES (NEXT VALUE FOR Id_rezervare_seq, 107, '19.10.2020', 'Ordin plata', 2200 )


INSERT INTO Rezervare VALUES (NEXT VALUE FOR Id_rezervare_seq, 108, '02.12.2020', 'Cash', 400 )


INSERT INTO Rezervare VALUES ( NEXT VALUE FOR Id_rezervare_seq, 109, '16.11.2020', 'Cash', 550 )


INSERT INTO Rezervare VALUES (NEXT VALUE FOR Id_rezervare_seq, 110, '17.11.2020', 'Online', 650 )


INSERT INTO Rezervare VALUES (NEXT VALUE FOR Id_rezervare_seq, 111, '11.11.2020', 'Online', 950 )


INSERT INTO Rezervare VALUES (NEXT VALUE FOR Id_rezervare_seq, 112, '09.11.2020', 'Ordin plata', 900 )


INSERT INTO Rezervare VALUES ( NEXT VALUE FOR Id_rezervare_seq, 113, '20.12.2020', 'Cash', 350 )


INSERT INTO Rezervare VALUES (NEXT VALUE FOR Id_rezervare_seq, 114, '09.11.2020', 'Online', 850 )


INSERT INTO Rezervare VALUES ( NEXT VALUE FOR Id_rezervare_seq, 115, '29.11.2020', 'Cash', 700 )


INSERT INTO Rezervare VALUES ( NEXT VALUE FOR Id_rezervare_seq, 116, '10.12.2020', 'Ordin plata', 650 )


INSERT INTO Rezervare VALUES ( NEXT VALUE FOR Id_rezervare_seq, 117, '23.12.2020', 'Online', 450 )


INSERT INTO Rezervare VALUES (NEXT VALUE FOR Id_rezervare_seq, 118, '17.11.2020', 'Cash', 800 )


INSERT INTO Rezervare VALUES ( NEXT VALUE FOR Id_rezervare_seq, 119, '22.11.2020', 'Cash', 950 )


INSERT INTO Rezervare VALUES ( NEXT VALUE FOR Id_rezervare_seq, 120, '04.12.2020','Online', 400 )


INSERT INTO Rezervare VALUES ( NEXT VALUE FOR Id_rezervare_seq, 121, '22.12.2020', 'Cash', 1450 )


INSERT INTO Rezervare VALUES ( NEXT VALUE FOR Id_rezervare_seq, 122, '25.12.2020', 'Online', 900 )


INSERT INTO Rezervare VALUES ( NEXT VALUE FOR Id_rezervare_seq, 123, '20.12.2020', 'Ordin plata', 1200 )


INSERT INTO Rezervare VALUES ( NEXT VALUE FOR Id_rezervare_seq, 124, '05.12.2020', 'Cash', 600 )


INSERT INTO Rezervare VALUES ( NEXT VALUE FOR Id_rezervare_seq, 125, '03.12.2020', 'Online', 700 )


INSERT INTO Rezervare VALUES ( NEXT VALUE FOR Id_rezervare_seq, 126, '11.11.2020', 'Cash', 550 )


INSERT INTO Rezervare VALUES ( NEXT VALUE FOR Id_rezervare_seq, 127, '01.11.2020', 'Online', 950 )


INSERT INTO Rezervare VALUES (NEXT VALUE FOR Id_rezervare_seq, 128, '03.12.2020', 'Cash', 1250 )


INSERT INTO Rezervare VALUES ( NEXT VALUE FOR Id_rezervare_seq, 129, '12.11.2020', 'Ordin plata', 1500 )


SELECT * 
	FROM Rezervare;
