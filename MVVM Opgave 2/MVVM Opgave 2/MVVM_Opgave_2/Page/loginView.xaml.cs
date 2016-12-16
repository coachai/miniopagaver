using Xamarin.Forms;
using MVVM_Opgave_2.ViewModel;

namespace MVVM_Opgave_2.page
{
    public partial class loginView : ContentPage
    {
        private login onelongin;
        public loginView(login onelogin)
        {
            this.onelongin = onelongin;
            InitializeComponent();
          //  Label newLabel = new Label();
            BindingContext = this.onelongin;
            VersionsTekst.SetBinding(Label.TextProperty, "VersionsTekst", BindingMode.OneWay);
            LoginEntry.SetBinding<login>(Entry.TextProperty, vm->vm.LoginEntry, BindingMode.OneWay);
        }
    }
}
