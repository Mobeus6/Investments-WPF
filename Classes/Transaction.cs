using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFInvestment.Classes
{
    internal class Transaction
    {

        private int ID
        {
            get { return ID; }
            set { ID = value; } 
        }

        private DateTime date
        {
            get { return date; }
            set { date = value; }
        }
        private string pair
        {
            get { return pair; }
            set { pair = value; }
        }
        private int volume
        {
            get { return volume; }
            set { volume = value; }
        }
        private float price
        {
            get { return price; }
            set { price = value; }
        }



        public Transaction(int ID, DateTime date, string pair, int volume, float price)
        {
            this.ID = ID;
            this.date = date;
            this.pair = pair;
            this.volume = volume;
            this.price = price;
        }

    }
}
