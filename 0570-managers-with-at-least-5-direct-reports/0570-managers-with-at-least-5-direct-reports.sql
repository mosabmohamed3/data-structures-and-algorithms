SELECT DISTINCT m.name
FROM Employee AS e
JOIN Employee AS m ON e.managerId = m.id
WHERE e.managerId IS NOT NULL;