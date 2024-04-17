drop database if exists ManageBooks;
create database ManageBooks;
use ManageBooks;
--------------------------------------------------------------
drop table if exists BookGenres;
create table BookGenres(
	BookGenreId int primary key identity,
	Name nvarchar(50)  COLLATE Vietnamese_CI_AS not null,
	Description nvarchar(500) COLLATE Vietnamese_CI_AS default ''
);
go
--------------------------------------------------------------

drop table if exists Publishers;
create table Publishers(
	PublisherId int primary key identity,
	Name nvarchar(50) COLLATE Vietnamese_CI_AS not null,
	Contact nvarchar(100) COLLATE Vietnamese_CI_AS not null,
	Description nvarchar(500) COLLATE Vietnamese_CI_AS default '',
);
go


--------------------------------------------------------------

drop table if exists Books;
create table Books(
	BookId int primary key identity,
	Name nvarchar(50) COLLATE Vietnamese_CI_AS not null ,
	Summary nvarchar(500) COLLATE Vietnamese_CI_AS default '',
	Quantity int not null check(Quantity >=0),
	ImportPrice money check(ImportPrice >0),
	BookGenreId int not null,
	PublisherId int not null,
	Thumbnails varchar(200) default '\Database\Images\defaultThumbnail.jpg',
	Foreign key (PublisherId) references Publishers(PublisherId),
	Foreign key (BookGenreId) references BookGenres(BookgenreId),
);
go



--------------------------------------------------------------

drop table if exists States;
create table States(
	Id int primary key identity,
	BookId int not null,
	LastChangeDate date default getDate(),
	State nvarchar(20) not null,
	--Primary key(BookId,LastChangeDate),
	Foreign key(BookId) references Books(BookId)
);
go
--------------------------------------------------------------

drop table if exists SellingPrice;
create table SellingPrice(
	BookId int not null,
	LastChangeDate date default getdate(),
	Price money not null check(Price >0)
	Primary key (BookId, LastChangeDate),
	Foreign key (BookId) references Books(BookId),
);
go
--------------------------------------------------------------

drop table if exists Authors;
create table Authors(
	AuthorId int primary key identity,
	Name nvarchar(50) COLLATE Vietnamese_CI_AS not null,
	Contact nvarchar(100) COLLATE Vietnamese_CI_AS not null,
	Description nvarchar(500) COLLATE Vietnamese_CI_AS default ''
);
go
--------------------------------------------------------------

drop table if exists Authorship;
create table Authorship(
	AuthorId int not null,
	BookId int not null,
	Foreign key (AuthorId) references Authors(AuthorId),
	Foreign key (BookId) references Books(BookId),
	Primary key (AuthorId,BookId)
);
go
--------------------------------------------------------------

drop table if exists Suppliers ;
create table Suppliers(
	SupplierId int primary key identity,
	Name nvarchar(50) COLLATE Vietnamese_CI_AS not null,
	Contact varchar(60) not null,
	Description nvarchar(500) COLLATE Vietnamese_CI_AS default '',
);
go


--------------------------------------------------------------

drop table if exists Roles;
create table Roles(
	RoleId int primary key identity,
	Name nvarchar(30) COLLATE Vietnamese_CI_AS not null,
	Description nvarchar(400) COLLATE Vietnamese_CI_AS default '',
);
go
--------------------------------------------------------------
drop table if exists Positions;
create table Positions(
	PositionId int primary key Identity,
	Name nvarchar(100) COLLATE Vietnamese_CI_AS not null,
	Description nvarchar(500) COLLATE Vietnamese_CI_AS default '',
);
go


drop table if exists Employees;
create table Employees(
	EmployeeID int primary key identity,
	Name nvarchar(50) COLLATE Vietnamese_CI_AS not null,
	Gender bit default null,
	Address nvarchar(200) default '',
	Contact varchar(60) not null,
	PositionId int not null,
	Foreign key (PositionId) references Positions(PositionId)
);
go

--------------------------------------------------------------

drop table if exists ComputerAccounts;
create table ComputerAccounts(
	EmployeeId int not null,
	AccountName varchar(20) not null unique,
	Password varchar(30) not null,
	RoleId int not null,
	Primary key (EmployeeID,AccountName), 
	Foreign key (EmployeeId) references Employees(EmployeeId),
	Foreign key (RoleId) references Roles(RoleId)
);
go

--------------------------------------------------------------
drop table if exists  Receipts;
create table Receipts(
	ReceiptId int primary key identity,
	DateOfReceipt date check(DateOfReceipt <= getdate()),
	SupplierId int not null,
	EmployeeId int not null,
	Description nvarchar(500) COLLATE Vietnamese_CI_AS default '',
	Foreign key (SupplierId) references Suppliers(SupplierId),
	Foreign key (EmployeeId) references Employees(EmployeeId)
);
go
--------------------------------------------------------------

