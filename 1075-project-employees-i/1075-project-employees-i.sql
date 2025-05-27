/* Write your T-SQL query statement below */
select  p.project_id, Round( AVG( CAST(experience_years as decimal)) ,2) as average_years
from Project as p
inner join Employee as e on p.employee_id = e.employee_id
group by p.project_id