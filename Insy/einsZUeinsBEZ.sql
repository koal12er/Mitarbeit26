-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema Chefs
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema Chefs
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `Chefs` DEFAULT CHARACTER SET utf8 ;
USE `Chefs` ;

-- -----------------------------------------------------
-- Table `Chefs`.`Staatschefs`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Chefs`.`Staatschefs` (
                                                     `_idStaatschef` INT NOT NULL,
                                                     `Firstname` VARCHAR(45) NULL,
    `Lastname` VARCHAR(45) NULL,
    `Age` INT NULL,
    PRIMARY KEY (`_idStaatschef`))
    ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Chefs`.`Staaten`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Chefs`.`Staaten` (
                                                 `_idStaaten` INT NOT NULL,
                                                 `Country` VARCHAR(45) NOT NULL,
    `Staatschefs__idStaatschef` INT NOT NULL,
    PRIMARY KEY (`_idStaaten`, `Country`),
    INDEX `fk_Staaten_Staatschefs_idx` (`Staatschefs__idStaatschef` ASC) VISIBLE,
    CONSTRAINT `fk_Staaten_Staatschefs`
    FOREIGN KEY (`Staatschefs__idStaatschef`)
    REFERENCES `Chefs`.`Staatschefs` (`_idStaatschef`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
    ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
