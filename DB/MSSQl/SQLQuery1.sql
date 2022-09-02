CREATE SEQUENCE [dbo].[PSRMngDB] 
    AS [int]
    START WITH 1
    INCREMENT BY 1
GO

DECLARE @registerid int
set @registerid = NEXT VALUE FOR dbo.PSRMngDB
PRINT @registerid