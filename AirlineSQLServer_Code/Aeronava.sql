CREATE TABLE Aeronava
( Id_aeronava BIGINT CONSTRAINT pk_aeronava PRIMARY KEY,
  Nume_aeronava VARCHAR(50) NOT NULL,
  Nr_locuri INT NOT NULL
  )


  
  INSERT INTO Aeronava VALUES (123200021182, 'Boeing 737-300', 20);
  INSERT INTO Aeronava VALUES (123200021190, 'Boeing 737-300', 20);
  INSERT INTO Aeronava VALUES (123200021178, 'Boeing 737-500', 30);
  INSERT INTO Aeronava VALUES (123200021191, 'Boeing 737-500', 30);
  INSERT INTO Aeronava VALUES (123200021192, 'Boeing 737-500', 30);
  INSERT INTO Aeronava VALUES (123200021200, 'Boeing 737-800', 24);
  INSERT INTO Aeronava VALUES (123200021201, 'Boeing 737-800', 24);
  INSERT INTO Aeronava VALUES (123200023000, 'Boeing 737-800', 24);
  INSERT INTO Aeronava VALUES (123200023001, 'Boeing 737-800', 24);
  INSERT INTO Aeronava VALUES (123200021308, 'Boeing 737-800', 24);


  SELECT *
	FROM Aeronava;