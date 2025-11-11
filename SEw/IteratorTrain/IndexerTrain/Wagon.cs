namespace IteratorTrain
{
    // Repräsentiert einen einzelnen Wagon im Zug
    public class Wagon
    {
        // Farbe des Wagons
        public string Color { get; set; }

        // Maximale Kapazität (z. B. Personen oder Tonnen)
        public int Capacity { get; set; }

        // Verweis auf den nächsten Wagon in der Kette
        public Wagon? Next;

        // Gibt eine kurze Textbeschreibung des Wagons zurück
        public override string ToString()
        {
            return $"Wagon {Color}, capacity {Capacity}";
        }
    }
}