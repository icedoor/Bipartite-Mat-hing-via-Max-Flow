using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaxFlow
{
    class Queue<T>
    {
        private ListNode<T> myFront;
        private ListNode<T> myRear;

        public bool IsEmpty
        {
            get { return (myFront == null && myRear == null); }
        }

        public void Enqueue(T Value)
        {
            ListNode<T> newNode = new ListNode<T>();
            newNode.Data = Value;
            if (IsEmpty)
            {
                myFront = newNode;
                myRear = newNode;
            }
            else
            {
                myRear.Next = newNode;
                myRear = newNode;
            }
        }

        public T Dequeue() 
        {
            if (IsEmpty)
                return default(T);
            else
            {
                T remove = myFront.Data;
                if (myFront == myRear)
                {
                    myFront = null;
                    myRear = null;
                }
                else
                    myFront = myFront.Next;
                return remove;
            }
        }
    }
}
