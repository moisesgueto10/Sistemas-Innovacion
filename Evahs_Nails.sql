USE [Evahs_Nails]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 28/08/2020 22:47:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[Id_Cliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Completo] [varchar](40) NOT NULL,
	[Direccion] [text] NULL,
	[Telefono] [int] NULL,
	[Identificacion] [int] NULL,
	[Fecha_Registro] [datetime] NOT NULL,
 CONSTRAINT [PK__Clientes__3DD0A8CB16F6E2D6] PRIMARY KEY CLUSTERED 
(
	[Id_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 28/08/2020 22:47:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[Id_Producto] [int] NOT NULL,
	[Nombre_Producto] [varchar](35) NOT NULL,
	[Precio_Compra] [money] NOT NULL,
	[Precio_Venta] [money] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Tipo_Producto] [bit] NOT NULL,
	[Fecha_Registro] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 28/08/2020 22:47:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedores](
	[Id_Proveedor] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](40) NOT NULL,
	[Correo] [varchar](40) NULL,
	[Telefono] [int] NULL,
	[Direccion] [text] NULL,
 CONSTRAINT [PK__Proveedo__477B858E4ED92213] PRIMARY KEY CLUSTERED 
(
	[Id_Proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Servicios]    Script Date: 28/08/2020 22:47:19 ******/
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
/****** Object:  Table [dbo].[Usuarios]    Script Date: 28/08/2020 22:47:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Nombre_Usuario] [varchar](20) NOT NULL,
	[Contrasenia] [varchar](40) NOT NULL,
	[Identificacion] [int] NOT NULL,
	[Nombre_Completo] [varchar](40) NOT NULL,
	[Telefono] [int] NULL,
	[Correo] [text] NULL,
	[Direccion] [text] NULL,
	[Tipo_Usuario] [bit] NOT NULL,
	[Fecha_Registro] [datetime] NULL,
 CONSTRAINT [PK__Usuarios__57A4BD18A29E251E] PRIMARY KEY CLUSTERED 
(
	[Nombre_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 28/08/2020 22:47:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[Id_Ventas] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Usuario] [varchar](20) NOT NULL,
	[Id_Cliente] [int] NOT NULL,
	[Total] [money] NULL,
	[Estado] [bit] NULL,
	[Fecha_Registro] [datetime] NULL,
 CONSTRAINT [PK__Ventas__464C581F44388292] PRIMARY KEY CLUSTERED 
(
	[Id_Ventas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ventas_Detalle_Productos]    Script Date: 28/08/2020 22:47:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas_Detalle_Productos](
	[Id_Detalle_Ventas_Producto] [int] IDENTITY(1,1) NOT NULL,
	[Id_Venta] [int] NOT NULL,
	[Id_Producto] [int] NOT NULL,
	[Precio] [money] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK__Ventas_D__55CF3106DD44B3EF] PRIMARY KEY CLUSTERED 
(
	[Id_Detalle_Ventas_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ventas_Detalle_Servicio]    Script Date: 28/08/2020 22:47:19 ******/
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
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK__Ventas_D__7CC4DE051D373F12] PRIMARY KEY CLUSTERED 
(
	[Id_Detalle_Ventas_Servicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
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
/****** Object:  StoredProcedure [dbo].[EliminarProveedor]    Script Date: 28/08/2020 22:47:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[EliminarProveedor]
	-- Add the parameters for the stored procedure here
	@Id_Proveedor	int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM Proveedores WHERE Id_Proveedor=@Id_Proveedor
	END
GO
/****** Object:  StoredProcedure [dbo].[EliminarVentaDetalleProductos]    Script Date: 28/08/2020 22:47:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[EliminarVentaDetalleProductos]
	-- Add the parameters for the stored procedure here
	@Id_Detalle_Ventas_Producto	int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	 DELETE FROM Ventas_Detalle_Productos WHERE Id_Detalle_Ventas_Producto=@Id_Detalle_Ventas_Producto
END
GO
/****** Object:  StoredProcedure [dbo].[EliminarVentaDetalleServicios]    Script Date: 28/08/2020 22:47:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[EliminarVentaDetalleServicios]
	-- Add the parameters for the stored procedure here
	@Id_Detalle_Ventas_Servicio	int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM Ventas_Detalle_Servicio WHERE Id_Detalle_Ventas_Servicio=@Id_Detalle_Ventas_Servicio
END
GO
/****** Object:  StoredProcedure [dbo].[InsertarUsuarios]    Script Date: 28/08/2020 22:47:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertarUsuarios]
	-- Add the parameters for the stored procedure here
	@Nombre_Usuario	varchar(20),
	@Contrasenia	varchar(40),
	@Identificacion	int,
	@Nombre_Completo	varchar(40),
	@Telefono	int,
	@Correo	text,
	@Direccion	text,
	@Tipo_Usuario	bit,
	@Fecha_Registro	datetime
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF EXISTS (SELECT 1 FROM Usuarios WHERE Nombre_Usuario = @Nombre_Usuario)
        PRINT 'Nombre de usuario ya utilizado'
	ELSE
		INSERT INTO Usuarios VALUES (@Nombre_Usuario,@Contrasenia,@Identificacion,@Nombre_Completo,@Telefono,@Correo,@Direccion,@Tipo_Usuario,@Fecha_Registro)
END
GO
/****** Object:  StoredProcedure [dbo].[ModificarClientes]    Script Date: 28/08/2020 22:47:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ModificarClientes]
	-- Add the parameters for the stored procedure here
	@Id_Cliente	int,
	@Nombre_Completo	varchar(40),
	@Direccion	text,
	@Telefono	int,
	@Identificacion	int,
	@Fecha_Registro	datetime
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF EXISTS (SELECT 1 FROM Clientes WHERE Id_Cliente = @Id_Cliente)
        UPDATE Clientes
		SET Nombre_Completo=@Nombre_Completo,Direccion=@Direccion,Telefono=@Telefono,Identificacion=@Identificacion
        WHERE Id_Cliente = @Id_Cliente
	ELSE
		INSERT INTO Clientes VALUES (@Nombre_Completo,@Direccion,@Telefono,@Identificacion,@Fecha_Registro)
END
GO
/****** Object:  StoredProcedure [dbo].[ModificarProductos]    Script Date: 28/08/2020 22:47:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ModificarProductos]
	-- Add the parameters for the stored procedure here
	@Id_Producto	int,
	@Nombre_Producto	varchar(35),
	@Precio_Compra	money,
	@Precio_Venta	money,
	@Cantidad	int,
	@Tipo_Producto	bit,
	@Fecha_Registro	datetime
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF EXISTS (SELECT 1 FROM Productos WHERE Id_Producto = @Id_Producto)
        UPDATE Productos
		SET Nombre_Producto=@Nombre_Producto, Precio_Compra=@Precio_Compra, Precio_Venta=@Precio_Venta, Cantidad=@Cantidad,
			Tipo_Producto=@Tipo_Producto
        WHERE Id_Producto = @Id_Producto
	ELSE
		INSERT INTO Productos VALUES (@Id_Producto,@Nombre_Producto,@Precio_Compra,@Precio_Venta,@Cantidad,@Tipo_Producto,@Fecha_Registro)
END
GO
/****** Object:  StoredProcedure [dbo].[ModificarProveedores]    Script Date: 28/08/2020 22:47:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ModificarProveedores]
	-- Add the parameters for the stored procedure here
	@Id_Proveedor	int,
	@Nombre	varchar(40),
	@Correo	varchar(40),
	@Telefono	int,
	@Direccion	text
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF EXISTS (SELECT 1 FROM Proveedores WHERE Id_Proveedor = @Id_Proveedor)
        UPDATE Proveedores
		SET Nombre=@Nombre,Correo=@Correo,Telefono=@Telefono,Direccion=@Direccion
        WHERE Id_Proveedor = @Id_Proveedor
	ELSE
		INSERT INTO Proveedores VALUES (@Nombre,@Correo,@Telefono,@Direccion)
END
GO
/****** Object:  StoredProcedure [dbo].[ModificarServicios]    Script Date: 28/08/2020 22:47:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ModificarServicios]
	-- Add the parameters for the stored procedure here
	@Id_Servicio	int,
	@Nombre_Servicio	varchar(40),
	@Descripcion_Servicio	text
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF EXISTS (SELECT 1 FROM Servicios WHERE Id_Servicio = @Id_Servicio)
        UPDATE Servicios
		SET Nombre_Servicio=@Nombre_Servicio,Descripcion_Servicio=@Descripcion_Servicio
        WHERE Id_Servicio = @Id_Servicio
	ELSE
		INSERT INTO Servicios VALUES (@Nombre_Servicio,@Descripcion_Servicio)
END
GO
/****** Object:  StoredProcedure [dbo].[ModificarUsuarios]    Script Date: 28/08/2020 22:47:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ModificarUsuarios]
	-- Add the parameters for the stored procedure here
	@Nombre_Usuario	varchar(20),
	@Contrasenia	varchar(40),
	@Identificacion	int,
	@Nombre_Completo	varchar(40),
	@Telefono	int,
	@Correo	text,
	@Direccion	text,
	@Tipo_Usuario	bit,
	@Fecha_Registro	datetime
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE Usuarios
		SET Contrasenia=@Contrasenia,Identificacion=@Identificacion,Nombre_Completo=@Nombre_Completo,Telefono=@Telefono,
			Correo=@Correo,Direccion=@Direccion,Tipo_Usuario=@Tipo_Usuario
        WHERE Nombre_Usuario = @Nombre_Usuario
	END
GO
/****** Object:  StoredProcedure [dbo].[ModificarVentaDetalleProductos]    Script Date: 28/08/2020 22:47:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ModificarVentaDetalleProductos]
	-- Add the parameters for the stored procedure here
	@Id_Detalle_Ventas_Producto	int,
	@Id_Venta	int,
	@Id_Producto	int,
	@Precio	money,
	@Cantidad	int,
	@Estado	bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF EXISTS (SELECT 1 FROM Ventas_Detalle_Productos WHERE Id_Detalle_Ventas_Producto = @Id_Detalle_Ventas_Producto)
        UPDATE Ventas_Detalle_Productos
		SET Id_Producto=@Id_Producto,Precio=@Precio,Cantidad=@Cantidad,Estado=@Estado
        WHERE Id_Detalle_Ventas_Producto = @Id_Detalle_Ventas_Producto
	ELSE
		INSERT INTO Ventas_Detalle_Productos VALUES (@Id_Venta,@Id_Producto,@Precio,@Cantidad,@Estado)
END
GO
/****** Object:  StoredProcedure [dbo].[ModificarVentaDetalleServicios]    Script Date: 28/08/2020 22:47:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ModificarVentaDetalleServicios]
	-- Add the parameters for the stored procedure here
	@Id_Detalle_Ventas_Servicio	int,
	@Id_Venta	int,
	@Id_Servicio	int,
	@Precio	money,
	@Cantidad	int,
	@Estado	bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF EXISTS (SELECT 1 FROM Ventas_Detalle_Servicio WHERE Id_Detalle_Ventas_Servicio = @Id_Detalle_Ventas_Servicio)
        UPDATE Ventas_Detalle_Servicio
		SET Id_Servicio=@Id_Servicio,Precio=@Precio,Cantidad=@Cantidad,Estado=@Estado
        WHERE Id_Detalle_Ventas_Servicio = @Id_Detalle_Ventas_Servicio
	ELSE
		INSERT INTO Ventas_Detalle_Servicio VALUES (@Id_Venta,@Id_Servicio,@Precio,@Cantidad,@Estado)
END
GO
/****** Object:  StoredProcedure [dbo].[ModificarVentas]    Script Date: 28/08/2020 22:47:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ModificarVentas]
	-- Add the parameters for the stored procedure here
	@Id_Ventas	int,
	@Nombre_Usuario	varchar(20),
	@Id_Cliente	int,
	@Total	money,
	@Estado	bit,
	@Fecha_Registro	datetime
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF EXISTS (SELECT 1 FROM Ventas WHERE Id_Ventas = @Id_Ventas)
        UPDATE Ventas
		SET Nombre_Usuario=@Nombre_Usuario,Id_Cliente=@Id_Cliente,Estado=@Estado
        WHERE Id_Ventas = @Id_Ventas
	ELSE
		INSERT INTO Ventas VALUES (@Nombre_Usuario,@Id_Cliente,@Total,@Estado,@Fecha_Registro)
END
GO
