-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Czas generowania: 05 Lip 2019, 02:39
-- Wersja serwera: 10.1.38-MariaDB
-- Wersja PHP: 7.1.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `przychodnia`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `gabinety`
--

CREATE TABLE `gabinety` (
  `id_g` int(11) NOT NULL,
  `id_l` int(11) DEFAULT NULL,
  `nazwa` varchar(5) COLLATE utf8_polish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `gabinety`
--

INSERT INTO `gabinety` (`id_g`, `id_l`, `nazwa`) VALUES
(1, 5, '11'),
(2, 3, '12'),
(3, 8, '13'),
(4, 11, '14'),
(5, 1, '15'),
(6, 2, '16'),
(7, 12, '21'),
(9, NULL, '24'),
(11, 9, '25'),
(12, NULL, '26'),
(13, NULL, '27'),
(14, NULL, '28'),
(15, NULL, '29'),
(16, 7, '31'),
(17, NULL, '32'),
(18, NULL, '33'),
(19, 10, '34'),
(20, NULL, '35'),
(21, NULL, '36'),
(22, NULL, '37'),
(23, NULL, '38'),
(24, NULL, '39'),
(25, NULL, '41'),
(26, 6, '42'),
(27, NULL, '43'),
(28, NULL, '44'),
(29, NULL, '45'),
(30, NULL, '46'),
(31, NULL, '47'),
(32, 4, '48');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `lekarze`
--

CREATE TABLE `lekarze` (
  `id_l` int(11) NOT NULL,
  `imie` varchar(50) COLLATE utf8_polish_ci NOT NULL,
  `nazwisko` varchar(100) COLLATE utf8_polish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `lekarze`
--

INSERT INTO `lekarze` (`id_l`, `imie`, `nazwisko`) VALUES
(1, 'Agnieszka', 'Pawlak'),
(2, 'Ariadna', 'Kania'),
(3, 'Krystian', 'Wiśniewski'),
(4, 'Mateusz', 'Marszałek'),
(5, 'Julia', 'Marcinkowska'),
(6, 'Karolina', 'Kołodziejczyk'),
(7, 'Dominika', 'Śliwińska'),
(8, 'Antonina', 'Woźniak'),
(9, 'Maja', 'Sadowska'),
(10, 'Aniela', 'Błaszczyk'),
(11, 'Agata', 'Król'),
(12, 'Magda', 'Gesler');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `pacjenci`
--

CREATE TABLE `pacjenci` (
  `id_p` int(11) NOT NULL,
  `imie` varchar(50) COLLATE utf8_polish_ci NOT NULL,
  `nazwisko` varchar(100) COLLATE utf8_polish_ci NOT NULL,
  `pesel` varchar(11) COLLATE utf8_polish_ci NOT NULL,
  `telefon` varchar(9) COLLATE utf8_polish_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `pacjenci`
--

INSERT INTO `pacjenci` (`id_p`, `imie`, `nazwisko`, `pesel`, `telefon`) VALUES
(1, 'Kazimierz', 'Rataj', '37100987300', '631843397'),
(2, 'Mirosława', 'Szewczyk', '43050698993', '952548080'),
(3, 'Paula', 'Tomczyk', '99051689225', '909506912'),
(4, 'Kordian', 'Walczak', '60012519796', '144219470'),
(5, 'Dobrosława', 'Bąk', '60020738491', '940545219'),
(6, 'Zuza', 'Janik', '53110367112', '871917632'),
(7, 'Leopold', 'Środa', '26043064218', '143863887'),
(8, 'Anita', 'Łuczak', '55031525732', '637055818'),
(9, 'Teresa', 'Kaczmarek', '01280339352', '198456978'),
(10, 'Antonia', 'Boruc', '79062246088', '479717740'),
(11, 'Kamil', 'Król', '123123123', '123123123'),
(12, 'Michal', 'Zawada', '123123123', '123123123'),
(13, 'Patrycja', 'Mitka', '12312344', '13213233'),
(14, 'Marcin', 'Wrób', '123', '332');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `posiadaja`
--

CREATE TABLE `posiadaja` (
  `id_l` int(11) NOT NULL,
  `id_s` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `posiadaja`
--

INSERT INTO `posiadaja` (`id_l`, `id_s`) VALUES
(1, 4),
(2, 1),
(3, 12),
(4, 1),
(5, 8),
(6, 14),
(7, 2),
(8, 9),
(9, 13),
(10, 7),
(11, 7),
(11, 4),
(12, 4),
(1, 8),
(10, 3),
(9, 6);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `specjalizacje`
--

CREATE TABLE `specjalizacje` (
  `id_s` int(11) NOT NULL,
  `nazwa` varchar(100) COLLATE utf8_polish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `specjalizacje`
--

INSERT INTO `specjalizacje` (`id_s`, `nazwa`) VALUES
(1, 'neurologia'),
(2, 'nefrologia'),
(3, 'okulistyka'),
(4, 'ortopedia'),
(5, 'otorynolaryngologia'),
(6, 'perinatologia '),
(7, 'radiologia '),
(8, 'endokrynologia '),
(9, 'pediatria'),
(10, 'kardiologia'),
(11, 'dermatologia'),
(12, 'onkologia'),
(13, 'psychiatria'),
(14, 'stomatologia'),
(15, 'reumatologia');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `umowienia`
--

CREATE TABLE `umowienia` (
  `id_u` int(11) NOT NULL,
  `data` datetime NOT NULL,
  `id_l` int(11) NOT NULL,
  `id_p` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `umowienia`
--

INSERT INTO `umowienia` (`id_u`, `data`, `id_l`, `id_p`) VALUES
(3, '2019-07-04 09:30:00', 1, 1),
(5, '2019-07-05 09:30:00', 1, 11),
(6, '2019-07-05 09:00:00', 1, 11),
(7, '2019-07-05 08:00:00', 1, 2),
(8, '2019-07-05 08:30:00', 1, 2),
(9, '2019-07-05 08:00:00', 7, 8),
(10, '2019-07-05 08:30:00', 7, 8),
(11, '2019-07-05 10:00:00', 1, 1),
(12, '2019-07-11 14:30:00', 1, 1),
(13, '2019-07-06 09:30:00', 7, 8),
(14, '2019-07-05 08:30:00', 3, 12),
(15, '2019-07-05 10:30:00', 1, 1),
(16, '2019-07-05 09:00:00', 7, 1),
(17, '2019-07-05 08:30:00', 8, 1),
(18, '2019-07-05 11:30:00', 7, 1),
(19, '2019-07-05 14:00:00', 6, 1),
(20, '2019-07-05 13:00:00', 1, 13),
(21, '2019-07-05 11:30:00', 10, 13),
(22, '2019-07-05 15:00:00', 1, 9),
(23, '2019-07-06 10:30:00', 6, 7),
(24, '2019-07-06 08:30:00', 11, 11),
(25, '2019-07-06 08:30:00', 1, 1),
(26, '2019-07-06 09:00:00', 1, 1),
(27, '2019-07-06 09:30:00', 1, 11),
(29, '2019-07-06 08:00:00', 12, 1);

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `gabinety`
--
ALTER TABLE `gabinety`
  ADD PRIMARY KEY (`id_g`),
  ADD KEY `id_l` (`id_l`);

--
-- Indeksy dla tabeli `lekarze`
--
ALTER TABLE `lekarze`
  ADD PRIMARY KEY (`id_l`);

--
-- Indeksy dla tabeli `pacjenci`
--
ALTER TABLE `pacjenci`
  ADD PRIMARY KEY (`id_p`);

--
-- Indeksy dla tabeli `posiadaja`
--
ALTER TABLE `posiadaja`
  ADD KEY `id_l` (`id_l`),
  ADD KEY `id_s` (`id_s`);

--
-- Indeksy dla tabeli `specjalizacje`
--
ALTER TABLE `specjalizacje`
  ADD PRIMARY KEY (`id_s`);

--
-- Indeksy dla tabeli `umowienia`
--
ALTER TABLE `umowienia`
  ADD PRIMARY KEY (`id_u`),
  ADD KEY `id_l` (`id_l`),
  ADD KEY `id_p` (`id_p`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT dla tabeli `gabinety`
--
ALTER TABLE `gabinety`
  MODIFY `id_g` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;

--
-- AUTO_INCREMENT dla tabeli `lekarze`
--
ALTER TABLE `lekarze`
  MODIFY `id_l` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT dla tabeli `pacjenci`
--
ALTER TABLE `pacjenci`
  MODIFY `id_p` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT dla tabeli `specjalizacje`
--
ALTER TABLE `specjalizacje`
  MODIFY `id_s` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT dla tabeli `umowienia`
--
ALTER TABLE `umowienia`
  MODIFY `id_u` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

--
-- Ograniczenia dla zrzutów tabel
--

--
-- Ograniczenia dla tabeli `gabinety`
--
ALTER TABLE `gabinety`
  ADD CONSTRAINT `gabinety_ibfk_1` FOREIGN KEY (`id_l`) REFERENCES `lekarze` (`id_l`);

--
-- Ograniczenia dla tabeli `posiadaja`
--
ALTER TABLE `posiadaja`
  ADD CONSTRAINT `posiadaja_ibfk_1` FOREIGN KEY (`id_l`) REFERENCES `lekarze` (`id_l`),
  ADD CONSTRAINT `posiadaja_ibfk_2` FOREIGN KEY (`id_s`) REFERENCES `specjalizacje` (`id_s`);

--
-- Ograniczenia dla tabeli `umowienia`
--
ALTER TABLE `umowienia`
  ADD CONSTRAINT `umowienia_ibfk_1` FOREIGN KEY (`id_l`) REFERENCES `lekarze` (`id_l`),
  ADD CONSTRAINT `umowienia_ibfk_2` FOREIGN KEY (`id_p`) REFERENCES `pacjenci` (`id_p`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
