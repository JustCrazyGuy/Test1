using ConsoleApp5.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Command
{
    class LoadFromFile : ICommand
    {
        private readonly LanguageDictionary dictionary;

        public LoadFromFile(LanguageDictionary Dictionary)
        {
            this.dictionary = Dictionary;
        }
        public bool CanRun(string input)
        {
            return input == "LoadFromFile";
        }


        public string GetMenuRow()
        {
            return "LoadFromFile - Загрузить данные из файла";
        }
        public string Run(string input, ref bool isExit)
        {
            LanguageDictionary BuffDictionary = new LanguageDictionary();
            BinaryFormatter Serializer = new BinaryFormatter();
            using (Stream FileS = File.OpenRead("RuEn.txt"))
            {
                 BuffDictionary = Serializer.Deserialize(FileS) as LanguageDictionary;
            }
              dictionary.Type = BuffDictionary.Type;
              dictionary.Dictionary = BuffDictionary.Dictionary;
            return "Загрузка прошло успешно\n";
        }
    }
}
