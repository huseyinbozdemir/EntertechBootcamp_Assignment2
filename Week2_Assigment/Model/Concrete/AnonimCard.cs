using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2_Assigment.Model.Abstract;

namespace Week2_Assigment.Model.Concrete
{
    internal class AnonimCard : CardWithoutInfo
    {
        public override CardType CardType { get { return CardType.Normal; } }

        public AnonimCard(string cardNumber, decimal fixedFare, decimal balance) : base(cardNumber, fixedFare, balance)
        {
        }

    }
}
