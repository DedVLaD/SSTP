-- MySQL Script generated by MySQL Workbench
-- Mon Feb 12 14:15:13 2024
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema BS_BAIKAL
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema BS_BAIKAL
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `BS_BAIKAL` DEFAULT CHARACTER SET utf8mb4 ;
USE `BS_BAIKAL` ;

-- -----------------------------------------------------
-- Table `BS_BAIKAL`.`users`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BS_BAIKAL`.`users` (
  `id_user` CHAR(10) CHARACTER SET 'utf8mb4' NOT NULL,
  `us_lname` VARCHAR(45) NOT NULL,
  `us_fname` VARCHAR(45) NOT NULL,
  `us_otch` VARCHAR(45) NOT NULL,
  `us_dateOfBirth` DATE NOT NULL,
  PRIMARY KEY (`id_user`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BS_BAIKAL`.`positions`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BS_BAIKAL`.`positions` (
  `id_position` CHAR(10) CHARACTER SET 'utf8mb4' NOT NULL,
  `title_position` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id_position`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BS_BAIKAL`.`authorization_users`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BS_BAIKAL`.`authorization_users` (
  `id_user` CHAR(10) CHARACTER SET 'utf8mb4' NOT NULL,
  `id_position` CHAR(10) CHARACTER SET 'utf8mb4' NOT NULL,
  `login` VARCHAR(45) NOT NULL,
  `password` VARCHAR(100) NOT NULL,
  INDEX `fk_authorization_users_positions1_idx` (`id_position` ASC) VISIBLE,
  CONSTRAINT `fk_authorization_users_users1`
    FOREIGN KEY (`id_user`)
    REFERENCES `BS_BAIKAL`.`users` (`id_user`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `fk_authorization_users_positions1`
    FOREIGN KEY (`id_position`)
    REFERENCES `BS_BAIKAL`.`positions` (`id_position`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BS_BAIKAL`.`labels`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BS_BAIKAL`.`labels` (
  `id_label` INT NOT NULL AUTO_INCREMENT,
  `title_label` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id_label`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BS_BAIKAL`.`titleGP`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BS_BAIKAL`.`titleGP` (
  `id_titleGP` INT NOT NULL AUTO_INCREMENT,
  `titleGP` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id_titleGP`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BS_BAIKAL`.`container`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BS_BAIKAL`.`container` (
  `id_container` INT NOT NULL AUTO_INCREMENT,
  `title_container` VARCHAR(45) NULL,
  PRIMARY KEY (`id_container`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BS_BAIKAL`.`location`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BS_BAIKAL`.`location` (
  `id_location` INT NOT NULL AUTO_INCREMENT,
  `title_location` VARCHAR(45) NULL,
  PRIMARY KEY (`id_location`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BS_BAIKAL`.`status`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BS_BAIKAL`.`status` (
  `id_status` INT NOT NULL AUTO_INCREMENT,
  `title_status` VARCHAR(45) NULL,
  PRIMARY KEY (`id_status`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BS_BAIKAL`.`customers`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BS_BAIKAL`.`customers` (
  `id_customer` INT NOT NULL AUTO_INCREMENT,
  `name_customer` VARCHAR(200) NOT NULL,
  `telephone` VARCHAR(150) NOT NULL,
  `adress` VARCHAR(300) NOT NULL,
  PRIMARY KEY (`id_customer`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BS_BAIKAL`.`orders`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BS_BAIKAL`.`orders` (
  `id_order` INT NOT NULL AUTO_INCREMENT,
  `id_customer` INT NOT NULL,
  `data_order_formation` DATE NOT NULL,
  `end_date_agreement` DATE NOT NULL,
  `id_label` INT NOT NULL,
  `id_titleGP` INT NOT NULL,
  `id_container` INT NOT NULL,
  `id_location` INT NOT NULL,
  `id_status` INT NOT NULL,
  PRIMARY KEY (`id_order`),
  INDEX `fk_id_label_idx` (`id_label` ASC) VISIBLE,
  INDEX `fk_id_titleGP_idx` (`id_titleGP` ASC) VISIBLE,
  INDEX `fk_id_container_idx` (`id_container` ASC) VISIBLE,
  INDEX `fk_id_location_idx` (`id_location` ASC) VISIBLE,
  INDEX `fk_id_status_idx` (`id_status` ASC) VISIBLE,
  INDEX `fk_id_customer_idx` (`id_customer` ASC) VISIBLE,
  CONSTRAINT `fk_id_label`
    FOREIGN KEY (`id_label`)
    REFERENCES `BS_BAIKAL`.`labels` (`id_label`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `fk_id_titleGP`
    FOREIGN KEY (`id_titleGP`)
    REFERENCES `BS_BAIKAL`.`titleGP` (`id_titleGP`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `fk_id_container`
    FOREIGN KEY (`id_container`)
    REFERENCES `BS_BAIKAL`.`container` (`id_container`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `fk_id_location`
    FOREIGN KEY (`id_location`)
    REFERENCES `BS_BAIKAL`.`location` (`id_location`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `fk_id_status`
    FOREIGN KEY (`id_status`)
    REFERENCES `BS_BAIKAL`.`status` (`id_status`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `fk_id_customer`
    FOREIGN KEY (`id_customer`)
    REFERENCES `BS_BAIKAL`.`customers` (`id_customer`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BS_BAIKAL`.`compositionOrder`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BS_BAIKAL`.`compositionOrder` (
  `id_composition_order` INT NOT NULL,
  `composition_order` VARCHAR(400) NULL,
  `passport` VARCHAR(150) NULL,
  `weight_kg` VARCHAR(150) NULL,
  INDEX `fk_id_order_idx` (`id_composition_order` ASC) VISIBLE,
  PRIMARY KEY (`id_composition_order`),
  CONSTRAINT `fk_id_composition_order`
    FOREIGN KEY (`id_composition_order`)
    REFERENCES `BS_BAIKAL`.`orders` (`id_order`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BS_BAIKAL`.`productBatchGP`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BS_BAIKAL`.`productBatchGP` (
  `id_productBatchGP` INT NOT NULL AUTO_INCREMENT,
  `id_composition_order` INT NOT NULL,
  `begin_production_date` DATE NOT NULL,
  `end_production_date` DATE NULL,
  `viscosity` VARCHAR(45) NULL,
  `electrical_capacity` VARCHAR(45) NULL,
  PRIMARY KEY (`id_productBatchGP`),
  CONSTRAINT `fk_id_composition_order1`
    FOREIGN KEY (`id_composition_order`)
    REFERENCES `BS_BAIKAL`.`compositionOrder` (`id_composition_order`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BS_BAIKAL`.`productBatchPAYAK`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BS_BAIKAL`.`productBatchPAYAK` (
  `id_productBatchPAYAK` INT NOT NULL AUTO_INCREMENT,
  `id_productBatchGP_PAYAK` INT NOT NULL,
  `begin_production_date_PAYAK` DATE NOT NULL,
  `end_production_date_PAYAK` DATE NULL,
  `acid_number_PAYAK` VARCHAR(45) NULL,
  `comment_PAYAK` VARCHAR(300) NULL,
  PRIMARY KEY (`id_productBatchPAYAK`),
  INDEX `fk_id_productBatchGP_PAYAK_idx` (`id_productBatchGP_PAYAK` ASC) VISIBLE,
  CONSTRAINT `fk_id_productBatchGP_PAYAK`
    FOREIGN KEY (`id_productBatchGP_PAYAK`)
    REFERENCES `BS_BAIKAL`.`productBatchGP` (`id_productBatchGP`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BS_BAIKAL`.`productBatchEOK`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BS_BAIKAL`.`productBatchEOK` (
  `id_productBatchEOK` INT NOT NULL AUTO_INCREMENT,
  `id_productBatchGP_EOK` INT NOT NULL,
  `begin_production_date_EOK` DATE NOT NULL,
  `end_production_date_EOK` DATE NULL,
  `acid_number_EOK` VARCHAR(45) NULL,
  `comment_EOK` VARCHAR(300) NULL,
  PRIMARY KEY (`id_productBatchEOK`),
  INDEX `fk_id_productBatchGP_EOK_idx` (`id_productBatchGP_EOK` ASC) VISIBLE,
  CONSTRAINT `fk_id_productBatchGP_EOK`
    FOREIGN KEY (`id_productBatchGP_EOK`)
    REFERENCES `BS_BAIKAL`.`productBatchGP` (`id_productBatchGP`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
