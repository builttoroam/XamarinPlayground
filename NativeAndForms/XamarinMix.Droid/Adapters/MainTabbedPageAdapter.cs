﻿using System;
using Android.App;
using Android.Runtime;
using Android.Support.V4.App;
using Xamarin.Forms.Platform.Android;
using XamarinMix.Droid.Fragments;
using XamarinMix.Forms;
using Fragment = Android.Support.V4.App.Fragment;
using FragmentManager = Android.Support.V4.App.FragmentManager;

namespace XamarinMix.Droid.Adapters
{
    public class MainTabbedPageAdapter : FragmentStatePagerAdapter
    {
        private readonly FragmentManager fragmentManager;

        public MainTabbedPageAdapter(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }

        public MainTabbedPageAdapter(FragmentManager fragmentManager)
            : base(fragmentManager)
        {
            this.fragmentManager = fragmentManager;
        }

        public override int Count { get; } = 2;

        public override Fragment GetItem(int position)
        {
            if (position == 0)
            {
                return new MapFragment();
            }

            if (position == 1)
            {
                return new CustomFragment(fragmentManager);
            }

            return null;
        }
    }
}