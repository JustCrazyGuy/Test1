using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Command
{
    interface ICommand
    {
         bool CanRun(string input);
         string Run(string input, ref bool isExit);
         string GetMenuRow();
        

    }
}
