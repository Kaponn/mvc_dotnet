IF NOT EXISTS(SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Students')
BEGIN
CREATE TABLE dbo.Students
(
	StudentId INT NOT NULL IDENTITY CONSTRAINT [PK_dbo.Students] PRIMARY KEY,
	[Name] nvarchar(50) NOT NULL,
	LastName nvarchar(50) NOT NULL,
	Age INT NOT NULL,
	Email nvarchar(50) NOT NULL,
	IsActive bit NOT NULL,
);
Print 'Table Students created'
END

INSERT INTO dbo.Students ([Name], LastName, Age, Email, IsActive) VALUES ('Jan', 'Kowalski', 18, 'test1@test.pl', 1);
INSERT INTO dbo.Students ([Name], LastName, Age, Email, IsActive) VALUES ('Anna', 'Nowak', 19, 'test2@test.pl', 0);
INSERT INTO dbo.Students ([Name], LastName, Age, Email, IsActive) VALUES ('Maciej', 'Malinowski', 20, 'test3@test.pl', 0);