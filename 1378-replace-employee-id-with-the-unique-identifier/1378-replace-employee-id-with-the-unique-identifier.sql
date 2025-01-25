/* Write your T-SQL query statement below */
SELECT Minor.unique_id AS unique_id, Main.name AS name
FROM Employees AS Main
LEFT JOIN EmployeeUNI AS Minor ON Main.id = Minor.id