using System;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace RecyclerViewSample
{
    public class MovieViewHolder : RecyclerView.ViewHolder
    {
        public TextView MovieNameTextView { get; set; }

        public TextView DirectedByTextView { get; set; }

        public TextView ReleasedOnTextView { get; set; }

        public MovieViewHolder(View itemView, Action<int> listener) : base(itemView)
        {
            MovieNameTextView = itemView.FindViewById<TextView>(Resource.Id.movieNameText);
            DirectedByTextView = itemView.FindViewById<TextView>(Resource.Id.directedByText);
            ReleasedOnTextView = itemView.FindViewById<TextView>(Resource.Id.releasedOnText);

            itemView.Click += (s,e) => listener(Position);
        }
    }
}