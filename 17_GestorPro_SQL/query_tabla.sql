-- Query para los productos

-- Crear la Base de Datos
create database GESTOR_PRODUCTO;

-- Usar la base de datos creada
go
use GESTOR_PRODUCTO;
go


-- Tabla de productos
create table Productos(
	IdProducto int primary key identity(1,1),
	Nombre varchar(100) not null,
	Precio decimal(10,2) not null,
	Cantidad int not null,
	Total as (Precio * Cantidad),
);


-- Insertar datos
insert into Productos
values
('Coca Cola', 3.55, 107),
('Pepsi', 2.25, 97),
('Pizza Hut', 4.99, 5);


-- Consulta a la tabla
select * from Productos;

-- Limpiar los datos pues no hay referencias FK en otras tablas
truncate table Productos;