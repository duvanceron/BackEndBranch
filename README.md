# BackEndBranch
BRANCH CRUD
Se debe clonar o descargar el codigo atraves de consola.
Restaurar los Nuget Package para que se instalen las dependencias del proyecto.
Configurar ConnectionString , este se encuentra en el archivo appsettings.development.json 
El proyecto esta realizado con EF Core, por tal motivo orrer la migraciones del proyecto, para esto nos dirigimos al 
Package Manager Console y ejecutamos el comando add-Migration Initial para que se creen las tablas y luego Update-Database
Se debe tener en cuenta encuenta el puerto con el cual se levanta el localhost ya que asi mismo se debe habilitar el CORS
