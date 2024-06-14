-- =============================================================================
-- ALTERNATIVE QUERIES ALTERNATIVE QUERIES ALTERNATIVE QUERIES
-- =============================================================================

-- =============================================================================
-- Problem 01. Draw The Triangle 1
-- =============================================================================

DECLARE @i int = 20;
WHILE (@i > 0)
BEGIN
    PRINT(REPLICATE('* ', @i));
    SET @i = @i - 1;
END
GO

-- =============================================================================
-- Problem 02. Draw The Triangle 2
-- =============================================================================

DECLARE @i int = 1;
WHILE (@i < 21)
BEGIN
    PRINT(REPLICATE('* ', @i));
    SET @i = @i + 1;
END
GO

-- =============================================================================
-- Problem 03. Print Prime Numbers
-- =============================================================================

DECLARE @result varchar(max) = '';

DECLARE @n int = 2;
WHILE (@n < 1000)
BEGIN
    DECLARE @isPrime bit = 1;

    DECLARE @i int = 2;
    WHILE (@i < @n)
    BEGIN
        IF (@n % @i = 0)
        BEGIN
            SET @isPrime = 0;
            BREAK;
        END
        SET @i = @i + 1;
    END

    IF (@isPrime = 1)
    BEGIN
        SET @result = @result + CAST(@n AS varchar(3)) + '&';
    END

    SET @n = @n + 1;
END

PRINT(TRIM('&' FROM @result));
GO