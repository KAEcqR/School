-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 01, 2024 at 06:03 PM
-- Wersja serwera: 10.4.32-MariaDB
-- Wersja PHP: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hotele_kr`
--
CREATE DATABASE IF NOT EXISTS `hotele_kr` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `hotele_kr`;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `hotele`
--

CREATE TABLE `hotele` (
  `id` int(11) NOT NULL,
  `nazwa` varchar(100) NOT NULL,
  `cena` int(11) NOT NULL,
  `samolot` int(11) NOT NULL,
  `wyzywienie` int(11) NOT NULL,
  `ubezpieczenie` int(11) NOT NULL,
  `transport` int(11) NOT NULL,
  `mapa` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `hotele`
--

INSERT INTO `hotele` (`id`, `nazwa`, `cena`, `samolot`, `wyzywienie`, `ubezpieczenie`, `transport`, `mapa`) VALUES
(1, 'Astoria', 1000, 900, 400, 50, 50, 'mapy/astoria.png'),
(2, 'Meteor', 950, 850, 350, 40, 40, 'mapy/meteor.png'),
(3, 'Atlas', 1100, 1000, 500, 60, 60, 'mapy/atlas.png');

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `hotele`
--
ALTER TABLE `hotele`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `hotele`
--
ALTER TABLE `hotele`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
