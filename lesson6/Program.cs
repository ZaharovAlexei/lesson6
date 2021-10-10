using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longWord
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом.
              Знаки препинания не используются. Найти самое длинное слово в строке.*/

            string text = Console.ReadLine();
            string[] arrayText = text.Split();
            int max=0;
            string longWord = "";
            foreach (string a in arrayText)
            {
                int word = a.Length;
                if (word>max)
                {
                    max = word;
                    longWord = a;
                }
            }
            Console.WriteLine(longWord);
            Console.ReadKey();
        }
    }
}
