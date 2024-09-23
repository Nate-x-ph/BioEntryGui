-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 21, 2024 at 07:20 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bioentry`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `admin_id` int(11) UNSIGNED NOT NULL,
  `user_id` int(11) UNSIGNED NOT NULL,
  `fname` varchar(100) NOT NULL,
  `mname` varchar(100) DEFAULT NULL,
  `lname` varchar(100) NOT NULL,
  `gender` varchar(100) NOT NULL,
  `age` int(11) NOT NULL,
  `birthday` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`admin_id`, `user_id`, `fname`, `mname`, `lname`, `gender`, `age`, `birthday`) VALUES
(1, 1, 'Dominic', 'Volante', 'Ama', 'Male', 23, '2000-09-29');

-- --------------------------------------------------------

--
-- Table structure for table `classlist`
--

CREATE TABLE `classlist` (
  `clist_id` int(11) UNSIGNED NOT NULL,
  `faculty_id` int(11) UNSIGNED NOT NULL,
  `subject_id` int(11) UNSIGNED NOT NULL,
  `class_section` varchar(100) NOT NULL,
  `school_year` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `classlist`
--

INSERT INTO `classlist` (`clist_id`, `faculty_id`, `subject_id`, `class_section`, `school_year`) VALUES
(1, 1, 1, 'BSIT-4B', '2024');

-- --------------------------------------------------------

--
-- Table structure for table `events`
--

CREATE TABLE `events` (
  `event_id` int(5) UNSIGNED NOT NULL,
  `title` varchar(100) NOT NULL,
  `start_date` datetime NOT NULL,
  `end_date` datetime NOT NULL,
  `description` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `faculty`
--

CREATE TABLE `faculty` (
  `faculty_id` int(11) UNSIGNED NOT NULL,
  `user_id` int(11) UNSIGNED NOT NULL,
  `fname` varchar(100) NOT NULL,
  `mname` varchar(100) DEFAULT NULL,
  `lname` varchar(100) NOT NULL,
  `gender` varchar(100) NOT NULL,
  `age` int(11) NOT NULL,
  `birthday` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `faculty`
--

INSERT INTO `faculty` (`faculty_id`, `user_id`, `fname`, `mname`, `lname`, `gender`, `age`, `birthday`) VALUES
(1, 2, 'Nick', 'Volante', 'Ama', 'Male', 23, '2000-09-29'),
(2, 3, 'Romel', 'Hernandez', 'Peralta', 'Male', 22, '2002-01-30');

-- --------------------------------------------------------

--
-- Table structure for table `faculty_log`
--

CREATE TABLE `faculty_log` (
  `flog_id` int(11) UNSIGNED NOT NULL,
  `faculty_id` int(11) UNSIGNED NOT NULL,
  `schedule_id` int(11) UNSIGNED NOT NULL,
  `time_in` varchar(50) NOT NULL,
  `time_out` varchar(50) NOT NULL,
  `year` year(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `faculty_log`
--

INSERT INTO `faculty_log` (`flog_id`, `faculty_id`, `schedule_id`, `time_in`, `time_out`, `year`) VALUES
(45, 1, 1, '2024-09-21 23:32:09.783748', '2024-09-22 00:21:04.639316', '2024'),
(46, 1, 1, '2024-09-21 23:36:03.174810', '2024-09-22 00:21:04.639316', '2024'),
(47, 1, 1, '2024-09-21 23:43:39.426817', '2024-09-22 00:21:04.639316', '2024'),
(48, 1, 1, '2024-09-21 23:47:58.616715', '2024-09-22 00:21:04.639316', '2024'),
(49, 1, 1, '2024-09-21 23:55:06.172779', '2024-09-22 00:21:04.639316', '2024'),
(50, 1, 1, '2024-09-22 00:00:22.919993', '2024-09-22 00:21:04.639316', '2024'),
(51, 1, 1, '2024-09-22 00:01:08.406149', '2024-09-22 00:21:04.639316', '2024'),
(52, 1, 1, '2024-09-22 00:14:59.193927', '2024-09-22 00:21:04.639316', '2024'),
(53, 1, 1, '2024-09-22 00:20:58.825693', '2024-09-22 00:21:04.639316', '2024'),
(54, 1, 1, '2024-09-22 00:25:06.450993', '2024-09-22 00:25:11.435260', '2024'),
(55, 1, 1, '2024-09-22 00:32:58.122707', '2024-09-22 00:33:02.355659', '2024'),
(56, 1, 1, '2024-09-22 00:37:39.686240', '2024-09-22 00:37:47.486632', '2024'),
(57, 1, 1, '2024-09-22 00:44:13.322948', '2024-09-22 00:44:17.948165', '2024'),
(58, 1, 1, '2024-09-22 00:50:22.631196', '2024-09-22 00:50:28.895518', '2024'),
(59, 1, 1, '2024-09-22 00:52:33.161641', '2024-09-22 00:52:38.842654', '2024');

-- --------------------------------------------------------

--
-- Table structure for table `fingerprint`
--

CREATE TABLE `fingerprint` (
  `fingerprint_id` int(11) UNSIGNED NOT NULL,
  `admin_id` int(11) UNSIGNED DEFAULT NULL,
  `faculty_id` int(11) UNSIGNED DEFAULT NULL,
  `fingerprint_data` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `fingerprint`
--

INSERT INTO `fingerprint` (`fingerprint_id`, `admin_id`, `faculty_id`, `fingerprint_data`) VALUES
(3, NULL, 1, 'APh/Acgq43NcwEE3CatxcEwVVZLTZV7HPjBSZrJrtywq7VvD9kbCeQ7T6dArdVT113eNt6cpp+emOmGBWvuRj/+FLiSqBvpg/YyD9lx0062BTt2aw2PjxmiNYDLLuKZpzl3hdoPjE7gvMPBYl36AgX5ysAEvntN3GHXZHADhq+vLacx0FH23weA+842T27jbZIHlmw4vvVj/VOFrgN+vMm2cTNKixXmxtT7vqj1xW4T083yP0CDF4/hey++zeQmKphYr2X+83x8broJW0WWarilp/6Gf0UX3Yb7OcDV9TsNT1pSrDGtj3WIayB4YDfvfO+kyN1FwHWdHHmHwyrQoZzg3TWUXrljHPBtPUNr1ezgbMH6a7asWNub3vXD+KY7ZV3hcgnc0ADaxzbtKGJ3TsCk+EDf0WojUX+tUcMnC/bNUFTCaAVs2VE3qBh8xIbe3upbMl+NuPbnG17cXghyY3fDH/nhkGnoCxqqdP/giGGv0syJrAU9TOo3T/xtRd2Mbll03bwD4fwHIKuNzXMBBNwmrcfCzFFWSB8z3iUCXV6EuDPufC52EDrGLYeKhK1w6PsRTXY1TrSyC3LNcbyXJN+kuclnhkjOCwvAPiVAgVpJDTYTE5Altx0Der13yioqspgKM75J48ZtcwBBnIpp8btu87mxLnIjK+Ueng9ElY2fCIn1Lm6U8rWMa+Nim+tLKIo1gEEvWUogbkwo9q6nK1P1voVVD2YCxXTUogOljX/Frx+b8uZRGqySvITqBmSW8CFBXai3fWU+nY92tglqgBlrEUJ3s4c4fuKmNV5N49ufSUQMZxF+l/F0EGd1Mcyw2fvzrq/n754PveKiZtZMRetkzCPEgaqS2h0LW8zmUP1TNQDzBlPjJCBh4TjbPEP6c//iLMR1/p5yzAs2uKQR+u9Iw6OcbuM9jdx7dM0W/7CBo8/WHejz6vsb1jgsOTr/gC67HbKbOwj8sgRz7LJnEE//PDs6T3XyK1HqEtDXEntqFQ85sxM20Pvfpo0nsU0B9T8av8U9+5W8A+IAByCrjc1zAQTcJq3GwthRVkiGDPmOVyelB55ntZpglZXZBTEcD6lQtj+De1Me5z9mkJfugMsUlAqmsw2dqxoJWB7z8O5m/1ncVq7XtKmqcTOLucNMBoJfwCkostWTv2iKnk/c1stiS+47zBHy2pgcgZApeyv0dGHXi4b2cNSdQP/vBpFOoCW00/6+kXXmP0FQ2XrFDYFhBVZCwL4nvQO7PKKysN431pMXA0C4rj7QT46u4k0fhyIm+hD0poV4e8MAm1JoF1mnK9MFyTeVWu1KCcqsFiOlVwsJKn9CXrVoYn2/nPBCjQ9kraVs4Xep8SIcV3v0b2/XZGUmMTODCmIDa1EsKHJf6P+ZYN10WiTTRn9FQr7iYmCxWk9PeIdJRMCESSP+fukoicPXZCZZ+5rmG9Ek8m/zQjTi6Al6DFmwpGiX/nlwtDKKb3dz76XX2npuvnF4aM3W71hv2C/gJke6VELb/EHj3J1t/ITBNVZDUNo2X2pFGI3mz4M6x6xbcDLLIbwDogQHIKuNzXMBBNwmrcXCsFFWSQLD8NL4datkz91+x0GzmI/GfJSy/0P5tzua9zLq7hVdXL1r8LUd2ojIOHTJ5iIlvOG2UnyELvYT6HgfuMlVkYHzTxFOnGB2vBVPnPqkxYqasGx1XEZJMQ5KaBX4EP+mAUuY5Nmd8TnKYwiRZ7WQPp2YDPFcTsXiws0x3SvftsDB6GhTaCBZ6fKS3hGJft6llO+1MeOHWsy1o04357qFp3u8zY3LkTnzLFtnwokwR+crSYa3FStqPxR1bocO423cvAQNuXm4P+aEfqz/1VjfD68CnrZaKJTwFRyOUIm3xgTcGpG3fDmJ9EU+MbM+nSfQcjz3/zyGafS242CLp3ox/exk+VHk1DjlQPvdSLXKA4ZR61jMYOJQPRdS98T1V/+6HgO2zkXI2/vpl+7aP1714iND2c3sesobk+OzY3uNcZWSGCgIWPjhQ/U78aLRmITbx4EhIKCr87BanH1lXy5ViW59WKBcgGm74sip/FDrAdvFpb///////////////////////////////////////////////////////////////////////////////////////////////////////');

-- --------------------------------------------------------

--
-- Table structure for table `masterlist`
--

CREATE TABLE `masterlist` (
  `mlist_id` int(11) UNSIGNED NOT NULL,
  `clist_id` int(11) UNSIGNED NOT NULL,
  `student_id` int(11) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `masterlist`
--

INSERT INTO `masterlist` (`mlist_id`, `clist_id`, `student_id`) VALUES
(1, 1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `migrations`
--

CREATE TABLE `migrations` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `version` varchar(255) NOT NULL,
  `class` varchar(255) NOT NULL,
  `group` varchar(255) NOT NULL,
  `namespace` varchar(255) NOT NULL,
  `time` int(11) NOT NULL,
  `batch` int(11) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `migrations`
--

INSERT INTO `migrations` (`id`, `version`, `class`, `group`, `namespace`, `time`, `batch`) VALUES
(1, '2024-07-25-143838', 'App\\Database\\Migrations\\CreateFacultyTable', 'default', 'App', 1726888010, 1),
(2, '2024-07-25-143915', 'App\\Database\\Migrations\\CreateStudentTable', 'default', 'App', 1726888010, 1),
(3, '2024-07-25-143948', 'App\\Database\\Migrations\\CreateSubjectsTable', 'default', 'App', 1726888010, 1),
(4, '2024-07-25-144017', 'App\\Database\\Migrations\\CreateClassListTable', 'default', 'App', 1726888010, 1),
(5, '2024-07-25-144050', 'App\\Database\\Migrations\\CreateScheduleTable', 'default', 'App', 1726888010, 1),
(6, '2024-07-25-144116', 'App\\Database\\Migrations\\CreateAdminTable', 'default', 'App', 1726888010, 1),
(7, '2024-07-25-144146', 'App\\Database\\Migrations\\CreateFingerprintTable', 'default', 'App', 1726888010, 1),
(8, '2024-07-25-144215', 'App\\Database\\Migrations\\CreateRFIDTable', 'default', 'App', 1726888010, 1),
(9, '2024-07-25-144240', 'App\\Database\\Migrations\\CreateMasterlistTable', 'default', 'App', 1726888010, 1),
(10, '2024-07-25-144409', 'App\\Database\\Migrations\\CreatePincodeTable', 'default', 'App', 1726888010, 1),
(11, '2024-08-02-124054', 'App\\Database\\Migrations\\CreateUsersTable', 'default', 'App', 1726888010, 1),
(12, '2024-08-03-100633', 'App\\Database\\Migrations\\CreateEventsTable', 'default', 'App', 1726888010, 1),
(13, '2024-09-21-024208', 'App\\Database\\Migrations\\CreateFacultyLogTable', 'default', 'App', 1726888010, 1),
(14, '2024-09-21-024257', 'App\\Database\\Migrations\\CreateStudentLogTable', 'default', 'App', 1726888010, 1);

-- --------------------------------------------------------

--
-- Table structure for table `pincode`
--

CREATE TABLE `pincode` (
  `pincode_id` int(11) UNSIGNED NOT NULL,
  `admin_id` int(11) UNSIGNED DEFAULT NULL,
  `faculty_id` int(11) UNSIGNED DEFAULT NULL,
  `pincode_data` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `pincode`
--

INSERT INTO `pincode` (`pincode_id`, `admin_id`, `faculty_id`, `pincode_data`) VALUES
(1, NULL, 1, '1111');

-- --------------------------------------------------------

--
-- Table structure for table `rfid`
--

CREATE TABLE `rfid` (
  `rfid_id` int(11) UNSIGNED NOT NULL,
  `admin_id` int(11) UNSIGNED DEFAULT NULL,
  `faculty_id` int(11) UNSIGNED DEFAULT NULL,
  `student_id` int(11) UNSIGNED DEFAULT NULL,
  `rfid_data` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `rfid`
--

INSERT INTO `rfid` (`rfid_id`, `admin_id`, `faculty_id`, `student_id`, `rfid_data`) VALUES
(3, NULL, 1, NULL, '1432706338'),
(4, NULL, NULL, 1, '0876474723');

-- --------------------------------------------------------

--
-- Table structure for table `schedule`
--

CREATE TABLE `schedule` (
  `schedule_id` int(11) UNSIGNED NOT NULL,
  `clist_id` int(11) UNSIGNED NOT NULL,
  `faculty_id` int(11) UNSIGNED NOT NULL,
  `subject_id` int(11) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `schedule`
--

INSERT INTO `schedule` (`schedule_id`, `clist_id`, `faculty_id`, `subject_id`) VALUES
(1, 1, 1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

CREATE TABLE `student` (
  `student_id` int(11) UNSIGNED NOT NULL,
  `fname` varchar(100) NOT NULL,
  `mname` varchar(100) DEFAULT NULL,
  `lname` varchar(100) NOT NULL,
  `section` varchar(100) NOT NULL,
  `gender` varchar(100) NOT NULL,
  `age` int(11) NOT NULL,
  `birthday` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `student`
--

INSERT INTO `student` (`student_id`, `fname`, `mname`, `lname`, `section`, `gender`, `age`, `birthday`) VALUES
(1, 'Jonathan', 'F.', 'Beloro', 'BSIT-4B', 'Male', 25, '1999-08-18');

-- --------------------------------------------------------

--
-- Table structure for table `student_log`
--

CREATE TABLE `student_log` (
  `slog_id` int(11) UNSIGNED NOT NULL,
  `student_id` int(11) UNSIGNED NOT NULL,
  `schedule_id` int(11) UNSIGNED NOT NULL,
  `time_in` varchar(50) NOT NULL,
  `time_out` varchar(50) NOT NULL,
  `year` year(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `student_log`
--

INSERT INTO `student_log` (`slog_id`, `student_id`, `schedule_id`, `time_in`, `time_out`, `year`) VALUES
(1, 1, 1, '2024-09-21 22:26:28.028518', '2024-09-22 00:21:04.639316', '2024'),
(2, 1, 1, '2024-09-21 22:26:41.753349', '2024-09-22 00:21:04.639316', '2024'),
(3, 1, 1, '2024-09-21 22:31:51.689346', '2024-09-22 00:21:04.639316', '2024'),
(4, 1, 1, '2024-09-21 22:39:54.314088', '2024-09-22 00:21:04.639316', '2024'),
(5, 1, 1, '2024-09-21 22:53:36.888140', '2024-09-22 00:21:04.639316', '2024'),
(6, 1, 1, '2024-09-21 23:32:05.148763', '2024-09-22 00:21:04.639316', '2024'),
(7, 1, 1, '2024-09-21 23:36:00.836114', '2024-09-22 00:21:04.639316', '2024'),
(8, 1, 1, '2024-09-21 23:43:42.736209', '2024-09-22 00:21:04.639316', '2024'),
(9, 1, 1, '2024-09-21 23:48:00.575338', '2024-09-22 00:21:04.639316', '2024'),
(10, 1, 1, '2024-09-21 23:55:04.132662', '2024-09-22 00:21:04.639316', '2024'),
(11, 1, 1, '2024-09-22 00:00:21.225380', '2024-09-22 00:21:04.639316', '2024'),
(12, 1, 1, '2024-09-22 00:01:05.354676', '2024-09-22 00:21:04.639316', '2024'),
(13, 1, 1, '2024-09-22 00:14:56.812082', '2024-09-22 00:21:04.639316', '2024'),
(14, 1, 1, '2024-09-22 00:20:56.834897', '2024-09-22 00:21:04.639316', '2024'),
(15, 1, 1, '2024-09-22 00:25:04.600498', '2024-09-22 00:25:11.435260', '2024'),
(16, 1, 1, '2024-09-22 00:32:56.100162', '2024-09-22 00:33:02.355659', '2024'),
(17, 1, 1, '2024-09-22 00:37:42.247279', '2024-09-22 00:37:47.486632', '2024'),
(18, 1, 1, '2024-09-22 00:44:11.030154', '2024-09-22 00:44:17.948165', '2024'),
(19, 1, 1, '2024-09-22 00:50:24.409185', '2024-09-22 00:50:28.895518', '2024'),
(20, 1, 1, '2024-09-22 00:52:35.116401', '2024-09-22 00:52:38.842654', '2024');

-- --------------------------------------------------------

--
-- Table structure for table `subjects`
--

CREATE TABLE `subjects` (
  `subject_id` int(11) UNSIGNED NOT NULL,
  `class_code` varchar(100) NOT NULL,
  `subject_name` varchar(100) NOT NULL,
  `subject_unit` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `subjects`
--

INSERT INTO `subjects` (`subject_id`, `class_code`, `subject_name`, `subject_unit`) VALUES
(1, 'CCIT 101', 'Introduction to Computing', 0),
(2, 'CCIT 102', 'Computer Programming 1', 0),
(3, 'GE 5', 'Purposive Communication', 0),
(4, 'GE 1', 'Understanding the Self', 0),
(5, 'GE 2', 'Readings in Philippine History', 0),
(6, 'GE 8', 'Ethics', 0),
(7, 'PE 1-NEW GE', 'Physical Education 1', 0),
(8, 'NSTP1 (LTS)', 'National Service Training Program 1', 0),
(9, 'NSTP1 (CWTS)', 'National Service Training Program 1', 0),
(10, 'NSTP1 (ROTC)', 'National Service Training Program 1', 0),
(11, 'CCIT 103', 'Computer Programming 2', 0),
(12, 'IT 211', 'Introduction to Human Computer Interaction', 0),
(13, 'IT 212', 'Discrete Mathematics', 0),
(14, 'ITA 121', 'Web Systems and Technologies 1', 0),
(15, 'GE 3', 'Contemporary World', 0);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `user_id` int(11) UNSIGNED NOT NULL,
  `admin_id` int(11) UNSIGNED DEFAULT NULL,
  `faculty_id` int(11) UNSIGNED DEFAULT NULL,
  `role` varchar(100) NOT NULL,
  `email` varchar(150) NOT NULL,
  `password` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`user_id`, `admin_id`, `faculty_id`, `role`, `email`, `password`) VALUES
(1, 1, NULL, 'admin', 'admin@gmail.com', '$2y$10$S1n7j5cOvbH4ssZRU6VneOFnRLH8gPQA0FfqKh09FghL8813LXewy'),
(2, NULL, 1, 'faculty', 'faculty@gmail.com', '$2y$10$PGqtgQAn6R4ASCThPQtY4OZ2ZkmXx.R8cvWq/Rov3zEXGhg.oTUHu');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`admin_id`);

--
-- Indexes for table `classlist`
--
ALTER TABLE `classlist`
  ADD PRIMARY KEY (`clist_id`),
  ADD KEY `faculty_id` (`faculty_id`),
  ADD KEY `subject_id` (`subject_id`);

--
-- Indexes for table `events`
--
ALTER TABLE `events`
  ADD PRIMARY KEY (`event_id`);

--
-- Indexes for table `faculty`
--
ALTER TABLE `faculty`
  ADD PRIMARY KEY (`faculty_id`);

--
-- Indexes for table `faculty_log`
--
ALTER TABLE `faculty_log`
  ADD PRIMARY KEY (`flog_id`),
  ADD KEY `faculty_log_faculty_id_foreign` (`faculty_id`),
  ADD KEY `faculty_log_schedule_id_foreign` (`schedule_id`);

--
-- Indexes for table `fingerprint`
--
ALTER TABLE `fingerprint`
  ADD PRIMARY KEY (`fingerprint_id`),
  ADD KEY `admin_id` (`admin_id`),
  ADD KEY `faculty_id` (`faculty_id`);

--
-- Indexes for table `masterlist`
--
ALTER TABLE `masterlist`
  ADD PRIMARY KEY (`mlist_id`),
  ADD KEY `clist_id` (`clist_id`),
  ADD KEY `student_id` (`student_id`);

--
-- Indexes for table `migrations`
--
ALTER TABLE `migrations`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `pincode`
--
ALTER TABLE `pincode`
  ADD PRIMARY KEY (`pincode_id`),
  ADD KEY `admin_id` (`admin_id`),
  ADD KEY `faculty_id` (`faculty_id`);

--
-- Indexes for table `rfid`
--
ALTER TABLE `rfid`
  ADD PRIMARY KEY (`rfid_id`),
  ADD KEY `admin_id` (`admin_id`),
  ADD KEY `faculty_id` (`faculty_id`),
  ADD KEY `student_id` (`student_id`);

--
-- Indexes for table `schedule`
--
ALTER TABLE `schedule`
  ADD PRIMARY KEY (`schedule_id`),
  ADD KEY `clist_id` (`clist_id`),
  ADD KEY `faculty_id` (`faculty_id`),
  ADD KEY `subject_id` (`subject_id`);

--
-- Indexes for table `student`
--
ALTER TABLE `student`
  ADD PRIMARY KEY (`student_id`);

--
-- Indexes for table `student_log`
--
ALTER TABLE `student_log`
  ADD PRIMARY KEY (`slog_id`),
  ADD KEY `student_log_student_id_foreign` (`student_id`),
  ADD KEY `student_log_schedule_id_foreign` (`schedule_id`);

--
-- Indexes for table `subjects`
--
ALTER TABLE `subjects`
  ADD PRIMARY KEY (`subject_id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`user_id`),
  ADD KEY `users_faculty_id_foreign` (`faculty_id`),
  ADD KEY `users_admin_id_foreign` (`admin_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin`
--
ALTER TABLE `admin`
  MODIFY `admin_id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `classlist`
--
ALTER TABLE `classlist`
  MODIFY `clist_id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `events`
--
ALTER TABLE `events`
  MODIFY `event_id` int(5) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `faculty`
--
ALTER TABLE `faculty`
  MODIFY `faculty_id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `faculty_log`
--
ALTER TABLE `faculty_log`
  MODIFY `flog_id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=60;

--
-- AUTO_INCREMENT for table `fingerprint`
--
ALTER TABLE `fingerprint`
  MODIFY `fingerprint_id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `masterlist`
--
ALTER TABLE `masterlist`
  MODIFY `mlist_id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `migrations`
--
ALTER TABLE `migrations`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `pincode`
--
ALTER TABLE `pincode`
  MODIFY `pincode_id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `rfid`
--
ALTER TABLE `rfid`
  MODIFY `rfid_id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `schedule`
--
ALTER TABLE `schedule`
  MODIFY `schedule_id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `student_log`
--
ALTER TABLE `student_log`
  MODIFY `slog_id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `subjects`
--
ALTER TABLE `subjects`
  MODIFY `subject_id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `user_id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `classlist`
--
ALTER TABLE `classlist`
  ADD CONSTRAINT `classlist_faculty_id_foreign` FOREIGN KEY (`faculty_id`) REFERENCES `faculty` (`faculty_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `classlist_subject_id_foreign` FOREIGN KEY (`subject_id`) REFERENCES `subjects` (`subject_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `faculty_log`
--
ALTER TABLE `faculty_log`
  ADD CONSTRAINT `faculty_log_faculty_id_foreign` FOREIGN KEY (`faculty_id`) REFERENCES `faculty` (`faculty_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `faculty_log_schedule_id_foreign` FOREIGN KEY (`schedule_id`) REFERENCES `schedule` (`schedule_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `fingerprint`
--
ALTER TABLE `fingerprint`
  ADD CONSTRAINT `fingerprint_admin_id_foreign` FOREIGN KEY (`admin_id`) REFERENCES `admin` (`admin_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fingerprint_faculty_id_foreign` FOREIGN KEY (`faculty_id`) REFERENCES `faculty` (`faculty_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `masterlist`
--
ALTER TABLE `masterlist`
  ADD CONSTRAINT `masterlist_clist_id_foreign` FOREIGN KEY (`clist_id`) REFERENCES `classlist` (`clist_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `masterlist_student_id_foreign` FOREIGN KEY (`student_id`) REFERENCES `student` (`student_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `pincode`
--
ALTER TABLE `pincode`
  ADD CONSTRAINT `pincode_admin_id_foreign` FOREIGN KEY (`admin_id`) REFERENCES `admin` (`admin_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `pincode_faculty_id_foreign` FOREIGN KEY (`faculty_id`) REFERENCES `faculty` (`faculty_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `rfid`
--
ALTER TABLE `rfid`
  ADD CONSTRAINT `rfid_admin_id_foreign` FOREIGN KEY (`admin_id`) REFERENCES `admin` (`admin_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `rfid_faculty_id_foreign` FOREIGN KEY (`faculty_id`) REFERENCES `faculty` (`faculty_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `rfid_student_id_foreign` FOREIGN KEY (`student_id`) REFERENCES `student` (`student_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `schedule`
--
ALTER TABLE `schedule`
  ADD CONSTRAINT `schedule_clist_id_foreign` FOREIGN KEY (`clist_id`) REFERENCES `classlist` (`clist_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `schedule_faculty_id_foreign` FOREIGN KEY (`faculty_id`) REFERENCES `faculty` (`faculty_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `schedule_subject_id_foreign` FOREIGN KEY (`subject_id`) REFERENCES `subjects` (`subject_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `student_log`
--
ALTER TABLE `student_log`
  ADD CONSTRAINT `student_log_schedule_id_foreign` FOREIGN KEY (`schedule_id`) REFERENCES `schedule` (`schedule_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `student_log_student_id_foreign` FOREIGN KEY (`student_id`) REFERENCES `student` (`student_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `users`
--
ALTER TABLE `users`
  ADD CONSTRAINT `users_admin_id_foreign` FOREIGN KEY (`admin_id`) REFERENCES `admin` (`admin_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `users_faculty_id_foreign` FOREIGN KEY (`faculty_id`) REFERENCES `faculty` (`faculty_id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
