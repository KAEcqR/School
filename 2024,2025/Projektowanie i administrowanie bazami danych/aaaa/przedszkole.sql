-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Czas generowania: 19 Lut 2025, 12:10
-- Wersja serwera: 10.4.17-MariaDB
-- Wersja PHP: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `przedszkole`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `dzieci`
--

CREATE TABLE `dzieci` (
  `Pesel` varchar(12) NOT NULL,
  `Nazwisko` varchar(25) NOT NULL,
  `Imie` varchar(15) NOT NULL,
  `plec` varchar(11) NOT NULL,
  `wiek` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `preferencje`
--

CREATE TABLE `preferencje` (
  `Pesel` varchar(12) DEFAULT NULL,
  `Numer_preferencji` int(11) NOT NULL,
  `Id_przedszkola` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `przedszkola`
--

CREATE TABLE `przedszkola` (
  `Id_przedszkola` int(11) NOT NULL,
  `Nazwa_przedszkola` varchar(50) NOT NULL,
  `Liczba_miejsc` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `dzieci`
--
ALTER TABLE `dzieci`
  ADD PRIMARY KEY (`Pesel`);

--
-- Indeksy dla tabeli `przedszkola`
--
ALTER TABLE `przedszkola`
  ADD PRIMARY KEY (`Id_przedszkola`);

--
-- AUTO_INCREMENT dla zrzuconych tabel
--

--
-- AUTO_INCREMENT dla tabeli `przedszkola`
--
ALTER TABLE `przedszkola`
  MODIFY `Id_przedszkola` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
