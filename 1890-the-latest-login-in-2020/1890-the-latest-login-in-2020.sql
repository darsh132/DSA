/* Write your T-SQL query statement below */
select
    user_id,
    Max(time_stamp) as last_stamp
from Logins
where Year(time_stamp) = 2020
group by user_id;