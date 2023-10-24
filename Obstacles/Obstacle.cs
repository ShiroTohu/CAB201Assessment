using CAB201_Assignment.ObstacleMap;
using CAB201_Assignment.Obstacles.Nodes;
using System.Runtime.CompilerServices;

namespace Obstacles
{
    interface IObstacle
    {
        Coordinate Origin { get; }
        int X { get; }
        int Y { get; }
        bool HasVision(Coordinate coordinate);
    }

    public abstract class Obstacle : NodeFactory, IObstacle
    {
        public abstract Coordinate Origin { get; }
        public static char Marker;
        public int X { get => Origin.X; }
        public int Y { get => Origin.Y; }
        public Obstacle() : base(Marker) { }

        /// <summary>
        /// Returns a node if the Obsticle has vision. Raises an Error if the Obsticle doesn't
        /// have vision. The coordinates are not relative to a grid selection but relative to 
        /// the whole grid. 
        /// 
        /// The implementation of this function can vary across different classes, but how
        /// the value is gotten doesn't matter too much.
        /// </summary>
        /// <param name="coordinate"></param>
        /// <returns></returns>
        protected abstract bool HasVision(Coordinate coordinate);

        public Node getNode(Coordinate coordinate)
        {
            if (HasVision(coordinate))
            {
                return CreateNode(coordinate);
            }
            else
            {
                throw new Exception();
            }
        }
    }
}