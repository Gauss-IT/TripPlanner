using System;

namespace MultiGraph.DemoConsole
{
    public class Route : IEquatable<Route>
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public bool Equals(Route other)
        {
            if (other == null)
                return false;

            return Name == other.Name && Price == other.Price;
        }
    }
}
