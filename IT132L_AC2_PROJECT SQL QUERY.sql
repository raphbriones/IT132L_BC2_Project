drop database IT132L
create database IT132L;
use IT132L;

create table ScheduleTable (PatientName varchar(50) primary key, Date date, Time varchar(50), 
 Status varchar(50));

create table PatientTable (PatientNo int Identity(1,100) primary key, FirstName varchar(50), MiddleName varchar(50), 
LastName varchar(50), Birthday date, Age int, Occupation varchar(50), Status varchar(50) );

create table TreatmentHistoryTable (PatientNo int primary key, Condition varchar(50), Treatment varchar(50), 
Status varchar(50), Date date);

create table ContactInformationTable (PatientNo int primary key, Address varchar(50), EmailAdd varchar(50),
 ContactNo varchar(50));

 create table StockTable (ItemNo int Identity(1,100) primary key, MedicalName varchar(50), GenericName varchar(50), 
 Size varchar(50), AmountInStock varchar(50), Price decimal (20,2), ExpirationDate date, Status varchar(50));

 create table PaymentTable (PatientNo int primary key, Date date, ModeOfPayment varchar(50), 
 AmountPayed decimal (20,2), Balance decimal (20,2));

 select * from ScheduleTable;
 select * from PatientTable;
 select * from TreatmentHistoryTable;
 select * from ContactInformationTable;
 select * from StockTable;
 select * from PaymentTable;

drop table ScheduleTable;
drop table PatientTable;
drop table TreatmentHistoryTable;
drop table ContactInformationTable;
drop table StockTable;
drop table PaymentTable;


insert into ScheduleTable values('Renzel00','09/08/17','18:00','Pending')
insert into ContactInformationTable values ('Bahay','renzellateo11@gmail.com','09074151184')



insert into PatientTable values('Renzel Laurence','Tiamson','Lateo','06/11/1999',18,'unemployed','single pero may crush')


select LastName + ', '+ FirstName+' '+MiddleName+' ' from PatientTable