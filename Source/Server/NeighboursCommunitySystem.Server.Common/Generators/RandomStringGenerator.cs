namespace NeighboursCommunitySystem.Server.Common.Generators
{
    using System;
    using System.Linq;

    public class RandomStringGenerator
    {
        private Random Generator = new Random();
        private const string Symbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890!@#$%^&*()_+~-";

        /// <summary>
        /// Standard implementation for a random string generator.
        /// Probably the fastest and most intuitive solution.
        /// Caveman style.
        /// </summary>
        /// <param name="length">The desired length if the string.</param>
        /// <returns>Returns a random string with the required character length.</returns>
        public string GetString(int minLength, int maxLength)
        {
            var length = Generator.Next(minLength, maxLength + 1);
            var result = new char[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = Symbols[Generator.Next(0, Symbols.Length - 1)];
            }

            return new string(result);
        }
    }
}
