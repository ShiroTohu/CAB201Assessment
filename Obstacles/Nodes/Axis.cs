using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CAB201_Assignment.Obstacles.Nodes
{
    public class Axis : IEquatable<Axis>, IComparable<Axis>
    { 
        public int Value { get; }
        public Axis(int value)
        {
            Value = value;
        }
        public bool Equals(Axis? otherAxis)
        {
            if (otherAxis == null)
                return false;

            return (this.Value == otherAxis.Value);
        }

        public override bool Equals(object? obj)
        {
            return this.Equals(obj as Axis);
        }

        public override int GetHashCode() // probably correct ¯\_(ツ)_/¯
        {
            return this.Value.GetHashCode();
        }

        public int CompareTo(Axis? otherAxis)
        {
            if (otherAxis == null) return 1;

            return this.Value.CompareTo(otherAxis.Value);
        }

        // Define the is greater than operator.
        public static bool operator > (Axis operand1, Axis operand2)
        {
            return operand1.CompareTo(operand2) > 0;
        }

        // Define the is less than operator.
        public static bool operator < (Axis operand1, Axis operand2)
        {
            return operand1.CompareTo(operand2) < 0;
        }

        // Define the is greater than or equal to operator.
        public static bool operator >= (Axis operand1, Axis operand2)
        {
            return operand1.CompareTo(operand2) >= 0;
        }

        // Define the is less than or equal to operator.
        public static bool operator <= (Axis operand1, Axis operand2)
        {
            return operand1.CompareTo(operand2) <= 0;
        }
    }
}
