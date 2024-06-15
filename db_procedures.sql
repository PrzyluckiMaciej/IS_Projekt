DELIMITER $$
CREATE DEFINER=`covidAdmin`@`localhost` PROCEDURE `ClearExamsAfter`()
DELETE FROM srednie_wyniki_matur_after$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`covidAdmin`@`localhost` PROCEDURE `ClearExamsBefore`()
DELETE FROM srednie_wyniki_matur_before$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`covidAdmin`@`localhost` PROCEDURE `GetAllCasesAfter`()
BEGIN
	SELECT *  FROM weekly_cases_after;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`covidAdmin`@`localhost` PROCEDURE `InsertExamsAfter`(IN `rodzaj_egzaminu` VARCHAR(7), IN `poziom_egzaminu` VARCHAR(11), IN `przedmiot` VARCHAR(33), IN `plec` VARCHAR(9), IN `rok` INT(4), IN `wartosc` DECIMAL(4,1))
INSERT INTO `srednie_wyniki_matur_after`(`rodzaj_egzaminu`, `poziom_egzaminu`, `przedmiot`, `plec`, `rok`, `wartosc`) VALUES (rodzaj_egzaminu, poziom_egzaminu, przedmiot, plec, rok, wartosc)$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`covidAdmin`@`localhost` PROCEDURE `InsertExamsBefore`(IN `rodzaj_egzaminu` VARCHAR(7), IN `poziom_egzaminu` VARCHAR(11), IN `przedmiot` VARCHAR(33), IN `plec` VARCHAR(9), IN `rok` INT(4), IN `wartosc` DECIMAL(4,1))
INSERT INTO `srednie_wyniki_matur_before`(`rodzaj_egzaminu`, `poziom_egzaminu`, `przedmiot`, `plec`, `rok`, `wartosc`) VALUES (rodzaj_egzaminu, poziom_egzaminu, przedmiot, plec, rok, wartosc)$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`covidAdmin`@`localhost` PROCEDURE `GetAllCasesBefore`()
BEGIN
	SELECT *  FROM weekly_cases_before;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`covidAdmin`@`localhost` PROCEDURE `GetAllDeathsAfter`()
BEGIN
	SELECT *  FROM weekly_deaths_after;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`covidAdmin`@`localhost` PROCEDURE `GetAllDeathsBefore`()
BEGIN
	SELECT *  FROM weekly_deaths_before;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`covidAdmin`@`localhost` PROCEDURE `GetAllExamResultsAfter`()
BEGIN
	SELECT *  FROM srednie_wyniki_matur_after;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`covidAdmin`@`localhost` PROCEDURE `GetAllExamResultsBefore`()
BEGIN
	SELECT *  FROM srednie_wyniki_matur_before;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`covidAdmin`@`localhost` PROCEDURE `GetAverageCasesAfter`()
BEGIN
	SELECT 
	SUBSTRING(date, 4, 2) AS month,
    ROUND(AVG(World),0) AS average
    FROM weekly_cases_after
    GROUP BY month;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`covidAdmin`@`localhost` PROCEDURE `GetAverageCasesBefore`()
BEGIN
	SELECT 
	SUBSTRING(date, 4, 2) AS month,
    ROUND(AVG(World),0) AS average
    FROM weekly_cases_before
    GROUP BY month;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`covidAdmin`@`localhost` PROCEDURE `GetAverageDeathsAfter`()
BEGIN
	SELECT 
	SUBSTRING(date, 4, 2) AS month,
    ROUND(AVG(World),0) AS average
    FROM weekly_deaths_after
    GROUP BY month;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`covidAdmin`@`localhost` PROCEDURE `GetAverageDeathsBefore`()
BEGIN
	SELECT 
	SUBSTRING(date, 4, 2) AS month,
    ROUND(AVG(World),0) AS average
    FROM weekly_deaths_before
    GROUP BY month;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`covidAdmin`@`localhost` PROCEDURE `GetAverageExamPerYearAfter`()
BEGIN
	SELECT rok, ROUND(AVG(wartosc),1) AS srednia
    FROM `srednie_wyniki_matur_after`
    WHERE plec = "ogolem"
    AND wartosc != 0
    GROUP BY rok;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`covidAdmin`@`localhost` PROCEDURE `GetAverageExamPerYearBefore`()
BEGIN
	SELECT rok, ROUND(AVG(wartosc),1) AS srednia
    FROM `srednie_wyniki_matur_before`
    WHERE plec = "ogolem"
    AND wartosc != 0
    GROUP BY rok;
END$$
DELIMITER ;
