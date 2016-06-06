USE [Maintinfo]
GO

/****** Object:  StoredProcedure [dbo].[GetEquipementByCentre]    Script Date: 06/06/2016 10:48:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [dbo].[GetEquipementByCentre]
@idCentre int
As
Select [NUMEROSERIE],[LIBELLEMODELE],[TARIFMODELE]
from dbo.EQUIPEMENT
join [dbo].[MODELE] on dbo.MODELE.IDMODELE = dbo.EQUIPEMENT.IDMODELE
join [dbo].[TARIF] on dbo.TARIF.CODETARIF = dbo.MODELE.CODETARIF
where dbo.EQUIPEMENT.NUMEROCENTRE = @idCentre
GO

