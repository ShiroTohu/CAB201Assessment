using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CAB201_Assignment.Obstacles.Nodes
{
    public class Node : Coordinate
    {
        public Node? Parent { get; set; }
        public char Marker { get; }
        public float DistanceToTarget; // H cost, the distance from the current node to the goal node.
        public float Weight;
        public float Cost; // G cost, the distance from the current node to the start node
        public bool Start = false;
        public bool End = false;
        public bool Solid;

        public float F // F Cost (G + H cost), it is also the most important cost
        {
            get
            {
                if (DistanceToTarget != -1 && Cost != -1)
                    return DistanceToTarget + Cost;
                else
                    return -1;
            }
        }
        
        public Node(Coordinate position, bool solid, char marker='.', float weight = 1) : base(position)
        {
            Parent = null;
            DistanceToTarget = -1;
            Cost = 1;
            Weight = weight;
            Solid = solid;
            Marker = marker;
        }
    }
}
