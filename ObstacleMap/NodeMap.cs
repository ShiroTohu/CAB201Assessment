using CAB201_Assignment.Obstacles.Nodes;
using Obstacles;
using System.Net;
using Util;

namespace CAB201_Assignment.ObstacleMap
{
    public class NodeMap
    {
        private List<Obstacle> _obstacleList = new List<Obstacle>();
        public Bounds Bounds;

        public NodeMap()
        {
            Bounds = DynamicallyCreateBounds();
        }

        public NodeMap(Bounds bounds)
        {
            Bounds = bounds;
        }
        public Bounds DynamicallyCreateBounds()
        {
            return new Bounds(topLeft, bottomRight);
        }

        private Bounds createTopLeftCoordinate()
        {
            Coordinate topLeftCoordinate = _obstacleList[0].Origin;
            foreach (Obstacle obstacle in obstacleList)
            {
                if ()
                {

                }
            }
        }

        public void AddObstacle(Obstacle obstacle)
        {
            _obstacleList.Add(obstacle);
        }

        

        

        public void ShowSafeDirections()
        {
            throw new NotImplementedException();
            /*Coordinate coordinate = new Coordinate(Input.PromptCoordinates("Enter your current location (X,Y):"));
            foreach (Obstacle obstacle in _obstacles)
            {
                if (obstacle.HasVision(coordinate)) {
                    Console.WriteLine("Agent, your location is compromised. Abort mission.");
                }
                else if (!AdjacentNodesAreEmpty(coordinate))
                {

                }
            }*/
        }

        public void DisplayObstacleMap()
        {
            new MarkerMap(this);
        }

        public void FindSafePath()
        {
            new PathFinding(this);
        }

        public List<Obstacle> GetObstacleList()
        {
            return _obstacles;
        }
    }
}


