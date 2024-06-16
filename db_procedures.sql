DELIMITER $$
CREATE DEFINER=`covidAdmin`@`localhost` PROCEDURE `ClearExamsAfter`()
DELETE FROM srednie_wyniki_matur_after$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`covidAdmin`@`localhost` PROCEDURE `ClearExamsBefore`()
DELETE FROM srednie_wyniki_matur_before$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`covidAdmin`@`localhost` PROCEDURE `ClearCasesAfter`()
DELETE FROM weekly_cases_after$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`covidAdmin`@`localhost` PROCEDURE `ClearCasesBefore`()
DELETE FROM weekly_cases_before$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`covidAdmin`@`localhost` PROCEDURE `ClearDeathsAfter`()
DELETE FROM weekly_deaths_after$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`covidAdmin`@`localhost` PROCEDURE `ClearDeathsBefore`()
DELETE FROM weekly_deaths_before$$
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
CREATE DEFINER=`covidAdmin`@`localhost` PROCEDURE `InsertCasesAfter`(IN `date` varchar(10), IN `World` int(7), IN `Afghanistan` int(4), IN `Albania` int(4), IN `Algeria` int(4), IN `Andorra` int(3), IN `Angola` int(4), IN `Anguilla` int(1), IN `Antigua_and_Barbuda` int(2), IN 
  `Argentina` int(6), IN 
  `Armenia` int(5), IN 
  `Aruba` int(3), IN 
  `Australia` int(4), IN 
  `Austria` int(5), IN 
  `Azerbaijan` int(5), IN 
  `Bahamas` int(3), IN 
  `Bahrain` int(4), IN 
  `Bangladesh` int(5), IN 
  `Barbados` int(2), IN 
  `Belarus` int(5), IN 
  `Belgium` int(6), IN 
  `Belize` int(3), IN 
  `Benin` int(4), IN 
  `Bermuda` int(2), IN 
  `Bhutan` int(2), IN 
  `Bolivia` int(5), IN 
  `Bonaire_Sint_Eustatius_and_Saba` int(2), IN 
  `Bosnia_and_Herzegovina` int(5), IN 
  `Botswana` int(4), IN 
  `Brazil` int(6), IN 
  `British_Virgin_Islands` int(2), IN 
  `Brunei` int(2), IN 
  `Bulgaria` int(5), IN 
  `Burkina_Faso` int(3), IN 
  `Burundi` int(2), IN 
  `Cambodia` int(2), IN 
  `Cameroon` int(4), IN 
  `Canada` int(5), IN 
  `Cape_Verde` int(3), IN 
  `Cayman_Islands` int(2), IN 
  `Central_African_Republic` int(3), IN 
  `Chad` int(3), IN 
  `Chile` int(5), IN 
  `China` int(4), IN 
  `Colombia` int(5), IN 
  `Comoros` int(2), IN 
  `Congo` int(3), IN 
  `Costa_Rica` int(4), IN 
  `Cote_d_Ivoire` int(4), IN 
  `Croatia` int(5), IN 
  `Cuba` int(3), IN 
  `Curacao` int(3), IN 
  `Cyprus` int(4), IN 
  `Czech_Republic` int(5), IN 
  `Democratic_Republic_of_Congo` int(4), IN 
  `Denmark` int(4), IN 
  `Djibouti` int(4), IN 
  `Dominica` int(2), IN 
  `Dominican_Republic` int(5), IN 
  `Ecuador` int(5), IN 
  `Egypt` int(5), IN 
  `El_Salvador` int(4), IN 
  `Equatorial_Guinea` int(4), IN 
  `Eritrea` int(3), IN 
  `Estonia` int(4), IN 
  `Ethiopia` int(5), IN 
  `Faeroe_Islands` int(3), IN 
  `Falkland_Islands` int(1), IN 
  `Fiji` int(2), IN 
  `Finland` int(4), IN 
  `France` int(6), IN 
  `French_Polynesia` int(4), IN 
  `Gabon` int(3), IN 
  `Gambia` int(3), IN 
  `Georgia` int(5), IN 
  `Germany` int(6), IN 
  `Ghana` int(4), IN 
  `Gibraltar` int(3), IN 
  `Greece` int(5), IN 
  `Greenland` int(1), IN 
  `Grenada` int(1), IN 
  `Guam` int(3), IN 
  `Guatemala` int(4), IN 
  `Guernsey` int(3), IN 
  `Guinea` int(3), IN 
  `Guinea_Bissau` int(3), IN 
  `Guyana` int(3), IN 
  `Haiti` int(4), IN 
  `Honduras` int(4), IN 
  `Hungary` int(5), IN 
  `Iceland` int(3), IN 
  `India` int(6), IN 
  `Indonesia` int(5), IN 
  `International` int(1), IN 
  `Iran` int(6), IN 
  `Iraq` int(5), IN 
  `Ireland` int(4), IN 
  `Isle_of_Man` int(3), IN 
  `Israel` int(5), IN 
  `Italy` int(6), IN 
  `Jamaica` int(4), IN 
  `Japan` int(5), IN 
  `Jersey` int(3), IN 
  `Jordan` int(5), IN 
  `Kazakhstan` int(5), IN 
  `Kenya` int(4), IN 
  `Kosovo` int(4), IN 
  `Kuwait` int(4), IN 
  `Kyrgyzstan` int(5), IN 
  `Laos` int(2), IN 
  `Latvia` int(4), IN 
  `Lebanon` int(5), IN 
  `Lesotho` int(3), IN 
  `Liberia` int(3), IN 
  `Libya` int(4), IN 
  `Liechtenstein` int(3), IN 
  `Lithuania` int(5), IN 
  `Luxembourg` int(5), IN 
  `Macedonia` int(4), IN 
  `Madagascar` int(4), IN 
  `Malawi` int(3), IN 
  `Malaysia` int(4), IN 
  `Maldives` int(4), IN 
  `Mali` int(3), IN 
  `Malta` int(3), IN 
  `Marshall_Islands` int(1), IN 
  `Mauritania` int(4), IN 
  `Mauritius` int(3), IN 
  `Mexico` int(5), IN 
  `Moldova` int(4), IN 
  `Monaco` int(3), IN 
  `Mongolia` int(3), IN 
  `Montenegro` int(4), IN 
  `Montserrat` int(1), IN 
  `Morocco` int(5), IN 
  `Mozambique` int(4), IN 
  `Myanmar` int(5), IN 
  `Namibia` int(4), IN 
  `Nepal` int(5), IN 
  `Netherlands` int(5), IN 
  `New_Caledonia` int(1), IN 
  `New_Zealand` int(3), IN 
  `Nicaragua` int(3), IN 
  `Niger` int(3), IN 
  `Nigeria` int(4), IN 
  `Northern_Mariana_Islands` int(2), IN 
  `Norway` int(4), IN 
  `Oman` int(5), IN 
  `Pakistan` int(5), IN 
  `Palestine` int(5), IN 
  `Panama` int(4), IN 
  `Papua_New_Guinea` int(3), IN 
  `Paraguay` int(4), IN 
  `Peru` int(5), IN 
  `Philippines` int(5), IN 
  `Poland` int(6), IN 
  `Portugal` int(5), IN 
  `Puerto_Rico` int(4), IN 
  `Qatar` int(5), IN 
  `Romania` int(5), IN 
  `Russia` int(6), IN 
  `Rwanda` int(3), IN 
  `Saint_Kitts_and_Nevis` int(1), IN 
  `Saint_Lucia` int(2), IN 
  `Saint_Vincent_and_the_Grenadines` int(2), IN 
  `San_Marino` int(3), IN 
  `Sao_Tome_and_Principe` int(3), IN 
  `Saudi_Arabia` int(5), IN 
  `Senegal` int(4), IN 
  `Serbia` int(5), IN 
  `Seychelles` int(2), IN 
  `Sierra_Leone` int(3), IN 
  `Singapore` int(4), IN 
  `Sint_Maarten_Dutch_part` int(3), IN 
  `Slovakia` int(5), IN 
  `Slovenia` int(5), IN 
  `Solomon_Islands` int(1), IN 
  `Somalia` int(3), IN 
  `South_Africa` int(5), IN 
  `South_Korea` int(4), IN 
  `South_Sudan` int(3), IN 
  `Spain` int(6), IN 
  `Sri_Lanka` int(4), IN 
  `Sudan` int(4), IN 
  `Suriname` int(3), IN 
  `Swaziland` int(3), IN 
  `Sweden` int(5), IN 
  `Switzerland` int(5), IN 
  `Syria` int(3), IN 
  `Taiwan` int(3), IN 
  `Tajikistan` int(4), IN 
  `Tanzania` int(3), IN 
  `Thailand` int(3), IN 
  `Timor` int(2), IN 
  `Togo` int(3), IN 
  `Trinidad_and_Tobago` int(3), IN 
  `Tunisia` int(5), IN 
  `Turkey` int(5), IN 
  `Turks_and_Caicos_Islands` int(3), IN 
  `Uganda` int(4), IN 
  `Ukraine` int(6), IN 
  `United_Arab_Emirates` int(5), IN 
  `United_Kingdom` int(6), IN 
  `United_States` int(7), IN 
  `United_States_Virgin_Islands` int(3), IN 
  `Uruguay` int(3), IN 
  `Uzbekistan` int(4), IN 
  `Vanuatu` int(1), IN 
  `Vatican` int(2), IN 
  `Venezuela` int(4), IN 
  `Vietnam` int(3), IN 
  `Wallis_and_Futuna` int(1), IN 
  `Western_Sahara` int(3), IN 
  `Yemen` int(3), IN 
  `Zambia` int(4), IN 
  `Zimbabwe` int(4))
