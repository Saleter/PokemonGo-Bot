using System;
using System.Threading.Tasks;

namespace PokemonGo.RocketAPI.Helpers
{
    public static class RandomHelper
    {
        private static readonly Random _random = new Random();
        private static readonly Random _rng = new Random();

        private static readonly Random Random = new Random();
        public static double RandomRoundDouble(double minimum, double maximum, int roundCases)
        {
            var next = Random.NextDouble();
            // even the cut should be random to look like more real stuff, too big number would be double size
            var nextFixed = Math.Round(next, RandomNumber(1, roundCases), MidpointRounding.AwayFromZero);
            return minimum + (nextFixed * (maximum - minimum));
        }

        public static int GetNumberOfDigits(double d)
        {
            double abs = Math.Abs(d);
            return abs < 1 ? 0 : (int)(Math.Log10(abs) + 1);
        }

        public static Boolean getRandBool()
        {
            return Random.Next(0, 10) >= 3;
        }

        public static double getRandomDoubleInteger(int minimum, int maximum)
        {
            return Random.Next(minimum, maximum);
        }

        public static double getRandomMaloDoubleInteger()
        {
            return (Random.Next(0, 10000) / 10000.0);
        }

        public static double getRandomDouble(double minimum, double maximum)
        {
            return Random.NextDouble() * (maximum - minimum) + minimum;

        }

        public static long GetLongRandom(long min, long max)
        {
            byte[] buf = new byte[8];
            _random.NextBytes(buf);
            var longRand = BitConverter.ToInt64(buf, 0);

            return (Math.Abs(longRand % (max - min)) + min);
        }

        public static async Task RandomDelay(int maxDelay = 5000)
        {
            await Task.Delay(_rng.Next((maxDelay > 500) ? 500 : 0, maxDelay));
        }

        public static async Task RandomDelay(int min, int max)
        {
            await Task.Delay(_rng.Next(min, max));
        }

        public static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}