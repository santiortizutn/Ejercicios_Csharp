/****** Script para el comando SelectTopNRows de SSMS  ******/
/* insert
   delete
   update */
SELECT TOP 1000 [id]
      ,[nombre]
      ,[apellido]
      ,[sexo]
  FROM [Ejemplo1].[dbo].[Persona]