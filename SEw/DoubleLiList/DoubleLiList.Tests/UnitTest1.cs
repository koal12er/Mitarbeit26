using DoubleLiList;
using Xunit;


namespace DoubleLinkedList.Tests
{
    public class DoubleLinkedListTests
    {
        [Fact]
        public void NewList_ShouldBeEmpty()
        {
            // Arrange & Act
            var list = new DoubleLinkedList<int>();

            // Assert
            Assert.Equal(0, list.Count);
            Assert.Null(list.Head);
            Assert.Null(list.Tail);
        }

        [Fact]
        public void AddFirst_ShouldAddElementToStart()
        {
            // Arrange
            var list = new DoubleLinkedList<int>();

            // Act
            list.AddFirst(1);
            list.AddFirst(2); // 2 -> 1

            // Assert
            Assert.Equal(2, list.Count);
            Assert.Equal(2, list.Head!.Data);
            Assert.Equal(1, list.Tail!.Data);
            
            // Verknüpfungen prüfen
            Assert.Equal(list.Tail, list.Head.Next);
            Assert.Equal(list.Head, list.Tail.Previous);
        }

        [Fact]
        public void AddLast_ShouldAddElementToEnd()
        {
            // Arrange
            var list = new DoubleLinkedList<string>();

            // Act
            list.AddLast("A");
            list.AddLast("B"); // A -> B

            // Assert
            Assert.Equal(2, list.Count);
            Assert.Equal("A", list.Head!.Data);
            Assert.Equal("B", list.Tail!.Data);
        }

        [Fact]
        public void RemoveFirst_ShouldRemoveHead()
        {
            // Arrange
            var list = new DoubleLinkedList<int>();
            list.AddLast(10);
            list.AddLast(20);

            // Act
            var result = list.RemoveFirst();

            // Assert
            Assert.True(result);
            Assert.Equal(1, list.Count);
            Assert.Equal(20, list.Head!.Data);
            Assert.Null(list.Head.Previous); // Neuer Head darf keinen Vorgänger haben
        }

        [Fact]
        public void RemoveLast_ShouldRemoveTail()
        {
            // Arrange
            var list = new DoubleLinkedList<int>();
            list.AddLast(10);
            list.AddLast(20);

            // Act
            var result = list.RemoveLast();

            // Assert
            Assert.True(result);
            Assert.Equal(1, list.Count);
            Assert.Equal(10, list.Tail!.Data);
            Assert.Null(list.Tail.Next); // Neuer Tail darf keinen Nachfolger haben
        }

        [Fact]
        public void Remove_MiddleElement_ShouldReconnectLinks()
        {
            // Arrange
            var list = new DoubleLinkedList<int>();
            list.AddLast(1);
            list.AddLast(2); // Das hier löschen
            list.AddLast(3);

            // Act
            var result = list.Remove(2);

            // Assert
            Assert.True(result);
            Assert.Equal(2, list.Count);
            
            // Prüfen ob 1 und 3 jetzt direkt verbunden sind
            Assert.Equal(3, list.Head!.Next!.Data);
            Assert.Equal(1, list.Tail!.Previous!.Data);
        }

        [Fact]
        public void Remove_NonExistingElement_ShouldReturnFalse()
        {
            // Arrange
            var list = new DoubleLinkedList<int>();
            list.AddLast(1);

            // Act
            var result = list.Remove(99);

            // Assert
            Assert.False(result);
            Assert.Equal(1, list.Count);
        }

        [Fact]
        public void Find_And_Contains_ShouldWork()
        {
            // Arrange
            var list = new DoubleLinkedList<string>();
            list.AddLast("Hello");
            list.AddLast("World");

            // Act & Assert
            Assert.True(list.Contains("Hello"));
            Assert.False(list.Contains("Universe"));

            var foundNode = list.Find("World");
            Assert.NotNull(foundNode);
            Assert.Equal("World", foundNode!.Data);
        }

        [Fact]
        public void Clear_ShouldEmptyTheList()
        {
            // Arrange
            var list = new DoubleLinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);

            // Act
            list.Clear();

            // Assert
            Assert.Equal(0, list.Count);
            Assert.Null(list.Head);
            Assert.Null(list.Tail);
        }

        [Fact]
        public void Enumerator_ShouldIterateCorrectly()
        {
            // Arrange
            var list = new DoubleLinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);

            // Act
            var resultList = new List<int>();
            foreach (var item in list)
            {
                resultList.Add(item);
            }

            // Assert
            Assert.Equal(new[] { 1, 2, 3 }, resultList);
        }

        [Fact]
        public void CustomObject_Person_ShouldWorkIdeally()
        {
            // Dieser Test prüft, ob Equals() und Generics korrekt zusammenspielen
            
            // Arrange
            var list = new DoubleLinkedList<Person>();
            var p1 = new Person("Hans", 30);
            var p2 = new Person("Greta", 25);
            
            list.AddLast(p1);
            list.AddLast(p2);

            // Act
            // Wir suchen nach einem NEUEN Objekt mit gleichen Daten
            // Das funktioniert nur, wenn Person.Equals korrekt implementiert ist
            var searchPerson = new Person("Hans", 30); 
            var contains = list.Contains(searchPerson);
            var removed = list.Remove(searchPerson);

            // Assert
            Assert.True(contains, "Sollte Person anhand der Werte finden");
            Assert.True(removed, "Sollte Person entfernen");
            Assert.Equal(1, list.Count);
            Assert.Equal("Greta", list.Head!.Data.Name);
        }
    }
}
