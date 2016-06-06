Create procedure UpdEquipement
@numSerie int,
@numContrat int
as
Update dbo.EQUIPEMENT 
Set [NUMCONTRAT]=@numContrat
where NUMEROSERIE = @numSerie
