Create Procedure GetEquipementByCentre
@idCentre int
As
Select * from dbo.EQUIPEMENT
where dbo.EQUIPEMENT.NUMEROCENTRE = @idCentre