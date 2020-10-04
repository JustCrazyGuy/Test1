using ConsoleApp5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp5.Command
{
    class SearchT : ICommand
    {
        private readonly LanguageDictionary dictionary;

        public SearchT(LanguageDictionary dictionary)
        {
            this.dictionary = dictionary;
        }

        public bool CanRun(string input)
        {
            return input == "SearchT";
        }

        public string GetMenuRow()
        {
            return "SearchT - Удалить перевод слова";
        }


        public string Run(string input, ref bool isExit)
        {
            List<string> busket = new List<string>();
            bool key = false;
            WriteLine("Введите первод нужного слова: ");
            string currentWord = ReadLine();
            List<string> NewWords = new List<string>();
            NewWords.Add(currentWord);
            foreach(string yes in dictionary.Dictionary.Keys)
            {
                dictionary.Dictionary.TryGetValue(yes, out busket);
                if (busket.Contains(currentWord))
                {
                    key = true;
                }
               
               
                if (key == true)
                {
                    return "Перевод успешно найден!";
                }
            }
            return "Перевод не найден!";   
            //В задании было указано найти перевод,но не вывести его :)
        }
    }
}

