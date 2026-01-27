WITH cte AS (
    SELECT
        tiv_2016,
        tiv_2015,
        COUNT(*) OVER (PARTITION BY tiv_2015) AS tiv_2015_count,
        COUNT(*) OVER (PARTITION BY lat, lon) AS location_count
    FROM insurance
)
SELECT CAST(SUM(CAST(tiv_2016 AS DECIMAL(10,2))) AS DECIMAL(10,2)) AS tiv_2016
FROM cte
WHERE location_count = 1
  AND tiv_2015_count > 1;