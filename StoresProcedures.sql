create database PuntoAutoPartes
go

use PuntoAutoPartes
go

create table Empleados(
idEmpleado Int primary key identity,
Nombre varchar(100),
Telefono varchar(13),
Correo varchar(200)
)

GO


create table Clientes(
idCliente Int primary key identity,
Nombre varchar(100),
Telefono varchar(14),
Correo varchar(200)
)

GO


create table Producto(
idProducto Int primary key identity,
NombreProducto varchar(50),
Modelo varchar(20),
Descripcion varchar(50),
valorCompra decimal(10,2),
ValorVenta decimal (10,2),
Existencias int not null default 0
)

GO


create table Ventas(
idVenta Int primary key identity,
IdVendedor int references Empleados(idEmpleado),
idCliente int references Clientes(idCliente),
FechaRegistro datetime default getdate()
)

GO


create table Detalle_Venta(
IddetalleVenta Int primary key identity,
IdVenta int references Ventas(idVenta),
IdProducto int references Producto(idProducto),
Cantidad int
)

GO



create PROC SP_REGISTRARCLIENTE(
@idCliente int,
@Nombre varchar(100),
@Telefono varchar(20),
@Correo varchar(70),
@idUsuarioResultado int output,
@Mensaje varchar(500) output)
as 
begin
	set @idUsuarioResultado = 0
	set @Mensaje = ''

if not exists(select * from Clientes where idCliente = @idCliente )
	begin
	insert into Clientes(Nombre,Telefono,Correo) values
	(@Nombre,@Telefono,@Correo)

	set @idUsuarioResultado = SCOPE_IDENTITY()
	end
	else
	set @Mensaje = 'No se puede repetir el codigo'
end
go


create PROC SP_MODIFICARCLIENTE(
@IdCliente int,
@Nombre varchar(100),
@telefono varchar(20),
@Correo varchar(100),
@Direccion varchar(200),
@respuesta bit output,
@Mensaje varchar(500) output)
as 
begin
set @respuesta = 0
set @Mensaje = ''


	if not exists(select * from Clientes  where idCliente != @IdCliente)
	begin
	update Clientes set
	Nombre= @Nombre,
	Telefono = @telefono,
	Correo = @Correo
	where idCliente = @IdCliente

	set @respuesta = 1
	
	end
	else
	set @Mensaje = 'No se puede repetir el Codigo de un empleado'

	end

GO





create PROC SP_REGISTRAREMPLEADO(
@idEmpleado int,
@nombreCompleto varchar(100),
@telefono varchar(15),
@Correo varchar(100),
@idUsuarioResultado int output,
@Mensaje varchar(500) output)
as 
begin
set @idUsuarioResultado = 0
	if not exists(select * from Empleados where idEmpleado = @idEmpleado )
	begin
	insert into Empleados(Nombre,Telefono,Correo) values
	(@nombreCompleto,@telefono,@Correo)

	set @idUsuarioResultado = SCOPE_IDENTITY()
	set @Mensaje = ''
	end
	else
	set @Mensaje = 'No se puede repetir el Codigo de un empleado'


end

GO

create PROC SP_EDITAREMPLEADO(
@IdEmpleado int,
@NombreCompleto varchar(50),
@Telefono varchar(15),
@Correo varchar(100),
@respuesta bit output,
@Mensaje varchar(500) output)
as 
begin
set @respuesta = 0
set @Mensaje = ''


	if exists(select * from Empleados  where idEmpleado = @IdEmpleado)
	begin
	update Empleados set
	Nombre= @NombreCompleto,
	Telefono = @Telefono,
	Correo= @Correo
	where idEmpleado = @IdEmpleado

	set @respuesta = 1

	end
	else
	set @Mensaje = 'No se puede repetir el Codigo de un empleado'


	end

go


create PROC SP_REGISTRARPRODUCTO(
@IdProducto int,
@NombreProducto varchar(50),
@Modelo varchar(50),
@Descripcion varchar(100),
@ValorCompra decimal,
@Resultado bit output,
@Mensaje varchar(500) output
)as 
begin
set @Resultado = 0


if not exists(select*from Producto where idProducto = @IdProducto)
begin
insert into Producto(NombreProducto,Modelo,Descripcion,ValorVenta,valorCompra) 
values(@NombreProducto,@Modelo,@Descripcion,@ValorCompra)
set @Resultado = SCOPE_IDENTITY()
end
ELSE

	SET @Mensaje = 'Ya existe un producto con el mismo codigo'

	end
go




create PROC SP_MODIFICARPRODUCTO(
@IdProducto int,
@NombreProducto varchar(100),
@Modelo varchar(100),
@Descripcion varchar(200),
@ValorCompra decimal,
@Resultado bit output,
@Mensaje varchar(500) output
)as 
begin
set @Resultado = 1

