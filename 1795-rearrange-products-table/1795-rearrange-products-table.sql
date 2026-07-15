/* Write your T-SQL query statement below */
select product_id, store, price from Products
UNPIVOT
(
    price FOR store IN (store1, store2, store3)
) as unpvt;