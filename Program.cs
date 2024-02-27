using Card_Exception;



var cards = new List<Card>()
{
    new Card()
    {
        Id = 1,
        Balance = 120000,
        Owner = "Bobur Holmatov",
        Type = CardType.HUMO
    },new Card()
    {
        Id = 2,
        Balance = 120000,
        Owner = "Maur Berdiyev",
        Type = CardType.UZCARD
    },new Card()
    {
        Id = 3,
        Balance = 5000,
        Owner = "Ali Aliyev",
        Type = CardType.VISA
    },new Card()
    {
        Id = 4,
        Balance = 5000,
        Owner = "Vali Valiyev",
        Type = CardType.UNIONPAY
    },
};
Console.Write("If you send money Uscard and Humo Pluease enter...... y : ");
var chosen = Console.ReadLine();
if (chosen == "y")
    SendMoneyBetweenHumoAndUzcard();
else

    SendMoneyBetweenVisaAndUnionPay();

void SendMoneyBetweenHumoAndUzcard()
{
    Console.Write("Enter Sender id : ");
    var sender = int.Parse(Console.ReadLine());
    var isSenderExist = cards.Any(c => c.Id == sender);
    if (isSenderExist)
    {
        Console.Write("Enter Getter  id : ");
        var getter = int.Parse(Console.ReadLine());
        var isGetterExist = cards.Any(c=>c.Id == sender);
        if (isGetterExist)
        {
            Console.Write("Enter amount: ");
            var amount = decimal.Parse(Console.ReadLine());
            var cardSender = cards.FirstOrDefault(c => c.Id == sender);
            var cardGetter = cards.FirstOrDefault(c => c.Id == getter);
            if ( (cardSender.Type == CardType.UZCARD || cardSender.Type == CardType.HUMO) && (cardGetter.Type == CardType.UZCARD || cardGetter.Type == CardType.HUMO))
            {
                if (cardSender.Balance >= amount)
                {
                    Console.WriteLine($"Oldingi balans : {cardSender.Balance}");
                    Console.WriteLine($"Oldingi balans : {cardGetter.Balance}");
                    cardSender.Balance -= amount;
                    cardGetter.Balance += amount;
                    Console.WriteLine($"Hozirgi balans {cardSender.Balance}");
                    Console.WriteLine($"'Hozirgi balans {cardGetter.Balance}");
                }
                else
                {
                    throw new NotEnoughMoney($"It is not enough to sent money Please....{cardSender}");
                }

            }
            else
            {
                throw new CardTypeNotMatch($"The sender:{cardSender.Owner} has not got enough money to send");
            }
        }
    }
}



void SendMoneyBetweenVisaAndUnionPay()
{
    Console.Write("Enter Sender id : ");
    var sender = int.Parse(Console.ReadLine());
    var isSenderExist = cards.Any(c => c.Id == sender);
    if (isSenderExist)
    {
        Console.Write("Enter Getter  id : ");
        var getter = int.Parse(Console.ReadLine());
        var isGetterExist = cards.Any(c => c.Id == sender);
        if (isGetterExist)
        {
            Console.Write("Enter amount: ");
            var amount = decimal.Parse(Console.ReadLine());
            var cardSender = cards.FirstOrDefault(c => c.Id == sender);
            var cardGetter = cards.FirstOrDefault(c => c.Id == getter);
            if ((cardSender.Type == CardType.VISA || cardSender.Type == CardType.UNIONPAY) && (cardGetter.Type == CardType.VISA || cardGetter.Type == CardType.UNIONPAY))
            //if ((cardSender.Type is CardType.UZCARD or CardType.HUMO) && (cardGetter.Type is CardType.UZCARD or CardType.HUMO))
            {
                if (cardSender.Balance >= amount)
                {
                    Console.WriteLine($"Oldingi balans : {cardSender.Balance}");
                    Console.WriteLine($"Oldingi balans : {cardGetter.Balance}");
                    cardSender.Balance -= amount;
                    cardGetter.Balance += amount;
                    Console.WriteLine($"Hozirgi balans {cardSender.Balance}$");
                    Console.WriteLine($"'Hozirgi balans {cardGetter.Balance}$");
                }
                else
                {
                    throw new NotEnoughMoney($"It is not enough to sent money Please....{cardSender}");
                }

            }
            else
            {
                throw new CardTypeNotMatch($"The sender:{cardSender.Owner} has not got enough money to send");
            }
            //ishladi
        }
    }
}