if not exists(select*from Producto where idProducto != @IdProducto)
update Producto set
NombreProducto = @NombreProducto,
Modelo = @Modelo,
Descripcion = @Descripcion,
valorCompra = @ValorCompra
where idProducto = @IdProducto

ELSE
begin
	set @Resultado = 0
	SET @Mensaje = 'Ya existe un producto con el mismo codigo'

	end
end
go





CREATE TYPE [dbo].[EDetalle_Venta] as TABLE(
	[IdProducto] int NULL,
	[Cantidad] int NULL,
	[PrecioProducto] decimal(10,2) NULL
)
go


CREATE PROC SP_REGISTRARVENTA(
@IdVendedor int,
@IdCliente int,
@Detalle_Venta [EDetalle_Venta] READONLY,
@Resultado bit output,
@Mensaje varchar(500) output 
)
as
begin

	begin try
		declare @idVenta int = 0
		set @Resultado = 1
		set @Mensaje = ''
	begin transaction registro

	 insert into Ventas(IdVendedor,idCliente)
	 values(@IdVendedor,@IdCliente)

	 set @idVenta = SCOPE_IDENTITY()

	 insert into Detalle_Venta(IdVenta,IdProducto,Cantidad,PrecioVenta)
	 select @idVenta,IdProducto,Cantidad,PrecioProducto from @Detalle_Venta


	 update p set p.Existencias = p.Existencias - dc.Cantidad
	 from Producto p
	 inner join  @Detalle_Venta dc on dc.IdProducto  =p.idProducto
	commit transaction registro 

	end try
	begin catch
	set @Resultado = 0
	set @Mensaje =  ERROR_MESSAGE()
		rollback transaction registro
	end catch

end

go




create PROC SP_ELIMINAREMPLEADO(
@IdEmpleado int,
@respuesta bit output,
@Mensaje varchar(500) output)
as 
begin
set @respuesta = 0
set @Mensaje = ''
declare @pasoRe bit = 1
		if exists(select *from Ventas V
		inner join Empleados e on e.idEmpleado = V.IdVendedor
		where e.idEmpleado = @IdEmpleado
		)
		BEGIN
		set @pasoRe =0
		set @respuesta=0
		set @Mensaje = 'Este empleado no se puede eliminar por que esta relacionado con una venta'
		END

		if (@pasoRe = 1)
		begin
		DELETE FROM Empleados where idEmpleado = @IdEmpleado
		set @respuesta = 1
		set @Mensaje = 'Se elimino correctamente'
		end
	
	end

	go


create PROC SP_ELIMINARCLIENTE(
@IdCliente int,
@respuesta bit output,
@Mensaje varchar(500) output)
as 
begin
set @respuesta = 0
set @Mensaje = ''
declare @pasoRe bit = 1
		if exists(select *from Ventas V
		inner join Clientes e on e.idCliente = V.idCliente
		where e.idCliente = @IdCliente
		)
		BEGIN
		set @pasoRe =0
		set @respuesta=0
		set @Mensaje = 'Este cliente no se puede eliminar por que esta relacionado con una venta'
		END

		if (@pasoRe = 1)
		begin
		DELETE FROM Clientes where idCliente = @IdCliente
		set @respuesta = 1
		set @Mensaje = 'Se elimino correctamente'
		end
	
	end

	go


create PROC SP_ELIMINARPRODUCTO(
@IdProducto int,
@respuesta bit output,
@Mensaje varchar(500) output)
as 
begin
set @respuesta = 0
set @Mensaje = ''
declare @pasoRe bit = 1

		if exists(select *from Detalle_Venta dv
		inner join Producto e on e.idProducto = dv.IdProducto
		where e.idProducto = @IdProducto
		)
		BEGIN
		set @pasoRe =0
		set @respuesta=0
		set @Mensaje = 'Este cliente no se puede eliminar por que esta relacionado con una venta'
		END

		if (@pasoRe = 1)
		begin
		DELETE FROM Producto where idProducto = @IdProducto
		set @respuesta = 1
		set @Mensaje = 'Se elimino correctamente'
		end
	
	end

	go



Create Trigger ActualizarStock
on Detalle_Venta for insert
as begin
update Producto set
Existencias = Existencias - i.Cantidad
from Producto p
inner join inserted i
on i.IdProducto = p.idProducto
where p.idProducto= i.IdProducto

end
go



create trigger CalcularPrecioVenta
on Producto after update,insert
as begin
	update Producto set
	ValorVenta = i.valorCompra + i.valorCompra * 0.20
	from Producto p
	inner join inserted i
	on i.idProducto = p.idProducto
	where p.idProducto = i.idProducto
end
go
