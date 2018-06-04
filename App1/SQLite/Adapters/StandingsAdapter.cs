using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite.Models;

namespace SQLite.Adapters
{
    class StandingsAdapter : BaseAdapter<clubs_standings>
    {

        List<clubs_standings> clubs_Standings;
        Context context;

        public StandingsAdapter(Context context, List<clubs_standings> clubs_Standings)
        {
            this.context = context;
            this.clubs_Standings = clubs_Standings;
        }


        public override Java.Lang.Object GetItem(int position)
        {
            return position;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView;
            StandingsAdapterViewHolder holder = null;

            if (view != null)
                holder = view.Tag as StandingsAdapterViewHolder;

            if (holder == null)
            {
                holder = new StandingsAdapterViewHolder();
                var inflater = context.GetSystemService(Context.LayoutInflaterService).JavaCast<LayoutInflater>();
                //replace with your item and your holder items
                //comment back in
                view = inflater.Inflate(Android.Resource.Layout.SimpleListItem1, parent, false);
                holder.Title = view.FindViewById<TextView>(Android.Resource.Id.Text1);
                view.Tag = holder;
            }


            //fill in your items
            holder.Title.Text = clubs_Standings[position].Name;

            return view;
        }

        //Fill in cound here, currently 0
        public override int Count
        {
            get
            {
                return clubs_Standings.Count;
            }
        }

        public override clubs_standings this[int position] => throw new NotImplementedException();
    }

    class StandingsAdapterViewHolder : Java.Lang.Object
    {
        //Your adapter views to re-use
        public TextView Title { get; set; }
    }
}