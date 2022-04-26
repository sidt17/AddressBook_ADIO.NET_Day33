create procedure spDeleteDetails
(

@FirstName varchar(255)

)
as
begin
delete from AddressBook_119  where FirstName=@FirstName
end
