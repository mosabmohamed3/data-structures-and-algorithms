/* Write your T-SQL query statement below */
select eu.unique_id, e.name
from Employees as e
left join EmployeeUNI eu ON e.id = eu.id