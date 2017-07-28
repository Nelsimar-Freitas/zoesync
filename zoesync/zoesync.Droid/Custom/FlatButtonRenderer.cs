using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;

[assembly: ExportRenderer( typeof( Button ), typeof( zoesync.Droid.Custom.FlatButtonRenderer ) )]
namespace zoesync.Droid.Custom
{
    public class FlatButtonRenderer : ButtonRenderer
    {
        protected override void OnDraw(Android.Graphics.Canvas canvas)
        {
            base.OnDraw( canvas );
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged( e );
        }
    }

//        [assembly: ExportRenderer (typeof (Button), typeof (ButtonCustomRenderer))]
//namespace MyApp.Droid
//    {
//        public class ButtonCustomRenderer : ButtonRenderer
//        {
//            Android.Graphics.Typeface _typeFaceRegular = Android.Graphics.Typeface.CreateFromAsset( Android.App.Application.Context.Assets, "AbcTT-Regular_2_0.ttf" );

//            protected override void OnElementChanged(Xamarin.Forms.Platform.Android.ElementChangedEventArgs&lt; Button&gt; e)
//        {
//            base.OnElementChanged(e);

//            Control.SetTypeface (_typeFaceRegular, Android.Graphics.TypefaceStyle.Normal);

//            Control.StateListAnimator = null;
//        }

//        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
//        {
//            base.OnElementPropertyChanged( sender, e );
//        }
//    }
//}

}