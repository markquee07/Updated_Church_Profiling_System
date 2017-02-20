-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Feb 20, 2017 at 06:32 AM
-- Server version: 10.1.19-MariaDB
-- PHP Version: 7.0.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `church_profiling_monitoring`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_amount`
--

CREATE TABLE `tbl_amount` (
  `monthly_fee` double NOT NULL,
  `Fines` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_amount`
--

INSERT INTO `tbl_amount` (`monthly_fee`, `Fines`) VALUES
(10, 50);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_attendance`
--

CREATE TABLE `tbl_attendance` (
  `Member_id` int(10) UNSIGNED NOT NULL,
  `Activity_type` varchar(45) NOT NULL,
  `meeting_Date` date NOT NULL,
  `Meeting_time` time NOT NULL,
  `Status` varchar(10) NOT NULL,
  `Description` varchar(45) NOT NULL,
  `id` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_attendance`
--

INSERT INTO `tbl_attendance` (`Member_id`, `Activity_type`, `meeting_Date`, `Meeting_time`, `Status`, `Description`, `id`) VALUES
(130, 'BURIAL MEETING', '2017-02-19', '03:25:00', 'Present', 'DEATH OF SABA', 1),
(135, 'BURIAL MEETING', '2017-02-19', '03:25:00', 'Present', 'DEATH OF SABA', 2),
(141, 'BURIAL MEETING', '2017-02-19', '03:25:00', 'Present', 'DEATH OF SABA', 3),
(140, 'BURIAL MEETING', '2017-02-19', '03:25:00', 'Present', 'DEATH OF SABA', 4),
(144, 'BURIAL MEETING', '2017-02-19', '03:25:00', 'Present', 'DEATH OF SABA', 5),
(130, 'CHURCH MEETING', '2017-02-19', '02:20:00', 'Present', 'KAON NATA HAMZ', 6),
(131, 'CHURCH MEETING', '2017-02-19', '02:20:00', 'Present', 'KAON NATA HAMZ', 7),
(132, 'CHURCH MEETING', '2017-02-19', '02:20:00', 'Present', 'KAON NATA HAMZ', 8),
(133, 'CHURCH MEETING', '2017-02-19', '02:20:00', 'Present', 'KAON NATA HAMZ', 9),
(139, 'BURIAL MEETING', '2017-02-19', '05:25:00', 'Present', 'TEST ATTENDANCE', 10),
(140, 'BURIAL MEETING', '2017-02-19', '05:25:00', 'Present', 'TEST ATTENDANCE', 11),
(141, 'BURIAL MEETING', '2017-02-19', '05:25:00', 'Present', 'TEST ATTENDANCE', 12);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_burialofficial`
--

CREATE TABLE `tbl_burialofficial` (
  `member_id` int(10) UNSIGNED NOT NULL,
  `Position` varchar(45) NOT NULL,
  `Year` varchar(45) NOT NULL,
  `Status` varchar(45) NOT NULL,
  `image_path` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_burialofficial`
--

INSERT INTO `tbl_burialofficial` (`member_id`, `Position`, `Year`, `Status`, `image_path`) VALUES
(130, 'PRESIDENT', '2018', 'INACTIVE', 'none'),
(131, 'VICE-PRESIDENT', '2018', 'INACTIVE', 'none'),
(133, 'TREASURER', '2018', 'INACTIVE', 'none'),
(134, 'SECRETARY', '2018', 'INACTIVE', 'none'),
(135, 'PRESIDENT', '2018', 'INACTIVE', 'none'),
(136, 'VICE-PRESIDENT', '2018', 'INACTIVE', 'none'),
(137, 'TREASURER', '2018', 'INACTIVE', 'none'),
(138, 'SECRETARY', '2018', 'INACTIVE', 'none'),
(130, 'PRESIDENT', '2021', 'INACTIVE', 'none'),
(131, 'VICE-PRESIDENT', '2021', 'INACTIVE', 'none'),
(133, 'TREASURER', '2021', 'INACTIVE', 'none'),
(134, 'SECRETARY', '2021', 'INACTIVE', 'none'),
(130, 'PRESIDENT', '2022', 'INACTIVE', 'none'),
(131, 'VICE-PRESIDENT', '2022', 'INACTIVE', 'none'),
(133, 'TREASURER', '2022', 'INACTIVE', 'none'),
(134, 'SECRETARY', '2022', 'INACTIVE', 'none'),
(131, 'PRESIDENT', '87654', 'ACTIVE', 'none'),
(135, 'VICE-PRESIDENT', '87654', 'ACTIVE', 'none'),
(134, 'TREASURER', '87654', 'ACTIVE', 'none'),
(130, 'SECRETARY', '87654', 'ACTIVE', 'none');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_child_information`
--

CREATE TABLE `tbl_child_information` (
  `id` int(10) UNSIGNED NOT NULL,
  `Child_id` varchar(8) NOT NULL,
  `Gender` varchar(6) NOT NULL,
  `Birth_date` datetime NOT NULL,
  `First_name` varchar(45) NOT NULL,
  `Last_name` varchar(45) NOT NULL,
  `Middle_name` varchar(45) NOT NULL,
  `status` varchar(45) NOT NULL,
  `image` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_child_information`
--

