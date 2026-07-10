CREATE FUNCTION getNthHighestSalary (@N INT)
RETURNS INT
AS
BEGIN
    DECLARE @Result INT;

    SELECT @Result = Salary
    FROM (
        SELECT Salary,
               DENSE_RANK() OVER (ORDER BY Salary DESC) AS SalaryRank
        FROM Employee
    ) AS T
    WHERE SalaryRank = @N;

    RETURN @Result;
END;