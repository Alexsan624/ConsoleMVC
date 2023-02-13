using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport.Model
{
    public class Transport
    {
        private int kilometers;
        private string partOfTheDay;
        
        public Transport(int kilmeters, string partOfTheDay)
        {
            this.kilometers = kilometers;
            this.partOfTheDay = partOfTheDay;
        }

        public int Kilometers
        {
            get { return this.kilometers; }
            set { this.kilometers = value; }
        }

        public string PartOfTheDay
        {
            get { return this.partOfTheDay; }
            set { this.partOfTheDay = value; }
        }

        public double CalculatePrice(double price)
        {
            if (kilometers < 20)
            {
                if (partOfTheDay == "day")
                {
                    price = 0.70 + kilometers * 0.79;
                }
                if (partOfTheDay == "night")
                {
                    price = 0.70 + kilometers * 0.90;
                }
            }
            if (kilometers > 20 && kilometers < 100)
            {
                price = kilometers * 0.09;
            }
            if (kilometers > 100)
            {
                price = kilometers * 0.06;
            }
            return price;
        }
    }
}
