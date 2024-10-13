use Supermarket

create table Categories 
(
	Categories_Id int identity (310000,1) Primary key,

	Categories_Name nvarchar (80) not null,

	Categories_Descripction nvarchar (50) not null,
)

go 
insert into Categories values ('Cleaning','Cleaning product')
insert into Categories values ('Medicine','Medicine product')