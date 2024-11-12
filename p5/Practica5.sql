create database practica5 
go

use practica5 
go

create table Books(
	id int primary key Identity(1,1),
	Title NVARCHAR(255) NOT NULL,
	Author NVARCHAR(255) NOT NULL,
	PublishedYear INT
)
go

CREATE TABLE Members (
	MemberID INT PRIMARY KEY IDENTITY(1,1),
	FullName NVARCHAR(255) NOT NULL,
	JoinDate DATE NOT NULL,
	Email NVARCHAR(255)
)
go

create table prestamo(
	LoanID INT PRIMARY KEY IDENTITY(1,1),
	LoanDate DATE NOT NULL,
	BookID INT NOT NULL,
	MemberID INT NOT NULL,
	FOREIGN KEY (BookID) REFERENCES Books(id),
	FOREIGN KEY (MemberID) REFERENCES Members(MemberID)
)
go

INSERT INTO Books (Title, Author, PublishedYear) 
VALUES 
('El Quijote', 'Miguel de Cervantes', 1605),
('Cien años de soledad', 'Gabriel García Márquez', 1967),
('1984', 'George Orwell', 1949),
('Donde los árboles cantan', 'Laura Gallego García', 2011),
('La sombra del viento', 'Carlos Ruiz Zafón', 2001);


INSERT INTO Members (FullName, JoinDate, Email) 
VALUES 
('Juan Pérez', '2023-01-15', 'juan.perez@mail.com'),
('Ana Gómez', '2023-02-20', 'ana.gomez@mail.com'),
('Carlos Hernández', '2023-03-10', 'carlos.hernandez@mail.com'),
('María López', '2023-04-25', 'maria.lopez@mail.com'),
('Lucía Fernández', '2023-05-05', 'lucia.fernandez@mail.com');

INSERT INTO prestamo (LoanDate, BookID, MemberID) 
VALUES 
('2023-06-01', 1, 1),
('2023-06-05', 2, 2),
('2023-06-10', 3, 3),
('2023-06-15', 4, 4),
('2023-06-20', 5, 5);


SELECT * FROM Books;
UPDATE Books 
SET Title = 'El Ingenioso Hidalgo Don Quijote de la Mancha' 
WHERE id = 1;

DELETE FROM Books 
WHERE id = 5;

DELETE FROM prestamo 
WHERE BookID = 5;

SELECT * FROM Members;
UPDATE Members 
SET Email = 'carlos.hernandez.new@mail.com' 
WHERE MemberID = 3;

DELETE FROM Members 
WHERE MemberID = 5;

SELECT * FROM prestamo;

UPDATE prestamo 
SET LoanDate = '2023-07-01' 
WHERE LoanID = 2;
