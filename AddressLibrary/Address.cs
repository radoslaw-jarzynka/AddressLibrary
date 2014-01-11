using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressLibrary
{
    public class Address
    {
        public int network { get; private set; }
        public int subnet {get; private set; }
        public int host {get; private set; }

        public Address(int network, int subnet, int host) {
            this.network = network;
            this.subnet = subnet;
            this.host = host;
        }

        public override String ToString() {
            return network + "." + subnet + "." + host;
        }
    }
}
