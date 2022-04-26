create procedure spEditDetails
(
@FirstName varchar(255),
@LastName varchar(255),
@Address varchar(255),
@City varchar(255),
@State varchar(255),
@ZipCode int,
@PhoneNumber bigint,
@EmailId varchar(255)

)
as
begin
update  AddressBook_119 set FirstName=@FirstName,LastName=@LastName,Address=@Address,City=@City,State=@State,ZipCode=@ZipCode,PhoneNumber=@PhoneNumber,EmailId=@EmailId where FirstName=@FirstName
end