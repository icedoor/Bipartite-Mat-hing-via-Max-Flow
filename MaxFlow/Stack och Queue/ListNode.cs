//Isadora Persson, AC7479
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxFlow
{
    class ListNode<T>
    {
        private T myData;
        private ListNode<T> myNext;

        /// <summary>
        /// Property to externally get and internally set the value of the node
        /// </summary>
        public T Data 
        { 
            get
            {
                return myData;
            }
            set
            {
                if (value != null) myData = value;
            }
        }

        /// <summary>
        /// Property to get the next node
        /// </summary>
        public ListNode<T> Next
        {
            get
            {
                return myNext;
            }

            set { myNext = value; }
        }

        public ListNode()
        { 
            myData = default(T);
            myNext = null;
        }

        /// <summary>
        /// Constructor sets data and next
        /// </summary>
        /// <param name="dataValue">the value of the node</param>
        /// <param name="nextNode">the next node</param>
        public ListNode(T dataValue, ListNode<T> nextNode)
        {
            myData = dataValue;
            myNext = nextNode;
        }
    }
}
