using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;
using System.Xml.Serialization;
using ConsoleApp5.Model;

namespace ConsoleApp5.Command
{
    class AddWordsRuEn : ICommand
    {
        private readonly LanguageDictionary dictionary;

        public AddWordsRuEn(LanguageDictionary dictionary)
        {
            this.dictionary = dictionary;
        }

        public bool CanRun(string input)
        {
            return input == "AddWord";
        }

        public string GetMenuRow()
        {
            return "AddWord - Добавить слово в русско-английский";
        }

        public string Run(string input, ref bool isExit)
        {
            string OriginalWord;
            string key;
            //XmlSerializer serializer = new XmlSerializer(typeof(AddWordsRuEn));
            //AddWordsRuEn i = null;
            bool EndWords = true;
            //Dictionary<String,List<string>> Translate = new Dictionary<String,List<string>>();
            List<string> translates = new List<string>();
            //using (Stream FileS = File.OpenRead("RuEn.txt"))
            {
                WriteLine("Введите переводимое слово: ");
                OriginalWord = ReadLine();
                OriginalWord.Trim();
                
                do
                {
                    WriteLine("Введите перевод(переводы) слова: ");
                    translates.Add(ReadLine());
                    WriteLine("\nЭто последнее значение? (1-да 2-нет)");
                    key = ReadLine();
                    if (key == "1")
                    {
                        EndWords = false;
                        translates.Add("\n");
                    }
                    else if (key== "2")
                    {
                        //
                    }
                } while (EndWords);
                //i = (AddWordsRuEn)serializer.Deserialize(FileS);
                dictionary.Dictionary.Add(OriginalWord,translates);
                //FileS.Write(Translate.Values);

            }
            return "";
        }
    }
}
