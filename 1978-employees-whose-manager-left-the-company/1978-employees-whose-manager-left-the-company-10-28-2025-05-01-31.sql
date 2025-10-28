/* Write your T-SQL query statement below */
-- select t.employee_id
-- from (
--     select employee_id, manager_id
--     from Employees
--     where salary < 30000    
-- ) as t
-- left join Employees as e on t.manager_id = e.employee_id
-- where e.employee_id is null

select e.employee_id
from Employees as e
where
    salary < 30000
    and
    e.manager_id is not null
    and
    not exists(
        select 1
        from Employees as m
        where m.employee_id = e.manager_id
    )
order by e.employee_id asc

