-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 20, 2024 at 03:37 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

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
  `attendance` varchar(50) NOT NULL,
  `datetime` timestamp NOT NULL DEFAULT current_timestamp(),
  `year` year(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `fingerprint`
--

CREATE TABLE `fingerprint` (
  `fingerprint_id` int(11) UNSIGNED NOT NULL,
  `admin_id` int(11) UNSIGNED DEFAULT NULL,
  `faculty_id` int(11) UNSIGNED DEFAULT NULL,
  `fingerprint_data` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `fingerprint`
--

INSERT INTO `fingerprint` (`fingerprint_id`, `admin_id`, `faculty_id`, `fingerprint_data`) VALUES
(1, 1, NULL, 'APhJAcgq43NcwEE3Catx8KsUVZJcJ4L+hgCG1Q8TBRK2KsXhCT2FwjGO8FfDeJO1oph1k/9bBJWwT3TMrzyaW1kA2aIbvnkdy21+'),
(2, NULL, 1, 'APg+Acgq43NcwEE3CatxMJUUVZKtPoohD5IEcXOYtRj5dlrzGlrpfmiCoScWHYImmiMX1tuyhQbtbCQ9shFRsOafHuEqdRzgNcZJ'),
(3, NULL, 2, 'APh+Acgq43NcwEE3CatxcJkUVZK250+BoYujls/zL8LpQ58RXTmt97jQX49um2YNUPScsLY4i8/1RrjABwIL4XaLykSH6VlCLR7p');

-- --------------------------------------------------------

--
-- Table structure for table `masterlist`
--

CREATE TABLE `masterlist` (
  `mlist_id` int(11) UNSIGNED NOT NULL,
  `clist_id` int(11) UNSIGNED NOT NULL,
  `student_id` int(11) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

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
(1, '2024-07-25-143838', 'App\\Database\\Migrations\\CreateFacultyTable', 'default', 'App', 1726812872, 1),
(2, '2024-07-25-143915', 'App\\Database\\Migrations\\CreateStudentTable', 'default', 'App', 1726812872, 1),
(3, '2024-07-25-143948', 'App\\Database\\Migrations\\CreateSubjectsTable', 'default', 'App', 1726812872, 1),
(4, '2024-07-25-144017', 'App\\Database\\Migrations\\CreateClassListTable', 'default', 'App', 1726812873, 1),
(5, '2024-07-25-144050', 'App\\Database\\Migrations\\CreateScheduleTable', 'default', 'App', 1726812873, 1),
(6, '2024-07-25-144116', 'App\\Database\\Migrations\\CreateAdminTable', 'default', 'App', 1726812873, 1),
(7, '2024-07-25-144146', 'App\\Database\\Migrations\\CreateFingerprintTable', 'default', 'App', 1726812873, 1),
(8, '2024-07-25-144215', 'App\\Database\\Migrations\\CreateRFIDTable', 'default', 'App', 1726812873, 1),
(9, '2024-07-25-144240', 'App\\Database\\Migrations\\CreateMasterlistTable', 'default', 'App', 1726812873, 1),
(10, '2024-07-25-144330', 'App\\Database\\Migrations\\CreateFacultyLogTable', 'default', 'App', 1726812873, 1),
(11, '2024-07-25-144351', 'App\\Database\\Migrations\\CreateStudentLogTable', 'default', 'App', 1726812873, 1),
(12, '2024-07-25-144409', 'App\\Database\\Migrations\\CreatePincodeTable', 'default', 'App', 1726812873, 1),
(13, '2024-08-02-124054', 'App\\Database\\Migrations\\CreateUsersTable', 'default', 'App', 1726812873, 1),
(14, '2024-08-03-100633', 'App\\Database\\Migrations\\CreateEventsTable', 'default', 'App', 1726812873, 1);

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
(1, 1, NULL, '1234');

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
(1, 1, NULL, NULL, '0876474723');

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

-- --------------------------------------------------------

--
-- Table structure for table `student_log`
--

CREATE TABLE `student_log` (
  `slog_id` int(11) UNSIGNED NOT NULL,
  `student_id` int(11) UNSIGNED NOT NULL,
  `schedule_id` int(11) UNSIGNED NOT NULL,
  `datetime` timestamp NOT NULL DEFAULT current_timestamp(),
  `year` year(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

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
(1, 1, NULL, 'admin', 'admin@gmail.com', '$2y$10$HggIbT6xL/YUuER67LPaqeupArA2PHSoVUiwAE4VODpr.4ZxmEkqa'),
(2, NULL, 1, 'faculty', 'faculty@gmail.com', '$2y$10$iGWaPKAX9fhNBNLMMYeUUOclsqHAYOsnM6MdAR.JIWncAdhdKJer.');

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
  MODIFY `clist_id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT;

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
  MODIFY `flog_id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `fingerprint`
--
ALTER TABLE `fingerprint`
  MODIFY `fingerprint_id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `masterlist`
--
ALTER TABLE `masterlist`
  MODIFY `mlist_id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT;

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
  MODIFY `rfid_id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `schedule`
--
ALTER TABLE `schedule`
  MODIFY `schedule_id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `student_log`
--
ALTER TABLE `student_log`
  MODIFY `slog_id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT;

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
