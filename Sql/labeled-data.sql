-- MySQL dump 10.13  Distrib 8.0.24, for Win64 (x86_64)
--
-- Host: localhost    Database: manage_user
-- ------------------------------------------------------
-- Server version	5.7.34-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `labeled_data`
--

USE labeled_data;

DROP TABLE IF EXISTS `labeled_data`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `labeled_data` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` int(11) NOT NULL,
  `topic_id` int(11) NOT NULL,
  `content` text COLLATE utf8_bin,
  `score` float DEFAULT NULL,
  `file_audio` text COLLATE utf8_bin,
  `file_image` text COLLATE utf8_bin,
  `question` text COLLATE utf8_bin,
  `english_test_id` int(11) NOT NULL,
  `test_format_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `user_id_idx` (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `mst_category`
--

DROP TABLE IF EXISTS `mst_category`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mst_category` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` text COLLATE utf8_bin NOT NULL,
  `tag_type` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `mst_english_type`
--

DROP TABLE IF EXISTS `mst_english_type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mst_english_type` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `tag_type` int(11) NOT NULL,
  `name` text COLLATE utf8_bin NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_user`
--

DROP TABLE IF EXISTS `tbl_user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_user` (
  `user_id` int(11) NOT NULL AUTO_INCREMENT,
  `login_name` text COLLATE utf8_bin NOT NULL,
  `full_name` text COLLATE utf8_bin NOT NULL,
  `password` text COLLATE utf8_bin NOT NULL,
  `rule` int(11) NOT NULL,
  PRIMARY KEY (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-09-03 21:41:36


INSERT INTO `labeled_data`.`tbl_user`(`login_name`,`full_name`,`password`,`rule`)
VALUES('admin','admin','$pbkdf2$10000$fIqEcPW9YIn1AJrsPxXDbA$MTNdtGqJh5Wr6WjIeiXGyh4JDHk',0);

INSERT INTO `labeled_data`.`mst_english_type`(`tag_type`,`name`)
VALUES
	(0,'English Test'),
	(1,'Test Format'),
	(2,'Topic');

DELIMITER $$
DROP PROCEDURE IF EXISTS `get_labeled_data`;
CREATE PROCEDURE get_labeled_data (
IN topic_id INT,
IN english_test_id INT,
IN test_format_id INT,
OUT topic TEXT,
OUT english_test TEXT,
OUT test_format TEXT
)
BEGIN
	SET topic = (
		SELECT m.name FROM labeled_data l
		INNER JOIN mst_category m
		ON l.topic_id = m.id
		WHERE m.id = topic_id
        LIMIT 1
    );
    
    SET english_test = (
		SELECT m.name FROM labeled_data l
		INNER JOIN mst_category m
		ON l.english_test_id = m.id
		WHERE m.id = english_test_id
        LIMIT 1
    );
    
    SET test_format = (
		SELECT m.name FROM labeled_data l
		INNER JOIN mst_category m
		ON l.test_format_id = m.id
		WHERE m.id = test_format_id
        LIMIT 1
    );
END$$
DELIMITER ;