CREATE DATABASE [Evahs_Nails]
GO

USE [Evahs_Nails]
GO

/*CREAR TABLA CLIENTES*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[Id_Cliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Completo] [varchar](40) NOT NULL,
	[Direccion] [text] NULL,
	[Telefono] [varchar](40) NULL,
	[Identificacion] [varchar](40) NULL,
	[Fecha_Registro] [nvarchar](40) NOT NULL,
 CONSTRAINT [PK__Clientes__3DD0A8CB16F6E2D6] PRIMARY KEY CLUSTERED 
(
	[Id_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

/*CREAR TABLA PRODUCTOS*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[Id_Producto] [varchar](40) NOT NULL,
	[Nombre_Producto] [varchar](35) NOT NULL,
	[Precio_Compra] [money] NOT NULL,
	[Precio_Venta] [money] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Tipo_Producto] [varchar](40) NOT NULL,
	[Fecha_Registro] [nvarchar](40) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/*CREAR TABLA PROVEEDORES*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedores](
	[Id_Proveedor] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](40) NOT NULL,
	[Correo] [varchar](40) NULL,
	[Telefono] [varchar](40) NULL,
	[Direccion] [text] NULL,
 CONSTRAINT [PK__Proveedo__477B858E4ED92213] PRIMARY KEY CLUSTERED 
(
	[Id_Proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

/*CREAR TABLA SERVICIOS*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servicios](
	[Id_Servicio] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Servicio] [varchar](40) NOT NULL,
	[Descripcion_Servicio] [text] NULL,
 CONSTRAINT [PK__Servicio__5B1345F0CFFE7968] PRIMARY KEY CLUSTERED 
(
	[Id_Servicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

/*CREAR TABLA USUARIOS*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Nombre_Usuario] [varchar](20) NOT NULL,
	[Contrasenia] [varchar](40) NOT NULL,
	[Identificacion] [varchar](40) NOT NULL,
	[Nombre_Completo] [varchar](40) NOT NULL,
	[Telefono] [varchar](40) NULL,
	[Correo] [text] NULL,
	[Direccion] [text] NULL,
	[Tipo_Usuario] [varchar](40) NOT NULL,
	[Fecha_Registro] [nvarchar](40) NULL,
 CONSTRAINT [PK__Usuarios__57A4BD18A29E251E] PRIMARY KEY CLUSTERED 
(
	[Nombre_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

/*CREAR TABLA VENTAS*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[Id_Ventas] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Usuario] [varchar](20) NOT NULL,
	[Id_Cliente] [int] NOT NULL,
	[Total] [money] NULL,
	[Estado] [varchar](40) NULL,
	[Fecha_Registro] [nvarchar](40) NULL,
 CONSTRAINT [PK__Ventas__464C581F44388292] PRIMARY KEY CLUSTERED 
(
	[Id_Ventas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/*CREAR TABLA VENTA_DETALLE_PRODUCTOS*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas_Detalle_Productos](
	[Id_Detalle_Ventas_Producto] [int] IDENTITY(1,1) NOT NULL,
	[Id_Venta] [int] NOT NULL,
	[Id_Producto] [varchar](40) NOT NULL,
	[Precio] [money] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Estado] [varchar](40) NOT NULL,
 CONSTRAINT [PK__Ventas_D__55CF3106DD44B3EF] PRIMARY KEY CLUSTERED 
(
	[Id_Detalle_Ventas_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/*CREAR TABLA VEMTA_DETALLE_PRODUCTO*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas_Detalle_Servicio](
	[Id_Detalle_Ventas_Servicio] [int] IDENTITY(1,1) NOT NULL,
	[Id_Venta] [int] NOT NULL,
	[Id_Servicio] [int] NOT NULL,
	[Precio] [money] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Estado] [varchar](40) NOT NULL,
 CONSTRAINT [PK__Ventas_D__7CC4DE051D373F12] PRIMARY KEY CLUSTERED 
(
	[Id_Detalle_Ventas_Servicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/*MODIFICAR TABLAS CON LA LLAVE FORANEA*/
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [fk_id_cliente] FOREIGN KEY([Id_Cliente])
REFERENCES [dbo].[Clientes] ([Id_Cliente])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [fk_id_cliente]
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [fk_nombre_usuario] FOREIGN KEY([Nombre_Usuario])
REFERENCES [dbo].[Usuarios] ([Nombre_Usuario])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [fk_nombre_usuario]
GO
ALTER TABLE [dbo].[Ventas_Detalle_Productos]  WITH CHECK ADD  CONSTRAINT [fk_id_producto] FOREIGN KEY([Id_Producto])
REFERENCES [dbo].[Productos] ([Id_Producto])
GO
ALTER TABLE [dbo].[Ventas_Detalle_Productos] CHECK CONSTRAINT [fk_id_producto]
GO
ALTER TABLE [dbo].[Ventas_Detalle_Productos]  WITH CHECK ADD  CONSTRAINT [fk_id_ventas_detalle_producto] FOREIGN KEY([Id_Venta])
REFERENCES [dbo].[Ventas] ([Id_Ventas])
GO
ALTER TABLE [dbo].[Ventas_Detalle_Productos] CHECK CONSTRAINT [fk_id_ventas_detalle_producto]
GO
ALTER TABLE [dbo].[Ventas_Detalle_Servicio]  WITH CHECK ADD  CONSTRAINT [fk_id_servicio] FOREIGN KEY([Id_Servicio])
REFERENCES [dbo].[Servicios] ([Id_Servicio])
GO
ALTER TABLE [dbo].[Ventas_Detalle_Servicio] CHECK CONSTRAINT [fk_id_servicio]
GO
ALTER TABLE [dbo].[Ventas_Detalle_Servicio]  WITH CHECK ADD  CONSTRAINT [fk_id_ventas_detalle_servicio] FOREIGN KEY([Id_Venta])
REFERENCES [dbo].[Ventas] ([Id_Ventas])
GO
ALTER TABLE [dbo].[Ventas_Detalle_Servicio] CHECK CONSTRAINT [fk_id_ventas_detalle_servicio]
GO

