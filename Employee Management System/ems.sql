-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 15, 2021 at 10:28 AM
-- Server version: 10.4.18-MariaDB
-- PHP Version: 8.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ems`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `name` varchar(30) NOT NULL,
  `password` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`name`, `password`) VALUES
('admin', 'password');

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `id` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `dob` varchar(100) NOT NULL,
  `gender` varchar(10) NOT NULL,
  `email` varchar(50) NOT NULL,
  `nic` varchar(15) NOT NULL,
  `address` varchar(50) NOT NULL,
  `telephone` varchar(11) NOT NULL,
  `education` varchar(10) NOT NULL,
  `position` varchar(30) NOT NULL,
  `salary` varchar(15) NOT NULL,
  `leaves` int(11) NOT NULL DEFAULT 5
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`id`, `name`, `dob`, `gender`, `email`, `nic`, `address`, `telephone`, `education`, `position`, `salary`, `leaves`) VALUES
(1000, 'Saritha Witharana', 'Wednesday, July 19, 2000', 'Male', 'witharana@gmail.com', '200026007777', '100,\r\nQueen\'s Street,\r\nAlexa.', '0778885677', 'Degree', 'Accountant', '15000', 2),
(1002, 'Tom Depp', 'Thursday, July 13, 2000', 'Male', 'depp00@gmail.com', '200026001111', '111/B,\r\nAce Road,\r\nCalifornia.', '0781212121', 'A/L', 'Clerk', '10000', 5);

-- --------------------------------------------------------

--
-- Table structure for table `leaverequests`
--

CREATE TABLE `leaverequests` (
  `id` int(11) NOT NULL,
  `emid` int(11) NOT NULL,
  `requesteddate` date NOT NULL,
  `reason` text NOT NULL,
  `approvedstatus` varchar(10) NOT NULL,
  `createddate` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `leaverequests`
--

INSERT INTO `leaverequests` (`id`, `emid`, `requesteddate`, `reason`, `approvedstatus`, `createddate`) VALUES
(8, 1001, '2021-10-22', 'Travelling', 'Pending', '2021-10-11 11:06:58');

-- --------------------------------------------------------

--
-- Table structure for table `manager`
--

CREATE TABLE `manager` (
  `id` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `dob` varchar(50) NOT NULL,
  `gender` varchar(10) NOT NULL,
  `email` varchar(50) NOT NULL,
  `nic` varchar(15) NOT NULL,
  `address` varchar(100) NOT NULL,
  `telephone` varchar(11) NOT NULL,
  `qualifications` varchar(10) NOT NULL,
  `yos` varchar(10) NOT NULL,
  `position` varchar(20) NOT NULL,
  `salary` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `manager`
--

INSERT INTO `manager` (`id`, `name`, `dob`, `gender`, `email`, `nic`, `address`, `telephone`, `qualifications`, `yos`, `position`, `salary`) VALUES
(10000, 'Janith Rathnayake', 'Friday, June 16, 2000', 'Male', 'janitha@gmail.com', '200006001000', '101/B,\r\nPitipana,\r\nHomagama.', '0774566541', 'BSc', '3', 'Operation Manager', '40000'),
(10003, 'Gaganie Silva', 'Sunday, July 30, 2000', 'Female', 'silva@gmail.com', '200026001111', '110/A,\r\nSamagi Road,\r\nKottawa.', '0771238902', 'Master\'s', '4', 'Deputy General Manag', '50000'),
(10004, 'David Milan', 'Thursday, March 1, 1990', 'Male', 'david@gmail.com', '200020666144', '101/A,\r\nOxford  Road,\r\nLondon.\r\n\r\n', '0784593361', 'PhD', '5', 'Deputy General Manag', '50000');

-- --------------------------------------------------------

--
-- Table structure for table `manageraccount`
--

CREATE TABLE `manageraccount` (
  `id` int(11) NOT NULL,
  `password` varchar(50) NOT NULL,
  `email` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `manageraccount`
--

INSERT INTO `manageraccount` (`id`, `password`, `email`) VALUES
(10000, 'A0DF931E7A7F9B608C165504BDE9B620', 'janitha@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `prevleavereq`
--

CREATE TABLE `prevleavereq` (
  `id` int(11) NOT NULL,
  `empid` int(11) NOT NULL,
  `requestedate` date NOT NULL,
  `reason` text NOT NULL,
  `approvedstatus` varchar(10) NOT NULL,
  `createddate` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `prevleavereq`
--

INSERT INTO `prevleavereq` (`id`, `empid`, `requestedate`, `reason`, `approvedstatus`, `createddate`) VALUES
(14, 1000, '2021-10-11', 'Travel', 'Accepted', '2021-10-11 14:28:07'),
(15, 1000, '2021-10-13', 'Sick leave', 'Accepted', '2021-10-11 15:02:30');

-- --------------------------------------------------------

--
-- Table structure for table `staffsignup`
--

CREATE TABLE `staffsignup` (
  `id` int(11) NOT NULL,
  `password` varchar(50) NOT NULL,
  `email` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `staffsignup`
--

INSERT INTO `staffsignup` (`id`, `password`, `email`) VALUES
(1000, '10D0CDC0136E8959D928FC4BB254F78B', 'saritha@gmail.com'),
(1001, '834C9DF7553233A30B3F645850037DF7', 'hirank@gmail.com'),
(1002, 'C2477F223C3C4CA19A5029E0CD91FDA8', 'chalaka@gmail.com');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `leaverequests`
--
ALTER TABLE `leaverequests`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `manager`
--
ALTER TABLE `manager`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `manageraccount`
--
ALTER TABLE `manageraccount`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `prevleavereq`
--
ALTER TABLE `prevleavereq`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `staffsignup`
--
ALTER TABLE `staffsignup`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `employee`
--
ALTER TABLE `employee`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1003;

--
-- AUTO_INCREMENT for table `leaverequests`
--
ALTER TABLE `leaverequests`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `manager`
--
ALTER TABLE `manager`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10005;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
