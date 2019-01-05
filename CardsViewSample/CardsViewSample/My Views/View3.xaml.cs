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
	public partial class View3 : ContentView
	{
		public View3 ()
		{
			InitializeComponent ();
            List<string> pickerItems = new List<string>() { "Tom Hanks", "Leo Messi", "Three", "Four", "Five"};
            myListView.ItemsSource = pickerItems;

        }
    }
}