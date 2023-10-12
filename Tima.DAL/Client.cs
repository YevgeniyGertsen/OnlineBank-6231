using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tima.DAL
{
    public class Client
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string Iin { get; set; }
        public string Fname { get; set; }
        public string Sname { get; set; }
        public string Mname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        //fnma g.h.
        public string Getshortname
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(Mname))
                {
                    return string.Format("{0} {1}. {2}.",
                                         Fname, Sname[0], Mname[0]);
                }
                else
                    return string.Format("{0} {1}.",
                                      Fname, Sname[0]);

            }
        }
        public string Phone { get; set; }
        /// <summary>
        /// Data roshdenia
        /// </summary>
        public DateTime Birthday { get; set; }
        public int GetCreateDate
        {
            get
            {
                return (DateTime.Now.Year - CreateDate.Year);
            }
        }
        public string Email { get; set; }

        public Adress Adress { get; set; }
    }
}
