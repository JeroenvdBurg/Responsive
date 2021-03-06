﻿// Copyright (c) 2018 Sarin Na Wangkanai, All Rights Reserved.
// The Apache v2. See License.txt in the project root for license information.

using Wangkanai.Detection;

namespace Wangkanai.Responsive
{
    public class ResponsiveOptions
    {
        public DeviceType MobileDefault { get; set; } = DeviceType.Mobile;
        public DeviceType TabletDefault { get; set; } = DeviceType.Tablet;
        public DeviceType DesktopDefault { get; set; } = DeviceType.Desktop;

        public ResponsiveOptions() { }
        public ResponsiveOptions(DeviceType desktop, DeviceType tablet, DeviceType mobile)
        {
            DesktopDefault = desktop;
            TabletDefault = tablet;
            MobileDefault = mobile;
        }

    }
}