/*PROCEDIMIENTOS ALMACENADOS*/

/*ELIMINAR PROVEEDOR*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EliminarProveedor]
	@Id_Proveedor	int
AS
BEGIN
	SET NOCOUNT ON;

	DELETE FROM Proveedores WHERE Id_Proveedor=@Id_Proveedor
	END
GO

/*ELIMINAR VENTA_DETALLE_PRODUCTOS*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EliminarVentaDetalleProductos]
	@Id_Detalle_Ventas_Producto	int
AS
BEGIN

	SET NOCOUNT ON;

	 DELETE FROM Ventas_Detalle_Productos WHERE Id_Detalle_Ventas_Producto=@Id_Detalle_Ventas_Producto
END
GO

/*ELIMINAR VENTA_DETALLE_SERVICIOS*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EliminarVentaDetalleServicios]
	@Id_Detalle_Ventas_Servicio	int
AS
BEGIN
	SET NOCOUNT ON;

	DELETE FROM Ventas_Detalle_Servicio WHERE Id_Detalle_Ventas_Servicio=@Id_Detalle_Ventas_Servicio
END
GO

/*INSERTAR USUARIOS*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertarUsuarios]
	@Nombre_Usuario	varchar(20),
	@Contrasenia	varchar(40),
	@Identificacion	varchar(40),
	@Nombre_Completo	varchar(40),
	@Telefono	varchar(40),
	@Correo	text,
	@Direccion	text,
	@Tipo_Usuario	varchar(40),
	@Fecha_Registro	nvarchar(40)
AS
BEGIN
	SET NOCOUNT ON;

	IF EXISTS (SELECT 1 FROM Usuarios WHERE Nombre_Usuario = @Nombre_Usuario)
        PRINT 'Nombre de usuario ya utilizado'
	ELSE
		INSERT INTO Usuarios VALUES (@Nombre_Usuario,@Contrasenia,@Identificacion,@Nombre_Completo,@Telefono,@Correo,@Direccion,@Tipo_Usuario,@Fecha_Registro)
END
GO

/*MODIFICAR CLIENTES*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ModificarClientes]
	@Id_Cliente int,
	@Nombre_Completo	varchar(40),
	@Direccion	text,
	@Telefono	varchar(40),
	@Identificacion	varchar(40),
	@Fecha_Registro	nvarchar(40)
AS
BEGIN
	SET NOCOUNT ON;

	IF EXISTS (SELECT 1 FROM Clientes WHERE Id_Cliente = @Id_Cliente)
        UPDATE Clientes
		SET Nombre_Completo=@Nombre_Completo,Direccion=@Direccion,Telefono=@Telefono,Identificacion=@Identificacion
        WHERE Id_Cliente = @Id_Cliente
	ELSE
		INSERT INTO Clientes VALUES (@Nombre_Completo,@Direccion,@Telefono,@Identificacion,@Fecha_Registro)
END
GO

/*MODIFICAR PRODUCTOS*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ModificarProductos]
	@Id_Producto	varchar,
	@Nombre_Producto	varchar(35),
	@Precio_Compra	money,
	@Precio_Venta	money,
	@Cantidad	int,
	@Tipo_Producto	varchar(40),
	@Fecha_Registro	nvarchar(40)
AS
BEGIN
	SET NOCOUNT ON;

	IF EXISTS (SELECT 1 FROM Productos WHERE Id_Producto = @Id_Producto)
        UPDATE Productos
		SET Nombre_Producto=@Nombre_Producto, Precio_Compra=@Precio_Compra, Precio_Venta=@Precio_Venta, Cantidad=@Cantidad,
			Tipo_Producto=@Tipo_Producto
        WHERE Id_Producto = @Id_Producto
	ELSE
		INSERT INTO Productos VALUES (@Id_Producto,@Nombre_Producto,@Precio_Compra,@Precio_Venta,@Cantidad,@Tipo_Producto,@Fecha_Registro)
END
GO

/*MODIFICAR PROVEEDORES*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ModificarProveedores]
	@Id_Proveedor	int,
	@Nombre	varchar(40),
	@Correo	varchar(40),
	@Telefono	varchar(40),
	@Direccion	text
AS
BEGIN
	SET NOCOUNT ON;

	IF EXISTS (SELECT 1 FROM Proveedores WHERE Id_Proveedor = @Id_Proveedor)
        UPDATE Proveedores
		SET Nombre=@Nombre,Correo=@Correo,Telefono=@Telefono,Direccion=@Direccion
        WHERE Id_Proveedor = @Id_Proveedor
	ELSE
		INSERT INTO Proveedores VALUES (@Nombre,@Correo,@Telefono,@Direccion)
END
GO

/*MODIFICAR SERVICIOS*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ModificarServicios]
	@Id_Servicio	int,
	@Nombre_Servicio	varchar(40),
	@Descripcion_Servicio	text
AS
BEGIN
	SET NOCOUNT ON;

	IF EXISTS (SELECT 1 FROM Servicios WHERE Id_Servicio = @Id_Servicio)
        UPDATE Servicios
		SET Nombre_Servicio=@Nombre_Servicio,Descripcion_Servicio=@Descripcion_Servicio
        WHERE Id_Servicio = @Id_Servicio
	ELSE
		INSERT INTO Servicios VALUES (@Nombre_Servicio,@Descripcion_Servicio)
END
GO

/*MODIFICAR USUARIOS*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ModificarUsuarios]
	@Nombre_Usuario	varchar(20),
	@Contrasenia	varchar(40),
	@Identificacion	varchar(40),
	@Nombre_Completo	varchar(40),
	@Telefono	varchar(40),
	@Correo	text,
	@Direccion	text,
	@Tipo_Usuario	varchar(40),
	@Fecha_Registro	nvarchar(40)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE Usuarios
		SET Contrasenia=@Contrasenia,Identificacion=@Identificacion,Nombre_Completo=@Nombre_Completo,Telefono=@Telefono,
			Correo=@Correo,Direccion=@Direccion,Tipo_Usuario=@Tipo_Usuario
        WHERE Nombre_Usuario = @Nombre_Usuario
	END
GO

/*MODIFICAR VENTA_DETALLE_PRODUCTOS*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ModificarVentaDetalleProductos]
	@Id_Detalle_Ventas_Producto	int,
	@Id_Venta	int,
	@Id_Producto	varchar(40),
	@Precio	money,
	@Cantidad	int,
	@Estado	varchar(40)
AS
BEGIN
	SET NOCOUNT ON;

	IF EXISTS (SELECT 1 FROM Ventas_Detalle_Productos WHERE Id_Detalle_Ventas_Producto = @Id_Detalle_Ventas_Producto)
        UPDATE Ventas_Detalle_Productos
		SET Id_Producto=@Id_Producto,Precio=@Precio,Cantidad=@Cantidad,Estado=@Estado
        WHERE Id_Detalle_Ventas_Producto = @Id_Detalle_Ventas_Producto
	ELSE
		INSERT INTO Ventas_Detalle_Productos VALUES (@Id_Venta,@Id_Producto,@Precio,@Cantidad,@Estado)
END
GO

/*MODIFICAR VENTA_DETALLE_SERVICIOS*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ModificarVentaDetalleServicios]
	@Id_Detalle_Ventas_Servicio	int,
	@Id_Venta	int,
	@Id_Servicio	int,
	@Precio	money,
	@Cantidad	int,
	@Estado	varchar(40)
AS
BEGIN
	SET NOCOUNT ON;

	IF EXISTS (SELECT 1 FROM Ventas_Detalle_Servicio WHERE Id_Detalle_Ventas_Servicio = @Id_Detalle_Ventas_Servicio)
        UPDATE Ventas_Detalle_Servicio
		SET Id_Servicio=@Id_Servicio,Precio=@Precio,Cantidad=@Cantidad,Estado=@Estado
        WHERE Id_Detalle_Ventas_Servicio = @Id_Detalle_Ventas_Servicio
	ELSE
		INSERT INTO Ventas_Detalle_Servicio VALUES (@Id_Venta,@Id_Servicio,@Precio,@Cantidad,@Estado)
END
GO

/*MODIFICAR VENTAS*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ModificarVentas]
	@Id_Ventas	int,
	@Nombre_Usuario	varchar(20),
	@Id_Cliente	int,
	@Total	money,
	@Estado	varchar(40),
	@Fecha_Registro	nvarchar(40)
AS
BEGIN
	SET NOCOUNT ON;

	IF EXISTS (SELECT 1 FROM Ventas WHERE Id_Ventas = @Id_Ventas)
        UPDATE Ventas
		SET Nombre_Usuario=@Nombre_Usuario,Id_Cliente=@Id_Cliente,Estado=@Estado
        WHERE Id_Ventas = @Id_Ventas
	ELSE
		INSERT INTO Ventas VALUES (@Nombre_Usuario,@Id_Cliente,@Total,@Estado,@Fecha_Registro)
END
GO

/*MOSTRAR CLIENTES*/

CREATE PROCEDURE [dbo].[MostrarClientes]
AS
SELECT * FROM Clientes ORDER BY Id_Cliente DESC

GO

CREATE PROCEDURE [dbo].[MostrarServicios]
AS
SELECT * FROM Servicios ORDER BY Id_Servicio DESC

GO

CREATE PROCEDURE [dbo].[MostrarProductos]
AS
SELECT * FROM Productos ORDER BY Id_Producto DESC