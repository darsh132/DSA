/* Write your T-SQL query statement below */
with CTE as (select 
id, 
visit_date,
people,
id - ROW_NUMBER() over (order by id) as island_id
from Stadium
where people >= 100)
select id, visit_date, people
from 
(select id, visit_date, people, 
count(*) over (partition by island_id) as cnt from CTE) T
where cnt >= 3
order by visit_date asc;