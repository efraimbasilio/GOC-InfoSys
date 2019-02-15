-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 15, 2019 at 08:50 AM
-- Server version: 10.1.37-MariaDB
-- PHP Version: 7.3.0

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
-- Table structure for table `discount`
--

CREATE TABLE `discount` (
  `id` int(11) NOT NULL,
  `discount_name` varchar(255) DEFAULT NULL,
  `discount_percent_amount` double(7,2) DEFAULT '0.00'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

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
(6, 'Registration Fee\r\n', '1000.00'),
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
  `other_fee_amount` double(7,2) DEFAULT '0.00'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `other_fee`
--

INSERT INTO `other_fee` (`id`, `other_fee_name`, `other_fee_amount`) VALUES
(5, 'Computer Laboratory/ Internet Fee\r\n', 2500.00),
(6, 'Testing Materials\r\n', 500.00),
(7, 'Laboratory Fee (Chemistry & Physics)\r\n', 1000.00);

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
(1, '8:00\r\n', '9:00\r\n', 'HOME ROOM\r\n', 'Adviser\r\n', 'Room Hera\r\n', 'M\r\n', '', '', '', '', 'Hera\r\n', 'ABM\r\n');

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
(5, 2019, 2020),
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
(1, 'qq', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(2, '1121212123333', 'REG-2019-0002', NULL, 'Basilio', 'Efraim', 'G.', '11', 'New Student', NULL, 'ABM', 'ACADEMIC', '2019-03-04', 'Male', 'TarlacTarlacTarlacTarlacTarlac', 'TarlacTarlacTarlacTarlacTarlacTarlacTarlac', NULL, NULL, NULL, NULL);

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
  `tuition_desc` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tuition_fee`
--

INSERT INTO `tuition_fee` (`id`, `tuition_fee_name`, `tuition_amount`, `tuition_desc`) VALUES
(13, 'Tuition Fee - STEM', '8000.00', 'For STEM Student Only'),
(14, 'Tuition Fee - NON STEM', '7000.00', 'For NON STEM Students');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(255) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `user_type` varchar(255) DEFAULT NULL,
  `access_level_1` varchar(255) DEFAULT NULL,
  `access_level_2` varchar(255) DEFAULT NULL,
  `access_level_3` varchar(255) DEFAULT NULL,
  `access_level_4` varchar(255) DEFAULT NULL,
  `access_level_5` varchar(255) DEFAULT NULL,
  `access_level_6` varchar(255) DEFAULT NULL,
  `access_level_7` varchar(255) DEFAULT NULL,
  `access_level_8` varchar(255) DEFAULT NULL,
  `access_level_9` varchar(255) DEFAULT NULL,
  `access_level_10` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `username`, `password`, `user_type`, `access_level_1`, `access_level_2`, `access_level_3`, `access_level_4`, `access_level_5`, `access_level_6`, `access_level_7`, `access_level_8`, `access_level_9`, `access_level_10`) VALUES
(6, 'admin', 'admin123', 'Admin', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(7, 'theadmin', 'theadmin1', 'Registrar', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `voucher`
--

CREATE TABLE `voucher` (
  `id` int(11) NOT NULL,
  `voucher_from` varchar(255) DEFAULT NULL,
  `voucher_amount` double(7,2) DEFAULT '0.00'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `voucher`
--

INSERT INTO `voucher` (`id`, `voucher_from`, `voucher_amount`) VALUES
(3, 'Voucher Public\r\n', 17500.00),
(4, 'Voucher Private\r\n', 14000.00);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `discount`
--
ALTER TABLE `discount`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `discount_name` (`discount_name`);

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
-- AUTO_INCREMENT for table `discount`
--
ALTER TABLE `discount`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

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
-- AUTO_INCREMENT for table `room`
--
ALTER TABLE `room`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `schedule`
--
ALTER TABLE `schedule`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

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
-- AUTO_INCREMENT for table `stud_registration`
--
ALTER TABLE `stud_registration`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

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
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `voucher`
--
ALTER TABLE `voucher`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
