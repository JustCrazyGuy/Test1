using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using ConsoleApp5.Command;
using ConsoleApp5.Model;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //AppDbContext context = new AppDbContext();
            List<ICommand> commands = new List<ICommand>();
            LanguageDictionary languageDictionary = new LanguageDictionary();
            commands.Add(new CreateBookWords());
            commands.Add(new AddWordsRuEn(languageDictionary));
            commands.Add(new SaveCommand(languageDictionary));
            commands.Add(new LoadFromFile(languageDictionary));
            commands.Add(new Display(languageDictionary));
            commands.Add(new SearchT(languageDictionary));
            commands.Add(new ChangeWord(languageDictionary));
            commands.Add(new ChangeTranslate(languageDictionary));
            commands.Add(new DeleteWord(languageDictionary));
            commands.Add(new DeleteTransate(languageDictionary));
            commands.Add(new ExitCommand());
            //commands.Add(new AddPersonCommand(context));
            //commands.Add(new GetPersonListCommand(context));
            bool isExit = false;
            string input;
            string commandResult;
            do
            {
                WriteLine("===========================================");
                foreach (ICommand command in commands)
                {
                    WriteLine(command.GetMenuRow());
                }
                WriteLine();
                Write("Введите команду: ");
                input = ReadLine();
                foreach (ICommand command in commands)
                {
                    if (command.CanRun(input))
                    {
                      
                        commandResult = command.Run(input, ref isExit);
                       // WriteLine("твоя ошибка");
                        WriteLine(commandResult);
                        break;
                    }
                }
            } while (!isExit);
            ReadKey();
        }
    }
}