INSERT INTO `weekly_cases_after`(`date`,
`World`,
`Afghanistan`,
`Albania`,
`Algeria`,
`Andorra`,
`Angola`,
`Anguilla`,
`Antigua_and_Barbuda`,
`Argentina`,
`Armenia`,
`Aruba`,
`Australia`,
`Austria`,
`Azerbaijan`,
`Bahamas`,
`Bahrain`,
`Bangladesh`,
`Barbados`,
`Belarus`,
`Belgium`,
`Belize`,
`Benin`,
`Bermuda`,
`Bhutan`,
`Bolivia`,
`Bonaire_Sint_Eustatius_and_Saba`,
`Bosnia_and_Herzegovina`,
`Botswana`,
`Brazil`,
`British_Virgin_Islands`,
`Brunei`,
`Bulgaria`,
`Burkina_Faso`,
`Burundi`,
`Cambodia`,
`Cameroon`,
`Canada`,
`Cape_Verde`,
`Cayman_Islands`,
`Central_African_Republic`,
`Chad`,
`Chile`,
`China`,
`Colombia`,
`Comoros`,
`Congo`,
`Costa_Rica`,
`Cote_d_Ivoire`,
`Croatia`,
`Cuba`,
`Curacao`,
`Cyprus`,
`Czech_Republic`,
`Democratic_Republic_of_Congo`,
`Denmark`,
`Djibouti`,
`Dominica`,
`Dominican_Republic`,
`Ecuador`,
`Egypt`,
`El_Salvador`,
`Equatorial_Guinea`,
`Eritrea`,
`Estonia`,
`Ethiopia`,
`Faeroe_Islands`,
`Falkland_Islands`,
`Fiji`,
`Finland`,
`France`,
`French_Polynesia`,
`Gabon`,
`Gambia`,
`Georgia`,
`Germany`,
`Ghana`,
`Gibraltar`,
`Greece`,
`Greenland`,
`Grenada`,
`Guam`,
`Guatemala`,
`Guernsey`,
`Guinea`,
`Guinea_Bissau`,
`Guyana`,
`Haiti`,
`Honduras`,
`Hungary`,
`Iceland`,
`India`,
`Indonesia`,
`International`,
`Iran`,
`Iraq`,
`Ireland`,
`Isle_of_Man`,
`Israel`,
`Italy`,
`Jamaica`,
`Japan`,
`Jersey`,
`Jordan`,
`Kazakhstan`,
`Kenya`,
`Kosovo`,
`Kuwait`,
`Kyrgyzstan`,
`Laos`,
`Latvia`,
`Lebanon`,
`Lesotho`,
`Liberia`,
`Libya`,
`Liechtenstein`,
`Lithuania`,
`Luxembourg`,
`Macedonia`,
`Madagascar`,
`Malawi`,
`Malaysia`,
`Maldives`,
`Mali`,
`Malta`,
`Marshall_Islands`,
`Mauritania`,
`Mauritius`,
`Mexico`,
`Moldova`,
`Monaco`,
`Mongolia`,
`Montenegro`,
`Montserrat`,
`Morocco`,
`Mozambique`,
`Myanmar`,
`Namibia`,
`Nepal`,
`Netherlands`,
`New_Caledonia`,
`New_Zealand`,
`Nicaragua`,
`Niger`,
`Nigeria`,
`Northern_Mariana_Islands`,
`Norway`,
`Oman`,
`Pakistan`,
`Palestine`,
`Panama`,
`Papua_New_Guinea`,
`Paraguay`,
`Peru`,
`Philippines`,
`Poland`,
`Portugal`,
`Puerto_Rico`,
`Qatar`,
`Romania`,
`Russia`,
`Rwanda`,
`Saint_Kitts_and_Nevis`,
`Saint_Lucia`,
`Saint_Vincent_and_the_Grenadines`,
`San_Marino`,
`Sao_Tome_and_Principe`,
`Saudi_Arabia`,
`Senegal`,
`Serbia`,
`Seychelles`,
`Sierra_Leone`,
`Singapore`,
`Sint_Maarten_Dutch_part`,
`Slovakia`,
`Slovenia`,
`Solomon_Islands`,
`Somalia`,
`South_Africa`,
`South_Korea`,
`South_Sudan`,
`Spain`,
`Sri_Lanka`,
`Sudan`,
`Suriname`,
`Swaziland`,
`Sweden`,
`Switzerland`,
`Syria`,
`Taiwan`,
`Tajikistan`,
`Tanzania`,
`Thailand`,
`Timor`,
`Togo`,
`Trinidad_and_Tobago`,
`Tunisia`,
`Turkey`,
`Turks_and_Caicos_Islands`,
`Uganda`,
`Ukraine`,
`United_Arab_Emirates`,
`United_Kingdom`,
`United_States`,
`United_States_Virgin_Islands`,
`Uruguay`,
`Uzbekistan`,
`Vanuatu`,
`Vatican`,
`Venezuela`,
`Vietnam`,
`Wallis_and_Futuna`,
`Western_Sahara`,
`Yemen`,
`Zambia`,
`Zimbabwe`) 
VALUES (date,
World,
Afghanistan,
Albania,
Algeria,
Andorra,
Angola,
Anguilla,
Antigua_and_Barbuda,
Argentina,
Armenia,
Aruba,
Australia,
Austria,
Azerbaijan,
Bahamas,
Bahrain,
Bangladesh,
Barbados,
Belarus,
Belgium,
Belize,
Benin,
Bermuda,
Bhutan,
Bolivia,
Bonaire_Sint_Eustatius_and_Saba,
Bosnia_and_Herzegovina,
Botswana,
Brazil,
British_Virgin_Islands,
Brunei,
Bulgaria,
Burkina_Faso,
Burundi,
Cambodia,
Cameroon,
Canada,
Cape_Verde,
Cayman_Islands,
Central_African_Republic,
Chad,
Chile,
China,
Colombia,
Comoros,
Congo,
Costa_Rica,
Cote_d_Ivoire,
Croatia,
Cuba,
Curacao,
Cyprus,
Czech_Republic,
Democratic_Republic_of_Congo,
Denmark,
Djibouti,
Dominica,
Dominican_Republic,
Ecuador,
Egypt,
El_Salvador,
Equatorial_Guinea,
Eritrea,
Estonia,
Ethiopia,
Faeroe_Islands,
Falkland_Islands,
Fiji,
Finland,
France,
French_Polynesia,
Gabon,
Gambia,
Georgia,
Germany,
Ghana,
Gibraltar,
Greece,
Greenland,
Grenada,
Guam,
Guatemala,
Guernsey,
Guinea,
Guinea_Bissau,
Guyana,
Haiti,
Honduras,
Hungary,
Iceland,
India,
Indonesia,
International,
Iran,
Iraq,
Ireland,
Isle_of_Man,
Israel,
Italy,
Jamaica,
Japan,
Jersey,
Jordan,
Kazakhstan,
Kenya,
Kosovo,
Kuwait,
Kyrgyzstan,
Laos,
Latvia,
Lebanon,
Lesotho,
Liberia,
Libya,
Liechtenstein,
Lithuania,
Luxembourg,
Macedonia,
Madagascar,
Malawi,
Malaysia,
Maldives,
Mali,
Malta,
Marshall_Islands,
Mauritania,
Mauritius,
Mexico,
Moldova,
Monaco,
Mongolia,
Montenegro,
Montserrat,
Morocco,
Mozambique,
Myanmar,
Namibia,
Nepal,
Netherlands,
New_Caledonia,
New_Zealand,
Nicaragua,
Niger,
Nigeria,
Northern_Mariana_Islands,
Norway,
Oman,
Pakistan,
Palestine,
Panama,
Papua_New_Guinea,
Paraguay,
Peru,
Philippines,
Poland,
Portugal,
Puerto_Rico,
Qatar,
Romania,
Russia,
Rwanda,
Saint_Kitts_and_Nevis,
Saint_Lucia,
Saint_Vincent_and_the_Grenadines,
San_Marino,
Sao_Tome_and_Principe,
Saudi_Arabia,
Senegal,
Serbia,
Seychelles,
Sierra_Leone,
Singapore,
Sint_Maarten_Dutch_part,
Slovakia,
Slovenia,
Solomon_Islands,
Somalia,
South_Africa,
South_Korea,
South_Sudan,
Spain,
Sri_Lanka,
Sudan,
Suriname,
Swaziland,
Sweden,
Switzerland,
Syria,
Taiwan,
Tajikistan,
Tanzania,
Thailand,
Timor,
Togo,
Trinidad_and_Tobago,
Tunisia,
Turkey,
Turks_and_Caicos_Islands,
Uganda,
Ukraine,
United_Arab_Emirates,
United_Kingdom,
United_States,
United_States_Virgin_Islands,
Uruguay,
Uzbekistan,
Vanuatu,
Vatican,
Venezuela,
Vietnam,
Wallis_and_Futuna,
Western_Sahara,
Yemen,
Zambia,
Zimbabwe)$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`covidAdmin`@`localhost` PROCEDURE `InsertCasesBefore`(IN `date` varchar(10), IN `World` int(7), IN `Afghanistan` int(4), IN `Albania` int(4), IN `Algeria` int(4), IN `Andorra` int(3), IN `Angola` int(4), IN `Anguilla` int(1), IN `Antigua_and_Barbuda` int(2), IN 
  `Argentina` int(6), IN 
  `Armenia` int(5), IN 
  `Aruba` int(3), IN 
  `Australia` int(4), IN 
  `Austria` int(5), IN 
  `Azerbaijan` int(5), IN 
  `Bahamas` int(3), IN 
  `Bahrain` int(4), IN 
  `Bangladesh` int(5), IN 
  `Barbados` int(2), IN 
  `Belarus` int(5), IN 
  `Belgium` int(6), IN 
  `Belize` int(3), IN 
  `Benin` int(4), IN 
  `Bermuda` int(2), IN 
  `Bhutan` int(2), IN 
  `Bolivia` int(5), IN 
  `Bonaire_Sint_Eustatius_and_Saba` int(2), IN 
  `Bosnia_and_Herzegovina` int(5), IN 
  `Botswana` int(4), IN 
  `Brazil` int(6), IN 
  `British_Virgin_Islands` int(2), IN 
  `Brunei` int(2), IN 
  `Bulgaria` int(5), IN 
  `Burkina_Faso` int(3), IN 
  `Burundi` int(2), IN 
  `Cambodia` int(2), IN 
  `Cameroon` int(4), IN 
  `Canada` int(5), IN 
  `Cape_Verde` int(3), IN 
  `Cayman_Islands` int(2), IN 
  `Central_African_Republic` int(3), IN 
  `Chad` int(3), IN 
  `Chile` int(5), IN 
  `China` int(4), IN 
  `Colombia` int(5), IN 
  `Comoros` int(2), IN 
  `Congo` int(3), IN 
  `Costa_Rica` int(4), IN 
  `Cote_d_Ivoire` int(4), IN 
  `Croatia` int(5), IN 
  `Cuba` int(3), IN 
  `Curacao` int(3), IN 
  `Cyprus` int(4), IN 
  `Czech_Republic` int(5), IN 
  `Democratic_Republic_of_Congo` int(4), IN 
  `Denmark` int(4), IN 
  `Djibouti` int(4), IN 
  `Dominica` int(2), IN 
  `Dominican_Republic` int(5), IN 
  `Ecuador` int(5), IN 
  `Egypt` int(5), IN 
  `El_Salvador` int(4), IN 
  `Equatorial_Guinea` int(4), IN 
  `Eritrea` int(3), IN 
  `Estonia` int(4), IN 
  `Ethiopia` int(5), IN 
  `Faeroe_Islands` int(3), IN 
  `Falkland_Islands` int(1), IN 
  `Fiji` int(2), IN 
  `Finland` int(4), IN 
  `France` int(6), IN 
  `French_Polynesia` int(4), IN 
  `Gabon` int(3), IN 
  `Gambia` int(3), IN 
  `Georgia` int(5), IN 
  `Germany` int(6), IN 
  `Ghana` int(4), IN 
  `Gibraltar` int(3), IN 
  `Greece` int(5), IN 
  `Greenland` int(1), IN 
  `Grenada` int(1), IN 
  `Guam` int(3), IN 
  `Guatemala` int(4), IN 
  `Guernsey` int(3), IN 
  `Guinea` int(3), IN 
  `Guinea_Bissau` int(3), IN 
  `Guyana` int(3), IN 
  `Haiti` int(4), IN 
  `Honduras` int(4), IN 
  `Hungary` int(5), IN 
  `Iceland` int(3), IN 
  `India` int(6), IN 
  `Indonesia` int(5), IN 
  `International` int(1), IN 
  `Iran` int(6), IN 
  `Iraq` int(5), IN 
  `Ireland` int(4), IN 
  `Isle_of_Man` int(3), IN 
  `Israel` int(5), IN 
  `Italy` int(6), IN 
  `Jamaica` int(4), IN 
  `Japan` int(5), IN 
  `Jersey` int(3), IN 
  `Jordan` int(5), IN 
  `Kazakhstan` int(5), IN 
  `Kenya` int(4), IN 
  `Kosovo` int(4), IN 
  `Kuwait` int(4), IN 
  `Kyrgyzstan` int(5), IN 
  `Laos` int(2), IN 
  `Latvia` int(4), IN 
  `Lebanon` int(5), IN 
  `Lesotho` int(3), IN 
  `Liberia` int(3), IN 
  `Libya` int(4), IN 
  `Liechtenstein` int(3), IN 
  `Lithuania` int(5), IN 
  `Luxembourg` int(5), IN 
  `Macedonia` int(4), IN 
  `Madagascar` int(4), IN 
  `Malawi` int(3), IN 
  `Malaysia` int(4), IN 
  `Maldives` int(4), IN 
  `Mali` int(3), IN 
  `Malta` int(3), IN 
  `Marshall_Islands` int(1), IN 
  `Mauritania` int(4), IN 
  `Mauritius` int(3), IN 
  `Mexico` int(5), IN 
  `Moldova` int(4), IN 
  `Monaco` int(3), IN 
  `Mongolia` int(3), IN 
  `Montenegro` int(4), IN 
  `Montserrat` int(1), IN 
  `Morocco` int(5), IN 
  `Mozambique` int(4), IN 
  `Myanmar` int(5), IN 
  `Namibia` int(4), IN 
  `Nepal` int(5), IN 
  `Netherlands` int(5), IN 
  `New_Caledonia` int(1), IN 
  `New_Zealand` int(3), IN 
  `Nicaragua` int(3), IN 
  `Niger` int(3), IN 
  `Nigeria` int(4), IN 
  `Northern_Mariana_Islands` int(2), IN 
  `Norway` int(4), IN 
  `Oman` int(5), IN 
  `Pakistan` int(5), IN 
  `Palestine` int(5), IN 
  `Panama` int(4), IN 
  `Papua_New_Guinea` int(3), IN 
  `Paraguay` int(4), IN 
  `Peru` int(5), IN 
  `Philippines` int(5), IN 
  `Poland` int(6), IN 
  `Portugal` int(5), IN 
  `Puerto_Rico` int(4), IN 
  `Qatar` int(5), IN 
  `Romania` int(5), IN 
  `Russia` int(6), IN 
  `Rwanda` int(3), IN 
  `Saint_Kitts_and_Nevis` int(1), IN 
  `Saint_Lucia` int(2), IN 
  `Saint_Vincent_and_the_Grenadines` int(2), IN 
  `San_Marino` int(3), IN 
  `Sao_Tome_and_Principe` int(3), IN 
  `Saudi_Arabia` int(5), IN 
  `Senegal` int(4), IN 
  `Serbia` int(5), IN 
  `Seychelles` int(2), IN 
  `Sierra_Leone` int(3), IN 
  `Singapore` int(4), IN 
  `Sint_Maarten_Dutch_part` int(3), IN 
  `Slovakia` int(5), IN 
  `Slovenia` int(5), IN 
  `Solomon_Islands` int(1), IN 
  `Somalia` int(3), IN 
  `South_Africa` int(5), IN 
  `South_Korea` int(4), IN 
  `South_Sudan` int(3), IN 
  `Spain` int(6), IN 
  `Sri_Lanka` int(4), IN 
  `Sudan` int(4), IN 
  `Suriname` int(3), IN 
  `Swaziland` int(3), IN 
  `Sweden` int(5), IN 
  `Switzerland` int(5), IN 
  `Syria` int(3), IN 
  `Taiwan` int(3), IN 
  `Tajikistan` int(4), IN 
  `Tanzania` int(3), IN 
  `Thailand` int(3), IN 
  `Timor` int(2), IN 
  `Togo` int(3), IN 
  `Trinidad_and_Tobago` int(3), IN 
  `Tunisia` int(5), IN 
  `Turkey` int(5), IN 
  `Turks_and_Caicos_Islands` int(3), IN 
  `Uganda` int(4), IN 
  `Ukraine` int(6), IN 
  `United_Arab_Emirates` int(5), IN 
  `United_Kingdom` int(6), IN 
  `United_States` int(7), IN 
  `United_States_Virgin_Islands` int(3), IN 
  `Uruguay` int(3), IN 
  `Uzbekistan` int(4), IN 
  `Vanuatu` int(1), IN 
  `Vatican` int(2), IN 
  `Venezuela` int(4), IN 
  `Vietnam` int(3), IN 
  `Wallis_and_Futuna` int(1), IN 
  `Western_Sahara` int(3), IN 
  `Yemen` int(3), IN 
  `Zambia` int(4), IN 
  `Zimbabwe` int(4))
