/* Write your T-SQL query statement below */
select product_name, sum(unit) as unit 
from(
    select product_name, unit
    from Orders
    inner join Products
        on Products.product_id = Orders.product_id
    where order_date between '2020-02-01' and '2020-02-29'
) a
group by product_name
having sum(unit) >= 100
order by product_name desc