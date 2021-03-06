﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.ComponentModel;


namespace Modulzaro
{
    public class BaseModel1 : INotifyPropertyChanged
{
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChange([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this,
                    new PropertyChangedEventArgs(propertyName));
        }
    }
}
