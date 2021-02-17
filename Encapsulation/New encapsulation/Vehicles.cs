using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_encapsulation
{
    class Vehicles
    {
        //underscore variables are private variables
        string _regno;
        int _wheels;
        int _liters;

        //properties
        public string Regno
        {
            get { return _regno; }
            set { _regno = value; }
        }
        public int Wheels
        {
            get { return _wheels; }
            set { _wheels = value; }
        }
        public int Liters
        {
            get { return _liters; }
            set { _liters = value; }
        }


        //methods
        private int fillair(int price)
        {
            return _wheels * price;
        }
        private int  fillfuel(int price)
        {
            return _liters*price;
        }
        public string getfinalamount(int air, int fuel)
        {
            int y=fillair(air)+fillfuel(fuel);
                return " The total amount to be paid by "+_regno+" is "+y;

        }

    }
}
