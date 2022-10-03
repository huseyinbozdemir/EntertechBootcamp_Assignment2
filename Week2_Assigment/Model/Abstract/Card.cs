using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Assigment.Model.Abstract
{
    enum CardType
    {
        Student,
        Old,
        Worker,
        Normal
    }
    internal abstract class Card // Card -> CardWithoutInfo[Card]{Anonim} - CardWithInfo[Card, IUser]{Ogrenci, ....}
    {
        private string cardNumber;
        private decimal balance;
        public string CardNumber
        {
            get { return cardNumber; }
            set
            {
                if (value.Length != 16 || !value.All(char.IsDigit))
                    throw new Exception("Please enter a 16 digit card number.");
                cardNumber = value;
            }
        }
        public virtual CardType CardType { get; }
        public decimal FixedFare { get; }
        public decimal ReducedFare { get; }
        public decimal Balance { get { return balance; } }
        public Card(string cardNumber, CardType cardType, decimal fixedFare, decimal balance)
        {
            CardNumber = cardNumber;
            CardType = cardType;
            FixedFare = fixedFare;
            this.balance = balance;
            ReducedFare = cardType switch
            {
                CardType.Student => fixedFare - (fixedFare * 0.75m),
                CardType.Old => fixedFare - (fixedFare * 0.50m),
                CardType.Worker => fixedFare - (fixedFare * 0.25m),
                CardType.Normal => fixedFare
            };
        }
        public bool Pay()
        {
            bool status = false;
            if (FixedFare <= balance)
            {
                balance -= FixedFare;
                status = true;
            }
            return status;
        }
        public void AddBalance(decimal amount)
        {
            balance += amount;
        }

    }
}
