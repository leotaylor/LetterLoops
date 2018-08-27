using System;

namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Some Letters:");
            var input = Console.ReadLine();
            var result = "";

            for(int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                result += char.ToUpper(c);
                result += new String(char.ToLower(c), i);
                result += "-";
            }
            Console.WriteLine(result.TrimEnd('-'));

            Console.WriteLine("Press Enter To Exit");
            Console.ReadLine();
        }
    }
}
