using ConsoleApp5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp5.Command
{
    class DeleteTransate : ICommand
    {
        private readonly LanguageDictionary dictionary;

        public DeleteTransate(LanguageDictionary dictionary)
        {
            this.dictionary = dictionary;
        }

        public bool CanRun(string input)
        {
            return input == "DeleteTranslate";
        }

        public string GetMenuRow()
        {
            return "DeleteTranslate - Удалить перевод слова";
        }


        public string Run(string input, ref bool isExit)
        {
            List<string> busket = new List<string>();

            WriteLine("Введите слово,перевод которого хотите удалить: ");
            string currentWord = ReadLine();
            List<string> NewWords = new List<string>();

            dictionary.Dictionary.TryGetValue(currentWord, out busket);

            if (!dictionary.Dictionary.ContainsKey(currentWord))
            {

                return "Слово не найдено";
            }
            WriteLine("Слово найдено,введите какой перевод хотите удалить: ");
            if (busket.Count < 2)
            {
                return "Нельзя удалить последний перевод";
            }
                if (!busket.Remove(ReadLine()))
                {
                    return "Слово не найдено";
                }
            

            string currentWord2 = currentWord;
            dictionary.Dictionary.Remove(currentWord);
            dictionary.Dictionary.Add(currentWord2, busket);
            return "Перевод успешно удалён!";
        }
    }
}
