using DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServicesContract
{
    [ServiceContract(CallbackContract = typeof(IMeteoServiceCallBack))]
    public interface IMeteoService
    {
        [OperationContract()]
        Int32 GetTemperature(String city);

        [OperationContract()]
        List<CityTemperature> GetCityTemperatureList();


        [OperationContract(IsOneWay = true)]
        void AskForTemperatures();

    }
}
