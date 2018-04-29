using NUnit.Framework;
using System.Collections.Generic;

namespace ListsHomework
{
    [TestFixture]
    public class ListsTests
    {
        // Whenever you see this constant, you'll need to delete the
        // variable reference and replace it with a literal value.
        const object __FILL_ME_IN__ = null;

        [Test]
        public void Lists_Are_Empty_By_Default()
        {
            var list = new List<int>();

            // Replace __FILL_ME_IN__ with the correct value.
            Assert.That(list.Count, Is.EqualTo(__FILL_ME_IN__));
        }

        [Test]
        public void Lists_Can_Be_Initialized_With_Items()
        {
            var list = new List<int>()
            {
                // Add 3 items to the list here.
            };

            Assert.That(list.Count, Is.EqualTo(3));
        }

        [Test]
        public void Lists_Can_Have_Items_Added_After_They_Are_Created()
        {
            var list = new List<string>();

            // Use one of List's methods to add an item here.

            Assert.That(list, Is.Not.Empty);
        }

        [Test]
        public void Lists_Use_Zero_Based_Indexes()
        {
            var list = new List<string>() { "Foo", "Bar", "Baz" };

            int indexOfSecondItem = list.IndexOf("Bar");

            Assert.That(indexOfSecondItem, Is.EqualTo(__FILL_ME_IN__));
        }

        [Test]
        public void Lists_Can_Have_Items_Inserted_At_Specific_Locations()
        {
            var list = new List<int>() { 1, 3 };

            // Use one of List's methods to insert the number 2
            // in the correct position here.

            CollectionAssert.AreEqual(list, new List<int> { 1, 2, 3 });
        }

        [Test]
        public void Lists_Can_Have_Items_Removed_At_A_Specific_Index()
        {
            var list = new List<int>() { 1, 2, 3, 4 };

            // Use one of List's methods to delete the item at index 2.

            CollectionAssert.AreEqual(list, new List<int> { 1, 2, 4 });
        }

        [Test]
        public void Lists_Can_Have_Specific_Values_Removed()
        {
            var list = new List<int>() { 1, 2, 42, 3 };

            // Use one of List's methods to delete the value 42.

            CollectionAssert.AreEqual(list, new List<int> { 1, 2, 3 });
        }

        [Test]
        public void Lists_Allow_You_To_Set_Values_With_Indexers()
        {
            var list = new List<string>() { "Foo", "Bar", "Baz" };

            // Use an indexer (square brackets) to change "Bar" to "Quux".
            
            CollectionAssert.AreEqual(list, new List<string> { "Foo", "Quux", "Baz"});
        }

        [Test]
        public void Lists_Allow_You_To_Get_Values_With_Indexers()
        {
            var list = new List<string>() { "Foo", "Bar", "Baz" };

            // What value does list[2] return?
            Assert.That(list[2], Is.EqualTo(__FILL_ME_IN__));
        }
    }
}
