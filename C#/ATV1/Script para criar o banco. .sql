-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema bd_registro
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema bd_registro
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `bd_registro` DEFAULT CHARACTER SET utf8 ;
USE `bd_registro` ;

-- -----------------------------------------------------
-- Table `bd_registro`.`Pessoa`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bd_registro`.`Pessoa` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `Nome` VARCHAR(50) NULL,
  `Cpf` VARCHAR(14) NULL,
  `RegistroGeral` VARCHAR(20) NULL,
  `Email` VARCHAR(45) NULL,
  PRIMARY KEY (`Id`))
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
