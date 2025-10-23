select
    p.product_id,
    p.first_year,
    s.quantity,
    s.price
from Sales as s
join(   
        SELECT product_id, MIN(year) AS first_year
        FROM Sales
        GROUP BY product_id
    ) p
on s.product_id = p.product_id and s.year = p.first_year