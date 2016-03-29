using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtorLibrary
{
    class Realtor
    {

        string realtorName = "";

        public Realtor()
        {

        }


        public string getName
        {
            set { realtorName = value;}
            get { return realtorName; }
        }

    }
}