INSERT INTO `weekly_cases_before`(`date`,
`World`,
`Afghanistan`,
`Albania`,
`Algeria`,
`Andorra`,
`Angola`,
`Anguilla`,
`Antigua_and_Barbuda`,
`Argentina`,
`Armenia`,
`Aruba`,
`Australia`,
`Austria`,
`Azerbaijan`,
`Bahamas`,
`Bahrain`,
`Bangladesh`,
`Barbados`,
`Belarus`,
`Belgium`,
`Belize`,
`Benin`,
`Bermuda`,
`Bhutan`,
`Bolivia`,
`Bonaire_Sint_Eustatius_and_Saba`,
`Bosnia_and_Herzegovina`,
`Botswana`,
`Brazil`,
`British_Virgin_Islands`,
`Brunei`,
`Bulgaria`,
`Burkina_Faso`,
`Burundi`,
`Cambodia`,
`Cameroon`,
`Canada`,
`Cape_Verde`,
`Cayman_Islands`,
`Central_African_Republic`,
`Chad`,
`Chile`,
`China`,
`Colombia`,
`Comoros`,
`Congo`,
`Costa_Rica`,
`Cote_d_Ivoire`,
`Croatia`,
`Cuba`,
`Curacao`,
`Cyprus`,
`Czech_Republic`,
`Democratic_Republic_of_Congo`,
`Denmark`,
`Djibouti`,
`Dominica`,
`Dominican_Republic`,
`Ecuador`,
`Egypt`,
`El_Salvador`,
`Equatorial_Guinea`,
`Eritrea`,
`Estonia`,
`Ethiopia`,
`Faeroe_Islands`,
`Falkland_Islands`,
`Fiji`,
`Finland`,
`France`,
`French_Polynesia`,
`Gabon`,
`Gambia`,
`Georgia`,
`Germany`,
`Ghana`,
`Gibraltar`,
`Greece`,
`Greenland`,
`Grenada`,
`Guam`,
`Guatemala`,
`Guernsey`,
`Guinea`,
`Guinea_Bissau`,
`Guyana`,
`Haiti`,
`Honduras`,
`Hungary`,
`Iceland`,
`India`,
`Indonesia`,
`International`,
`Iran`,
`Iraq`,
`Ireland`,
`Isle_of_Man`,
`Israel`,
`Italy`,
`Jamaica`,
`Japan`,
`Jersey`,
`Jordan`,
`Kazakhstan`,
`Kenya`,
`Kosovo`,
`Kuwait`,
`Kyrgyzstan`,
`Laos`,
`Latvia`,
`Lebanon`,
`Lesotho`,
`Liberia`,
`Libya`,
`Liechtenstein`,
`Lithuania`,
`Luxembourg`,
`Macedonia`,
`Madagascar`,
`Malawi`,
`Malaysia`,
`Maldives`,
`Mali`,
`Malta`,
`Marshall_Islands`,
`Mauritania`,
`Mauritius`,
`Mexico`,
`Moldova`,
`Monaco`,
`Mongolia`,
`Montenegro`,
`Montserrat`,
`Morocco`,
`Mozambique`,
`Myanmar`,
`Namibia`,
`Nepal`,
`Netherlands`,
`New_Caledonia`,
`New_Zealand`,
`Nicaragua`,
`Niger`,
`Nigeria`,
`Northern_Mariana_Islands`,
`Norway`,
`Oman`,
`Pakistan`,
`Palestine`,
`Panama`,
`Papua_New_Guinea`,
`Paraguay`,
`Peru`,
`Philippines`,
`Poland`,
`Portugal`,
`Puerto_Rico`,
`Qatar`,
`Romania`,
`Russia`,
`Rwanda`,
`Saint_Kitts_and_Nevis`,
`Saint_Lucia`,
`Saint_Vincent_and_the_Grenadines`,
`San_Marino`,
`Sao_Tome_and_Principe`,
`Saudi_Arabia`,
`Senegal`,
`Serbia`,
`Seychelles`,
`Sierra_Leone`,
`Singapore`,
`Sint_Maarten_Dutch_part`,
`Slovakia`,
`Slovenia`,
`Solomon_Islands`,
`Somalia`,
`South_Africa`,
`South_Korea`,
`South_Sudan`,
`Spain`,
`Sri_Lanka`,
`Sudan`,
`Suriname`,
`Swaziland`,
`Sweden`,
`Switzerland`,
`Syria`,
`Taiwan`,
`Tajikistan`,
`Tanzania`,
`Thailand`,
`Timor`,
`Togo`,
`Trinidad_and_Tobago`,
`Tunisia`,
`Turkey`,
`Turks_and_Caicos_Islands`,
`Uganda`,
`Ukraine`,
`United_Arab_Emirates`,
`United_Kingdom`,
`United_States`,
`United_States_Virgin_Islands`,
`Uruguay`,
`Uzbekistan`,
`Vanuatu`,
`Vatican`,
`Venezuela`,
`Vietnam`,
`Wallis_and_Futuna`,
`Western_Sahara`,
`Yemen`,
`Zambia`,
`Zimbabwe`) 
VALUES (date,
World,
Afghanistan,
Albania,
Algeria,
Andorra,
Angola,
Anguilla,
Antigua_and_Barbuda,
Argentina,
Armenia,
Aruba,
Australia,
Austria,
Azerbaijan,
Bahamas,
Bahrain,
Bangladesh,
Barbados,
Belarus,
Belgium,
Belize,
Benin,
Bermuda,
Bhutan,
Bolivia,
Bonaire_Sint_Eustatius_and_Saba,
Bosnia_and_Herzegovina,
Botswana,
Brazil,
British_Virgin_Islands,
Brunei,
Bulgaria,
Burkina_Faso,
Burundi,
Cambodia,
Cameroon,
Canada,
Cape_Verde,
Cayman_Islands,
Central_African_Republic,
Chad,
Chile,
China,
Colombia,
Comoros,
Congo,
Costa_Rica,
Cote_d_Ivoire,
Croatia,
Cuba,
Curacao,
Cyprus,
Czech_Republic,
Democratic_Republic_of_Congo,
Denmark,
Djibouti,
Dominica,
Dominican_Republic,
Ecuador,
Egypt,
El_Salvador,
Equatorial_Guinea,
Eritrea,
Estonia,
Ethiopia,
Faeroe_Islands,
Falkland_Islands,
Fiji,
Finland,
France,
French_Polynesia,
Gabon,
Gambia,
Georgia,
Germany,
Ghana,
Gibraltar,
Greece,
Greenland,
Grenada,
Guam,
Guatemala,
Guernsey,
Guinea,
Guinea_Bissau,
Guyana,
Haiti,
Honduras,
Hungary,
Iceland,
India,
Indonesia,
International,
Iran,
Iraq,
Ireland,
Isle_of_Man,
Israel,
Italy,
Jamaica,
Japan,
Jersey,
Jordan,
Kazakhstan,
Kenya,
Kosovo,
Kuwait,
Kyrgyzstan,
Laos,
Latvia,
Lebanon,
Lesotho,
Liberia,
Libya,
Liechtenstein,
Lithuania,
Luxembourg,
Macedonia,
Madagascar,
Malawi,
Malaysia,
Maldives,
Mali,
Malta,
Marshall_Islands,
Mauritania,
Mauritius,
Mexico,
Moldova,
Monaco,
Mongolia,
Montenegro,
Montserrat,
Morocco,
Mozambique,
Myanmar,
Namibia,
Nepal,
Netherlands,
New_Caledonia,
New_Zealand,
Nicaragua,
Niger,
Nigeria,
Northern_Mariana_Islands,
Norway,
Oman,
Pakistan,
Palestine,
Panama,
Papua_New_Guinea,
Paraguay,
Peru,
Philippines,
Poland,
Portugal,
Puerto_Rico,
Qatar,
Romania,
Russia,
Rwanda,
Saint_Kitts_and_Nevis,
Saint_Lucia,
Saint_Vincent_and_the_Grenadines,
San_Marino,
Sao_Tome_and_Principe,
Saudi_Arabia,
Senegal,
Serbia,
Seychelles,
Sierra_Leone,
Singapore,
Sint_Maarten_Dutch_part,
Slovakia,
Slovenia,
Solomon_Islands,
Somalia,
South_Africa,
South_Korea,
South_Sudan,
Spain,
Sri_Lanka,
Sudan,
Suriname,
Swaziland,
Sweden,
Switzerland,
Syria,
Taiwan,
Tajikistan,
Tanzania,
Thailand,
Timor,
Togo,
Trinidad_and_Tobago,
Tunisia,
Turkey,
Turks_and_Caicos_Islands,
Uganda,
Ukraine,
United_Arab_Emirates,
United_Kingdom,
United_States,
United_States_Virgin_Islands,
Uruguay,
Uzbekistan,
Vanuatu,
Vatican,
Venezuela,
Vietnam,
Wallis_and_Futuna,
Western_Sahara,
Yemen,
Zambia,
Zimbabwe)$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`covidAdmin`@`localhost` PROCEDURE `InsertDeathsAfter`(IN `date` varchar(10), IN `World` int(7), IN `Afghanistan` int(4), IN `Albania` int(4), IN `Algeria` int(4), IN `Andorra` int(3), IN `Angola` int(4), IN `Anguilla` int(1), IN `Antigua_and_Barbuda` int(2), IN 
  `Argentina` int(6), IN 
  `Armenia` int(5), IN 
  `Aruba` int(3), IN 
  `Australia` int(4), IN 
  `Austria` int(5), IN 
  `Azerbaijan` int(5), IN 
  `Bahamas` int(3), IN 
  `Bahrain` int(4), IN 
  `Bangladesh` int(5), IN 
  `Barbados` int(2), IN 
  `Belarus` int(5), IN 
  `Belgium` int(6), IN 
  `Belize` int(3), IN 
  `Benin` int(4), IN 
  `Bermuda` int(2), IN 
  `Bhutan` int(2), IN 
  `Bolivia` int(5), IN 
  `Bonaire_Sint_Eustatius_and_Saba` int(2), IN 
  `Bosnia_and_Herzegovina` int(5), IN 
  `Botswana` int(4), IN 
  `Brazil` int(6), IN 
  `British_Virgin_Islands` int(2), IN 
  `Brunei` int(2), IN 
  `Bulgaria` int(5), IN 
  `Burkina_Faso` int(3), IN 
  `Burundi` int(2), IN 
  `Cambodia` int(2), IN 
  `Cameroon` int(4), IN 
  `Canada` int(5), IN 
  `Cape_Verde` int(3), IN 
  `Cayman_Islands` int(2), IN 
  `Central_African_Republic` int(3), IN 
  `Chad` int(3), IN 
  `Chile` int(5), IN 
  `China` int(4), IN 
  `Colombia` int(5), IN 
  `Comoros` int(2), IN 
  `Congo` int(3), IN 
  `Costa_Rica` int(4), IN 
  `Cote_d_Ivoire` int(4), IN 
  `Croatia` int(5), IN 
  `Cuba` int(3), IN 
  `Curacao` int(3), IN 
  `Cyprus` int(4), IN 
  `Czech_Republic` int(5), IN 
  `Democratic_Republic_of_Congo` int(4), IN 
  `Denmark` int(4), IN 
  `Djibouti` int(4), IN 
  `Dominica` int(2), IN 
  `Dominican_Republic` int(5), IN 
  `Ecuador` int(5), IN 
  `Egypt` int(5), IN 
  `El_Salvador` int(4), IN 
  `Equatorial_Guinea` int(4), IN 
  `Eritrea` int(3), IN 
  `Estonia` int(4), IN 
  `Ethiopia` int(5), IN 
  `Faeroe_Islands` int(3), IN 
  `Falkland_Islands` int(1), IN 
  `Fiji` int(2), IN 
  `Finland` int(4), IN 
  `France` int(6), IN 
  `French_Polynesia` int(4), IN 
  `Gabon` int(3), IN 
  `Gambia` int(3), IN 
  `Georgia` int(5), IN 
  `Germany` int(6), IN 
  `Ghana` int(4), IN 
  `Gibraltar` int(3), IN 
  `Greece` int(5), IN 
  `Greenland` int(1), IN 
  `Grenada` int(1), IN 
  `Guam` int(3), IN 
  `Guatemala` int(4), IN 
  `Guernsey` int(3), IN 
  `Guinea` int(3), IN 
  `Guinea_Bissau` int(3), IN 
  `Guyana` int(3), IN 
  `Haiti` int(4), IN 
  `Honduras` int(4), IN 
  `Hungary` int(5), IN 
  `Iceland` int(3), IN 
  `India` int(6), IN 
  `Indonesia` int(5), IN 
  `International` int(1), IN 
  `Iran` int(6), IN 
  `Iraq` int(5), IN 
  `Ireland` int(4), IN 
  `Isle_of_Man` int(3), IN 
  `Israel` int(5), IN 
  `Italy` int(6), IN 
  `Jamaica` int(4), IN 
  `Japan` int(5), IN 
  `Jersey` int(3), IN 
  `Jordan` int(5), IN 
  `Kazakhstan` int(5), IN 
  `Kenya` int(4), IN 
  `Kosovo` int(4), IN 
  `Kuwait` int(4), IN 
  `Kyrgyzstan` int(5), IN 
  `Laos` int(2), IN 
  `Latvia` int(4), IN 
  `Lebanon` int(5), IN 
  `Lesotho` int(3), IN 
  `Liberia` int(3), IN 
  `Libya` int(4), IN 
  `Liechtenstein` int(3), IN 
  `Lithuania` int(5), IN 
  `Luxembourg` int(5), IN 
  `Macedonia` int(4), IN 
  `Madagascar` int(4), IN 
  `Malawi` int(3), IN 
  `Malaysia` int(4), IN 
  `Maldives` int(4), IN 
  `Mali` int(3), IN 
  `Malta` int(3), IN 
  `Marshall_Islands` int(1), IN 
  `Mauritania` int(4), IN 
  `Mauritius` int(3), IN 
  `Mexico` int(5), IN 
  `Moldova` int(4), IN 
  `Monaco` int(3), IN 
  `Mongolia` int(3), IN 
  `Montenegro` int(4), IN 
  `Montserrat` int(1), IN 
  `Morocco` int(5), IN 
  `Mozambique` int(4), IN 
  `Myanmar` int(5), IN 
  `Namibia` int(4), IN 
  `Nepal` int(5), IN 
  `Netherlands` int(5), IN 
  `New_Caledonia` int(1), IN 
  `New_Zealand` int(3), IN 
  `Nicaragua` int(3), IN 
  `Niger` int(3), IN 
  `Nigeria` int(4), IN 
  `Northern_Mariana_Islands` int(2), IN 
  `Norway` int(4), IN 
  `Oman` int(5), IN 
  `Pakistan` int(5), IN 
  `Palestine` int(5), IN 
  `Panama` int(4), IN 
  `Papua_New_Guinea` int(3), IN 
  `Paraguay` int(4), IN 
  `Peru` int(5), IN 
  `Philippines` int(5), IN 
  `Poland` int(6), IN 
  `Portugal` int(5), IN 
  `Puerto_Rico` int(4), IN 
  `Qatar` int(5), IN 
  `Romania` int(5), IN 
  `Russia` int(6), IN 
  `Rwanda` int(3), IN 
  `Saint_Kitts_and_Nevis` int(1), IN 
  `Saint_Lucia` int(2), IN 
  `Saint_Vincent_and_the_Grenadines` int(2), IN 
  `San_Marino` int(3), IN 
  `Sao_Tome_and_Principe` int(3), IN 
  `Saudi_Arabia` int(5), IN 
  `Senegal` int(4), IN 
  `Serbia` int(5), IN 
  `Seychelles` int(2), IN 
  `Sierra_Leone` int(3), IN 
  `Singapore` int(4), IN 
  `Sint_Maarten_Dutch_part` int(3), IN 
  `Slovakia` int(5), IN 
  `Slovenia` int(5), IN 
  `Solomon_Islands` int(1), IN 
  `Somalia` int(3), IN 
  `South_Africa` int(5), IN 
  `South_Korea` int(4), IN 
  `South_Sudan` int(3), IN 
  `Spain` int(6), IN 
  `Sri_Lanka` int(4), IN 
  `Sudan` int(4), IN 
  `Suriname` int(3), IN 
  `Swaziland` int(3), IN 
  `Sweden` int(5), IN 
  `Switzerland` int(5), IN 
  `Syria` int(3), IN 
  `Taiwan` int(3), IN 
  `Tajikistan` int(4), IN 
  `Tanzania` int(3), IN 
  `Thailand` int(3), IN 
  `Timor` int(2), IN 
  `Togo` int(3), IN 
  `Trinidad_and_Tobago` int(3), IN 
  `Tunisia` int(5), IN 
  `Turkey` int(5), IN 
  `Turks_and_Caicos_Islands` int(3), IN 
  `Uganda` int(4), IN 
  `Ukraine` int(6), IN 
  `United_Arab_Emirates` int(5), IN 
  `United_Kingdom` int(6), IN 
  `United_States` int(7), IN 
  `United_States_Virgin_Islands` int(3), IN 
  `Uruguay` int(3), IN 
  `Uzbekistan` int(4), IN 
  `Vanuatu` int(1), IN 
  `Vatican` int(2), IN 
  `Venezuela` int(4), IN 
  `Vietnam` int(3), IN 
  `Wallis_and_Futuna` int(1), IN 
  `Western_Sahara` int(3), IN 
  `Yemen` int(3), IN 
  `Zambia` int(4), IN 
  `Zimbabwe` int(4))
