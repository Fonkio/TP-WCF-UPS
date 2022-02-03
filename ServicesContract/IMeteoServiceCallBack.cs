using DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServicesContract
{
    [ServiceContract]
    public interface IMeteoServiceCallBack
    {
        [OperationContract()]
        void WeatherReceived(List<CityTemperature> cities);
    }
}
