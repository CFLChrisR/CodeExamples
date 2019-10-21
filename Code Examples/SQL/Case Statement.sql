Use AdventureWorks2014;
Select AddressLine1  = CASE
		WHEN AddressLine1 LIKE '%drive%' THEN 'Contains Drive'   
     ELSE 'Does not contain drive'
END   

from Person.Address;