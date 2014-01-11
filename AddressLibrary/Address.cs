using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressLibrary
{
    public class Address
    {
        public int subnet {get; private set; }
        public int host {get; private set; }

        public Address(int subnet, int host) {
            this.subnet = subnet;
            this.host = host;
        }

        public String toString() {
            return subnet + "." + host;
        }
    }
}
