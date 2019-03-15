-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 14, 2019 at 05:19 AM
-- Server version: 10.1.37-MariaDB
-- PHP Version: 7.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `goc_info_sys`
--

-- --------------------------------------------------------

--
-- Table structure for table `billing_or`
--

CREATE TABLE `billing_or` (
  `id` int(11) NOT NULL,
  `IDNo` varchar(255) DEFAULT NULL,
  `OrNo` varchar(255) DEFAULT NULL,
  `amount_given` double(7,2) DEFAULT NULL,
  `payment_date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `payment_no` varchar(255) DEFAULT NULL,
  `MOP` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `billing_or`
--

INSERT INTO `billing_or` (`id`, `IDNo`, `OrNo`, `amount_given`, `payment_date`, `payment_no`, `MOP`) VALUES
(19, 'GOC-2019-0001', '0001', 1000.00, '2019-03-14 10:25:01', '1', NULL),
(21, 'GOC-2019-0003', '003', 1000.00, '2019-03-14 12:00:34', '1', NULL),
(22, 'GOC-2019-0003', '0006', 1000.00, '2019-03-14 13:10:25', '1', NULL),
(23, 'GOC-2019-0004', '0031', 1000.00, '2019-03-14 13:14:20', '1', NULL),
(24, 'GOC-2019-0005', '0066', 1000.00, '2019-03-14 16:51:19', '1', NULL),
(25, 'GOC-2019-0006', '00010', 1000.00, '2019-03-14 17:33:26', '1', NULL),
(26, 'GOC-2019-0007', '36', 1000.00, '2019-03-14 10:19:05', '1', NULL),
(27, 'GOC-2019-0008', '37', 1000.00, '2019-03-14 10:23:21', '1', NULL),
(28, 'GOC-2019-0009', '56', 1000.00, '2019-03-14 10:40:27', '1', NULL),
(29, 'GOC-2019-0010', '39', 1000.00, '2019-03-14 10:52:14', '1', NULL),
(30, 'GOC-2019-0011', '369', 1000.00, '2019-03-14 10:57:38', '1', NULL),
(31, 'GOC-2019-0012', '05', 1000.00, '2019-03-14 11:07:32', '1', NULL),
(32, 'GOC-2019-0013', '55', 1000.00, '2019-03-14 11:11:47', '1', NULL),
(33, 'GOC-2019-0014', '02', 0.00, '2019-03-14 12:14:40', '1', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `billing_partial`
--

CREATE TABLE `billing_partial` (
  `id` int(11) NOT NULL,
  `OR_No` varchar(255) DEFAULT NULL,
  `IDNo` varchar(255) DEFAULT NULL,
  `full_name` varchar(255) DEFAULT NULL,
  `DP` varchar(255) DEFAULT NULL,
  `1p` varchar(255) DEFAULT NULL,
  `2p` varchar(255) DEFAULT NULL,
  `3p` varchar(255) DEFAULT NULL,
  `4p` varchar(255) DEFAULT NULL,
  `5p` varchar(255) DEFAULT NULL,
  `6p` varchar(255) DEFAULT NULL,
  `7p` varchar(255) DEFAULT NULL,
  `8p` varchar(255) DEFAULT NULL,
  `9p` varchar(255) DEFAULT NULL,
  `10p` varchar(255) DEFAULT NULL,
  `balance` varchar(255) DEFAULT NULL,
  `Enrollment_Status` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `billing_partial`
--

INSERT INTO `billing_partial` (`id`, `OR_No`, `IDNo`, `full_name`, `DP`, `1p`, `2p`, `3p`, `4p`, `5p`, `6p`, `7p`, `8p`, `9p`, `10p`, `balance`, `Enrollment_Status`) VALUES
(5, '0005', 'GOC-2019-0001', 'SALVADOR, JEN JULA', NULL, '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '9,500.00', 'Reservee'),
(7, '003', 'GOC-2019-0003', 'BONIFACIO, RHIANNE LAGLAG', NULL, '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '14,000.00', 'Reservee'),
(8, '0031', 'GOC-2019-0004', 'CONCEPCION, JANBERT GREYLON MERCADO', NULL, '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '9,500.00', 'Reservee'),
(9, '0066', 'GOC-2019-0005', 'BALI, SEDRICK J', NULL, '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '9,500.00', 'Reservee'),
(10, '00010', 'GOC-2019-0006', 'RAMOS, ABEGAIL MEDINA', NULL, '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '10,500.00', 'Reservee'),
(11, '36', 'GOC-2019-0007', 'BASILIO, ZANDY GARCIA', NULL, '950.00', '950.00', '950.00', '950.00', '950.00', '950.00', '950.00', '950.00', '950.00', '950.00', '9,500.00', 'Reservee'),
(12, '37', 'GOC-2019-0008', 'AQUINO, EMMANUEL ROXAS', NULL, '950.00', '950.00', '950.00', '950.00', '950.00', '950.00', '950.00', '950.00', '950.00', '950.00', '9,500.00', 'Reservee'),
(17, '55', 'GOC-2019-0013', 'VALDEZ, ANGEL SANTOS', '3,000.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '6,500.00', 'Reservee');

-- --------------------------------------------------------

--
-- Table structure for table `department`
--

CREATE TABLE `department` (
  `id` int(11) NOT NULL,
  `Department_Name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `department`
--

INSERT INTO `department` (`id`, `Department_Name`) VALUES
(1, 'SHS'),
(2, 'COLLEGE');

-- --------------------------------------------------------

--
-- Table structure for table `discount`
--

CREATE TABLE `discount` (
  `id` int(11) NOT NULL,
  `discount_name` varchar(255) DEFAULT NULL,
  `discount_percent_amount` double(7,2) DEFAULT '0.00'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `enrollled_students`
--

CREATE TABLE `enrollled_students` (
  `id` int(11) NOT NULL,
  `RegNo` varchar(255) DEFAULT NULL,
  `GOCNo` varchar(255) DEFAULT NULL,
  `Full_Name` varchar(255) DEFAULT NULL,
  `Grade_Level` varchar(255) DEFAULT NULL,
  `Strand` varchar(255) DEFAULT NULL,
  `Section` varchar(255) DEFAULT NULL,
  `Semester` varchar(255) DEFAULT NULL,
  `SY_Enrolled` varchar(255) DEFAULT NULL,
  `Adviser_Id` varchar(255) DEFAULT NULL,
  `Adviser_Name` varchar(255) DEFAULT NULL,
  `Data_Enrolled` timestamp NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `grading`
--

CREATE TABLE `grading` (
  `id` int(11) NOT NULL,
  `IDNo` varchar(255) DEFAULT NULL,
  `full_name` varchar(255) DEFAULT NULL,
  `subject_code` varchar(255) DEFAULT NULL,
  `subject_desc` varchar(255) DEFAULT NULL,
  `units` varchar(255) DEFAULT NULL,
  `1stQ` varchar(255) DEFAULT NULL,
  `2ndQ` varchar(255) DEFAULT NULL,
  `average` varchar(255) DEFAULT NULL,
  `remarks` varchar(255) DEFAULT NULL,
  `term` varchar(255) DEFAULT NULL,
  `grade_level` varchar(255) NOT NULL,
  `section` varchar(255) NOT NULL,
  `strand` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `grading`
--

INSERT INTO `grading` (`id`, `IDNo`, `full_name`, `subject_code`, `subject_desc`, `units`, `1stQ`, `2ndQ`, `average`, `remarks`, `term`, `grade_level`, `section`, `strand`) VALUES
(32, '', 'Tiglao, Chzarinah Mae D ', 'ARTCON 11-2', 'Contemporary Philipine Arts from the Regions', '', '0', '0', '0', '', '1st Semester', '11', 'HERMES', 'ABM'),
(33, '', 'Tiglao, Chzarinah Mae D ', 'MIL 11-2', 'Media and Information Literacy', '', '0', '0', '0', '', '1st Semester', '11', 'HERMES', 'ABM'),
(34, '', 'Tiglao, Chzarinah Mae D ', 'FILI2 11-2', 'Pagbasa at Pagsusuri ng Ibat ibang Teksto  tungo sa pananaliksik', '', '0', '0', '0', '', '1st Semester', '11', 'HERMES', 'ABM'),
(35, '', 'Tiglao, Chzarinah Mae D ', 'PHYED2 11-2', 'Physical Educationand Health 2', '', '0', '0', '0', '', '1st Semester', '11', 'HERMES', 'ABM'),
(36, '', 'Tiglao, Chzarinah Mae D ', 'STATPRO 11-2', 'Statistics and Probability', '', '0', '0', '0', '', '1st Semester', '11', 'HERMES', 'ABM'),
(37, '', 'Tiglao, Chzarinah Mae D ', 'RESDAL 1', 'Research in Daily Life 1', '', '0', '0', '0', '', '1st Semester', '11', 'HERMES', 'ABM'),
(38, '', 'Tiglao, Chzarinah Mae D ', 'BUSMATH 11-2', 'Business Math', '', '0', '0', '0', '', '1st Semester', '11', 'HERMES', 'ABM'),
(39, '', 'Tiglao, Chzarinah Mae D ', 'ORGMAN 11-2', 'Organization and Management', '', '0', '0', '0', '', '1st Semester', '11', 'HERMES', 'ABM'),
(40, '', 'Tiglao, Chzarinah Mae D ', 'FABM1 11-2', 'Fundamentals of Accounting, Business and Management 1', '', '0', '0', '0', '', '1st Semester', '11', 'HERMES', 'ABM'),
(41, '', 'Pineda, Rickson Jessa', 'ARTCON 11-2', 'Contemporary Philipine Arts from the Regions', '', '0', '0', '0', '', '1st Semester', '11', 'TYCHE', 'TVL - ICT'),
(42, '', 'Pineda, Rickson Jessa', 'MIL 11-2', 'Media and Information Literacy', '', '0', '0', '0', '', '1st Semester', '11', 'TYCHE', 'TVL - ICT'),
(43, '', 'Pineda, Rickson Jessa', 'FILI2 11-2', 'Pagbasa at Pagsusuri ng Ibat ibang Teksto  tungo sa pananaliksik', '', '0', '0', '0', '', '1st Semester', '11', 'TYCHE', 'TVL - ICT'),
(44, '', 'Pineda, Rickson Jessa', 'PHYED2 11-2', 'Physical Educationand Health 2', '', '0', '0', '0', '', '1st Semester', '11', 'TYCHE', 'TVL - ICT'),
(45, '', 'Pineda, Rickson Jessa', 'STATPRO 11-2', 'Statistics and Probability', '', '0', '0', '0', '', '1st Semester', '11', 'TYCHE', 'TVL - ICT'),
(46, '', 'Pineda, Rickson Jessa', 'RESDAL 1', 'Research in Daily Life 1', '', '0', '0', '0', '', '1st Semester', '11', 'TYCHE', 'TVL - ICT'),
(47, '', 'Pineda, Rickson Jessa', 'JAVA1 11-2', 'Computer Programming NC II JAVA 1', '', '0', '0', '0', '', '1st Semester', '11', 'TYCHE', 'TVL - ICT'),
(48, '', 'Yusi, Edgren Flores', 'ARTCON 11-2', 'Contemporary Philipine Arts from the Regions', '', '0', '0', '0', '', '1st Semester', '11', 'APOLLO', 'TVL - ICT'),
(49, '', 'Yusi, Edgren Flores', 'MIL 11-2', 'Media and Information Literacy', '', '0', '0', '0', '', '1st Semester', '11', 'APOLLO', 'TVL - ICT'),
(50, '', 'Yusi, Edgren Flores', 'FILI2 11-2', 'Pagbasa at Pagsusuri ng Ibat ibang Teksto  tungo sa pananaliksik', '', '0', '0', '0', '', '1st Semester', '11', 'APOLLO', 'TVL - ICT'),
(51, '', 'Yusi, Edgren Flores', 'PHYED2 11-2', 'Physical Educationand Health 2', '', '0', '0', '0', '', '1st Semester', '11', 'APOLLO', 'TVL - ICT'),
(52, '', 'Yusi, Edgren Flores', 'STATPRO 11-2', 'Statistics and Probability', '', '0', '0', '0', '', '1st Semester', '11', 'APOLLO', 'TVL - ICT'),
(53, '', 'Yusi, Edgren Flores', 'RESDAL 1', 'Research in Daily Life 1', '', '0', '0', '0', '', '1st Semester', '11', 'APOLLO', 'TVL - ICT'),
(54, '', 'Yusi, Edgren Flores', 'JAVA1 11-2', 'Computer Programming NC II JAVA 1', '', '0', '0', '0', '', '1st Semester', '11', 'APOLLO', 'TVL - ICT'),
(55, '', 'Pineda, gdfgdfg gdfgdfg', 'ARTCON 11-2', 'Contemporary Philipine Arts from the Regions', '', '0', '0', '0', '', '1st Semester', '11', 'HERMES', 'HUMSS'),
(56, '', 'Pineda, gdfgdfg gdfgdfg', 'MIL 11-2', 'Media and Information Literacy', '', '0', '0', '0', '', '1st Semester', '11', 'HERMES', 'HUMSS'),
(57, '', 'Pineda, gdfgdfg gdfgdfg', 'FILI2 11-2', 'Pagbasa at Pagsusuri ng Ibat ibang Teksto  tungo sa pananaliksik', '', '0', '0', '0', '', '1st Semester', '11', 'HERMES', 'HUMSS'),
(58, '', 'Pineda, gdfgdfg gdfgdfg', 'PHYED2 11-2', 'Physical Educationand Health 2', '', '0', '0', '0', '', '1st Semester', '11', 'HERMES', 'HUMSS'),
(59, '', 'Pineda, gdfgdfg gdfgdfg', 'STATPRO 11-2', 'Statistics and Probability', '', '0', '0', '0', '', '1st Semester', '11', 'HERMES', 'HUMSS'),
(60, '', 'Pineda, gdfgdfg gdfgdfg', 'RESDAL 1', 'Research in Daily Life 1', '', '0', '0', '0', '', '1st Semester', '11', 'HERMES', 'HUMSS'),
(61, '', 'Pineda, gdfgdfg gdfgdfg', 'CRTV1 11-2', 'Creative Writing', '', '0', '0', '0', '', '1st Semester', '11', 'HERMES', 'HUMSS'),
(62, '', 'Pineda, gdfgdfg gdfgdfg', 'SOCSCI2 11-2', 'Introduction to World Religions and Belief Systems', '', '0', '0', '0', '', '1st Semester', '11', 'HERMES', 'HUMSS'),
(63, '', 'Pineda, gdfgdfg gdfgdfg', 'PHILGOV 11-2', 'Philippine Politics and Governance', '', '0', '0', '0', '', '1st Semester', '11', 'HERMES', 'HUMSS'),
(64, '', 'Pineda, gdfgdfg gdfgdfg', 'ARTCON 11-2', 'Contemporary Philipine Arts from the Regions', '', '0', '0', '0', '', '1st Semester', '11', '', 'HUMSS'),
(65, '', 'Pineda, gdfgdfg gdfgdfg', 'MIL 11-2', 'Media and Information Literacy', '', '0', '0', '0', '', '1st Semester', '11', '', 'HUMSS'),
(66, '', 'Pineda, gdfgdfg gdfgdfg', 'FILI2 11-2', 'Pagbasa at Pagsusuri ng Ibat ibang Teksto  tungo sa pananaliksik', '', '0', '0', '0', '', '1st Semester', '11', '', 'HUMSS'),
(67, '', 'Pineda, gdfgdfg gdfgdfg', 'PHYED2 11-2', 'Physical Educationand Health 2', '', '0', '0', '0', '', '1st Semester', '11', '', 'HUMSS'),
(68, '', 'Pineda, gdfgdfg gdfgdfg', 'STATPRO 11-2', 'Statistics and Probability', '', '0', '0', '0', '', '1st Semester', '11', '', 'HUMSS'),
(69, '', 'Pineda, gdfgdfg gdfgdfg', 'RESDAL 1', 'Research in Daily Life 1', '', '0', '0', '0', '', '1st Semester', '11', '', 'HUMSS'),
(70, '', 'Pineda, gdfgdfg gdfgdfg', 'CRTV1 11-2', 'Creative Writing', '', '0', '0', '0', '', '1st Semester', '11', '', 'HUMSS'),
(71, '', 'Pineda, gdfgdfg gdfgdfg', 'SOCSCI2 11-2', 'Introduction to World Religions and Belief Systems', '', '0', '0', '0', '', '1st Semester', '11', '', 'HUMSS'),
(72, '', 'Pineda, gdfgdfg gdfgdfg', 'PHILGOV 11-2', 'Philippine Politics and Governance', '', '0', '0', '0', '', '1st Semester', '11', '', 'HUMSS');

-- --------------------------------------------------------

--
-- Table structure for table `misc_fee`
--

CREATE TABLE `misc_fee` (
  `id` int(11) NOT NULL,
  `misc_fee_name` varchar(255) DEFAULT NULL,
  `misc_amount` decimal(7,2) DEFAULT '0.00'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `misc_fee`
--

INSERT INTO `misc_fee` (`id`, `misc_fee_name`, `misc_amount`) VALUES
(6, 'Reservation Fee\r\n', '1000.00'),
(7, 'Guidance Fee\r\n', '500.00'),
(8, 'Library Fee\r\n', '600.00'),
(9, 'Medical / Dental Fee\r\n', '500.00'),
(10, 'Audio-Visual Fee\r\n', '500.00'),
(11, 'Athletic/ Sports Fee\r\n', '300.00'),
(12, 'Insurance Fee\r\n', '100.00'),
(13, 'ID Fee\r\n', '150.00'),
(14, 'School Publication Fee\r\n', '200.00'),
(15, 'Handbook\r\n', '150.00');

-- --------------------------------------------------------

--
-- Table structure for table `other_fee`
--

CREATE TABLE `other_fee` (
  `id` int(11) NOT NULL,
  `other_fee_name` varchar(255) DEFAULT NULL,
  `other_fee_amount` double(7,2) DEFAULT '0.00',
  `strand` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `other_fee`
--

INSERT INTO `other_fee` (`id`, `other_fee_name`, `other_fee_amount`, `strand`) VALUES
(5, 'Computer Laboratory/ Internet Fee\r\n', 2500.00, 'Non-STEM'),
(6, 'Testing Materials\r\n', 500.00, 'Non-STEM'),
(7, 'Laboratory Fee (Chemistry & Physics)\r\n', 1000.00, 'STEM');

-- --------------------------------------------------------

--
-- Table structure for table `reservation`
--

CREATE TABLE `reservation` (
  `id` int(11) NOT NULL,
  `RegNo` varchar(255) DEFAULT NULL,
  `GOCNo` varchar(255) DEFAULT NULL,
  `Reservatio_for` varchar(255) DEFAULT NULL,
  `Days_valid` varchar(5) DEFAULT NULL,
  `Status` varchar(20) DEFAULT NULL,
  `Date_of_reserve` timestamp NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `room`
--

CREATE TABLE `room` (
  `id` int(11) NOT NULL,
  `room_name` varchar(255) DEFAULT NULL,
  `location` varchar(255) DEFAULT NULL,
  `capacity` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `schedule`
--

CREATE TABLE `schedule` (
  `id` int(11) NOT NULL,
  `time_start` varchar(255) DEFAULT NULL,
  `time_end` varchar(255) DEFAULT NULL,
  `subject_code` varchar(255) NOT NULL,
  `teacher_name` varchar(255) NOT NULL,
  `room` varchar(255) NOT NULL,
  `day_1` varchar(255) NOT NULL,
  `day_2` varchar(255) NOT NULL,
  `day_3` varchar(255) NOT NULL,
  `day_4` varchar(255) NOT NULL,
  `day_5` varchar(255) NOT NULL,
  `section` varchar(255) NOT NULL,
  `strand` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `schedule`
--

INSERT INTO `schedule` (`id`, `time_start`, `time_end`, `subject_code`, `teacher_name`, `room`, `day_1`, `day_2`, `day_3`, `day_4`, `day_5`, `section`, `strand`) VALUES
(3, '8:00:00 AM', '9:00:00 AM', 'HOME ROOM', 'Adviser', 'Room Hera', 'M', '', '', '', '', 'Hera', 'ABM'),
(4, '8:00:00 AM', '9:00:00 AM', 'BUSMATH 11-2', 'Mr. Sanguyo', 'Room Hera', '', 'T', '', '', '', 'Hera', 'ABM'),
(5, '8:00:00 AM', '9:00:00 AM', 'ARTCON 11-2', 'Mr. Legaspi', 'Room Hera', '', '', 'W', '', '', 'Hera', 'ABM'),
(6, '8:00:00 AM', '9:00:00 AM', 'FABM1 11-2', 'Ms. Bueno', 'Room Hera', '', '', '', 'TH', '', 'Hera', 'ABM'),
(7, '8:00:00 AM', '9:00:00 AM', 'FABM1 11-2', 'Ms. Bueno', 'Room Hera', '', '', '', '', 'F', 'Hera', 'ABM'),
(8, '9:00:00 AM', '10:00:00 AM', 'BUSMATH 11-2', 'Mr. Sanguyo', 'Room Hera', 'M', '', '', '', '', 'Hera', 'ABM'),
(9, '9:00:00 AM', '10:00:00 AM', 'FILI2 11-2', 'Ms. Saturno', 'Room Hera', '', 'T', '', '', '', 'Hera', 'ABM'),
(10, '9:00:00 AM', '10:00:00 AM', 'ORGMAN 11-2', 'Mr. Yaquiten', 'Room Hera', '', '', 'W', '', '', 'Hera', 'ABM'),
(11, '9:00:00 AM', '10:00:00 AM', 'BUSMATH 11-2', 'Mr. Sanguyo', 'Room Hera', '', '', '', 'TH', '', 'Hera', 'ABM'),
(12, '9:00:00 AM', '10:00:00 AM', 'MIL 11-2', 'Mr. Reyes', 'Room Hera', '', '', '', '', 'F', 'Hera', 'ABM'),
(13, '10:00:00 AM', '11:00:00 AM', 'RESEARCH', 'Ms. Garcia', 'Room Hera', 'M', '', '', '', '', 'Hera', 'ABM'),
(14, '10:00:00 AM', '11:00:00 AM', 'RESEARCH', 'Ms. Garcia', 'Room Hera', '', 'T', '', '', '', 'Hera', 'ABM'),
(15, '10:00:00 AM', '11:00:00 AM', 'MIL 11-2', 'Mr. Reyes', 'Room Hera', '', '', 'W', '', '', 'Hera', 'ABM'),
(16, '10:00:00 AM', '11:00:00 AM', 'ORGMAN 11-2', 'Mr. Yaquiten', 'Room Hera', '', '', '', 'TH', '', 'Hera', 'ABM'),
(17, '10:00:00 AM', '11:00:00 AM', 'PHYED2', 'Ms. Tiburcio', 'Room Hera', '', '', '', '', 'F', 'Hera', 'ABM'),
(18, '11:00:00 AM', '12:00:00 PM', 'LUNCH', '', '', 'M', 'T', 'W', 'TH', 'F', 'Hera', 'ABM'),
(19, '12:00:00 PM', '1:00:00 AM', 'ORGMAN 11-2', 'Mr. Yaquiten', 'Room Hera', 'M', '', '', '', '', 'Hera', 'ABM'),
(20, '12:00:00 PM', '1:00:00 AM', 'STATPRO 11-2', 'Ms. Calditaran', 'Room Hera', '', 'T', '', '', '', 'Hera', 'ABM'),
(21, '12:00:00 PM', '1:00:00 AM', 'STATPRO 11-2', 'Ms. Calditaran', 'Room Hera', '', '', 'W', '', '', 'Hera', 'ABM'),
(22, '12:00:00 PM', '1:00:00 AM', 'STATPRO 11-2', 'Ms. Calditaran', 'Room Hera', '', '', '', 'TH', '', 'Hera', 'ABM'),
(23, '12:00:00 PM', '1:00:00 AM', 'ARTCON 11-2', 'Mr. Legaspi', 'Room Hera', '', '', '', '', 'F', 'Hera', 'ABM'),
(24, '1:00:00 AM', '2:00:00 AM', 'FABM1 11-2', 'Ms. Bueno', 'Room Hera', 'M', '', '', '', '', 'Hera', 'ABM'),
(25, '1:00:00 AM', '2:00:00 AM', 'FABM1 11-2', 'Ms. Bueno', 'Room Hera', '', 'T', '', '', '', 'Hera', 'ABM'),
(26, '1:00:00 AM', '2:00:00 AM', 'BUSMATH 11-2', 'Mr. Sanguyo', 'Room Hera', '', '', 'W', '', '', 'Hera', 'ABM'),
(27, '1:00:00 AM', '2:00:00 AM', 'MIL 11-2', 'Mr. Reyes', 'Room Hera', '', '', '', 'TH', '', 'Hera', 'ABM'),
(28, '1:00:00 AM', '2:00:00 AM', 'STATPRO 11-2', 'Ms. Calditaran', 'Room Hera', '', '', '', '', 'F', 'Hera', 'ABM'),
(29, '2:00:00 AM', '2:30:00 AM', 'HEALTH BREAK', '', '', 'M', 'T', 'W', 'TH', 'F', 'Hera', 'ABM'),
(30, '2:30:00 PM', '3:30:00 PM', 'FABM1 11-2', 'Ms. Bueno', 'Room Hera', 'M', '', '', '', '', 'Hera', 'ABM'),
(31, '2:30:00 PM', '3:30:00 PM', 'FABM1 11-2', 'Ms. Bueno', 'Room Hera', '', 'T', '', '', '', 'Hera', 'ABM'),
(32, '2:30:00 PM', '3:30:00 PM', 'BUSMATH 11-2', 'Mr. Sanguyo', 'Room Hera', '', '', 'W', '', '', 'Hera', 'ABM'),
(33, '2:30:00 PM', '3:30:00 PM', 'MIL 11-2', 'Mr. Reyes', 'Room Hera', '', '', '', 'TH', '', 'Hera', 'ABM'),
(34, '2:30:00 PM', '3:30:00 PM', 'STATPRO 11-2', 'Ms. Calditaran', 'Room Hera', '', '', '', '', 'F', 'Hera', 'ABM'),
(35, '3:30:00 PM', '4:30:00 AM', 'FILI2 11-2', 'Ms. Saturno', 'Room Hera', 'M', '', '', '', '', 'Hera', 'ABM'),
(36, '3:30:00 PM', '4:30:00 AM', 'ORGMAN 11-2', 'ORGMAN 11-2', 'Room Hera', '', 'T', '', '', '', 'Hera', 'ABM'),
(37, '3:30:00 PM', '4:30:00 AM', '', '', 'Room Hera', '', '', 'W', '', '', 'Hera', 'ABM'),
(38, '3:30:00 PM', '4:30:00 AM', 'ARTCON 11-2', 'Mr. Legaspi', 'Room Hera', '', '', '', 'TH', '', 'Hera', 'ABM'),
(39, '3:30:00 PM', '4:30:00 AM', 'FILI2 11-2', 'Ms. Saturno', 'Room Hera', '', '', '', '', 'F', 'Hera', 'ABM');

-- --------------------------------------------------------

--
-- Table structure for table `schedule_main`
--

CREATE TABLE `schedule_main` (
  `id` int(11) NOT NULL,
  `time_start` varchar(255) NOT NULL,
  `time_end` varchar(255) NOT NULL,
  `day_1` varchar(255) NOT NULL,
  `day_2` varchar(255) NOT NULL,
  `day_3` varchar(255) NOT NULL,
  `day_4` varchar(255) NOT NULL,
  `day_5` varchar(255) NOT NULL,
  `section` varchar(255) NOT NULL,
  `counter` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `schedule_main`
--

INSERT INTO `schedule_main` (`id`, `time_start`, `time_end`, `day_1`, `day_2`, `day_3`, `day_4`, `day_5`, `section`, `counter`) VALUES
(3, '8:00:00 AM', '9:00:00 AM', 'HOME ROOM', 'BUSMATH 11-2', 'ARTCON 11-2', 'FABM1 11-2', 'FABM1 11-2', 'HERA', '1'),
(4, '9:00:00 AM', '10:00:00 AM', 'BUSMATH 11-2', 'FILI2 11-2', 'ORGMAN 11-2', 'BUSMATH 11-2', 'MIL 11-2', 'HERA', '2'),
(5, '10:00:00 AM', '11:00:00 AM', 'RESDAL 1', 'RESDAL 1', 'MIL 11-2', 'ORGMAN 11-2', 'PHYED2 11-2', 'HERA', '3'),
(6, '11:00:00 AM', '12:00:00 PM', 'LUNCH', 'LUNCH', 'LUNCH', 'LUNCH', 'LUNCH', 'HERA', '4'),
(7, '12:00:00 PM', '1:00:00 PM', 'ORGMAN 11-2', 'STATPRO 11-2', 'STATPRO 11-2', 'STATPRO 11-2', 'ARTCON 11-2', 'HERA', '5'),
(8, '1:00:00 PM', '2:00:00 PM', 'FABM1 11-2', 'FABM1 11-2', 'BUSMATH 11-2', 'MIL 11-2', 'STATPRO 11-2', 'HERA', '6'),
(9, '2:00:00 PM', '2:30:00 PM', 'BREAK', 'BREAK', 'BREAK', 'BREAK', 'BREAK', 'HERA', '7'),
(10, '2:30:00 PM', '3:30:00 PM', 'ARTCON 11-2', 'MIL 11-2', 'FILI2 11-2', 'RESDAL 1', 'RESDAL 1', 'HERA', '8'),
(11, '3:30:00 PM', '4:30:00 PM', 'FILI2 11-2', 'ORGMAN 11-2', 'CLUB', 'ARTCON 11-2', 'FILI2 11-2', 'HERA', '9'),
(21, '8:00:00 AM', '9:00:00 AM', 'HOME ROOM', 'FABM1 11-2', 'FABM1 11-2', 'ARTCON 11-2', 'BUSMATH 11-2', 'HERMES', '1'),
(22, '9:00:00 AM', '10:00:00 AM', 'BUSMATH 11-2', 'BUSMATH 11-2', 'BUSMATH 11-2', 'ORGMAN 11-2', 'FILI2 11-2', 'HERMES', '2'),
(23, '10:00:00 AM', '11:00:00 AM', 'RESDAL 1', 'ORGMAN 11-2', 'ORGMAN 11-2', 'MIL 11-2', 'RESDAL 1', 'HERMES', '3'),
(24, '11:00:00 AM', '12:00:00 PM', 'LUNCH', 'LUNCH', 'LUNCH', 'LUNCH', 'LUNCH', 'HERMES', '4'),
(25, '12:00:00 PM', '1:00:00 PM', 'ORGMAN 11-2', 'STATPRO 11-2', 'STATPRO 11-2', 'STATPRO 11-2', 'STATPRO 11-2', 'HERMES', '5'),
(26, '1:00:00 PM', '2:00:00 PM', 'FABM1 11-2', 'MIL 11-2', 'MIL 11-2', 'BUSMATH 11-2', 'FABM1 11-2', 'HERMES', '6'),
(27, '2:00:00 PM', '2:30:00 PM', 'BREAK', 'BREAK', 'BREAK', 'BREAK', 'BREAK', 'HERMES', '7'),
(28, '2:30:00 PM', '3:30:00 PM', 'ARTCON 11-2', 'RESDAL 1', 'RESDAL 1', 'FILI2 11-2', 'MIL 11-2', 'HERMES', '8'),
(29, '3:30:00 PM', '4:30:00 PM', 'FILI2 11-2', 'ARTCON 11-2', 'ARTCON 11-2', 'CLUB', 'ORGMAN 11-2', 'HERMES', '9'),
(30, '8:00:00 AM', '9:00:00 AM', 'HOME ROOM', 'FABM1 11-2', 'FABM1 11-2', 'ARTCON 11-2', 'BUSMATH 11-2', 'HESTIA', '1'),
(31, '9:00:00 AM', '10:00:00 AM', 'BUSMATH 11-2', 'BUSMATH 11-2', 'BUSMATH 11-2', 'ORGMAN 11-2', 'FILI2 11-2', 'HESTIA', '2'),
(32, '10:00:00 AM', '11:00:00 AM', 'RESDAL 1', 'ORGMAN 11-2', 'ORGMAN 11-2', 'MIL 11-2', 'RESDAL 1', 'HESTIA', '3'),
(33, '11:00:00 AM', '12:00:00 PM', 'LUNCH', 'LUNCH', 'LUNCH', 'LUNCH', 'LUNCH', 'HESTIA', '4'),
(34, '12:00:00 PM', '1:00:00 PM', 'ORGMAN 11-2', 'STATPRO 11-2', 'STATPRO 11-2', 'STATPRO 11-2', 'STATPRO 11-2', 'HESTIA', '5'),
(35, '1:00:00 PM', '2:00:00 PM', 'FABM1 11-2', 'MIL 11-2', 'MIL 11-2', 'BUSMATH 11-2', 'FABM1 11-2', 'HESTIA', '6'),
(36, '2:00:00 PM', '2:30:00 PM', 'BREAK', 'BREAK', 'BREAK', 'BREAK', 'BREAK', 'HESTIA', '7'),
(37, '2:30:00 PM', '3:30:00 PM', 'ARTCON 11-2', 'RESDAL 1', 'RESDAL 1', 'FILI2 11-2', 'MIL 11-2', 'HESTIA', '8'),
(38, '3:30:00 PM', '4:30:00 PM', 'FILI2 11-2', 'ARTCON 11-2', 'ARTCON 11-2', 'CLUB', 'ORGMAN 11-2', 'HESTIA', '9'),
(39, '8:00:00 AM', '9:00:00 AM', 'HOME ROOM', 'FABM1 11-2', 'FABM1 11-2', 'ARTCON 11-2', 'BUSMATH 11-2', 'HYPERION', '1'),
(40, '9:00:00 AM', '10:00:00 AM', 'BUSMATH 11-2', 'BUSMATH 11-2', 'BUSMATH 11-2', 'ORGMAN 11-2', 'FILI2 11-2', 'HYPERION', '2'),
(41, '10:00:00 AM', '11:00:00 AM', 'RESDAL 1', 'ORGMAN 11-2', 'ORGMAN 11-2', 'MIL 11-2', 'RESDAL 1', 'HYPERION', '3'),
(42, '11:00:00 AM', '12:00:00 PM', 'LUNCH', 'LUNCH', 'LUNCH', 'LUNCH', 'LUNCH', 'HYPERION', '4'),
(43, '12:00:00 PM', '1:00:00 PM', 'ORGMAN 11-2', 'STATPRO 11-2', 'STATPRO 11-2', 'STATPRO 11-2', 'STATPRO 11-2', 'HYPERION', '5'),
(44, '1:00:00 PM', '2:00:00 PM', 'FABM1 11-2', 'MIL 11-2', 'MIL 11-2', 'BUSMATH 11-2', 'FABM1 11-2', 'HYPERION', '6'),
(45, '2:00:00 PM', '2:30:00 PM', 'BREAK', 'BREAK', 'BREAK', 'BREAK', 'BREAK', 'HYPERION', '7'),
(46, '2:30:00 PM', '3:30:00 PM', 'ARTCON 11-2', 'RESDAL 1', 'RESDAL 1', 'FILI2 11-2', 'MIL 11-2', 'HYPERION', '8'),
(47, '3:30:00 PM', '4:30:00 PM', 'FILI2 11-2', 'ARTCON 11-2', 'ARTCON 11-2', 'CLUB', 'ORGMAN 11-2', 'HYPERION', '9'),
(48, '8:00:00 AM', '9:00:00 AM', 'HOME ROOM', 'FABM1 11-2', 'FABM1 11-2', 'ARTCON 11-2', 'BUSMATH 11-2', 'ZEUS', '1'),
(49, '9:00:00 AM', '10:00:00 AM', 'BUSMATH 11-2', 'BUSMATH 11-2', 'BUSMATH 11-2', 'ORGMAN 11-2', 'FILI2 11-2', 'ZEUS', '2'),
(50, '10:00:00 AM', '11:00:00 AM', 'RESDAL 1', 'ORGMAN 11-2', 'ORGMAN 11-2', 'MIL 11-2', 'RESDAL 1', 'ZEUS', '3'),
(51, '11:00:00 AM', '12:00:00 PM', 'LUNCH', 'LUNCH', 'LUNCH', 'LUNCH', 'LUNCH', 'ZEUS', '4'),
(52, '12:00:00 PM', '1:00:00 PM', 'ORGMAN 11-2', 'STATPRO 11-2', 'STATPRO 11-2', 'STATPRO 11-2', 'STATPRO 11-2', 'ZEUS', '5'),
(53, '1:00:00 PM', '2:00:00 PM', 'FABM1 11-2', 'MIL 11-2', 'MIL 11-2', 'BUSMATH 11-2', 'FABM1 11-2', 'ZEUS', '6'),
(54, '2:00:00 PM', '2:30:00 PM', 'BREAK', 'BREAK', 'BREAK', 'BREAK', 'BREAK', 'ZEUS', '7'),
(55, '2:30:00 PM', '3:30:00 PM', 'ARTCON 11-2', 'RESDAL 1', 'RESDAL 1', 'FILI2 11-2', 'MIL 11-2', 'ZEUS', '8'),
(56, '3:30:00 PM', '4:30:00 PM', 'FILI2 11-2', 'ARTCON 11-2', 'ARTCON 11-2', 'CLUB', 'ORGMAN 11-2', 'ZEUS', '9'),
(57, '8:00:00 AM', '9:00:00 AM', 'HOME ROOM', 'FABM1 11-2', 'FABM1 11-2', 'ARTCON 11-2', 'BUSMATH 11-2', 'TYCHE', '1'),
(58, '9:00:00 AM', '10:00:00 AM', 'BUSMATH 11-2', 'BUSMATH 11-2', 'BUSMATH 11-2', 'ORGMAN 11-2', 'FILI2 11-2', 'TYCHE', '2'),
(59, '10:00:00 AM', '11:00:00 AM', 'RESDAL 1', 'ORGMAN 11-2', 'ORGMAN 11-2', 'MIL 11-2', 'RESDAL 1', 'TYCHE', '3'),
(60, '11:00:00 AM', '12:00:00 PM', 'LUNCH', 'LUNCH', 'LUNCH', 'LUNCH', 'LUNCH', 'TYCHE', '4'),
(61, '12:00:00 PM', '1:00:00 PM', 'ORGMAN 11-2', 'STATPRO 11-2', 'STATPRO 11-2', 'STATPRO 11-2', 'STATPRO 11-2', 'TYCHE', '5'),
(62, '1:00:00 PM', '2:00:00 PM', 'FABM1 11-2', 'MIL 11-2', 'MIL 11-2', 'BUSMATH 11-2', 'FABM1 11-2', 'TYCHE', '6'),
(63, '2:00:00 PM', '2:30:00 PM', 'BREAK', 'BREAK', 'BREAK', 'BREAK', 'BREAK', 'TYCHE', '7'),
(64, '2:30:00 PM', '3:30:00 PM', 'ARTCON 11-2', 'RESDAL 1', 'RESDAL 1', 'FILI2 11-2', 'MIL 11-2', 'TYCHE', '8'),
(65, '3:30:00 PM', '4:30:00 PM', 'FILI2 11-2', 'ARTCON 11-2', 'ARTCON 11-2', 'CLUB', 'ORGMAN 11-2', 'TYCHE', '9');

-- --------------------------------------------------------

--
-- Table structure for table `school_year`
--

CREATE TABLE `school_year` (
  `id` int(11) NOT NULL,
  `year_start` int(11) DEFAULT NULL,
  `year_end` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `school_year`
--

INSERT INTO `school_year` (`id`, `year_start`, `year_end`) VALUES
(6, 2020, 2021);

-- --------------------------------------------------------

--
-- Table structure for table `section`
--

CREATE TABLE `section` (
  `id` int(11) NOT NULL,
  `section_name` varchar(255) DEFAULT NULL,
  `section_desc` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `section`
--

INSERT INTO `section` (`id`, `section_name`, `section_desc`) VALUES
(2, 'HESTIA', 'HESTIA'),
(3, 'ATHENA', 'ATHENA'),
(4, 'HERMES', 'HERMES'),
(5, 'ATLAS', 'ATLAS'),
(6, 'APOLLO', 'APOLLO'),
(7, 'TYCHE', 'TYCHE'),
(8, 'ODYSEUS', 'ODYSEUS'),
(9, 'ZEUS', 'ZEUS'),
(10, 'HERA', 'HERA'),
(11, 'HYPERION', 'HYPERION');

-- --------------------------------------------------------

--
-- Table structure for table `strand`
--

CREATE TABLE `strand` (
  `id` int(11) NOT NULL,
  `strand_name` varchar(255) DEFAULT NULL,
  `strand_desc` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `strand`
--

INSERT INTO `strand` (`id`, `strand_name`, `strand_desc`) VALUES
(6, 'STEM', 'Stem Desc'),
(7, 'ABM', 'ABM DESC'),
(8, 'HUMSS', 'HUMSS Desc'),
(9, 'TVL - HE', 'TVL Desc'),
(10, 'TVL - ICT', 'For ICT');

-- --------------------------------------------------------

--
-- Table structure for table `student_profile`
--

CREATE TABLE `student_profile` (
  `id` int(11) NOT NULL,
  `IDNo` varchar(225) DEFAULT NULL,
  `LRN` varchar(20) DEFAULT NULL,
  `regNo` varchar(25) DEFAULT NULL,
  `Reservee` varchar(5) DEFAULT '0',
  `Reserve_for` varchar(20) DEFAULT '0',
  `Full_payment` varchar(5) DEFAULT '0',
  `Partial_payment` varchar(5) DEFAULT '0',
  `photo_loc` varchar(225) DEFAULT NULL,
  `last_name` varchar(225) DEFAULT NULL,
  `first_name` varchar(225) DEFAULT NULL,
  `middle_name` varchar(225) DEFAULT NULL,
  `grade_Level` varchar(225) DEFAULT NULL,
  `section` varchar(255) NOT NULL,
  `track` varchar(225) DEFAULT NULL,
  `strand` varchar(225) DEFAULT NULL,
  `voucher_type` varchar(225) DEFAULT NULL,
  `address` varchar(225) DEFAULT NULL,
  `date_of_birth` varchar(225) DEFAULT NULL,
  `place_of_birth` varchar(225) DEFAULT NULL,
  `religion` varchar(225) DEFAULT NULL,
  `nationality` varchar(225) DEFAULT NULL,
  `gender` varchar(225) DEFAULT NULL,
  `stud_contactNo` varchar(225) DEFAULT NULL,
  `stud_telNo` varchar(225) DEFAULT NULL,
  `prev_school` varchar(225) DEFAULT NULL,
  `prev_school_address` varchar(225) DEFAULT NULL,
  `father_name` varchar(225) DEFAULT NULL,
  `father_work` varchar(225) DEFAULT NULL,
  `mother_name` varchar(225) DEFAULT NULL,
  `mother_work` varchar(225) DEFAULT NULL,
  `guardian_name` varchar(225) DEFAULT NULL,
  `guardian_work` varchar(225) DEFAULT NULL,
  `guardian_address` varchar(225) DEFAULT NULL,
  `guardian_relationship` varchar(225) DEFAULT NULL,
  `guardian_contactNo` varchar(225) DEFAULT NULL,
  `guardian_telNo` varchar(225) DEFAULT NULL,
  `bc` varchar(225) DEFAULT NULL,
  `form138` varchar(225) DEFAULT NULL,
  `drugtest` varchar(225) DEFAULT NULL,
  `good_moral` varchar(225) DEFAULT NULL,
  `en_exam` varchar(225) DEFAULT NULL,
  `ncae` varchar(225) DEFAULT NULL,
  `date_enrolled` varchar(225) DEFAULT NULL,
  `sy_enrolled` varchar(225) DEFAULT NULL,
  `1` varchar(225) NOT NULL,
  `2` varchar(225) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `student_profile`
--

INSERT INTO `student_profile` (`id`, `IDNo`, `LRN`, `regNo`, `Reservee`, `Reserve_for`, `Full_payment`, `Partial_payment`, `photo_loc`, `last_name`, `first_name`, `middle_name`, `grade_Level`, `section`, `track`, `strand`, `voucher_type`, `address`, `date_of_birth`, `place_of_birth`, `religion`, `nationality`, `gender`, `stud_contactNo`, `stud_telNo`, `prev_school`, `prev_school_address`, `father_name`, `father_work`, `mother_name`, `mother_work`, `guardian_name`, `guardian_work`, `guardian_address`, `guardian_relationship`, `guardian_contactNo`, `guardian_telNo`, `bc`, `form138`, `drugtest`, `good_moral`, `en_exam`, `ncae`, `date_enrolled`, `sy_enrolled`, `1`, `2`) VALUES
(1, '0', '106721070018', 'REG-2019-0001', '1', '11', '0', '0', NULL, 'CATAP', 'CHRISTLEYAN ', 'YALUNG', '11', '', 'ACADEMIC', 'ABM', 'Public Voucher', '  Sepung Calzada Tarlac City Tarlac', '2001-12-08', 'Tarlac', 'Christianity', 'Filipino', 'Male', '(0000) 000-0000', '(000) 000-0000', 'A', 'A', '', '', '', '', '', '', '   ', '', '(    )    -', '(   )    -', 'Birth Certificate', 'Form 138', 'Drug Test', 'Entrance Exam', 'NCAE Result', 'Good Moral', '2019-00-13', '2020 - 2021', '', ''),
(2, 'GOC-2019-0004', '106767070045', 'REG-2019-0002', '1', '11', '0', '0', NULL, 'CONCEPCION', 'JANBERT GREYLON', 'MERCADO', '11', '', 'ACADEMIC', 'ABM', 'Public Voucher', '  SAn vicente Tarlac City Tarlac', '2002-07-07', 'Tarlac', 'Christianity', 'Filipino', 'Male', '(0000) 000-0000', '(000) 000-0000', ' ', ' ', '', '', '', '', '', '', '   ', '', '(    )    -', '(   )    -', 'Birth Certificate', 'Form 138', 'Drug Test', 'Entrance Exam', 'NCAE Result', 'Good Moral', '2019-00-13', '2020 - 2021', '', ''),
(3, '0', '102545568889', 'REG-2019-0003', '1', '11', '0', '0', NULL, 'BONIFACIO', 'RHIANNE', 'LAGLAG', '11', '', 'ACADEMIC', 'STEM', 'Private Voucher', '141 San Jose Tarlac City Tarlac', '2019-03-09', 'Tarlac, Tarlac', 'Christianity', 'Filipino', 'Male', '(0000) 000-0000', '(000) 000-0000', ' ', ' ', '', '', '', '', '', '', '   ', '', '(    )    -', '(   )    -', 'Birth Certificate', 'Form 138', 'Drug Test', 'Entrance Exam', 'NCAE Result', 'Good Moral', '2019-00-09', '2020 - 2021', '', ''),
(4, '0', '124012154465', 'REG-2019-1002', '1', '11', '0', '0', NULL, 'SALVADOR', 'JEN', 'JULA', '11', '', 'ACADEMIC', 'HUMSS', 'Public Voucher', '52 Sta. Maria Casiguran  Aurora', '2000-03-09', 'Tarlac', 'Christianity', 'Filipino', 'Male', '(0925) 455-5454', '(095) 121-5454', 'SJ', 'SJ Tarlac', '', '', '', '', '', '', '   ', '', '(    )    -', '(   )    -', NULL, 'Form 138', 'Drug Test', NULL, NULL, NULL, '2019-00-09', '2020 - 2021', '', ''),
(5, 'GOC-2019-0005', '102245454545', 'REG-2019-0005', '1', '11', '0', '0', NULL, 'BALI', 'SEDRICK', 'J', '11', '', 'ACADEMIC', 'HUMSS', 'Public Voucher', '121 SAN JOSE Limay Bataan', '2001-03-14', 'TARLAC', 'Ba', 'Filipino', 'Male', '(    )    -', '(   )    -', '', '', '', '', '', '', '', '', '   ', '', '(    )    -', '(   )    -', NULL, 'Form 138', 'Drug Test', NULL, NULL, 'Good Moral', '2019-00-14', '2020 - 2021', '', ''),
(6, 'GOC-2019-0006', '105545432254', 'REG-2019-0006', '0', '11', '0', '0', NULL, 'RAMOS', 'ABEGAIL', 'MEDINA', '11', '', 'ACADEMIC', 'STEM', 'Public Voucher', '124 San Jose Gerona  Tarlac', '2002-03-14', 'Tarlac', 'Roman Catholic', 'Filipino', 'Female', '(0952) 645-5455', '(045) 226-5666', '', '', '', '', '', '', '', '', '   ', '', '(    )    -', '(   )    -', 'Birth Certificate', 'Form 138', NULL, NULL, NULL, 'Good Moral', '2019-00-14', '2020 - 2021', '', ''),
(7, 'GOC-2019-0007', '152002021546', 'REG-2019-0007', '0', '11', NULL, NULL, NULL, 'BASILIO', 'ZANDY', 'GARCIA', '11', '', 'ACADEMIC', 'HUMSS', 'Public Voucher', '154 San Isidro Tarlac City Tarlac', '2000-03-26', 'Angono, Rizal', 'Baptist', 'Filipino', 'Male', '(0956) 656-5656', '(045) 221-2121', 'SJNH', 'San Jose Gerona, Tarlac', '', '', '', '', '', '', '   ', '', '(    )    -', '(   )    -', 'Birth Certificate', 'Form 138', NULL, NULL, NULL, NULL, '2019-00-14', '2020 - 2021', '', ''),
(8, 'GOC-2019-0008', '120545468498', 'REG-2019-0008', '0', '11', NULL, NULL, NULL, 'AQUINO', 'EMMANUEL', 'ROXAS', '11', '', 'ACADEMIC', 'HUMSS', 'Public Voucher', '1 Suizo Tarlac City Tarlac', '2001-06-09', 'Tarlac', 'Christianity', 'Filipino', 'Male', '(0965) 656-5652', '(054) 464-6464', 'Amucao', 'amucao', '', '', '', '', '', '', '   ', '', '(    )    -', '(   )    -', 'Birth Certificate', 'Form 138', NULL, NULL, NULL, NULL, '2019-00-14', '2020 - 2021', '', ''),
(9, 'GOC-2019-0014', '452226987989', 'REG-2019-0009', '0', '11', NULL, NULL, NULL, 'VALDEZ', 'ANGEL', 'SANTOS', '11', '', 'ACADEMIC', 'HUMSS', 'Public Voucher', '555 San juan Baler Aurora', '2000-03-14', 'Aurora', 'BP', 'Filipino', 'Male', '(0555) 555-4546', '(054) 654-6546', '', '', '', '', '', '', '', '', '   ', '', '(    )    -', '(   )    -', 'Birth Certificate', NULL, NULL, NULL, NULL, NULL, '2019-00-14', '2020 - 2021', '', '');

-- --------------------------------------------------------

--
-- Table structure for table `stud_registration`
--

CREATE TABLE `stud_registration` (
  `id` int(11) NOT NULL,
  `stud_LRN` varchar(255) DEFAULT NULL,
  `stud_regNo` varchar(255) DEFAULT NULL,
  `stud_GOCNo` varchar(255) DEFAULT NULL,
  `stud_lastName` varchar(255) DEFAULT NULL,
  `stud_firstName` varchar(255) DEFAULT NULL,
  `stud_middleName` varchar(255) DEFAULT NULL,
  `stud_grade_level` varchar(255) DEFAULT NULL,
  `stud_type` varchar(255) DEFAULT NULL,
  `stud_course` varchar(255) DEFAULT NULL,
  `stud_strand` varchar(255) DEFAULT NULL,
  `stud_acad_track` varchar(255) DEFAULT NULL,
  `stud_date_of_birth` varchar(255) DEFAULT NULL,
  `stud_gender` varchar(255) DEFAULT NULL,
  `stud_birth_place` varchar(255) DEFAULT NULL,
  `stud_address1` varchar(255) DEFAULT NULL,
  `req_BC` varchar(255) DEFAULT NULL,
  `req_form138` varchar(255) DEFAULT NULL,
  `req_drug_test` varchar(255) DEFAULT NULL,
  `req_entrance_exam` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `stud_registration`
--

INSERT INTO `stud_registration` (`id`, `stud_LRN`, `stud_regNo`, `stud_GOCNo`, `stud_lastName`, `stud_firstName`, `stud_middleName`, `stud_grade_level`, `stud_type`, `stud_course`, `stud_strand`, `stud_acad_track`, `stud_date_of_birth`, `stud_gender`, `stud_birth_place`, `stud_address1`, `req_BC`, `req_form138`, `req_drug_test`, `req_entrance_exam`) VALUES
(17, '102565489895', 'REG-2019-0017', NULL, 'Yusi', 'Edgren', 'Flores', '11', 'New Student', NULL, 'TVL - ICT', 'TECH-VOC', '1991-08-15', 'Male', 'Tarlac', '1252 Mabuhay St. LSFM Concepcion  Tarlac', 'Birth Certificate', 'Form 138', NULL, NULL),
(18, '102222255566', 'REG-2019-0018', NULL, 'Pineda', 'Rickson', 'Jessa', '11', 'New Student', NULL, 'TVL - ICT', 'TECH-VOC', '2019-02-28', 'Male', 'Tarlac', '121 Maligaya San Jose Tarlac City Tarlac', 'Birth Certificate', NULL, 'Drug Test', NULL),
(19, '106704070110', 'REG-2019-0019', NULL, 'Tiglao', 'Chzarinah Mae', 'D ', '11', 'New Student', NULL, 'ABM', 'ACADEMIC', '2019-02-28', 'Female', 'Tarlac City', '1380 Zone 4  Maliwalo Tarlac City Tarlac', 'Birth Certificate', NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `subject`
--

CREATE TABLE `subject` (
  `id` int(11) NOT NULL,
  `subject_code` varchar(255) DEFAULT NULL,
  `subject_desc` varchar(255) DEFAULT NULL,
  `semester` varchar(10) NOT NULL,
  `grade_level` varchar(10) NOT NULL,
  `subject_type` varchar(255) NOT NULL,
  `strand` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `subject`
--

INSERT INTO `subject` (`id`, `subject_code`, `subject_desc`, `semester`, `grade_level`, `subject_type`, `strand`) VALUES
(367, 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', 'First', '11', 'CORE SUBJECTS', 'All Strand'),
(368, 'EARTHSCI 11-1', 'Earth Science', 'First', '11', 'CORE SUBJECTS', 'All Strand'),
(369, 'GENMATH 11-1', 'General Mathematics', 'First', '11', 'CORE SUBJECTS', 'All Strand'),
(370, 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', 'First', '11', 'CORE SUBJECTS', 'All Strand'),
(371, 'ORALCOM 11-1', 'Oral Communication in Context', 'First', '11', 'CORE SUBJECTS', 'All Strand'),
(372, 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', 'First', '11', 'CORE SUBJECTS', 'All Strand'),
(373, 'PHYED1 11-1', 'Physical Education and Health 1', 'First', '11', 'CORE SUBJECTS', 'All Strand'),
(374, 'ARTCON 11-2', 'Contemporary Philipine Arts from the Regions', 'Second', '11', 'APPLIED SUBJECTS', 'All Strand'),
(375, 'MIL 11-2', 'Media and Information Literacy', 'Second', '11', 'APPLIED SUBJECTS', 'All Strand'),
(376, 'FILI2 11-2', 'Pagbasa at Pagsusuri ng Ibat ibang Teksto  tungo sa pananaliksik', 'Second', '11', 'APPLIED SUBJECTS', 'All Strand'),
(377, 'PHYED2 11-2', 'Physical Educationand Health 2', 'Second', '11', 'APPLIED SUBJECTS', 'All Strand'),
(378, 'STATPRO 11-2', 'Statistics and Probability', 'Second', '11', 'APPLIED SUBJECTS', 'All Strand'),
(379, 'SOCSCI1 12-1', 'Understanding Culture, Society and Politics', 'First', '12', 'CORE SUBJECTS', 'All Strand'),
(380, 'PHILMAN 12 -1', 'Introduction to the Philisophy of Human Person', 'First', '12', 'CORE SUBJECTS', 'All Strand'),
(381, 'RWSKILL 12-1', 'Reading and Writing Skills', 'First', '12', 'CORE SUBJECTS', 'All Strand'),
(382, 'PHYED3 12-1', 'Physical Education and Health 3', 'First', '12', 'CORE SUBJECTS', 'All Strand'),
(383, 'PHYSCI 12-2', 'Physical Science', 'Second', '12', 'CORE SUBJECTS', 'NON STEM'),
(384, 'DRR 12-2', 'Disaster Readiness and Risk Reduction', 'Second', '12', 'CORE SUBJECTS', 'STEM'),
(385, 'PHYED4 12-2', 'Physical Educationand Health 4', 'Second', '12', 'CORE SUBJECTS', 'STEM'),
(386, 'BUSMATH 11-2', 'Business Math', 'Second', '11', 'SPECIALIZED SUBJECTS', 'ABM'),
(387, 'ORGMAN 11-2', 'Organization and Management', 'Second', '11', 'SPECIALIZED SUBJECTS', 'ABM'),
(388, 'FABM1 11-2', 'Fundamentals of Accounting, Business and Management 1', 'Second', '11', 'SPECIALIZED SUBJECTS', 'ABM'),
(389, 'FABM2 12-1', 'Fundamentals of Accounting, Business and Management 2', 'First', '12', 'SPECIALIZED SUBJECTS', 'ABM'),
(390, 'PRINBM 12-1', 'Principles of Business Marketing', 'First', '12', 'SPECIALIZED SUBJECTS', 'ABM'),
(391, 'BUSFIN 12-1', 'Business Finance', 'First', '12', 'SPECIALIZED SUBJECTS', 'ABM'),
(392, 'APPECO 12-2', 'Applied Economics', 'Second', '12', 'SPECIALIZED SUBJECTS', 'ABM'),
(393, 'ETBUS 12-2', 'Business Ethics and Social Responsibility', 'Second', '12', 'SPECIALIZED SUBJECTS', 'ABM'),
(394, 'ENTBUS 12-2', 'Business Enterprise Simulation', 'Second', '12', 'SPECIALIZED SUBJECTS', 'ABM'),
(395, 'CRTV1 11-2', 'Creative Writing', 'Second', '11', 'SPECIALIZED SUBJECTS', 'HUMSS'),
(396, 'SOCSCI2 11-2', 'Introduction to World Religions and Belief Systems', 'Second', '11', 'SPECIALIZED SUBJECTS', 'HUMSS'),
(397, 'PHILGOV 11-2', 'Philippine Politics and Governance', 'Second', '11', 'SPECIALIZED SUBJECTS', 'HUMSS'),
(398, 'CRTV2 12-1', 'Creative Non Fiction', 'First', '12', 'SPECIALIZED SUBJECTS', 'HUMSS'),
(399, 'TNCT 12-1', 'Trends, Networks and Critical Thinking in the 21st Century Culture', 'First', '12', 'SPECIALIZED SUBJECTS', 'HUMSS'),
(400, 'SOCSCI3 12-1', 'Disciplines and Ideas in the Social Sciences', 'First', '12', 'SPECIALIZED SUBJECTS', 'HUMSS'),
(401, 'CESC 12-2', 'Community Engagement, Solidarity and Citizenship', 'Second', '12', 'SPECIALIZED SUBJECTS', 'HUMSS'),
(402, 'SOCSCI4 12-2', 'Disciplines and Ideas in the Applied Social Sciences', 'Second', '12', 'SPECIALIZED SUBJECTS', 'HUMSS'),
(403, 'CULACT 12-2', 'Culminating Activity', 'Second', '12', 'SPECIALIZED SUBJECTS', 'HUMSS'),
(404, 'JAVA1 11-2', 'Computer Programming NC II JAVA 1', 'Second', '11', 'SPECIALIZED SUBJECTS', 'TVL - ICT'),
(405, 'JAVA2 12-1', 'Computer Programming NC II JAVA 2', 'First', '12', 'SPECIALIZED SUBJECTS', 'TVL - ICT'),
(406, 'ANICOM1 12-1', 'Animation NC II 1', 'First', '12', 'SPECIALIZED SUBJECTS', 'TVL - ICT'),
(407, 'ANICOM2 12-2', 'Animation NC II 2', 'Second', '12', 'SPECIALIZED SUBJECTS', 'TVL - ICT'),
(408, 'STUDCOM 12-2', 'Computer Subjects', 'Second', '12', 'SPECIALIZED SUBJECTS', 'TVL - ICT'),
(409, 'COOK1 11-2', 'Cookery 1', 'Second', '11', 'SPECIALIZED SUBJECTS', 'TVL - HE'),
(410, 'COOK2 12-1', 'Cookery 2', 'First', '12', 'SPECIALIZED SUBJECTS', 'TVL - HE'),
(411, 'BRPROD1 12-1', 'Bread and Pastry Production 1', 'First', '12', 'SPECIALIZED SUBJECTS', 'TVL - HE'),
(412, 'BRPROD12-2', 'Bread and Pastry Production 2', 'Second', '12', 'SPECIALIZED SUBJECTS', 'TVL - HE'),
(413, 'WORKIMM 12-2', 'Work Immersion', 'Second', '12', 'SPECIALIZED SUBJECTS', 'TVL - HE'),
(414, 'GENBIO1 11-2', 'General Biology 1', 'Second', '11', 'SPECIALIZED SUBJECTS', 'STEM'),
(415, 'GENCHEM1 11-2', 'General Chemistry 1', 'Second', '11', 'SPECIALIZED SUBJECTS', 'STEM'),
(416, 'PRECALC 11-2', 'Pre Calculus', 'Second', '11', 'SPECIALIZED SUBJECTS', 'STEM'),
(417, 'BASCALC 12-1', 'Basic Calculus', 'First', '12', 'SPECIALIZED SUBJECTS', 'STEM'),
(418, 'GENPHYS1 12-1', 'General Physics 1', 'First', '12', 'SPECIALIZED SUBJECTS', 'STEM'),
(419, 'GENCHEM2 12-1', 'General Chemistry 2', 'First', '12', 'SPECIALIZED SUBJECTS', 'STEM'),
(420, 'GENBIO2 12-2', 'General Biology 2', 'Second', '12', 'SPECIALIZED SUBJECTS', 'STEM'),
(421, 'GENPHYS2 12-2', 'General Physics 2', 'Second', '12', 'SPECIALIZED SUBJECTS', 'STEM'),
(422, 'CAPPROJ 12-2', 'Research / Capstone Project', 'Second', '12', 'SPECIALIZED SUBJECTS', 'STEM'),
(423, 'RESDAL 2', 'Research in Daily Life 2', 'First', '12', 'APPLIED SUBJECTS', 'All Strand'),
(424, 'RESDAL 1', 'Research in Daily Life 1', 'Second', '11', 'APPLIED SUBJECTS', 'All Strand'),
(425, 'EMTECH 11-1', 'Empowerment Technologies', 'First', '11', 'APPLIED SUBJECTS', 'All Strand'),
(426, 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', 'First', '11', 'APPLIED SUBJECTS', 'All Strand');

-- --------------------------------------------------------

--
-- Table structure for table `teacher`
--

CREATE TABLE `teacher` (
  `id` int(11) NOT NULL,
  `employeeNo` int(11) NOT NULL,
  `teacher_fname` varchar(255) DEFAULT NULL,
  `teacher_lname` varchar(255) DEFAULT NULL,
  `teacher_mname` varchar(255) DEFAULT NULL,
  `specialization` varchar(255) DEFAULT NULL,
  `adviser_of` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tuition_fee`
--

CREATE TABLE `tuition_fee` (
  `id` int(11) NOT NULL,
  `tuition_fee_name` varchar(255) DEFAULT NULL,
  `tuition_amount` decimal(7,2) DEFAULT '0.00',
  `tuition_desc` varchar(255) NOT NULL,
  `status` varchar(255) NOT NULL,
  `Department` varchar(255) NOT NULL,
  `Reservation-Fee` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tuition_fee`
--

INSERT INTO `tuition_fee` (`id`, `tuition_fee_name`, `tuition_amount`, `tuition_desc`, `status`, `Department`, `Reservation-Fee`) VALUES
(13, 'SHS - Tuition Fee', '21000.00', 'For SHS Student Only', '1', 'SHS', '1000'),
(14, 'COLLEGE - Tuition Fee', '25000.00', 'For NON STEM Students', '0', 'COLLEGE', '1000');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(255) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `user_type` varchar(255) DEFAULT NULL,
  `LastName` varchar(255) DEFAULT NULL,
  `FirstName` varchar(255) DEFAULT NULL,
  `MiddelName` varchar(255) DEFAULT NULL,
  `Emp_ID` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `username`, `password`, `user_type`, `LastName`, `FirstName`, `MiddelName`, `Emp_ID`) VALUES
(6, 'admin', 'admin123', 'Admin', 'Basilio', 'Efraim', 'G.', '001'),
(7, 'registrar', 'registrar123', 'Registrar', 'Vargas', 'Lucia', '', '002'),
(8, 'cashier', 'cashier123', 'Cashier', 'Pineda', 'Rickson', '', '003');

-- --------------------------------------------------------

--
-- Table structure for table `voucher`
--

CREATE TABLE `voucher` (
  `id` int(11) NOT NULL,
  `voucher_from` varchar(255) DEFAULT NULL,
  `voucher_amount` double(7,2) DEFAULT '0.00',
  `DP_Amount` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `voucher`
--

INSERT INTO `voucher` (`id`, `voucher_from`, `voucher_amount`, `DP_Amount`) VALUES
(3, 'Public Voucher', 17500.00, '3000'),
(4, 'Private Voucher', 14000.00, '3000'),
(5, 'Non - Voucher', 0.00, '10000.00');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `billing_or`
--
ALTER TABLE `billing_or`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `billing_partial`
--
ALTER TABLE `billing_partial`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `department`
--
ALTER TABLE `department`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `discount`
--
ALTER TABLE `discount`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `discount_name` (`discount_name`);

--
-- Indexes for table `enrollled_students`
--
ALTER TABLE `enrollled_students`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `grading`
--
ALTER TABLE `grading`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `misc_fee`
--
ALTER TABLE `misc_fee`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `misc_fee_name` (`misc_fee_name`);

--
-- Indexes for table `other_fee`
--
ALTER TABLE `other_fee`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `other_fee_name` (`other_fee_name`);

--
-- Indexes for table `reservation`
--
ALTER TABLE `reservation`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `room`
--
ALTER TABLE `room`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `room_name` (`room_name`);

--
-- Indexes for table `schedule`
--
ALTER TABLE `schedule`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `schedule_main`
--
ALTER TABLE `schedule_main`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `school_year`
--
ALTER TABLE `school_year`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `year_start` (`year_start`,`year_end`);

--
-- Indexes for table `section`
--
ALTER TABLE `section`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `section_name` (`section_name`);

--
-- Indexes for table `strand`
--
ALTER TABLE `strand`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `strand_name` (`strand_name`);

--
-- Indexes for table `student_profile`
--
ALTER TABLE `student_profile`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `stud_registration`
--
ALTER TABLE `stud_registration`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `subject`
--
ALTER TABLE `subject`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `teacher`
--
ALTER TABLE `teacher`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `employeeNo` (`employeeNo`);

--
-- Indexes for table `tuition_fee`
--
ALTER TABLE `tuition_fee`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `tuition_fee_name` (`tuition_fee_name`),
  ADD UNIQUE KEY `tuition_fee_name_2` (`tuition_fee_name`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `username` (`username`);

--
-- Indexes for table `voucher`
--
ALTER TABLE `voucher`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `voucher_from` (`voucher_from`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `billing_or`
--
ALTER TABLE `billing_or`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=34;

--
-- AUTO_INCREMENT for table `billing_partial`
--
ALTER TABLE `billing_partial`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `department`
--
ALTER TABLE `department`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `discount`
--
ALTER TABLE `discount`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `enrollled_students`
--
ALTER TABLE `enrollled_students`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `grading`
--
ALTER TABLE `grading`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=73;

--
-- AUTO_INCREMENT for table `misc_fee`
--
ALTER TABLE `misc_fee`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `other_fee`
--
ALTER TABLE `other_fee`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `reservation`
--
ALTER TABLE `reservation`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `room`
--
ALTER TABLE `room`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `schedule`
--
ALTER TABLE `schedule`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=40;

--
-- AUTO_INCREMENT for table `schedule_main`
--
ALTER TABLE `schedule_main`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=66;

--
-- AUTO_INCREMENT for table `school_year`
--
ALTER TABLE `school_year`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `section`
--
ALTER TABLE `section`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `strand`
--
ALTER TABLE `strand`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `student_profile`
--
ALTER TABLE `student_profile`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `stud_registration`
--
ALTER TABLE `stud_registration`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT for table `subject`
--
ALTER TABLE `subject`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=427;

--
-- AUTO_INCREMENT for table `teacher`
--
ALTER TABLE `teacher`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tuition_fee`
--
ALTER TABLE `tuition_fee`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `voucher`
--
ALTER TABLE `voucher`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
