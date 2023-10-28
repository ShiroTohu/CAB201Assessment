using CAB201_Assignment.Obstacles.Nodes;
using Obstacles;
using System.Net;
using Util;

namespace CAB201_Assignment.ObstacleMap
{
    public class NodeMap : ObstacleFactory
    {
        List<List<Node>> nodeMap = new List<List<Node>>();
        List<Obstacle> obstacleList = new List<Obstacle>();
        public Bounds Bounds;

        public NodeMap()
        {
            Bounds = DynamicallyCreateBounds();
        }

        public NodeMap(Bounds bounds)
        {
            Bounds = bounds;
        }

        public void AddObstacle(Obstacle obstacle)
        {
            obstacleList.Add(obstacle);
        }

        public Bounds DynamicallyCreateBounds()
        {
            foreach (Obstacle obstacle in obstacleList)
            {
                if (!obstacle.IsIgnored)
                {
                    obstacle.GetCoverage();
                } 
            }
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

        public void AddObstacle(char type)
        {
            switch (type)
            {
                case Guard.Marker:
                     _obstacles.Add(CreateGuard());
                    Console.WriteLine("Guard has been added to obstacleList");
                    break;
                case Fence.Marker:
                    _obstacles.Add(CreateFence());
                    break;
                case Camera.Marker:
                    _obstacles.Add(CreateCamera());
                    break;
                case Sensor.Marker:
                    _obstacles.Add(CreateSensor());
                    break;
                case MineField.Marker:
                    _obstacles.Add(CreateMineField());
                    break;
                default:
                    throw new ObstacleNotFound();
            }
        }
    }
}


