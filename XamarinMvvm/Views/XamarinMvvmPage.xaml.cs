using Xamarin.Forms;
using XamarinMvvm.ViewModel;

namespace XamarinMvvm
{
    public partial class XamarinMvvmPage : ContentPage
    {
        public XamarinMvvmPage()
        {
            InitializeComponent();
            this.BindingContext = new EmployeeViewModel();
        }
    }
}
