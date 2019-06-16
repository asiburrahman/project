create database Blood_Bank

create table Donar
(
	id int identity primary key,
	name varchar(50),
	blood_group varchar(10),
	fb_id varchar(50),
	mobile varchar(30),
	[address] varchar(50),
	last_donate date
)

create table Receiver
(
	id int identity primary key,
	name varchar(50),
	blood_group varchar(10),
	fb_id varchar(50),
	mobile varchar(30),
	[address] varchar(50)
)