/* Write your T-SQL query statement below */
select
    user_id,
    UPPER(LEFT(name, 1)) + LOWER(SUBSTRING(name, 2, LEN(name))) AS name
from Users
Order By user_id;