INSERT INTO `weekly_deaths_after`(`date`,
`World`,
`Afghanistan`,
`Albania`,
`Algeria`,
`Andorra`,
`Angola`,
`Anguilla`,
`Antigua_and_Barbuda`,
`Argentina`,
`Armenia`,
`Aruba`,
`Australia`,
`Austria`,
`Azerbaijan`,
`Bahamas`,
`Bahrain`,
`Bangladesh`,
`Barbados`,
`Belarus`,
`Belgium`,
`Belize`,
`Benin`,
`Bermuda`,
`Bhutan`,
`Bolivia`,
`Bonaire_Sint_Eustatius_and_Saba`,
`Bosnia_and_Herzegovina`,
`Botswana`,
`Brazil`,
`British_Virgin_Islands`,
`Brunei`,
`Bulgaria`,
`Burkina_Faso`,
`Burundi`,
`Cambodia`,
`Cameroon`,
`Canada`,
`Cape_Verde`,
`Cayman_Islands`,
`Central_African_Republic`,
`Chad`,
`Chile`,
`China`,
`Colombia`,
`Comoros`,
`Congo`,
`Costa_Rica`,
`Cote_d_Ivoire`,
`Croatia`,
`Cuba`,
`Curacao`,
`Cyprus`,
`Czech_Republic`,
`Democratic_Republic_of_Congo`,
`Denmark`,
`Djibouti`,
`Dominica`,
`Dominican_Republic`,
`Ecuador`,
`Egypt`,
`El_Salvador`,
`Equatorial_Guinea`,
`Eritrea`,
`Estonia`,
`Ethiopia`,
`Faeroe_Islands`,
`Falkland_Islands`,
`Fiji`,
`Finland`,
`France`,
`French_Polynesia`,
`Gabon`,
`Gambia`,
`Georgia`,
`Germany`,
`Ghana`,
`Gibraltar`,
`Greece`,
`Greenland`,
`Grenada`,
`Guam`,
`Guatemala`,
`Guernsey`,
`Guinea`,
`Guinea_Bissau`,
`Guyana`,
`Haiti`,
`Honduras`,
`Hungary`,
`Iceland`,
`India`,
`Indonesia`,
`International`,
`Iran`,
`Iraq`,
`Ireland`,
`Isle_of_Man`,
`Israel`,
`Italy`,
`Jamaica`,
`Japan`,
`Jersey`,
`Jordan`,
`Kazakhstan`,
`Kenya`,
`Kosovo`,
`Kuwait`,
`Kyrgyzstan`,
`Laos`,
`Latvia`,
`Lebanon`,
`Lesotho`,
`Liberia`,
`Libya`,
`Liechtenstein`,
`Lithuania`,
`Luxembourg`,
`Macedonia`,
`Madagascar`,
`Malawi`,
`Malaysia`,
`Maldives`,
`Mali`,
`Malta`,
`Marshall_Islands`,
`Mauritania`,
`Mauritius`,
`Mexico`,
`Moldova`,
`Monaco`,
`Mongolia`,
`Montenegro`,
`Montserrat`,
`Morocco`,
`Mozambique`,
`Myanmar`,
`Namibia`,
`Nepal`,
`Netherlands`,
`New_Caledonia`,
`New_Zealand`,
`Nicaragua`,
`Niger`,
`Nigeria`,
`Northern_Mariana_Islands`,
`Norway`,
`Oman`,
`Pakistan`,
`Palestine`,
`Panama`,
`Papua_New_Guinea`,
`Paraguay`,
`Peru`,
`Philippines`,
`Poland`,
`Portugal`,
`Puerto_Rico`,
`Qatar`,
`Romania`,
`Russia`,
`Rwanda`,
`Saint_Kitts_and_Nevis`,
`Saint_Lucia`,
`Saint_Vincent_and_the_Grenadines`,
`San_Marino`,
`Sao_Tome_and_Principe`,
`Saudi_Arabia`,
`Senegal`,
`Serbia`,
`Seychelles`,
`Sierra_Leone`,
`Singapore`,
`Sint_Maarten_Dutch_part`,
`Slovakia`,
`Slovenia`,
`Solomon_Islands`,
`Somalia`,
`South_Africa`,
`South_Korea`,
`South_Sudan`,
`Spain`,
`Sri_Lanka`,
`Sudan`,
`Suriname`,
`Swaziland`,
`Sweden`,
`Switzerland`,
`Syria`,
`Taiwan`,
`Tajikistan`,
`Tanzania`,
`Thailand`,
`Timor`,
`Togo`,
`Trinidad_and_Tobago`,
`Tunisia`,
`Turkey`,
`Turks_and_Caicos_Islands`,
`Uganda`,
`Ukraine`,
`United_Arab_Emirates`,
`United_Kingdom`,
`United_States`,
`United_States_Virgin_Islands`,
`Uruguay`,
`Uzbekistan`,
`Vanuatu`,
`Vatican`,
`Venezuela`,
`Vietnam`,
`Wallis_and_Futuna`,
`Western_Sahara`,
`Yemen`,
`Zambia`,
`Zimbabwe`) 
VALUES (date,
World,
Afghanistan,
Albania,
Algeria,
Andorra,
Angola,
Anguilla,
Antigua_and_Barbuda,
Argentina,
Armenia,
Aruba,
Australia,
Austria,
Azerbaijan,
Bahamas,
Bahrain,
Bangladesh,
Barbados,
Belarus,
Belgium,
Belize,
Benin,
Bermuda,
Bhutan,
Bolivia,
Bonaire_Sint_Eustatius_and_Saba,
Bosnia_and_Herzegovina,
Botswana,
Brazil,
British_Virgin_Islands,
Brunei,
Bulgaria,
Burkina_Faso,
Burundi,
Cambodia,
Cameroon,
Canada,
Cape_Verde,
Cayman_Islands,
Central_African_Republic,
Chad,
Chile,
China,
Colombia,
Comoros,
Congo,
Costa_Rica,
Cote_d_Ivoire,
Croatia,
Cuba,
Curacao,
Cyprus,
Czech_Republic,
Democratic_Republic_of_Congo,
Denmark,
Djibouti,
Dominica,
Dominican_Republic,
Ecuador,
Egypt,
El_Salvador,
Equatorial_Guinea,
Eritrea,
Estonia,
Ethiopia,
Faeroe_Islands,
Falkland_Islands,
Fiji,
Finland,
France,
French_Polynesia,
Gabon,
Gambia,
Georgia,
Germany,
Ghana,
Gibraltar,
Greece,
Greenland,
Grenada,
Guam,
Guatemala,
Guernsey,
Guinea,
Guinea_Bissau,
Guyana,
Haiti,
Honduras,
Hungary,
Iceland,
India,
Indonesia,
International,
Iran,
Iraq,
Ireland,
Isle_of_Man,
Israel,
Italy,
Jamaica,
Japan,
Jersey,
Jordan,
Kazakhstan,
Kenya,
Kosovo,
Kuwait,
Kyrgyzstan,
Laos,
Latvia,
Lebanon,
Lesotho,
Liberia,
Libya,
Liechtenstein,
Lithuania,
Luxembourg,
Macedonia,
Madagascar,
Malawi,
Malaysia,
Maldives,
Mali,
Malta,
Marshall_Islands,
Mauritania,
Mauritius,
Mexico,
Moldova,
Monaco,
Mongolia,
Montenegro,
Montserrat,
Morocco,
Mozambique,
Myanmar,
Namibia,
Nepal,
Netherlands,
New_Caledonia,
New_Zealand,
Nicaragua,
Niger,
Nigeria,
Northern_Mariana_Islands,
Norway,
Oman,
Pakistan,
Palestine,
Panama,
Papua_New_Guinea,
Paraguay,
Peru,
Philippines,
Poland,
Portugal,
Puerto_Rico,
Qatar,
Romania,
Russia,
Rwanda,
Saint_Kitts_and_Nevis,
Saint_Lucia,
Saint_Vincent_and_the_Grenadines,
San_Marino,
Sao_Tome_and_Principe,
Saudi_Arabia,
Senegal,
Serbia,
Seychelles,
Sierra_Leone,
Singapore,
Sint_Maarten_Dutch_part,
Slovakia,
Slovenia,
Solomon_Islands,
Somalia,
South_Africa,
South_Korea,
South_Sudan,
Spain,
Sri_Lanka,
Sudan,
Suriname,
Swaziland,
Sweden,
Switzerland,
Syria,
Taiwan,
Tajikistan,
Tanzania,
Thailand,
Timor,
Togo,
Trinidad_and_Tobago,
Tunisia,
Turkey,
Turks_and_Caicos_Islands,
Uganda,
Ukraine,
United_Arab_Emirates,
United_Kingdom,
United_States,
United_States_Virgin_Islands,
Uruguay,
Uzbekistan,
Vanuatu,
Vatican,
Venezuela,
Vietnam,
Wallis_and_Futuna,
Western_Sahara,
Yemen,
Zambia,
Zimbabwe)$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`covidAdmin`@`localhost` PROCEDURE `InsertDeathsBefore`(IN `date` varchar(10), IN `World` int(7), IN `Afghanistan` int(4), IN `Albania` int(4), IN `Algeria` int(4), IN `Andorra` int(3), IN `Angola` int(4), IN `Anguilla` int(1), IN `Antigua_and_Barbuda` int(2), IN 
  `Argentina` int(6), IN 
  `Armenia` int(5), IN 
  `Aruba` int(3), IN 
  `Australia` int(4), IN 
  `Austria` int(5), IN 
  `Azerbaijan` int(5), IN 
  `Bahamas` int(3), IN 
  `Bahrain` int(4), IN 
  `Bangladesh` int(5), IN 
  `Barbados` int(2), IN 
  `Belarus` int(5), IN 
  `Belgium` int(6), IN 
  `Belize` int(3), IN 
  `Benin` int(4), IN 
  `Bermuda` int(2), IN 
  `Bhutan` int(2), IN 
  `Bolivia` int(5), IN 
  `Bonaire_Sint_Eustatius_and_Saba` int(2), IN 
  `Bosnia_and_Herzegovina` int(5), IN 
  `Botswana` int(4), IN 
  `Brazil` int(6), IN 
  `British_Virgin_Islands` int(2), IN 
  `Brunei` int(2), IN 
  `Bulgaria` int(5), IN 
  `Burkina_Faso` int(3), IN 
  `Burundi` int(2), IN 
  `Cambodia` int(2), IN 
  `Cameroon` int(4), IN 
  `Canada` int(5), IN 
  `Cape_Verde` int(3), IN 
  `Cayman_Islands` int(2), IN 
  `Central_African_Republic` int(3), IN 
  `Chad` int(3), IN 
  `Chile` int(5), IN 
  `China` int(4), IN 
  `Colombia` int(5), IN 
  `Comoros` int(2), IN 
  `Congo` int(3), IN 
  `Costa_Rica` int(4), IN 
  `Cote_d_Ivoire` int(4), IN 
  `Croatia` int(5), IN 
  `Cuba` int(3), IN 
  `Curacao` int(3), IN 
  `Cyprus` int(4), IN 
  `Czech_Republic` int(5), IN 
  `Democratic_Republic_of_Congo` int(4), IN 
  `Denmark` int(4), IN 
  `Djibouti` int(4), IN 
  `Dominica` int(2), IN 
  `Dominican_Republic` int(5), IN 
  `Ecuador` int(5), IN 
  `Egypt` int(5), IN 
  `El_Salvador` int(4), IN 
  `Equatorial_Guinea` int(4), IN 
  `Eritrea` int(3), IN 
  `Estonia` int(4), IN 
  `Ethiopia` int(5), IN 
  `Faeroe_Islands` int(3), IN 
  `Falkland_Islands` int(1), IN 
  `Fiji` int(2), IN 
  `Finland` int(4), IN 
  `France` int(6), IN 
  `French_Polynesia` int(4), IN 
  `Gabon` int(3), IN 
  `Gambia` int(3), IN 
  `Georgia` int(5), IN 
  `Germany` int(6), IN 
  `Ghana` int(4), IN 
  `Gibraltar` int(3), IN 
  `Greece` int(5), IN 
  `Greenland` int(1), IN 
  `Grenada` int(1), IN 
  `Guam` int(3), IN 
  `Guatemala` int(4), IN 
  `Guernsey` int(3), IN 
  `Guinea` int(3), IN 
  `Guinea_Bissau` int(3), IN 
  `Guyana` int(3), IN 
  `Haiti` int(4), IN 
  `Honduras` int(4), IN 
  `Hungary` int(5), IN 
  `Iceland` int(3), IN 
  `India` int(6), IN 
  `Indonesia` int(5), IN 
  `International` int(1), IN 
  `Iran` int(6), IN 
  `Iraq` int(5), IN 
  `Ireland` int(4), IN 
  `Isle_of_Man` int(3), IN 
  `Israel` int(5), IN 
  `Italy` int(6), IN 
  `Jamaica` int(4), IN 
  `Japan` int(5), IN 
  `Jersey` int(3), IN 
  `Jordan` int(5), IN 
  `Kazakhstan` int(5), IN 
  `Kenya` int(4), IN 
  `Kosovo` int(4), IN 
  `Kuwait` int(4), IN 
  `Kyrgyzstan` int(5), IN 
  `Laos` int(2), IN 
  `Latvia` int(4), IN 
  `Lebanon` int(5), IN 
  `Lesotho` int(3), IN 
  `Liberia` int(3), IN 
  `Libya` int(4), IN 
  `Liechtenstein` int(3), IN 
  `Lithuania` int(5), IN 
  `Luxembourg` int(5), IN 
  `Macedonia` int(4), IN 
  `Madagascar` int(4), IN 
  `Malawi` int(3), IN 
  `Malaysia` int(4), IN 
  `Maldives` int(4), IN 
  `Mali` int(3), IN 
  `Malta` int(3), IN 
  `Marshall_Islands` int(1), IN 
  `Mauritania` int(4), IN 
  `Mauritius` int(3), IN 
  `Mexico` int(5), IN 
  `Moldova` int(4), IN 
  `Monaco` int(3), IN 
  `Mongolia` int(3), IN 
  `Montenegro` int(4), IN 
  `Montserrat` int(1), IN 
  `Morocco` int(5), IN 
  `Mozambique` int(4), IN 
  `Myanmar` int(5), IN 
  `Namibia` int(4), IN 
  `Nepal` int(5), IN 
  `Netherlands` int(5), IN 
  `New_Caledonia` int(1), IN 
  `New_Zealand` int(3), IN 
  `Nicaragua` int(3), IN 
  `Niger` int(3), IN 
  `Nigeria` int(4), IN 
  `Northern_Mariana_Islands` int(2), IN 
  `Norway` int(4), IN 
  `Oman` int(5), IN 
  `Pakistan` int(5), IN 
  `Palestine` int(5), IN 
  `Panama` int(4), IN 
  `Papua_New_Guinea` int(3), IN 
  `Paraguay` int(4), IN 
  `Peru` int(5), IN 
  `Philippines` int(5), IN 
  `Poland` int(6), IN 
  `Portugal` int(5), IN 
  `Puerto_Rico` int(4), IN 
  `Qatar` int(5), IN 
  `Romania` int(5), IN 
  `Russia` int(6), IN 
  `Rwanda` int(3), IN 
  `Saint_Kitts_and_Nevis` int(1), IN 
  `Saint_Lucia` int(2), IN 
  `Saint_Vincent_and_the_Grenadines` int(2), IN 
  `San_Marino` int(3), IN 
  `Sao_Tome_and_Principe` int(3), IN 
  `Saudi_Arabia` int(5), IN 
  `Senegal` int(4), IN 
  `Serbia` int(5), IN 
  `Seychelles` int(2), IN 
  `Sierra_Leone` int(3), IN 
  `Singapore` int(4), IN 
  `Sint_Maarten_Dutch_part` int(3), IN 
  `Slovakia` int(5), IN 
  `Slovenia` int(5), IN 
  `Solomon_Islands` int(1), IN 
  `Somalia` int(3), IN 
  `South_Africa` int(5), IN 
  `South_Korea` int(4), IN 
  `South_Sudan` int(3), IN 
  `Spain` int(6), IN 
  `Sri_Lanka` int(4), IN 
  `Sudan` int(4), IN 
  `Suriname` int(3), IN 
  `Swaziland` int(3), IN 
  `Sweden` int(5), IN 
  `Switzerland` int(5), IN 
  `Syria` int(3), IN 
  `Taiwan` int(3), IN 
  `Tajikistan` int(4), IN 
  `Tanzania` int(3), IN 
  `Thailand` int(3), IN 
  `Timor` int(2), IN 
  `Togo` int(3), IN 
  `Trinidad_and_Tobago` int(3), IN 
  `Tunisia` int(5), IN 
  `Turkey` int(5), IN 
  `Turks_and_Caicos_Islands` int(3), IN 
  `Uganda` int(4), IN 
  `Ukraine` int(6), IN 
  `United_Arab_Emirates` int(5), IN 
  `United_Kingdom` int(6), IN 
  `United_States` int(7), IN 
  `United_States_Virgin_Islands` int(3), IN 
  `Uruguay` int(3), IN 
  `Uzbekistan` int(4), IN 
  `Vanuatu` int(1), IN 
  `Vatican` int(2), IN 
  `Venezuela` int(4), IN 
  `Vietnam` int(3), IN 
  `Wallis_and_Futuna` int(1), IN 
  `Western_Sahara` int(3), IN 
  `Yemen` int(3), IN 
  `Zambia` int(4), IN 
  `Zimbabwe` int(4))
