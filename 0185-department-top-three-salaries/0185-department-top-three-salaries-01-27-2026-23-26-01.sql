/* Write your T-SQL query statement below */
with cte as (
select
    Department.name as Department,
    Employee.name as Employee,
    salary as Salary ,
    DENSE_RANK() over (partition by departmentId order by salary desc) as salary_rank
from Employee
left join Department 
    on Department.id = Employee.departmentId
)
select Department, Employee, Salary
from cte
where salary_rank in (1,2,3)