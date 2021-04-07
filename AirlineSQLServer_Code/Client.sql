SET DATEFORMAT DMY;
CREATE TABLE Client
(
Id_client INT CONSTRAINT pk_client PRIMARY KEY,  
Nume VARCHAR(25) NOT NULL,   
Prenume VARCHAR(25) NOT NULL,
Gen VARCHAR(2) NOT NULL,
CONSTRAINT gen_invalid_FsauM CHECK (Gen in ('F', 'M','f', 'm')),
Data_nasterii DATE NOT NULL,
CNP BIGINT  CONSTRAINT cnp_deja_utilizat UNIQUE NOT NULL, 
 CONSTRAINT cnp_invalid CHECK (CNP >= 1000000000000),
-- Nume insotitor se completeaza doar in cazurile persoanelor minore. 
Nume_insotitor VARCHAR(52),
Tara VARCHAR(25) NOT NULL,
Regiune VARCHAR(25) NOT NULL,
Localitate VARCHAR(25) NOT NULL, 
Strada VARCHAR(25) NOT NULL,
Numar VARCHAR(4),
-- Numarul este varchar deoarece exista adrese ca Strada Mihai Eminescu, Nr. 10B
Nr_telefon VARCHAR(15) NOT NULL,
CONSTRAINT telefon_client_invalid CHECK ( LEN(Nr_telefon)>9 and LEN(Nr_telefon)<16),
Adresa_mail VARCHAR(50) NOT NULL
)   

CREATE SEQUENCE Id_client_seq  MAXVALUE 999999 INCREMENT BY 1 START WITH 100  NO CACHE  NO CYCLE;


INSERT INTO Client VALUES (NEXT VALUE FOR Id_client_seq, 'Buiciuc', 'Cristina', 'F', '17.02.1976', 2076021709321,   NULL, 'Romania', 'Bacau', 
'Moinesti', 'Strada Nicu Enea', '15A', '0743848473', 'cristinabuiciuc@gmail.com') 


INSERT INTO Client VALUES (NEXT VALUE FOR Id_client_seq, 'Buiciuc', 'Ana', 'f', '28.12.2007', 6071228983123,'Buiciuc Cristina',  'Romania', 'Bacau', 
'Moinesti', 'Strada Nicu Enea', '15A', '0754934309', 'cristinabuiciuc@gmail.com')

INSERT INTO Client VALUES (NEXT VALUE FOR Id_client_seq, 'Buiciuc', 'Maricica', 'f', '10.05.2009', 6071893383123,'Buiciuc Cristina',  'Romania', 'Bacau', 
'Moinesti', 'Strada Nicu Enea', '15A', '0754930009', 'cristinabuiciuc@gmail.com')


INSERT INTO Client VALUES (NEXT VALUE FOR Id_client_seq, 'Ariton', 'Marcel', 'M', '28.10.1988', 4891021113321,   NULL, 'Romania', 'Bacau', 
'Sacele', 'Strada Mihai Viteazu', '239', '0734548473', 'aritonmarcel@gmail.com') 

INSERT INTO Client VALUES (NEXT VALUE FOR Id_client_seq, 'Ariton', 'Andreea', 'f', '11.02.1990', 6234128983123, NULL,  'Romania', 'Bacau', 
'Sacele', 'Strada Mihai Viteazu', '239', '0720814309', 'aritonandreea@gmail.com')


INSERT INTO Client VALUES (NEXT VALUE FOR Id_client_seq, 'Ariton', 'Medeea', 'f', '01.11.2004', 6071222323123,'Ariton Marcel',  'Romania', 'Bacau', 
'Sacele', 'Strada Mihai Viteazu', '239', '0751124309', 'aritonmarcel@gmail.com')

INSERT INTO Client VALUES (NEXT VALUE FOR Id_client_seq, 'Ariton', 'Alexandru', 'm', '20.05.2003', 4071228983123,'Ariton Andreea',  'Romania', 'Bacau', 
'Sacele', 'Strada Mihai Viteazu', '239', '0722344509', 'aritonmarcel@gmail.com')


