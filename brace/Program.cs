using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brace
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Дана строка S. Из строки требуется удалить текст, заключенный в фигурные скобки.
            В строке может быть несколько фрагментов, заключённых в фигурные скобки.
            Возможно использование вложенных фигурных скобок, необходимо, чтобы программа это учитывала*/

            string sourceText = "Из строки {{возможно} {требуется}} удалить текст, заключенный в {фигурные} скобки.";
            Console.WriteLine(sourceText);
            string newText = sourceText;
            char start = '{';
            char end = '}';
            char[] chars = sourceText.ToCharArray();
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
                    continue;
                }
                if (chars[i] == end)
                {
                    if (depth > 1)
                    {
                        depth--;
                        continue;
                    }
                    depth = 0;
                    string sbusting = sourceText.Substring(entryPoint, i - entryPoint + 1);
                    newText = newText.Remove(newText.IndexOf(sbusting), sbusting.Length);
                }
            }
            Console.WriteLine(newText);
            Console.ReadKey();
        }
    }
}
