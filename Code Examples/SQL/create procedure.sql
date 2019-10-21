USE AdventureWorksDW;
GO;
Begin
CREATE PROCEDURE LetsGoProc 
	@variablenamethensize nvarchar(50), 
	@matchingint int, 
	@PostalCode nvarchar(10)
AS
SELECT * FROM dbo.testtable
WHERE testtable.Col1 = @matchingint /*AND PostalCode = @PostalCode*/
End

Drop procedure LetsGoProc

exec letsgoproc 'f7gf'


Alter procedure letsgoproc
	@thisvariableinstead nvarchar(35)
	AS
	Select * from dbo.testtable



Alter procedure procname
		@variable int,
		@variable2 varchar(30),
		@variable3 varchar(10)
	AS
	Select COUNT(Col1)
	From dbo.testtable
	Group by Col1
	Having COUNT(col1) > 1

	exec procname 3,'33','33'
