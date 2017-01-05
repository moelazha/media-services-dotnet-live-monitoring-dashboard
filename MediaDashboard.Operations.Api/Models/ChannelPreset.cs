﻿using System;

namespace MediaDashboard.Web.Api.Models
{
    [Serializable]
    public class ChannelPreset
    {
        
        public string Codec { get; set; }
        public int BitRate { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Profile { get; set; }
        public string OutputStream { get; set; }


    }
}