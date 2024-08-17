CREATE DATABASE  IF NOT EXISTS `minhabiblioteca` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `minhabiblioteca`;
-- MySQL dump 10.13  Distrib 8.0.38, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: minhabiblioteca
-- ------------------------------------------------------
-- Server version	8.0.39

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
-- Table structure for table `autor`
--

DROP TABLE IF EXISTS `autor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `autor` (
  `AutorId` int NOT NULL AUTO_INCREMENT,
  `AutorNome` varchar(50) NOT NULL,
  PRIMARY KEY (`AutorId`),
  UNIQUE KEY `AutorNome` (`AutorNome`)
) ENGINE=MyISAM AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `autor`
--

LOCK TABLES `autor` WRITE;
/*!40000 ALTER TABLE `autor` DISABLE KEYS */;
INSERT INTO `autor` VALUES (1,'J.K. Rowling'),(2,'George R.R. Martin'),(3,'J.R.R. Tolkien'),(4,'Gabriel García Márquez'),(5,'Machado de Assis'),(6,'Clarice Lispector'),(7,'Paulo Coelho'),(8,'Monteiro Lobato'),(9,'José Saramago'),(10,'João Ubaldo Ribeiro'),(11,'Desconhecido'),(12,'blabla '),(13,'Denisson Gomes'),(14,'F'),(15,''),(16,'Sem nome'),(17,'d'),(18,'FD'),(19,'Stephen King'),(20,'3');
/*!40000 ALTER TABLE `autor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categoria`
--

DROP TABLE IF EXISTS `categoria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categoria` (
  `CategoriaId` int NOT NULL AUTO_INCREMENT,
  `CategoriaNome` varchar(50) NOT NULL,
  PRIMARY KEY (`CategoriaId`),
  UNIQUE KEY `CategoriaNome` (`CategoriaNome`)
) ENGINE=MyISAM AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categoria`
--

