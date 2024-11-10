# Write your MySQL query statement below
/* Write your T-SQL query statement below */
SELECT name
FROM Customer
WHERE referee_id != 2 OR referee_id IS NULL
ORDER BY name