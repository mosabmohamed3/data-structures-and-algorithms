/* Write your T-SQL query statement below */
select r.contest_id,
        round(count(r.contest_id)*100.0/(select count(distinct user_id) from Users), 2) as percentage 
from Users as u
inner join Register as r on u.user_id = r.user_id
group by r.contest_id
order by percentage desc, contest_id;