using System;

namespace RaindropClassLibrary
{
    public class Raindrop
    {
        public static string Raindrops(int number)
        {
            string result = "";
            if (number % 3 == 0)
            { result += "Pling"; }
            if (number % 5 == 0)
            { result += "Plang"; }
            if (number % 7 == 0)
            { result += "Plong"; }
            if (result.Length == 0)
            { result = number.ToString(); }

            return result;
        }
    }
}
