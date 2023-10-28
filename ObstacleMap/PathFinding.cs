using CAB201_Assignment.Obstacles.Nodes;
using CAB201_Assignment.Obstacles.Pathing;
using Obstacles;
using System.Drawing;

namespace CAB201_Assignment.ObstacleMap
{
    public class PathFinding : AStar
    {
        private static Type[] _ignore = new Type[] { typeof(Camera) };
        private NodeMap _nodeMap;
        private Bounds _mapBounds;
        private StartNode _startNode;
        private EndNode _endNode;
        public PathFinding(NodeMap nodeMap)
        {
            _nodeMap = nodeMap;
            _startNode = new StartNode("Enter your current location (X,Y):");
            _endNode = new EndNode("Enter the location of your objective (X,Y):");
            _mapBounds = DefineBounds();
        }

        private void FindSafePath()
        {
            throw new NotImplementedException();
        }

        private Bounds DefineBounds()
        {
            Coordinate topLeftCoordinate = new Coordinate(0, 0);
            Coordinate bottomRightCoordiante = new Coordinate(0, 0);
            return new Bounds(topLeftCoordinate, bottomRightCoordiante);
        }
    }

    /*[Serializable]
    public class PathNotFoundException : Exception
    {
        public PathNotFoundException() { }

        public PathNotFoundException(string message)
            : base(message) { }

        public PathNotFoundException(string message, Exception inner)
            : base(message, inner) { }
    }

    public class PathFinding
    {
        public void Main(Map map) // this is what you call coupling :)
        {
            Point start = new Point("enter farting point");
            Point goal = new Point("enter ending point");
            int[,] grid = CreateIntMap(map, start, goal);

            List<Point> path = FindShortestPath(grid, start, goal);

            if (path != null)
            {
                Console.WriteLine("Shortest Path:");
                foreach (var point in path)
                {
                    Console.WriteLine($"({point.X}, {point.Y})");
                }
            }
            else
            {
                Console.WriteLine("No path found.");
            }
        }

        public void FindSafePath()
        {
            throw new NotImplementedException();
        }

        private int[,] CreateIntMap(Map map, Point start, Point goal)
        {
            int[,] intMap = CreateEmptyIntMap(map, start, goal);
            foreach (Obstacle obstacle in map.Obstacles)
            {

            }
        }

        private static int[,] CreateEmptyIntMap(Map map, Point start, Point goal) 
        {
            int[] mapBounds = map.GetMapBounds();
            if (start.X > mapBounds[0])
            {
                mapBounds[0] = start.X;
            }
            if (start.Y > mapBounds[1])
            {
                mapBounds[0] = start.Y;
            }

            if (goal.X > mapBounds[1])
            {
                mapBounds[0] = goal.X;
            }
            if (goal.Y > mapBounds[1])
            {
                mapBounds[0] = goal.Y;
            }
            return new int[mapBounds[0], mapBounds[1]];
        }

        public class Point
        {
            public int X { get; }
            public int Y { get; }

            public Point(string prompt)
            {
                int[] coordinates = Util.PromptCoordinates(prompt);
                X = coordinates[0];
                Y = coordinates[1];
            }

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

        public static List<Point> FindShortestPath(int[,] grid, Point start, Point goal)
        {
            int rows = grid.GetLength(0);
            int cols = grid.GetLength(1);

            bool[,] visited = new bool[rows, cols];
            Point[,] parent = new Point[rows, cols];

            Queue<Point> queue = new Queue<Point>();
            queue.Enqueue(start);
            visited[start.X, start.Y] = true;

            int[] dx = { -1, 0, 1, 0 }; // Possible horizontal moves
            int[] dy = { 0, 1, 0, -1 }; // Possible vertical moves

            while (queue.Count > 0)
            {
                Point current = queue.Dequeue();

                if (current.X == goal.X && current.Y == goal.Y)
                {
                    // Reconstruct the path
                    List<Point> path = new List<Point>();
                    while (current != null)
                    {
                        path.Add(current);
                        current = parent[current.X, current.Y];
                    }
                    path.Reverse();
                    return path;
                }

                // Explore adjacent cells
                for (int i = 0; i < 4; i++)
                {
                    int newX = current.X + dx[i];
                    int newY = current.Y + dy[i];

                    if (IsValid(newX, newY, rows, cols) && grid[newX, newY] == 1 && !visited[newX, newY])
                    {
                        queue.Enqueue(new Point(newX, newY));
                        visited[newX, newY] = true;
                        parent[newX, newY] = current;
                    }
                }
            }

            // No path found
            throw new PathNotFoundException("No path found.");
        }

        public static bool IsValid(int x, int y, int rows, int cols)
        {
            return x >= 0 && x < rows && y >= 0 && y < cols;
        }
    }*/
}

