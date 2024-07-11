﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBilet.Case.Study.API.Client.Models
{
    public class GeoLocation
    {
        [JsonProperty(PropertyName="latitude")]
        public double Latitude { get; set; }

        [JsonProperty(PropertyName="longitude")]
        public double Longitude { get; set; }

        [JsonProperty(PropertyName="zoom")]
        public int Zoom { get; set; }
    }
}