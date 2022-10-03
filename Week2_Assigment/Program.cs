

using Week2_Assigment.Model.Abstract;
using Week2_Assigment.Model.Concrete;

//DigitalCard digitalCard = new DigitalCard("1111111111111111", CardType.Worker, 5, 50, "123456789", "Hüseyin", "Bozdemir");
#region Variables
CardType cardType = CardType.Normal;
Type type = null;
User user = null;
#endregion
Console.WriteLine("TechCity Ulaşım Kartı Arayüzü");
DisplayBaseCardsUI();
type = GetBaseCardType();
if (type != typeof(AnonimCard))
{
    DisplayCardTypeUI();
    cardType = GetCardType();
    user = DisplayUserInformationUI();
}
DisplayCardSettingsUI(type, user, cardType);

Console.ReadKey();


CardType GetCardType()
{
    string value;
    int number;
    do
    {
        Console.Write("Lütfen oluşturmak istediğiniz kart tipini seçin: ");
        value = Console.ReadLine();
    } while (!int.TryParse(value, out number) || (number > 4 || number < 1));
    CardType cardType = number switch
    {
        0 => CardType.Student,
        1 => CardType.Old,
        2 => CardType.Worker,
        3 => CardType.Normal,
    };
    return cardType;
}
Type GetBaseCardType()
{
    string value;
    int number;
    do
    {
        Console.Write("Lütfen oluşturmak istediğiniz kart tipini seçin: ");
        value = Console.ReadLine();
    } while (!int.TryParse(value, out number) || (number > 3 || number < 1));
    Type type = number switch
    {
        1 => typeof(PhysicalCard),
        2 => typeof(DigitalCard),
        3 => typeof(AnonimCard),
    };

    return type;
}

Decimal GetDecimalValue(string message)
{
    string value;
    decimal number;
    do
    {
        Console.Write(message);
        value = Console.ReadLine();
    } while (!decimal.TryParse(value, out number));

    return number;
}
void DisplayCardTypeUI()
{
    Console.WriteLine("===============================================================");
    Console.WriteLine("1- Öğrenci");
    Console.WriteLine("2- Yaşlı");
    Console.WriteLine("3- İşçi");
    Console.WriteLine("4- Normal");
}

void DisplayBaseCardsUI()
{
    Console.WriteLine("===============================================================");
    Console.WriteLine("1- Fiziksel");
    Console.WriteLine("2- Dijital");
    Console.WriteLine("3- Anonim");
}

User DisplayUserInformationUI()
{
    string[] userInfo = new string[3];
    Console.WriteLine("===============================================================");
    Console.Write("{0,-16}: ", "Kimlik Numaranız");
    userInfo[0] = Console.ReadLine();
    Console.Write("{0,-16}: ", "Adınız");
    userInfo[1] = Console.ReadLine();
    Console.Write("{0,-16}: ", "Soyadınız");
    userInfo[2] = Console.ReadLine();
    User user = new User(userInfo[0], userInfo[1], userInfo[2]);
    return user;
}

Card DisplayCardSettingsUI(Type t, User user, CardType cardType)
{
    Card card=null;
    string cardNumber = "";
    decimal[] balanceSettings = new decimal[2];
    Console.WriteLine("===============================================================");
    balanceSettings[0] = GetDecimalValue(string.Format("{0,-11}: ", "Sabit Ücret"));
    balanceSettings[1] = GetDecimalValue(string.Format("{0,-11}: ", "Bakiye"));
    while (cardNumber.Length != 16 || !cardNumber.All(char.IsDigit))
    {
        Console.Write("{0,-11}: ", "Kart Numarası");
        cardNumber = Console.ReadLine();
    }
    if (type == typeof(AnonimCard))
        card = new AnonimCard(cardNumber, balanceSettings[0], balanceSettings[1]);
    else if (type == typeof(DigitalCard))
        card = new DigitalCard(cardNumber, cardType, balanceSettings[0], balanceSettings[1], user);
    else if(type == typeof(PhysicalCard))
        card = new PhysicalCard(cardNumber, cardType, balanceSettings[0], balanceSettings[1], user);

    return card;
}
