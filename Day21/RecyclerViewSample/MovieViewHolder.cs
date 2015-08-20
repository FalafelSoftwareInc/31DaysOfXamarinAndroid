using System;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace RecyclerViewSample
{
    public class MovieViewHolder : RecyclerView.ViewHolder
    {
        public TextView MovieNameTextView { get; set; }
        public ImageView MovieImageView { get; set; }

        public MovieViewHolder(View itemView, Action<int> listener) : base(itemView)
        {
            MovieNameTextView = itemView.FindViewById<TextView>(Resource.Id.cardViewText);
            MovieImageView = itemView.FindViewById<ImageView>(Resource.Id.imageView);

            itemView.Click += (s,e) => listener(Position);
        }
    }
}