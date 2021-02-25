Create Table CarImages (
 Id int Primary key Identity(1,1),
 CarId int Not Null,
ImageName varchar(255)  default 'Logo.jpeg',
AddDate date default GETDATE(),
Foreign key(CarId) References Cars(Id)
);
Create Table BrandImages (
Id int Primary key Identity(1,1),
BrandId int Not Null,
ImageName varchar(255)  default 'Logo.jpeg',
AddDate date default GETDATE(),

);