using MVVMTest.ViewModels;
using Xamarin.Forms;

namespace MVVMTest.Page
{
    public partial class TestPage : ContentPage
    {
        private ViewModelTest viewmodelTest;
        public TestPage(ViewModelTest viewmodelTest)
        {
            this.viewmodelTest = viewmodelTest;
            BindingContext = this.viewmodelTest;
            InitializeComponent();

            VersionTextLabel.SetBinding<ViewModelTest>(Label.TextProperty,vm=>vm.VersionText, BindingMode.OneWay);
            LoginOkButton.SetBinding(Button.IsEnabledProperty, "LoginOK", BindingMode.OneWay);
            // TestEntry.SetBinding(Entry.KeyboardProperty,"TestEntry",BindingMode.OneWay);
            StatusEntry.SetBinding<ViewModelTest>(Entry.TextProperty,vm=>vm.StatusText, BindingMode.OneWayToSource);
          




        }
    }
}
