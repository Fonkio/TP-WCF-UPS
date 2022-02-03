using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DataContract
{
    [DataContract()]
    public class CityTemperature
    {
        [DataMember()]
        public String City { get; set; }
        [DataMember()]
        public Int32 Temperature { get; set; }

        public override string ToString()
        {
            return "La température à " + City + " est de " + Temperature + "°C";
        }
    }
}
