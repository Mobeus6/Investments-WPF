using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFInvestment.Classes
{
    internal class Transaction
    {

        private int ID;
        private DateTime date;
        private string pair;
        private int volume;
        private float price;

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
