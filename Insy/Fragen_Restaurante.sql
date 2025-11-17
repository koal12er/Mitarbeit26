-- Wer hot derzeit koan Tisch reserviert?
SELECT c._id, c.Name
FROM Customers c
         LEFT JOIN Reservations r
                   ON c._id = r.Customers__id
WHERE r.Customers__id IS NULL;

-- Welche Tische san heute / an bestimmtem Datum frei?
SELECT t._id, t.NoOfSeats
FROM `Table` t
         LEFT JOIN Reservations r
                   ON t._id = r.Table__id
                       AND DATE(r.Date) = '2025-11-20'
WHERE r.Table__id IS NULL;

-- Wer hot mehr als einen Tisch am selben Tag reserviert?
SELECT r.Customers__id, c.Name, DATE(r.Date) AS Reservierungstag,
       COUNT(*) AS AnzahlTische
FROM Reservations r
         JOIN Customers c ON c._id = r.Customers__id
GROUP BY r.Customers__id, Reservierungstag
HAVING COUNT(*) > 1;

-- Wer hot über mehrere Tage mehr als einen Tisch insgesamt reserviert?
SELECT r.Customers__id, c.Name, COUNT(DISTINCT DATE(r.Date)) AS AnzahlTage
FROM Reservations r
         JOIN Customers c ON c._id = r.Customers__id
GROUP BY r.Customers__id
HAVING COUNT(DISTINCT DATE(r.Date)) > 1;