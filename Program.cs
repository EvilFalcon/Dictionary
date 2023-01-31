using System;
using System.Collections.Generic;

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

            Dictionary<string, string> countries = CreateDictionary();

            bool isProgramWork = true;

            while (isProgramWork)
            {
                Console.Clear();

                Console.WriteLine($"{CommandDictionaryLook}<--Показать весь список\n" +
                    $"{CommandDictionaryAdd}<--добавить страну в список \n" +
                    $"{CommandDictionaryRemove}<--удалить страну из списка \n" +
                    $"{CommandDictionarySearch}<--поиск столицы по названию страны \n" +
                    $"{CommandExitProgram}<--выход из программы");

                switch (Console.ReadLine())
                {
                    case CommandDictionaryLook:
                        PrintDictionary(countries);
                        break;

                    case CommandDictionaryAdd:
                        AddNewWord(countries);
                        break;

                    case CommandDictionaryRemove:
                        RemoveWord(countries);
                        break;

                    case CommandDictionarySearch:
                        ShowByCountry(countries);
                        break;

                    case CommandExitProgram:
                        isProgramWork = false;
                        break;
                }

                Console.Write("Нажмите любую кнопку для того чтобы продолжить!");
                Console.ReadKey();
            }
        }

        private static Dictionary<string, string> CreateDictionary()
        {
            return new Dictionary<string, string>
            {
                { "Россия", "Москва" },
                { "Нидерланды", "Амстердам" },
                { "Греция", "Афины" },
                { "Сербия", "Белград" },
                { "Германия", "Берлин" },
                { "Швейцария", "Берн" },
                { "Словакия", "Братислава" },
                { "Бельгия", "Брюссель" }
            };
        }

        private static void PrintDictionary(Dictionary<string, string> countries)
        {
            foreach (var capitalCities in countries)
            {
                Console.WriteLine($"Страна {capitalCities.Key} и её столица {capitalCities.Value} !");
            }
        }

        private static void AddNewWord(Dictionary<string, string> countries)
        {
            Console.Write("\nВведите новую  страну в список : ");
            string country = Console.ReadLine();

            if (countries.ContainsKey(country))
            {
                Console.WriteLine($"Эта страна '{country}' уже есть в списке ");
            }
            else
            {
                Console.Write($"\nВведите столицу страны {country} чтобы добавить в список : ");
                string capitalCity = Console.ReadLine();
                countries.Add(country, capitalCity);
                Console.WriteLine($"Страна {country} и её столица {capitalCity} добавлены в список! ");
            }
        }

        private static void RemoveWord(Dictionary<string, string> countries)
        {
            Console.Write("Введите страну чтобы удалить её из списка: ");
            string country = Console.ReadLine();

            if (countries.ContainsKey(country))
            {
                countries.Remove(country);
                Console.WriteLine($"Страна {country} удалена из списка!");
            }
        }

        private static void ShowByCountry(Dictionary<string, string> countries)
        {
            Console.Write("Введите страну чтобы узнать столицу : ");
            string country = Console.ReadLine();

            if (countries.ContainsKey(country))
            {
                Console.WriteLine($"Страна {country} и её столица {countries[country]}");
            }
            else
            {
                Console.WriteLine("Такой станы нет или вы ввели её неправильно !");
            }
        }
    }
}
