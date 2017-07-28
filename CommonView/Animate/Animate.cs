using System.Threading.Tasks;
using Xamarin.Forms;

namespace CommonView.Animate
{
    public class Animate
    {
        //
        public static async Task BallAnimate(View view, int Top, int reduce, int time)
        {

            //Rodada 360 graus               
            //await view.RelRotateTo( 360, 1000 );               
            do
            {
                await view.TranslateTo( view.TranslationX, view.TranslationY - Top, 700, Easing.CubicOut );

                await view.TranslateTo( view.TranslationX, view.TranslationY + Top, 400, Easing.CubicIn );

                await view.FadeTo( 90, 500 );

                Top = Top - reduce;
                time--;
            } while( time != 0 );

            await view.FadeTo( -0, 500 );

            /*
            await view.TranslateTo(view.TranslationX, view.TranslationY - 50, 500, Easing.Linear);

            await view.TranslateTo(view.TranslationX, view.TranslationY + 50, 300, Easing.Linear);

            await view.TranslateTo(view.TranslationX, view.TranslationY - 20, 300, Easing.Linear);

            await view.TranslateTo(view.TranslationX, view.TranslationY + 20, 150, Easing.Linear);

            await view.TranslateTo(view.TranslationX, view.TranslationY - 10, 150, Easing.Linear);

            await view.TranslateTo(view.TranslationX, view.TranslationY + 10, 100, Easing.Linear);

            await view.FadeTo(-0, 1000);
            */
        }
    }
}
