--UC-1 Create Database
create database AddressBookService_119

--UC-2 Create a table 
create table AddressBook_119
(
FirstName varchar(255),
LastName varchar(255),
Address varchar(255),


City varchar(255),
State varchar(255),
ZipCode int,
PhoneNumber bigint,
EmailId varchar(255)
)

select * from AddressBook_119

delete from AddressBook_119