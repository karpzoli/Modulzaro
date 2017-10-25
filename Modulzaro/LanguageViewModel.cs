using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Modulzaro
{
    class LanguageViewModel:BaseModel1
    {
        public ObservableCollection<Language> LanguageList { get; set; }
        public Language SelectLanguage { get; set; }

        public LanguageViewModel()
        {
            LanguageList = new ObservableCollection<Language>
            {
                new Language{Name="C#", Field="Back-End", KnowledgeLevel =10},
                new Language{Name="PHP", Field="Back-End", KnowledgeLevel =60},
                new Language{Name="JavaScript", Field="Front-End", KnowledgeLevel =50}
            };
        }
    }
}
