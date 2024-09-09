create database LibraryDB

use libraryDB

create table book(
	BookID INT PRIMARY KEY IDENTITY(1,1) not null,
	Title NVARCHAR(255) NOT NULL,
	Author NVARCHAR(255) NOT NULL,
	PublishedYear INT 
)
go

CREATE TABLE Miembros (
    MemberID INT PRIMARY KEY IDENTITY(1,1),
    FullName NVARCHAR(255) NOT NULL,
    JoinDate DATE NOT NULL,
    Email NVARCHAR(255)
)
GO

CREATE TABLE Loan (
    LoanID INT PRIMARY KEY IDENTITY(1,1),
    LoanDate DATE NOT NULL,
    BookID INT NOT NULL, 
    MemberID INT NOT NULL,
    FOREIGN KEY (BookID) REFERENCES Books(BookID),
    FOREIGN KEY (MemberID) REFERENCES Members(MemberID)
)
GO