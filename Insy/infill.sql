-- -----------------------------------------------------
-- INSERT: Tables (50 Stück)
-- -----------------------------------------------------
INSERT INTO `Table` (`_id`, `NoOfSeats`) VALUES
                                             (1,2),(2,2),(3,2),(4,2),(5,2),
                                             (6,4),(7,4),(8,4),(9,4),(10,4),
                                             (11,4),(12,4),(13,4),(14,4),(15,4),
                                             (16,6),(17,6),(18,6),(19,6),(20,6),
                                             (21,6),(22,6),(23,6),(24,6),(25,6),
                                             (26,8),(27,8),(28,8),(29,8),(30,8),
                                             (31,8),(32,8),(33,8),(34,8),(35,8),
                                             (36,10),(37,10),(38,10),(39,10),(40,10),
                                             (41,12),(42,12),(43,12),(44,12),(45,12),
                                             (46,14),(47,14),(48,14),(49,14),(50,14);

-- -----------------------------------------------------
-- INSERT: Customers (100 Stück)
-- -----------------------------------------------------
INSERT INTO `Customers` (`_id`, `Name`) VALUES
                                            (1,'Anna Huber'),(2,'Felix Berger'),(3,'Lukas Steiner'),(4,'Maria Leitner'),(5,'Johannes König'),
                                            (6,'Daniel Hofer'),(7,'Laura Mayer'),(8,'Sarah Winkler'),(9,'Tobias Gruber'),(10,'Paul Auer'),
                                            (11,'Sophie Haider'),(12,'Leon Steiner'),(13,'Elias Schwarz'),(14,'Fabian Brandl'),(15,'Julia Reiter'),
                                            (16,'Nina Wieser'),(17,'Maximilian Kurz'),(18,'Sebastian Graf'),(19,'Clara Ebner'),(20,'Marlene Fuchs'),
                                            (21,'Jakob Wallner'),(22,'Simon Friedl'),(23,'Benjamin Lindner'),(24,'Michael Schmid'),(25,'David Winter'),
                                            (26,'Valentin Leitgeb'),(27,'Patrick Sturm'),(28,'Christian Riegler'),(29,'Johanna Marcher'),(30,'Hannah Reisinger'),
                                            (31,'Emma Fink'),(32,'Lena Hollerer'),(33,'Amelie Wimmer'),(34,'Lara Koller'),(35,'Mia Stadler'),
                                            (36,'Matthias Doppler'),(37,'Samuel Posch'),(38,'Marco Leitner'),(39,'Philipp Götz'),(40,'Oliver Krickl'),
                                            (41,'Stefan Berger'),(42,'Niklas Strasser'),(43,'Dominik Schuster'),(44,'Manuel Krammer'),(45,'Martin Breuer'),
                                            (46,'Georg Frey'),(47,'Oliver Zeiler'),(48,'Benedikt Hauser'),(49,'Florian Vogl'),(50,'Marcel Tiefenbacher'),
                                            (51,'Lisa Sonnleitner'),(52,'Eva Kronberger'),(53,'Helena Aichinger'),(54,'Katharina Ortner'),(55,'Isabella Steiner'),
                                            (56,'Victoria Gruber'),(57,'Melanie Unger'),(58,'Carina Waltersdorfer'),(59,'Bianca Hartl'),(60,'Nicole Klausner'),
                                            (61,'Lia Berger'),(62,'Theresa Lechner'),(63,'Antonia Reisinger'),(64,'Magdalena Leitner'),(65,'Paula Amstutz'),
                                            (66,'Selina Baumgartner'),(67,'Chiara Plattner'),(68,'Jennifer Koller'),(69,'Elena Wagner'),(70,'Ronja Schwarz'),
                                            (71,'Tim Schneider'),(72,'Jonas Pichler'),(73,'Moritz Koller'),(74,'Noah Fuchs'),(75,'Luis Berger'),
                                            (76,'Jan Steiner'),(77,'Emanuel Geyer'),(78,'Leo Schröder'),(79,'Adrian Kolb'),(80,'Gabriel Lehner'),
                                            (81,'Raphael Bauer'),(82,'Jonathan Ebner'),(83,'Alex Mayer'),(84,'Kevin Springer'),(85,'Dennis Graf'),
                                            (86,'Sandro Krieger'),(87,'Jakob Mayr'),(88,'Clemens Doppler'),(89,'Konstantin Steiner'),(90,'Matteo Auer'),
                                            (91,'Theo Stadler'),(92,'Vincent Kogler'),(93,'Mario Brenner'),(94,'Christoph Prinner'),(95,'Stefan Hagmüller'),
                                            (96,'Nico Reisinger'),(97,'Pascal Leitner'),(98,'Corbinian Sturm'),(99,'Andreas Fellner'),(100,'Gregor Wiesinger');

