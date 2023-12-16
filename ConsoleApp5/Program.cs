using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string text = Console.ReadLine();
            string[] textArray = SplitText(text);
            PrintTextArray(textArray);
            Console.ReadKey();
            //PrintTextArray(SplitText(text)); я бы сделал так
        }

        static string[] SplitText(string text)
        {
            string[] textArray = text.Split(' ');
            return textArray;
        }

        static void PrintTextArray(string[] textArray)
        {
            for (int i = 0; i < textArray.Length; i++)
            {
                Console.WriteLine(textArray[i]);
            }
        }
    }
}
