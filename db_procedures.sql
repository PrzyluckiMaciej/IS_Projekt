DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetAllCasesAfter`()
BEGIN
	SELECT *  FROM weekly_cases_after;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetAllCasesBefore`()
BEGIN
	SELECT *  FROM weekly_cases_before;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetAllDeathsAfter`()
BEGIN
	SELECT *  FROM weekly_deaths_after;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetAllDeathsBefore`()
BEGIN
	SELECT *  FROM weekly_deaths_before;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetAllExamResultsAfter`()
BEGIN
	SELECT *  FROM srednie_wyniki_matur_after;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetAllExamResultsBefore`()
BEGIN
	SELECT *  FROM srednie_wyniki_matur_before;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetAverageCasesAfter`()
BEGIN
	SELECT 
	SUBSTRING(date, 4, 2) AS month,
    ROUND(AVG(World),0) AS average
    FROM weekly_cases_after
    GROUP BY month;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetAverageCasesBefore`()
BEGIN
	SELECT 
	SUBSTRING(date, 4, 2) AS month,
    ROUND(AVG(World),0) AS average
    FROM weekly_cases_before
    GROUP BY month;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetAverageDeathsAfter`()
BEGIN
	SELECT 
	SUBSTRING(date, 4, 2) AS month,
    ROUND(AVG(World),0) AS average
    FROM weekly_deaths_after
    GROUP BY month;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetAverageDeathsBefore`()
BEGIN
	SELECT 
	SUBSTRING(date, 4, 2) AS month,
    ROUND(AVG(World),0) AS average
    FROM weekly_deaths_before
    GROUP BY month;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetAverageExamPerYearAfter`()
BEGIN
	SELECT rok, ROUND(AVG(wartosc),1) AS srednia
    FROM `srednie_wyniki_matur_after`
    WHERE plec = "ogolem"
    GROUP BY rok;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetAverageExamPerYearBefore`()
BEGIN
	SELECT rok, ROUND(AVG(wartosc),1) AS srednia
    FROM `srednie_wyniki_matur_before`
    WHERE plec = "ogolem"
    GROUP BY rok;
END$$
DELIMITER ;
