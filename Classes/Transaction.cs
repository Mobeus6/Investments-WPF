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
        { get; set; }

        public DateTime date 
        { get; set; }  
        public string pair
        { get; set; }
        public float volume
        { get; set; }
        public float price
        { get; set; }



        public Transaction(int ID, DateTime date, string pair,float volume, float price)
        {
            this.ID = ID;
            this.date = date;
            this.pair = pair;
            this.volume = volume;
            this.price = price;
        }
        public Transaction() { }

    }
}
