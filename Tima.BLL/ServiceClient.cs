using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tima.DAL;

namespace Tima.BLL
{
    public class ServiceClient
    {
        private readonly string path;
        public ServiceClient(string path)
        {
            this.path = path;
        }

        public bool Registration(Client client)
        {
            RepositoryClient service = new RepositoryClient(path);
            bool result = service.CreateClient(client);

            return result;
        }

        public Client Auth(string login, string password)
        {
            if(login=="" || password =="")
                return null;

            RepositoryClient service = new RepositoryClient(path);
            Client client = service.GetClient(login, password);

            return client;
        }
    }
}
