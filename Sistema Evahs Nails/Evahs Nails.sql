create database Evahs_Nails

use Evahs_Nails

create table Usuarios(
Nombre_Usuario varchar(20) primary key not null,
Contrasenia varchar(40) not null,
Identificacion int not null,
Nombre_Completo varchar(40) not null,
Telefono int not null,
Correo text,
Direccion text,
Tipo_Usuario bit not null,
Fecha_Registro datetime
);

create table Clientes(
Id_Cliente int primary key not null,
Nombre_Completo varchar(40)not null,
Direccion text,
Telefono int not null,
Identificacion int not null,
Fecha_Registro datetime not null
);

create table Servicios(
Id_Servicio int primary key identity (1,1) not null,
Nombre_Servicio varchar(40) not null,
Descripcion_Servicio text
);

create table Productos(
Id_Producto int primary key not null,
Nombre_Producto varchar(35) not null,
Precio_Compra money not null,
Precio_Venta money not null,
Cantidad int not null,
Tipo_Producto bit not null,
Fecha_Registro datetime not null
);

create table Ventas(
Id_Ventas int primary key identity(1,1) not null,
Nombre_Usuario varchar(20) not null,
Id_Cliente int not null,
Total money not null,
Estado bit not null,
Fecha_Registro datetime
CONSTRAINT fk_nombre_usuario FOREIGN KEY (Nombre_Usuario) REFERENCES Usuarios (Nombre_Usuario),
CONSTRAINT fk_id_cliente FOREIGN KEY (Id_Cliente) REFERENCES Clientes (Id_Cliente)
);

create table Ventas_Detalle_Productos(
Id_Detalle_Ventas_Producto int primary key not null,
Id_Venta int not null,
Id_Producto int not null,
Precio money not null,
Cantidad int not null
CONSTRAINT fk_id_ventas_detalle_producto FOREIGN KEY (Id_Venta) REFERENCES Ventas (Id_Ventas),
CONSTRAINT fk_id_producto FOREIGN KEY (Id_Producto) REFERENCES Productos (Id_Producto),
);

create table Ventas_Detalle_Servicio(
Id_Detalle_Ventas_Servicio int primary key not null,
Id_Venta int not null,
Id_Servicio int not null,
Precio money not null,
Cantidad int not null
CONSTRAINT fk_id_ventas_detalle_servicio FOREIGN KEY (Id_Venta) REFERENCES Ventas (Id_Ventas),
CONSTRAINT fk_id_servicio FOREIGN KEY (Id_Servicio) REFERENCES Servicios (Id_Servicio),
);

create table Proveedores(
Id_Proveedor int primary key identity(1,1) not null,
Nombre varchar(40) not null,
Correo varchar(40) not null,
Telefono int not null,
Direccion text
);