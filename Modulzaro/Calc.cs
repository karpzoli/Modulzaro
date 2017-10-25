using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulzaro
{
    public static class Calc
    {
        public static int NumberOfLanguages(IEnumerable<Language> languages)
        {
            return languages.Count();
        }
    }
}
