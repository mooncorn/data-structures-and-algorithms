using FinalProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FinalProject_Test
{
    [TestClass]
    public class DCLinkedListTest
    {
        [TestMethod]
        public void AddFirstToEmptyList()
        {
            DCLinkedList<int> list = new DCLinkedList<int>();
            GenericNode<int> headAndTail = new GenericNode<int>(2);
            
            list.AddFirst(headAndTail);

            Assert.AreEqual(list.Count, 1);

            Assert.AreEqual(headAndTail, list.Head);
            Assert.AreEqual(headAndTail, list.Head.Next);
            Assert.AreEqual(headAndTail, list.Head.Prev);

            Assert.AreEqual(list.Head, list.Tail);
        }

        [TestMethod]
        public void AddFirstToListWithTwoNodes()
        {
            DCLinkedList<int> list = new DCLinkedList<int>();
            GenericNode<int> head = new GenericNode<int>(5);
            GenericNode<int> body = new GenericNode<int>(5);
            GenericNode<int> tail = new GenericNode<int>(2);

            list.AddFirst(tail);
            list.AddFirst(body);
            list.AddFirst(head);

            Assert.AreEqual(list.Count, 3);

            // 3 References for head and tail
            Assert.AreEqual(head, list.Head);
            Assert.AreEqual(head, list.Tail.Next);
            Assert.AreEqual(head, list.Tail.Prev.Prev);

            Assert.AreEqual(tail, list.Tail);
            Assert.AreEqual(tail, list.Head.Prev);
            Assert.AreEqual(tail, list.Head.Next.Next);

            // 2 References for body nodes
            Assert.AreEqual(body, list.Head.Next);
            Assert.AreEqual(body, list.Tail.Prev);
        }

        [TestMethod]
        public void AddLastToEmptyList()
        {
            DCLinkedList<int> list = new DCLinkedList<int>();
            GenericNode<int> headAndTail = new GenericNode<int>(2);

            list.AddLast(headAndTail);

            Assert.AreEqual(list.Count, 1);

            Assert.AreEqual(headAndTail, list.Head);
            Assert.AreEqual(headAndTail, list.Head.Next);
            Assert.AreEqual(headAndTail, list.Head.Prev);

            Assert.AreEqual(list.Head, list.Tail);
        }

        [TestMethod]
        public void AddLastToListWithTwoNodes()
        {
            DCLinkedList<int> list = new DCLinkedList<int>();
            GenericNode<int> head = new GenericNode<int>(5);
            GenericNode<int> body = new GenericNode<int>(5);
            GenericNode<int> tail = new GenericNode<int>(2);

            list.AddLast(head);
            list.AddLast(body);
            list.AddLast(tail);

            Assert.AreEqual(list.Count, 3);

            // 3 References for head and tail
            Assert.AreEqual(head, list.Head);
            Assert.AreEqual(head, list.Tail.Next);
            Assert.AreEqual(head, list.Tail.Prev.Prev);

            Assert.AreEqual(tail, list.Tail);
            Assert.AreEqual(tail, list.Head.Prev);
            Assert.AreEqual(tail, list.Head.Next.Next);

            // 2 References for body nodes
            Assert.AreEqual(body, list.Head.Next);
            Assert.AreEqual(body, list.Tail.Prev);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddBeforeToEmptyList()
        {
            DCLinkedList<int> list = new DCLinkedList<int>();
            list.AddBefore(new GenericNode<int>(1), new GenericNode<int>(5));
        }

        [TestMethod]
        public void AddBeforeHead()
        {
            DCLinkedList<int> list = new DCLinkedList<int>();
            GenericNode<int> head = new GenericNode<int>(5);
            GenericNode<int> body = new GenericNode<int>(5);
            GenericNode<int> tail = new GenericNode<int>(2);

            list.AddFirst(body);
            list.AddLast(tail);

            list.AddBefore(body, head);

            Assert.AreEqual(list.Count, 3);

            // 3 References for head
            Assert.AreEqual(head, list.Head);
            Assert.AreEqual(head, list.Tail.Next);
            Assert.AreEqual(head, list.Tail.Prev.Prev);
        }
    }
}
