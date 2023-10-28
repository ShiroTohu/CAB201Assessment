using CAB201_Assignment.Obstacles.Nodes;
using Obstacles;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using Util;
using static CAB201_Assignment.ObstacleMap.MarkerMap;

namespace CAB201_Assignment.ObstacleMap
{
    interface INodeMap
    {
        void ShowSafeDirections();
        void DisplayObstacleMap();
        void FindSafePath();
        void AddObstacle(Obstacle obstacle);
        void AddNode(Node node);
        List<Obstacle> GetObstacleList();
        List<Node> GetNodeList(Bounds bounds);

        Node GetStartNode();
        Node GetEndNode();
    }

    public class NodeMap : INodeMap
    {
        private List<Obstacle> _obstacleList = new List<Obstacle>();
        private List<List<Node>> nodeMatrix = new List<List<Node>>();
        private Node? StartNode;
        private Node? EndNode;

        public void AddObstacle(Obstacle obstacle)
        {
            _obstacleList.Add(obstacle);
        }

        public List<Obstacle> GetObstacleList()
        {
            return _obstacleList;
        }

        public void ShowSafeDirections()
        {
            new PathFinding(this).ShowSafeDirections();
        }

        public void DisplayObstacleMap()
        {
            new MarkerMap(this).DisplayObstacleMap();
        }

        public void FindSafePath()
        {
            StartNode = new Node("Enter your current location (X,Y):", false).SetAsStart();
            EndNode = new Node("Enter the location of the mission objective (X,Y):", false).SetAsEnd();

            SetStartNode(StartNode);
            SetEndNode(EndNode);

            new PathFinding(this).FindSafePath();
        }

        private void SetStartNode(Node startNode) 
        {
            nodeMatrix[startNode.X][startNode.Y] = startNode;
        }

        private void SetEndNode(Node EndNode)
        {
            nodeMatrix[EndNode.X][EndNode.Y] = EndNode;
        }

        public Node GetStartNode()
        {
            if (StartNode != null)
            {
                return StartNode;
            }
            else
            {
                throw new Exception("You need to decalre the StartNode before you can reference it");
            }
        }

        public Node GetEndNode()
        {
            if (EndNode != null)
            {
                return EndNode;
            }
            else
            {
                throw new Exception("You need to decalre the EndNode before you can reference it");
            }
        }

        public void AddNode(Node node)
        {
            nodeMatrix[node.X][node.Y] = node;
        }

        public List<Node> GetNodeList(Bounds bounds)
        {
            List<Node> nodeList = new List<Node>();
            foreach (Obstacle obstacle in GetObstacleList())
            {
                List<Node> nodes = obstacle.GetNodes(bounds);
                foreach (Node node in nodes)
                {
                    Console.WriteLine($"Array Bounds {node.X}, {node.Y}");
                    nodeList.Add(node);
                }
            }

            return nodeList;
        }

        public List<List<Node>> GetNodeMatrix(Bounds bounds)
        {
            List<List<Node>> nodeMatrix = new List<List<Node>>();
            List<Node> nodeList = GetNodeList(bounds);
            foreach(Node node in nodeList)
            {
                nodeMatrix[node.X][node.Y] = node;
            }

            return nodeMatrix;
        }
    }
}


