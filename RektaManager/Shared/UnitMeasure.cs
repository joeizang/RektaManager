using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RektaManager.Shared
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum UnitMeasure
    {
        Select = 0,
        Kilograms = 5,
        Crates = 10,
        Packs = 15,
        Pieces = 20,
        Plates = 25,
        Serving = 30,
        Lot = 35,
        Other = 40
    }
}
