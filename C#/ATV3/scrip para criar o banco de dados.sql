-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema tarefapo
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema tarefapo
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `tarefapo` DEFAULT CHARACTER SET utf8 ;
USE `tarefapo` ;

-- -----------------------------------------------------
-- Table `tarefapo`.`Categoria`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `tarefapo`.`Categoria` (
  `IdCategoria` INT NOT NULL AUTO_INCREMENT,
  `Nome` VARCHAR(50) NULL,
  PRIMARY KEY (`IdCategoria`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `tarefapo`.`Secao`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `tarefapo`.`Secao` (
  `IdSecao` INT NOT NULL AUTO_INCREMENT,
  `Nome` VARCHAR(50) NULL,
  `Numero` VARCHAR(50) NULL,
  PRIMARY KEY (`IdSecao`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `tarefapo`.`Produto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `tarefapo`.`Produto` (
  `IdProduto` INT NOT NULL AUTO_INCREMENT,
  `Nome` VARCHAR(50) NULL,
  `Preco` DECIMAL NULL,
  `Quantidade` VARCHAR(45) NULL,
  `Categoria_IdCategoria` INT NOT NULL,
  `Secao_IdSecao` INT NOT NULL,
  PRIMARY KEY (`IdProduto`),
  INDEX `fk_Produto_Categoria_idx` (`Categoria_IdCategoria` ASC) VISIBLE,
  INDEX `fk_Produto_Secao1_idx` (`Secao_IdSecao` ASC) VISIBLE,
  CONSTRAINT `fk_Produto_Categoria`
    FOREIGN KEY (`Categoria_IdCategoria`)
    REFERENCES `tarefapo`.`Categoria` (`IdCategoria`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Produto_Secao1`
    FOREIGN KEY (`Secao_IdSecao`)
    REFERENCES `tarefapo`.`Secao` (`IdSecao`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
