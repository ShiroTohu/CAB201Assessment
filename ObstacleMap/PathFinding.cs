using CAB201_Assignment.Obstacles.Nodes;
using Obstacles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CAB201_Assignment.ObstacleMap
{
    interface IPathfinding
    {
        List<List<Node>> GenerateMap();
    }
    public class PathFinding
    {
        public NodeMap NodeMap;
        private Node StartNode;
        private Node EndNode;
        public PathFinding(NodeMap nodeMap)
        {
            NodeMap = nodeMap;
            StartNode = nodeMap.GetStartNode();
            EndNode = nodeMap.GetEndNode();
            ValidateNodeMap();
        }

        private void ValidateNodeMap() 
        {
            // If it can't get these nodes an Exception will erupt.
            NodeMap.GetStartNode();
            NodeMap.GetEndNode();
        }

        public void FindSafePath()
        {
            throw new NotImplementedException();
        }

        public void GenerateMap()
        {
            Bounds bounds = DynamicallyCreateBounds();
            foreach (Obstacle obstacle in NodeMap.GetObstacleList())
            {
                if (obstacle.IsIgnored) { continue; }
                List<Node> nodes = obstacle.GetNodes(bounds);
                foreach (Node node in nodes)
                {
                    NodeMap.AddNode(node);
                }
            }
        }

        private Bounds DynamicallyCreateBounds()
        {
            Coordinate topLeftCoordinate = CreateTopLeft();
            Coordinate bottomRightCoordinate = CreateBottomRight();
            return new Bounds(topLeftCoordinate, bottomRightCoordinate);
        }

        private Coordinate CreateTopLeft()
        {
            Coordinate topLeft = new Coordinate(StartNode.X, StartNode.Y);
            foreach (Obstacle obstacle in NodeMap.GetObstacleList())
            {
                Bounds bounds = obstacle.GetBounds();
                if (bounds.TopLeftCoordinate.X < topLeft.X)
                {
                    topLeft.X = bounds.TopLeftCoordinate.X;
                }
                if (bounds.TopLeftCoordinate.Y < topLeft.Y)
                {
                    topLeft.Y = bounds.TopLeftCoordinate.Y;
                }
            }

            return topLeft;
        }

        private Coordinate CreateBottomRight()
        {
            Coordinate bottomRight = new Coordinate(EndNode.X, EndNode.Y);
            foreach (Obstacle obstacle in NodeMap.GetObstacleList())
            {
                Bounds bounds = obstacle.GetBounds();
                if (bounds.TopLeftCoordinate.X < bottomRight.X)
                {
                    bottomRight.X = bounds.TopLeftCoordinate.X;
                }
                if (bounds.TopLeftCoordinate.Y < bottomRight.Y)
                {
                    bottomRight.Y = bounds.TopLeftCoordinate.Y;
                }
            }

            return bottomRight;
        }

        public void ShowSafeDirections()
        {
            throw new NotImplementedException();
        }

        private void FindPath()
        {
            throw new NotImplementedException();
        }
    }
}
