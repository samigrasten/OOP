using Microsoft.VisualBasic.CompilerServices;
using OOP.Helpers;

namespace OOP._8._ValueObjects
{
    public class Weight
    {
        public Weight(int weight, string unit)
        {
            weight.AssertGreaterThanZero("Weigt must be positive number");
            Value = weight;
            Unit = unit;
        }

        public readonly int Value;
        public readonly string Unit;

        public static Weight operator +(Weight a, Weight b)
        {
            (a.Unit != b.Unit).AssertTrue($"Cannot add {b.Unit} to {a.Unit}");
            return new Weight(a.Value + b.Value, a.Unit);
        }

        public static Weight operator -(Weight a, Weight b)
        {
            (a.Unit != b.Unit).AssertTrue($"Cannot substract {b.Unit} from {a.Unit}");
            return new Weight(a.Value - b.Value, a.Unit);
        }
    }
}