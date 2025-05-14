/* Write your T-SQL query statement below */
select 
    p.product_id,
    ROUND(
        CASE
            WHEN SUM(u.units) = 0 OR SUM(u.units) IS NULL THEN 0
            ElSE SUM(u.units * p.price) * 1.0 / SUM(u.units)
        END
        ,2
        ) AS average_price
from Prices as p
left join UnitsSold as u on 
    u.product_id = p.product_id and
    u.purchase_date BETWEEN p.start_date AND p.end_date
group by p.product_id