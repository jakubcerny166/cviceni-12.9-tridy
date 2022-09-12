using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceni_12._9_tridy
{
    internal class Interval
    {
        private int horni;
        private int dolni;

        public int Horni
        {
            get { return horni; }
            set
            {
                if(value < dolni)
                {
                    throw new Exception("horni nemuze byt mensi nez dolni");
                }
                horni = value; 
            }
        }
        public bool UpravMeze(int dolni, int horni)
        {
            if(horni < dolni)
            {
                return false;
            }
            this.dolni = dolni;
            this.horni = horni;
            return true;
        }
    }
}
