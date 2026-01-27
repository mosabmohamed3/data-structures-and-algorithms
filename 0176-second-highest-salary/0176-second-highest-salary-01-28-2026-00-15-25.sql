SELECT 
    (
        SELECT DISTINCT salary AS SecondHighestSalary
        FROM Employee
        ORDER BY salary DESC
        OFFSET 1 ROW FETCH NEXT 1 ROW ONLY
    ) AS SecondHighestSalary;
