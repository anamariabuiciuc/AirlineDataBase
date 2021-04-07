SET DATEFORMAT DMY;

CREATE TABLE Aeroport
(
Cod_aeroport VARCHAR(3)  PRIMARY KEY,
Nume_aeroport VARCHAR(50) CONSTRAINT nume_unic UNIQUE NOT NULL,
Tara VARCHAR(20)  NOT NULL ,
CONSTRAINT servicii_indisponibile_in_aceasta_tara CHECK (Tara IN ('Romania', 'Italia', 'Grecia', 'Germania', 
'Spania', 'Cipru', 'Regatul Unit', 'Franta', 'Portugalia', 'Olanda', 'Danemarca', 'Turcia')),
Regiune VARCHAR(20) NOT NULL,
CONSTRAINT locatie_invalida CHECK (Regiune IN ('Bucuresti', 'Iasi', 'Cluj', 'Bacau', 'Roma', 'Napoli', 
'Milano', 'Torino', 'Atena', 'Salonic', 'Corfu', 'Berlin', 'Stuttgard', 'Barcelona', 'Valencia', 'Madrid', 'Larnaca',
'Londra', 'Liverpool', 'Lion', 'Paris', 'Lisabona', 'Amsterdam', 'Copenhaga', 'Istanbul', 'Antalya')),
Localitate VARCHAR(20) NOT NULL,
Strada VARCHAR(50) NOT NULL,
Nr VARCHAR(10),
-- Numarul este varchar deoarece exista adrese ca Strada Mihai Eminescu, Nr. 10B
-- De asemenea, poate fi null pentru exista adrese ca Bacau, Loc. Hemeiusi (fara nr casei specificat)
Nr_telefon VARCHAR(15) UNIQUE NOT NULL
CONSTRAINT nr_tel_invalid CHECK ( LEN(Nr_telefon)>9 and LEN(Nr_telefon)<16)
)


INSERT INTO Aeroport VALUES ('OTP', 'A.I. Henri Coanda Otopeni', 'Romania', 'Bucuresti', 'Otopeni','Calea Bucurestilor', '224E','0212041000');
INSERT INTO Aeroport VALUES ('BCM', 'A.I George Enescu', 'Romania', 'Bacau','Bacau','Strada Aeroportului', '1', '0234575400');
INSERT INTO Aeroport VALUES ('IAS', 'A.I Iasi', 'Romania', 'Iasi', 'Iasi', 'Strada Moara de Vant', '34', '0232271590');
INSERT INTO Aeroport VALUES ('CLJ', 'A.I Avram Iancu', 'Romania', 'Cluj', 'Cluj-Napoca', 'Strada Traian Vuia', '149-151', '0264307500');
INSERT INTO Aeroport VALUES ('FCO', 'A.I Leonardo Da Vinci', 'Italia', 'Roma', 'Fumicino', 'Via dell Aeroporto di Fumicino', '', '+390665951');
INSERT INTO Aeroport VALUES ('CIA', 'A.I Cimpiano', 'Italia', 'Roma' , 'Cimpiano', 'Via Appia Nuova', '', '+390665670');
INSERT INTO Aeroport VALUES ('NAP', 'A.I din Napoli', 'Italia', 'Napoli' , 'Napoli' , 'Viale F. Ruffo di Calabria' , '', '+390817896111');
INSERT INTO Aeroport VALUES ('MXP', 'A.I Milano-Malpensa', 'Italia', 'Milano', 'Varese', 'Via Statale', '', '+3902232323');
INSERT INTO Aeroport VALUES ('LTN', 'A.I Luton', 'Regatul Unit', 'Londra', 'Luton', 'Airport Way', '9LY', '+441582405100');
INSERT INTO Aeroport VALUES ('ATH', 'A.I Atena', 'Grecia', 'Atena', 'Spata Artemids','Attiki Odos','190','+302103530000');
INSERT INTO Aeroport VALUES ('SKG', 'A.I Macedonia din Salonic', 'Grecia', 'Salonic', 'Salonic', 'EO Aerodromiou', '551', '+302310985000');
INSERT INTO Aeroport VALUES ('CFU', 'A.I Corfu', 'Grecia', 'Corfu', 'Corfu', 'EO Kerkiras Achillou', '491', '+302661089602');
INSERT INTO Aeroport VALUES ('BER', 'A.I Berlin-Brandenburg', 'Germania', 'Berlin', 'Schonefeld', 'Willy-Brandt-Platz', '', '+4930609160910');
INSERT INTO Aeroport VALUES ('VLC', 'A.I Valencia', 'Spania', 'Valencia', 'Manises', 'Carretera del Aeropuerto', '', '+34902404704');
INSERT INTO Aeroport VALUES ('LCA', 'A.I Larnaca', 'Cipru', 'Larnaca', 'Larnaca', 'Timiou Prodromou', '', '+35724040370');
INSERT INTO Aeroport VALUES ('CDG', 'A.I. Charles de Gaulle', 'Franta', 'Paris', 'Roissy-en-France', 'Route des Peupliers', '95', '+33170363950');
INSERT INTO Aeroport VALUES ('LIS', 'A.I. Lisabona', 'Portugalia', 'Lisabona', 'Lisabona', 'Alameda das Comunidades Portuguesas', '1700-111', '+351218413500');
INSERT INTO Aeroport VALUES ('AMS', 'A.I Amsterdam Schiphol', 'Olanda', 'Amsterdam', 'Haarlemmermeer', 'Loevesteinse Randweg', '', '+31207940800');
INSERT INTO Aeroport VALUES ('CPH', 'A.I. Copenhaga','Danemarca', 'Copenhaga', 'Kastrup', 'Lufthavnsboulevarden', '6', '+4532313231');
INSERT INTO Aeroport VALUES ('IST', 'A.I. Istanbul', 'Turcia','Istanbul', 'Istanbul', 'Tayakadin Terminal Cad.', '1', '+902124441442');

SELECT * FROM Aeroport;

DROP TABLE Aeroport;
