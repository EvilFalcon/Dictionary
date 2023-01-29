using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vocabulary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandDictionaryLook = "1";
            const string CommandDictionaryAdd = "2";
            const string CommandDictionaryRemove = "3";
            const string CommandDictionarySearch = "4";
            const string CommandExitProgram = "5";

            Dictionary<string, string> countries = new Dictionary<string, string>();
            countries.Add("Россия", "Москва");
            countries.Add("Нидерланды", "Амстердам");
            countries.Add("Греция", "Афины");
            countries.Add("Сербия", "Белград");
            countries.Add("Германия", "Берлин");
            countries.Add("Швейцария", "Берн");
            countries.Add("Словакия", "Братислава");
            countries.Add("Бельгия", "Брюссель");

            bool isProgramWork = true;

            while (isProgramWork)
            {
                Console.WriteLine($"{CommandDictionaryLook}<--поиск по списку  " +
                    $"{CommandDictionaryAdd}<--добавить страну в список  " +
                    $"{CommandDictionaryRemove}<--удалить страну из списка" +
                    $"{CommandDictionarySearch}<--поиск столицы по названию страны  " +
                    $"{CommandExitProgram}<--выход из программы");

                switch (Console.ReadLine())
                {
                    case CommandDictionaryLook:
                        LookDictionary(countries);
                        break;

                    case CommandDictionaryAdd:
                        countries = AddDictionary(countries);
                        break;

                    case CommandDictionaryRemove:
                        countries = RemoveDictionary(countries);
                        break;

                    case CommandDictionarySearch:
                        DictionarySearch(countries);
                        break;

                    case CommandExitProgram:
                        isProgramWork = false;
                        break;


                }
            }
        }
        private static void LookDictionary(Dictionary<string, string> countries)
        {
            foreach (var item in countries)
            {
                Console.WriteLine($"Страна {item.Key} и её столица {item.Value} !");
            }
        }

        private static Dictionary<string, string> AddDictionary(Dictionary<string, string> countries)
        {
            Console.Write("\nВведите новую  страну в список : ");
            string country = Console.ReadLine();
            Console.Write($"\nВведите столицу страны {country} чтобы добавить в список : ");
            string capitalCity = Console.ReadLine();

            countries.Add(country, capitalCity);
            Console.WriteLine($"Страна {country} и её столица {capitalCity} добавлены в список! ");
            return countries;
        }

        private static Dictionary<string, string> RemoveDictionary(Dictionary<string, string> countries)
        {
            Console.Write("Введите страну чтобы удалить её из списка: ");
            countries.Remove(Console.ReadLine());
            Console.WriteLine($"Страна {countries} удалена из списка!");
            return countries;
        }

        private static void DictionarySearch(Dictionary<string, string> countries)
        {
            Console.Write("Введите страну для поиска по списку : ");
            string country = Console.ReadLine();

            if (countries.ContainsKey(country))
            {
                Console.WriteLine($"Страна {country} и её столица {countries[country]}");
            }
            else
            {
                Console.WriteLine("Такой станы нет!");
            }
        }
    }
}
