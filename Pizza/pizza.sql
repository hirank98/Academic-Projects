-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 10, 2022 at 12:45 AM
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
-- Database: `pizza`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `userid` varchar(20) NOT NULL,
  `password` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`userid`, `password`) VALUES
('admin1', 'admin123');

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE `orders` (
  `orderid` int(11) NOT NULL,
  `firstname` varchar(15) NOT NULL,
  `lastname` varchar(30) NOT NULL,
  `address` varchar(100) NOT NULL,
  `telephone` varchar(11) NOT NULL,
  `type` varchar(20) NOT NULL,
  `size` varchar(10) NOT NULL,
  `quantity` varchar(11) NOT NULL,
  `price` varchar(11) NOT NULL,
  `orderdate` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`orderid`, `firstname`, `lastname`, `address`, `telephone`, `type`, `size`, `quantity`, `price`, `orderdate`) VALUES
(1, 'Bruce', 'Wayne', 'xx', '+2729729', 'BBQ Chicken', 'large', '2', '2500', ''),
(2, 'chalaka', 'Wayne', '96,waraketiya road, mahragaama', '+23455543', 'Veggie', 'large', '2', '2500', ''),
(3, 'chalaka', 'admin1', '96,waraketiya road, mahragaama', '+23455543', 'BBQ Chicken', 'small', '2', '1500', ''),
(4, 'telephone', 'Wayne', '96,waraketiya road, mahragaama', '+23455543', 'Cuttlefish', 'large', '9', '11250', ''),
(5, 'chalaka', 'admin1', '96,waraketiya road, mahragaama', '+23455543', 'Veggie', 'large', '9', '11250', ''),
(6, 'chalaka', 'Wayne', '96,waraketiya road, mahragaama.', '+23455543', 'Sausage', 'small', '5', '3750', ''),
(7, 'chalaka', 'Wayne', 'ewewe', '+23455543', 'BBQ Chicken', 'large', '2', '2500', ''),
(8, 'chalaka', 'Wayne', 'dadadd', '+23455543', 'Veggie', 'large', '2', '2500', ''),
(9, 'chalaka', 'Wayne', 'dwdwdwfdw', '+23455543', 'Sausage', 'large', '9', '11250', ''),
(10, 'chalaka', 'Wayne', 'qwqwqwqwq', '+23455543', 'BBQ Chicken', 'large', '5', '6250', ''),
(11, 'chalaka', 'Wayne', 'dsdsdsd', '+23455543', 'Cheese', 'large', '2', '2500', ''),
(12, 'chalaka', 'Wayne', '1ssas', '+23455543', 'Cheese', 'large', '2', '2500', ''),
(2020, 'chalaka', 'Wayne', '1ssas', '+23455543', 'Cheese', 'large', '2', '2500', ''),
(2021, 'chalaka', 'Wayne', '1ssas', '+23455543', 'Cheese', 'large', '2', '2500', ''),
(2022, 'telephone', 'Wayne', '96,waraketiya road, mahragaama', '+23455543', 'Cuttlefish', 'large', '9', '11250', ''),
(2023, 'chalaka', 'Wayne', '96,waraketiya road, mahragaama', '+23455543', 'Veggie', 'large', '2', '2500', ''),
(2024, 'chalaka', 'Wayne', 'dsdsdsd', '+23455543', 'Cheese', 'large', '2', '2500', ''),
(2025, 'chalaka', 'Wayne', 'dwdwdwfdw', '+23455543', 'Sausage', 'large', '9', '11250', ''),
(2026, 'chalaka', 'Wayne', '1ssas', '+23455543', 'Cheese', 'large', '2', '2500', ''),
(2027, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'BBQ Chicken', 'large', '2', '2500', ''),
(2028, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'BBQ Chicken', 'large', '2', '2500', ''),
(2029, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'BBQ Chicken', 'large', '2', '2500', ''),
(2030, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'BBQ Chicken', 'large', '2', '2500', ''),
(2031, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'BBQ Chicken', 'large', '2', '2500', ''),
(2032, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'BBQ Chicken', 'large', '2', '2500', ''),
(2033, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'BBQ Chicken', 'large', '2', '2500', ''),
(2034, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'BBQ Chicken', 'large', '2', '2500', ''),
(2035, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'BBQ Chicken', 'large', '2', '2500', ''),
(2036, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'BBQ Chicken', 'large', '2', '2500', ''),
(2037, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'BBQ Chicken', 'large', '2', '2500', ''),
(2038, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'BBQ Chicken', 'large', '2', '2500', ''),
(2039, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'BBQ Chicken', 'large', '2', '2500', ''),
(2040, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'BBQ Chicken', 'large', '2', '2500', ''),
(2041, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'BBQ Chicken', 'large', '2', '2500', ''),
(2042, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'BBQ Chicken', 'large', '2', '2500', ''),
(2043, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'BBQ Chicken', 'large', '2', '2500', ''),
(2044, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'BBQ Chicken', 'large', '2', '2500', ''),
(2045, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'BBQ Chicken', 'large', '2', '2500', ''),
(2046, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'BBQ Chicken', 'large', '2', '2500', ''),
(2047, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'BBQ Chicken', 'large', '2', '2500', ''),
(2048, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'BBQ Chicken', 'large', '2', '2500', ''),
(2049, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'BBQ Chicken', 'large', '2', '2500', ''),
(2050, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'BBQ Chicken', 'large', '2', '2500', ''),
(2051, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'Veggie', 'large', '2', '2500', ''),
(2052, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'BBQ Chicken', 'large', '2', '2500', ''),
(2053, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'Sausage', 'large', '2', '2500', ''),
(2054, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'Sausage', 'large', '2', '2500', ''),
(2055, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'Sausage', 'large', '2', '2500', ''),
(2056, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'Sausage', 'large', '2', '2500', ''),
(2057, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'Cuttlefish', 'large', '2', '2500', ''),
(2058, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'Cuttlefish', 'large', '2', '2500', ''),
(2059, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'Cuttlefish', 'large', '2', '2500', ''),
(2060, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'Cheese', 'large', '2', '2500', ''),
(2061, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'Cheese', 'large', '2', '2500', ''),
(2062, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'Cheese', 'large', '2', '2500', ''),
(2063, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'Cheese', 'large', '2', '2500', ''),
(2064, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'Cheese', 'large', '2', '2500', ''),
(2065, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'Sausage', 'large', '2', '2500', ''),
(2066, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'Sausage', 'large', '2', '2500', ''),
(2067, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'Sausage', 'large', '2', '2500', ''),
(2068, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'Sausage', 'large', '2', '2500', ''),
(2069, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'BBQ Chicken', 'large', '2', '2500', ''),
(2070, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'BBQ Chicken', 'large', '2', '2500', ''),
(2071, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'Sausage', 'large', '2', '2500', ''),
(2072, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'Sausage', 'large', '2', '2500', ''),
(2073, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'Sausage', 'large', '2', '2500', ''),
(2074, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'Veggie', 'large', '2', '2500', ''),
(2075, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'Veggie', 'large', '2', '2500', ''),
(2076, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'Cuttlefish', 'large', '2', '2500', ''),
(2077, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'Cuttlefish', 'large', '2', '2500', ''),
(2078, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'Cuttlefish', 'large', '2', '2500', ''),
(2079, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'Cuttlefish', 'large', '2', '2500', ''),
(2080, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'BBQ Chicken', 'large', '2', '2500', ''),
(2081, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'BBQ Chicken', 'large', '2', '2500', ''),
(2082, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'BBQ Chicken', 'large', '2', '2500', ''),
(2083, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'Sausage', 'large', '2', '2500', ''),
(2084, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'Sausage', 'large', '2', '2500', ''),
(2085, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'Cheese', 'large', '2', '2500', ''),
(2086, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'Cheese', 'large', '2', '2500', ''),
(2087, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'Cheese', 'large', '2', '2500', ''),
(2088, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'Veggie', 'large', '2', '2500', ''),
(2089, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'Veggie', 'large', '2', '2500', ''),
(2090, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'Cuttlefish', 'large', '2', '2500', ''),
(2091, 'chalaka', 'Wayne', '75,new road,mahraama', '+23455543', 'Cuttlefish', 'large', '2', '2500', ''),
(2092, 'Chalaka', 'Bandara', '75,new road,mahraama', '+23455543', 'Cuttlefish', 'large', '2', '2500', ''),
(2093, 'Chalaka', 'Bandara', '75,new road,mahraama', '+23455543', 'Sausage', 'large', '2', '2500', ''),
(2094, 'Chalaka', 'Bandara', '75,new road,mahraama', '+23455543', 'Sausage', 'small', '2', '1500', ''),
(2095, 'Chalaka', 'Bandara', '75,new road,mahraamyya', '+23455543', 'Sausage', 'small', '2', '1500', ''),
(2096, 'Chalaka', 'Bandara', '75,new road,mahraamyya', '+23455543', 'Veggie', 'small', '2', '1500', ''),
(2097, 'Chalaka', 'Bandara', '75,new road,mahraamyya', '+23455543', 'Cheese', 'small', '2', '1500', ''),
(2098, 'Chalaka', 'Bandara', '75,new road,mahraamyya', '+23455543', 'Cuttlefish', 'small', '2', '1500', ''),
(2099, 'Chalaka', 'Bandara', '75,new road,mahraamyya', '+23455543', 'Cuttlefish', 'small', '2', '1500', ''),
(2100, 'Chalaka', 'Bandara', '75,new road,mahraamyya', '+23455543', 'BBQ Chicken', 'small', '2', '1500', ''),
(2101, 'Chalaka', 'Bandara', '75,new road,mahraamyya', '+23455543', 'BBQ Chicken', 'small', '2', '1500', ''),
(2102, 'Bruce', 'Wayne', '75,new road,mahraamyya', '+2729729', 'Sausage', 'large', '2', '2500', ''),
(2104, 'Bruce', 'Wayne', '75,new road,mahraamyya', '+2729729', 'BBQ Chicken', 'small', '2', '1500', ''),
(2105, 'Bruce', 'Wayne', '75,new road,mahraamyya', '+2729729', 'BBQ Chicken', 'large', '2', '2500', ''),
(2106, 'Bruce', 'Wayne', '75,new road,mahraamyya', '+2729729', 'BBQ Chicken', 'large', '2', '2500', ''),
(2107, 'Bruce', 'Wayne', '75,new road,mahraamyya', '+2729729', 'Cheese', 'large', '2', '2500', ''),
(2108, 'Bruce', 'Wayne', '75,new road,mahraamyya', '+2729729', 'Cheese', 'small', '2', '1500', ''),
(2109, 'Bruce', 'Wayne', '75,new road,mahraamyya', '+2729729', 'Veggie', 'small', '2', '1500', ''),
(2110, 'Bruce', 'Wayne', '75,new road,mahraamyya', '+2729729', 'Veggie', 'large', '2', '2500', ''),
(2111, 'Bruce', 'Wayne', '75,new road,mahraamyya', '+2729729', 'Cuttlefish', 'large', '2', '2500', ''),
(2112, 'Bruce', 'Wayne', '75,new road,mahraamyya', '+2729729', 'Cuttlefish', 'small', '2', '1500', ''),
(2115, 'Bruce', 'Wayne', 'SsSsSsSsSs', '+2729729', 'Cheese', 'large', '12', '15000', 'Mar 9, 2022 5:58:49 PM');

