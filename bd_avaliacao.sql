-- --------------------------------------------------------
-- Anfitrião:                    127.0.0.1
-- Versão do servidor:           10.4.27-MariaDB - mariadb.org binary distribution
-- SO do servidor:               Win64
-- HeidiSQL Versão:              12.6.0.6765
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- A despejar estrutura da base de dados para evaluation-form
DROP DATABASE IF EXISTS `evaluation-form`;
CREATE DATABASE IF NOT EXISTS `evaluation-form` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */;
USE `evaluation-form`;

-- A despejar estrutura para tabela evaluation-form.dados_aluno
DROP TABLE IF EXISTS `dados_aluno`;
CREATE TABLE IF NOT EXISTS `dados_aluno` (
  `id_aluno` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  `apelido` varchar(140) NOT NULL,
  `escola` varchar(255) NOT NULL,
  PRIMARY KEY (`id_aluno`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Exportação de dados não seleccionada.

-- A despejar estrutura para tabela evaluation-form.perguntas_avaliacao
DROP TABLE IF EXISTS `perguntas_avaliacao`;
CREATE TABLE IF NOT EXISTS `perguntas_avaliacao` (
  `id_resposta` int(11) NOT NULL AUTO_INCREMENT,
  `curso_frequentado` varchar(90) NOT NULL,
  `atividade_gostou` varchar(140) NOT NULL,
  `porque_gostou` varchar(255) NOT NULL,
  `not_final` int(11) DEFAULT NULL,
  `id_aluno` int(11) NOT NULL,
  PRIMARY KEY (`id_resposta`,`id_aluno`) USING BTREE,
  KEY `FK_perguntas_avaliacao_dados_aluno` (`id_aluno`),
  CONSTRAINT `FK_perguntas_avaliacao_dados_aluno` FOREIGN KEY (`id_aluno`) REFERENCES `dados_aluno` (`id_aluno`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Exportação de dados não seleccionada.

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;