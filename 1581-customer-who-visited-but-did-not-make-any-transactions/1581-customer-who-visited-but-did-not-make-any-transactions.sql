/* Write your T-SQL query statement below */
select customer_id, COUNT(v.visit_id) as count_no_trans 
from Visits as v
left join Transactions as t on v.visit_id = t.visit_id
where t.transaction_id is null
group by v.customer_id
