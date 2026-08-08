/* Write your T-SQL query statement below */
select a.name as name, IsNull(sum(b.distance), 0) as travelled_distance 
from Users a 
left join Rides b 
on a.id = b.user_id
group by a.id, a.name
order by travelled_distance desc, a.name asc