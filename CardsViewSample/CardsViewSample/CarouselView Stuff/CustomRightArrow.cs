using PanCardView.Controls;
using Xamarin.Forms;
namespace CardsViewSample.CarouselView_Stuff
{
    class CustomRightArrow : ArrowControl
    {
        public CustomRightArrow()
        {
            AbsoluteLayout.SetLayoutBounds(this, new Rectangle(1, .5, -1, -1));
            Content = new Image
            {
                Source = "down_arrow.png",
                Rotation = -90
            };
        }
    }
}
