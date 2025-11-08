-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema bdregistromultas
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema bdregistromultas
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `bdregistromultas` DEFAULT CHARACTER SET utf8 ;
USE `bdregistromultas` ;

-- -----------------------------------------------------
-- Table `bdregistromultas`.`Veiculo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bdregistromultas`.`Veiculo` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `Modelo` VARCHAR(50) NULL,
  `Marca` VARCHAR(50) NULL,
  `Placa` VARCHAR(50) NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `bdregistromultas`.`Multa`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bdregistromultas`.`Multa` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `Descricao` VARCHAR(50) NULL,
  `ValorMulta` DECIMAL NULL,
  `VeiculoId` INT NOT NULL,
  PRIMARY KEY (`Id`),
  INDEX `fk_Multa_Veiculo_idx` (`VeiculoId` ASC) VISIBLE,
  CONSTRAINT `fk_Multa_Veiculo`
    FOREIGN KEY (`VeiculoId`)
    REFERENCES `bdregistromultas`.`Veiculo` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