drop table if exists ReceiptDetail;
create table ReceiptDetail(
	ReceiptId int not null,
	BookId int not null,
	Foreign key (ReceiptId) references Receipts(ReceiptId),
	Foreign key (BookId) references Books(BookId),
	Quantity int check(Quantity >0),
	Primary key(ReceiptId,BookId)
);
go
--------------------------------------------------------------


drop table if exists Customers;
create table Customers(
	CustomerId int primary key identity ,
	Name nvarchar(50) COLLATE Vietnamese_CI_AS not null,
	Contact varchar(50) not null,
	Gender bit default null,
	Address nvarchar(200) default '',
);
go
alter table Customers
alter column Contact varchar(500) not null;
--------------------------------------------------------------

drop table if exists Invoices;
create table Invoices(
	InvoiceId int primary key identity,
	DateOfInvoice date check(DateOfInvoice<=getdate()),
	CustomerId int not null,
	EmployeeId int not null,
	Foreign key (CustomerId) references Customers(CustomerId),
	Foreign key (EmployeeId) references Employees(EmployeeId)
);
go
--------------------------------------------------------------

drop table if exists InvoiceDetail;
create table InvoiceDetail(
	InvoiceId int not null,
	BookId int not null,
	Quantity int check(Quantity >0),
	Foreign key (InvoiceId) references Invoices(InvoiceId),
	Foreign key (BookId) references Books(BookId),
	Primary key(InvoiceId,BookId)
);
go
--------------------------------------------------------------

drop table if exists Discounts;
create table Discounts(
	BookId int not null,
	DateOfStarting date not null,
	DateOfEnding date not null,
	Discount float not null,
	Description nvarchar(500) default null,
	Foreign key (BookId) references Books(BookId),
	Primary key (BookId, DateOfStarting, DateOfEnding)

);
go
--------------------------------------------------------------


--delete from BookGenres;

insert into BookGenres(Name) values(N'Truyện tranh');
insert into BookGenres(Name) values(N'Sách giáo khoa');
insert into BookGenres(Name) values(N'Viễn Tưởng');
insert into BookGenres(Name) values(N'Truyện ngắn');
insert into BookGenres(Name) values(N'Hành động và phiêu lưu');
insert into BookGenres(Name) values(N'Kinh điển');
insert into BookGenres(Name) values(N'Tiểu thuyết');
insert into BookGenres(Name) values(N'Kinh Tế');


select * from BookGenres;
SELECT BookGenreId, Name as BookGenreName, Description  FROM BookGenres;
--------------------------------------------------------------

--delete from Roles;

insert into Roles(Name,Description) values('Admin','Administrator');
insert into Roles(Name,Description) values('Sales','Sale Employee');

insert into Positions(Name,Description) values
	('Manager',''),
	('Sales',''),
	('Security Guand','');


select * from Roles;
select * from Positions;
--------------------------------------------------------------

--delete from Employees;

insert into Employees(Name,Contact,PositionId) values(N'Lê Tuấn Anh','0765189055',1);
insert into Employees(Name,Contact,PositionId) values(N'Nguyễn Lê Diệu Oanh','0766189933',2);
insert into Employees(Name,Contact,PositionId) values(N'Lê Tuấn Bủm','0234554356',3);

select * from Employees;
--------------------------------------------------------------

insert into ComputerAccounts(EmployeeId,AccountName,Password,RoleId) values(1,'AnhLee','1234',1);

select * from ComputerAccounts;
--------------------------------------------------------------

--delete from Authors; 

insert into Authors(Name,Contact) values
	(N'Nguyễn Tiến Huy','huy@gmail.com'),
	(N'Hoàng Anh Thư','anhthu@yahoo.com'),
	(N'Claire Luong','luong123@gmail.com'),
	(N'Robert HerjaVec','robert@gmail.com'),
	(N'Tony Schwartz','034523432'),
	(N'Dan Senor','dandan@gmail.com'),
	(N'Saul Singer','0123456743'),
	(N'Klaus Schwab','schwad@gmail.com');

select * from Authors;
--------------------------------------------------------------

--delete from Publicers;

insert into Publishers(Name,Contact) values
	(N'Nhà xuất bản Kim Đồng','publisher@gmail.com'),
	(N'Nhà xuất bản Trẻ','publisher@gmail.com'),
	(N'Nhà xuất bản Lao động','publisher@gmail.com'),
	(N'Nhà xuất bản Giáo dục Việt Nam','publisher@gmail.com'),
	(N'Nhà xuất bản Tổng hợp thành phố Hồ Chí Minh','publisher@gmail.com'),
	(N'Nhà xuất bản Chính trị quốc gia Sự thật','publisher@gmail.com');

