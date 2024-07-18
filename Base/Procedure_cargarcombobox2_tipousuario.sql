select * from Tipo_Usuario
go
CREATE PROCEDURE CARGARCOMBOBOX2
AS
SELECT codigo_tipo,nombre_tipo FROM Tipo_Usuario
go

exec CARGARCOMBOBOX2