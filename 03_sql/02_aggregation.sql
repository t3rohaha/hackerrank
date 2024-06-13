-- AGGREGATION AGGREGATION AGGREGATION AGGREGATION AGGREGATION AGGREGATION 
-- AGGREGATION AGGREGATION AGGREGATION AGGREGATION AGGREGATION AGGREGATION 
-- AGGREGATION AGGREGATION AGGREGATION AGGREGATION AGGREGATION AGGREGATION 


-- Problem 00: Revising Aggregations - The Count Function
SELECT COUNT(*) AS Count
FROM City
WHERE Population > 100000;

-- Problem 01: Revising Aggregations - The Sum Function
SELECT SUM(Population) AS TotalPopulation
FROM City
WHERE District = 'California';

-- Problem 02: Revising Aggregations - Averages
SELECT AVG(Population) AS AveragePopulation
FROM City
WHERE District = 'California';

-- Problem 03: Average Population
SELECT FLOOR(AVG(Population)) AS AveragePopulation
FROM City;

-- Problem 04: Japan Population
SELECT SUM(Population) AS TotalPopulation
FROM City
WHERE CountryCode = 'JPN';

-- Problem 05: Population Density Difference
SELECT (MAX(Population) - MIN(Population)) AS MinMaxPopulationDiff
FROM City;

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

-- Problem 07: Top Earners
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

-- Problem 08: Weather Observation Station 2
SELECT FORMAT(SUM(LAT_N), 'F2'), FORMAT(SUM(LONG_W), 'F2')
FROM Station;

-- Problem 09: Weather Observation Station 13
SELECT FORMAT(SUM(LAT_N), 'F4')
FROM Station
WHERE LAT_N > 38.7880 AND LAT_N < 137.2345;

-- Problem 10: Weather Observation Station 14
SELECT TOP(1) FORMAT(LAT_N, 'F4')
FROM Station
WHERE LAT_N < 137.2345
ORDER BY LAT_N DESC;

-- Problem 11: Weather Observation Station 15
SELECT TOP(1) FORMAT(LONG_W, 'F4')
FROM Station
WHERE LAT_N < 137.2345
ORDER BY LAT_N DESC;

-- Problem 12: Weather Observation Station 16
SELECT TOP(1) FORMAT(LAT_N, 'F4')
FROM Station
WHERE LAT_N > 38.7780
ORDER BY LAT_N;

-- Problem 13: Weather Observation Station 17
SELECT TOP(1) FORMAT(LONG_W, 'F4')
FROM Station
WHERE LAT_N > 38.7780
ORDER BY LAT_N;