using CardsViewSample.My_Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CardsViewSample
{
    public partial class MainPage : ContentPage
    {
        public List<Type> AvaiableViews { get; set; } // Must have default value or be set before the BindingContext is set.
        private int _position;
        public int Position { get { return _position; } set { _position = value; OnPropertyChanged(); } }

        public MainPage()
        {
            InitializeComponent();

            AvaiableViews = new List<Type>() { typeof(View1), typeof(View2), typeof(View3) };

            BindingContext = this;

        }
    }
}
