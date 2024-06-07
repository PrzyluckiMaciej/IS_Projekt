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
