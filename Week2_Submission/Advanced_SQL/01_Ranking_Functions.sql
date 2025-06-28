-- Ranking Function Example
SELECT EmployeeID, DepartmentID, Salary,
       RANK() OVER(PARTITION BY DepartmentID ORDER BY Salary DESC) AS RankInDept
FROM Employees;