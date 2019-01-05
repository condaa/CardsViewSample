using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CardsViewSample.My_Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class View2 : ContentView
	{
		public View2 ()
		{
			InitializeComponent ();
            List<string> pickerItems = new List<string>() { "One", "Two", "Three", "Four" };
            defaultPicker.ItemsSource = pickerItems;
            customPicker.ItemsSource = pickerItems;
        }
	}
}