using System;
using System.Linq;

namespace Hamming
{
    public class Hamming
    {
        public static int Distance(string original, string current)
        {
            int hammingDistance = 0;
            // Throwing exception
            if (current == null)
            {
                throw new ArgumentNullException("current");
            }
            if (original == null)
            {
                throw new ArgumentNullException("original");
            }
            if (original.Length != current.Length)
            {
                throw new ArgumentException("Hamming Distance can only be calculated over strings of equal length");
            }
            char[] charOriginal = original.ToArray();
            char[] charCurrent = current.ToArray();
            for (int i = 0; i < charOriginal.Length; i++)
            {
                if (charOriginal[i] != charCurrent[i])
                    hammingDistance++;
            }
            return hammingDistance;
            
        }
    }
}
