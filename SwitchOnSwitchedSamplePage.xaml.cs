using System.Collections.Generic;
using Xamarin.Forms;

namespace SwitchOnSwitchedSample
{
    public partial class SwitchOnSwitchedSamplePage : ContentPage
    {
        public SwitchOnSwitchedSamplePage()
        {
            InitializeComponent();

            interestList.ItemsSource = new List<Foo>() {
				new Foo { Text = "Hi", Bar = 1 },
				new Foo { Text = "He", Bar = 2 },
				new Foo { Text = "Ho", Bar = 3 },
				new Foo { Text = "Hu", Bar = 4 },
				new Foo { Text = "Ha", Bar = 5 }

            };
        }

        private void Handle_OnChanged(object sender, ToggledEventArgs args)
        {
			var selectedItem = ((SwitchCell)sender).BindingContext as Foo;

            DisplayAlert(title: selectedItem.Text, message: selectedItem.Bar.ToString(), cancel: "OK");                
		}
    }
}