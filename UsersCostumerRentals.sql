Create Table Useres (

Id int Identity(1,1) Primary key,
FirstName varchar(255) Not Null,
LastName varchar(255) Not Null,
Email varchar(255) Not Null,
Password varchar(255) NOT NULL,


);


Create Table Costumeres(

Id int Identity(1,1) Primary key,
UserId int Not Null Foreign key references Useres(Id),
IdentityNumber varchar(11),
Addres varchar(255),
CompanyName varchar(255)


);
Create Table Rentals (

Id int Identity(1,1) Primary key,
CarId int foreign key references Cars(Id),
CostumerId int foreign key references Costumers(Id),
RentDate DateTime ,
ReturnDate DateTime

);


