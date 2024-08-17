-- MySQL dump 10.13  Distrib 8.0.38, for Win64 (x86_64)
--
-- Host: 192.168.0.38    Database: Livraria
-- ------------------------------------------------------
-- Server version	5.7.34

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
-- Table structure for table `Autor`
--

DROP TABLE IF EXISTS `Autor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Autor` (
  `AutorId` int(11) NOT NULL AUTO_INCREMENT,
  `AutorNome` varchar(50) NOT NULL,
  PRIMARY KEY (`AutorId`),
  UNIQUE KEY `AutorNome` (`AutorNome`)
) ENGINE=MyISAM AUTO_INCREMENT=21 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Autor`
--

LOCK TABLES `Autor` WRITE;
/*!40000 ALTER TABLE `Autor` DISABLE KEYS */;
INSERT INTO `Autor` VALUES (1,'J.K. Rowling'),(2,'George R.R. Martin'),(3,'J.R.R. Tolkien'),(4,'Gabriel García Márquez'),(5,'Machado de Assis'),(6,'Clarice Lispector'),(7,'Paulo Coelho'),(8,'Monteiro Lobato'),(9,'José Saramago'),(10,'João Ubaldo Ribeiro'),(11,'Desconhecido'),(12,'blabla '),(13,'Denisson Gomes'),(14,'F'),(15,''),(16,'Sem nome'),(17,'d'),(18,'FD'),(19,'Stephen King'),(20,'3');
/*!40000 ALTER TABLE `Autor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Categoria`
--

DROP TABLE IF EXISTS `Categoria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Categoria` (
  `CategoriaId` int(11) NOT NULL AUTO_INCREMENT,
  `CategoriaNome` varchar(50) NOT NULL,
  PRIMARY KEY (`CategoriaId`),
  UNIQUE KEY `CategoriaNome` (`CategoriaNome`)
) ENGINE=MyISAM AUTO_INCREMENT=18 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Categoria`
--

