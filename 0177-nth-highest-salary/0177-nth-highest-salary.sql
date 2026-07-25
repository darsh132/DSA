CREATE FUNCTION getNthHighestSalary(@N INT) RETURNS INT AS
BEGIN
    RETURN (
        /* Write your T-SQL query statement below. */
        select top 1 salary
        from (
            select 
                salary, 
                dense_rank() over (order by salary desc) as rnk
            from
                Employee
        ) as SubQuery
        where rnk = @N
    );
END