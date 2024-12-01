-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Czas generowania: 30 Wrz 2024, 10:16
-- Wersja serwera: 10.4.24-MariaDB
-- Wersja PHP: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `3tip_cw2`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `kategorie`
--

CREATE TABLE `kategorie` (
  `id` int(11) NOT NULL,
  `kategoria` varchar(255) NOT NULL,
  `opis` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `kategorie`
--

INSERT INTO `kategorie` (`id`, `kategoria`, `opis`) VALUES
(1, 'Elektronika', 'Sprzęt elektroniczny i gadżety'),
(2, 'Odzież', 'Ubrania i akcesoria modowe'),
(3, 'AGD', 'Artykuły gospodarstwa domowego'),
(4, 'Książki', 'Literatura i publikacje'),
(5, 'Zabawki', 'Zabawki dla dzieci'),
(6, 'Sport', 'Sprzęt sportowy i odzież'),
(7, 'Kosmetyki', 'Produkty kosmetyczne i higieniczne'),
(8, 'Meble', 'Wyposażenie wnętrz i meble'),
(9, 'Ogród', 'Narzędzia ogrodowe i dekoracje'),
(10, 'Motoryzacja', 'Części samochodowe i akcesoria');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `produkty`
--

CREATE TABLE `produkty` (
  `id` int(11) NOT NULL,
  `nazwa` varchar(255) NOT NULL,
  `opis` varchar(255) NOT NULL,
  `kategoriaId` int(11) NOT NULL,
  `cena` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `produkty`
--

INSERT INTO `produkty` (`id`, `nazwa`, `opis`, `kategoriaId`, `cena`) VALUES
(1, 'Smartfon', 'Nowoczesny smartfon z dużym ekranem', 1, 2500),
(2, 'Laptop', 'Lekki laptop do pracy biurowej', 1, 3500),
(3, 'Bluza', 'Ciepła bluza z kapturem', 2, 150),
(4, 'Lodówka', 'Energooszczędna lodówka z zamrażalnikiem', 3, 1800),
(5, 'Książka - Powieść', 'Bestsellerowa powieść kryminalna', 4, 45),
(6, 'Piłka nożna', 'Piłka treningowa do gry na zewnątrz', 6, 80),
(7, 'Krem do twarzy', 'Nawilżający krem na dzień', 7, 30),
(8, 'Sofa', 'Rozkładana sofa z funkcją spania', 8, 1500),
(9, 'Kosiarka', 'Kosiarka elektryczna do trawnika', 9, 900),
(10, 'Oleje silnikowe', 'Wysokiej jakości olej silnikowy', 10, 120);

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `kategorie`
--
ALTER TABLE `kategorie`
  ADD PRIMARY KEY (`id`);

--
-- Indeksy dla tabeli `produkty`
--
ALTER TABLE `produkty`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_kategoria` (`kategoriaId`);

--
-- AUTO_INCREMENT dla zrzuconych tabel
--

--
-- AUTO_INCREMENT dla tabeli `kategorie`
--
ALTER TABLE `kategorie`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT dla tabeli `produkty`
--
ALTER TABLE `produkty`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Ograniczenia dla zrzutów tabel
--

--
-- Ograniczenia dla tabeli `produkty`
--
ALTER TABLE `produkty`
  ADD CONSTRAINT `fk_kategoria` FOREIGN KEY (`kategoriaId`) REFERENCES `kategorie` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
