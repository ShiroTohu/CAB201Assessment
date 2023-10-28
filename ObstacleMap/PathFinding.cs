using CAB201_Assignment.Obstacles.Nodes;
using CAB201_Assignment.Obstacles.Pathing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CAB201_Assignment.ObstacleMap
{
    public class PathFinding
    {
        NodeMap _nodeMap;
        StartNode _startNode;
        EndNode _endNode;
        public PathFinding(NodeMap nodeMap)
        {
            _nodeMap = nodeMap;
        }

        public void FindSafePath()
        {

            throw new NotImplementedException();
        }

        public List<List<Node>> GenerateMap()
        {
            List<List<Node>> nodeMap = new List<List<Node>>();
            Bounds bounds = DynamicallyCreateBounds();
        }

        private Bounds DynamicallyCreateBounds()
        {
            List<List<Node>> nodeMap = new List<List<Node>>();
        }

        public void ShowSafeDirections()
        {
            throw new NotImplementedException();
        }

        private void FindPath()
        {
            throw new NotImplementedException();
        }
/*
        public Stack<Node> FindPath(NodeMap nodeMap)
        {
            protected List<List<Node>> _nodeMap = new List<List<Node>>();
            Stack<Node> Path = new Stack<Node>();
            PriorityQueue<Node, float> OpenList = new PriorityQueue<Node, float>();
            List<Node> ClosedList = new List<Node>();
            List<Node> adjacencies;
            Node current = StartNode;

            // add start node to Open List
            OpenList.Enqueue(StartNode, StartNode.F);

            while (OpenList.Count != 0 && !ClosedList.Exists(x => x.Position == end.Position))
            {
                current = OpenList.Dequeue();
                ClosedList.Add(current);
                adjacencies = GetAdjacentNodes(current);

                foreach (Node n in adjacencies)
                {
                    if (!ClosedList.Contains(n) && n.Solid)
                    {
                        bool isFound = false;
                        foreach (var oLNode in OpenList.UnorderedItems)
                        {
                            if (oLNode.Element == n)
                            {
                                isFound = true;
                            }
                        }
                        if (!isFound)
                        {
                            n.Parent = current;
                            n.DistanceToTarget = Math.Abs(n.X - end.X) + Math.Abs(n.Y - end.Y);
                            n.Cost = n.Weight + n.Parent.Cost;
                            OpenList.Enqueue(n, n.F);
                        }
                    }
                }
            }

            // construct path, if end was not closed return null
            if (!ClosedList.Exists(x => x.Position == end.Position))
            {
                return null;
            }

            // if all good, return path
            Node temp = ClosedList[ClosedList.IndexOf(current)];
            if (temp == null) return null;
            do
            {
                Path.Push(temp);
                temp = temp.Parent;
            } while (temp != start && temp != null);
            return Path;
        }

        private List<Node> GetAdjacentNodes(Node n)
        {
            List<Node> temp = new List<Node>();

            int row = (int)n.Position.Y;
            int col = (int)n.Position.X;

            if (row + 1 < GridRows)
            {
                temp.Add(Grid[col][row + 1]);
            }
            if (row - 1 >= 0)
            {
                temp.Add(Grid[col][row - 1]);
            }
            if (col - 1 >= 0)
            {
                temp.Add(Grid[col - 1][row]);
            }
            if (col + 1 < GridCols)
            {
                temp.Add(Grid[col + 1][row]);
            }

            return temp;
        }*/
    }
}
