create database dineroproject

create table dinero
(
id int identity (1,1) primary key,
caseNo varchar (50) not null,
surname varchar (250) not null,
othername varchar (250) not null,
gender varchar (250) not null,
dob varchar (250) not null,
telephone bigint not null,
email varchar (250) not null,
ofaddress varchar (250) not null,
witname varchar (250) not null,
roa varchar (250) not null,
doa varchar (250) not null,
occup varchar (250) not null,
witno bigint not null, 
witaddress varchar (250) not null,
)
caseNo, surname, othername, gender, dob, telephone, email, ofaddress, witname, roa, doa, occup, witno, witaddress
select * from dinero 

