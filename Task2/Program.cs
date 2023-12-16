using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string text = Console.ReadLine();
            Console.WriteLine(Reverse(text));
            Console.ReadKey();
        }

        /// <summary>
        /// Метод разделения предложения на массив слов
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static string[] SplitText(string text)
        {
            string[] textArray = text.Split(' ');
            return textArray;
        }

        /// <summary>
        /// Метод изменения порядка слов на обратный
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static string Reverse(string text)
        {
            string[] textArray = SplitText(text);
            Array.Reverse(textArray);

            string reversedText = null;
            for (int i = 0; i < textArray.Length; i++)
            {
                reversedText += textArray[i] + ' ';
            }
            return reversedText;
        }
    }
}
