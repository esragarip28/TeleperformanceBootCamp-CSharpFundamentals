
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_MemberHiding
{
    internal class MobilePhone:Phone
    {
        //member hiding
        public new  string Brand { get; set; }
    }
}
