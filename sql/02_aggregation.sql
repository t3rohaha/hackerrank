-- =============================================================================
-- AGGREGATION AGGREGATION AGGREGATION AGGREGATION AGGREGATION AGGREGATION AGGRE
-- =============================================================================

-- =============================================================================
-- Problem 00: Revising Aggregations - The Count Function
-- =============================================================================

SELECT COUNT(*) AS Count
FROM City
WHERE Population > 100000;
GO

-- =============================================================================
-- Problem 01: Revising Aggregations - The Sum Function
-- =============================================================================

SELECT SUM(Population) AS TotalPopulation
FROM City
WHERE District = 'California';
GO

-- =============================================================================
-- Problem 02: Revising Aggregations - Averages
-- =============================================================================

SELECT AVG(Population) AS AveragePopulation
FROM City
WHERE District = 'California';
GO

-- =============================================================================
-- Problem 03: Average Population
-- =============================================================================

SELECT FLOOR(AVG(Population)) AS AveragePopulation
FROM City;
GO

-- =============================================================================
-- Problem 04: Japan Population
-- =============================================================================

SELECT SUM(Population) AS TotalPopulation
FROM City
WHERE CountryCode = 'JPN';
GO

-- =============================================================================
-- Problem 05: Population Density Difference
-- =============================================================================

SELECT (MAX(Population) - MIN(Population)) AS MinMaxPopulationDiff
FROM City;

-- =============================================================================
-- Problem 06: The Blunder
-- =============================================================================

WITH CTE_Blunder (WrongAvgSalary)
AS
(
    SELECT AVG(CAST(REPLACE(CAST(Salary AS varchar), '0', '') AS float)) AS WrongAvgSalary
    FROM Employees
),
CTE_AvgSalary (AvgSalary)
AS
(
    SELECT AVG(CAST(Salary AS float)) AS AvgSalary
    FROM Employees
)
SELECT CAST(CEILING(AvgSalary - WrongAvgSalary) AS int) AS Diff
FROM CTE_Blunder, CTE_AvgSalary;
GO

-- =============================================================================
-- Problem 07: Top Earners
-- =============================================================================

WITH CTE_EmployeeTotalSalary (Id, TotalSalary)
AS
(
    SELECT Employee_Id AS Id, (Months * Salary) AS TotalSalary
    FROM Employee
)
SELECT TOP(1) TotalSalary, COUNT(*)
FROM CTE_EmployeeTotalSalary
GROUP BY TotalSalary
ORDER BY TotalSalary DESC;
GO

-- =============================================================================
-- Problem 08: Weather Observation Station 2
-- =============================================================================

SELECT FORMAT(SUM(LAT_N), 'F2'), FORMAT(SUM(LONG_W), 'F2')
FROM Station;
GO

-- =============================================================================
-- Problem 09: Weather Observation Station 13
-- =============================================================================

SELECT FORMAT(SUM(LAT_N), 'F4')
FROM Station
WHERE LAT_N > 38.7880 AND LAT_N < 137.2345;
GO

-- =============================================================================
-- Problem 10: Weather Observation Station 14
-- =============================================================================

SELECT TOP(1) FORMAT(LAT_N, 'F4')
FROM Station
WHERE LAT_N < 137.2345
ORDER BY LAT_N DESC;
GO

-- =============================================================================
-- Problem 11: Weather Observation Station 15
-- =============================================================================

SELECT TOP(1) FORMAT(LONG_W, 'F4')
FROM Station
WHERE LAT_N < 137.2345
ORDER BY LAT_N DESC;
GO

-- =============================================================================
-- Problem 12: Weather Observation Station 16
-- =============================================================================

SELECT TOP(1) FORMAT(LAT_N, 'F4')
FROM Station
WHERE LAT_N > 38.7780
ORDER BY LAT_N;
GO

-- =============================================================================
-- Problem 13: Weather Observation Station 17
-- =============================================================================

SELECT TOP(1) FORMAT(LONG_W, 'F4')
FROM Station
WHERE LAT_N > 38.7780
ORDER BY LAT_N;
GO

-- =============================================================================
-- Problem 14: Weather Observation Station 18
-- =============================================================================

DECLARE @a decimal(10,4), @b decimal(10,4), @c decimal(10,4), @d decimal(10,4);
SELECT
    @a = MIN(LAT_N),
    @b = MIN(LONG_W),
    @c = MAX(LAT_N),
    @d = MAX(LONG_W)
FROM Station;
SELECT ABS(@a - @c) + ABS(@b - @d) AS ManhattanDistance;
GO

-- =============================================================================
-- Problem 15: Weather Observation Station 19
-- =============================================================================

DECLARE @a decimal(10,4), @b decimal(10,4), @c decimal(10,4), @d decimal(10,4);

SELECT
    @a = MIN(LAT_N),
    @b = MAX(LAT_N),
    @c = MIN(LONG_W),
    @d = MAX(LONG_W)
FROM Station;

DECLARE @result decimal(10, 4) = SQRT(POWER((@a - @b), 2) + POWER((@c - @d), 2));

SELECT @result AS EuclideanDistance;
GO

-- =============================================================================
-- Problem 16: Weather Observation Station 20
-- =============================================================================

DECLARE @OrderedStations TABLE
(
    RowNum int,
    LAT_N decimal(10, 4)
);

INSERT INTO @OrderedStations
SELECT
    ROW_NUMBER() OVER (ORDER BY LAT_N) AS RowNum,
    LAT_N
FROM Station
ORDER BY LAT_N;

DECLARE @count int;
DECLARE @median decimal(10, 4);

SELECT @count = COUNT(*) FROM Station;

IF (@count % 2 = 0)
BEGIN
    SELECT @median = AVG(LAT_N)
    FROM @OrderedStations
    WHERE
        RowNum = @count / 2
        OR RowNum = @count / 2 + 1;
END
ELSE
BEGIN
    SELECT @median = LAT_N
    FROM @OrderedStations
    WHERE RowNum = (@count + 1) / 2
END

SELECT @median AS Median;
GO