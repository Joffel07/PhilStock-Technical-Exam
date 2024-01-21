create proc Std_info_insert
@StudentID int,
@Name nvarchar(20),
@Age int,
@Gender nvarchar(10),
@Birthday datetime,
@Address nvarchar(50),
@Contact_no nvarchar(15),
@Course nvarchar (50),
@Year nvarchar (20),
@Major nvarchar (20)
as begin
insert into Std_Info (StudentID,Name,Age,Gender,Birthday,Address,Contact_no,Course,Year,Major) values (@StudentID,@Name,@Age,@Gender,@Birthday,@Address,@Contact_no,@Course,@Year,@Major)
end

create proc Std_all_info
as begin select * from Std_Info
end

create proc Std_info_update
@StudentID int,
@Name nvarchar(20),
@Age int,
@Gender nvarchar(10),
@Birthday datetime,
@Address nvarchar(50),
@Contact_no nvarchar(15),
@Course nvarchar (50),
@Year nvarchar (20),
@Major nvarchar (20)
as begin
update Std_Info set Name=@Name,Age=@Age,Gender=@Gender,Birthday=@Birthday,Address=@Address,Contact_no=@Contact_no,Course=@Course,Year=@Year,Major=@Major where StudentID=@StudentID
end

create proc Std_info_delete
@StudentID int
as begin delete Std_Info where StudentID=@StudentID end

create proc Std_info_search
@StudentID int
as begin select * from Std_Info where StudentID=@StudentID end