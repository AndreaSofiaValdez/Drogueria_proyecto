select * from Categoria
go
CREATE PROCEDURE SP_CARGARCOMBOBOX
AS
SELECT codigo_categoria,descripcion_categoria FROM Categoria
go

exec SP_CARGARCOMBOBOX