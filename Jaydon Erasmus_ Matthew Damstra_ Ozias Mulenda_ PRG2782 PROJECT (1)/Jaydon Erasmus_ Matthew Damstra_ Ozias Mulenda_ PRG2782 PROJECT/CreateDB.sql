CREATE DATABASE StudentsDB;

GO

USE StudentsDB
CREATE TABLE Students(

StudentNo int  IDENTITY(1,1) primary key,
StudentName varchar(100) not null,
StudentSurname varchar(100) not null,
StudentImage varchar(255) not null,
DOB date not null,
Gender varchar(50) not null,
Phone varchar(10) not null,
StudentAddress varchar(100) not null,
ModuleCodes varchar(255) not null

);

CREATE TABLE Modules(

ModuleCode varchar(50) not null,
ModuleName varchar(100) not null,
ModuleDescription varchar(255) not null,
Links varchar(255) not null

);