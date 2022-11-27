using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClientMaster.Model
{
    public class ClientData
    {
        public static List<ClientModel> Data = new List<ClientModel>
        {
            new ClientModel { Id = 501, Code = "CCN501" , Name = "CCN 501 Client", Exchange = "NSE" },
            new ClientModel { Id = 502, Code = "CCN502" , Name = "CCN 502 Client", Exchange = "BSE" },
            new ClientModel { Id = 503, Code = "CCN503" , Name = "CCN 503 Client", Exchange = "MCX" },
            new ClientModel { Id = 504, Code = "CCN504" , Name = "CCN 504 Client", Exchange = "NCDEX" },
        };
    }
}