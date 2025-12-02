INSERT INTO Fahrzeuge (_id, Beziehung)
VALUES
    (1, 'Auto'),
    (2, 'Motorrad'),
    (3, 'LKW');
INSERT INTO Raeder (_id, Durchmesser, Fahrzeuge__id, Bezeichnung)
VALUES
    (1, '17 Zoll', 1, 'Vorne links'),
    (2, '17 Zoll', 1, 'Vorne rechts'),
    (3, '17 Zoll', 1, 'Hinten links'),
    (4, '17 Zoll', 1, 'Hinten rechts'),

    (5, '19 Zoll', 2, 'Vorderrad'),
    (6, '17 Zoll', 2, 'Hinterrad'),

    (7, '22 Zoll', 3, 'Zwillingsrad links'),
    (8, '22 Zoll', 3, 'Zwillingsrad rechts');
INSERT INTO Gebäude (_id, Beziehung)
VALUES
    (1, 'Schule'),
    (2, 'Werkstatt'),
    (3, 'Wohnhaus');
INSERT INTO Raeume (_id, Groeße, Bezeichnung, Gebäude__id)
VALUES
    (1, '35 m²', 'Klassenraum 1A', 1),
    (2, '50 m²', 'EDV-Labor', 1),
    (3, '20 m²', 'Kellerraum', 3),
    (4, '80 m²', 'Montagehalle', 2);