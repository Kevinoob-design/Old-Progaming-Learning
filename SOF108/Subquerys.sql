use master
go

Create database Subquerys

use Subquerys
go

Create Table tblProducts
(
 [Id] int identity primary key,
 [Name] nvarchar(50),
 [Description] nvarchar(250)
)

Create Table tblProductSales
(
 Id int primary key identity,
 ProductId int foreign key references tblProducts(Id),
 UnitPrice int,
 QuantitySold int
)

Insert into tblProducts values ('TV', '52 inch black color LCD TV')
Insert into tblProducts values ('Laptop', 'Very thin black color acer laptop')
Insert into tblProducts values ('Desktop', 'HP high performance desktop')

Insert into tblProductSales values(3, 450, 5)
Insert into tblProductSales values(2, 250, 7)
Insert into tblProductSales values(3, 450, 4)
Insert into tblProductSales values(3, 450, 9)

--Subquerys, son consultas anidadas. 

Select * from tblProducts
Select * from tblProductSales

Select Id, [Name], [Description] from tblProducts where Id not in 
(select distinct tblProductSales.ProductId from tblProductSales)

Select tblProducts.Id, [Name], [Description] from tblProducts 
full join tblProductSales on tblProducts.Id = tblProductSales.ProductId 
where tblProductSales.ProductId is null

select [Name], (select sum(QuantitySold) from tblProductSales where ProductId = tblProducts.Id) 
as QtySold
from tblProducts
order by QtySold desc

select tblProducts.[Name], SUM(QuantitySold) as QtySold
from tblProducts
full join tblProductSales 
on tblProducts.Id = tblProductSales.ProductId
where tblProductSales.ProductId is null
group by tblProducts.[Name]

Select Id, [Name], [Description] from tblProducts where exists 
(select distinct tblProductSales.ProductId from tblProductSales)

--Subquerys correlacionados

--This a non correlated query, it does not depends of the enclousing query.
Select Id, [Name], [Description] from tblProducts where Id not in 
(select distinct tblProductSales.ProductId from tblProductSales)

Select Id, [Name], [Description] from tblProducts where Id in 
(select distinct tblProductSales.ProductId from tblProductSales)

--This is a correlated query, it depend of the enclousing query.
select [Name], (select sum(QuantitySold) from tblProductSales where ProductId = tblProducts.Id) 
as QtySold
from tblProducts
order by QtySold desc

