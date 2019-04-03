/*
Plantilla de script posterior a la implementación							
--------------------------------------------------------------------------------------
 Este archivo contiene instrucciones de SQL que se anexarán al script de compilación.		
 Use la sintaxis de SQLCMD para incluir un archivo en el script posterior a la implementación.			
 Ejemplo:      :r .\miArchivo.sql								
 Use la sintaxis de SQLCMD para hacer referencia a una variable en el script posterior a la implementación.		
 Ejemplo:      :setvar TableName miTabla							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

INSERT INTO [dbo].[Profesion] (nombre_Profesion) VALUES ('Sin Profesion');
INSERT INTO [dbo].[Profesion] (nombre_Profesion) VALUES ('Informatico');
INSERT INTO [dbo].[Profesion] (nombre_Profesion) VALUES ('Chofer');
INSERT INTO [dbo].[Profesion] (nombre_Profesion) VALUES ('Administrador');

INSERT INTO [dbo].[Persona]
           ([num_cedula]
           ,[primer_nombre]
           ,[segundo_nombre]
           ,[primer_apellido]
           ,[segundo_apellido]
           ,[fecha_nacimiento]
           ,[genero]
           ,[correo_electronico]
           ,[telefono_celular]
           ,[telefono_fijo]
           ,[direccion]
           ,[abortos]
           ,[vivos]
           ,[fallecidos]
           ,[prematuros]
           ,[num_hermanos]
           ,[id_pais]
           ,[id_EstadoCivil]
           ,[id_Escolaridad]
           ,[id_Profesion])
     VALUES
           (123456789
           ,'Juan'
           ,'Daniel'
           ,'Perez'
           ,'Garcia'
           ,convert(date,'10/07/1996')
           ,'M'
           ,'juan.perez@mail.com'
           ,'88888989'
           ,'22441010'
           ,'Heredia, Costa Rica'
           ,0
           ,0
           ,0
           ,0
           ,1
           ,'Costa Rica'
           ,'Soltero'
           ,'Universidad Incompleta'
           ,2);


INSERT INTO dbo.Usuario (num_cedula,contrasena) VALUES (123456789,'dc647eb65e6711e155375218212b3964');