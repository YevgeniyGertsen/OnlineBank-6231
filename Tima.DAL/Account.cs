using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tima.DAL
{
    public class Account
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }

        public string IBAN { get; set; }//KZ35146514
        public int ClientId { get; set; }
        public double Balance { get; set; }
        public string BankName { get; set; }
        public int Currency { get; set; }//1-kzt, 2-usd
    }
}
