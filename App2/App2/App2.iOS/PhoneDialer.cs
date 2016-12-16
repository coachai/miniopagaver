using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using App2.iOS;

[assembly:Dependency(typeof(PhoneDialer))]
namespace App2.iOS
{
   public class PhoneDialer:IDialer
    {
        public bool Dial(string number)
        {
            return UIApplication.SharedApplication.OpenUrl(
                    new NSUrl("tel:" + number));
        }
    }
}