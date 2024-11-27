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

CREATE TABLE student(
	idStudent INT PRIMARY KEY IDENTITY(1, 1) NOT NULL,
	nameStudent NVARCHAR(50) NOT NULL,
	lastnameStudent NVARCHAR(50) NOT NULL,
	idCareerStudent INT FOREIGN KEY REFERENCES career(idCareer) NOT NULL
)
GO

CREATE TABLE roles (
	idRol INT PRIMARY KEY IDENTITY(1, 1),
	nameRol VARCHAR(20),
	descriptionRol VARCHAR(50)
)
GO

CREATE TABLE users (
	idUser INT PRIMARY KEY IDENTITY(1, 1),
	nameUser VARCHAR(20),
	usernameUser VARCHAR(20),
	passwordUser VARCHAR(20),
	idRolUser INT FOREIGN KEY REFERENCES roles(idRol)
)
GO

INSERT INTO career 
VALUES ('Ingenieria en Desarrollo de Software', 'Carrera de Ingenieria en Desarrollo de Software')
GO

INSERT INTO student VALUES ('Williams', 'Rodriguez', 1)
GO

INSERT INTO roles 
VALUES ('administrator', 'Rol con mayor privilegio'),
	   ('teacher', 'usuario comun del sistema')
GO

INSERT INTO users
VALUES ('Administrador', 'admin', 'admin', 1),
	   ('Williams', 'wrodriguez', '123', 2)
GO

SELECT st.idStudent, st.nameStudent, st.lastnameStudent, st.idCareerStudent, ca.nameCareer 
FROM student st
INNER JOIN career ca ON st.idCareerStudent = ca.idCareer
WHERE st.nameStudent like '%%'
GO

SELECT * FROM career
WHERE nameCareer LIKE '%%'
GO

/*---------------------------------------------- STORES PROCEDURES -----------------------------------------------------*/

---------------------- <CAREER - STORE PROCEDURE> --------------------------

----- SELECT -----
CREATE OR ALTER PROCEDURE sp_SelectCareer
(
	@SearchCareer VARCHAR(50)
)
AS
BEGIN
	SELECT * FROM career WHERE nameCareer LIKE @SearchCareer
END
GO

----- INSERT -----
CREATE OR ALTER PROCEDURE sp_InsertCareer
(
	@nameCareer NVARCHAR(100),
	@descriptionCareer NVARCHAR(255)
)
AS
BEGIN
	INSERT INTO career VALUES (@nameCareer, @descriptionCareer)
END
GO

----- UPDATE -----
CREATE OR ALTER PROCEDURE sp_UpdateCareer
(
	@idCareer INT,
	@nameCareer NVARCHAR(100),
	@descriptionCareer NVARCHAR(255)
)
AS
BEGIN
	UPDATE career 
	SET nameCareer = @nameCareer, descriptionCareer = @descriptionCareer
	WHERE idCareer = @idCareer
END
GO

----- DELETE -----
CREATE OR ALTER PROCEDURE sp_DeleteCareer
(
	@idCareer INT
)
AS
BEGIN
	DELETE FROM career WHERE idCareer = @idCareer
END
GO
---------------------- <STUDENT - STORE PROCEDURE> --------------------------

----- SELECT -----
CREATE OR ALTER PROCEDURE sp_SelectStudent
(
	@Search VARCHAR(20)
)
AS
BEGIN
	SELECT st.idStudent, st.nameStudent, st.lastnameStudent, st.idCareerStudent, ca.nameCareer
	FROM student st
	INNER JOIN career ca ON st.idCareerStudent = ca.idCareer
	WHERE st.nameStudent LIKE @Search
END
GO

----- INSERT -----
CREATE OR ALTER PROCEDURE sp_InsertStudent
(
	@nameStudent NVARCHAR(50),
	@lastnameStudent NVARCHAR(50),
	@idCareerStudent INT
)
AS
BEGIN
	INSERT INTO student (nameStudent, lastnameStudent, idCareerStudent) 
	VALUES (@nameStudent, @lastnameStudent, @idCareerStudent)
END
GO

----- UPDATE -----
CREATE OR ALTER PROCEDURE sp_UpdateStudent
(
	@idStudent INT,
	@nameStudent NVARCHAR(50),
	@lastnameStudent NVARCHAR(50),
	@idCareerStudent INT
)
AS
BEGIN
	UPDATE student 
	SET nameStudent = @nameStudent, 
		lastnameStudent = @lastnameStudent, 
		idCareerStudent = @idCareerStudent
	WHERE idStudent = @idStudent
END
GO

----- DELETE -----
CREATE OR ALTER PROCEDURE sp_DeleteStudent
(
	@idStudent INT
)
AS
BEGIN
	DELETE FROM student WHERE idStudent = @idStudent
END
GO