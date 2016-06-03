USE [Maintinfo]
GO

/****** Object:  StoredProcedure [dbo].[GetAllContrat]    Script Date: 03/06/2016 11:23:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[GetAllContrat]
As
Select * From dbo.CONTRAT
GO

