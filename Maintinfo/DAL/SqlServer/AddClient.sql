Create procedure AddClient
@idClient int out,
@nomClient varchar(40),
@adresseClient varchar(100),
@villeClient varchar(40),
@codePostal varchar(5),
@telClient varchar(12)
As
Insert into dbo.CLIENT ([NOMCLIENT],[ADRESSECLIENT],[VILLECLIENT],[CODEPOSTAL],[TELCLIENT])
values (@nomClient,@adresseClient,@villeClient,@codePostal,@telClient)
Select @idClient = SCOPE_IDENTITY()