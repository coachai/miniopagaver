using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleEvent
{   class Observable
    {
        public event EventHandler<string> NameChanged;
        public void OnNameChanged()
        { EventHandler<string> handler = NameChanged;
            if (handler != null)
            { handler(this,  EventArgs.Empty.ToString());
              
            }
        }
    }

    class Observer
    {
        public virtual void HandleEvent(object sender, string args)
        { Debug.WriteLine("Something happened to " + sender); }
    }

    class Test
    {
        static void Main(string[] args)
        {
            Observable observable = new Observable();
            Observer observer = new Observer();
            observable.NameChanged += observer.HandleEvent;

            observable.OnNameChanged();
        }
    }
}