LOCK TABLES `categoria` WRITE;
/*!40000 ALTER TABLE `categoria` DISABLE KEYS */;
INSERT INTO `categoria` VALUES (1,'Ficção'),(2,'Fantasia'),(3,'Romance'),(4,'Aventura'),(5,'História'),(6,'Suspense'),(7,'Drama'),(8,'Mistério'),(9,'Ciência Fiction'),(10,'Literatura Brasileira'),(11,'blablabla'),(12,'Vencedor'),(13,'G'),(14,''),(15,'DG'),(16,'Terror'),(17,'4');
/*!40000 ALTER TABLE `categoria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `editora`
--

DROP TABLE IF EXISTS `editora`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `editora` (
  `EditoraId` int NOT NULL AUTO_INCREMENT,
  `EditoraNome` varchar(50) NOT NULL,
  PRIMARY KEY (`EditoraId`),
  UNIQUE KEY `EditoraNome` (`EditoraNome`)
) ENGINE=MyISAM AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `editora`
--

LOCK TABLES `editora` WRITE;
/*!40000 ALTER TABLE `editora` DISABLE KEYS */;
INSERT INTO `editora` VALUES (1,'Companhia das Letras'),(2,'Editora Record'),(3,'Rocco'),(4,'Editora Globo'),(5,'LPM'),(6,'Planeta'),(7,'Saraiva'),(8,'Editora Novo Século'),(9,'Editora Objetiva'),(10,'Editora Moderna'),(11,'Sem nome'),(12,'bla '),(13,'Denni Corp.'),(14,'S'),(15,''),(16,'d'),(17,'SD'),(18,'Raio Azul'),(19,'2');
/*!40000 ALTER TABLE `editora` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `getlivrodata`
--

DROP TABLE IF EXISTS `getlivrodata`;
/*!50001 DROP VIEW IF EXISTS `getlivrodata`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `getlivrodata` AS SELECT 
 1 AS `LivroId`,
 1 AS `Titulo`,
 1 AS `ISBN`,
 1 AS `EditoraNome`,
 1 AS `AutorNome`,
 1 AS `CategoriaNome`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `livro`
--

DROP TABLE IF EXISTS `livro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `livro` (
  `LivroId` int NOT NULL AUTO_INCREMENT,
  `Titulo` varchar(50) NOT NULL,
  `ISBN` varchar(20) NOT NULL,
  `EditoraId` int NOT NULL,
  `AutorId` int NOT NULL,
  `CategoriaId` int NOT NULL,
  PRIMARY KEY (`LivroId`),
  UNIQUE KEY `Titulo` (`Titulo`),
  KEY `EditoraId` (`EditoraId`),
  KEY `AutorId` (`AutorId`),
  KEY `CategoriaId` (`CategoriaId`)
) ENGINE=MyISAM AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `livro`
--

LOCK TABLES `livro` WRITE;
/*!40000 ALTER TABLE `livro` DISABLE KEYS */;
INSERT INTO `livro` VALUES (2,'As Crônicas de Gelo e Fogo','978-85-01-06827-7',2,2,2),(3,'O Senhor dos Anéis','978-85-07-02476-7',3,3,2),(4,'Cem Anos de Solidão','978-85-07-12030-4',4,4,1),(5,'Dom Casmurro 3','978-85-07-09752-3',5,5,10),(6,'A Hora da Estrela','978-85-07-14445-8',4,6,1),(7,'O Alquimista','978-85-07-14395-6',7,7,1),(8,'O Sítio do Picapau Amarelo','978-85-07-02012-8',8,8,1),(9,'Ensaio sobre a cegueira','978-85-07-14335-2',9,9,1),(10,'Viva o Povo Brasileiro','978-85-07-13610-1',10,10,10),(11,'Era uma vez','010101',11,11,7);
/*!40000 ALTER TABLE `livro` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios` (
  `usuario` varchar(16) NOT NULL,
  `senha` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES ('denni','1234'),('teste','teste');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'minhabiblioteca'
--

--
-- Dumping routines for database 'minhabiblioteca'
--
/*!50003 DROP PROCEDURE IF EXISTS `AtualizarLivro` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `AtualizarLivro`(
p_LivroId int,
p_Titulo varchar(50),
p_ISBN varchar(20),
p_EditoraNome varchar(50),
p_AutorNome varchar(50),
p_CategoriaNome varchar(50))
BEGIN
if not exists (select * from Categoria where CategoriaNome = p_CategoriaNome) then
INSERT INTO categoria (CategoriaNome) VALUES (p_CategoriaNome);
end if;
if not exists (select * from Autor where AutorNome = p_AutorNome) then
INSERT INTO Autor (AutorNome) VALUES (p_AutorNome);
end if;
if not exists (select * from Editora where EditoraNome = p_EditoraNome) then
INSERT INTO Editora (EditoraNome) VALUES (p_EditoraNome);
end if;
UPDATE Livro SET
Titulo = p_Titulo,
ISBN = p_ISBN,
EditoraId = (select EditoraId from Editora where EditoraNome = p_EditoraNome),
AutorId = (select AutorId from Autor where AutorNome = p_AutorNome),
CategoriaId = (select CategoriaId from Categoria where CategoriaNome = p_CategoriaNome)
WHERE LivroId = p_LivroId;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `CriarLivro` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`%` PROCEDURE `CriarLivro`(
p_Titulo varchar(50),
p_ISBN varchar(20),
p_EditoraNome varchar(50),
p_AutorNome varchar(50),
p_CategoriaNome varchar(50))
BEGIN
if not exists (select * from Categoria where CategoriaNome = p_CategoriaNome) then
INSERT INTO Categoria (CategoriaNome) VALUES (p_CategoriaNome);
end if;
if not exists (select * from Autor where AutorNome = p_AutorNome) then
INSERT INTO Autor (AutorNome) VALUES (p_AutorNome);
end if;
if not exists (select * from Editora where EditoraNome = p_EditoraNome) then
INSERT INTO Editora (EditoraNome) VALUES (p_EditoraNome);
end if;
if not exists (select * from Livro where Titulo = p_Titulo) then
INSERT INTO Livro (Titulo, ISBN, EditoraId, AutorId, CategoriaId)
VALUES
(
p_Titulo,
p_ISBN,
(select EditoraId from Editora where EditoraNome=p_EditoraNome),
(select AutorId from Autor where AutorNome=p_AutorNome),
(select CategoriaId from Categoria where CategoriaNome=p_CategoriaNome)
);
end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `DeletarLivro` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `DeletarLivro`(
p_LivroId int)
BEGIN
delete from Livro where LivroId=p_LivroId;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Final view structure for view `getlivrodata`
--

/*!50001 DROP VIEW IF EXISTS `getlivrodata`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `getlivrodata` AS select `l`.`LivroId` AS `LivroId`,`l`.`Titulo` AS `Titulo`,`l`.`ISBN` AS `ISBN`,`e`.`EditoraNome` AS `EditoraNome`,`a`.`AutorNome` AS `AutorNome`,`c`.`CategoriaNome` AS `CategoriaNome` from (((`livro` `l` join `editora` `e` on((`l`.`EditoraId` = `e`.`EditoraId`))) join `autor` `a` on((`l`.`AutorId` = `a`.`AutorId`))) join `categoria` `c` on((`l`.`CategoriaId` = `c`.`CategoriaId`))) */;
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

-- Dump completed on 2024-08-17 19:15:28
