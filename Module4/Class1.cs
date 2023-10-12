using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4
{
   public class User
    {
        public const double pi = 3.14;
        private int _Age;
        
        public User() { 
        CreateDate = DateTime.Now;
        }
        public DateTime CreateDate { get; set; }
                public int Age
        {
            get
            {
                return _Age;
            }
                set
            {
                if (value < 0)
                    Age = 0;

            }

        }
        public string IIN { get; private set; }
    }
}
