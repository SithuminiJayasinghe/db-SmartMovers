CREATE DATABASE SmartMovers;

DROP DATABASE SmartMovers;

CREATE TABLE Customer(
C_Id  INT IDENTITY(1,1) NOT NULL,
C_Name VARCHAR(50),
C_Address VARCHAR(50),
C_Email VARCHAR(50),
C_Password Varchar(50),
CONSTRAINT Pk_Customer PRIMARY KEY (C_Id),
);

INSERT INTO Customer VALUES ('Sithumini','Colombo','sithu@gmail.com',123);
INSERT INTO Customer VALUES ('Ayesha','Gampaha','ayesha@gmail.com',123);
INSERT INTO Customer VALUES ('Moneesha','Gampaha','moneesha@gmail.com',123);

CREATE TABLE CustomerType(
C_Type_Id  INT NOT NULL,
C_Type_Name VARCHAR(50),
C_Id VARCHAR(50),
CONSTRAINT Pk_CustomerType PRIMARY KEY (C_Type_Id, C_Id),
);

INSERT INTO CustomerType VALUES (001,'Category 1',1);
INSERT INTO CustomerType VALUES (002,'Category 2',2);
INSERT INTO CustomerType VALUES (002,'Category 3',3);


CREATE TABLE CustomerContact(
C_Id  INT NOT NULL,
C_Contact VARCHAR(50),
CONSTRAINT Pk_CustomerContact PRIMARY KEY (C_Id),
);

INSERT INTO CustomerContact VALUES (1,0711111111);
INSERT INTO CustomerContact VALUES (2,0712222222);
INSERT INTO CustomerContact VALUES (3,0713333333);


CREATE TABLE Depot(
D_Id  INT NOT NULL,
D_Name VARCHAR(50),
D_Location VARCHAR(50),
CONSTRAINT Pk_Depot PRIMARY KEY (D_Id),
);
INSERT INTO Depot VALUES (1000,'Colombo Depot','Colombo');
INSERT INTO Depot VALUES (1001,'Kandy Depot','Kandy');
INSERT INTO Depot VALUES (1002,'Galle Depot','Galle');

CREATE TABLE Product(
P_Id  INT NOT NULL,
P_Name VARCHAR(50),
P_Description VARCHAR(50),
CONSTRAINT Pk_Product PRIMARY KEY (P_Id),
);
INSERT INTO Product VALUES (3000,'Silica','Granules');
INSERT INTO Product VALUES (3001,'Calcium carbonate','Powder');
INSERT INTO Product VALUES (3002,'Sulphuric','Liquid');

CREATE TABLE Job(
J_Id  INT NOT NULL,
J_Start_Location VARCHAR(50),
J_End_Location VARCHAR(50),
D_Id INT NOT NULL,
CONSTRAINT Pk_Job PRIMARY KEY (J_Id),
CONSTRAINT Fk_Job FOREIGN KEY (D_Id) REFERENCES Depot (D_Id)
);

ALTER TABLE Job ADD TimeStamp datetime;

INSERT INTO Job VALUES (2000,'Colombo','Kegalle',1000,(convert(datetime,'18-05-12 10:34:09 PM',5)));
INSERT INTO Job VALUES (2001,'Kandy','Galle',1001,(convert(datetime,'18-06-12 10:34:09 PM',5)));
INSERT INTO Job VALUES (2002,'Galle','Negambo',1002,(convert(datetime,'18-07-12 10:34:09 PM',5)));
INSERT INTO Job VALUES (2003,'Colombo','Kegalle',1000,(convert(datetime,'18-08-12 10:34:09 PM',5)));
INSERT INTO Job VALUES (2004,'Kandy','Galle',1001,(convert(datetime,'18-09-12 10:34:09 PM',5)));
INSERT INTO Job VALUES (2005,'Galle','Negambo',1002,(convert(datetime,'18-10-12 10:34:09 PM',5)));
INSERT INTO Job VALUES (2006,'Colombo','Kegalle',1000,(convert(datetime,'18-10-18 10:34:09 PM',5)));
INSERT INTO Job VALUES (2007,'Kandy','Galle',1001,(convert(datetime,'18-10-25 10:34:09 PM',5)));
INSERT INTO Job VALUES (2008,'Galle','Negambo',1002,(convert(datetime,'18-11-12 10:34:09 PM',5)));


CREATE TABLE Load(
L_Id  INT NOT NULL,
J_Id INT,
P_Id INT,
CONSTRAINT Pk_Load PRIMARY KEY (L_Id),
CONSTRAINT Fk_Load FOREIGN KEY (J_Id) REFERENCES Job(J_Id), FOREIGN KEY (P_Id) REFERENCES Product(P_Id) 
);
INSERT INTO Load VALUES (4000,2000,3000);
INSERT INTO Load VALUES (4001,2000,3000);
INSERT INTO Load VALUES (4002,2000,3000);


SELECT TOP (1000)
	  Depot.D_Name,
	  Depot.D_Location,
      COUNT(Job.J_Id) AS NumberOfJobs
  FROM 
  Job         INNER JOIN  Depot
  ON Job.D_Id     =       Depot.D_Id

  GROUP BY Depot.D_Name,Depot.D_Location;