INSERT INTO `tbl_child_information` (`id`, `Child_id`, `Gender`, `Birth_date`, `First_name`, `Last_name`, `Middle_name`, `status`, `image`) VALUES
(26, 'OHUTP249', 'FEMALE', '0000-00-00 00:00:00', 'yeah-yeah', 'yeah', 'yeah', 'ACTIVE', 'yeah-yeah_OHUTP2490.jpg'),
(27, 'OHUTP249', 'FEMALE', '0000-00-00 00:00:00', 'jean', 'may', '', 'ACTIVE', 'jean_OHUTP249.jpg'),
(28, 'OHUTP249', 'FEMALE', '0000-00-00 00:00:00', 'child1', 'child1', 'child1', 'ACTIVE', 'child1_OHUTP249.jpg'),
(29, 'OHUTP249', 'MALE', '2017-02-23 00:00:00', 'childtest2', 'childtest2', '', 'ACTIVE', 'childtest2_OHUTP249.jpg'),
(30, 'OHUTP249', 'MALE', '2017-02-23 00:00:00', 'childtest2', 'childtest2', '', 'ACTIVE', 'childtest2_OHUTP249.jpg'),
(31, 'OHUTP249', 'MALE', '2016-02-18 00:00:00', 'm', 'm', 'm', 'ACTIVE', 'm_OHUTP249.jpg'),
(32, 'OHUTP249', 'FEMALE', '2017-02-23 00:00:00', 'four', 'four', 'frou', 'ACTIVE', 'four_OHUTP249.jpg'),
(33, 'X0F1Q69E', 'MALE', '2017-02-17 00:00:00', 'TestAgain', 'TestAgain', 'TestAgain', 'ACTIVE', 'TestAgain_X0F1Q69EH.jpg'),
(34, 'GDLXN7EC', 'FEMALE', '2016-02-19 00:00:00', 'l', 'l', 'l', 'ACTIVE', 'l_GDLXN7ECB.jpg'),
(35, '8C0IMZTC', 'MALE', '2015-02-19 00:00:00', 'k', 'k', 'k', 'ACTIVE', 'k_8C0IMZTCH.jpg'),
(36, 'T07P3VQU', 'FEMALE', '2016-02-19 00:00:00', 'j', 'j', 'j', 'ACTIVE', 'j_T07P3VQU7.jpg'),
(37, 'B0UKYV81', 'FEMALE', '2017-02-24 00:00:00', 'duh', 'duh', '', 'ACTIVE', 'duh_B0UKYV81O.jpg'),
(38, 'IH8STG3Y', 'FEMALE', '2017-02-11 00:00:00', 'j', 'j', 'j', 'ACTIVE', 'j_IH8STG3YI.jpg'),
(39, 'F0NOX2MR', 'MALE', '2016-02-19 00:00:00', 'k', 'k', 'k', 'ACTIVE', 'k_F0NOX2MRM.jpg'),
(40, '1KF82JG4', 'FEMALE', '2017-03-02 00:00:00', 'p', 'p', 'p', 'ACTIVE', 'p_1KF82JG4S.jpg'),
(41, '6XG56TCW', 'MALE', '2016-02-19 00:00:00', 'l', 'l', 'l', 'ACTIVE', 'l_6XG56TCWE.jpg'),
(42, '5R6YHJ4C', 'MALE', '2016-02-19 00:00:00', 'i', 'i', 'i', 'ACTIVE', 'i_5R6YHJ4C5.jpg'),
(43, 'OHUTP249', 'MALE', '2017-02-19 00:00:00', 'eunice', 'lepana', 'yeah', 'ACTIVE', 'eunice_OHUTP249.jpg'),
(44, 'OHUTP249', 'FEMALE', '2017-02-03 00:00:00', 'kami', 'kami', 'kami', 'ACTIVE', 'kami_OHUTP249.jpg'),
(45, 'OHUTP249', 'FEMALE', '2013-02-19 00:00:00', 'anaks', 'anaks', 'anaks', 'ACTIVE', 'anaks_OHUTP249.jpg'),
(46, '', 'FEMALE', '2013-02-19 00:00:00', 'duha', 'duha', 'duha', 'ACTIVE', 'duha_.jpg'),
(47, '', 'FEMALE', '2017-02-24 00:00:00', 'huot', 'huot', 'huot', 'ACTIVE', 'huot_.jpg'),
(48, 'RKUDQNJP', 'FEMALE', '2013-02-19 00:00:00', 'ebyang', 'ebyang', 'ebyang', 'ACTIVE', 'ebyang_RKUDQNJP.JPG'),
(49, 'RKUDQNJP', 'FEMALE', '2011-02-19 00:00:00', 'kigwa', 'kigwa', 'kigwa', 'ACTIVE', 'kigwa_RKUDQNJP.JPG'),
(50, 'RKUDQNJP', 'FEMALE', '2011-02-19 00:00:00', 'ebyang', 'ebyang', 'ebyang', 'ACTIVE', 'ebyang_RKUDQNJP.JPG'),
(51, 'OHUTP249', 'FEMALE', '2005-02-19 00:00:00', 'idha', 'diha', 'diha', 'ACTIVE', 'idha_OHUTP249.jpg'),
(52, 'OK2JJCQ5', 'MALE', '2017-02-16 00:00:00', 'TEST 9 child', 'TEST 9 child', 'TEST 9 child', 'ACTIVE', 'TEST 9 child_OK2JJCQ5Q.jpg'),
(53, 'OK2JJCQ5', 'FEMALE', '2017-02-24 00:00:00', 'TEST 9 child 2', 'TEST 9 child 2', 'TEST 9 child 2', 'ACTIVE', 'TEST 9 child 2_OK2JJCQ5Q.jpg'),
(54, 'ENHMA78O', 'MALE', '2016-02-19 00:00:00', 'v', 'v', 'v', 'ACTIVE', 'v_ENHMA78OW.jpg'),
(55, 'ENHMA78O', 'FEMALE', '2015-02-19 00:00:00', 'b', 'b', 'b', 'ACTIVE', 'b_ENHMA78OW.jpg'),
(56, '3U0MR2DG', 'FEMALE', '2016-02-19 00:00:00', 'mk', 'mk', 'mk', 'ACTIVE', 'mk_3U0MR2DGE.jpg'),
(57, 'Q9LOLJIH', 'FEMALE', '2014-02-19 00:00:00', 'j', 'j', 'j', 'ACTIVE', 'j_Q9LOLJIHG.jpg'),
(58, 'PV4LD7CU', 'FEMALE', '2016-02-19 00:00:00', 'ns', 'ns', 'ns', 'ACTIVE', 'ns_PV4LD7CU3.jpg'),
(59, 'DMAOFOGC', 'MALE', '2016-02-19 00:00:00', 'ERASE', 'ERASE', 'ERASE', 'ACTIVE', 'ERASE_DMAOFOGCR.jpg');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_church_expenses`
--

CREATE TABLE `tbl_church_expenses` (
  `id` int(10) UNSIGNED NOT NULL,
  `Expenses_type` varchar(45) NOT NULL,
  `Amount` double NOT NULL,
  `Transaction_Date` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_church_income`
--

