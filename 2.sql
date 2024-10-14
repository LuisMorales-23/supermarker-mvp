use Supermarket

create table Products 
(
  Products_Id int identity (400000,1) primary key,
  Products_Name nvarchar (80) not null,
  Products_Price int not null,
  Products_Stock int not null,
  Categories_Id int not null,
  FOREIGN KEY (Categories_Id) REFERENCES Categories(Categories_Id)
)

go 
insert into Products values ('Limpido', 2000 ,12,310000)
insert into Products values ('Acetominofen', 2100 ,5,310001)
