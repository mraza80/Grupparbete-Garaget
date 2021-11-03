using System;
using System.Collections.Generic;
using System.Text;

namespace Grupparbete_Garaget
{
    class Truck : Vehicle
    {
        public int TruckMaxLoad { get; set; }
        public bool TruckTrailer { get; set; }
        public string TruckCompany { get; set; }
    }
}
