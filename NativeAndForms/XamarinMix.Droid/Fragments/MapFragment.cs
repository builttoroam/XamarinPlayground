﻿using Android.OS;
using Android.Support.V4.App;
using Android.Views;

namespace XamarinMix.Droid.Fragments
{
    public class MapFragment : Fragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.map, container, false);
        }
    }
}