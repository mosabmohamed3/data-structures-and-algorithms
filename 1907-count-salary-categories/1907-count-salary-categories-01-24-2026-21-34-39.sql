/* Write your T-SQL query statement below */
-- with LowSalary as(
--     select count(*) as accounts_count
--     from Accounts
--     where income < 20000
-- ),
-- AveSalary as(
--     select count(*) as accounts_count
--     from Accounts
--     where income >= 20000 and income <= 50000
-- ),
-- HighSalary as(
--     select count(*) as accounts_count
--     from Accounts
--     where income > 50000
-- )
-- select 'Low Salary' as category, accounts_count from LowSalary
-- union all
-- select 'Average Salary' as category, accounts_count from AveSalary
-- union all
-- select 'High Salary' as category, accounts_count from HighSalary

select category, accounts_count
from (
    select
        sum(case when income < 20000 then 1 else 0 end) as low_cnt,
        sum(case when income >= 20000 and income <= 50000 then 1 else 0 end) as avg_cnt,
        sum(case when income > 50000 then 1 else 0 end) as high_cnt
    from Accounts
) as s
cross apply (values
    ('Low Salary',     s.low_cnt),
    ('Average Salary', s.avg_cnt),
    ('High Salary',    s.high_cnt)
) v (category, accounts_count);