-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

CREATE TABLE `staff` (
  `staffid` int(11) NOT NULL,
  `fname` varchar(15) NOT NULL,
  `sname` varchar(20) NOT NULL,
  `email` varchar(50) NOT NULL,
  `password` varchar(10) NOT NULL,
  `dob` date NOT NULL,
  `gender` varchar(6) NOT NULL,
  `nic` varchar(15) NOT NULL,
  `telephone` varchar(11) NOT NULL,
  `type` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `staff`
--

INSERT INTO `staff` (`staffid`, `fname`, `sname`, `email`, `password`, `dob`, `gender`, `nic`, `telephone`, `type`) VALUES
(1001, 'chalaka', 'admin1', 'emma@gmail.com', 'admin123', '2022-03-02', 'male', '1111111', '+23455543', 'Chef');

-- --------------------------------------------------------

--
-- Table structure for table `staffmonitor`
--

CREATE TABLE `staffmonitor` (
  `number` int(11) NOT NULL,
  `staffid` varchar(10) NOT NULL,
  `logintime` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `staffmonitor`
--

INSERT INTO `staffmonitor` (`number`, `staffid`, `logintime`) VALUES
(1, '1001', 'Tue Mar 08 18:13:35 IST 2022'),
(2, '1001', 'Tue Mar 08 21:53:37 IST 2022'),
(3, '1001', 'Tue Mar 08 21:56:43 IST 2022'),
(4, '1001', 'Tue Mar 08 22:07:22 IST 2022'),
(5, '1001', 'Tue Mar 08 22:07:22 IST 2022'),
(6, '1001', 'Tue Mar 08 22:13:38 IST 2022'),
(7, '1001', 'Wed Mar 09 20:57:57 IST 2022');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`userid`);

--
-- Indexes for table `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`orderid`);

--
-- Indexes for table `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`staffid`),
  ADD UNIQUE KEY `email` (`email`);

--
-- Indexes for table `staffmonitor`
--
ALTER TABLE `staffmonitor`
  ADD PRIMARY KEY (`number`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `orders`
--
ALTER TABLE `orders`
  MODIFY `orderid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2116;

--
-- AUTO_INCREMENT for table `staff`
--
ALTER TABLE `staff`
  MODIFY `staffid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1002;

--
-- AUTO_INCREMENT for table `staffmonitor`
--
ALTER TABLE `staffmonitor`
  MODIFY `number` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
