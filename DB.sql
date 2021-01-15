Use BlogSpot
GO
CREATE TABLE Category
(
	ID INT IDENTITY (1,1) PRIMARY KEY,
	Name NVARCHAR(500),
	Status INT DEFAULT 1,
	CreatedDate DATETIME,
	CreatedBy VARCHAR(20)
)
GO
CREATE TABLE Posts
(
	ID INT IDENTITY (1,1) PRIMARY KEY,
	PostsNamePoster NVARCHAR(50),
	PostsNameDetail NVARCHAR(250),
	ContentIMG VARCHAR(250),
	Content NVARCHAR(MAX),
	Status INT,
	CateID int,
	CreatedDate DATETIME DEFAULT GETDATE(),
	CreatedBy VARCHAR(20)
)
GO
CREATE TABLE Users
(
	ID INT IDENTITY (1,1) PRIMARY KEY,
	FirstName NVARCHAR(100),
	LastName NVARCHAR(100),
	DisplayName NVARCHAR(100),
	BirthDay DATE,
	Nationality NVARCHAR(200),
	Freelance BIT,
	City NVARCHAR(100),
	MobilePhone VARCHAR(20),
	Email NVARCHAR(100),
	SocialNetWork NVARCHAR(100),
	[Languages] NVarchar(100),
	[Status] INT,
	CreatedDate DATETIME
)
GO
	
CREATE TABLE UserAbout
(
	ID INT IDENTITY (1,1) PRIMARY KEY,
	UserID INT,
	Desciption1 NVARCHAR(100),
	Value1 INT,
	Desciption2 NVARCHAR(100),
	Value2 INT,	
	Desciption3 NVARCHAR(100),
	Value3 INT,	
	Desciption4 NVARCHAR(100),
	Value4 INT,
	SkillName XML
)
GO
CREATE TABLE UserHistory
(
	ID INT IDENTITY (1,1) PRIMARY KEY,
	UserID INT,
	StartDate DateTime,
	EndDate DateTime,
	JOB NVARCHAR(100),
	CompanyName NVARCHAR(100),
	Description NVARCHAR(200)
)
Go

CREATE PROC GetInfoUsers
@UserID INT = 1
AS
BEGIN
	SELECT ID,
		   FirstName,
		   U.LastName,
		   U.DisplayName,
		   U.BirthDay,
		   U.Nationality,
		   U.Freelance,
		   U.City,
		   U.MobilePhone,
		   U.Email,
		   U.SocialNetWork,
		   U.Languages
	FROM Users U (NOLOCK)
	WHERE U.Status = 1 AND ID = @UserID;
END