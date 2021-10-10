using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввести с клавиатуры предложение.Предложение представляет собой слова, разделенные пробелом.Знаки препинания не используются.
            // Составить программу, определяющую является ли строка палиндромом без учёта пробелов и регистра(пример палиндрома – «А роза упала на лапу Азора»).

            string sourceText = Console.ReadLine();
            //Удаляем пробелы между словами и переводим все символы в нижний регистр
            string[] wArray = sourceText.Split();
            string newText = "";
            foreach (string w in wArray)
            {
                newText += w.ToLower();
            }
            Console.WriteLine(newText);
            //переставляем символы
            int n = newText.Length;
            string palindrome="";
            for (int i = 0; i < n; i++)
            {
                char c = Convert.ToChar(newText.Substring(n - 1 - i, 1));
                palindrome += c;                
            }
            Console.WriteLine(palindrome);
            //проверяем предложение на соответствие палиндрому
            bool f = true;
            for (int i = 0; i < n/2; i++)
            {
                char b = Convert.ToChar(newText.Substring(i, 1));
                char c = Convert.ToChar(newText.Substring(n-1 - i, 1));
                if (f)
                {
                    if (b==c)
                    {
                        f = true;
                    }
                    else
                    {
                        f = false;
                        break;
                    }
                }
            }
            if (f)
            {
                Console.WriteLine("Предложение является палиндромом");
            }
            else
            {
                Console.WriteLine("Предложение не является палиндромом");
            }
            Console.ReadKey();
        }
    }
}
