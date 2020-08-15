using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class StackTests
    {
        [Test]
        public void PushMethod_NullObject_ReturnsException()
        {
           var stack = new Fundamentals.Stack<string>();

            Assert.That(() => stack.Push(null), Throws.ArgumentNullException);
        }
        [Test]
        public void PushMethod_Object_AddItem()
        {
            var newItem = "a";
            var stack = new Fundamentals.Stack<string>();
            stack.Push(newItem);
            Assert.That(stack.Count,Is.EqualTo(1));
        }
        [Test]
        public void Pop_ZeroItems_ReturnException()
        {
            var stack = new Fundamentals.Stack<string>();

            Assert.That(() => stack.Pop(), Throws.InvalidOperationException);
        }
        [Test]
        public void Pop_Valid_Remove()
        {
            var stack = new Fundamentals.Stack<string>();
            stack.Push("a");
            stack.Push("b");
            var result= stack.Pop();

            Assert.That(result, Is.EqualTo("b"));
        }
        [Test]
        public void Pop_Valid_TopItem()
        {
            var stack = new Fundamentals.Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Pop();

            Assert.That(stack.Pop(), Is.EqualTo("a"));
        }
        [Test]
        public void Peek_EmptyStack_ReturnException()
        {
            var stack = new Fundamentals.Stack<string>();

            Assert.That(()=>stack.Peek(), Throws.InvalidOperationException);
        }
        [Test]
        public void Peek_StackWithItems_ReturnsTopItem()
        {
            var stack = new Fundamentals.Stack<string>();
            stack.Push("a");
            stack.Push("b");
            var result=stack.Peek();

            Assert.That(stack.Peek(), Is.EqualTo("b"));
        }
        [Test]
        public void Peek_StackWithItems_CountDoesntChange()
        {
            var stack = new Fundamentals.Stack<string>();
            stack.Push("a");
            stack.Push("b");
            var result = stack.Peek();

            Assert.That(stack.Count, Is.EqualTo(2));
        }


    }
}
