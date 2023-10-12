using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tima.DAL;

namespace Tima.BLL
{
    public class ServiceAccount
    {
        private readonly string path;
        public ServiceAccount(string path)
        {
            this.path = path;
        }

        public List<Account> GetClientAccounts(int clientId)
        {
            RepositoryAccount repository = 
                new RepositoryAccount(path);

            List<Account> accounts = repository.GetAccount(clientId);

            return accounts;
        }
    }
}
