/* Write your T-SQL query statement below */
select Max(salary) as SecondHighestSalary from Employee
where salary <
(select Max(Salary) from Employee)