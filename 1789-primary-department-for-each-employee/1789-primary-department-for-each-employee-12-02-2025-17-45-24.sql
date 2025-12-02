/* Write your T-SQL query statement below */

with c as (
    select employee_id, count(*) as co
    from Employee
    group by employee_id
)

SELECT e.employee_id, e.department_id
FROM Employee as e
left join c on c.employee_id = e.employee_id
where c.co = 1 or e.primary_flag = 'Y';
