using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public sealed class Singleton
    {
        private readonly static Singleton _intance = new Singleton();

        private Singleton()
        {

        }
        /*
        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _intance;
            }
        } */
    }
}
