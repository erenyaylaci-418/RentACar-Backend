Create Table Brands(
BrandId int,
BrandName varchar(255),
Primary key(BrandId)
)

Create Table Colors(
ColorId int,
ColorName varchar(255),
Primary key(ColorId)
)




Create Table Cars (
Id int,
BrandId int,
ColorId int,
ModelYear int,
DailyPrice decimal,
Description varchar(255)
Primary key(Id),
FOREIGN KEY (BrandId) REFERENCES Brands(BrandId),
FOREIGN KEY (ColorID) REFERENCES Colors(ColorId)


)