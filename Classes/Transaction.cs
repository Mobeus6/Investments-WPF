using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFInvestment.Classes
{
    internal class Transaction
    {

        public int ID
        {
            get { return ID; }
            set { ID = value; } 
        }

        public DateTime date
        {
            get { return date; }
            set { date = value; }
        }
        public string pair
        {
            get { return pair; }
            set { pair = value; }
        }
        public float volume
        {
            get { return volume; }
            set { volume = value; }
        }
        public float price
        {
            get { return price; }
            set { price = value; }
        }



        public Transaction(int ID, DateTime date, string pair,float volume, float price)
        {
            this.ID = ID;
            this.date = date;
            this.pair = pair;
            this.volume = volume;
            this.price = price;
        }

    }
}
