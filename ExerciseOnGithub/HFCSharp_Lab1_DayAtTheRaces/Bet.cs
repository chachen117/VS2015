using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HFCSharp_Lab1_DayAtTheRaces
{
    public class Bet
    {
        public Bet(int Amount, int Dog, Guy Bettor)
        {
            this.Amount = Amount;
            this.Dog = Dog;
            this.Bettor = Bettor;
        }

        public int Amount
        {
            get;
            set;
        }

        public int Dog
        {
            get;
            set;
        }

        public Guy Bettor
        {   get;
            set;          
        }
        
        public string GetDescription()
        {
            string description = "";

            if (this.Amount == 0)
            {
                description = this.Bettor.Name + " hasn't placed a bet";                
            }
            else
            {
                description = this.Bettor.Name + " bets " + this.Amount + " on dog #" + this.Dog;
            }

            return description;
        }
        
        public int PayOut(int Winner)
        {
            int payment = 0;

            if (this.Dog == Winner)
            { payment = Amount; }
            else
            { payment = - Amount; }

            return payment;
        }   
    }
}