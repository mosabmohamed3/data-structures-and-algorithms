SELECT m.name
FROM Employee AS e
JOIN Employee AS m ON e.managerId = m.id
GROUP BY e.managerId, m.name
HAVING COUNT(*) >= 5;
