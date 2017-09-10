drop database IT132L
create database IT132L;
use IT132L;

create table ScheduleTable (PatientName varchar(50) primary key, Date date, Time varchar(50), 
 Status varchar(50));

create table PatientTable (PatientNo int Identity(1,100) primary key, FirstName varchar(50), MiddleName varchar(50), 
LastName varchar(50), Birthday date, Age int, Occupation varchar(50), Status varchar(50) );

create table TreatmentHistoryTable (PatientNo int , Condition varchar(50), Treatment varchar(50), 
Status varchar(50), Date date primary key);

create table ContactInformationTable (PatientNo int primary key, Address varchar(50), EmailAdd varchar(50),
 ContactNo varchar(50));

 create table StockTable (ItemNo int Identity(1,100) primary key, MedicalName varchar(50), GenericName varchar(50), 
 Size varchar(50), AmountInStock varchar(50), Price decimal (20,2), ExpirationDate date, Status varchar(50));

 create table PaymentTable (PatientNo int , Date date, ModeOfPayment varchar(50), 
 AmountPayed decimal (20,2), Balance decimal (20,2),status varchar(50),primary key(PatientNo , date))
 create Table datea(date1 date,date2 date)

 create Table PaymentReports (PatientNo int , Date date, ModeOfPayment varchar(50), 
 AmountPayed decimal (20,2), Balance decimal (20,2),status varchar(50),primary key(PatientNo , date))
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

insert into ScheduleTable values('Renzel0','09/09/17','18:00','Pending')
insert into ContactInformationTable values ('Bahay','renzellateo11@gmail.com','09074151184')
insert into datea values('09/10/2017','09/09/2017')

select *from PaymentTable where Date  between 
insert into PaymentTable values(101,'09/03/2017','Cash',2000,300,'Not Payed');
 select sum(amountPayed) As TotalPayed from PaymentTable
insert into TreatmentHistoryTable values(201,'MASAKIT NA NGIPIN','TANGGALAN NG NGIPIN','completed','12/08/2017')
insert into PatientTable values('Renzel Laurence','Tiamson','Lateo','06/11/1999',18,'unemployed','single pero may crush')


select LastName + ', '+ FirstName+' '+MiddleName+' ' from PatientTable