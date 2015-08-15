using Android.Content;
using Android.Views;
using Android.Widget;

namespace FunWithMediaControls
{
    public class CuteCatsAdapter : BaseAdapter
    {
        Context context;

        public CuteCatsAdapter (Context c)
        {
            context = c;
        }

        public override int Count { get { return imagesToShow.Length; } }

        public override Java.Lang.Object GetItem (int position)
        {
            return null;
        }

        public override long GetItemId (int position)
        {
            return 0;
        }

        // create a new ImageView for each item referenced by the Adapter
        public override View GetView (int position, View convertView, ViewGroup parent)
        {
            ImageView i = new ImageView (context);

            i.SetImageResource (imagesToShow[position]);
            i.LayoutParameters = new Gallery.LayoutParams (500, 500);
            i.SetScaleType (ImageView.ScaleType.FitXy);

            return i;
        }

        // references to our images
        int[] imagesToShow = {
            Resource.Drawable.cat1,
            Resource.Drawable.cat2,
            Resource.Drawable.cat3
        };
    }
}