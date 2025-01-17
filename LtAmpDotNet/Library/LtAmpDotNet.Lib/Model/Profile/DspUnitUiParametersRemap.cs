﻿using Newtonsoft.Json;

namespace LtAmpDotNet.Lib.Model.Profile
{
    public class DspUnitUiParametersRemap
    {
        [JsonProperty("min")]
        public float? Min { get; set; }

        [JsonProperty("max")]
        public float? Max { get; set; }

        [JsonProperty("taper")]
        public string? Taper { get; set; }

        [JsonProperty("format")]
        public string? Format { get; set; }

        [JsonProperty("listItems")]
        public IEnumerable<string>? ListItems { get; set; }
    }
}