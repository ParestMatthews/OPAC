-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 28, 2020 at 03:24 AM
-- Server version: 10.4.8-MariaDB
-- PHP Version: 7.3.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `opac`
--

-- --------------------------------------------------------

--
-- Table structure for table `admintable`
--

CREATE TABLE `admintable` (
  `Username` text NOT NULL,
  `Password` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `admintable`
--

INSERT INTO `admintable` (`Username`, `Password`) VALUES
('admin', 'admin123');

-- --------------------------------------------------------

--
-- Table structure for table `book`
--

CREATE TABLE `book` (
  `bookCallNumber` varchar(255) NOT NULL,
  `bookTitle` text NOT NULL,
  `bookAuthor` text NOT NULL,
  `bookLocation` text NOT NULL,
  `bookPublished` text NOT NULL,
  `bookISBN` text NOT NULL,
  `bookEdition` text NOT NULL,
  `bookLanguage` text NOT NULL,
  `bookAccession` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `book`
--

INSERT INTO `book` (`bookCallNumber`, `bookTitle`, `bookAuthor`, `bookLocation`, `bookPublished`, `bookISBN`, `bookEdition`, `bookLanguage`, `bookAccession`) VALUES
('', '', '', '', '', '', '', '', ''),
('XXXXXXXXXXXXXXXXXX', 'DA BOOK', 'MEEEEEE', 'HERENBFG', 'YOUR HOUSE', '', 'EDITION ZERO', 'ASDSADASF', 'GODSDSDA');

-- --------------------------------------------------------

--
-- Table structure for table `client`
--

CREATE TABLE `client` (
  `clientId` varchar(255) NOT NULL,
  `clientFirstName` text NOT NULL,
  `clientLastName` text NOT NULL,
  `clientYearLevel` text NOT NULL,
  `clientDepartment` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `clientbookloan`
--

CREATE TABLE `clientbookloan` (
  `CIDNumber` text NOT NULL,
  `IDNumber` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `loan`
--

CREATE TABLE `loan` (
  `BookID` text NOT NULL,
  `Accession` text NOT NULL,
  `Title` text NOT NULL,
  `Borrowed` text NOT NULL,
  `Due` text NOT NULL,
  `OverDue` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `book`
--
ALTER TABLE `book`
  ADD PRIMARY KEY (`bookCallNumber`);

--
-- Indexes for table `client`
--
ALTER TABLE `client`
  ADD PRIMARY KEY (`clientId`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
