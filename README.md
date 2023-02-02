# AirportFIS
Repository for flight information service


## Readme - Trafico Aéreo
### Resumen
Este proyecto es una aplicación de seguimiento de tráfico aéreo que permite ver la información de llegadas y salidas de aviones. 
El backend está hecho con C# .NET 6 y el frontend está realizado con el framework Vue.js. 
La base de datos es MySQL Workbench 8.

## Instalación
- Clona el repositorio en tu equipo local.
- Instala .NET 6 y Node.js en tu equipo.
- Instala MySQL Workbench 8 y crea una nueva base de datos (flights) con la información de llegadas y salidas de aviones, 
puedes usar el script que se encuentra en la carpeta sql para la creación.
- Para el backend abre el archivo appsettings.json el cual se encuentra en la carpeta WebAeropuerto y configura la cadena de conexión a la base de datos.
- Abre una terminal en la raíz del proyecto y escribe dotnet run para ejecutar el servidor.
- Abre otra terminal en la carpeta airportapi donde esta el frontend de la aplicacion y escribe npm install para instalar las dependencias.
- Luego escribe npm run serve para ejecutar la aplicación frontend.

## Uso
Abre tu navegador y escribe http://localhost:8080 para ver la aplicación. Desde allí podrás ver la información de llegadas y salidas de aviones.

## Colaboración
Si deseas colaborar con el proyecto, por favor crea una nueva rama y envía un pull request con tus cambios.



