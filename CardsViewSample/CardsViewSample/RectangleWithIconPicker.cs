using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CardsViewSample
{
    public class RectangleWithIconPicker : Picker
    {
        public static readonly BindableProperty IconSourceProperty =
       BindableProperty.Create(nameof(IconSourceWithoutExtension), typeof(string), typeof(RectangleWithIconPicker), string.Empty);

        public static readonly BindableProperty IconDistanceProperty =
       BindableProperty.Create(nameof(IconDistanceFromRight), typeof(int), typeof(RectangleWithIconPicker), 0);

        public string IconSourceWithoutExtension
        {
            get { return (string)GetValue(IconSourceProperty); }
            set { SetValue(IconSourceProperty, value); }
        }

        public int IconDistanceFromRight
        {
            get { return (int)GetValue(IconDistanceProperty); }
            set { SetValue(IconDistanceProperty, value); }
        }
    }
}