CREATE TABLE `tbl_church_income` (
  `Income_type_id` int(10) UNSIGNED NOT NULL,
  `Amount` double NOT NULL,
  `Date` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_church_information`
--

CREATE TABLE `tbl_church_information` (
  `id` int(10) UNSIGNED NOT NULL,
  `Church_name` varchar(45) NOT NULL,
  `Church_address` varchar(45) NOT NULL,
  `Contact_no` varchar(45) NOT NULL,
  `Email_ad` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_church_officials`
--

CREATE TABLE `tbl_church_officials` (
  `member_id` int(10) UNSIGNED NOT NULL,
  `Position_type` varchar(20) NOT NULL,
  `Year` varchar(10) NOT NULL,
  `image_path` varchar(100) NOT NULL,
  `Status` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_church_officials`
--

INSERT INTO `tbl_church_officials` (`member_id`, `Position_type`, `Year`, `image_path`, `Status`) VALUES
(146, 'HOST PASTOR', ' 2020', 'None', 'INACTIVE'),
(132, 'ELDER', ' 2020', 'None', 'INACTIVE'),
(139, 'DEACON 1', ' 2020', 'None', 'INACTIVE'),
(140, 'DEACON 2', ' 2020', 'None', 'INACTIVE'),
(141, 'DEACON 3', ' 2020', 'None', 'INACTIVE'),
(142, 'TREASURER', ' 2020', 'None', 'INACTIVE'),
(143, 'SECRETARY', ' 2020', 'None', 'INACTIVE'),
(146, 'HOST PASTOR', '2021', 'None', 'INACTIVE'),
(145, 'ELDER', '2021', 'None', 'INACTIVE'),
(144, 'DEACON 1', '2021', 'None', 'INACTIVE'),
(143, 'DEACON 2', '2021', 'None', 'INACTIVE'),
(141, 'DEACON 3', '2021', 'None', 'INACTIVE'),
(140, 'TREASURER', '2021', 'None', 'INACTIVE'),
(139, 'SECRETARY', '2021', 'None', 'INACTIVE'),
(146, 'HOST PASTOR', '56754567', 'None', 'ACTIVE'),
(132, 'ELDER', '56754567', 'None', 'ACTIVE'),
(141, 'DEACON 1', '56754567', 'None', 'ACTIVE'),
(143, 'DEACON 2', '56754567', 'None', 'ACTIVE'),
(144, 'DEACON 3', '56754567', 'None', 'ACTIVE'),
(139, 'TREASURER', '56754567', 'None', 'ACTIVE'),
(144, 'SECRETARY', '56754567', 'None', 'ACTIVE');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_educational_background`
--

CREATE TABLE `tbl_educational_background` (
  `Member_id` int(10) UNSIGNED NOT NULL,
  `HEA` varchar(45) NOT NULL,
  `Course_graduated` varchar(70) NOT NULL,
  `Name_of_school_graduated` varchar(60) NOT NULL,
  `Licensure_passer` varchar(3) NOT NULL,
  `License_specification` varchar(65) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_educational_background`
--

INSERT INTO `tbl_educational_background` (`Member_id`, `HEA`, `Course_graduated`, `Name_of_school_graduated`, `Licensure_passer`, `License_specification`) VALUES
(130, 'None', 'None', 'None', 'No', 'None'),
(131, 'None', 'None', 'None', 'No', 'None'),
(132, 'None', 'None', 'None', 'No', 'None'),
(133, '', 'None', 'None', 'No', 'None'),
(134, '', 'None', 'None', 'No', 'None'),
(135, '', 'None', 'None', 'No', 'None'),
(136, 'None', 'None', 'None', 'No', 'None'),
(137, '', 'None', 'None', 'No', 'None'),
(138, '', 'None', 'None', 'No', 'None'),
(139, '', 'None', 'None', 'No', 'None'),
(140, '', 'None', 'None', 'No', 'None'),
(141, '', 'None', 'None', 'No', 'None'),
(142, 'None', 'None', 'None', 'No', 'None'),
(143, '', 'None', 'None', 'No', 'None'),
(144, '', 'None', 'None', 'No', 'None'),
(145, '', 'None', 'None', 'No', 'None'),
(147, '', 'None', 'TEST 9', 'Yes', 'None'),
(148, '', 'z', 'z', 'No', 'None'),
(149, '', 'p', 'p', 'No', 'None'),
(150, '', 'None', 'LOL', 'No', 'None'),
(151, '', 'None', 'n', 'No', 'None'),
(152, '', 'None', 'ERASE', 'No', 'None'),
(153, 'High School', 'None', 'JK', 'No', 'None');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_emergency_funds`
--

CREATE TABLE `tbl_emergency_funds` (
  `id` int(10) UNSIGNED NOT NULL,
  `member_id` int(10) UNSIGNED NOT NULL,
  `Amount` double NOT NULL,
  `Date_borrowed` datetime NOT NULL,
  `Due_date` datetime NOT NULL,
  `Status` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_emergency_funds`
--

INSERT INTO `tbl_emergency_funds` (`id`, `member_id`, `Amount`, `Date_borrowed`, `Due_date`, `Status`) VALUES
(1, 130, 1000, '2017-02-19 00:00:00', '2017-03-19 00:00:00', 'PAID'),
(2, 130, 1000, '2017-02-19 00:00:00', '2017-03-19 00:00:00', 'PAID'),
(3, 132, 1000, '2017-02-19 00:00:00', '2017-03-19 00:00:00', 'PAID');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_emergency_fund_budget`
--

CREATE TABLE `tbl_emergency_fund_budget` (
  `id` int(10) UNSIGNED NOT NULL,
  `amount` double NOT NULL,
  `member_id` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_emergency_fund_budget`
--

INSERT INTO `tbl_emergency_fund_budget` (`id`, `amount`, `member_id`) VALUES
(1, 1000, 132);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_expenditures`
--

CREATE TABLE `tbl_expenditures` (
  `id` int(10) UNSIGNED NOT NULL,
  `Expenditures_type` varchar(40) NOT NULL,
  `member_id` int(10) UNSIGNED NOT NULL,
  `Date` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_family_details`
--

CREATE TABLE `tbl_family_details` (
  `Parent_id` int(10) UNSIGNED NOT NULL,
  `Child_id` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_family_details`
--

INSERT INTO `tbl_family_details` (`Parent_id`, `Child_id`) VALUES
(133, 26),
(133, 32),
(134, 33),
(135, 34),
(137, 35),
(138, 36),
(139, 37),
(140, 38),
(141, 39),
(143, 40),
(144, 41),
(145, 42),
(133, 43),
(133, 44),
(133, 45),
(130, 49),
(130, 50),
(133, 51),
(147, 52),
(147, 53),
(148, 54),
(148, 55),
(149, 56),
(150, 57),
(151, 58),
(152, 59);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_fines`
--

CREATE TABLE `tbl_fines` (
  `id` int(10) UNSIGNED NOT NULL,
  `member_id` int(10) UNSIGNED NOT NULL,
  `Fines` double NOT NULL,
  `status` varchar(45) NOT NULL,
  `meeting_date` date NOT NULL,
  `Description` varchar(100) NOT NULL,
  `balance` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_fines`
--

INSERT INTO `tbl_fines` (`id`, `member_id`, `Fines`, `status`, `meeting_date`, `Description`, `balance`) VALUES
(1, 134, 50, 'UNPAID', '2017-02-19', 'KAON NATA HAMZ', 50),
(2, 135, 50, 'UNPAID', '2017-02-19', 'KAON NATA HAMZ', 50),
(3, 136, 50, 'UNPAID', '2017-02-19', 'KAON NATA HAMZ', 50),
(4, 137, 50, 'UNPAID', '2017-02-19', 'KAON NATA HAMZ', 50),
(5, 138, 50, 'UNPAID', '2017-02-19', 'KAON NATA HAMZ', 50),
(6, 139, 50, 'UNPAID', '2017-02-19', 'KAON NATA HAMZ', 50),
(7, 140, 50, 'UNPAID', '2017-02-19', 'KAON NATA HAMZ', 50),
(8, 141, 50, 'UNPAID', '2017-02-19', 'KAON NATA HAMZ', 50),
(9, 142, 50, 'UNPAID', '2017-02-19', 'KAON NATA HAMZ', 50),
(10, 143, 50, 'UNPAID', '2017-02-19', 'KAON NATA HAMZ', 50),
(11, 144, 50, 'UNPAID', '2017-02-19', 'KAON NATA HAMZ', 50),
(12, 145, 50, 'UNPAID', '2017-02-19', 'KAON NATA HAMZ', 50),
(13, 146, 50, 'UNPAID', '2017-02-19', 'KAON NATA HAMZ', 50),
(14, 130, 50, 'UNPAID', '2017-02-19', 'TEST ATTENDANCE', 50),
(15, 131, 50, 'PAID', '2017-02-19', 'TEST ATTENDANCE', 50),
(16, 132, 50, 'PAID', '2017-02-19', 'TEST ATTENDANCE', 50),
(17, 133, 50, 'PAID', '2017-02-19', 'TEST ATTENDANCE', 50),
(18, 134, 50, 'UNPAID', '2017-02-19', 'TEST ATTENDANCE', 50),
(19, 135, 50, 'PAID', '2017-02-19', 'TEST ATTENDANCE', 50),
(20, 136, 50, 'PAID', '2017-02-19', 'TEST ATTENDANCE', 50),
(21, 137, 50, 'PAID', '2017-02-19', 'TEST ATTENDANCE', 50),
(22, 138, 50, 'PAID', '2017-02-19', 'TEST ATTENDANCE', 50),
(23, 142, 50, 'PAID', '2017-02-19', 'TEST ATTENDANCE', 50),
(24, 143, 50, 'UNPAID', '2017-02-19', 'TEST ATTENDANCE', 50),
(25, 144, 50, 'UNPAID', '2017-02-19', 'TEST ATTENDANCE', 50),
(26, 145, 50, 'UNPAID', '2017-02-19', 'TEST ATTENDANCE', 50),
(27, 146, 50, 'UNPAID', '2017-02-19', 'TEST ATTENDANCE', 50);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_host_pastor`
--

CREATE TABLE `tbl_host_pastor` (
  `id` int(10) UNSIGNED NOT NULL,
  `First_Name` varchar(45) NOT NULL,
  `Last_name` varchar(45) NOT NULL,
  `Middle_Name` varchar(45) NOT NULL,
  `Address` varchar(60) NOT NULL,
  `gender` varchar(10) NOT NULL,
  `Date_of_birth` datetime DEFAULT NULL,
  `concat_number` varchar(45) NOT NULL,
  `Name_of_school_grad` varchar(45) NOT NULL,
  `Address_of_school_graduaterd` varchar(45) NOT NULL,
  `year_graduated` varchar(45) NOT NULL,
  `Chutch_name` varchar(45) NOT NULL,
  `Church_address` varchar(45) NOT NULL,
  `years_of_service` varchar(45) NOT NULL,
  `image_path` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_host_pastor`
--

INSERT INTO `tbl_host_pastor` (`id`, `First_Name`, `Last_name`, `Middle_Name`, `Address`, `gender`, `Date_of_birth`, `concat_number`, `Name_of_school_grad`, `Address_of_school_graduaterd`, `year_graduated`, `Chutch_name`, `Church_address`, `years_of_service`, `image_path`) VALUES
(146, 'pastor1', 'pastor1', 'pastor1', 'pastor1', 'MALE', '2017-02-09 00:00:00', 'pastor1', 'None', 'None', 'None', 'None', 'None', 'None', 'pastor1.jpg'),
(154, 'cloe', 'cloe', 'cloe', 'cloe', 'FEMALE', '2017-02-23 00:00:00', 'asdasd', 'None', 'None', 'None', 'None', 'None', 'None', 'cloe.jpg');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_listofhostpastor`
--

CREATE TABLE `tbl_listofhostpastor` (
  `id` int(10) UNSIGNED NOT NULL,
  `Pastor_id` int(10) UNSIGNED NOT NULL,
  `Officer_type` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_member_information`
--

CREATE TABLE `tbl_member_information` (
  `id` int(10) UNSIGNED NOT NULL,
  `Member_id` varchar(8) NOT NULL,
  `First_name` varchar(45) NOT NULL,
  `Last_name` varchar(45) NOT NULL,
  `Middle_name` varchar(10) NOT NULL,
  `Date_of_birth` datetime NOT NULL,
  `Gender` varchar(6) NOT NULL,
  `Province` varchar(45) NOT NULL,
  `City` varchar(45) NOT NULL,
  `Barangay` varchar(45) NOT NULL,
  `Baptized_status` varchar(3) NOT NULL,
  `Baptized_date` datetime DEFAULT NULL,
  `Contact_no` varchar(20) NOT NULL,
  `Email_ad` varchar(45) NOT NULL,
  `Blood_type` varchar(5) NOT NULL,
  `Civil_status` varchar(10) NOT NULL,
  `Church_name` varchar(45) NOT NULL,
  `Pastor_name` varchar(45) NOT NULL,
  `Marriage_date` datetime DEFAULT NULL,
  `member_type` varchar(45) NOT NULL,
  `image_path` varchar(100) NOT NULL,
  `status` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_member_information`
--

INSERT INTO `tbl_member_information` (`id`, `Member_id`, `First_name`, `Last_name`, `Middle_name`, `Date_of_birth`, `Gender`, `Province`, `City`, `Barangay`, `Baptized_status`, `Baptized_date`, `Contact_no`, `Email_ad`, `Blood_type`, `Civil_status`, `Church_name`, `Pastor_name`, `Marriage_date`, `member_type`, `image_path`, `status`) VALUES
(130, 'RKUDQNJP', 'TEST1', 'TEST1', 'TEST1', '2017-01-29 00:00:00', 'Male', 'TEST1', 'TEST1', 'TEST1', 'Yes', '2017-01-29 00:00:00', 'None', 'None', 'A+', 'Single', 'TEST1', 'TEST1', '0000-00-00 00:00:00', 'member', 'RKUDQNJPW.jpg', 'ACTIVE'),
(131, 'TSUBRT9Y', 'TEST2', 'TEST2', 'TEST2', '2017-01-29 00:00:00', 'Female', 'TEST2', 'TEST2', 'TEST2', 'No', '2017-01-29 00:00:00', 'None', 'None', 'A-', 'Single', 'TEST2', 'TEST2', '0000-00-00 00:00:00', 'member', 'TSUBRT9YV.jpg', 'ACTIVE'),
(132, 'K5USMZU4', 'TEST3', 'TEST3', 'TEST3', '2017-01-29 00:00:00', 'Female', 'TEST3', 'TEST3', 'TEST3', 'No', '2017-01-29 00:00:00', 'None', 'None', 'A-', 'Single', 'TEST3', 'TEST3', '0000-00-00 00:00:00', 'member', 'image_icon.jpg', 'ACTIVE'),
(133, 'OHUTP249', 'TEST4', 'TEST4', 'TEST4', '2017-01-29 00:00:00', 'Female', 'TEST4', 'TEST4', 'TEST4', '', '2017-01-29 00:00:00', 'None', 'None', 'AB+', '', 'TEST4', 'TEST4', '0000-00-00 00:00:00', 'member', 'OHUTP2490.jpg', 'ACTIVE'),
(134, 'X0F1Q69E', 'WALANGKATAPUSANGTEST', 'WALANGKATAPUSANGTEST', '', '2017-01-29 00:00:00', 'Male', 'WALANGKATAPUSANGTEST', 'WALANGKATAPUSANGTEST', 'WALANGKATAPUSANGTEST', '', '2017-01-29 00:00:00', 'None', 'None', 'B+', '', 'WALANGKATAPUSANGTEST', 'WALANGKATAPUSANGTEST', '0000-00-00 00:00:00', 'member', 'X0F1Q69EH.jpg', 'ACTIVE'),
(135, 'GDLXN7EC', 'O', 'O', '', '2017-01-29 00:00:00', 'Male', 'O', 'O', 'O', '', '2017-01-29 00:00:00', 'None', 'None', 'A+', '', 'O', 'O', '0000-00-00 00:00:00', 'member', 'GDLXN7ECB.jpg', 'ACTIVE'),
(136, 'WWKHJ0NJ', 'P', 'P', 'P', '2017-01-29 00:00:00', 'Male', 'P', 'P', 'P', 'No', '2017-01-29 00:00:00', 'None', 'None', 'A+', 'Single', 'P', 'P', '0000-00-00 00:00:00', 'member', 'WWKHJ0NJ6.jpg', 'ACTIVE'),
(137, '8C0IMZTC', 'U', 'U', '', '2017-01-29 00:00:00', 'Male', 'U', 'U', 'U', '', '2017-01-29 00:00:00', 'None', 'None', 'A+', '', 'U', 'U', '0000-00-00 00:00:00', 'member', '8C0IMZTCH.jpg', 'ACTIVE'),
(138, 'T07P3VQU', 'Y', 'Y', '', '2017-01-29 00:00:00', 'Male', 'T', 'T', 'T', '', '2017-01-29 00:00:00', 'None', 'None', 'A+', '', 'T', 'T', '0000-00-00 00:00:00', 'member', 'T07P3VQU7.jpg', 'ACTIVE'),
(139, 'B0UKYV81', 'ATEGS', 'ATEGS', '', '2017-01-29 00:00:00', 'Male', 'ATEGS', 'ATEGS', 'ATEGS', '', '2017-01-29 00:00:00', 'None', 'None', 'B+', '', 'ATEGS', 'ATEGS', '0000-00-00 00:00:00', 'member', 'B0UKYV81O.jpg', 'ACTIVE'),
(140, 'IH8STG3Y', 'M', 'M', '', '2017-01-29 00:00:00', 'Male', 'M', 'M', 'M', '', '2017-01-29 00:00:00', 'None', 'None', 'AB+', '', 'M', 'M', '0000-00-00 00:00:00', 'member', 'IH8STG3YI.jpg', 'ACTIVE'),
(141, 'F0NOX2MR', 'H', 'H', '', '2017-01-29 00:00:00', 'Male', 'H', 'H', 'H', '', '2017-01-29 00:00:00', 'None', 'None', 'A+', '', 'H', 'H', '0000-00-00 00:00:00', 'member', 'F0NOX2MRM.jpg', 'ACTIVE'),
(142, 'TJU5V8ZK', 'K', 'K', 'K', '2017-01-29 00:00:00', 'Male', 'K', 'K', 'K', 'No', '2017-01-29 00:00:00', 'None', 'None', 'B+', 'Single', 'K', 'K', '0000-00-00 00:00:00', 'member', 'image_icon.jpg', 'ACTIVE'),
(143, '1KF82JG4', 'N', 'N', '', '2017-01-29 00:00:00', 'Male', 'N', 'N', 'N', '', '2017-01-29 00:00:00', 'None', 'None', 'B+', '', 'N', 'N', '0000-00-00 00:00:00', 'member', '1KF82JG4S.jpg', 'ACTIVE'),
(144, '6XG56TCW', 'J', 'J', 'J', '2017-01-29 00:00:00', 'Male', 'J', 'J', 'J', '', '2017-01-29 00:00:00', 'None', 'None', 'A+', '', 'J', 'J', '0000-00-00 00:00:00', 'member', '6XG56TCWE.jpg', 'ACTIVE'),
(145, '5R6YHJ4C', 'L', 'L', 'L', '2017-01-29 00:00:00', 'Female', 'L', 'L', 'L', '', '2017-01-29 00:00:00', 'None', 'None', 'B+', '', 'L', 'L', '0000-00-00 00:00:00', 'member', '5R6YHJ4C5.jpg', 'ACTIVE'),
(146, 'NRZC5QVF', 'pastor1', 'pastor1', 'pastor1', '2017-02-09 00:00:00', 'MALE', 'N/a', 'N/a', 'N/a', 'No', '2017-01-29 00:00:00', 'None', 'None', 'N/a', 'N/a', 'N/a', 'N/a', '2017-01-29 00:00:00', 'pastor', 'pastor1.jpg', 'ACTIVE'),
(147, 'OK2JJCQ5', 'TEST 9', 'TEST 9', 'TEST 9', '2017-01-29 00:00:00', 'Male', 'TEST 9', 'TEST 9', 'TEST 9', '', '2017-01-29 00:00:00', 'TEST 9', 'TEST 9', 'A+', '', 'TEST 9', 'TEST 9', '0000-00-00 00:00:00', 'member', 'OK2JJCQ5Q.jpg', 'ACTIVE'),
(148, 'ENHMA78O', 'ZZ', 'Z', 'Z', '2017-01-29 00:00:00', 'Male', 'Z', 'Z', 'Z', '', '2017-01-29 00:00:00', 'z', 'z', 'A+', '', 'Z', 'Z', '0000-00-00 00:00:00', 'member', 'image_icon.jpg', 'ACTIVE'),
(149, '3U0MR2DG', 'P', 'P', 'P', '2017-01-29 00:00:00', 'Male', 'P', 'P', 'P', '', '2017-01-29 00:00:00', 'p', 'p@gmial.com', 'A+', '', 'P', 'P', '0000-00-00 00:00:00', 'member', '3U0MR2DGE.jpg', 'ACTIVE'),
(150, 'Q9LOLJIH', 'LOL', 'LOL', 'LOL', '2017-01-29 00:00:00', 'Male', 'LOL', 'LOL', 'LOL', '', '2017-01-29 00:00:00', 'LOL', 'LOL@gmail.com', 'A+', '', 'LOL', 'LOL', '0000-00-00 00:00:00', 'member', 'Q9LOLJIHG.jpg', 'ACTIVE'),
(151, 'PV4LD7CU', 'N', 'N', 'N', '2017-01-29 00:00:00', 'Male', 'N', 'N', 'N', '', '2017-01-29 00:00:00', 'n', 'n', 'A+', '', 'N', 'N', '0000-00-00 00:00:00', 'member', 'PV4LD7CU3.jpg', 'ACTIVE'),
(152, 'DMAOFOGC', 'ERASE', 'ERASE', 'ERASE', '2017-01-29 00:00:00', 'Male', 'ERASE', 'ERASE', 'ERASE', '', '2017-01-29 00:00:00', 'ERASE', 'ERASE', 'A+', '', 'ERASE', 'ERASE', '0000-00-00 00:00:00', 'member', 'DMAOFOGCR.jpg', 'ACTIVE'),
(153, 'QL4ICTYY', 'JK', 'JK', 'JK', '2017-01-29 00:00:00', 'Male', 'JK', 'JK', 'JK', 'Yes', '2017-01-29 00:00:00', 'JK', 'JK', 'A+', 'Married', 'JK', 'JK', '0000-00-00 00:00:00', 'member', 'image_icon.jpg', 'ACTIVE'),
(154, 'T5880SBA', 'cloe', 'cloe', 'cloe', '2017-02-23 00:00:00', 'FEMALE', 'N/a', 'N/a', 'N/a', 'No', '2017-01-29 00:00:00', 'None', 'None', 'N/a', 'N/a', 'N/a', 'N/a', '2017-01-29 00:00:00', 'pastor', 'cloe.jpg', 'ACTIVE');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_offerings`
--

CREATE TABLE `tbl_offerings` (
  `id` int(10) UNSIGNED NOT NULL,
  `offering_type` varchar(45) NOT NULL,
  `amount` double NOT NULL,
  `date` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_offerings`
--

INSERT INTO `tbl_offerings` (`id`, `offering_type`, `amount`, `date`) VALUES
(1, 'TITHES', 20, '2017-02-13 23:56:11'),
(2, 'LOVE', 20, '2017-02-13 23:56:11'),
(3, 'MISSION', 20, '2017-02-13 23:56:11'),
(4, 'LOVE', 20, '2017-02-14 18:26:00'),
(5, 'TITHES', 10, '2017-02-14 18:28:34'),
(6, 'LOVE', 10, '2017-02-14 18:34:46');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_shared`
--

CREATE TABLE `tbl_shared` (
  `id` int(10) UNSIGNED NOT NULL,
  `Pastor_shared` double NOT NULL,
  `District` double NOT NULL,
  `Main_church` double NOT NULL,
  `Local_church` double NOT NULL,
  `Moderator` double NOT NULL,
  `Date_From` datetime NOT NULL,
  `Date_To` datetime NOT NULL,
  `date_save` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_shared`
--

INSERT INTO `tbl_shared` (`id`, `Pastor_shared`, `District`, `Main_church`, `Local_church`, `Moderator`, `Date_From`, `Date_To`, `date_save`) VALUES
(1, 60, 10, 10, 15, 5, '2017-01-01 00:00:00', '2017-02-19 00:00:00', '2017-02-19 12:34:35');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_ten`
--

CREATE TABLE `tbl_ten` (
  `member_id` int(10) UNSIGNED NOT NULL,
  `amount` double NOT NULL,
  `status` varchar(45) NOT NULL,
  `Month` date NOT NULL,
  `Monthly_amount` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_useraccount`
--

CREATE TABLE `tbl_useraccount` (
  `id` int(10) UNSIGNED NOT NULL,
  `First_Name` varchar(45) NOT NULL,
  `Last_Name` varchar(45) NOT NULL,
  `Username` varchar(45) NOT NULL,
  `Password` varchar(45) NOT NULL,
  `User_type` varchar(45) NOT NULL,
  `Contact_no` varchar(45) NOT NULL,
  `Date_registered` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_useraccount`
--

INSERT INTO `tbl_useraccount` (`id`, `First_Name`, `Last_Name`, `Username`, `Password`, `User_type`, `Contact_no`, `Date_registered`) VALUES
(1, 'admin', 'admin', 'admin', '21232f297a57a5a743894a0e4a801fc3', 'admin', '09', '2017-02-18 22:57:14'),
(2, 'secretary', 'secretary', 'secretary', '889b2b111b4bc3adb722f0fcff480901', 'SECRETARY', '910292092', '2017-02-19 23:46:49');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_wedding`
--

CREATE TABLE `tbl_wedding` (
  `id` int(10) UNSIGNED NOT NULL,
  `other_income_type` varchar(45) NOT NULL,
  `amount` double NOT NULL,
  `date` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_work_information`
--

CREATE TABLE `tbl_work_information` (
  `Members_id` int(10) UNSIGNED NOT NULL,
  `Work_status` varchar(3) NOT NULL,
  `Work_address` varchar(45) NOT NULL,
  `Nature_of_work` varchar(45) NOT NULL,
  `Name_of_company` varchar(45) NOT NULL,
  `Salary` double NOT NULL,
  `Self_employed` varchar(10) NOT NULL,
  `Name_of_business` varchar(45) NOT NULL,
  `Business_address` varchar(45) NOT NULL,
  `Estimated_annual_income` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_work_information`
--

INSERT INTO `tbl_work_information` (`Members_id`, `Work_status`, `Work_address`, `Nature_of_work`, `Name_of_company`, `Salary`, `Self_employed`, `Name_of_business`, `Business_address`, `Estimated_annual_income`) VALUES
(130, 'No', 'None', 'None', 'None', 0, 'None', 'None', 'None', '0'),
(131, 'No', 'None', 'None', 'None', 0, 'None', 'None', 'None', '0'),
(132, 'No', 'None', 'None', 'None', 0, 'None', 'None', 'None', '0'),
(133, '', 'None', 'None', 'None', 0, 'None', 'None', 'None', '0'),
(134, '', 'None', 'None', 'None', 0, 'None', 'None', 'None', '0'),
(135, '', 'None', 'None', 'None', 0, 'None', 'None', 'None', '0'),
(136, 'No', 'None', 'None', 'None', 0, 'None', 'None', 'None', '0'),
(137, '', 'None', 'None', 'None', 0, 'None', 'None', 'None', '0'),
(138, '', 'None', 'None', 'None', 0, 'None', 'None', 'None', '0'),
(139, '', 'None', 'None', 'None', 0, 'None', 'None', 'None', '0'),
(140, '', 'None', 'None', 'None', 0, 'None', 'None', 'None', '0'),
(141, '', 'None', 'None', 'None', 0, 'None', 'None', 'None', '0'),
(142, 'No', 'None', 'None', 'None', 0, 'None', 'None', 'None', '0'),
(143, '', 'None', 'None', 'None', 0, 'None', 'None', 'None', '0'),
(144, '', 'None', 'None', 'None', 0, 'None', 'None', 'None', '0'),
(145, '', 'None', 'None', 'None', 0, 'None', 'None', 'None', '0'),
(147, '', 'TEST 9', 'TEST 9', 'TEST 9', 0, 'TEST 9', 'TEST 9', 'TEST 9', '0'),
(148, '', 'z', 'z', 'z', 123, 'z', 'z', 'z', '123'),
(149, '', 'p', 'p', 'p', 222, 'p', 'lop', 'p', '22'),
(150, '', 'None', 'None', 'None', 0, 'None', 'None', 'None', '0'),
(151, '', 'None', 'None', 'None', 0, 'None', 'None', 'None', '0'),
(152, '', 'None', 'None', 'None', 0, 'None', 'None', 'None', '0'),
(153, 'No', 'None', 'None', 'None', 0, 'None', 'None', 'None', '0');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_attendance`
--
ALTER TABLE `tbl_attendance`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FK_tbl_church_attendance_2` (`Member_id`);

--
-- Indexes for table `tbl_burialofficial`
--
ALTER TABLE `tbl_burialofficial`
  ADD KEY `FK_tbl_burialOfficial_1` (`member_id`);

--
-- Indexes for table `tbl_child_information`
--
ALTER TABLE `tbl_child_information`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbl_church_expenses`
--
ALTER TABLE `tbl_church_expenses`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbl_church_income`
--
ALTER TABLE `tbl_church_income`
  ADD KEY `FK_tbl_church_income_3` (`Income_type_id`);

--
-- Indexes for table `tbl_church_information`
--
ALTER TABLE `tbl_church_information`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbl_church_officials`
--
ALTER TABLE `tbl_church_officials`
  ADD KEY `FK_tbl_church_officials_2` (`member_id`);

--
-- Indexes for table `tbl_educational_background`
--
ALTER TABLE `tbl_educational_background`
  ADD KEY `FK_tbl_educational_background_1` (`Member_id`);

--
-- Indexes for table `tbl_emergency_funds`
--
ALTER TABLE `tbl_emergency_funds`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FK_tbl_emergency_funds_1` (`member_id`);

--
-- Indexes for table `tbl_emergency_fund_budget`
--
ALTER TABLE `tbl_emergency_fund_budget`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FK_tbl_emergency_fund_budget_1` (`member_id`);

--
-- Indexes for table `tbl_expenditures`
--
ALTER TABLE `tbl_expenditures`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FK_tbl_expenditures_1` (`member_id`);

--
-- Indexes for table `tbl_family_details`
--
ALTER TABLE `tbl_family_details`
  ADD KEY `FK_tbl_family_details_1` (`Parent_id`),
  ADD KEY `FK_tbl_family_details_2` (`Child_id`);

--
-- Indexes for table `tbl_fines`
--
ALTER TABLE `tbl_fines`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FK_tbl_fines_1` (`member_id`);

--
-- Indexes for table `tbl_host_pastor`
--
ALTER TABLE `tbl_host_pastor`
  ADD KEY `FK_tbl_host_pastor_1` (`id`);

--
-- Indexes for table `tbl_listofhostpastor`
--
ALTER TABLE `tbl_listofhostpastor`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbl_member_information`
--
ALTER TABLE `tbl_member_information`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbl_offerings`
--
ALTER TABLE `tbl_offerings`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbl_shared`
--
ALTER TABLE `tbl_shared`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbl_ten`
--
ALTER TABLE `tbl_ten`
  ADD KEY `FK_tbl_ten_1` (`member_id`);

--
-- Indexes for table `tbl_useraccount`
--
ALTER TABLE `tbl_useraccount`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbl_wedding`
--
ALTER TABLE `tbl_wedding`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbl_work_information`
--
ALTER TABLE `tbl_work_information`
  ADD KEY `FK_work_information_1` (`Members_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_attendance`
--
ALTER TABLE `tbl_attendance`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
--
-- AUTO_INCREMENT for table `tbl_child_information`
--
ALTER TABLE `tbl_child_information`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=60;
--
-- AUTO_INCREMENT for table `tbl_church_expenses`
--
ALTER TABLE `tbl_church_expenses`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tbl_church_information`
--
ALTER TABLE `tbl_church_information`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tbl_emergency_funds`
--
ALTER TABLE `tbl_emergency_funds`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `tbl_emergency_fund_budget`
--
ALTER TABLE `tbl_emergency_fund_budget`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `tbl_expenditures`
--
ALTER TABLE `tbl_expenditures`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tbl_fines`
--
ALTER TABLE `tbl_fines`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;
--
-- AUTO_INCREMENT for table `tbl_listofhostpastor`
--
ALTER TABLE `tbl_listofhostpastor`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tbl_member_information`
--
ALTER TABLE `tbl_member_information`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=155;
--
-- AUTO_INCREMENT for table `tbl_offerings`
--
ALTER TABLE `tbl_offerings`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT for table `tbl_shared`
--
ALTER TABLE `tbl_shared`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `tbl_useraccount`
--
ALTER TABLE `tbl_useraccount`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `tbl_wedding`
--
ALTER TABLE `tbl_wedding`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbl_attendance`
--
ALTER TABLE `tbl_attendance`
  ADD CONSTRAINT `FK_tbl_attendance_1` FOREIGN KEY (`Member_id`) REFERENCES `tbl_member_information` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tbl_burialofficial`
--
ALTER TABLE `tbl_burialofficial`
  ADD CONSTRAINT `FK_tbl_burialOfficial_1` FOREIGN KEY (`member_id`) REFERENCES `tbl_member_information` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tbl_church_income`
--
ALTER TABLE `tbl_church_income`
  ADD CONSTRAINT `FK_tbl_church_income_1` FOREIGN KEY (`Income_type_id`) REFERENCES `tbl_fines` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_tbl_church_income_2` FOREIGN KEY (`Income_type_id`) REFERENCES `tbl_offerings` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_tbl_church_income_3` FOREIGN KEY (`Income_type_id`) REFERENCES `tbl_wedding` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tbl_church_officials`
--
ALTER TABLE `tbl_church_officials`
  ADD CONSTRAINT `FK_tbl_church_officials_1` FOREIGN KEY (`member_id`) REFERENCES `tbl_member_information` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tbl_educational_background`
--
ALTER TABLE `tbl_educational_background`
  ADD CONSTRAINT `FK_tbl_educational_background_1` FOREIGN KEY (`Member_id`) REFERENCES `tbl_member_information` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tbl_emergency_funds`
--
ALTER TABLE `tbl_emergency_funds`
  ADD CONSTRAINT `FK_tbl_emergency_funds_1` FOREIGN KEY (`member_id`) REFERENCES `tbl_member_information` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tbl_emergency_fund_budget`
--
ALTER TABLE `tbl_emergency_fund_budget`
  ADD CONSTRAINT `FK_tbl_emergency_fund_budget_1` FOREIGN KEY (`member_id`) REFERENCES `tbl_member_information` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tbl_expenditures`
--
ALTER TABLE `tbl_expenditures`
  ADD CONSTRAINT `FK_tbl_expenditures_1` FOREIGN KEY (`member_id`) REFERENCES `tbl_member_information` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tbl_family_details`
--
ALTER TABLE `tbl_family_details`
  ADD CONSTRAINT `FK_tbl_family_details_1` FOREIGN KEY (`Parent_id`) REFERENCES `tbl_member_information` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_tbl_family_details_2` FOREIGN KEY (`Child_id`) REFERENCES `tbl_child_information` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tbl_fines`
--
ALTER TABLE `tbl_fines`
  ADD CONSTRAINT `FK_tbl_fines_1` FOREIGN KEY (`member_id`) REFERENCES `tbl_member_information` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tbl_host_pastor`
--
ALTER TABLE `tbl_host_pastor`
  ADD CONSTRAINT `FK_tbl_host_pastor_1` FOREIGN KEY (`id`) REFERENCES `tbl_member_information` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tbl_ten`
--
ALTER TABLE `tbl_ten`
  ADD CONSTRAINT `FK_tbl_ten_1` FOREIGN KEY (`member_id`) REFERENCES `tbl_member_information` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tbl_work_information`
--
ALTER TABLE `tbl_work_information`
  ADD CONSTRAINT `FK_work_information_1` FOREIGN KEY (`Members_id`) REFERENCES `tbl_member_information` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
