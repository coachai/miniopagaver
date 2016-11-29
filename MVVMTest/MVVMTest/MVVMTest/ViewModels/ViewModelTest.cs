using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MVVMTest.ViewModels
{
    public class ViewModelTest : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string versionText="1.2.4";
        private string statusText ="StatusText";
        private bool loginOK = false;
        private string login;

     
        public string VersionText
        {
            get
            {
                return versionText;
            }

            set
            {
                if (versionText != value)
                {
                    versionText = value;
                    OnPropertyChanged(); //compiler provides the property name;
                    
                }
            }
        }

        public bool LoginOK
        {
            get
            {
                return loginOK;
            }

            set
            {
                if (loginOK != value)
                {
                   
                    loginOK = value;
                    OnPropertyChanged(); //compiler provides the property name;
                }


            }
        }

        public string StatusText
        {
            get
            {
                return statusText;
            }

            set
            {
                if (StatusText != value)
                {
                    statusText = value;
                    OnPropertyChanged("StatusText"); //propertyname provided manually
                  

                if (string.IsNullOrEmpty(StatusText) || string.IsNullOrWhiteSpace(StatusText))
                {
                    LoginOK = false;
                    VersionText = "indtast Telefonnummer";
                }
                else
                    { if (statusText.Length == 8)
                        {
                            LoginOK = true;
                            VersionText = "Klar til log in";
                        }
                    }
                  
            }
                
            }
        }

        public string Login
        {
            get
            {
                return login;
            }

            set
            {
                login = value;
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string properName = "")
        {
            var evn = PropertyChanged;
            if (evn != null)
            { evn(this, new PropertyChangedEventArgs(properName));
            }


        }
    }
}
