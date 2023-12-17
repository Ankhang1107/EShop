


---------------PRODUCT-------------------------------------------
select * from Products

insert Products
(ProductId, ProductName, Price, ManufacoringDate, CreatedDate, 
Status, CategoryId, UserId, Quantity)
values
(
NEWID(),
N'Vision 2023',
40000000,
'2023-09-11',
GETDATE(),
1,
'A2D60A6B-4CEB-44CC-9516-B59C0FFE04F6',
'ABB9CA80-6E0C-492F-8AAA-68D8D4A623D9', 
100
)

delete Products where ProductId = '1F58378E-E488-42FF-8108-60696F58E7B0'
delete Products where CategoryId = '4D7E692D-93D4-4C46-AD26-716AFFC6105E'
---------------------------------------------------------------------------


-----------------CATEGORIES----------------------------
select * from Categories

insert Categories
(CategoryId, CategoryName, Status, CreatedDate)
values
(NEWID(), N'Xe máy', 1, GETDATE())


delete Categories where CategoryId = 'A2D60A6B-4CEB-44CC-9516-B59C0FFE04F6'
---------------------------------------------

select * from Users

---TRUY VẤN DỮ LIỆU-------------------------
select * from Products 
where ProductName like N'%14%' 

select 
p.ProductId,
p.ProductName,
p.Price,
u.UserName

from
Products as p
inner join 
Users as u
on u.UserId = p.UserId


select 
p.CategoryId,
c.CategoryName,
p.ProductId,
p.ProductName

from 
Products as p
full join
Categories as c
on p.CategoryId = c.CategoryId


select 
p.ProductId,
p.ProductName,
c.CategoryName,
u.UserName

from
Users as u
inner join
Products as p
on u.UserId = p.UserId
full join 
Categories as c
on p.CategoryId = c.CategoryId




