USE [Maintinfo]
GO
/****** Object:  StoredProcedure [dbo].[GetEquipementByCentre]    Script Date: 07/06/2016 14:49:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Procedure [dbo].[GetEquipementByCentre]
@idCentre int
As
Select [NUMEROSERIE],dbo.[EQUIPEMENT].IDMODELE,dbo.MODELE.CODETARIF,[TARIFMODELE],[LIBELLEMODELE]
from dbo.EQUIPEMENT
join [dbo].[MODELE] on dbo.MODELE.IDMODELE = dbo.EQUIPEMENT.IDMODELE
join [dbo].[TARIF] on dbo.TARIF.CODETARIF = dbo.MODELE.CODETARIF
where dbo.EQUIPEMENT.NUMEROCENTRE = @idCentre