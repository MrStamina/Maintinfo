USE [Maintinfo]
GO

/****** Object:  StoredProcedure [dbo].[GetAllClient]    Script Date: 02/06/2016 09:49:57 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[GetAllClient]
As
Select * From [dbo].[CLIENT]
GO

