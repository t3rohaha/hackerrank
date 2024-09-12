-- Problem 01: Revising the Select Query 1
SELECT *
FROM City
WHERE CountryCode = 'USA'
AND Population > 100000;
GO

-- Problem 02: Revising the Select Query 2
SELECT Name
FROM City
WHERE CountryCode = 'USA'
AND Population > 120000;
GO

-- Problem 03: Select All
SELECT * FROM City;
GO

-- Problem 04: Select by ID
SELECT * FROM City
WHERE ID = 1661;
GO

-- Problem 05: Japanese Cities' Attributes
SELECT *
FROM City
WHERE CountryCode = 'JPN';
GO

-- Problem 06: Japanese Cities' Names
SELECT Name
FROM City
WHERE CountryCode = 'JPN';
GO

-- Problem 07: Weather Observation Station 1
SELECT City, State
FROM Station;
GO

-- Problem 08: Weather Observation Station 3
SELECT DISTINCT City
FROM Station
WHERE ID % 2 = 0;
GO

-- Problem 08: Weather Observation Station 4
SELECT COUNT(City) - COUNT(DISTINCT City)
FROM Station;
GO

-- Problem 09: Weather Observation Station 5
SELECT TOP(1) City, LEN(City) AS Length
FROM Station
ORDER BY Length, City;

SELECT TOP(1) City, LEN(City) AS Length
FROM Station
ORDER BY Length DESC, City;
GO

-- Problem 10: Weather Observation Station 6
SELECT DISTINCT City
FROM Station
WHERE LOWER(LEFT(City, 1)) IN ('a', 'e', 'i', 'o', 'u');
GO

-- Problem 11: Weather Observation Station 7
SELECT DISTINCT City
FROM Station
WHERE LOWER(RIGHT(City, 1)) IN ('a', 'e', 'i', 'o', 'u');
GO

-- Problem 12: Weather Observation Station 8
SELECT DISTINCT City
FROM Station
WHERE LOWER(LEFT(City, 1)) IN ('a', 'e', 'i', 'o', 'u')
AND LOWER(RIGHT(City, 1)) IN ('a', 'e', 'i', 'o', 'u');
GO

-- Problem 13: Weather Observation Station 9
SELECT DISTINCT City
FROM Station
WHERE LOWER(LEFT(City, 1)) NOT IN ('a', 'e', 'i', 'o', 'u');
GO

-- Problem 14: Weather Observation Station 10
SELECT DISTINCT City
FROM Station
WHERE LOWER(RIGHT(City, 1)) NOT IN ('a', 'e', 'i', 'o', 'u');
GO

-- Problem 15: Weather Observation Station 11
SELECT DISTINCT City
FROM Station
WHERE LOWER(LEFT(City, 1)) NOT IN ('a', 'e', 'i', 'o', 'u')
OR LOWER(RIGHT(City, 1)) NOT IN ('a', 'e', 'i', 'o', 'u');
GO

-- Problem 16: Weather Observation Station 11
SELECT DISTINCT City
FROM Station
WHERE LOWER(LEFT(City, 1)) NOT IN ('a', 'e', 'i', 'o', 'u')
AND LOWER(RIGHT(City, 1)) NOT IN ('a', 'e', 'i', 'o', 'u');
GO

-- Problem 17: Higher Than 75 Marks
SELECT Name
FROM Students
WHERE Marks > 75
ORDER BY RIGHT(Name, 3), ID;
GO

-- Problem 18: Employee Names
SELECT Name
FROM Employee
ORDER BY Name;
GO

-- Problem 19: Employee Salaries
SELECT Name
FROM Employee
WHERE Salary > 2000
AND Months < 10
ORDER BY Employee_ID;