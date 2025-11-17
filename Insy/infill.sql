-- -----------------------------------------------------
-- Infill / Beispiel-Daten für Restaurant
-- -----------------------------------------------------

USE `Restaurant`;

-- ---------------------------
-- Tables (Tische)
-- ---------------------------
INSERT INTO `Table` (`_id`, `NoOfSeats`) VALUES
                                             (1, 2),
                                             (2, 4),
                                             (3, 4),
                                             (4, 6),
                                             (5, 8);

-- ---------------------------
-- Customers (Kunden)
-- ---------------------------
INSERT INTO `Customers` (`_id`, `Name`) VALUES
                                            (1, 'Anna Huber'),
                                            (2, 'Felix Berger'),
                                            (3, 'Lukas Steiner'),
                                            (4, 'Maria Leitner'),
                                            (5, 'Johannes König');

-- ---------------------------
-- Reservations (Reservierungen)
-- ---------------------------
INSERT INTO `Reservations` (`Table__id`, `Customers__id`, `Date`) VALUES
                                                                      (1, 1, '2025-11-18 18:00:00'),
                                                                      (2, 2, '2025-11-18 19:30:00'),
                                                                      (3, 3, '2025-11-19 12:00:00'),
                                                                      (4, 4, '2025-11-19 20:00:00'),
                                                                      (2, 5, '2025-11-20 18:45:00');