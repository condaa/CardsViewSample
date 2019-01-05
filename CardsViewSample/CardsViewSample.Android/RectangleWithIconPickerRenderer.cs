using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.Content;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CardsViewSample.RectangleWithIconPicker), typeof(CardsViewSample.Droid.RectangleWithIconPickerRenderer))]

namespace CardsViewSample.Droid
{
    class RectangleWithIconPickerRenderer : PickerRenderer
    {
        RectangleWithIconPicker element;

        public RectangleWithIconPickerRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);

            element = (RectangleWithIconPicker)this.Element;

            if (Control != null && this.Element != null && !string.IsNullOrEmpty(element.IconSourceWithoutExtension))
            {
                Control.Background = AddPickerStyles(element.IconSourceWithoutExtension, element.IconDistanceFromRight);
                Control.Gravity = GravityFlags.Center;
                //Control.SetBackground(ContextCompat.GetDrawable(Context, Resource.Drawable.edittextbottombar));
            }
        }

        public LayerDrawable AddPickerStyles(string iconPath, int iconDistance)
        {
            //ShapeDrawable border = new ShapeDrawable();
            //border.Paint.Color = Android.Graphics.Color.Gray;
            //border.SetPadding(10, 10, 10, 10);
            //border.Paint.SetStyle(Paint.Style.Stroke);
            //
            //Drawable[] layers = { border, GetDrawable(imagePath) };
            //LayerDrawable layerDrawable = new LayerDrawable(layers);
            //layerDrawable.SetLayerInset(0, 0, 0, 0, 0);
            //
            //return layerDrawable;

            GradientDrawable grand = new GradientDrawable();
            Android.Graphics.Color catalystDarkGrey = Android.Graphics.Color.ParseColor("#605e5e");
            grand.SetStroke(3, catalystDarkGrey);

            //ContextCompat.GetDrawable(Context, Resource.Drawable.edittextbottombar)

            Drawable[] layers = { grand, GetDrawable(iconPath) };
            LayerDrawable layerDrawable = new LayerDrawable(layers);
            //layerDrawable.SetLayerInset(1, 10, 10, 10, 10);


            if (Build.VERSION.SdkInt >= BuildVersionCodes.M)
            {
                layerDrawable.SetLayerInsetRight(1, iconDistance);
            }
            else
            {
                layerDrawable.SetLayerInset(1, 0, 0, iconDistance, 0);
            }
            //layerDrawable.SetLayerInsetRight(1, iconDistance);

            //layerDrawable.SetLayerInsetRight(0, 100);


            return layerDrawable;
        }

        private BitmapDrawable GetDrawable(string imagePath)
        {
            int resID = Resources.GetIdentifier(imagePath, "drawable", this.Context.PackageName);
            var drawable = ContextCompat.GetDrawable(this.Context, resID);
            var bitmap = ((BitmapDrawable)drawable).Bitmap;

            var result = new BitmapDrawable(Resources, Bitmap.CreateScaledBitmap(bitmap, 40, 40, true));
            result.Gravity = Android.Views.GravityFlags.Right;

            return result;
        }
    }
}