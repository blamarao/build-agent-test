using System;

namespace build_agent_test
{
    class Program
    {
        static void Main(string[] args)
        {
            GlobalPosition position = new GlobalPosition(51.9233076,4.4794524);

            Console.WriteLine("Hello World!");

            Console.WriteLine(position.PrintMe());
        }

        public class GlobalPosition
        {
            private (double, double) _coordinates;

            public GlobalPosition(double latitude, double longitude)
            {
                _coordinates = (latitude, longitude);
            }

            public string PrintMe() => $"Your current position is {_coordinates.Item1},{_coordinates.Item2}";
        }
    }
}
