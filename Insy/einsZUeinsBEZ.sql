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
-- Table `Chefs`.`Persons`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Chefs`.`Persons` (
                                                 `_id` INT NOT NULL,
                                                 `Name` VARCHAR(45) NULL,
                                                 PRIMARY KEY (`_id`))
    ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Chefs`.`Countries`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Chefs`.`Countries` (
                                                   `_id` INT NOT NULL,
                                                   `Name` VARCHAR(45) NOT NULL,
                                                   `Persons__id` INT NOT NULL,
                                                   PRIMARY KEY (`_id`, `Name`),
                                                   INDEX `fk_Countries_Persons_idx` (`Persons__id` ASC) VISIBLE,
                                                   UNIQUE INDEX `Persons__id_UNIQUE` (`Persons__id` ASC) VISIBLE,
                                                   CONSTRAINT `fk_Countries_Persons`
                                                       FOREIGN KEY (`Persons__id`)
                                                           REFERENCES `Chefs`.`Persons` (`_id`)
                                                           ON DELETE NO ACTION
                                                           ON UPDATE NO ACTION)
    ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
