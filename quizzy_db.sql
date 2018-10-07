-- MySQL dump 10.13  Distrib 8.0.12, for Win64 (x86_64)
--
-- Host: localhost    Database: quizzy_db
-- ------------------------------------------------------
-- Server version	8.0.12

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `question`
--

DROP TABLE IF EXISTS `question`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `question` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `question_text` varchar(255) NOT NULL,
  `answer` varchar(255) NOT NULL,
  `youtube_link` varchar(255) DEFAULT NULL,
  `deleted` tinyint(4) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=39 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `question`
--

LOCK TABLES `question` WRITE;
/*!40000 ALTER TABLE `question` DISABLE KEYS */;
INSERT INTO `question` VALUES (16,'Kako se zove slovenska boginja smrti?','Morana','',0),(17,'Šta znači skraćenica D.C. u imenu Washington D.C?','District of Columbia','',0),(18,'Koliko ima poslanika Narodna skupština Republike Srpske','83','',0),(19,'Koji narod je u 9. vijeku donio šah u Evropu?','Arapi','',0),(20,'Koji se američki predsjednik jedini u istoriji izjasnio kao rimokatolik','J.F. Kennedy','',0),(21,'Koje godine je Fidel Kastro došao na vlast u Kubi?','1959','',0),(22,'U kom punskom ratu je Hanibal bio \"ante portas\"?','Drugom','',0),(23,'Koja vrsta medvjeda je najveća u Evropi?','Mrki medvjed','',0),(24,'U kojoj državi Šiiti čine 90% stanovništva?','Iran','',0),(25,'Koje godine je Jurij Gagarin otišao u svemir','1961','',0),(26,'Koliko godina traje mandat nestalnim članicama Savjeta bezbjednost UN','2','',0),(27,'U kom mjesecu 1944-e je oslobođen Beograd','U septembru','',0),(28,'Izvođač i naziv pjesme','Van halen - Jump','https://www.youtube.com/watch?v=SwYN7mTi6HM',1),(29,'Izvođač i naziv pjesme','Film - Dokaži','https://www.youtube.com/watch?v=h5xf6q0quDY',0),(30,'Izvođač i naziv pjesme','Akcent - Kylie','https://www.youtube.com/watch?v=wOem06X3uVo',0),(31,'Izvođač i naziv pjesme','Kiss  - I Was Made For Lovin\' You','https://www.youtube.com/watch?v=zlSFmotba2I',0),(32,'U kojem filmu se može čuti ova pjesma?','Balkanski špijun','https://www.youtube.com/watch?v=NJVa9wRHtBQ',0),(33,'Naziv serije','Navy CIS (NCIS)','https://www.youtube.com/watch?v=9NlDMLRDZUE',0),(34,'Na pravoslavni božić koje godine je umro Nikola Tesla','1943','',0),(35,'Koja država s kopna potpuno okružuje zapadnoafričku Gambiju','Senegal','',0),(36,'Koji nadimak nosi bokser Floyd Mayweather','Money','',0),(37,'Koji je jedini fudbaler koji je igrao čak 20 sezona Lige Šampiona?','Iker Kasiljas','',0),(38,'Ana Brnabić, Aleksandar Vučić, nastavite niz','Ivica Dačić','',0);
/*!40000 ALTER TABLE `question` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `round`
--

DROP TABLE IF EXISTS `round`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `round` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(45) NOT NULL,
  `season_id` int(11) NOT NULL,
  `deleted` tinyint(4) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`),
  KEY `fk_Round_Season1_idx` (`season_id`),
  CONSTRAINT `fk_Round_Season1` FOREIGN KEY (`season_id`) REFERENCES `season` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `round`
--

LOCK TABLES `round` WRITE;
/*!40000 ALTER TABLE `round` DISABLE KEYS */;
INSERT INTO `round` VALUES (13,'09.04.2018',10,0),(14,'16.04.2018',10,0),(15,'17.09.2018',11,0),(16,'24.09.2018',11,0),(17,'01.10.2018',11,0);
/*!40000 ALTER TABLE `round` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `round_question`
--

DROP TABLE IF EXISTS `round_question`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `round_question` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `question_number` int(11) NOT NULL,
  `round_id` int(11) NOT NULL,
  `question_id` int(11) NOT NULL,
  `deleted` tinyint(4) NOT NULL DEFAULT '0',
  `points` double NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`),
  KEY `fk_Round_has_Question_Question1_idx` (`question_id`),
  KEY `fk_Round_has_Question_Round_idx` (`round_id`),
  CONSTRAINT `fk_Round_has_Question_Question1` FOREIGN KEY (`question_id`) REFERENCES `question` (`id`),
  CONSTRAINT `fk_Round_has_Question_Round` FOREIGN KEY (`round_id`) REFERENCES `round` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=39 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `round_question`
--

LOCK TABLES `round_question` WRITE;
/*!40000 ALTER TABLE `round_question` DISABLE KEYS */;
INSERT INTO `round_question` VALUES (18,1,17,23,0,1),(19,3,17,22,0,1),(20,2,17,18,0,1),(21,4,17,16,0,2),(22,1,16,19,0,1),(23,2,16,25,0,1),(24,3,16,17,0,1),(25,4,16,20,0,2),(26,1,15,24,0,1),(27,2,15,21,0,1.5),(28,3,15,26,0,1),(29,4,15,27,0,1),(30,5,15,28,0,1),(31,5,17,32,0,1),(32,5,16,30,0,1),(33,3,13,33,0,1),(34,2,14,31,0,1.5),(35,3,14,37,0,1),(36,1,14,35,0,1),(37,1,13,34,0,1),(38,2,13,36,0,1);
/*!40000 ALTER TABLE `round_question` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `season`
--

DROP TABLE IF EXISTS `season`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `season` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(45) NOT NULL,
  `deleted` tinyint(4) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `season`
--

LOCK TABLES `season` WRITE;
/*!40000 ALTER TABLE `season` DISABLE KEYS */;
INSERT INTO `season` VALUES (10,'Proljeće 2018',0),(11,'Jesen 2018',0);
/*!40000 ALTER TABLE `season` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `season_has_team`
--

DROP TABLE IF EXISTS `season_has_team`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `season_has_team` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `season_id` int(11) NOT NULL,
  `team_id` int(11) NOT NULL,
  `total` double NOT NULL DEFAULT '0',
  `deleted` tinyint(4) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`),
  KEY `fk_Season_has_Team_Team1_idx` (`team_id`),
  KEY `fk_Season_has_Team_Season1_idx` (`season_id`),
  CONSTRAINT `fk_Season_has_Team_Season1` FOREIGN KEY (`season_id`) REFERENCES `season` (`id`),
  CONSTRAINT `fk_Season_has_Team_Team1` FOREIGN KEY (`team_id`) REFERENCES `team` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `season_has_team`
--

LOCK TABLES `season_has_team` WRITE;
/*!40000 ALTER TABLE `season_has_team` DISABLE KEYS */;
INSERT INTO `season_has_team` VALUES (8,11,13,123,0),(9,11,14,30,0),(10,11,15,71,0),(11,11,16,77.5,0),(12,11,17,20,0),(13,11,18,0,1),(14,11,19,34,0),(15,10,19,72,0),(16,10,13,58,0),(17,10,20,36,0),(18,10,21,41,0);
/*!40000 ALTER TABLE `season_has_team` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `team`
--

DROP TABLE IF EXISTS `team`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `team` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(45) NOT NULL,
  `deleted` tinyint(4) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `team`
--

LOCK TABLES `team` WRITE;
/*!40000 ALTER TABLE `team` DISABLE KEYS */;
INSERT INTO `team` VALUES (13,'San Siro Duo',0),(14,'AK47',0),(15,'Bellot',0),(16,'Kikiriki u ljusci',0),(17,'Plava trava zaborava',0),(18,'Kikirik u ljusci',0),(19,'NS RS',0),(20,'Osmatrači',0),(21,'Tetkice',0);
/*!40000 ALTER TABLE `team` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `team_round`
--

DROP TABLE IF EXISTS `team_round`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `team_round` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `team_id` int(11) NOT NULL,
  `round_id` int(11) NOT NULL,
  `total` double NOT NULL DEFAULT '0',
  `deleted` tinyint(4) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`),
  KEY `fk_Team_has_Round_Round1_idx` (`round_id`),
  KEY `fk_Team_has_Round_Team1_idx` (`team_id`),
  CONSTRAINT `fk_Team_has_Round_Round1` FOREIGN KEY (`round_id`) REFERENCES `round` (`id`),
  CONSTRAINT `fk_Team_has_Round_Team1` FOREIGN KEY (`team_id`) REFERENCES `team` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `team_round`
--

LOCK TABLES `team_round` WRITE;
/*!40000 ALTER TABLE `team_round` DISABLE KEYS */;
INSERT INTO `team_round` VALUES (11,13,15,38,0),(12,14,15,30,0),(13,15,15,34,0),(14,16,15,40,0),(15,13,16,43,0),(16,15,16,37,0),(17,17,16,20,0),(18,18,17,0,1),(19,16,17,37.5,0),(20,13,17,42,0),(21,19,17,34,0),(22,19,13,40,0),(23,13,13,28,0),(24,20,13,36,0),(25,21,14,41,0),(26,13,14,30,0),(27,19,14,32,0);
/*!40000 ALTER TABLE `team_round` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-10-07 20:41:32
