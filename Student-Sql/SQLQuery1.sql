create table DetailsStudent
(
  Student_Number int,
  Student_Name varchar(255) not null,
  Gender varchar(255) not null,
  Date_Of_Birth date,
  Phone varchar(10) not null unique,
  Student_Address varchar(255) not null,
  Module_Codes varchar not null,
  Student_Image VARBINARY(MAX)
  )