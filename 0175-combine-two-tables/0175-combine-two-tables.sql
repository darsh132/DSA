/* Write your T-SQL query statement below */
select a.firstname, a.lastname, b.city, b.state from Person a left join address b
on a.personId = b.personId