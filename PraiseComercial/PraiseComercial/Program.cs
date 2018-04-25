/* 
 Напишете програма, която генерира случайно рекламно съобщение за
някакъв продукт. Съобщенията трябва да се състоят от хвалебствена
фраза, следвани от хвалебствена случка, следвани от автор (първо и
второ име) и град, които се избират от предварително подготвени
списъци. Например, нека имаме следните списъци:
 Хвалебствени фрази: {"Продуктът е отличен.", "Това е страхотен
продукт.", "Постоянно ползвам този продукт.", "Това е найдобрият продукт от тази категория."}.
- Хвалебствени случки: {"Вече се чувствам добре.", "Успях да се
променя.", "Той направи чудо.", "Не мога да повярвам, но вече се
чувствам страхотно.", "Опитайте и вие. Аз съм много доволна."}.     
- Първо име на автор: {"Диана", "Петя", "Стела", "Елена", "Катя"}.
- Второ име на автор: {"Иванова", "Петрова", "Кирова"}.
- Градове: {"София", "Пловдив", "Варна", "Русе"}.
  */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraiseComercial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize the string with phrases, stories, names and towns
            string[] phrases = {"Продуктът е отличен.", "Това е страхотен продукт.", "Постоянно ползвам този продукт.", "Това е най-добрият продукт от тази категория."};
            string[] stories = { "Вече се чувствам добре.", "Успях да се променя.", "Той направи чудо.", "Не мога да повярвам, но вече се чувствам страхотно."};
            string[] names = { "Диана", "Петя", "Стела", "Елена", "Баба Гицка"  };
            string[] lastNames = { "Иванова", "Петрова", "Кирова", "Станоева"};
            string[] homeTown = { "София", "Пловдив", "Варна", "Русе", "Някъде там"  };

            Random number = new Random();
            Random cifra = new Random();
            Random nomerche = new Random();

            //Looping for creating an amount of comercial stories
            for (int i = 0; i < 10; i++)
            {
                int index1 = number.Next(0,3);
                int index2 = cifra.Next(0, 4);
                int index3 = nomerche.Next(0, 3);
                
                Console.WriteLine();
                Console.WriteLine("'" + phrases[index1] +" "+ stories[index2]+ "'" +  " -- " + names[index3] + " " + lastNames[index1] + ", " + homeTown[index2]);
                Console.WriteLine();
            }
        }
    }
}
