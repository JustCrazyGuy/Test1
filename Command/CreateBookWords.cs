using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp5.Command
{
    class CreateBookWords : ICommand
    {
        public bool CanRun(string input)
        {
            return input == "Create";
        }

    
        public string GetMenuRow()
        {
            return "Create - Создать словарь";
        }

        public string Run(string input, ref bool isExit)
        {
            WriteLine("Русско-английский или Англо-русский(Введите 1 или 2)");
            string key = ReadLine();
            if (key == "1")
            {
                using (var fs = new StreamWriter("RuEn.txt"))
                {
                }
            }
            else if (key == "2")
            {
                using (var fs = new StreamWriter("EnRu.txt"))
                {
                }
            }
            else
            {
                WriteLine("Ошибка ввода");
            }
            return "Славарь создан";
        }

    }
}
