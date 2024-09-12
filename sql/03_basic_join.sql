-- BASIC JOIN BASIC JOIN BASIC JOIN BASIC JOIN BASIC JOIN BASIC JOIN BASIC JOIN 
-- BASIC JOIN BASIC JOIN BASIC JOIN BASIC JOIN BASIC JOIN BASIC JOIN BASIC JOIN 
-- BASIC JOIN BASIC JOIN BASIC JOIN BASIC JOIN BASIC JOIN BASIC JOIN BASIC JOIN 


-- Problem 00: Population Census
SELECT SUM(ci.Population)
FROM City ci
JOIN Country co
ON ci.CountryCode = co.Code
WHERE co.Continent = 'Asia';

-- Problem 01: African Cities
SELECT ci.Name
FROM City ci
JOIN Country co
ON ci.CountryCode = co.Code
WHERE co.Continent = 'Africa';

-- Problem 02: Average Population of Each Continent
SELECT co.Continent, CAST(AVG(ci.Population) AS int) AS AvgCityPopulation
FROM Country co
JOIN City ci
ON co.Code = ci.CountryCode
GROUP BY co.Continent;

-- Problem 03: The Report
SELECT
    CASE
        WHEN g.Grade < 8 THEN NULL
        ELSE s.Name
    END
    AS Name,
    g.Grade,
    s.Marks
FROM Students s
JOIN Grades g 
ON s.Marks BETWEEN g.Min_Mark AND g.Max_Mark
ORDER BY g.Grade DESC, s.Name;