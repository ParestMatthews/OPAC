-- phpMyAdmin SQL Dump
-- version 4.0.4
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Feb 26, 2020 at 04:45 PM
-- Server version: 5.6.12-log
-- PHP Version: 5.4.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `opac`
--
CREATE DATABASE IF NOT EXISTS `opac` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `opac`;

-- --------------------------------------------------------

--
-- Table structure for table `admintable`
--

CREATE TABLE IF NOT EXISTS `admintable` (
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

CREATE TABLE IF NOT EXISTS `book` (
  `Call_Number` varchar(255) NOT NULL,
  `Title` text NOT NULL,
  `Author` text NOT NULL,
  `Location` text NOT NULL,
  `Published` text NOT NULL,
  `Description` text NOT NULL,
  `ISBN` text NOT NULL,
  `Edition` text NOT NULL,
  `Language` text NOT NULL,
  `Accesssion` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `client`
--

CREATE TABLE IF NOT EXISTS `client` (
  `ClientID` int(11) NOT NULL,
  `FirstName` int(11) NOT NULL,
  `LastName` int(11) NOT NULL,
  `YearLevel` int(11) NOT NULL,
  `Department` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `clientbookloan`
--

CREATE TABLE IF NOT EXISTS `clientbookloan` (
  `CIDNumber` text NOT NULL,
  `IDNumber` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `loan`
--

CREATE TABLE IF NOT EXISTS `loan` (
  `BookID` text NOT NULL,
  `Accession` text NOT NULL,
  `Title` text NOT NULL,
  `Borrowed` text NOT NULL,
  `Due` text NOT NULL,
  `OverDue` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
