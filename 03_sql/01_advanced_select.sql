-- Problem 01: Type of Triangle
SELECT
CASE
    WHEN A + B > C AND A + C > B AND B + C > A THEN
        CASE
            WHEN A = B AND B = C THEN 'Equilateral'
            WHEN (A = B AND A != C) OR
                (A = C AND A != B) OR
                (B = C AND B != A) THEN 'Isosceles'
            WHEN A != B AND A != C AND B != C THEN 'Scalene'
        END
    ELSE 'Not A Triangle'
END
FROM Triangles;
GO

-- Problem 02: The PADS
SELECT CONCAT(Name, '(', LEFT(Occupation, 1), ')')
FROM Occupations
ORDER BY Name;

WITH CTE_OccupationsCount (Occupation, Count) AS
(
    SELECT Occupation, COUNT(*) AS Count
    FROM Occupations
    GROUP BY Occupation
)
SELECT CONCAT('There are a total of ', Count, ' ', LOWER(Occupation), 's')
FROM CTE_OccupationsCount
ORDER BY Count, Occupation
GO