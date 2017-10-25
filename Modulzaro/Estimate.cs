using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Modulzaro
{
    class Estimate:BaseModel1
    {
        string _field;

        public string Field {
            get { return _field; }
            set { _field = value; OnPropertyChange(); }
        }

        int _Level;

        public int Level {
            get { return _Level; }
            set { _Level = value; OnPropertyChange(); }
        }

        public ObservableCollection<Estimate> TreatmentList { get; set; }
    }
}
