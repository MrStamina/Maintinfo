USE [Maintinfo]
GO

/****** Object:  StoredProcedure [dbo].[GetAllModele]    Script Date: 04/06/2016 09:37:47 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[GetAllModele]
As
Select * from dbo.MODELE
GO

