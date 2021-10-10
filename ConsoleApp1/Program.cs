using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceText = "Из строки {{возможно} {требуется}} удалить текст, заключенный в {фигурные} скобки.";
            Console.WriteLine(sourceText);
            string newText = sourceText;
            char start = '{';
            char end = '}';
            var chars = sourceText.ToCharArray();
            int depth = 0;
            int entryPoint = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == start)
                {
                    if (depth == 0)
                    {
                        entryPoint = i;
                    }
                    depth++;
                    // Found first [. Count it
                    continue;
                }
                if (chars[i] == end)
                {
                    if (depth > 1)
                    {
                        depth--;
                        continue;
                    }

                    // Restart depth calculatioj
                    depth = 0;
                    // Get string to remove
                    string sbusting = sourceText.Substring(entryPoint, i - entryPoint + 1);
                    // Find, remove substring and update outcome string
                    newText = newText.Remove(newText.IndexOf(sbusting), sbusting.Length);
                }
            }
            Console.WriteLine(newText);
            Console.ReadKey();
        }
    }
}
