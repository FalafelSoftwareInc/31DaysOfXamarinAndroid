using Android.App;
using Android.OS;
using Android.Webkit;

namespace ScrollAndWebViewSample
{
    [Activity(Label = "WebViewSampleActivity")]
    public class WebViewSampleActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.webviewsample);

            var webView = FindViewById<WebView>(Resource.Id.webView1);

            webView.LoadUrl("http://falafel.com");
        }
    }
}