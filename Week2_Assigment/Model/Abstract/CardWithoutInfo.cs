using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Assigment.Model.Abstract
{
    internal class CardWithoutInfo : Card
    {
        public CardWithoutInfo(string cardNumber, decimal fixedFare, decimal balance) : base(cardNumber, CardType.Normal, fixedFare, balance)
        {
        }
    }
}
