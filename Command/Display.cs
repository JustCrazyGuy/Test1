using ConsoleApp5.Model;
using System;
using System.Collections.Generic;
//using System.IO;
using System.Linq;
//using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp5.Command
{
    class Display : ICommand
    {
        private readonly LanguageDictionary dictionary;

        public Display(LanguageDictionary dictionary)
        {
            this.dictionary = dictionary;
        }
        public bool CanRun(string input)
        {
            return input == "Display1";
        }


        public string GetMenuRow()
        {
            return "Display1 - Вывести на экран весь словарь";
        }
        public string Run(string input, ref bool isExit)
        {
            string str = "Тип словаря: " + dictionary.Type;
            str += "\n";

           foreach(KeyValuePair<String,List<string>> pair in dictionary.Dictionary)
            {
                str += pair.Key + " " + String.Join(", ", pair.Value);
                //WriteLine(Book.Value);
            }

            return str;
        }
    }
}
