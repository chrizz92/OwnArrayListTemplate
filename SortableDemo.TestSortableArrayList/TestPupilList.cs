using Microsoft.VisualStudio.TestTools.UnitTesting;
using OwnArrayList.Core;
using System;

namespace SortableDemo.TestCore
{
    [TestClass]
    public class TestPupilList
    {
        [TestMethod]
        public void T01_CreateEmptyList_CountShouldReturn0()
        {
            PupilList list = new PupilList();
            Assert.AreEqual(0, list.Count);
        }

        [TestMethod]
        public void T02_AddItems_TestCount()
        {
            PupilList list = new PupilList();
            list.Add(new Pupil());
            Assert.AreEqual(1, list.Count, "Count should return 1 after first add");
            list.Add(new Pupil());
            Assert.AreEqual(2, list.Count, "Count should return 2 after second add");
        }

        [TestMethod]
        public void T03_InsertItems_TestCount()
        {
            PupilList list = new PupilList();
            list.Insert(0, new Pupil());
            Assert.AreEqual(1, list.Count, "Count should return 1 after first insert");
            list.Insert(0, new Pupil());
            Assert.AreEqual(2, list.Count, "Count should return 2 after second insert");
            list.Insert(1, new Pupil());
            Assert.AreEqual(3, list.Count, "Count should return 3 after third insert");
        }

        [TestMethod]
        public void T04_AddItems_TestGetAt()
        {
            Pupil item1 = new Pupil();
            Pupil item2 = new Pupil();
            Pupil item3 = new Pupil();
            PupilList list = new PupilList();
            list.Add(item1);
            Assert.AreEqual(1, list.Count, "Count should return 1 after first add");
            list.Add(item2);
            Assert.AreEqual(2, list.Count, "Count should return 2 after second add");
            list.Add(item3);
            Assert.AreEqual(3, list.Count, "Count should return 3 after thirs add");
            Assert.AreEqual(item1, list.GetAt(0), "GetAt(0) should return Item1");
        }

        [TestMethod]
        public void T05_SortItems()
        {
            Pupil pupil1 = new Pupil() { Age = 10 };
            Pupil pupil2 = new Pupil() { Age = 7 };
            Pupil pupil3 = new Pupil() { Age = 1 };
            Pupil pupil4 = new Pupil() { Age = 8 };
            Pupil pupil5 = new Pupil() { Age = 11 };
            PupilList list = new PupilList();
            list.Add(pupil1);
            list.Add(pupil2);
            list.Add(pupil3);
            list.Add(pupil4);
            list.Add(pupil5);
            list.Sort();
            Assert.AreEqual(pupil3, list.GetAt(0), "pupil3 should be on first position");
            Assert.AreEqual(pupil2, list.GetAt(1), "pupil2 should be on second position");
            Assert.AreEqual(pupil4, list.GetAt(2), "pupil4 should be on third position");
            Assert.AreEqual(pupil1, list.GetAt(3), "pupil1 should be on fourth position");
            Assert.AreEqual(pupil5, list.GetAt(4), "pupil5 should be on fifth position");
        }

        [TestMethod]
        public void T08_RemoveItem_WhichIsNotInList()
        {
            Pupil pupil1 = new Pupil() { Age = 10 };
            Pupil pupil2 = new Pupil() { Age = 7 };
            Pupil pupil3 = new Pupil() { Age = 1 };
            Pupil pupil4 = new Pupil() { Age = 8 };
            Pupil pupil5 = new Pupil() { Age = 11 };
            PupilList list = new PupilList();
            list.Add(pupil1);
            list.Add(pupil2);
            list.Add(pupil3);
            list.Add(pupil4);
            Assert.AreEqual(4, list.Count, "Count not working properly");
            Assert.IsFalse(list.Remove(pupil5), "Remove should return false");
            Assert.AreEqual(4, list.Count, "Count should not be reduced, when no object is removed");
        }

