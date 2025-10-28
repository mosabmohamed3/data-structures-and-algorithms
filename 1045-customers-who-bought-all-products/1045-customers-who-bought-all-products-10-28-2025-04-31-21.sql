/* Write your T-SQL query statement below */
with a as 
(
select distinct *
from Customer
),
product_count as
(
    select count(*) as c
    from Product
)

select customer_id
from a
group by customer_id
having count(*) = (
    select c
    from product_count
)
