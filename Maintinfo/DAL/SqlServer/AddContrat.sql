USE [Maintinfo]
GO
/****** Object:  StoredProcedure [dbo].[AddContrat]    Script Date: 06/06/2016 15:01:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[AddContrat]
@idContrat int OUTPUT,
@idclient int,
@idCentre int,
@montant money,
@datedebut Datetime,
@dateecheance Datetime,
@commentaire varchar(100)=null

As
Insert dbo.CONTRAT 
(NUMCLIENT,NUMEROCENTRE,MONTANTCONTRAT,DATEDEBUT,
DATEECHEANCE,COMMENTAIRE)
values(@idclient,@idCentre,@montant,@datedebut,@dateecheance,@commentaire)
Select @idContrat = SCOPE_IDENTITY()