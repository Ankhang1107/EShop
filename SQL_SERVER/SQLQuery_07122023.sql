insert TagProducts
(TagProductId, ProductId, TagId)
values
(
NEWID(),
N'F721919F-7328-4B02-99A3-82A57F758510',
N'C7A18AF0-2BEE-4500-9EF4-9D9594BED81D'
)

select * from TagProducts
---------------------------------------------------------
insert Tag
(TagId, TagName)
values
(
NEWID(),
N'Khuyen mai'
)


select * from Products
select* from Tag






select 
p.ProductId, p.ProductName, t.TagId, t.TagName
from
TagProducts as tp  inner join Products as p
on p.ProductId = tp.ProductId 
left join Tag as t
on tp.TagId = t.TagId


