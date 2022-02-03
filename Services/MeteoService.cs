using DataContract;
using ServicesContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    [ServiceBehavior(InstanceContextMode= InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class MeteoService : IMeteoService
    {
        public void AskForTemperatures()
        {
            System.Threading.Thread.Sleep(5000);
            var callBack = OperationContext.Current.GetCallbackChannel<IMeteoServiceCallBack>();
            callBack.WeatherReceived(this.GetCityTemperatureList());
        }

        public List<CityTemperature> GetCityTemperatureList()
        {
            var listReturn = new List<CityTemperature>() {
                new CityTemperature() { City="Toulouse", Temperature=10},
                new CityTemperature() { City="Albi", Temperature=52}
            };
            return listReturn;
        }

        public int GetTemperature(string city)
        {
            if (city == "Toulouse")
            {
                return 10;
            } else
            {
                return 4;
            }
        }
    }
}
