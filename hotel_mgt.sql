-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Dec 23, 2017 at 02:02 PM
-- Server version: 10.1.16-MariaDB
-- PHP Version: 5.6.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hotel_mgt`
--

-- --------------------------------------------------------

--
-- Table structure for table `charges`
--

CREATE TABLE `charges` (
  `checkin_id` int(4) NOT NULL,
  `transaction_code` int(11) NOT NULL,
  `date_posted` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `amount` float(10,2) NOT NULL,
  `register_account` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `check_in`
--

CREATE TABLE `check_in` (
  `checkin_id` int(11) NOT NULL,
  `guest_id` int(4) NOT NULL,
  `room_num` varchar(3) NOT NULL,
  `checkin_date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `expected_checkout` date NOT NULL,
  `register_account` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `check_out`
--

CREATE TABLE `check_out` (
  `checkin_id` int(11) DEFAULT NULL,
  `checkout_date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `balance` float(10,2) NOT NULL,
  `register_account` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `front_desk`
--

CREATE TABLE `front_desk` (
  `register_account` varchar(15) NOT NULL,
  `password` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `front_desk`
--

INSERT INTO `front_desk` (`register_account`, `password`) VALUES
('admin', '123'),
('admin2', '4321');

-- --------------------------------------------------------

--
-- Table structure for table `guest`
--

CREATE TABLE `guest` (
  `guest_id` int(4) NOT NULL,
  `lname` varchar(30) NOT NULL,
  `fname` varchar(30) NOT NULL,
  `title` varchar(3) NOT NULL,
  `gender` char(15) NOT NULL,
  `citizenship` varchar(20) NOT NULL,
  `status` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `guest`
--

INSERT INTO `guest` (`guest_id`, `lname`, `fname`, `title`, `gender`, `citizenship`, `status`) VALUES
(1, 'Kim', 'Namjoon', 'Mr', 'M', 'Korean', 'checked-out'),
(2, 'Zhang', 'Yixing', 'Mr', 'M', 'Chinese', 'checked-out'),
(3, 'Romanov', 'Christian ', 'Mr', 'M', 'German', 'checked-out'),
(4, 'Young', 'Gian Andre', 'Mr', 'M', 'Chinese', 'checked-out'),
(5, 'Lancaster', 'Hazel Grace', 'Ms', 'F', 'American', 'checked-out'),
(6, 'Ababao', 'James', 'Mr.', 'M', 'Filipino', 'checked-out'),
(7, 'Butler', 'Austin', 'Mr.', 'M', 'American', 'checked-out'),
(8, 'Jung ', 'Eunji', 'Ms.', 'F', 'Korean', 'checked-out'),
(9, 'Perez', 'Richmond Matthew', 'Mr.', 'M', 'Filipino', 'checked-out'),
(10, 'Kim', 'Sejeong', 'Ms.', 'F', 'Korean', 'checked-out'),
(11, 'Son', 'Wendy', 'Ms', 'F', 'Japanese', 'checked-in'),
(12, 'Mercader', 'Fraulien', 'Ms', 'F', 'Filipino', 'checked-in'),
(13, 'Talisaysay', 'Kent', 'Mr', 'M', 'American', 'checked-in'),
(14, 'Seva', 'Raffy', 'Mr.', 'M', 'Filipino', 'checked-out'),
(15, 'Mozo', 'Marianne', 'Ms.', 'F', 'Filipino', 'checked-out'),
(16, 'Quisido', 'Devorah', 'Ms.', 'F', 'Filipino', 'checked-out'),
(17, 'Mendes', 'Shawn', 'Mr.', 'M', 'Canadian', 'checked-out'),
(18, 'Valjean', 'Jean', 'Mr.', 'M', 'French', 'checked-out'),
(19, 'Lodge', 'Veronica', 'Ms.', 'F', 'American', 'checked-out'),
(20, 'Sprouse', 'Cole', 'Mr.', 'M', 'American', 'checked-out'),
(21, 'Genelsa', 'June', 'Mr', 'M', 'Filipino', 'checked-in'),
(22, 'Avergonzado', 'Danica', 'Ms', 'F', 'Filipino', 'checked-out'),
(23, 'Qwer', 'Ewrt', 'Ms', 'F', 'wer', 'checked-in'),
(24, 'Asdf', 'Sdfg', 'Mr', 'F', 'Sdfg', 'checked-in');

-- --------------------------------------------------------

--
-- Table structure for table `reservation`
--

CREATE TABLE `reservation` (
  `lname` varchar(30) NOT NULL,
  `fname` varchar(30) NOT NULL,
  `room_num` varchar(3) NOT NULL,
  `check_in` date NOT NULL,
  `check_out` date NOT NULL,
  `remarks` varchar(30) DEFAULT NULL,
  `register_account` varchar(15) NOT NULL,
  `time_stamp` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `reservation`
--

INSERT INTO `reservation` (`lname`, `fname`, `room_num`, `check_in`, `check_out`, `remarks`, `register_account`, `time_stamp`) VALUES
('Kim', 'Namjoon', '102', '2017-03-20', '2017-03-21', 'extra pillows', 'admin', '2017-03-18 22:21:46'),
('Smith', 'Hazel', '201', '2017-03-21', '2017-03-22', NULL, 'admin', '2017-03-18 22:24:45'),
('Wu', 'Kris', '303', '2017-03-22', '2017-03-24', NULL, 'admin', '2017-03-18 22:25:35'),
('Lincoln', 'James', '202', '2017-03-23', '2017-03-24', NULL, 'admin', '2017-03-18 22:26:48'),
('Karquiova', 'Akiesha', '101', '2017-03-23', '2017-03-24', NULL, 'admin', '2017-03-18 22:27:59'),
('Mendoza', 'Jazin', '101', '2017-03-27', '2017-04-01', NULL, 'admin', '2017-03-19 13:10:28'),
('Quisido', 'Devorah', '101', '2017-04-06', '2017-04-11', NULL, 'admin2', '2017-03-20 00:39:57'),
('Mendoza', 'Jazin', '201', '2017-03-28', '2017-04-02', 'extra pillows', 'admin', '2017-03-20 02:47:07');

-- --------------------------------------------------------

--
-- Table structure for table `room`
--

CREATE TABLE `room` (
  `room_num` varchar(3) NOT NULL,
  `room_type` int(11) NOT NULL,
  `regular_price` float(10,2) NOT NULL,
  `pax` int(15) NOT NULL,
  `floor` int(11) NOT NULL,
  `room_status` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `room`
--

INSERT INTO `room` (`room_num`, `room_type`, `regular_price`, `pax`, `floor`, `room_status`) VALUES
('101', 0, 1500.00, 2, 1, 0),
('105', 1, 2500.00, 4, 1, 0),
('201', 1, 2500.00, 4, 2, 0),
('202', 3, 3500.00, 6, 2, 0);

-- --------------------------------------------------------

--
-- Table structure for table `transactions`
--

CREATE TABLE `transactions` (
  `transaction_code` int(4) NOT NULL,
  `transaction_name` varchar(30) NOT NULL,
  `govt_tax` decimal(10,2) NOT NULL,
  `accting_side` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `transactions`
--

INSERT INTO `transactions` (`transaction_code`, `transaction_name`, `govt_tax`, `accting_side`) VALUES
(1000, 'Room Charge', '12.00', 'Debit'),
(1001, 'Extra Bed', '12.00', 'Debit'),
(1002, 'Early Check-in Fee', '12.00', 'Debit'),
(1003, 'Room Accommodation Diplomat', '0.00', 'Debit'),
(1004, 'Late Check-out Fee', '12.00', 'Debit'),
(1005, 'Cash Payment', '0.00', 'Credit'),
(1006, 'Credit Card Payment', '0.00', 'Credit'),
(1007, 'Food and Beverage', '12.00', 'Debit');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `charges`
--
ALTER TABLE `charges`
  ADD PRIMARY KEY (`date_posted`),
  ADD KEY `guest_id` (`checkin_id`),
  ADD KEY `register_account` (`register_account`),
  ADD KEY `transaction_code` (`transaction_code`);

--
-- Indexes for table `check_in`
--
ALTER TABLE `check_in`
  ADD PRIMARY KEY (`checkin_id`),
  ADD KEY `guest_id` (`guest_id`),
  ADD KEY `room_num` (`room_num`),
  ADD KEY `guest_id_2` (`guest_id`),
  ADD KEY `room_num_2` (`room_num`),
  ADD KEY `guest_id_3` (`guest_id`),
  ADD KEY `register_account` (`register_account`),
  ADD KEY `checkin_date` (`checkin_date`);

--
-- Indexes for table `check_out`
--
ALTER TABLE `check_out`
  ADD PRIMARY KEY (`checkout_date`),
  ADD KEY `checkin_date` (`checkin_id`),
  ADD KEY `register_account` (`register_account`);

--
-- Indexes for table `front_desk`
--
ALTER TABLE `front_desk`
  ADD PRIMARY KEY (`register_account`);

--
-- Indexes for table `guest`
--
ALTER TABLE `guest`
  ADD PRIMARY KEY (`guest_id`),
  ADD UNIQUE KEY `guest_id` (`guest_id`);

--
-- Indexes for table `reservation`
--
ALTER TABLE `reservation`
  ADD KEY `register_account` (`register_account`);

--
-- Indexes for table `room`
--
ALTER TABLE `room`
  ADD PRIMARY KEY (`room_num`),
  ADD UNIQUE KEY `room_num` (`room_num`);

--
-- Indexes for table `transactions`
--
ALTER TABLE `transactions`
  ADD PRIMARY KEY (`transaction_code`),
  ADD KEY `transaction_name` (`transaction_name`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `check_in`
--
ALTER TABLE `check_in`
  MODIFY `checkin_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=373;
--
-- AUTO_INCREMENT for table `guest`
--
ALTER TABLE `guest`
  MODIFY `guest_id` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `charges`
--
ALTER TABLE `charges`
  ADD CONSTRAINT `charges_ibfk_1` FOREIGN KEY (`checkin_id`) REFERENCES `check_in` (`checkin_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `charges_ibfk_2` FOREIGN KEY (`register_account`) REFERENCES `front_desk` (`register_account`),
  ADD CONSTRAINT `charges_ibfk_3` FOREIGN KEY (`transaction_code`) REFERENCES `transactions` (`transaction_code`);

--
-- Constraints for table `check_in`
--
ALTER TABLE `check_in`
  ADD CONSTRAINT `check_in_ibfk_3` FOREIGN KEY (`register_account`) REFERENCES `front_desk` (`register_account`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `check_in_ibfk_4` FOREIGN KEY (`guest_id`) REFERENCES `guest` (`guest_id`),
  ADD CONSTRAINT `check_in_ibfk_5` FOREIGN KEY (`room_num`) REFERENCES `room` (`room_num`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `check_out`
--
ALTER TABLE `check_out`
  ADD CONSTRAINT `check_out_ibfk_5` FOREIGN KEY (`register_account`) REFERENCES `front_desk` (`register_account`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `check_out_ibfk_7` FOREIGN KEY (`checkin_id`) REFERENCES `check_in` (`checkin_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `reservation`
--
ALTER TABLE `reservation`
  ADD CONSTRAINT `reservation_ibfk_1` FOREIGN KEY (`register_account`) REFERENCES `front_desk` (`register_account`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
