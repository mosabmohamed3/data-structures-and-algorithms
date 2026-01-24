/* Write your T-SQL query statement below */
with cte as(
    select
        person_name,
        turn,
        sum(weight) over (order by turn) as repetitiveSum
    from Queue
)

select top 1 person_name
from cte
where repetitiveSum <= 1000
order by turn desc;