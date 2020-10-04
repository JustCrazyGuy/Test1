using ConsoleApp5.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp5.Command
{
    class ChangeWord : ICommand
    {
        private readonly LanguageDictionary dictionary;

        public ChangeWord(LanguageDictionary dictionary)
        {
            this.dictionary = dictionary;
        }

        public bool CanRun(string input)
        {
            return input == "ChangeWord";
        }

        public string GetMenuRow()
        {
            return "ChangeWord - Изменить переводимое слово";
        }

        public string Run(string input, ref bool isExit)
        {
           // LanguageDictionary buffDictionary = new LanguageDictionary();
           // dictionary.Dictionary = buffDictionary.Dictionary;
           // dictionary.Type = buffDictionary.Type;

            List<string> busket = new List<string>();
            
            WriteLine("Введите слово которое хотите изменить: ");
            string currentWord = ReadLine();
            //dictionary.Dictionary.TryGetValue(currentWord,out busket);

            if (!dictionary.Dictionary.ContainsKey(currentWord))
            {
               
                return "Слово не найдено";
            }
            dictionary.Dictionary.TryGetValue(currentWord, out busket);
            dictionary.Dictionary.Remove(currentWord);
            WriteLine("Слово найдено,Введите новое");
                currentWord = ReadLine();
            dictionary.Dictionary.Add(currentWord,busket);
            return "Слово успешно изменено!";
        }
    }
}
