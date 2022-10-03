using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2_Assigment.Model.Concrete;

namespace Week2_Assigment.Model.Abstract
{
    internal abstract class CardWithInfo : Card
    {
        public User User { get;  }
        protected CardWithInfo(string cardNumber, CardType cardType, decimal fixedFare, decimal balance, User user) : base(cardNumber, cardType, fixedFare, balance)
        {
            User = user;
        }


    }
}
