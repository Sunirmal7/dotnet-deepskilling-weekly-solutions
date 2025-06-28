-- Stored Procedure to Add Employee
CREATE PROCEDURE AddEmployee
    @Name NVARCHAR(100),
    @Salary INT
AS
BEGIN
    INSERT INTO Employees (Name, Salary)
    VALUES (@Name, @Salary);
END;

EXEC AddEmployee 'Sunu', 50000;