create database StudentInfo
go
use StudentInfo
go

drop table StudentDetails
go


Go
Use StudentInfo
create table StudentDetails
(
  Student_Number int,
  Student_Name varchar(255) ,
  Gender varchar(255) ,
  Date_Of_Birth VarChar(255),
  Phone varchar(14),
  Student_Address varchar(255) ,
  Module_Codes int ,
  Student_Image int,
  )
  go
 


drop table StudentDetails
  Go


  Use StudentInfo

  INSERT INTO StudentDetails(Student_Number, Student_Name, Gender , Date_Of_Birth, Phone, Student_Address, Module_Codes, Student_Image)
VALUES (5000,'Kieran Mckenzie','Female','1999-01-20','(790) 247-3753','Ap #729-4357 Ut St.',3,1),
  (5007,'Cheyenne Lloyd','Female','1992-01-21','(191) 303-1461','Ap #311-4658 Ornare. Road',3,2),
  (5014,'Keelie Santos','Female','2001-04-13','(621) 434-7636','Ap #394-5670 In Avenue',4,3),
  (5021,'Leigh Craig','Female','1998-10-11','1-968-986-6701','901-4270 Donec Rd.',12,4),
  (5028,'Josephine Morton','Female','1990-04-18','1-717-348-2282','833-4201 Ut, Street',2,1),
  (5035,'Reuben Holland','Male','1997-04-13','1-691-718-3730','597-1666 Nisi. Rd.',11,2),
  (5042,'Marsden Gregory','Male','1997-01-27','1-602-158-1622','Ap #841-8597 Lobortis St.',2,3),
  (5049,'Emerson Clements','Female','1993-03-03','1-568-403-3938','286-648 Suspendisse St.',12,4),
  (5056,'Hector Franco','Male','1991-12-25','(410) 446-8601','942-4995 Et, Avenue',1,1),
  (5063,'Maite Rhodes','Male','2001-09-12','(342) 647-4872','323-7031 Rutrum St.',9,2),
  (5070,'Camden Dickson','Male','2001-02-14','(514) 133-2749','P.O. Box 425, 2497 Proin Avenue',7,3),
  (5077,'Devin Cardenas','Male','1999-06-24','(746) 127-4114','42-287 Amet Av.',4,4),
  (5084,'Charde Benton','Male','1990-01-26','1-447-354-3101','843-3204 Integer Ave',9,3),
  (5091,'Shelley Lindsay','Female','1995-12-02','1-850-365-7674','9366 Euismod Avenue',3,2),
  (5098,'Marsden Steele','Female','2000-08-14','(313) 427-4665','505-3581 Nunc Av.',7,4),
  (5105,'Lars Frazier','Male','1994-04-20','(663) 277-1392','7151 Mauris Ave',2,4),
  (5112,'Lacey Curry','Female','1993-10-23','1-626-988-2968','834-9051 Vestibulum. Rd.',12,2),
  (5119,'Griffith Johnson','Male','1997-03-05','(721) 677-8135','6861 Aliquet, St.',3,3),
  (5126,'Grant Hester','Male','1990-11-16','1-254-723-4179','189-2510 Integer Street',7,3),
  (5133,'Wynter Peterson','Male','2001-01-08','(537) 796-5012','Ap #376-258 Praesent Avenue',9,4),
  (5140,'Drake Sparks','Male','1991-10-21','(971) 695-8968','9180 Sed Road',13,2),
  (5147,'Emery Tran','Female','1990-08-21','(577) 313-3421','558-4614 Lectus Rd.',10,1),
  (5154,'Gil Patel','Male','1993-10-30','1-278-851-5781','Ap #518-8268 Laoreet Rd.',13,2),
  (5161,'Aphrodite Mack','Male','2001-03-01','1-727-145-1258','9804 Malesuada St.',5,3),
  (5168,'Damon Rodgers','Male','1990-04-21','1-246-683-5962','3106 Sagittis Rd.',12,4),
  (5175,'Brenda Fuentes','Female','1992-06-02','(817) 653-1457','Ap #620-5561 Et, Street',8,2),
  (5182,'Carolyn Dean','Female','2000-08-01','(265) 881-3544','721-3810 Ipsum Ave',1,4),
  (5189,'Kimberly Webster','Female','1996-08-30','(773) 132-5654','P.O. Box 648, 5736 Laoreet St.',3,1),
  (5196,'Xyla Mcneil','Female','1991-11-06','1-365-690-8614','P.O. Box 879, 7547 Ullamcorper. Av.',1,2),
  (5203,'Michael Schwartz','Male','1994-08-26', '(825) 747-4874','P.O. Box 277, 9128 Nulla Ave',6,3),
  (5210,'Gregory Mason','Male','1994-09-19','(855) 941-6562','3029 Amet, Rd.',1,3),
  (5217,'Margaret Mcleod','Female','1992-08-08','(971) 316-8337','692-2186 Donec Av.',4,4),
  (5224,'Ori Frank','Male','1994-07-16','(834) 757-2260','9391 Dolor. Avenue',12,2),
  (5231,'Cameron Summers','Female','1994-01-02','1-729-483-6955','8412 Ac St.',3,1),
  (5238,'Tobias Carrillo','Male','1996-02-18','(300) 843-2477','Ap #912-2287 Praesent Av.',9,2),
  (5245,'Chase Mcdonald','Male','1998-09-27','(736) 304-6385','493-1775 Vivamus St.',11,1),
  (5252,'Bevis Herrera','Male','1994-06-23','(864) 456-0388','Ap #426-3438 Ornare Ave',12,3),
  (5259,'Kasper Figueroa','Male','2000-12-07','(751) 771-2345','Ap #714-6118 Semper, Street',12,2),
  (5266,'Tanisha Whitney','Female','1994-07-31','1-728-310-8291','P.O. Box 713, 9121 Nibh Road',3,2),
  (5273,'Alea Heath','Female','1993-12-03','1-867-344-3733','P.O. Box 650, 1723 In Av.',1,4),
  (5280,'Lewis Myers','Male','1995-10-18','(243) 451-7870','Ap #873-1548 Fusce Street',8,3),
  (5287,'Matthew Sellers','Male','1996-02-27','1-311-581-5614','9466 Eleifend Av.',13,2),
  (5294,'Ulysses Hancock','Female','1991-01-02','1-238-857-8619','P.O. Box 569, 1966 Sed St.',2,1),
  (5301,'Raphael David','Female','1990-09-11','1-746-404-2640','904-2074 Proin Rd.',3,2),
  (5308,'Ifeoma Castaneda','Male','1997-02-14','(639) 785-2279','P.O. Box 830, 3959 Libero Street',10,3),
  (5315,'Hasad Morse','Male','2001-10-02','1-836-223-4242','526-7832 Cursus Avenue',13,2),
  (5322,'Malcolm Rutledge','Male','1996-11-18','1-822-717-7819','288-9741 Ut Rd.',5,4),
  (5329,'Michelle Wiggins','Female','1996-07-04','(883) 988-4320','191-2640 Lacinia Street',13,3),
  (5336,'Lucas Neal','Male','1999-12-11','(117) 374-8518','6031 Non St.',2,3),
  (5343,'Emily Velasquez','Female','1991-04-16','1-454-791-4723','206-116 Class Road',7,2);
  go
 
 select * 
 from StudentDetails
 Go



