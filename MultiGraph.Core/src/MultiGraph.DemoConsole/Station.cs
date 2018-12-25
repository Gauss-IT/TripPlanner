using System;

namespace MultiGraph.DemoConsole
{
    public class Station : IEquatable<Station>
    {
        public int Value { get; set; }

        public bool Equals(Station other)
        {
            if (other == null)
                return false;

            return Value == other.Value;
        }
    }
}
