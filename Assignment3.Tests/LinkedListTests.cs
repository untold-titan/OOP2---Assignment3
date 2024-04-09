using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Tests
{
    internal class LinkedListTests
    {
        [Test]
        public void TestNewList()
        {
            var list = new ChainList();
            Assert.AreEqual(0, list.Count());
        }

        [Test]
        public void PrependElement()
        {
            var list = new ChainList();
            list.AddFirst(new User(1, "Johnny boy", "johnny@boy.com", "password"));
            Assert.AreEqual(1, list.Count());

        }
        [Test]
        public void AppendElement()
        {
            var list = new ChainList();
            list.AddLast(new User(1, "Johnny boy", "johnny@boy.com", "password"));
            Assert.AreEqual(1, list.Count());
        }
        [Test]
        public void AddElementAtIndex()
        {
            var list = new ChainList();
            list.AddLast(new User(1, "Johnny boy", "johnny@boy.com", "password"));
            list.AddLast(new User(2, "Johnny", "johnny@boy33.com", "password"));
            list.AddLast(new User(3, "boy", "johnny@boy2.com", "password"));
            list.Add(new User(10, "ajshd", "akshdajkhsd", "akoshdahugfsd"), 2);
            var user = list.GetValue(2);
            Assert.AreEqual(10, user.Id);
        }

        [Test]
        public void ReplaceElementAtIndex()
        {
            var list = new ChainList();
            list.AddLast(new User(1, "Johnny boy", "johnny@boy.com", "password"));
            list.AddLast(new User(2, "Johnny", "johnny@boy33.com", "password"));
            list.AddLast(new User(3, "boy", "johnny@boy2.com", "password"));
            list.Replace(new User(10, "ajshd", "akshdajkhsd", "akoshdahugfsd"), 2);
            var user = list.GetValue(2);
            Assert.AreEqual(10, user.Id);
        }

        [Test]
        public void RemoveElementAtEnd()
        {
            var list = new ChainList();
            list.AddLast(new User(1, "Johnny boy", "johnny@boy.com", "password"));
            list.AddLast(new User(2, "Johnny", "johnny@boy33.com", "password"));
            list.AddLast(new User(3, "boy", "johnny@boy2.com", "password"));
            list.AddLast(new User(10, "ajshd", "akshdajkhsd", "akoshdahugfsd"));
            list.RemoveLast();
            Assert.AreEqual(3, list.Last.Data.Id);
        }
        [Test]
        public void RemoveElementAtStart()
        {
            var list = new ChainList();
            list.AddLast(new User(1, "Johnny boy", "johnny@boy.com", "password"));
            list.AddLast(new User(2, "Johnny", "johnny@boy33.com", "password"));
            list.AddLast(new User(3, "boy", "johnny@boy2.com", "password"));
            list.AddLast(new User(10, "ajshd", "akshdajkhsd", "akoshdahugfsd"));
            list.RemoveFirst();
            Assert.AreEqual(2, list.First.Data.Id);
        }
        [Test]
        public void RemoveElementInMiddle()
        {
            var list = new ChainList();
            list.AddLast(new User(1, "Johnny boy", "johnny@boy.com", "password"));
            list.AddLast(new User(2, "Johnny", "johnny@boy33.com", "password"));
            list.AddLast(new User(3, "boy", "johnny@boy2.com", "password"));
            list.AddLast(new User(10, "ajshd", "akshdajkhsd", "akoshdahugfsd"));
            list.Remove(2);
            Assert.AreEqual(3, list.Count());
        }
        [Test]
        public void FindElement()
        {
            var list = new ChainList();
            list.AddLast(new User(1, "Johnny boy", "johnny@boy.com", "password"));
            list.AddLast(new User(2, "Johnny", "johnny@boy33.com", "password"));
            list.AddLast(new User(3, "boy", "johnny@boy2.com", "password"));
            list.AddLast(new User(10, "ajshd", "akshdajkhsd", "akoshdahugfsd"));
            var val = list.GetValue(list.IndexOf(new User(10, "ajshd", "akshdajkhsd", "akoshdahugfsd")));
            Assert.AreEqual(10, val.Id);
        }

        [Test]
        public void TestToArray() {
            var list = new ChainList();
            list.AddLast(new User(1, "Johnny boy", "johnny@boy.com", "password"));
            list.AddLast(new User(2, "Johnny", "johnny@boy33.com", "password"));
            list.AddLast(new User(3, "boy", "johnny@boy2.com", "password"));
            list.AddLast(new User(10, "ajshd", "akshdajkhsd", "akoshdahugfsd"));
            var array = list.toArray();
            Assert.AreEqual(4, array.Length);
            Assert.AreEqual(10, array[3].Id);
        }
    }
}
