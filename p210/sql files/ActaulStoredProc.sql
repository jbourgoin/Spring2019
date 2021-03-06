

USE [Prog210northwind]
GO
/****** Object:  StoredProcedure [dbo].[InsertNewProduct]    Script Date: 01/26/2009 19:24:15 ******/


Create proc [dbo].[InsertNewProduct]

-- Input parameters
@ProductName nvarchar(40),
@SupplierID int,
@CategoryID int,
@QuantityPerUnit nvarchar(20),
@UnitPrice money ,
@UnitsInStock smallint,
@UnitsOnOrder smallint,
@ReorderLevel smallint,
@Discontinued bit,


-- Output parameters
@ProductID int output

as

insert into Products
(ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,
ReorderLevel,Discontinued)
Values( @ProductName,@SupplierID,@CategoryID,@QuantityPerUnit,@UnitPrice,@UnitsInStock,
@ReorderLevel,@Discontinued)


-- here is where we write an "out" parameter.  Very much like a C# out parameter in a method call
Set @ProductID = @@Identity
