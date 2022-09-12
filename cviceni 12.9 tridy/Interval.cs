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
                if (value < dolni)
                {
                    throw new Exception("horni nemuze byt mensi nez dolni");
                }
                horni = value;
            }
        }

        public int Dolni
        {
            get { return dolni; }
            set
            {
                if (value > horni)
                {
                    throw new Exception("dolni nemuze byt vetsi nez horni");
                }
                dolni = value;
            }
        }

        public Interval(int horni, int dolni)
        {
            if(horni < dolni)
            {
                throw new Exception("nejde takto udelat");
            }
            this.horni = horni; 
            this.dolni = dolni;
        }

        public bool UpravMeze(int dolni, int horni)
        {
            if (horni < dolni)
            {
                return false;
            }
            this.dolni = dolni;
            this.horni = horni;
            return true;
        }
        public Interval? Prunik(Interval i1, Interval i2)
        {
            if(i1.dolni < i2.dolni)
            {

            }
        }
    }
    
}
