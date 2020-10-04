using ConsoleApp5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp5.Command
{
    class DeleteWord : ICommand
    {
        private readonly LanguageDictionary dictionary;

        public DeleteWord(LanguageDictionary dictionary)
        {
            this.dictionary = dictionary;
        }

        public bool CanRun(string input)
        {
            return input == "DeleteW";
        }

        public string GetMenuRow()
        {
            return "DeleteW - Удалить переводимое слово вместе с переводом";
        }

        public string Run(string input, ref bool isExit)
        {
            List<string> busket = new List<string>();

            WriteLine("Введите слово которое хотите удалить: ");
            string currentWord = ReadLine();

            if (!dictionary.Dictionary.ContainsKey(currentWord))
            {

                return "Слово не найдено";
            }
        
            dictionary.Dictionary.Remove(currentWord);
            return "Слово успешно удалено!";
        }
    }
}
