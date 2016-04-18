using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaxFlow
{
    class Node<T>
    {
        private T myData;

        public T Data
        {
            get { return myData; }
        }

        public Node()
        {
            myData = default(T);
        }

        public Node(T someData)
        {
            myData = someData;
        }
    }
}
