CREATE TABLE Bilet
(Id_bilet INT CONSTRAINT pk_bileT PRIMARY KEY,
 Id_rezervare INT FOREIGN KEY REFERENCES Rezervare(Id_rezervare) ON DELETE SET NULL,
 Id_zbor INT FOREIGN KEY REFERENCES Zbor(Id_zbor) ON DELETE SET NULL,
 Nr_loc VARCHAR(3) NOT NULL,
 Tip_bilet VARCHAR(20) NOT NULL,
 CONSTRAINT tip_bilet_invalid CHECK (Tip_bilet IN ('Standard', 'Express', 'Comfort'))
 )

   CREATE SEQUENCE Id_bilet_seq  MAXVALUE 999999 INCREMENT BY 1 START WITH 1 NO CACHE  NO CYCLE;

 INSERT INTO Bilet VALUES (NEXT VALUE FOR Id_bilet_seq, 1, 1001, '1A', 'Standard' )


INSERT INTO Bilet VALUES (NEXT VALUE FOR Id_bilet_seq, 2, 1001, '1B', 'Comfort' )

INSERT INTO Bilet VALUES (NEXT VALUE FOR Id_bilet_seq, 2, 1005, '2C', 'Comfort' )

INSERT INTO Bilet VALUES (NEXT VALUE FOR Id_bilet_seq, 2, 1008, '6C', 'Comfort' )

INSERT INTO Bilet VALUES (NEXT VALUE FOR Id_bilet_seq, 3, 1001, '1C', 'Express' )


INSERT INTO Bilet VALUES (NEXT VALUE FOR Id_bilet_seq, 4, 1005, '1D', 'Standard' )


INSERT INTO Bilet VALUES ( NEXT VALUE FOR Id_bilet_seq, 5, 1005, '3E', 'Standard' )


INSERT INTO Bilet VALUES ( NEXT VALUE FOR Id_bilet_seq, 6, 1001, '1E', 'Express' )

INSERT INTO Bilet VALUES ( NEXT VALUE FOR Id_bilet_seq, 6, 1008, '1E', 'Express' )


INSERT INTO Bilet VALUES (NEXT VALUE FOR Id_bilet_seq, 7, 1005, '1F', 'Standard' )


INSERT INTO Bilet VALUES ( NEXT VALUE FOR Id_bilet_seq, 8,1006, '2A', 'Standard' )


INSERT INTO Bilet VALUES ( NEXT VALUE FOR Id_bilet_seq, 9,1005 , '2B', 'Comfort' )


INSERT INTO Bilet VALUES ( NEXT VALUE FOR Id_bilet_seq, 10, 1005, '2C', 'Standard' )


INSERT INTO Bilet VALUES ( NEXT VALUE FOR Id_bilet_seq, 11, 1005, '2D', 'Express' )


INSERT INTO Bilet VALUES ( NEXT VALUE FOR Id_bilet_seq, 12,1005 , '2E', 'Comfort' )

INSERT INTO Bilet VALUES ( NEXT VALUE FOR Id_bilet_seq, 12,1007 , '3A', 'Comfort' )


INSERT INTO Bilet VALUES ( NEXT VALUE FOR Id_bilet_seq, 13,1005 , '2F', 'Standard' )


INSERT INTO Bilet VALUES ( NEXT VALUE FOR Id_bilet_seq, 14, 1005, '3C', 'Comfort' )


INSERT INTO Bilet VALUES (NEXT VALUE FOR Id_bilet_seq, 15,1005 , '3D', 'Standard' )


INSERT INTO Bilet VALUES ( NEXT VALUE FOR Id_bilet_seq, 16,1005, '3F', 'Express' )


INSERT INTO Bilet VALUES ( NEXT VALUE FOR Id_bilet_seq, 17,1005 , '3A', 'Comfort' )


INSERT INTO Bilet VALUES ( NEXT VALUE FOR Id_bilet_seq, 18, 1008, '3B', 'Express' )


INSERT INTO Bilet VALUES ( NEXT VALUE FOR Id_bilet_seq, 19, 1008, '4C', 'Standard' )


INSERT INTO Bilet VALUES ( NEXT VALUE FOR Id_bilet_seq, 20, 1008, '4A', 'Standard' )


INSERT INTO Bilet VALUES ( NEXT VALUE FOR Id_bilet_seq, 21, 1008, '4B', 'Comfort' )


INSERT INTO Bilet VALUES ( NEXT VALUE FOR Id_bilet_seq, 22, 1007, '4D', 'Comfort' )


INSERT INTO Bilet VALUES ( NEXT VALUE FOR Id_bilet_seq, 23,1007 , '4E', 'Express' )


INSERT INTO Bilet VALUES ( NEXT VALUE FOR Id_bilet_seq, 24, 1007, '4F', 'Comfort' )


INSERT INTO Bilet VALUES ( NEXT VALUE FOR Id_bilet_seq, 25, 1007, '10A', 'Comfort' )


INSERT INTO Bilet VALUES ( NEXT VALUE FOR Id_bilet_seq, 26, 1007, '10C', 'Comfort' )


INSERT INTO Bilet VALUES ( NEXT VALUE FOR Id_bilet_seq, 27, 1010, '11D', 'Standard' )




INSERT INTO Bilet VALUES ( NEXT VALUE FOR Id_bilet_seq, 29, 1010, '13D', 'Express' )


INSERT INTO Bilet VALUES ( NEXT VALUE FOR Id_bilet_seq, 30, 1006, '7B', 'Comfort' )

