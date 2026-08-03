/* Write your T-SQL query statement below */
select request_at as day,
round(sum(case when status != 'completed' then 1.0 else 0.0 end) / count(*), 2) as [Cancellation Rate]
from Trips
where request_at between '2013-10-01' and '2013-10-03'
and client_id in (select users_id from Users where banned = 'No')
and driver_id in (select users_id from Users where banned = 'No')
Group by request_at;