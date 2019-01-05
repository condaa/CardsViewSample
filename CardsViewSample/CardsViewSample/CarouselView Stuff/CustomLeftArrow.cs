using PanCardView.Controls;
using Xamarin.Forms;

namespace CardsViewSample.CarouselView_Stuff
{
    class CustomLeftArrow : ArrowControl
    {
        public CustomLeftArrow()
        {
            IsRight = false;
            AbsoluteLayout.SetLayoutBounds(this, new Rectangle(0, .5, -1, -1));
            Content = new Image
            {
                Source = "down_arrow.png",
                Rotation = 90
            };
        }
    }
}
