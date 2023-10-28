using CAB201_Assignment.Obstacles.Nodes;
using CAB201_Assignment.Obstacles.Pathing;
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
    }

    public class NodeMap : INodeMap
    {
        private List<Obstacle> _obstacleList;
        List<List<Node>> nodeMap = new List<List<Node>>();

        public NodeMap(List<Obstacle> obstacleList)
        {
            _obstacleList = obstacleList;
        }

        public List<List<Node>> GenerateMap(Bounds bounds)
        {
            List<List<Node>> nodeMap = new List<List<Node>>();
            foreach (Obstacle obstacle in _obstacleList)
            {
                if (obstacle.IsIgnored) { continue; }
                List<Node> nodes = obstacle.GetNodes(bounds);
                foreach (Node node in nodes)
                {
                    nodeMap[node.X][node.Y] = node;
                }
            }
        }

        private Bounds DynamicallyCreateBounds()
        {
            throw new NotImplementedException();
        }

        private Coordinate CreateTopLeftCoordinate()
        {
            throw new NotImplementedException();
        }

        private Coordinate CreateBottomRightCoordiante()
        {
            throw new NotImplementedException();
        }



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
            Node startNode = new Node("Enter your current location (X,Y):", false).SetAsStart();
            Node endNode = new Node("Enter the location of the mission objective (X,Y):", false).SetAsEnd();
            new PathFinding(this).FindSafePath();
        }

        private void SetStartNode(Node startNode) 
        {
            nodeMap[startNode.X][startNode.Y] = startNode;
        }

        private void SetEndNode(Node EndNode)
        {
            nodeMap[EndNode.X][EndNode.Y] = EndNode;
        }
    }
}


