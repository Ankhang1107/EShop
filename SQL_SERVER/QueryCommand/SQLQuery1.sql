insert
[dbo].[Categories]
([CategoryId], [CategoryName], [Status], [CreatedDate])
values
(
NEWID(),
N'Điều hòa',
3,
GETDATE()
)

select * from [dbo].[Users]



insert  [dbo].[Users]
([UserId], [UserName], [Password], [Email], [Mobile], [Status], [CreateDate])
values
(
NEWID(),
N'Vu Van Hung',
N'11223344',
NULL,
N'0113242495',
5,
GETDATE()
)



