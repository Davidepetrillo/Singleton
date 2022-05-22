using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    //classe Singleton di tipo sealed non ereditabile
    public sealed class Singleton
    {
        //membro privato che rappresenta l'instanza della classe
        private static Singleton _instance;

        //costruttore privato senza param non accessibile dall'esterno della classe
        private Singleton() { }

        //Entry-Point: proprietà esterna che ritorna l'istanza della classe
        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }
    }

}
