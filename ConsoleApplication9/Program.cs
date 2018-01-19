using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Глава российского правительства Дмитрий Медведев поручил разобраться с жалобой Ассоциации владельцев кинотеатров на перенос премьеры фильма «Приключения Паддингтона 2». Об этом РБК заявили в аппарате правительства. «Есть поручение премьера разобраться в ситуации», — рассказал представитель аппарата.";
            letterFrequency(str);
            Console.ReadLine();
        }
        public static void letterFrequency(string str) {

            Dictionary<string, int> letterFreq = new Dictionary<string, int>();

            foreach (var letter in str.Distinct().ToArray())
            {
                var count = Regex.Matches(str, letter.ToString()).Count;
                letterFreq.Add(letter.ToString(), count);
            }

            foreach (var letter in letterFreq.OrderByDescending(pair => pair.Value))
            {
                Console.WriteLine("Количество символов {0} = {1}", letter.Key, letter.Value.ToString());
            }
        }

        
    }
}