INSERT INTO Client VALUES (NEXT VALUE FOR Id_client_seq, 'Vilciu', 'Razvan', 'm', '15.04.1991', 4299124983123, NULL,  'Romania', 'Bacau', 
'Bacau', 'Strada 1 Mai', '21B', '0720364329', 'vilciurazvan@gmail.com')


INSERT INTO Client VALUES (NEXT VALUE FOR Id_client_seq, 'Dumitrascu', 'Andreea', 'f', '23.02.2000', 6234128983139, NULL,  'Romania', 'Bacau', 
'Bacau', 'Strada 9 Mai', '11C', '0720813392', 'dumitrascuandreea@gmail.com')


INSERT INTO Client VALUES (NEXT VALUE FOR Id_client_seq, 'Miron', 'Andrei', 'm', '18.06.2000', 4232228883193, NULL,  'Romania', 'Ilfov', 
'Bucuresti', 'Strada Neagoe Voda', '220', '0720884312', 'mironandrei@gmail.com')


INSERT INTO Client VALUES (NEXT VALUE FOR Id_client_seq, 'Badea', 'Alexia', 'f', '10.07.1995', 6232348982223, NULL,  'Romania', 'Brasov', 
'Brasov', 'Strada Florilor 2', '72B', '0728134309', 'badeaalexia@gmail.com')

INSERT INTO Client VALUES (NEXT VALUE FOR Id_client_seq, 'Andone', 'Klaus', 'm', '10.10.1998', 4231148486783, NULL,  'Germania', 'Munchen', 
'Munich', 'Liebestrasse', '11C', '0718132301', 'andoneklaus@gmail.com')

INSERT INTO Client VALUES (NEXT VALUE FOR Id_client_seq, 'Mihaila', 'Raluca', 'f', '21.09.1999', 6267908982223, NULL,  'Spania', 'Aragon', 
'Valencia', 'Ribera de Curtidores', '110', '0788124009', 'mihailaraluca@gmail.com')


INSERT INTO Client VALUES (NEXT VALUE FOR Id_client_seq, 'Tiganescu', 'Iulian', 'm', '10.10.1997', 4231122486783, NULL,  'Austria', 'Viena', 
'Niederosterreich', 'Appfelsts. 4', '9B', '0728880309', 'tiganescuiulian@gmail.com')


INSERT INTO Client VALUES (NEXT VALUE FOR Id_client_seq, 'Ciuciu', 'Andrada', 'f', '22.11.1997', 6232348002223, NULL,  'Romania', 'Ilfov', 
'Bucuresti', 'Strada Pinilor 2', '223A', '0723454309', 'ciuciuandrada@gmail.com')


INSERT INTO Client VALUES (NEXT VALUE FOR Id_client_seq, 'Buburuzan', 'Matei', 'm', '10.12.1995', 4122348982223, NULL,  'Romania', 'Ilfov', 
'Bucuresti', 'Strada Florilor 5', '2B', '0723456309', 'buburuzanmatei@gmail.com')


INSERT INTO Client VALUES (NEXT VALUE FOR Id_client_seq, 'Mares', 'Maria', 'f', '21.07.1996', 6232341002223, NULL,  'Romania', 'Brasov', 
'Brasov', 'Strada Bradului 2', '7A', '0728134220', 'maresmaria@gmail.com')


INSERT INTO Client VALUES (NEXT VALUE FOR Id_client_seq, 'Stoleru', 'Alin', 'm', '10.01.1999', 4192748982113, NULL,  'Romania', 'Iasi', 
'Iasi', 'Strada Florilor', '1', '0711139909', 'stolerualin@gmail.com')


INSERT INTO Client VALUES (NEXT VALUE FOR Id_client_seq, 'Acrasmaritei', 'Andrei', 'm', '15.03.1998', 4232385281933, NULL,  'Romania', 'Cluj', 
'Cluj Napoca', 'Strada Hergheliei', '1C', '0722334969', 'acrasmariteiandrei@gmail.com')


INSERT INTO Client VALUES (NEXT VALUE FOR Id_client_seq, 'Trifan', 'Alexia', 'f', '10.10.1999', 6117348300223, NULL,  'Romania', 'Dolj', 
'Dabuleni', 'Strada Merilor 3', '28B', '0770034309', 'trifanalexia@gmail.com')


