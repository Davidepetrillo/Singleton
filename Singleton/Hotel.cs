using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Hotel
    {
        public string name;
        public string località;
        public int numero_civico;

        private static Hotel _instance;

        private Hotel()
        {

        }

        public static Hotel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Hotel();
                }
                return _instance;
            }
        }

    }
}

