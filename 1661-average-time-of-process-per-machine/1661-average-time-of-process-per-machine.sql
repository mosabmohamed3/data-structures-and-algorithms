/* Write your T-SQL query statement below */
select
    machine_id,
    (Sum(case where activity_type = 'end' then timestamp else 0)
    - Sum(case where activity_type = 'start' then timestamp else 0))
    / Count(distinct process_id) as processing_time
from activity
group by machine_id