LOCK TABLES `Categoria` WRITE;
/*!40000 ALTER TABLE `Categoria` DISABLE KEYS */;
INSERT INTO `Categoria` VALUES (1,'Ficção'),(2,'Fantasia'),(3,'Romance'),(4,'Aventura'),(5,'História'),(6,'Suspense'),(7,'Drama'),(8,'Mistério'),(9,'Ciência Fiction'),(10,'Literatura Brasileira'),(11,'blablabla'),(12,'Vencedor'),(13,'G'),(14,''),(15,'DG'),(16,'Terror'),(17,'4');
/*!40000 ALTER TABLE `Categoria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Editora`
--

DROP TABLE IF EXISTS `Editora`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Editora` (
  `EditoraId` int(11) NOT NULL AUTO_INCREMENT,
  `EditoraNome` varchar(50) NOT NULL,
  PRIMARY KEY (`EditoraId`),
  UNIQUE KEY `EditoraNome` (`EditoraNome`)
) ENGINE=MyISAM AUTO_INCREMENT=20 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Editora`
--

LOCK TABLES `Editora` WRITE;
/*!40000 ALTER TABLE `Editora` DISABLE KEYS */;
INSERT INTO `Editora` VALUES (1,'Companhia das Letras'),(2,'Editora Record'),(3,'Rocco'),(4,'Editora Globo'),(5,'LPM'),(6,'Planeta'),(7,'Saraiva'),(8,'Editora Novo Século'),(9,'Editora Objetiva'),(10,'Editora Moderna'),(11,'Sem nome'),(12,'bla '),(13,'Denni Corp.'),(14,'S'),(15,''),(16,'d'),(17,'SD'),(18,'Raio Azul'),(19,'2');
/*!40000 ALTER TABLE `Editora` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `GetLivroData`
--

DROP TABLE IF EXISTS `GetLivroData`;
/*!50001 DROP VIEW IF EXISTS `GetLivroData`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `GetLivroData` AS SELECT 
 1 AS `LivroId`,
 1 AS `Titulo`,
 1 AS `ISBN`,
 1 AS `EditoraNome`,
 1 AS `AutorNome`,
 1 AS `CategoriaNome`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `GetLivrosData`
--

DROP TABLE IF EXISTS `GetLivrosData`;
/*!50001 DROP VIEW IF EXISTS `GetLivrosData`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `GetLivrosData` AS SELECT 
 1 AS `LivroId`,
 1 AS `Titulo`,
 1 AS `ISBN`,
 1 AS `EditoraNome`,
 1 AS `AutorNome`,
 1 AS `CategoriaNome`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `Livro`
--

DROP TABLE IF EXISTS `Livro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Livro` (
  `LivroId` int(11) NOT NULL AUTO_INCREMENT,
  `Titulo` varchar(50) NOT NULL,
  `ISBN` varchar(20) NOT NULL,
  `EditoraId` int(11) NOT NULL,
  `AutorId` int(11) NOT NULL,
  `CategoriaId` int(11) NOT NULL,
  PRIMARY KEY (`LivroId`),
  UNIQUE KEY `Titulo` (`Titulo`),
  KEY `EditoraId` (`EditoraId`),
  KEY `AutorId` (`AutorId`),
  KEY `CategoriaId` (`CategoriaId`)
) ENGINE=MyISAM AUTO_INCREMENT=17 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Livro`
--

LOCK TABLES `Livro` WRITE;
/*!40000 ALTER TABLE `Livro` DISABLE KEYS */;
INSERT INTO `Livro` VALUES (2,'As Crônicas de Gelo e Fogo','978-85-01-06827-7',2,2,2),(3,'O Senhor dos Anéis','978-85-07-02476-7',3,3,2),(4,'Cem Anos de Solidão','978-85-07-12030-4',4,4,1),(5,'Dom Casmurro 3','978-85-07-09752-3',5,5,10),(6,'A Hora da Estrela','978-85-07-14445-8',4,6,1),(7,'O Alquimista','978-85-07-14395-6',7,7,1),(8,'O Sítio do Picapau Amarelo','978-85-07-02012-8',8,8,1),(9,'Ensaio sobre a cegueira','978-85-07-14335-2',9,9,1),(10,'Viva o Povo Brasileiro','978-85-07-13610-1',10,10,10),(11,'Era uma vez','010101',11,11,7);
/*!40000 ALTER TABLE `Livro` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Final view structure for view `GetLivroData`
--

/*!50001 DROP VIEW IF EXISTS `GetLivroData`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `GetLivroData` AS select `l`.`LivroId` AS `LivroId`,`l`.`Titulo` AS `Titulo`,`l`.`ISBN` AS `ISBN`,`e`.`EditoraNome` AS `EditoraNome`,`a`.`AutorNome` AS `AutorNome`,`c`.`CategoriaNome` AS `CategoriaNome` from (((`Livro` `l` join `Editora` `e` on((`l`.`EditoraId` = `e`.`EditoraId`))) join `Autor` `a` on((`l`.`AutorId` = `a`.`AutorId`))) join `Categoria` `c` on((`l`.`CategoriaId` = `c`.`CategoriaId`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `GetLivrosData`
--

/*!50001 DROP VIEW IF EXISTS `GetLivrosData`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `GetLivrosData` AS select `l`.`LivroId` AS `LivroId`,`l`.`Titulo` AS `Titulo`,`l`.`ISBN` AS `ISBN`,`e`.`EditoraNome` AS `EditoraNome`,`a`.`AutorNome` AS `AutorNome`,`c`.`CategoriaNome` AS `CategoriaNome` from (((`Livro` `l` join `Editora` `e` on((`l`.`EditoraId` = `e`.`EditoraId`))) join `Autor` `a` on((`l`.`AutorId` = `a`.`AutorId`))) join `Categoria` `c` on((`l`.`CategoriaId` = `c`.`CategoriaId`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-08-15 14:09:26
