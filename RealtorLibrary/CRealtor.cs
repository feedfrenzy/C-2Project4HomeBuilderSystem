using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtorLibrary
{
    public class CRealtor
    {

        string realtorName = "";

        public CRealtor()
        {

        }


        public string getName
        {
            set { realtorName = value;}
            get { return realtorName; }
        }

    }
}
