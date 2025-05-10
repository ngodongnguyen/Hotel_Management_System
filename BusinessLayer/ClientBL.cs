using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace BusinessLayer
{
    public class ClientBL
    {
        private ClientDL clientDL;
        public ClientBL()
        {
            clientDL = new ClientDL();
        }
        public bool AddClient(Client client)
        {
            return clientDL.AddClient(client);
        }
        public DataTable DisplayClients()
        {
            return clientDL.DisplayClients();
        }
        public DataTable SearchClients(string keyword)
        {
            return clientDL.SearchClients(keyword);
        }
        public bool UpdateClient(Client client)
        {
            return clientDL.UpdateClient(client);

        }
        public bool DeleteClient(Client client)
        {
            return clientDL.DeleteClient(client);
        }
        public bool ClientExist(int CID)
        {
            return clientDL.ClientExist(CID);
        }
    }
}
