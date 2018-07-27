using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interest_calculator
{
    class MyCalculator
    {
        public decimal TotalInterest(Person person)
        {
            List<decimal> temp = InterestPerWallet(person);
            decimal result = 0;
            foreach(decimal d in temp)
            {
                result = result + d;
            }
            return result;
        }

        public List<decimal> InterestPerWallet(Person person)
        {
            List<decimal> result = new List<decimal>();
            foreach(Wallet w in person.Wallets)
            {
                result.Add(InterestPerCards(w.Cards));
            }
            return result;
        }

        public decimal InterestPerCards(Card[] cards) 
        {
            decimal total = 0;
            foreach(Card c in cards)
            {
                total = total + c.Balance * c.Rate;
            }
            return total;
        }

        public List<decimal> InterestPerCard(Card[] cards)
        {
            List<decimal> result = new List<decimal>();
            foreach(Card c in cards)
            {
                var interest = c.Balance * c.Rate;
                result.Add(interest);
            }
            return result;
        }
    }
}
