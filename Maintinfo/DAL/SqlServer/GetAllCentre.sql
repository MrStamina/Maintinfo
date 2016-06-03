USE [Maintinfo]
GO

/****** Object:  StoredProcedure [dbo].[GetAllCentre]    Script Date: 03/06/2016 11:22:17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[GetAllCentre]
as
Select * From dbo.CENTRE_INFORMATIQUE
GO


