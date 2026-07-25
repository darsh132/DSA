/* Write your T-SQL query statement below */
select 
    patient_id,
    patient_name,
    conditions
from Patients
where conditions Like 'DIAB1%'
    or conditions like '% DIAB1%';