/* Write your T-SQL query statement below */
select c.class
from
    (
    select class, count(student) as student_count
    from Courses
    group by class
    ) c
where c.student_count >= 5