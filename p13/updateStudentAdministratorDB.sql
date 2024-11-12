CREATE DATABASE StudentAdministratorDB
GO

USE StudentAdministratorDB
GO

CREATE TABLE career(
	idCareer INT PRIMARY KEY IDENTITY(1, 1) NOT NULL,
	nameCareer NVARCHAR(100) NOT NULL,
	descriptionCareer NVARCHAR(255) NOT NULL
)
GO

INSERT INTO career 
VALUES ('Ingenieria en Desarrollo de Software', 'Carrera de Ingenieria en Desarrollo de Software')
GO

CREATE TABLE student(
	idStudent INT PRIMARY KEY IDENTITY(1, 1) NOT NULL,
	nameStudent NVARCHAR(50) NOT NULL,
	lastnameStudent NVARCHAR(50) NOT NULL,
	idCareerStudent INT FOREIGN KEY REFERENCES career(idCareer) NOT NULL
)
GO

INSERT INTO student VALUES ('Williams', 'Rodriguez', 1)
GO


SELECT st.idStudent, st.nameStudent, st.lastnameStudent, st.idCareerStudent, ca.nameCareer 
FROM student st
INNER JOIN career ca ON st.idCareerStudent = ca.idCareer