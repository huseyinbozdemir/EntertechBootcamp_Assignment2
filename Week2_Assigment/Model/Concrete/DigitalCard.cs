using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2_Assigment.Model.Abstract;

namespace Week2_Assigment.Model.Concrete
{
    internal class DigitalCard : CardWithInfo
    {
        public DigitalCard(string cardNumber, CardType cardType, decimal fixedFare, decimal balance, User user) : base(cardNumber, cardType, fixedFare, balance, user)
        {

        }
    }
}
