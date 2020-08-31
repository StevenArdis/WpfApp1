using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WpfApp1
{
    class Student : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string name;

        public string Name
        {
            get { return name; }
            set 
            { 
                name = value;
                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Name"));
                }
            }
        }

    }
}
