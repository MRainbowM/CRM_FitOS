-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Ноя 26 2018 г., 07:39
-- Версия сервера: 5.7.23
-- Версия PHP: 5.5.38

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `fitos`
--

-- --------------------------------------------------------

--
-- Структура таблицы `balancecard`
--

CREATE TABLE `balancecard` (
  `ID_Service` int(50) NOT NULL,
  `ID_Card` int(50) NOT NULL,
  `Balance` int(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `card`
--

CREATE TABLE `card` (
  `ID_Card` int(50) NOT NULL,
  `ID_User` int(50) NOT NULL,
  `DateDelete` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `payment`
--

CREATE TABLE `payment` (
  `ID_Payment` int(50) NOT NULL,
  `ID_Card` int(50) DEFAULT NULL,
  `DateOfCreation` datetime DEFAULT NULL,
  `DateOfPayment` datetime NOT NULL,
  `Amount` double NOT NULL,
  `Paid` float DEFAULT NULL,
  `ID_Reservation` int(50) NOT NULL,
  `ID_User` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `photo`
--

CREATE TABLE `photo` (
  `ID_Photo` int(50) NOT NULL,
  `ID_User` int(50) NOT NULL,
  `ID_Room` int(50) NOT NULL,
  `URL` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `reservation`
--

CREATE TABLE `reservation` (
  `ID_Reservation` int(50) NOT NULL,
  `ID_ScheduleService` int(50) NOT NULL,
  `ID_Card` int(50) DEFAULT NULL,
  `UD_User` int(50) NOT NULL,
  `DateDelete` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `room`
--

CREATE TABLE `room` (
  `ID_Room` int(50) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Equipment` varchar(100) DEFAULT NULL,
  `Capacity` int(50) NOT NULL,
  `Comment` varchar(500) DEFAULT NULL,
  `DateDelete` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `scheduleservice`
--

CREATE TABLE `scheduleservice` (
  `ID_ScheduleService` int(50) NOT NULL,
  `ID_Service` int(50) NOT NULL,
  `ID_Room` int(50) NOT NULL,
  `Date` datetime NOT NULL,
  `StartDate` date DEFAULT NULL,
  `ExpirationDate` date DEFAULT NULL,
  `DateDelete` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `service`
--

CREATE TABLE `service` (
  `ID_Service` int(50) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Cost` double NOT NULL,
  `NumberOfPeople` int(50) NOT NULL,
  `Comment` varchar(500) NOT NULL,
  `DateDelete` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `serviceintariff`
--

CREATE TABLE `serviceintariff` (
  `ID_Service` int(50) NOT NULL,
  `ID_Tariff` int(50) NOT NULL,
  `Amount` int(50) NOT NULL,
  `Frequency` int(50) NOT NULL,
  `DateDelete` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `serviceroom`
--

CREATE TABLE `serviceroom` (
  `ID_Service` int(50) NOT NULL,
  `ID_Room` int(50) NOT NULL,
  `DateDelete` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `tariff`
--

CREATE TABLE `tariff` (
  `ID_Tariff` int(50) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Duration` int(50) NOT NULL,
  `TotalCost` double NOT NULL,
  `StartDate` date NOT NULL,
  `ExpirationDate` date DEFAULT NULL,
  `DateRemoved` date DEFAULT NULL,
  `DateDelete` date DEFAULT NULL,
  `Comment` varchar(500) DEFAULT NULL,
  `Time` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `trainerinschedule`
--

CREATE TABLE `trainerinschedule` (
  `ID_User` int(50) NOT NULL,
  `ID_ScheduleService` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `trainerservice`
--

CREATE TABLE `trainerservice` (
  `ID_Service` int(50) NOT NULL,
  `ID_User` int(50) NOT NULL,
  `DateDelete` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `user`
--

CREATE TABLE `user` (
  `ID_User` int(50) NOT NULL,
  `Login` varchar(50) NOT NULL,
  `Passworg` varchar(50) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Surname` varchar(50) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `MiddleName` varchar(50) NOT NULL,
  `Sex` tinyint(1) NOT NULL,
  `DOB` date NOT NULL,
  `Phone` int(50) NOT NULL,
  `Height` int(10) DEFAULT NULL,
  `Weight` int(10) DEFAULT NULL,
  `Health` varchar(100) DEFAULT NULL,
  `Comment` varchar(500) DEFAULT NULL,
  `Qualification` varchar(50) DEFAULT NULL,
  `StateUser` varchar(50) NOT NULL COMMENT 'Trainer/Admin/Manager/Client',
  `DateDelete` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `balancecard`
--
ALTER TABLE `balancecard`
  ADD KEY `ID_Card` (`ID_Card`),
  ADD KEY `ID_Service` (`ID_Service`);

--
-- Индексы таблицы `card`
--
ALTER TABLE `card`
  ADD PRIMARY KEY (`ID_Card`),
  ADD KEY `ID_User` (`ID_User`);

--
-- Индексы таблицы `payment`
--
ALTER TABLE `payment`
  ADD PRIMARY KEY (`ID_Payment`),
  ADD KEY `ID_Card` (`ID_Card`),
  ADD KEY `ID_Reservation` (`ID_Reservation`),
  ADD KEY `ID_User` (`ID_User`);

--
-- Индексы таблицы `photo`
--
ALTER TABLE `photo`
  ADD PRIMARY KEY (`ID_Photo`),
  ADD KEY `ID_User` (`ID_User`),
  ADD KEY `ID_Room` (`ID_Room`);

--
-- Индексы таблицы `reservation`
--
ALTER TABLE `reservation`
  ADD PRIMARY KEY (`ID_Reservation`),
  ADD KEY `ID_Card` (`ID_Card`),
  ADD KEY `ID_ScheduleService` (`ID_ScheduleService`),
  ADD KEY `UD_User` (`UD_User`);

--
-- Индексы таблицы `room`
--
ALTER TABLE `room`
  ADD PRIMARY KEY (`ID_Room`);

--
-- Индексы таблицы `scheduleservice`
--
ALTER TABLE `scheduleservice`
  ADD PRIMARY KEY (`ID_ScheduleService`),
  ADD KEY `ID_Service` (`ID_Service`),
  ADD KEY `ID_Room` (`ID_Room`);

--
-- Индексы таблицы `service`
--
ALTER TABLE `service`
  ADD PRIMARY KEY (`ID_Service`);

--
-- Индексы таблицы `serviceintariff`
--
ALTER TABLE `serviceintariff`
  ADD KEY `ID_Service` (`ID_Service`),
  ADD KEY `ID_Tariff` (`ID_Tariff`);

--
-- Индексы таблицы `serviceroom`
--
ALTER TABLE `serviceroom`
  ADD KEY `ID_Room` (`ID_Room`),
  ADD KEY `ID_Service` (`ID_Service`);

--
-- Индексы таблицы `tariff`
--
ALTER TABLE `tariff`
  ADD PRIMARY KEY (`ID_Tariff`);

--
-- Индексы таблицы `trainerinschedule`
--
ALTER TABLE `trainerinschedule`
  ADD KEY `ID_User` (`ID_User`),
  ADD KEY `ID_ScheduleService` (`ID_ScheduleService`);

--
-- Индексы таблицы `trainerservice`
--
ALTER TABLE `trainerservice`
  ADD KEY `ID_Service` (`ID_Service`),
  ADD KEY `ID_User` (`ID_User`);

--
-- Индексы таблицы `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`ID_User`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `card`
--
ALTER TABLE `card`
  MODIFY `ID_Card` int(50) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `payment`
--
ALTER TABLE `payment`
  MODIFY `ID_Payment` int(50) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `photo`
--
ALTER TABLE `photo`
  MODIFY `ID_Photo` int(50) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `reservation`
--
ALTER TABLE `reservation`
  MODIFY `ID_Reservation` int(50) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `room`
--
ALTER TABLE `room`
  MODIFY `ID_Room` int(50) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `scheduleservice`
--
ALTER TABLE `scheduleservice`
  MODIFY `ID_ScheduleService` int(50) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `service`
--
ALTER TABLE `service`
  MODIFY `ID_Service` int(50) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `tariff`
--
ALTER TABLE `tariff`
  MODIFY `ID_Tariff` int(50) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `user`
--
ALTER TABLE `user`
  MODIFY `ID_User` int(50) NOT NULL AUTO_INCREMENT;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `balancecard`
--
ALTER TABLE `balancecard`
  ADD CONSTRAINT `balancecard_ibfk_1` FOREIGN KEY (`ID_Card`) REFERENCES `card` (`ID_Card`),
  ADD CONSTRAINT `balancecard_ibfk_2` FOREIGN KEY (`ID_Service`) REFERENCES `service` (`ID_Service`);

--
-- Ограничения внешнего ключа таблицы `card`
--
ALTER TABLE `card`
  ADD CONSTRAINT `card_ibfk_1` FOREIGN KEY (`ID_User`) REFERENCES `user` (`ID_User`);

--
-- Ограничения внешнего ключа таблицы `payment`
--
ALTER TABLE `payment`
  ADD CONSTRAINT `payment_ibfk_1` FOREIGN KEY (`ID_Card`) REFERENCES `card` (`ID_Card`),
  ADD CONSTRAINT `payment_ibfk_2` FOREIGN KEY (`ID_Reservation`) REFERENCES `reservation` (`ID_Reservation`),
  ADD CONSTRAINT `payment_ibfk_3` FOREIGN KEY (`ID_User`) REFERENCES `user` (`ID_User`);

--
-- Ограничения внешнего ключа таблицы `photo`
--
ALTER TABLE `photo`
  ADD CONSTRAINT `photo_ibfk_1` FOREIGN KEY (`ID_User`) REFERENCES `user` (`ID_User`),
  ADD CONSTRAINT `photo_ibfk_2` FOREIGN KEY (`ID_Room`) REFERENCES `room` (`ID_Room`);

--
-- Ограничения внешнего ключа таблицы `reservation`
--
ALTER TABLE `reservation`
  ADD CONSTRAINT `reservation_ibfk_1` FOREIGN KEY (`ID_Card`) REFERENCES `card` (`ID_Card`),
  ADD CONSTRAINT `reservation_ibfk_2` FOREIGN KEY (`ID_ScheduleService`) REFERENCES `scheduleservice` (`ID_ScheduleService`),
  ADD CONSTRAINT `reservation_ibfk_3` FOREIGN KEY (`UD_User`) REFERENCES `user` (`ID_User`);

--
-- Ограничения внешнего ключа таблицы `scheduleservice`
--
ALTER TABLE `scheduleservice`
  ADD CONSTRAINT `scheduleservice_ibfk_1` FOREIGN KEY (`ID_Room`) REFERENCES `room` (`ID_Room`),
  ADD CONSTRAINT `scheduleservice_ibfk_2` FOREIGN KEY (`ID_Service`) REFERENCES `service` (`ID_Service`);

--
-- Ограничения внешнего ключа таблицы `serviceintariff`
--
ALTER TABLE `serviceintariff`
  ADD CONSTRAINT `serviceintariff_ibfk_1` FOREIGN KEY (`ID_Service`) REFERENCES `service` (`ID_Service`),
  ADD CONSTRAINT `serviceintariff_ibfk_2` FOREIGN KEY (`ID_Tariff`) REFERENCES `tariff` (`ID_Tariff`);

--
-- Ограничения внешнего ключа таблицы `serviceroom`
--
ALTER TABLE `serviceroom`
  ADD CONSTRAINT `serviceroom_ibfk_1` FOREIGN KEY (`ID_Room`) REFERENCES `room` (`ID_Room`),
  ADD CONSTRAINT `serviceroom_ibfk_2` FOREIGN KEY (`ID_Service`) REFERENCES `service` (`ID_Service`);

--
-- Ограничения внешнего ключа таблицы `trainerinschedule`
--
ALTER TABLE `trainerinschedule`
  ADD CONSTRAINT `trainerinschedule_ibfk_1` FOREIGN KEY (`ID_ScheduleService`) REFERENCES `scheduleservice` (`ID_ScheduleService`),
  ADD CONSTRAINT `trainerinschedule_ibfk_2` FOREIGN KEY (`ID_User`) REFERENCES `user` (`ID_User`);

--
-- Ограничения внешнего ключа таблицы `trainerservice`
--
ALTER TABLE `trainerservice`
  ADD CONSTRAINT `trainerservice_ibfk_1` FOREIGN KEY (`ID_Service`) REFERENCES `service` (`ID_Service`),
  ADD CONSTRAINT `trainerservice_ibfk_2` FOREIGN KEY (`ID_User`) REFERENCES `user` (`ID_User`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
