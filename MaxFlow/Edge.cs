using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaxFlow
{
    class Edge<T>
    {
        int myFlow;
        int myCapacity;

        public int CF
        {
            get { return myCapacity - myFlow;}
        }
        public int Capacity
        {
            get { return myCapacity; }
            set { myCapacity = value; }
        }
        public int Flow
        {
            get { return myFlow; }
            set { if (value >= myCapacity) myFlow = value; }
        }

        public Edge()
        {
            myFlow = 0;
            myCapacity = 0;
        }
    }
}
