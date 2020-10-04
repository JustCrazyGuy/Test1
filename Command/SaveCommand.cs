using ConsoleApp5.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.SqlServer.Server;

namespace ConsoleApp5.Command
{
    class SaveCommand : ICommand
    {
        private readonly LanguageDictionary dictionary;

        public SaveCommand(LanguageDictionary dictionary)
        {
            this.dictionary = dictionary;
        }
        public bool CanRun(string input)
        {
            return input == "SaveFile";
        }

        public string GetMenuRow()
        {
            return "SaveFile - Сохранить словарь";
        }
        public string Run(string input, ref bool isExit)
        {
            BinaryFormatter serializer = new BinaryFormatter();
            using (Stream FileS = File.OpenWrite("RuEn.txt"))
            {
                serializer.Serialize(FileS, dictionary.Dictionary);
            }
            return "Сохранение прошло успешно\n";
        }
    }
}
