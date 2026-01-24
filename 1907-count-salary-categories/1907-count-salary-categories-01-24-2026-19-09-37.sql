/* Write your T-SQL query statement below */
with LowSalary as(
    select count(*) as accounts_count
    from Accounts
    where income < 20000
),
AveSalary as(
    select count(*) as accounts_count
    from Accounts
    where income >= 20000 and income <= 50000
),
HighSalary as(
    select count(*) as accounts_count
    from Accounts
    where income > 50000
)
select 'Low Salary' as category, accounts_count from LowSalary
union all
select 'Average Salary' as category, accounts_count from AveSalary
union all
select 'High Salary' as category, accounts_count from HighSalary
