using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtorLibrary
{
    public class CClient
    {
        string clientName = "";


        public CClient()
        {

        }


        public string getName
        {
            set { clientName = value; }
            get { return clientName; }
        }


    }
}