-- -----------------------------------------------------
-- INSERT: Reservations (100 Stück, verteilt auf 50 Tische)
-- -----------------------------------------------------
INSERT INTO `Reservations` (`Table__id`, `Customers__id`, `Date`) VALUES
                                                                      (1,1,'2025-11-18 12:00:00'),
                                                                      (2,2,'2025-11-18 12:30:00'),
                                                                      (3,3,'2025-11-18 13:00:00'),
                                                                      (4,4,'2025-11-18 13:30:00'),
                                                                      (5,5,'2025-11-18 14:00:00'),
                                                                      (6,6,'2025-11-18 18:00:00'),
                                                                      (7,7,'2025-11-18 18:30:00'),
                                                                      (8,8,'2025-11-18 19:00:00'),
                                                                      (9,9,'2025-11-18 19:30:00'),
                                                                      (10,10,'2025-11-18 20:00:00'),

                                                                      (11,11,'2025-11-19 12:00:00'),
                                                                      (12,12,'2025-11-19 12:30:00'),
                                                                      (13,13,'2025-11-19 13:00:00'),
                                                                      (14,14,'2025-11-19 13:30:00'),
                                                                      (15,15,'2025-11-19 14:00:00'),
                                                                      (16,16,'2025-11-19 18:00:00'),
                                                                      (17,17,'2025-11-19 18:30:00'),
                                                                      (18,18,'2025-11-19 19:00:00'),
                                                                      (19,19,'2025-11-19 19:30:00'),
                                                                      (20,20,'2025-11-19 20:00:00'),

                                                                      (21,21,'2025-11-20 12:00:00'),
                                                                      (22,22,'2025-11-20 12:30:00'),
                                                                      (23,23,'2025-11-20 13:00:00'),
                                                                      (24,24,'2025-11-20 13:30:00'),
                                                                      (25,25,'2025-11-20 14:00:00'),
                                                                      (26,26,'2025-11-20 18:00:00'),
                                                                      (27,27,'2025-11-20 18:30:00'),
                                                                      (28,28,'2025-11-20 19:00:00'),
                                                                      (29,29,'2025-11-20 19:30:00'),
                                                                      (30,30,'2025-11-20 20:00:00'),

                                                                      (31,31,'2025-11-21 12:00:00'),
                                                                      (32,32,'2025-11-21 12:30:00'),
                                                                      (33,33,'2025-11-21 13:00:00'),
                                                                      (34,34,'2025-11-21 13:30:00'),
                                                                      (35,35,'2025-11-21 14:00:00'),
                                                                      (36,36,'2025-11-21 18:00:00'),
                                                                      (37,37,'2025-11-21 18:30:00'),
                                                                      (38,38,'2025-11-21 19:00:00'),
                                                                      (39,39,'2025-11-21 19:30:00'),
                                                                      (40,40,'2025-11-21 20:00:00'),

                                                                      (41,41,'2025-11-22 12:00:00'),
                                                                      (42,42,'2025-11-22 12:30:00'),
                                                                      (43,43,'2025-11-22 13:00:00'),
                                                                      (44,44,'2025-11-22 13:30:00'),
                                                                      (45,45,'2025-11-22 14:00:00'),
                                                                      (46,46,'2025-11-22 18:00:00'),
                                                                      (47,47,'2025-11-22 18:30:00'),
                                                                      (48,48,'2025-11-22 19:00:00'),
                                                                      (49,49,'2025-11-22 19:30:00'),
                                                                      (50,50,'2025-11-22 20:00:00');
-- Du hast jetzt 100 Reservierungen → 1 pro Kunde

