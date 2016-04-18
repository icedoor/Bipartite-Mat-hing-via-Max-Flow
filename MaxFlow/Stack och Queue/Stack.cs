//Isadora Persson, AC7479
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxFlow
{
    class Stack<T>
    {
        private ListNode<T> myFirstNode;
        private int mySize;

        /// <summary>
        /// returns number of nodes in the stack
        /// </summary>
        public int Count
        {
            get { return mySize; }
        }

        /// <summary>
        /// Constructor, sets default size to 0 
        /// </summary>
        public Stack()
        {
            mySize = 0;
        }

        /// <summary>
        /// Inserts new node 
        /// if stack is empty: point next to null
        /// else: point new to prev first and first is the new
        /// increse size of stack Count
        /// </summary>
        /// <param name="anElement">value of the new node</param>
        public void Push(T anElement)
        {
            if (mySize == 0)
                myFirstNode = new ListNode<T>(anElement, null);
            else
            {
                ListNode<T> newNode = new ListNode<T>(anElement, myFirstNode);
                myFirstNode = newNode;
            }
            mySize++;
        }

        /// <summary>
        /// Removes first node 
        /// Next node becomes the new first
        /// </summary>
        /// <returns>value of first node</returns>
        public T Pop()
        {
            if (mySize == 0)
                return default(T);
            else
            {
                T valueToReturn = myFirstNode.Data; //save value before remove
                myFirstNode = myFirstNode.Next; //peka om första node
                mySize--;
                return valueToReturn;
            }
        }

        /// <summary>
        /// Look at the value of first node without removing it
        /// </summary>
        /// <returns>value of first node</returns>
        public T Peek()
        {
            if (mySize == 0)
                return default(T);
            else
                return myFirstNode.Data;
        }
    }
}