select * from Publishers;
--------------------------------------------------------------
--delete from Books;

insert into Books(Name,Quantity,ImportPrice,BookGenreId,PublisherId)
	values('Java programming',10,100000,7,1),
	(N'Nghệ thuật đàm phán',12,90000,7,2),
	(N'Cách mạng công nghiệp lần thứ 4',2,10000,3,3),
	(N'Hạt giống tâm hồn',3,34000,7,2);

select * from Books;
--------------------------------------------------------------
insert into SellingPrice(BookId,Price) values
	(1,200000),
	(2,120000),
	(3,30000),
	(4,50000);
insert into SellingPrice values(1,'3/23/2024',120000);

select * from SellingPrice;
select SYSDATETIME();
select Convert(Varchar(10),getdate(),3) as [DD/MM/YYYY];
--delete from Compositions;

insert into Authorship(AuthorId,BookId) 
	values(6,1),
	(5,2),
	(8,3),
	(1,4);
select * from AuthorShip;
--------------------------------------------------------------

--delete from Suppliers;

insert into Suppliers(Name,Contact) values(N'Nhà sách Hồng Ân','0123456789');
insert into Suppliers(Name,Contact) values(N'Nhà xuất bản  Kim Đồng','023456755');
insert into Suppliers(Name,Contact) values(N'Nhà xuất bản Tiền Phong','043432322');

select * from Suppliers;
--------------------------------------------------------------
insert into Customers(Name,Contact,Gender,Address)
	values ('Le Tuan Anh','anh@gmail.com',1,'Can Tho'),
			('Le Thi Em','anh@gmail.com',0,'Hau Giang'),
			('Le Em Anh','anh@gmail.com',1,'Ninh Kieu'),
			('Nguyen Anh Tuan','anh@gmail.com',1,'Can Tho');
select * from customers;
--------------------------------------------------------------


drop function if exists GetBooks;
create function GetBooks()
returns @Book table (
	BookId int,
	BookName nvarchar(50),
	Summary nvarchar(500),
	Quantity int,
	ImportPrice money,
	Price money,
	BookGenre nvarchar(50),
	Publicer nvarchar(50),
	Author nvarchar(50),
	Thumbnails varchar(200))
as 
begin
	insert @Book
	select b.BookId,b.Name,Summary,Quantity,ImportPrice,Price,bg.Name,p.Name,a.Name,Thumbnails from Books b
		inner join BookGenres bg on bg.BookGenreId = b.BookGenreId
		inner join Authorship c on c.BookId = b.BookId
		inner join Authors a on c.AuthorId = a.AuthorId
		inner join Publishers p on p.PublisherId = b.PublisherId
		inner join SellingPrice s on s.BookId = b.BookId
	where LastChangeDate = (
		Select max(LastChangeDate) from SellingPrice
	)
	return;
end;
go

select * from GetBooks();
select * from Books;
select * from Authorship;

--------------------------------------------------------------



drop procedure if exists SetBooks;
create procedure SetBooks(	@Name nvarchar(50),
							@Summary nvarchar(500),
							@Quantity int,
							@ImportPrice money,
							@Price money,
							@BookGenreId int,
							@AuthorId int,
							@PublisherId int,
							@State nvarchar(30),
							@Thumbnail varchar(200))
as
begin
	insert into Books values(@Name,@Summary,@Quantity,@ImportPrice,@BookGenreId,@PublisherId,@Thumbnail);
	declare @BookId int  = (select  SCOPE_IDENTITY());
	select @BookId;
	insert into Authorship values(@AuthorID,@BookId);
	insert into SellingPrice values(@BookId,GETDATE(),@Price);
	insert into States values(@BookId,GETDATE(),@State);
end;
go

select * from States;
declare @id int;
exec SetBooks N'Hello World HTML JS','',1,10000,12000,1,3,2,'In stock';
select @id;

Select * from Books;
select * from GetBooks();
select * from SellingPrice;
--------------------------------------------------------------

drop function if exists GetIdToUpdate;
create function GetIdToUpdate(@BookId int)
returns @Id table(
	AuthorId int,
	BookGenreId int)
as 
begin
	insert @Id
		select c.AuthorId,bg.BookGenreId from Books b
			inner join BookGenres bg on bg.BookGenreId = b.BookGenreId
			inner join Compositions c on c.BookId = b.BookId
			inner join Authors a on c.AuthorId = a.AuthorId
		where b.BookId = @BookId;
	return;
