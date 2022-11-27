using ClientMaster.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace ClientMaster.Service
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ClientService
    {
        [OperationContract, WebGet(ResponseFormat = WebMessageFormat.Json)]
        public List<ClientModel> GetAllClients() // Get All Record
        {
            return ClientData.Data;
        }

       
        [OperationContract, WebInvoke(ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "AddClient", Method = "POST")]
        public ClientModel AddClient(ClientModel obj) // Add Record
        {
            obj.Id = ClientData.Data.Max(x => x.Id) + 1;
            ClientData.Data.Add(obj);
            return obj;
        }

    }
}
