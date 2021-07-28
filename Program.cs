using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearnHW2
{
    class Program
    {
        static void Main()
        {
            //Создается массив из 9 слов
            string[] words =
                {"home", "programming", "victory", "C#", "football", "sport", "book", "learn", "dream", "fun"};
            string letter = Console.ReadLine();
            int count = 0;

            //нам нужно пробежаться по массиву так, чтобы выводились только те слова,
            //в которых есть буква, которую мы напишем
            //если в словах нет той буквы, то выводим "No match"
            for (int i = 0; count < words.Length; count++)
            {
                if (words[count].Contains(letter) is true) //Проверяем, есть ли в слове буква
                {
                    Console.WriteLine(words[count]);
                    i++;
                }
                else
                {
                    if (i < 1 && count == words.Length-1) //если в массиве нет буквы и если в консоли ничего не было выведено
                    {                                     //то выводится текст
                        Console.WriteLine("No match");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