INSERT INTO Client VALUES (NEXT VALUE FOR Id_client_seq, 'Badea', 'Ilinca', 'f', '10.03.1997', 6190848989923, NULL,  'Romania', 'Dolj', 
'Bechet', 'Strada Bradului 5', '7C', '0708132409', 'badeailinca@gmail.com')


INSERT INTO Client VALUES (NEXT VALUE FOR Id_client_seq, 'Ignat', 'Georgiana', 'f', '29.08.1991', 6232343321223, NULL,  'Romania', 'Brasov', 
'Rasnov', 'Strada Revolutiei', '1D', '0728734309', 'ignatgeorgiana@gmail.com')
INSERT INTO Client VALUES (NEXT VALUE FOR Id_client_seq, 'Moiceanu', 'Andrei', 'm', '21.10.1999', 4221348985923, NULL,  'Romania', 'Brasov', 
'Predeal', 'Strada Stefan cel Mare', '11A', '0734188309', 'moiceanuandrei@gmail.com')


INSERT INTO Client VALUES (NEXT VALUE FOR Id_client_seq, 'Stefanescu', 'Andrei', 'm', '22.01.1998', 4232870082223, NULL,  'Romania', 'Brasov', 
'Rupea', 'Strada Revolutiei 2', '45A', '0722135609', 'stefanescuandrei@gmail.com')


INSERT INTO Client VALUES (NEXT VALUE FOR Id_client_seq, 'Pintilie', 'Calin', 'm', '12.11.1999', 4232387982200, NULL,  'Romania', 'Brasov', 
'Ghimbav', 'Strada Mantuirii 2', '12B', '0700123309', 'pintiliecalin@gmail.com')


INSERT INTO Client VALUES (NEXT VALUE FOR Id_client_seq, 'Cucu', 'Andrei', 'm', '10.02.1997', 4229938982223, NULL,  'Romania', 'Brasov', 
'Mandra', 'Strada Eroilor 5', '85A', '0727192309', 'cucuandrei@gmail.com')


INSERT INTO Client VALUES (NEXT VALUE FOR Id_client_seq, 'Turculet', 'Roxana', 'f', '22.12.1994', 6232907982513, NULL,  'Romania', 'Bacau', 
'Buhoci', 'Strada Fermierilor 1', '44B', '0728138863', 'turculetroxana@gmail.com')


INSERT INTO Client VALUES (NEXT VALUE FOR Id_client_seq, 'Ursu', 'Catalina', 'f', '19.02.1999', 6789248982223, NULL,  'Romania', 'Bacau', 
'Marasti', 'Strada Bicaz 2', '15B', '0723434309', 'ursucatalina@gmail.com')


INSERT INTO Client VALUES (NEXT VALUE FOR Id_client_seq, 'Grosu', 'Madalina', 'f', '22.08.1998', 6232348981084, NULL,  'Romania', 'Bacau', 
'Bogdan Voda', 'Strada Primariei', '14A', '0728554309', 'grosumadalina@gmail.com')


INSERT INTO Client VALUES (NEXT VALUE FOR Id_client_seq, 'Botezatu', 'Anca', 'f', '08.10.1995', 6232749102223, NULL,  'Romania', 'Bacau', 
'Bacau', 'Strada Nicu Enea 2', '27C', '0728885409', 'botezatuanca@gmail.com')


INSERT INTO Client VALUES (NEXT VALUE FOR Id_client_seq, 'Ghiroaga', 'Ofelia', 'f', '10.07.1999', 6232426989603, NULL,  'Romania', 'Bacau', 
'Traian', 'Strada Independentei 3', '98', '0728133749', 'ghiroagaofelia@gmail.com')

INSERT INTO Client VALUES(NEXT VALUE FOR Id_client_seq,'PIRVAN','CASIAN','M','2000-11-2','5001102100176', NULL, 'Romania', 
'BUZAU', 'BUZAU', 'BULEVARD UNIRII',12,'0789321983', 'CASIANPIRVAN@YAHOO.MAIL');

