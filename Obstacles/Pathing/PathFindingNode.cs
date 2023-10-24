using CAB201_Assignment.Obstacles.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAB201_Assignment.Obstacles.Pathing
{
    interface IPathFindingNode
    {
        Coordinate Coordinate { get; }
        bool IsIntercepting(Coordinate coordinate);
    }

    public abstract class PathFindingNode : IPathFindingNode 
    {
        protected abstract Coordinate Coordinate { get; }
        public abstract bool IsIntercepting(Coordinate coordinate);

        public PathFindingNode
    }
}
