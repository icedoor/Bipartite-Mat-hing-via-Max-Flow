using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MaxFlow
{
    public partial class Form1 : Form
    {
        Graph<char> myGraph = new Graph<char>();
        public Form1()
        {
            InitializeComponent();
            doStuff();            
        }

        private void doStuff()
        {
            Node<char> nA = new Node<char>('A');
            Node<char> nB = new Node<char>('B');
            Node<char> nC = new Node<char>('C');
            Node<char> nD = new Node<char>('D');
            Node<char> nE = new Node<char>('E');
            Node<char> nF = new Node<char>('F');
            Node<char> nG = new Node<char>('G');
            Node<char> nH = new Node<char>('H');
            Node<char> nI = new Node<char>('I');
            Node<char> nJ = new Node<char>('J');

            myGraph.AddNode(nA); //1
            myGraph.AddNode(nB); //2
            myGraph.AddNode(nC); //3
            myGraph.AddNode(nD); //4
            myGraph.AddNode(nE); //5
            myGraph.AddNode(nF); //6
            myGraph.AddNode(nG); //7
            myGraph.AddNode(nH); //8
            myGraph.AddNode(nI); //9
            myGraph.AddNode(nJ); //10

            bool bipartite = false;

            bipartite = myGraph.CreateEdge(nA, nF);
            bipartite = myGraph.CreateEdge(nA, nG);
            bipartite = myGraph.CreateEdge(nA, nI);

            bipartite = myGraph.CreateEdge(nB, nF);
            bipartite = myGraph.CreateEdge(nB, nG);
            bipartite = myGraph.CreateEdge(nB, nI);
            bipartite = myGraph.CreateEdge(nB, nJ);
            bipartite = myGraph.CreateEdge(nB, nF);

            bipartite = myGraph.CreateEdge(nC, nH);

            bipartite = myGraph.CreateEdge(nD, nH);

            bipartite = myGraph.CreateEdge(nE, nG);
            bipartite = myGraph.CreateEdge(nE, nH);
            bipartite = myGraph.CreateEdge(nE, nI);
            bipartite = myGraph.CreateEdge(nE, nJ);

            if (bipartite)
            {
                lblMaxMatch.Text = "Max matches: " + myGraph.FordFulkerson();
                lblMatches.Text = "Matches:\n";
                foreach (Tuple<Node<char>, Node<char>> match in myGraph.Matches)
                {
                    lblMatches.Text += match.Item1.Data.ToString() + " --- " + match.Item2.Data.ToString() + "\n";
                }
            }
        }
    }
}
