﻿using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public static partial class Map
    {
        internal static Task PlatformOpenMapsAsync(double latitude, double longitude, MapLaunchOptions options)
            => throw new System.PlatformNotSupportedException();

        internal static Task PlatformOpenMapsAsync(Placemark placemark, MapLaunchOptions options)
            => throw new System.PlatformNotSupportedException();
    }
}
