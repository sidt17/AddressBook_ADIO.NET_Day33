create procedure spAddDetails
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
Insert into AddressBook_119 values(@FirstName,@LastName,@Address,@City,@State,@ZipCode,@PhoneNumber,@EmailId)
end

