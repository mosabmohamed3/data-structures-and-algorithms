/* Write your T-SQL query statement below */
WITH t1 AS (
    SELECT
        FORMAT(trans_date, 'yyyy-MM') AS [month],
        country,
        state,
        amount
    FROM Transactions
)

select 
    [month],
    country,
    count(*) [trans_count],
    sum(CASE WHEN state = 'approved' Then 1 Else 0 End) [approved_count],
    sum(ISNULL(amount, 0)) [trans_total_amount],
    sum(iif(state = 'approved', ISNULL(t1.amount, 0), 0)) [approved_total_amount]
from t1
group by [month], t1.country