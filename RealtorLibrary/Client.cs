using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtorLibrary
{
    class Client
    {
        string clientName = "";


        public Client()
        {

        }


        public string getName
        {
            set { clientName = value; }
            get { return clientName; }
        }


    }
}