INSERT INTO Client VALUES(NEXT VALUE FOR Id_client_seq,'DRAGOIU','BOGDAN','M','2000-11-16','2007632100987', NULL, 'Romania',
'Bucuresti', 'Sector 1', 'Bucurestii Noi',901,'0756272593', 'BOGDANEMILDRAGOIU@GMAIL.COM');

INSERT INTO Client VALUES(NEXT VALUE FOR Id_client_seq,'Pirvu','Alexandra','F','2000-3-20','6004476100976', NULL, 'Romania', 
'Bucuresti', 'Sector 1', 'Bucurestii Noi',901,'0765345987', 'ali_pirvu@yahoo.com');

INSERT INTO Client VALUES(NEXT VALUE FOR Id_client_seq,'Voicu','Oana','F','1950-12-30','2031232455987', NULL, 'Romania', 'Bacau', 
'Colti', 'Strada Rozelor',99,'0986563877', 'voicu.oana@yahoo.com');

INSERT INTO Client VALUES(NEXT VALUE FOR Id_client_seq,'Ghinea','Stefania','F','2000-9-17','6009556100996', NULL, 'Romania', 
'Bucuresti', 'Bucuresti', 'Calea Victoriei',1,'0770813323', 'stefania.ghinea2000@yahoo.com');

INSERT INTO Client VALUES(NEXT VALUE FOR Id_client_seq,'Pana','Alexandru','M','1948-6-20','5938461749234', NULL, 'Romania', 'Cluj', 
'Cluj', 'Bulevard 1 Decembrie 1918',2,'0765345987', 'pana.alx@yahoo.com');

INSERT INTO Client VALUES(NEXT VALUE FOR Id_client_seq,'Radu','Adrian','M','1985-1-27','5765960606121', NULL, 'Romania', 'Cluj',
'Cluj', 'Nicolae Balcescu',51,'0765345987', 'radu_adrian77u@yahoo.com');


INSERT INTO Client VALUES(NEXT VALUE FOR Id_client_seq,'Andrei','Sara','F','1992-2-28','6098998824326', NULL, 'Romania', 'Calarasi',
'Calarasi', 'Chitila',12,'0765768775', 'andrei_sara@gmail.ro');

INSERT INTO Client VALUES(NEXT VALUE FOR Id_client_seq,'Papuc','Georgian','M','1979-11-1','6003746586971', NULL, 'Romania', 'Bacau',
'Bacau', 'Iancului',43,'0741989441', 'papuc_georgian@yahoo.com');

INSERT INTO Client VALUES(NEXT VALUE FOR Id_client_seq,'Savca','Cristian','M','1999-3-27','6098564739544', NULL, 'Romania', 'Iasi', 
'Iasi', 'Grivita',88,'0740112324', 'svca9900@yahoo.com');

INSERT INTO Client VALUES(NEXT VALUE FOR Id_client_seq,'Liloiu','Alexandra','F','1995-8-7','5000756829485', NULL, 'Romania', 
'Craiova', 'Corbeanca', 'Revolutiei',43,'0745665455', 'lil_alexa@yahoo.com');

INSERT INTO Client VALUES(NEXT VALUE FOR Id_client_seq,'Dodan','Teodor','M','2009-10-10','6099234586923', 'Petcu Ana-Maria',
'Romania', 'Craiova', 'Berceni', 'Independentei',11,'0756279532', 'dodan_teo@yahoo.com');

INSERT INTO Client VALUES(NEXT VALUE FOR Id_client_seq,'Gheorghe','Teodor','M','2001-6-17','6098756475842', NULL, 'Romania', 
'Piatra Neamt', 'Fisici', 'Patriei',23,'0744437210', 'teodor.ghe@yahoo.com');

INSERT INTO Client VALUES(NEXT VALUE FOR Id_client_seq,'Soldan','Alexandru','M','1998-1-20','6004466160976', NULL, 'Romania', 
'Satu Mare', 'Satu Mare', '23 August',22,'0752011597', 'soldan_alex10@yahoo.com');

drop table Client


select * from Client