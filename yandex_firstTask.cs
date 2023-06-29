using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yandex_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //количество клавиш клавиатуры
            int amountKeys = int.Parse(Console.ReadLine());

            //идентификаторы символов
            int[] id = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            //где они находятся
            int[] num = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            //кол-во символов в реферате
            int amountSymbols = int.Parse(Console.ReadLine());
            //расположение идентификаторов символов
            int[] idSymbols = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            var meaning = new Dictionary<int, int>();
            for (int i = 0, j = 0; i < id.Length && j < num.Length; i++, j++)
            {
                meaning.Add(id[i], num[j]);
            }

            int current = 0;
            int next = 1;
            int answer = 0;

            for (int i = 0, j = 1; i < idSymbols.Length - 1 && j < idSymbols.Length; i++, j++)
            {
                current = meaning[idSymbols[i]];
                next = meaning[idSymbols[j]];

                if (current != next)
                {
                    answer++;
                }
            }

            Console.WriteLine(answer);
        }
    }
    
}
