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
        Balance = 20000,
        Owner = "Maur Berdiyev",
        Type = CardType.UZCARD
    },new Card()
    {
        Id = 1,
        Balance = 300,
        Owner = "Ali Aliyev",
        Type = CardType.VISA
    },new Card()
    {
        Id = 1,
        Balance = 50,
        Owner = "Vali Valiyev",
        Type = CardType.UNIONPAY
    },
};
SendMoney();

void SendMoney()
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
            var amount = int.Parse(Console.ReadLine());
            var cardSender = cards.FirstOrDefault(c => c.Id == sender);
            var cardGetter = cards.FirstOrDefault(c => c.Id == getter);
            if ( (cardSender.Type == CardType.UZCARD || cardSender.Type == CardType.HUMO) && (cardGetter.Type == CardType.UZCARD || cardGetter.Type == CardType.HUMO))
            {
                if (cardSender.Balance >= amount)
                {
                    cardSender.Balance -= amount;
                    cardGetter.Balance += amount;
                }
            }
            

            else
            {
                throw new NotEnoughMoney($"The sender:{cardSender.Owner} has not got enough money to send");
            }

        }
    }
}