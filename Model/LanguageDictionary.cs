using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Model
{
    [Serializable]
    public class LanguageDictionary
    {
        public LanguageDictionary()
        {
            Dictionary = new Dictionary<String, List<string>>();
        }

        public string Type { get; set; }
        public Dictionary<String, List<string>> Dictionary { get; set; }

        public static implicit operator Dictionary<object, object>(LanguageDictionary v)
        {
            throw new NotImplementedException();
        }
    }
}
