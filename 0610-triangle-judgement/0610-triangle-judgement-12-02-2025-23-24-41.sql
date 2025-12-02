/* Write your T-SQL query statement below */
SELECT
    x,
    y,
    z,
    case
        when x + y > z and x + z > y and y + z > x
            then 'Yes'
        WHEN x + y <= z OR x + z <= y OR y + z <= x THEN 'No'
        else 'Unknown'
    end as triangle
FROM Triangle;