using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie2
{
    class FinalCollection
    {
        public static void Main(String[] args)
        {
            ElementParDefaut<string> collection = new ElementParDefaut<string>();
            collection.AjouterElement("client1");
            collection.AjouterElement("client2");
            collection.ChoisirElementParDefaut("client2");
            collection.SupprimerElement("client2");
        }
    }
}
