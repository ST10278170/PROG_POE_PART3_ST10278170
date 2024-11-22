# ST10278170 - PROG_POE_PART3

All 10 Files and More are present in the GitHub Main Folder, 
Please see for yourself. 

Kind Regards 


Please also see the SQL DATABASE USED BY ME !!!



Create Database PROG_POE_PART3_ST10278170;
Use PROG_POE_PART3_ST10278170
drop database PROG_POE_PART3_ST10278170;

Create Table AccountUser (
AccountUserID INT IDENTITY(1,1) PRIMARY KEY,
FirstName VARCHAR(50) NOT NULL,
LastName VARCHAR(50) NOT NULL,
Email VARCHAR(100) NOT NULL,
PhoneNumber VARCHAR(15) NOT NULL, 
PasswordHash VARCHAR(50) NOT NULL,
AccountType VARCHAR(50) NOT NULL
);

Select * from AccountUser;
drop table AccountUser;

Create Table Claims (
ClaimsID INT IDENTITY(1,1) PRIMARY KEY,
AccountUserID INT NOT NULL, 
ClassTaught VARCHAR(100),
NoOfSessions INT NOT NULL,
HourlyRatePerSession DECIMAL(10, 2) NOT NULL,
SupportingDocumentPath VARCHAR(225),
ClaimStatus VARCHAR(500) CHECK (ClaimStatus IN ('Pending', 'Approved', 'Rejected')),
ClaimTotalAmount DECIMAL(18,2)
);

Select * from Claims
drop table Claims;

Create Table SupportingDocumets (
DocID INT IDENTITY(1,1) PRIMARY KEY,
ClaimsID INT NOT NULL, 
DocName VARCHAR(100) NOT NULL,
FilePath VARCHAR(255) NOT NULL,
SubmissionDate DATETIME NOT NULL
);

Select * from SupportingDocumets;
drop table SupportingDocumets;

Create Table ClaimStatus (
ClaimStatusID INT IDENTITY(1,1) PRIMARY KEY,
ClaimsID INT NOT NULL,
ClaimStatusConfirmation VARCHAR(50) CHECK (ClaimStatusConfirmation IN ('Pending', 'Approved', 'Rejected')),
StatusDate DATETIME NOT NULL 
);

Select * from ClaimStatus;
drop table ClaimStatus;
