using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using Xamarin.Forms.Platform.iOS;
using UIKit;
using Xamarin.Forms;
using RendererTest;

[assembly: ExportRenderer(typeof(HelloView), typeof(EntryRenderer))]

namespace RendererTest.iOS
{
    class HelloRenderers : ViewRenderer<HelloView, UILabel>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<HelloView> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                UILabel label = new UILabel
                {
                    Text = "Hello from iOS!",
                    Font = UIFont.SystemFontOfSize(24)
                };
                SetNativeControl(label);
            }
        }
    }
}