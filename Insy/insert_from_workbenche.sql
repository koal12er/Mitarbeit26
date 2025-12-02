-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema eins_zu_n_beziehung
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema eins_zu_n_beziehung
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `eins_zu_n_beziehung` DEFAULT CHARACTER SET utf8 ;
USE `eins_zu_n_beziehung` ;

-- -----------------------------------------------------
-- Table `eins_zu_n_beziehung`.`Fahrzeuge`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `eins_zu_n_beziehung`.`Fahrzeuge` (
                                                                 `_id` INT NOT NULL,
                                                                 `Beziehung` VARCHAR(45) NULL,
                                                                 PRIMARY KEY (`_id`))
    ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `eins_zu_n_beziehung`.`Raeder`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `eins_zu_n_beziehung`.`Raeder` (
                                                              `_id` INT NOT NULL,
                                                              `Durchmesser` VARCHAR(45) NOT NULL,
                                                              `Fahrzeuge__id` INT NOT NULL,
                                                              `Bezeichnung` VARCHAR(45) NULL,
                                                              PRIMARY KEY (`_id`),
                                                              INDEX `fk_Raeder_Fahrzeuge_idx` (`Fahrzeuge__id` ASC) VISIBLE,
                                                              CONSTRAINT `fk_Raeder_Fahrzeuge`
                                                                  FOREIGN KEY (`Fahrzeuge__id`)
                                                                      REFERENCES `eins_zu_n_beziehung`.`Fahrzeuge` (`_id`)
                                                                      ON DELETE NO ACTION
                                                                      ON UPDATE NO ACTION)
    ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `eins_zu_n_beziehung`.`Gebäude`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `eins_zu_n_beziehung`.`Gebäude` (
                                                               `_id` INT NOT NULL,
                                                               `Beziehung` VARCHAR(45) NULL,
                                                               PRIMARY KEY (`_id`))
    ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `eins_zu_n_beziehung`.`Raeume`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `eins_zu_n_beziehung`.`Raeume` (
                                                              `_id` INT NOT NULL,
                                                              `Groeße` VARCHAR(45) NOT NULL,
                                                              `Bezeichnung` VARCHAR(45) NULL,
                                                              `Gebäude__id` INT NOT NULL,
                                                              PRIMARY KEY (`_id`, `Gebäude__id`),
                                                              INDEX `fk_Raeume_Gebäude1_idx` (`Gebäude__id` ASC) VISIBLE,
                                                              CONSTRAINT `fk_Raeume_Gebäude1`
                                                                  FOREIGN KEY (`Gebäude__id`)
                                                                      REFERENCES `eins_zu_n_beziehung`.`Gebäude` (`_id`)
                                                                      ON DELETE NO ACTION
                                                                      ON UPDATE NO ACTION)
    ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
