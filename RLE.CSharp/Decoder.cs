using System;
using System.Linq;

namespace RLE.CSharp
{
    public class Decoder
    {
        /// <summary>
        /// Runtime-Length encoding is an algorithm to compress data
        /// by eliminating repetitions. 
        /// It was used in old image formats sometimes, before JPG was invented.
        /// </summary>
        /// <param name="data">Series of lowercase letters and numbers, for example '2b3a3c1d2e'</param>
        /// <returns>decompress data, so '2b3a3c1d2e' will turn to 'bbaaacccdee'</returns>
        public static string Process(string data)
        {
            if(!data.All(c => char.IsLetterOrDigit(c) && (char.IsLower(c) || char.IsDigit(c))))
                throw new ArgumentException("Invalid input");
            string encodedData = data;

            return encodedData;
        }
    }
}
