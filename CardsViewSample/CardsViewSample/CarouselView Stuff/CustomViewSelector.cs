using CardsViewSample.My_Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CardsViewSample.CarouselView_Stuff
{
    class CustomViewSelector : DataTemplateSelector
    {
        private DataTemplate view1 = new DataTemplate(typeof(View1));
        private DataTemplate view2 = new DataTemplate(typeof(View2));
        private DataTemplate view3 = new DataTemplate(typeof(View3));

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            // I don't use 'new' at every time as I do need to retain views status
            Type currentView = item as Type;

            if (currentView == typeof(View1))
                return view1;
            else if (currentView == typeof(View2))
                return view2;
            return view3;
        }

    }
}
