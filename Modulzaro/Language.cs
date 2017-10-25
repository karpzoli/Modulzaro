using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Modulzaro
{
    public class Language:BaseModel1
    {
        string _name;

        public string Name {
            get { return _name; }
            set { _name = value; OnPropertyChange(); }
        }

        string _field; //(BE, FE, Mobile)

        public string Field {
            get { return _field; }
            set { _field = value; OnPropertyChange(); }
        }

        int _knowledgeLevel;

        public int KnowledgeLevel {
            get { return _knowledgeLevel; }
            set { _knowledgeLevel = value; OnPropertyChange(); }
        }
        

    }
}