        [TestMethod]
        public void T09_RemoveItem_WhichIsInList()
        {
            Pupil pupil1 = new Pupil() { Age = 10 };
            Pupil pupil2 = new Pupil() { Age = 7 };
            Pupil pupil3 = new Pupil() { Age = 1 };
            Pupil pupil4 = new Pupil() { Age = 8 };
            Pupil pupil5 = new Pupil() { Age = 11 };
            PupilList list = new PupilList();
            list.Add(pupil1);
            list.Add(pupil2);
            list.Add(pupil3);
            list.Add(pupil4);
            Assert.IsTrue(list.Remove(pupil3), "Should return true");
            Assert.AreEqual(3, list.Count, "Count should be reduced");
        }

        [TestMethod]
        public void T10_RemoveItem_WhichIsDuplicateInList()
        {
            Pupil pupil1 = new Pupil() { Age = 10 };
            Pupil pupil2 = new Pupil() { Age = 7 };
            Pupil pupil3 = new Pupil() { Age = 1 };
            Pupil pupil4 = new Pupil() { Age = 8 };
            Pupil pupil5 = new Pupil() { Age = 11 };
            PupilList list = new PupilList();
            list.Add(pupil1);
            list.Add(pupil2);
            list.Add(pupil3);
            list.Add(pupil4);
            list.Add(pupil3);
            Assert.IsTrue(list.Remove(pupil3), "Should return true");
            Assert.AreEqual(4, list.Count, "Count should be reduced by 1");
            Assert.AreEqual(pupil3, list.GetAt(3), "Second occurence of pupil3 should not be deleted");
        }

        [TestMethod]
        public void T11_RemoveAt()
        {
            Pupil pupil1 = new Pupil() { Age = 10 };
            Pupil pupil2 = new Pupil() { Age = 7 };
            Pupil pupil3 = new Pupil() { Age = 1 };
            Pupil pupil4 = new Pupil() { Age = 8 };
            Pupil pupil5 = new Pupil() { Age = 11 };
            PupilList list = new PupilList();
            list.Add(pupil1);
            list.Add(pupil2);
            list.Add(pupil3);
            list.Add(pupil4);
            list.RemoveAt(2);
            Assert.AreEqual(3, list.Count, "Count should be reduced");

            Assert.AreEqual(pupil1, list.GetAt(0), "pupil1 should be on first position");
            Assert.AreEqual(pupil2, list.GetAt(1), "pupil2 should be on second position");
            Assert.AreEqual(pupil4, list.GetAt(2), "pupil4 should be on third position");

            list.RemoveAt(2);
            Assert.AreEqual(2, list.Count, "Count should be reduced");
            Assert.AreEqual(pupil1, list.GetAt(0), "pupil1 should be on first position");
            Assert.AreEqual(pupil2, list.GetAt(1), "pupil2 should be on second position");

            list.RemoveAt(0);
            Assert.AreEqual(1, list.Count, "Count should be reduced");
            Assert.AreEqual(pupil2, list.GetAt(0), "pupil2 should be on first position");

            list.RemoveAt(0);
            Assert.AreEqual(0, list.Count, "Count should be reduced");

            list.Add(pupil4);
            Assert.AreEqual(pupil4, list.GetAt(0), "pupil4 should be on first position");
        }

        [TestMethod]
        public void T12_Insert()
        {
            Pupil pupil1 = new Pupil() { Age = 10 };
            Pupil pupil2 = new Pupil() { Age = 7 };
            Pupil pupil3 = new Pupil() { Age = 1 };
            Pupil pupil4 = new Pupil() { Age = 8 };
            Pupil pupil5 = new Pupil() { Age = 11 };
            PupilList list = new PupilList();
            list.Insert(0, pupil1);
            Assert.AreEqual(pupil1, list.GetAt(0), "pupil1 should be on first position");

            list.Insert(1, pupil2);
            Assert.AreEqual(pupil2, list.GetAt(1), "pupil2 should be on second position");

            list.Insert(1, pupil3);
            Assert.AreEqual(pupil1, list.GetAt(0), "pupil1 should be on first position");
            Assert.AreEqual(pupil3, list.GetAt(1), "pupil3 should be on second position");
            Assert.AreEqual(pupil2, list.GetAt(2), "pupil2 should be on third position");
        }
    }
}