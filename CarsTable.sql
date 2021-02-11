Create Table Brands(
Id int Identity(1,1) Primary Key,
BrandName varchar(255) Not null

)
Create Table Colors(
Id int Identity(1,1) Primary Key,
ColorName varchar(255) Not null

)

Create Table Cars (
Id int Identity(1,1) Primary Key,
BrandId int foreign key references Brands(Id),
ColorId int foreign key references Colors(Id),
ModelYear int Not Null,
DailyPrice decimal Not null,
Description varchar(255)

)