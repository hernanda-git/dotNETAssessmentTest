--CREATE TABLE #TEST2 ([Id] INT, [A] BIT, [B] BIT, [C] BIT, [D] BIT, [E] BIT)
--INSERT INTO #TEST2 ([Id], [A], [C], [E]) VALUES (1, 'true', 'false', 'true')
--INSERT INTO #TEST2 ([Id], [A], [B], [C]) VALUES (2, 'true', 'true', 'true')
--INSERT INTO #TEST2 ([Id], [C], [D], [E]) VALUES (1, 'false', 'false', 'true')

CREATE PROCEDURE InvertValue (@Id INT, @Column CHAR(1))
AS
BEGIN
    DECLARE @sql NVARCHAR(MAX);
    SET @sql = 'UPDATE #TEST2 SET ' + @Column + ' = CASE WHEN ' + @Column + ' = 1 THEN 0 ELSE 1 END WHERE Id = ' + CAST(@Id as VARCHAR(3)) + ' AND ' + @Column + ' IS NOT NULL';
    EXEC sp_executesql @sql;
END;

EXEC InvertValue 1, 'A'

--SELECT * FROM #TEST2