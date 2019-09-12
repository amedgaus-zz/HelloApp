using System;
using System.Collections.Generic;

namespace HelloApp
{
    public static class SquareGenerator
    {
        public static IEnumerable<int> Generate(int maxStep)
        {
            for (int i = 1; i <= maxStep; i++)
                yield return i * i;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Dana, its your husband");
            Byte a = 1;
            Byte b = (Byte)(a - 1);
            foreach (var sq in SquareGenerator.Generate(5))
                Console.WriteLine(sq);
            Console.WriteLine(Char.IsUpper('א'));
            Console.WriteLine(Char.IsLower('א'));
            Console.ReadKey();
        }
    }
}
