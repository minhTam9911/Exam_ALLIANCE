create database QuanLyNhanSu
go

use QuanLyNhanSu
go

create table Employee(
	id int primary key identity,
	"name" nvarchar(255) not null,
	"address"  nvarchar(max) not null,
	phone  varchar(20) not null,
	email  nvarchar(255) not null,
	join_date date not null,
	department_id int not null,
	role_id int not null default 1,
	is_active bit
)
go


create table Department (
    id int primary key identity,
    "name" nvarchar(255) not null,
    manager_id int unique,
)
go

alter table Department
add constraint FK_Department_Employee 
foreign key (manager_id) references Employee (id)
go


create table Welcome(
 id int primary key identity,
 employee_id int not null,
 "date" date not null
)
go

create table "Role"(
	id int primary key identity,
	"name" nvarchar(255) not null,
)
go

create table Account(
	id int primary key identity,
	username varchar(max) not null,
	"password" varchar(max) not null,
	employee_id int ,
	role_id int not null
)
go

create table Time_Recorder(
 id int primary key identity,
 employee_id int not null,
 check_in_time datetime not null,
 check_out_time datetime not null
)
go


create table Meeting(
	id int primary key identity,
	start_time datetime not null,
	end_time datetime not null,
	attendees int not null
)
go

select  Department.id as Department_id, count(Employee.id) as Total_Employee
from Department 
left join  Employee 
on Employee.department_id = Department.id
group by Department.id


select e.id, e."name", t.check_in_time from Employee e
join  Time_Recorder t
on e.id = t.employee_id
where DATEPART(dw,t.check_in_time) = 2 
and CAST(t.check_in_time AS TIME) > '08:00:00'

--alter table Employee
--add constraint unique_employee_id unique (id)

--insert into Department("name",manager_id) values('Tư Vấn',7)
--go
--insert into Department("name",manager_id) values('Tài Chính',7)
--go

--alter table Employee 
--add constraint Check_Only_Manager_Deparment
--Check (
--(select count(*) from Emloyee 
-- join Department  on Department.id = Employee.department_id 
--where role_id = 2 and Department.id = inserted.department_id
--) <=1
--)
--go


--create trigger Trigger_Only_Manager_Employee
--on Employee
--after insert, update
--as
--begin
 --   if exists (
 --       select department_id
 --       from inserted
 --      group by department_id
--			having count(*) > 1
--    )
--    begin
 --       rollback transaction
 --   end
--end
--go