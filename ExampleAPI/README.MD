# Pasos 

## 1. Crear el proyecto
<code> dotnet new webapi -n "nombre" --use-controllers </code>

## 2. Creamos carpeta y modelos.
En ellas creamos su relación con las claves primarias y foráneas como se especifica en la clase vehiculo

## 3. Creamos la carpeta Data y el DB Context.
## 4. Creamos el .env con las credenciales de la DB
## 5. Conexión en Program.cs de la DB con variables del .env
## 6. Migración a la base de datos de la siguiente manera:
<code> dotnet ef add migrations "nombre" </code>

## 7. Enviamos las tablas a la DB
<code> dotnet ef database update </code>


## NuGets necesarios:

- DotnetEnv: Variables de DB
- Entity
- Entity.Tools: Migraciones
- Entity.Design: Diseñar la base de datos
- Pomelo MySQL: Conexión con MySQL como motor de la DB

## FluentAP:

No es un NuGet, por lo que no es necesario instalarlo. Permite añadir validaciones directamente en el AppDbContext para la DB similar a las Data Annotations, para no hacerlo en los modelos. El método se llama OnModelCreating, heredado del DbContext.