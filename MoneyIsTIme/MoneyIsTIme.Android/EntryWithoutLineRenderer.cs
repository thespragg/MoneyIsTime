using MoneyIsTime.Models;
using MoneyIsTime.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(EntryWithoutLine), typeof(EntryWithoutLineRenderer))]
namespace MoneyIsTime.Droid
{
    public class EntryWithoutLineRenderer : EntryRenderer
    {
        public EntryWithoutLineRenderer() : base(Android.App.Application.Context) { }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            Control.SetBackgroundColor(Android.Graphics.Color.Transparent);
        }
    }
}