INSERT INTO `weekly_deaths_before`(`date`,
`World`,
`Afghanistan`,
`Albania`,
`Algeria`,
`Andorra`,
`Angola`,
`Anguilla`,
`Antigua_and_Barbuda`,
`Argentina`,
`Armenia`,
`Aruba`,
`Australia`,
`Austria`,
`Azerbaijan`,
`Bahamas`,
`Bahrain`,
`Bangladesh`,
`Barbados`,
`Belarus`,
`Belgium`,
`Belize`,
`Benin`,
`Bermuda`,
`Bhutan`,
`Bolivia`,
`Bonaire_Sint_Eustatius_and_Saba`,
`Bosnia_and_Herzegovina`,
`Botswana`,
`Brazil`,
`British_Virgin_Islands`,
`Brunei`,
`Bulgaria`,
`Burkina_Faso`,
`Burundi`,
`Cambodia`,
`Cameroon`,
`Canada`,
`Cape_Verde`,
`Cayman_Islands`,
`Central_African_Republic`,
`Chad`,
`Chile`,
`China`,
`Colombia`,
`Comoros`,
`Congo`,
`Costa_Rica`,
`Cote_d_Ivoire`,
`Croatia`,
`Cuba`,
`Curacao`,
`Cyprus`,
`Czech_Republic`,
`Democratic_Republic_of_Congo`,
`Denmark`,
`Djibouti`,
`Dominica`,
`Dominican_Republic`,
`Ecuador`,
`Egypt`,
`El_Salvador`,
`Equatorial_Guinea`,
`Eritrea`,
`Estonia`,
`Ethiopia`,
`Faeroe_Islands`,
`Falkland_Islands`,
`Fiji`,
`Finland`,
`France`,
`French_Polynesia`,
`Gabon`,
`Gambia`,
`Georgia`,
`Germany`,
`Ghana`,
`Gibraltar`,
`Greece`,
`Greenland`,
`Grenada`,
`Guam`,
`Guatemala`,
`Guernsey`,
`Guinea`,
`Guinea_Bissau`,
`Guyana`,
`Haiti`,
`Honduras`,
`Hungary`,
`Iceland`,
`India`,
`Indonesia`,
`International`,
`Iran`,
`Iraq`,
`Ireland`,
`Isle_of_Man`,
`Israel`,
`Italy`,
`Jamaica`,
`Japan`,
`Jersey`,
`Jordan`,
`Kazakhstan`,
`Kenya`,
`Kosovo`,
`Kuwait`,
`Kyrgyzstan`,
`Laos`,
`Latvia`,
`Lebanon`,
`Lesotho`,
`Liberia`,
`Libya`,
`Liechtenstein`,
`Lithuania`,
`Luxembourg`,
`Macedonia`,
`Madagascar`,
`Malawi`,
`Malaysia`,
`Maldives`,
`Mali`,
`Malta`,
`Marshall_Islands`,
`Mauritania`,
`Mauritius`,
`Mexico`,
`Moldova`,
`Monaco`,
`Mongolia`,
`Montenegro`,
`Montserrat`,
`Morocco`,
`Mozambique`,
`Myanmar`,
`Namibia`,
`Nepal`,
`Netherlands`,
`New_Caledonia`,
`New_Zealand`,
`Nicaragua`,
`Niger`,
`Nigeria`,
`Northern_Mariana_Islands`,
`Norway`,
`Oman`,
`Pakistan`,
`Palestine`,
`Panama`,
`Papua_New_Guinea`,
`Paraguay`,
`Peru`,
`Philippines`,
`Poland`,
`Portugal`,
`Puerto_Rico`,
`Qatar`,
`Romania`,
`Russia`,
`Rwanda`,
`Saint_Kitts_and_Nevis`,
`Saint_Lucia`,
`Saint_Vincent_and_the_Grenadines`,
`San_Marino`,
`Sao_Tome_and_Principe`,
`Saudi_Arabia`,
`Senegal`,
`Serbia`,
`Seychelles`,
`Sierra_Leone`,
`Singapore`,
`Sint_Maarten_Dutch_part`,
`Slovakia`,
`Slovenia`,
`Solomon_Islands`,
`Somalia`,
`South_Africa`,
`South_Korea`,
`South_Sudan`,
`Spain`,
`Sri_Lanka`,
`Sudan`,
`Suriname`,
`Swaziland`,
`Sweden`,
`Switzerland`,
`Syria`,
`Taiwan`,
`Tajikistan`,
`Tanzania`,
`Thailand`,
`Timor`,
`Togo`,
`Trinidad_and_Tobago`,
`Tunisia`,
`Turkey`,
`Turks_and_Caicos_Islands`,
`Uganda`,
`Ukraine`,
`United_Arab_Emirates`,
`United_Kingdom`,
`United_States`,
`United_States_Virgin_Islands`,
`Uruguay`,
`Uzbekistan`,
`Vanuatu`,
`Vatican`,
`Venezuela`,
`Vietnam`,
`Wallis_and_Futuna`,
`Western_Sahara`,
`Yemen`,
`Zambia`,
`Zimbabwe`) 
VALUES (date,
World,
Afghanistan,
Albania,
Algeria,
Andorra,
Angola,
Anguilla,
Antigua_and_Barbuda,
Argentina,
Armenia,
Aruba,
Australia,
Austria,
Azerbaijan,
Bahamas,
Bahrain,
Bangladesh,
Barbados,
Belarus,
Belgium,
Belize,
Benin,
Bermuda,
Bhutan,
Bolivia,
Bonaire_Sint_Eustatius_and_Saba,
Bosnia_and_Herzegovina,
Botswana,
Brazil,
British_Virgin_Islands,
Brunei,
Bulgaria,
Burkina_Faso,
Burundi,
Cambodia,
Cameroon,
Canada,
Cape_Verde,
Cayman_Islands,
Central_African_Republic,
Chad,
Chile,
China,
Colombia,
Comoros,
Congo,
Costa_Rica,
Cote_d_Ivoire,
Croatia,
Cuba,
Curacao,
Cyprus,
Czech_Republic,
Democratic_Republic_of_Congo,
Denmark,
Djibouti,
Dominica,
Dominican_Republic,
Ecuador,
Egypt,
El_Salvador,
Equatorial_Guinea,
Eritrea,
Estonia,
Ethiopia,
Faeroe_Islands,
Falkland_Islands,
Fiji,
Finland,
France,
French_Polynesia,
Gabon,
Gambia,
Georgia,
Germany,
Ghana,
Gibraltar,
Greece,
Greenland,
Grenada,
Guam,
Guatemala,
Guernsey,
Guinea,
Guinea_Bissau,
Guyana,
Haiti,
Honduras,
Hungary,
Iceland,
India,
Indonesia,
International,
Iran,
Iraq,
Ireland,
Isle_of_Man,
Israel,
Italy,
Jamaica,
Japan,
Jersey,
Jordan,
Kazakhstan,
Kenya,
Kosovo,
Kuwait,
Kyrgyzstan,
Laos,
Latvia,
Lebanon,
Lesotho,
Liberia,
Libya,
Liechtenstein,
Lithuania,
Luxembourg,
Macedonia,
Madagascar,
Malawi,
Malaysia,
Maldives,
Mali,
Malta,
Marshall_Islands,
Mauritania,
Mauritius,
Mexico,
Moldova,
Monaco,
Mongolia,
Montenegro,
Montserrat,
Morocco,
Mozambique,
Myanmar,
Namibia,
Nepal,
Netherlands,
New_Caledonia,
New_Zealand,
Nicaragua,
Niger,
Nigeria,
Northern_Mariana_Islands,
Norway,
Oman,
Pakistan,
Palestine,
Panama,
Papua_New_Guinea,
Paraguay,
Peru,
Philippines,
Poland,
Portugal,
Puerto_Rico,
Qatar,
Romania,
Russia,
Rwanda,
Saint_Kitts_and_Nevis,
Saint_Lucia,
Saint_Vincent_and_the_Grenadines,
San_Marino,
Sao_Tome_and_Principe,
Saudi_Arabia,
Senegal,
Serbia,
Seychelles,
Sierra_Leone,
Singapore,
Sint_Maarten_Dutch_part,
Slovakia,
Slovenia,
Solomon_Islands,
Somalia,
South_Africa,
South_Korea,
South_Sudan,
Spain,
Sri_Lanka,
Sudan,
Suriname,
Swaziland,
Sweden,
Switzerland,
Syria,
Taiwan,
Tajikistan,
Tanzania,
Thailand,
Timor,
Togo,
Trinidad_and_Tobago,
Tunisia,
Turkey,
Turks_and_Caicos_Islands,
Uganda,
Ukraine,
United_Arab_Emirates,
United_Kingdom,
United_States,
United_States_Virgin_Islands,
Uruguay,
Uzbekistan,
Vanuatu,
Vatican,
Venezuela,
Vietnam,
Wallis_and_Futuna,
Western_Sahara,
Yemen,
Zambia,
Zimbabwe)$$
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