end;
go

select * from GetIdToUpdate(1);
select * from BookGenres;


--------------------------------------------------------------
drop procedure if exists UpdatePrice;
create procedure UpdatePrice(@BookId int, 
							 @LastDate date, 
							 @Price money)
as
begin
	
	insert into SellingPrice values(@BookId, @LastDate,@Price);
end;
go


declare @date date = getDate();
exec UpdatePrice 1,@date,13000;

select * from SellingPrice;

select * from publicers;
--------------------------------------------------------------

drop procedure if exists UpdateBooks;
create procedure UpdateBooks(	@BookId int,
								@Name nvarchar(50),
								@Summary nvarchar(500),
								@Quantity int,
								@ImportPrice money,
								@Price money,
								@BookGenreId int,
								@AuthorId int,
								@PublisherId int,
								@State nvarchar(30),
								@Thumbnails varchar(200))
as
begin
	update Books
	set Name = @Name,
		Summary = @Summary,
		Quantity = @Quantity,
		ImportPrice = @ImportPrice,
		BookGenreId  = @BookGenreId,
		PublisherId = @PublisherId,
		Thumbnails =@Thumbnails
	where BookId = @BookId;

	update Authorship
	set AuthorId  = @AuthorId
	where BookId = @BookId;

	update SellingPrice
	set Price = @Price
	where BookId = @BookId and LastChangeDate = (
		Select Max(LastChangeDate) from SellingPrice
		where BookId = @BookId);
	insert into States values(@BookId,GETDATE(),@State);
	select @BookId;
end;
go

exec UpdateBooks 6,N'Hello World HTML JS And PHP','',2,100000,120000,3,3,2,'In stoke';

select * from GetBooks();

--------------------------------------------------------------
drop procedure if exists DeleteBook;
create procedure DeleteBook(@BookId int)
as
begin
	delete SellingPrice 
	where BookId = @BookId;

	delete Compositions
	where BookId = @BookId;

	delete Books
	where BookId = @BookId;

	Select @BookId;
end;
go

Exec DeleteBook 6;


--------------------------------------------------------------
drop procedure if exists CreateInvoice;
create procedure CreateInvoice(
	@EmployeeId int,
	@CustomerId int)
as
begin
	INSERT INTO Invoices(EmployeeId,CustomerId,DateOfInvoice)
	VALUES(@EmployeeId,@CustomerId,GETDATE());
end;
go

select * from invoices;
select * from Customers;
select * from Employees;
exec CreateInvoice 1,2;


--------------------------------------------------------------

drop procedure if exists GetAuthorName
create procedure GetAuthorName(@id int)
as
begin
	select Name from Authors a inner join Authorship au on a.AuthorId = au.AuthorId
	where BookId = @id;
end;
go

exec GetAuthorName 1;
select * from books;
select * from Authorship;
insert into Authorship(AuthorId,BookId) values(3,1);

drop table if exists GetAuthorId;
create procedure GetAuthorId(@id int)
as
begin
	select a.AuthorId from Authors a inner join Authorship au on a.AuthorId = au.AuthorId
	where BookId = @id;
end;
go

exec GetAuthorId 1;

drop procedure if exists GetPublisher;
create procedure GetPublisherName(@id int)
as
begin
	select p.Name from Books b inner join Publishers p on p.PublisherId = b.PublisherId
	where BookId=@id;
end;
go

exec GetPublisherName 1;

drop procedure if exists GetNumberBookFilter;
create procedure GetNumberBookFilter(@authorId int, @genreId int)
as
begin
	select count(distinct b.BookId),sum(quantity) from Books b
		inner join Authorship au on b.BookId = au.BookId
		inner join Authors a on a.AuthorId = au.AuthorId
	where a.AuthorId=@authorId and BookGenreId=@genreId;
end;
go

--exec GetNumberBookFilter 3,7;
select * from books;
select * from authors;
select * from Authors
select * from bookGenres;

drop procedure if exists GetCurrentPrice;
create procedure GetCurrentPrice (@Id int)
as
begin
	SELECT Price  FROM SellingPrice 
	Where BookId=@id and LastChangeDate Like
               (SELECT Max(LastChangeDate) FROM SellingPrice where BookId=@id);
end;
go


drop procedure GetStateById;
create procedure GetStateById(@id int)
as
begin
	select state from States
	where BookId=@id and LastChangeDate =	
		(Select Max(LastChangeDate) from States where BookId=@id);
end;
go

update Books set Thumbnails='\Database\Images\dac_nhan_tam.jpg' where BookId=1;