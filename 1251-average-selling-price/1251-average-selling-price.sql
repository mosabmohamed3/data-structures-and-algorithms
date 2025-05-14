/* Write your T-SQL query statement below */
select 
    p.product_id,
    ROUND( 
        COALESCE(SUM(u.units * p.price), 0) * 1.0 / NULLIF(SUM(u.units), 0)
        ,2) AS average_price
from Prices as p
left join UnitsSold as u on 
    u.product_id = p.product_id and
    u.purchase_date BETWEEN p.start_date AND p.end_date
group by p.product_id