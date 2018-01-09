using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SoapDemo.Client
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPizza" in both code and config file together.
    [ServiceContract]
    public interface IPizza
    {
        [OperationContract]
        SoapResponse Prepare();

        void Bake();

        void Deliver();

    }
}
