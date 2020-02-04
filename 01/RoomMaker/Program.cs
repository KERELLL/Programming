using System;
using System.Security;

namespace RoomMaker
{
    public class Program
    {
        static void Main()
        {
            Room room = new Room(new[] {new Thing("table", 500), new Thing("chair", 100)});

            AssertEqual(room.Contains("table"), true);
            AssertEqual(room.Contains("chair"), true);
            AssertEqual(room.Contains("cabinet"), false);
            AssertEqual(room.GetCost(), 600);

            Console.WriteLine("No errors");
            Console.Read();
        }

        private static void AssertEqual<T>(T actual, T expected)
        {
            if (!actual.Equals(expected))
            {
                throw new VerificationException($"expected: {expected}, but actual: {actual}");
            }
        }
    }
}