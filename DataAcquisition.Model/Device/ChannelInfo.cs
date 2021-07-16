﻿namespace DataAcquisition.Model.Device
{
    public class ChannelInfo
    {
        public int ChannelId { get; set; }
        public string ChannelName { get; set; }
        public string ChannelAddress { get; set; }
        public string ChannelUnit { get; set; }
        public double ChannelData { get; set; }
    }
}