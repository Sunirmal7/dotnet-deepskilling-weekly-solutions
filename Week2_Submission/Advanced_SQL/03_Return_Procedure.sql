-- Stored Procedure to Return High Salary Employees
CREATE PROCEDURE GetHighSalaryEmployees
    @MinSalary INT
AS
BEGIN
    SELECT * FROM Employees WHERE Salary > @MinSalary;
END;

EXEC GetHighSalaryEmployees 40000;