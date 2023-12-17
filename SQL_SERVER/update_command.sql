update [dbo].[Categories]
set CategoryName = N'Smart Phone' , Status = 2
where CategoryId = 'CC591227-BEB4-4D21-B061-3786A064058E'
go
select * from Categories
go


update Users
set UserName = N'Cr7' 
where UserId = '36252146-42BA-4E4F-818B-2CCE99CD6CEE'
go
select * from Users



update Products
set ProductName = N'Iphone 15 pro', Status = 10, Price = 60000000
where ProductId = '4DB2D4CC-1336-457B-985F-71F3AF7A9A23'
go
select * from Products
go