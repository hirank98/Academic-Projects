-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 17, 2022 at 08:15 AM
-- Server version: 10.4.17-MariaDB
-- PHP Version: 7.3.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `test`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `userid` varchar(11) NOT NULL,
  `password` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`userid`, `password`) VALUES
('1111', 'user1'),
('admin1', '0000');

-- --------------------------------------------------------

--
-- Table structure for table `blocked`
--

CREATE TABLE `blocked` (
  `title` varchar(10) NOT NULL,
  `firstname` varchar(30) NOT NULL,
  `lastname` varchar(30) NOT NULL,
  `username` varchar(10) NOT NULL,
  `email` varchar(30) NOT NULL,
  `password` varchar(10) NOT NULL,
  `gender` varchar(10) NOT NULL,
  `telephone` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `blocked`
--

INSERT INTO `blocked` (`title`, `firstname`, `lastname`, `username`, `email`, `password`, `gender`, `telephone`) VALUES
('MS', 'Vishwani', 'Gunapala', 'VishG', 'vishg@gmail.com', 'abcd', 'female', '0776225990');

-- --------------------------------------------------------

--
-- Table structure for table `chat`
--

CREATE TABLE `chat` (
  `id` int(11) NOT NULL,
  `email` varchar(30) NOT NULL,
  `cchat` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `chat`
--

INSERT INTO `chat` (`id`, `email`, `cchat`) VALUES
(54, 'gagis@gmail.com', 'Test 5 GagiS');

-- --------------------------------------------------------

--
-- Table structure for table `chatback`
--

CREATE TABLE `chatback` (
  `id` int(11) NOT NULL,
  `email` varchar(50) NOT NULL,
  `message` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `chatback`
--

INSERT INTO `chatback` (`id`, `email`, `message`) VALUES
(17, 'clark@gmail.com', '        \r\n        mn'),
(18, 'iamjenner@gmail.com', '        \r\n   hi     '),
(20, 'wwe@gmail.com', '    HI    \r\n        '),
(21, 'iamjenner@gmail.com', '        \r\n        BV'),
(24, 'iambatman@gmail.com', '        \r\n     hi   '),
(25, 'iamjenner@gmail.com', 'Final Test'),
(29, 'sagga@gmail.com', 'Hello'),
(31, 'sagga@gmail.com', 'What\'s my ticket ID?'),
(32, 'sagga@gmail.com', 'Hello May 15 test 1'),
(33, 'iamjenner@gmail.com', 'Hi may 15 test 2'),
(34, 'sarathb@gmail.com', 'Hello. Whats my ticket ID?'),
(35, 'sarathb@gmail.com', 'May Test 3'),
(42, 'iamjenner@gmail.com', 'Test 5'),
(45, 'vishg@gmail.com', 'Can I know my Ticket ID?'),
(46, 'gagis@gmail.com', 'Can I get tech help ?'),
(47, 'carlj@gmail.com', 'Can I do the reservations my self?'),
(48, 'gagis@gmail.com', 'Can I get my ticket ID?\r\n-Thnx.'),
(50, 'gagis@gmail.com', 'Test 1 Gagi'),
(51, 'vishg@gmail.com', 'Test 2 VishG'),
(52, 'carlj@gmail.com', 'Test 3 CarlJ'),
(53, 'saggaw@gmail.com', 'Test 4 SaggaW');

-- --------------------------------------------------------

--
-- Table structure for table `client`
--

CREATE TABLE `client` (
  `title` varchar(10) NOT NULL,
  `firstname` varchar(30) NOT NULL,
  `lastname` varchar(30) NOT NULL,
  `username` varchar(10) NOT NULL,
  `email` varchar(30) NOT NULL,
  `password` varchar(255) NOT NULL,
  `gender` varchar(10) NOT NULL,
  `telephone` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `client`
--

INSERT INTO `client` (`title`, `firstname`, `lastname`, `username`, `email`, `password`, `gender`, `telephone`) VALUES
('MR', 'Janitha', 'Rathnayake', 'CarlJ', 'carlj@gmail.com', 'abcd', 'male', '0771954876'),
('MS', 'Gaganie', 'Silva', 'GagiS', 'gagis@gmail.com', '1234', 'female', '0112645224'),
('DR', 'Rasika', 'Ranaweera', 'Rasika', 'rasika@gmail.com', '202cb962ac59075b964b07152d234b70', 'male', '077-3144532'),
('MR', 'Saritha', 'Witharana', 'SaggaW', 'saggaw@gmail.com', '1234', 'male', '0706448160');

-- --------------------------------------------------------

--
-- Table structure for table `flight`
--

CREATE TABLE `flight` (
  `id` varchar(10) NOT NULL,
  `departcountry` varchar(50) NOT NULL,
  `depcity` varchar(50) NOT NULL,
  `descountry` varchar(50) NOT NULL,
  `descity` varchar(50) NOT NULL,
  `airline` varchar(50) NOT NULL,
  `datea` date NOT NULL,
  `timea` time NOT NULL,
  `dated` date NOT NULL,
  `timed` time NOT NULL,
  `depairport` varchar(50) NOT NULL,
  `desairport` varchar(50) NOT NULL,
  `stops` varchar(10) NOT NULL,
  `fare` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `flight`
--

INSERT INTO `flight` (`id`, `departcountry`, `depcity`, `descountry`, `descity`, `airline`, `datea`, `timea`, `dated`, `timed`, `depairport`, `desairport`, `stops`, `fare`) VALUES
('Air 1', 'Sri Lanka', 'Katunayake', 'United States', 'New York', 'Emirates', '2021-06-03', '04:32:00', '2021-06-01', '22:16:00', 'Katunayake', 'New York', '2', '900000'),
('Air 10', 'United Kingdom', 'London', 'Romania', 'Bucharest', 'British Airways', '2021-06-26', '18:00:00', '2021-05-27', '21:45:00', 'London', 'Bucharest', '0', '325000'),
('Air 11', 'India', 'Delhi', 'Russia', 'Moscow', 'Emirates', '2021-05-31', '19:00:00', '2021-06-02', '06:10:00', 'Delhi', 'Moscow', '1', '350000'),
('Air 12', 'Ireland', 'Dublin', 'Switzerland', 'Bern', 'British Airways', '2021-06-20', '16:00:00', '2021-06-19', '06:35:00', 'Dublin', 'Bern', '1', '450000'),
('Air 2', 'Sri Lanka', 'Katunayake', 'Australia', 'Sydney', 'Sri Lankan Airlines', '2021-06-03', '06:00:00', '2021-06-01', '20:42:00', 'Katunayake', 'Sydney', '1', '750000'),
('Air 3', 'Sri Lanka', 'Katunayake', 'United Kingdom', 'London', 'British Airways', '2021-06-10', '09:15:00', '2021-06-08', '19:45:00', 'Katunayake', 'London', '2', '800000'),
('Air 4', 'Sri Lanka', 'Katunayake', 'Italy', 'Venice', 'Qatar Airways', '2021-06-16', '08:12:00', '2021-05-14', '23:56:00', 'Katunayake', 'Venice', '2', '745000'),
('Air 5', 'Sri Lanka', 'Katunayake', 'Singapore', 'Singapore', 'British Airways', '2021-06-20', '08:15:00', '2021-06-18', '23:30:00', 'Katunayake', 'Singapore', '0', '500000'),
('Air 6', 'Sri Lanka', 'Katunayake', 'India', 'Mumbai', 'Sri Lankan Airlines', '2021-05-30', '16:15:00', '2021-05-29', '22:30:00', 'Katunayake', 'Mumbai', '0', '175000'),
('Air 7', 'United Kingdom', 'London', 'Ireland', 'Dublin', 'British Airways', '2021-06-20', '12:50:00', '2021-06-19', '06:51:00', 'London', 'Dublin', '0', '400000'),
('Air 8', 'Australia', 'Melbourne', 'New Zealand', 'Wellington', 'Emirates', '2021-06-22', '12:30:00', '2021-06-20', '21:45:00', 'Melbourne', 'Wellington', '1', '450000'),
('Air 9', 'India', 'Delhi', 'Pakistan', 'Islamabad', 'Sri Lankan Airlines', '2021-05-31', '16:00:00', '2021-05-30', '23:45:00', 'Delhi', 'Islamabad', '0', '150000');

-- --------------------------------------------------------

--
-- Table structure for table `ipmonitor`
--

CREATE TABLE `ipmonitor` (
  `id` int(11) NOT NULL,
  `username` varchar(30) NOT NULL,
  `userip` varchar(50) NOT NULL,
  `logintime` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `ipmonitor`
--

INSERT INTO `ipmonitor` (`id`, `username`, `userip`, `logintime`) VALUES
(118, 'VishG', '0:0:0:0:0:0:0:1', 'Sun May 16 12:09:24 IST 2021'),
(119, 'GagiS', '0:0:0:0:0:0:0:1', 'Sun May 16 12:10:37 IST 2021'),
(120, 'VishG', '0:0:0:0:0:0:0:1', 'Sun May 16 13:05:25 IST 2021'),
(121, 'VishG', '0:0:0:0:0:0:0:1', 'Sun May 16 13:11:57 IST 2021'),
(122, 'VishG', '0:0:0:0:0:0:0:1', 'Sun May 16 13:14:28 IST 2021'),
(123, 'VishG', '0:0:0:0:0:0:0:1', 'Sun May 16 13:17:24 IST 2021'),
(124, 'VishG', '0:0:0:0:0:0:0:1', 'Sun May 16 13:34:09 IST 2021'),
(125, 'VishG', '0:0:0:0:0:0:0:1', 'Sun May 16 13:37:35 IST 2021'),
(126, 'VishG', '0:0:0:0:0:0:0:1', 'Sun May 16 19:11:39 IST 2021'),
(127, 'GagiS', '0:0:0:0:0:0:0:1', 'Sun May 16 19:16:45 IST 2021'),
(128, 'CarlJ', '0:0:0:0:0:0:0:1', 'Sun May 16 19:17:54 IST 2021'),
(129, 'SaggaW', '0:0:0:0:0:0:0:1', 'Sun May 16 19:40:57 IST 2021'),
(130, 'GagiS', '0:0:0:0:0:0:0:1', 'Sun May 16 19:57:54 IST 2021'),
(131, 'VishG', '0:0:0:0:0:0:0:1', 'Sun May 16 20:01:01 IST 2021'),
(132, 'GagiS', '0:0:0:0:0:0:0:1', 'Sun May 16 20:04:58 IST 2021'),
(133, 'GagiS', '0:0:0:0:0:0:0:1', 'Sun May 16 20:07:03 IST 2021'),
(134, 'GagiS', '0:0:0:0:0:0:0:1', 'Sun May 16 20:12:50 IST 2021'),
(135, 'GagiS', '0:0:0:0:0:0:0:1', 'Mon May 17 09:23:25 IST 2021'),
(136, 'GagiS', '0:0:0:0:0:0:0:1', 'Mon May 17 09:23:25 IST 2021'),
(137, 'GagiS', '0:0:0:0:0:0:0:1', 'Mon May 17 09:24:35 IST 2021'),
(138, 'GagiS', '0:0:0:0:0:0:0:1', 'Mon May 17 09:26:44 IST 2021'),
(139, 'GagiS', '0:0:0:0:0:0:0:1', 'Mon May 17 20:03:54 IST 2021'),
(140, 'VishG', '0:0:0:0:0:0:0:1', 'Mon May 17 20:04:35 IST 2021'),
(141, 'CarlJ', '0:0:0:0:0:0:0:1', 'Mon May 17 20:05:53 IST 2021'),
(142, 'SaggaW', '0:0:0:0:0:0:0:1', 'Mon May 17 20:07:15 IST 2021'),
(143, 'GagiS', '0:0:0:0:0:0:0:1', 'Mon May 17 20:13:54 IST 2021'),
(144, 'VishG', '0:0:0:0:0:0:0:1', 'Mon May 17 20:14:15 IST 2021'),
(145, 'CarlJ', '0:0:0:0:0:0:0:1', 'Mon May 17 20:14:34 IST 2021'),
(146, 'GagiS', '0:0:0:0:0:0:0:1', 'Mon May 17 20:14:53 IST 2021'),
(147, 'GagiS', '0:0:0:0:0:0:0:1', 'Mon May 17 20:25:04 IST 2021'),
(148, 'SaggaW', '0:0:0:0:0:0:0:1', 'Mon May 17 20:31:47 IST 2021'),
(149, 'GagiS', '0:0:0:0:0:0:0:1', 'Mon May 17 20:36:52 IST 2021'),
(150, 'GagiS', '0:0:0:0:0:0:0:1', 'Mon May 17 20:36:52 IST 2021'),
(151, 'SaggaW', '0:0:0:0:0:0:0:1', 'Mon May 17 21:46:32 IST 2021'),
(152, 'SaggaW', '0:0:0:0:0:0:0:1', 'Mon May 17 21:54:24 IST 2021'),
(153, 'GagiS', '0:0:0:0:0:0:0:1', 'Mon May 17 22:12:35 IST 2021'),
(154, 'GagiS', '0:0:0:0:0:0:0:1', 'Tue May 18 09:11:44 IST 2021'),
(155, 'Rasika', '0:0:0:0:0:0:0:1', 'Sat Dec 17 12:44:22 IST 2022');

-- --------------------------------------------------------

--
-- Table structure for table `reserve`
--

CREATE TABLE `reserve` (
  `title` varchar(30) NOT NULL,
  `fname` varchar(30) NOT NULL,
  `lname` varchar(30) NOT NULL,
  `type` varchar(20) NOT NULL,
  `email` varchar(30) NOT NULL,
  `telephone` varchar(30) NOT NULL,
  `id` varchar(10) NOT NULL,
  `departcountry` varchar(50) NOT NULL,
  `depcity` varchar(50) NOT NULL,
  `descountry` varchar(50) NOT NULL,
  `descity` varchar(50) NOT NULL,
  `airline` varchar(30) NOT NULL,
  `dated` date NOT NULL,
  `timed` time NOT NULL,
  `seat` varchar(10) NOT NULL,
  `clas` varchar(10) NOT NULL,
  `ticketid` varchar(20) NOT NULL,
  `gate` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `reserve`
--

INSERT INTO `reserve` (`title`, `fname`, `lname`, `type`, `email`, `telephone`, `id`, `departcountry`, `depcity`, `descountry`, `descity`, `airline`, `dated`, `timed`, `seat`, `clas`, `ticketid`, `gate`) VALUES
('MS', 'Gaganie', 'Silva', 'oneway', 'gagis@gmail.com', '0112645224', 'Air 1', 'Sri Lanka', 'Katunayake', 'United States', 'New York', 'Emirates', '2021-06-01', '22:16:00', 'A05', 'first', 'T01', 'Gate A'),
('MS', 'Vishwani', 'Gunapala', 'oneway', 'vishg@gmail.com', '0776225990', 'Air 2', 'Sri Lanka', 'Katunayake', 'Australia', 'Sydney', 'Sri Lankan Airlines', '2021-06-01', '20:42:00', 'A10', 'first', 'T02', 'Gate B');

-- --------------------------------------------------------

--
-- Table structure for table `schat`
--

CREATE TABLE `schat` (
  `email` varchar(30) NOT NULL,
  `schat` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `schat`
--

INSERT INTO `schat` (`email`, `schat`) VALUES
('carlj@gmail.com', 'Reply 3 Staff                                '),
('gagis@gmail.com', 'Reply 1 Staff                               '),
('saggaw@gmail.com', '                                '),
('vishg@gmail.com', 'Reply 2 Staff                                ');

-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

CREATE TABLE `staff` (
  `firstname` varchar(30) NOT NULL,
  `lastname` varchar(30) NOT NULL,
  `email` varchar(30) NOT NULL,
  `password` varchar(10) NOT NULL,
  `gender` varchar(10) NOT NULL,
  `telephone` varchar(15) NOT NULL,
  `stafftype` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `staff`
--

INSERT INTO `staff` (`firstname`, `lastname`, `email`, `password`, `gender`, `telephone`, `stafftype`) VALUES
('Chalaka', 'Nawarathna', 'chalan@gmail.com', '1111', 'male', '0706455180', 'staff1'),
('Donald', 'William', 'donaldw@gmail.com', '0000', 'male', '0115123123', 'staff2'),
('Hiran', 'Karunatilaka', 'hirank@gmail.com', '1111', 'male', '0776154994', 'staff2'),
('Robert', 'Miller', 'robertm@gmail.com', '0000', 'male', '0115645645', 'staff1');

-- --------------------------------------------------------

--
-- Table structure for table `staffipmonitor`
--

CREATE TABLE `staffipmonitor` (
  `id` int(11) NOT NULL,
  `username` varchar(30) NOT NULL,
  `userip` varchar(50) NOT NULL,
  `logintime` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `staffipmonitor`
--

INSERT INTO `staffipmonitor` (`id`, `username`, `userip`, `logintime`) VALUES
(282, 'chalan@gmail.com', '0:0:0:0:0:0:0:1', 'Sun May 16 11:57:26 IST 2021'),
(283, 'hirank@gmail.com', '0:0:0:0:0:0:0:1', 'Sun May 16 12:08:28 IST 2021'),
(284, 'robertm@gmail.com', '0:0:0:0:0:0:0:1', 'Sun May 16 12:17:31 IST 2021'),
(285, 'donaldw@gmail.com', '0:0:0:0:0:0:0:1', 'Sun May 16 12:17:53 IST 2021'),
(286, 'chalan@gmail.com', '0:0:0:0:0:0:0:1', 'Sun May 16 12:36:51 IST 2021'),
(287, 'chalan@gmail.com', '0:0:0:0:0:0:0:1', 'Sun May 16 13:10:08 IST 2021'),
(288, 'chalan@gmail.com', '0:0:0:0:0:0:0:1', 'Sun May 16 13:13:55 IST 2021'),
(289, 'hirank@gmail.com', '0:0:0:0:0:0:0:1', 'Sun May 16 13:20:59 IST 2021'),
(290, 'chalan@gmail.com', '0:0:0:0:0:0:0:1', 'Sun May 16 13:21:42 IST 2021'),
(291, 'chalan@gmail.com', '0:0:0:0:0:0:0:1', 'Sun May 16 13:38:09 IST 2021'),
(292, 'chalan@gmail.com', '0:0:0:0:0:0:0:1', 'Sun May 16 17:15:46 IST 2021'),
(293, 'chalan@gmail.com', '0:0:0:0:0:0:0:1', 'Sun May 16 17:27:39 IST 2021'),
(294, 'chalan@gmail.com', '0:0:0:0:0:0:0:1', 'Sun May 16 19:00:46 IST 2021'),
(295, 'chalan@gmail.com', '0:0:0:0:0:0:0:1', 'Sun May 16 19:05:01 IST 2021'),
(296, 'chalan@gmail.com', '0:0:0:0:0:0:0:1', 'Sun May 16 19:12:51 IST 2021'),
(297, 'chalan@gmail.com', '0:0:0:0:0:0:0:1', 'Sun May 16 19:19:12 IST 2021'),
(298, 'chalan@gmail.com', '0:0:0:0:0:0:0:1', 'Sun May 16 20:03:44 IST 2021'),
(299, 'chalan@gmail.com', '0:0:0:0:0:0:0:1', 'Sun May 16 20:11:28 IST 2021'),
(300, 'chalan@gmail.com', '0:0:0:0:0:0:0:1', 'Mon May 17 09:24:19 IST 2021'),
(301, 'chalan@gmail.com', '0:0:0:0:0:0:0:1', 'Mon May 17 09:25:00 IST 2021'),
(302, 'chalan@gmail.com', '0:0:0:0:0:0:0:1', 'Mon May 17 09:27:13 IST 2021'),
(303, 'chalan@gmail.com', '0:0:0:0:0:0:0:1', 'Mon May 17 19:38:37 IST 2021'),
(304, 'chalan@gmail.com', '0:0:0:0:0:0:0:1', 'Mon May 17 19:42:24 IST 2021'),
(305, 'chalan@gmail.com', '0:0:0:0:0:0:0:1', 'Mon May 17 19:49:44 IST 2021'),
(306, 'chalan@gmail.com', '0:0:0:0:0:0:0:1', 'Mon May 17 20:10:38 IST 2021'),
(307, 'chalan@gmail.com', '0:0:0:0:0:0:0:1', 'Mon May 17 20:17:45 IST 2021'),
(308, 'chalan@gmail.com', '0:0:0:0:0:0:0:1', 'Mon May 17 22:27:05 IST 2021'),
(309, 'chalan@gmail.com', '0:0:0:0:0:0:0:1', 'Tue May 18 07:41:48 IST 2021'),
(310, 'chalan@gmail.com', '0:0:0:0:0:0:0:1', 'Tue May 18 07:54:44 IST 2021'),
(311, 'robertm@gmail.com', '0:0:0:0:0:0:0:1', 'Tue May 18 09:13:38 IST 2021');

-- --------------------------------------------------------

--
-- Table structure for table `stafftracker`
--

CREATE TABLE `stafftracker` (
  `id` int(11) NOT NULL,
  `user` varchar(30) NOT NULL,
  `task` varchar(30) NOT NULL,
  `time` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `stafftracker`
--

INSERT INTO `stafftracker` (`id`, `user`, `task`, `time`) VALUES
(247, 'chalan@gmail.com', 'Added Flight Details', 'May 16, 2021 12:37:10 PM'),
(248, 'chalan@gmail.com', 'Added Flight Details', 'May 16, 2021 12:39:52 PM'),
(249, 'chalan@gmail.com', 'Viewed Flight Details', 'May 16, 2021 12:41:42 PM'),
(250, 'chalan@gmail.com', 'Added Flight Details', 'May 16, 2021 12:41:49 PM'),
(251, 'chalan@gmail.com', 'Added Flight Details', 'May 16, 2021 12:43:19 PM'),
(252, 'chalan@gmail.com', 'Viewed Flight Details', 'May 16, 2021 12:45:53 PM'),
(253, 'chalan@gmail.com', 'Viewed Flight Details', 'May 16, 2021 12:46:40 PM'),
(254, 'chalan@gmail.com', 'Added Flight Details', 'May 16, 2021 12:46:44 PM'),
(255, 'chalan@gmail.com', 'Added Flight Details', 'May 16, 2021 12:48:34 PM'),
(256, 'chalan@gmail.com', 'Added Flight Details', 'May 16, 2021 12:50:31 PM'),
(257, 'chalan@gmail.com', 'Added Flight Details', 'May 16, 2021 12:51:49 PM'),
(258, 'chalan@gmail.com', 'Added Flight Details', 'May 16, 2021 12:53:14 PM'),
(259, 'chalan@gmail.com', 'Viewed Flight Details', 'May 16, 2021 12:55:21 PM'),
(260, 'chalan@gmail.com', 'Added Flight Details', 'May 16, 2021 12:55:32 PM'),
(261, 'chalan@gmail.com', 'Added Flight Details', 'May 16, 2021 12:57:06 PM'),
(262, 'chalan@gmail.com', 'Added Flight Details', 'May 16, 2021 12:58:26 PM'),
(263, 'chalan@gmail.com', 'Viewed Flight Details', 'May 16, 2021 1:00:02 PM'),
(264, 'chalan@gmail.com', 'Added Flight Details', 'May 16, 2021 1:00:36 PM'),
(265, 'chalan@gmail.com', 'Viewed Flight Details', 'May 16, 2021 1:02:18 PM'),
(266, 'chalan@gmail.com', 'Viewed Client Details', 'May 16, 2021 1:03:43 PM'),
(267, 'chalan@gmail.com', 'Viewed Ticket Details', 'May 16, 2021 1:10:19 PM'),
(268, 'chalan@gmail.com', 'Added Ticket Details', 'May 16, 2021 1:11:24 PM'),
(269, 'chalan@gmail.com', 'Viewed Ticket Details', 'May 16, 2021 1:11:50 PM'),
(270, 'chalan@gmail.com', 'Viewed Client Details', 'May 16, 2021 1:14:06 PM'),
(271, 'hirank@gmail.com', 'Viewed Flight Details', 'May 16, 2021 1:21:27 PM'),
(272, 'hirank@gmail.com', 'Viewed Client Details', 'May 16, 2021 1:21:27 PM'),
(273, 'hirank@gmail.com', 'Viewed Ticket Details', 'May 16, 2021 1:21:27 PM'),
(274, 'chalan@gmail.com', 'Viewed Flight Details', 'May 16, 2021 1:21:50 PM'),
(275, 'chalan@gmail.com', 'Updated Flight Details', 'May 16, 2021 1:22:52 PM'),
(276, 'chalan@gmail.com', 'Flight Deleted', 'May 16, 2021 1:24:00 PM'),
(277, 'chalan@gmail.com', 'Viewed Ticket Details', 'May 16, 2021 1:24:59 PM'),
(278, 'chalan@gmail.com', ' Ticket Details Updated', 'May 16, 2021 1:31:16 PM'),
(279, 'Ticket Details Deleted', 'Ticket Details Deleted', 'May 16, 2021 1:32:40 PM'),
(280, 'chalan@gmail.com', 'Viewed Client Details', 'May 16, 2021 1:32:57 PM'),
(281, 'chalan@gmail.com', 'Update Client Details', 'May 16, 2021 1:33:35 PM'),
(282, 'chalan@gmail.com', 'Blocked Client Account', 'May 16, 2021 1:33:49 PM'),
(283, 'chalan@gmail.com', 'Viewed Flight Details', 'May 16, 2021 5:45:10 PM'),
(284, 'chalan@gmail.com', 'Viewed Ticket Details', 'May 16, 2021 8:03:52 PM'),
(285, 'chalan@gmail.com', 'Added Ticket Details', 'May 16, 2021 8:04:03 PM'),
(286, 'chalan@gmail.com', 'Added Ticket Details', 'May 16, 2021 8:04:20 PM'),
(287, 'chalan@gmail.com', 'Viewed Ticket Details', 'May 16, 2021 8:04:30 PM'),
(288, 'chalan@gmail.com', 'Viewed Ticket Details', 'May 16, 2021 8:11:43 PM'),
(289, 'chalan@gmail.com', 'Viewed Flight Details', 'May 17, 2021 9:28:05 AM'),
(290, 'chalan@gmail.com', 'Viewed Ticket Details', 'May 17, 2021 9:28:05 AM'),
(291, 'chalan@gmail.com', 'Viewed Client Details', 'May 17, 2021 9:28:05 AM'),
(292, 'chalan@gmail.com', 'Viewed Flight Details', 'May 17, 2021 7:55:29 PM'),
(293, 'chalan@gmail.com', 'Viewed Ticket Details', 'May 17, 2021 7:55:35 PM'),
(294, 'chalan@gmail.com', 'Viewed Client Details', 'May 17, 2021 7:55:39 PM'),
(295, 'chalan@gmail.com', 'Replied', 'May 17, 2021 8:12:44 PM'),
(296, 'chalan@gmail.com', 'Replied', 'May 17, 2021 8:12:57 PM'),
(297, 'chalan@gmail.com', 'Replied', 'May 17, 2021 8:13:08 PM'),
(298, 'chalan@gmail.com', 'Viewed Flight Details', 'May 17, 2021 10:27:14 PM'),
(299, 'chalan@gmail.com', 'Viewed Flight Details', 'May 17, 2021 10:27:14 PM'),
(300, 'chalan@gmail.com', 'Viewed Flight Details', 'May 17, 2021 10:27:14 PM'),
(301, 'chalan@gmail.com', 'Viewed Flight Details', 'May 17, 2021 10:27:14 PM'),
(302, 'chalan@gmail.com', 'Viewed Flight Details', 'May 17, 2021 10:27:14 PM'),
(303, 'chalan@gmail.com', 'Viewed Flight Details', 'May 18, 2021 7:44:43 AM'),
(304, 'chalan@gmail.com', 'Viewed Ticket Details', 'May 18, 2021 7:44:43 AM'),
(305, 'chalan@gmail.com', 'Viewed Client Details', 'May 18, 2021 7:44:43 AM'),
(306, 'robertm@gmail.com', 'Blocked Client Account', 'May 18, 2021 9:14:22 AM');

-- --------------------------------------------------------

--
-- Table structure for table `teststaff`
--

CREATE TABLE `teststaff` (
  `firstname` varchar(30) NOT NULL,
  `lastname` varchar(30) NOT NULL,
  `email` varchar(50) NOT NULL,
  `password` varchar(20) NOT NULL,
  `gender` varchar(10) NOT NULL,
  `telephone` varchar(15) NOT NULL,
  `stafftype` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `track`
--

CREATE TABLE `track` (
  `id` int(11) NOT NULL,
  `user` varchar(20) NOT NULL,
  `task` varchar(30) NOT NULL,
  `time` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `track`
--

INSERT INTO `track` (`id`, `user`, `task`, `time`) VALUES
(292, 'VishG', 'filterflights', 'May 16, 2021 1:05:47 PM'),
(293, 'VishG', 'filterflights', 'May 16, 2021 1:06:21 PM'),
(294, 'VishG', 'filterflights', 'May 16, 2021 1:06:48 PM'),
(295, 'VishG', 'searchflight', 'May 16, 2021 1:08:57 PM'),
(296, 'VishG', 'searchflight', 'May 16, 2021 1:08:57 PM'),
(297, 'VishG', 'searchflight', 'May 16, 2021 1:08:57 PM'),
(298, 'VishG', 'Sent A Message', 'May 16, 2021 1:08:57 PM'),
(299, 'VishG', 'ticketsearch', 'May 16, 2021 1:12:08 PM'),
(300, 'VishG', 'usededitdaccount', 'May 16, 2021 1:12:32 PM'),
(301, 'VishG', 'updateaccount', 'May 16, 2021 1:13:09 PM'),
(302, 'VishG', 'used edit reservation', 'May 16, 2021 1:14:34 PM'),
(303, 'VishG', 'Reservation Updated', 'May 16, 2021 1:15:25 PM'),
(304, 'VishG', 'used edit reservation', 'May 16, 2021 1:16:27 PM'),
(305, 'VishG', 'usededitdaccount', 'May 16, 2021 1:17:00 PM'),
(306, 'VishG', 'usededitdaccount', 'May 16, 2021 1:36:21 PM'),
(307, 'VishG', 'updateaccount', 'May 16, 2021 1:36:38 PM'),
(308, 'VishG', 'Message Checked', 'May 16, 2021 7:12:05 PM'),
(309, 'GagiS', 'Sent A Message', 'May 16, 2021 7:16:52 PM'),
(310, 'CarlJ', 'Sent A Message', 'May 16, 2021 7:18:03 PM'),
(311, 'GagiS', 'filterflights', 'May 16, 2021 7:58:12 PM'),
(312, 'VishG', 'filterflights', 'May 16, 2021 7:58:12 PM'),
(313, 'GagiS', 'ticketsearch', 'May 16, 2021 8:05:09 PM'),
(314, 'GagiS', 'ticketsearch', 'May 16, 2021 8:05:27 PM'),
(315, 'GagiS', 'Message Checked', 'May 16, 2021 8:05:35 PM'),
(316, 'GagiS', 'Message Checked', 'May 16, 2021 8:05:49 PM'),
(317, 'GagiS', 'Sent A Message', 'May 16, 2021 8:07:09 PM'),
(318, 'GagiS', 'Message Checked', 'May 16, 2021 8:12:56 PM'),
(319, 'GagiS', 'Sent A Message', 'May 17, 2021 9:24:40 AM'),
(320, 'GagiS', 'Message Checked', 'May 17, 2021 9:26:54 AM'),
(321, 'GagiS', 'Sent A Message', 'May 17, 2021 8:04:01 PM'),
(322, 'VishG', 'Sent A Message', 'May 17, 2021 8:04:50 PM'),
(323, 'CarlJ', 'Sent A Message', 'May 17, 2021 8:06:05 PM'),
(324, 'SaggaW', 'Sent A Message', 'May 17, 2021 8:07:23 PM'),
(325, 'GagiS', 'Message Checked', 'May 17, 2021 8:13:59 PM'),
(326, 'VishG', 'Message Checked', 'May 17, 2021 8:14:23 PM'),
(327, 'CarlJ', 'Message Checked', 'May 17, 2021 8:14:41 PM'),
(328, 'GagiS', 'Message Checked', 'May 17, 2021 8:14:57 PM'),
(329, 'GagiS', 'Sent A Message', 'May 17, 2021 8:15:07 PM'),
(330, 'GagiS', 'filterflights', 'May 17, 2021 8:27:51 PM'),
(331, 'GagiS', 'searchflight', 'May 17, 2021 8:27:26 PM'),
(332, 'GagiS', 'ticketsearch', 'May 17, 2021 8:28:52 PM'),
(333, 'GagiS', 'searchflight', 'May 17, 2021 8:27:26 PM'),
(334, 'GagiS', 'searchflight', 'May 17, 2021 9:27:26 PM'),
(335, 'GagiS', 'searchflight', 'May 17, 2021 9:27:26 PM'),
(336, 'GagiS', 'searchflight', 'May 17, 2021 9:27:26 PM'),
(337, 'GagiS', 'searchflight', 'May 17, 2021 9:27:26 PM'),
(338, 'GagiS', 'searchflight', 'May 17, 2021 9:27:26 PM'),
(339, 'GagiS', 'ticketsearch', 'May 17, 2021 9:42:01 PM'),
(340, 'GagiS', 'searchflight', 'May 17, 2021 9:42:21 PM'),
(341, 'GagiS', 'ticketsearch', 'May 17, 2021 9:42:41 PM'),
(342, 'GagiS', 'ticketsearch', 'May 17, 2021 9:42:41 PM'),
(343, 'GagiS', 'ticketsearch', 'May 17, 2021 9:44:23 PM'),
(344, 'GagiS', 'ticketsearch', 'May 17, 2021 9:44:23 PM'),
(345, 'GagiS', 'ticketsearch', 'May 17, 2021 9:44:23 PM'),
(346, 'GagiS', 'ticketsearch', 'May 17, 2021 9:44:23 PM'),
(347, 'GagiS', 'searchflight', 'May 17, 2021 9:46:11 PM'),
(348, 'SaggaW', 'usededitdaccount', 'May 17, 2021 9:46:38 PM'),
(349, 'SaggaW', 'usededitdaccount', 'May 17, 2021 9:46:38 PM'),
(350, 'SaggaW', 'usededitdaccount', 'May 17, 2021 9:46:38 PM'),
(351, 'SaggaW', 'usededitdaccount', 'May 17, 2021 9:46:38 PM'),
(352, 'SaggaW', 'searchflight', 'May 17, 2021 9:55:30 PM'),
(353, 'SaggaW', 'usededitdaccount', 'May 17, 2021 9:55:30 PM'),
(354, 'GagiS', 'used edit reservation', 'May 17, 2021 10:12:40 PM'),
(355, 'GagiS', 'used edit reservation', 'May 17, 2021 10:12:40 PM'),
(356, 'GagiS', 'used edit reservation', 'May 17, 2021 10:12:40 PM'),
(357, 'GagiS', 'used edit reservation', 'May 17, 2021 10:12:40 PM'),
(358, 'GagiS', 'used edit reservation', 'May 17, 2021 10:12:40 PM'),
(359, 'GagiS', 'used edit reservation', 'May 17, 2021 10:12:40 PM'),
(360, 'GagiS', 'used edit reservation', 'May 17, 2021 10:12:40 PM'),
(361, 'GagiS', 'used edit reservation', 'May 17, 2021 10:12:40 PM'),
(362, 'GagiS', 'used edit reservation', 'May 17, 2021 10:12:40 PM'),
(363, 'GagiS', 'used edit reservation', 'May 17, 2021 10:12:40 PM'),
(364, 'GagiS', 'used edit reservation', 'May 17, 2021 10:12:40 PM'),
(365, 'GagiS', 'used edit reservation', 'May 17, 2021 10:12:40 PM'),
(366, 'GagiS', 'usededitdaccount', 'May 17, 2021 10:12:40 PM'),
(367, 'GagiS', 'used edit reservation', 'May 17, 2021 10:12:40 PM'),
(368, 'chalan@gmail.com', 'Viewed Client Dashboard', 'May 18, 2021 8:23:29 AM');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`userid`);

--
-- Indexes for table `blocked`
--
ALTER TABLE `blocked`
  ADD PRIMARY KEY (`email`),
  ADD UNIQUE KEY `username` (`username`),
  ADD UNIQUE KEY `email` (`email`);

--
-- Indexes for table `chat`
--
ALTER TABLE `chat`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `email` (`email`);

--
-- Indexes for table `client`
--
ALTER TABLE `client`
  ADD PRIMARY KEY (`email`),
  ADD UNIQUE KEY `email` (`email`),
  ADD UNIQUE KEY `username` (`username`);

--
-- Indexes for table `flight`
--
ALTER TABLE `flight`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `ipmonitor`
--
ALTER TABLE `ipmonitor`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `reserve`
--
ALTER TABLE `reserve`
  ADD PRIMARY KEY (`email`);

--
-- Indexes for table `schat`
--
ALTER TABLE `schat`
  ADD PRIMARY KEY (`email`);

--
-- Indexes for table `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`email`);

--
-- Indexes for table `staffipmonitor`
--
ALTER TABLE `staffipmonitor`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `stafftracker`
--
ALTER TABLE `stafftracker`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `teststaff`
--
ALTER TABLE `teststaff`
  ADD PRIMARY KEY (`email`);

--
-- Indexes for table `track`
--
ALTER TABLE `track`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `chat`
--
ALTER TABLE `chat`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=57;

--
-- AUTO_INCREMENT for table `ipmonitor`
--
ALTER TABLE `ipmonitor`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=156;

--
-- AUTO_INCREMENT for table `staffipmonitor`
--
ALTER TABLE `staffipmonitor`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=312;

--
-- AUTO_INCREMENT for table `stafftracker`
--
ALTER TABLE `stafftracker`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=307;

--
-- AUTO_INCREMENT for table `track`
--
ALTER TABLE `track`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=369;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
