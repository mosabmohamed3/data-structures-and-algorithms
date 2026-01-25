WITH Daily AS (
    SELECT visited_on, SUM(amount) AS daily_amount
    FROM Customer
    GROUP BY visited_on
),
Rolling AS (
    SELECT
        visited_on,
        SUM(daily_amount) OVER (ORDER BY visited_on ROWS BETWEEN 6 PRECEDING AND CURRENT ROW) AS amount,
        ROUND(AVG(1.0 * daily_amount) OVER (ORDER BY visited_on ROWS BETWEEN 6 PRECEDING AND CURRENT ROW), 2) AS average_amount
    FROM Daily
)
SELECT visited_on, amount, average_amount
FROM Rolling
WHERE visited_on >= (SELECT DATEADD(DAY, 6, MIN(visited_on)) FROM Daily)
ORDER BY visited_on;