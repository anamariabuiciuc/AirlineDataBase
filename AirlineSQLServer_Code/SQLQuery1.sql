SET DATEFORMAT DMY;
SELECT z.Id_zbor, a.Id_aeronava, a.Nume_aeronava, z.Data_zbor, z.Ora_decolare, z.Ora_aterizare, r.Cod_plecare,x.Regiune, 
x.Tara, r.Cod_destinatie, y.Regiune, y.Tara
	FROM Zbor z JOIN Aeronava a ON  z.Id_aeronava = a.Id_aeronava
				JOIN Ruta r ON z.Id_ruta = r.Id_ruta
				JOIN  Aeroport x ON r.Cod_plecare = x.Cod_aeroport
				JOIN  Aeroport  y ON r.Cod_destinatie = y.Cod_aeroport
	WHERE z.Data_zbor = '1.1.2021' and x.Tara = 'Romania' and  y.Tara = 'Romania';


SELECT Count(*) "Numar zboruri", Id_aeronava
   FROM Zbor
WHERE Id_ruta = '5001'
 GROUP BY Id_aeronava
 HAVING COUNT(*) >= 2;


 SELECT  Id_client, SUM(Pret) 'Suma totala (lei)'
	FROM Rezervare
	GROUP BY Id_client
	HAVING SUM(Pret) >= 1000;


	SELECT * 
	FROM Rezervare 
	WHERE Id_client = '101';

	SELECT c.Id_client, c.Nume, c.Prenume, r.Id_rezervare,  b.Id_bilet, b.Id_zbor, u.Cod_plecare, u.Cod_destinatie,b.Nr_loc, b.Tip_bilet, r.Data_achizitie, r.Metoda_achizitie
	FROM Bilet b 
				JOIN Rezervare r ON  r.Id_rezervare = b.Id_rezervare
	            JOIN Client c ON  r.Id_client = c.Id_client
				JOIN Zbor z ON z.Id_zbor = b.Id_zbor
				JOIN Ruta u ON u.Id_ruta = z.Id_ruta
	WHERE c.Id_client = 105 AND r.Id_rezervare = 6;


	SELECT c.Id_client, b.Id_rezervare, b.Id_bilet, b.Id_zbor, b.Nr_loc, b.Tip_bilet, r.Data_achizitie, r.Metoda_achizitie
	FROM Rezervare r
		 JOIN  Bilet b ON b.Id_rezervare = r.Id_rezervare
		 JOIN Client c ON c.Id_client = r.Id_client 
	    JOIN Zbor z ON z.Id_zbor = b.Id_zbor
	WHERE c.Id_client = 101;



	SELECT *
	FROM Bilet b
	JOIN Rezervare r ON r.Id_rezervare = b.Id_rezervare
	WHERE r.Id_client = 101;


	SELECT *
	FROM Bilet 
	
	WHERE Id_rezervare = 2