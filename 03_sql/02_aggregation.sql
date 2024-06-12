-- AGGREGATION AGGREGATION AGGREGATION AGGREGATION AGGREGATION AGGREGATION 
-- AGGREGATION AGGREGATION AGGREGATION AGGREGATION AGGREGATION AGGREGATION 
-- AGGREGATION AGGREGATION AGGREGATION AGGREGATION AGGREGATION AGGREGATION 


-- Problem 00: Revising Aggregations - The Count Function
SELECT COUNT(*) AS Count
FROM City
WHERE Population > 100000;
GO

-- Problem 01: Revising Aggregations - The Sum Function
SELECT SUM(Population) AS TotalPopulation
FROM City
WHERE District = 'California';
GO

-- Problem 02: Revising Aggregations - Averages
SELECT AVG(Population) AS AveragePopulation
FROM City
WHERE District = 'California';
GO

-- Problem 03: Average Population
SELECT FLOOR(AVG(Population)) AS AveragePopulation
FROM City;
GO

-- Problem 04: Japan Population
SELECT SUM(Population) AS TotalPopulation
FROM City
WHERE CountryCode = 'JPN';
GO

-- Problem 05: Population Density Difference
SELECT (MAX(Population) - MIN(Population)) AS MinMaxPopulationDiff
FROM City;
GO

-- Problem 06: The Blunder
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