using Android.App;
using Android.Widget;
using Android.OS;

namespace BindingTest
{
    [Activity(Label = "BindingTest", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            initialMethod();
        }

        // initializing a necessary stuff
        private void initialMethod()
        {

        }
    }
}

