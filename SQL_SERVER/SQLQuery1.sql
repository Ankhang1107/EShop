insert 
[dbo].[Categories]
([CategoryId], [CategoryName], [Status], [CreatedDate])
values
(
NEWID(),
N'Tai nghe',
1,
GETDATE()
)

insert [dbo].[Users]
([UserId], [UserName], [Password], [Email], [Mobile], [Status], [CreateDate])
values
(

)


select * from [dbo].[Users]
select * from [dbo].[Categories]
select * from [dbo].[Products]
go 

delete from [dbo].[Categories] 
where [CategoryId] = 'B5290026-37C5-4647-9365-90A15EC5F909'

insert [dbo].[Products]
(ProductId, ProductName, Price, ManufacoringDate, 
CreatedDate, Description, Status, CategoryId, UserId, Quantity)
values
(
NEWID(),
N'Xiaomi m1',
123000,
N'2014-09-11',
GETDATE(),
N'',

1,
N'CC591227-BEB4-4D21-B061-3786A064058E',
N'36252146-42BA-4E4F-818B-2CCE99CD6CEE',
100
)


--generate script