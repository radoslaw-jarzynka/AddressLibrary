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
        /// <summary>
        /// konstruktor
        /// </summary>
        /// <param name="network">numer sieci</param>
        /// <param name="subnet">numer podsieci</param>
        /// <param name="host">numer hosta</param>
        public Address(int network, int subnet, int host) {
            this.network = network;
            this.subnet = subnet;
            this.host = host;
        }
        /// <summary>
        /// zwraca adres w postaci string
        /// </summary>
        /// <returns>adres jako string</returns>
        public override String ToString() {
            return network + "." + subnet + "." + host;
        }

        /// <summary>
        /// Próbuje parsować string na obiekt Address. Użycie tej funkcji jest analogiczne to wszystkich innych TryParsów 
        /// </summary>
        /// <param name="str">input string</param>
        /// <param name="addr">output Address object</param>
        /// <returns>czy sie udało?</returns>
        public static bool TryParse(String str, out Address addr) {
            char[] delimiter = { '.' };
            String[] _strArray = str.Split(delimiter);
            if (_strArray.Length == 3) {
                try {
                    int _net = int.Parse(_strArray[0]);
                    int _sub = int.Parse(_strArray[1]);
                    int _host = int.Parse(_strArray[2]);
                    addr = new Address(_net, _sub, _host);
                    return true;
                } catch {
                    addr = null;
                    return false;
                }
            } else {
                addr = null;
                return false;
            }
        }

        public static Address Parse(String str) {
            char[] delimiter = { '.' };
            String[] _strArray = str.Split(delimiter);
            int _net = int.Parse(_strArray[0]);
            int _sub = int.Parse(_strArray[1]);
            int _host = int.Parse(_strArray[2]);
            Address addr = new Address(_net, _sub, _host);
            return addr;
        }

        public override bool Equals(object addr) {
            Address _addr = addr as Address;
            if ((object)addr == null) {
                return false;
            }
            if (_addr.network == this.network && _addr.subnet == this.subnet && _addr.host == this.host) return true;
            else return false;
        }

        public static bool operator ==(Address a1, Address a2) {
            if (a1.network == a2.network && a1.subnet == a2.subnet && a1.host == a2.host) return true;
            else return false;
        }

        public override int GetHashCode() {
            return base.GetHashCode();
        }

        public static bool operator !=(Address a1, Address a2) {
            return !(a1 == a2);
        }
    }
}
