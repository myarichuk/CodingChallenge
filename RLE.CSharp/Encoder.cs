using System;
using System.Linq;

namespace RLE.CSharp
{
    public static class Encoder
    {
        /// <summary>
        /// Runtime-Length Encoder is an algorithm to compress data
        /// by eliminating repetitions. 
        /// It was used in old image formats sometimes, before JPG was invented.
        /// </summary>
        /// <param name="data">Series of lowercase letters, for example 'bbaaacccdee'</param>
        /// <returns>compress data, so 'bbaaacccdee' will turn to '2b3a3c1d2e'</returns>
        public static string Process(string data)
        {
            if(!data.All(c => char.IsLetter(c) && char.IsLower(c)))
                throw new ArgumentException("Invalid input");
            string encodedData = data;

            return encodedData;
        }
    }
}