Use StudentInfo
go

drop table ModuleDetails
 go


 create table ModuleDetails
(
  Module_Codes int,
  Module_Name varchar(255),
  Module_Description VarChar(255),
  Module_Link VarChar(255)
  )
  go

 

   INSERT INTO ModuleDetails(Module_Codes, Module_Name, Module_Description, Module_Link)
VALUES
(1, 'LRP281', 'Liniar maths in Excel', 'https://www.youtube.com/watch?v=6xa1x_Iqjzg'),
(2, 'WRP281', 'Creating and validating websites', 'https://www.youtube.com/watch?v=In0nB0ABaUk'),
(3, 'INL282', 'Innovation in diffrent fields', 'https://www.youtube.com/watch?v=Mtjatz9r-Vc'),
(4 , 'DBD281' ,'Creating databases in SQL server', 'https://www.youtube.com/watch?v=jEBx4z3AxG4'),
(5, 'MAT281', 'Mathematics', 'https://www.youtube.com/watch?v=yRwQ7A6jVLk'),
(6, 'LPR282', 'Linear Programming (LP) Optimization with Excel Solver','https://www.youtube.com/watch?v=6xa1x_Iqjzg'),
(7,'PRG282','How to connect C# to SQL (the easy way)','https://www.youtube.com/watch?v=Et2khGnrIqc' ),
(8, 'STA281', 'Statistics', 'https://www.youtube.com/watch?v=GUQJ7zMoSCM'),
(9,'INF281', 'Information systems', 'https://www.youtube.com/watch?v=Qujsd4vkqFI&t=3s'),
(10,'PMM281', 'Project Types','https://www.youtube.com/watch?v=EQeZItIhDOI'),
(11,'WPR281','Programming with Python and JavaScript','https://www.youtube.com/watch?v=NcoBAfJ6l2Q&t=1s' ),
(12,'PRG281','How to Save and Retrieve Image from Database','https://www.youtube.com/watch?v=W_cOlBBlFGM'),
(13,'IOT281','What Is IoT Technology And How It Works','https://www.youtube.com/watch?v=7DZR5UaAM0E')
go

select *
from StudentDetails
go


drop table FullStudentDetails
go



select Student_Number, Student_Name, Gender , Date_Of_Birth, Phone, Student_Address , Cource.Module_Name 
into  StudentsDetail
from StudentDetails
 left join 
Cource
on  StudentDetails.Module_Codes = Cource.Module_Codes 
go

select * 
from StudentsDetail
go