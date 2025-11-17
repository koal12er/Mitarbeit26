-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema Restaurant
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema Restaurant
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `Restaurant` DEFAULT CHARACTER SET utf8 ;
USE `Restaurant` ;

-- -----------------------------------------------------
-- Table `Restaurant`.`Table`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Restaurant`.`Table` (
                                                    `_id` INT NOT NULL,
                                                    `NoOfSeats` INT NOT NULL,
                                                    PRIMARY KEY (`_id`))
    ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Restaurant`.`Customers`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Restaurant`.`Customers` (
                                                        `_id` INT NOT NULL,
                                                        `Name` VARCHAR(45) NULL,
    PRIMARY KEY (`_id`))
    ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Restaurant`.`Reservations`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Restaurant`.`Reservations` (
                                                           `Table__id` INT NOT NULL,
                                                           `Customers__id` INT NOT NULL,
                                                           `Date` DATETIME NOT NULL,
                                                           PRIMARY KEY (`Table__id`, `Customers__id`, `Date`),
    INDEX `fk_Table_has_Customers_Customers1_idx` (`Customers__id` ASC) VISIBLE,
    INDEX `fk_Table_has_Customers_Table_idx` (`Table__id` ASC) VISIBLE,
    CONSTRAINT `fk_Table_has_Customers_Table`
    FOREIGN KEY (`Table__id`)
    REFERENCES `Restaurant`.`Table` (`_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
    CONSTRAINT `fk_Table_has_Customers_Customers1`
    FOREIGN KEY (`Customers__id`)
    REFERENCES `Restaurant`.`Customers` (`_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
    ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
