using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Opgave_2.ViewModel
{
    class login: INotifyPropertyChanged
    {
        private string VersionText;
        private string StatusText;
        private string LoginEntry;
        private string LoginKnap;
        private string propertyName;

        public event PropertyChangedEventHandler PropertyChanged;

        public string VersionText1
        {
            get
            {
                return VersionText;
            }

            set
            {   if (VersionText != value)
                    VersionText = value;
                OnPropertyChanged("Color");

            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName="")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,
                    new PropertyChangedEventArgs(propertyName));
            }

        }

        public string StatusText1
        {
            get
            {
                return StatusText;
            }

            set
            {
                StatusText = value;
            }
        }

        public string LoginEntry1
        {
            get
            {
                return LoginEntry;
            }

            set
            {
                LoginEntry = value;
            }
        }

        public string LoginKnap1
        {
            get
            {
                return LoginKnap;
            }

            set
            {
                LoginKnap = value;
            }
        }
    }
}
