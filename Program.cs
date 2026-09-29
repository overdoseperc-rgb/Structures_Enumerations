using KT13_Variant1_PlayingCard;

Card[] cards =
{
    new Card(Suit.Hearts, Rank.King),
    new Card(Suit.Spades, Rank.Ace),
    new Card(Suit.Diamonds, Rank.Ten),
    new Card(Suit.Clubs, Rank.Queen),
    new Card(Suit.Hearts, Rank.Seven)
};

Console.WriteLine("Коллекция из 5 карт:");
for (int i = 0; i < cards.Length; i++)
{
    Console.WriteLine($"{i + 1}. {cards[i]}");
}

Console.WriteLine();
Console.WriteLine("Демонстрация value-семантики структуры:");
Console.WriteLine($"cards[0] до изменения копии: {cards[0]}");

Card copy = cards[0]; // чтение элемента коллекции создаёт копию структуры
copy.Rank = Rank.Ace;

Console.WriteLine($"Копия после изменения Rank: {copy}");
Console.WriteLine($"cards[0] после изменения копии: {cards[0]}");

Console.WriteLine();
Console.WriteLine("Enum.TryParse:");

string correctInput = "King";
if (Enum.TryParse<Rank>(correctInput, out Rank correctRank))
{
    Console.WriteLine($"Строка \"{correctInput}\": true, результат = {correctRank}");
}
else
{
    Console.WriteLine($"Строка \"{correctInput}\": false");
}

string incorrectInput = "Joker";
if (Enum.TryParse<Rank>(incorrectInput, out Rank incorrectRank))
{
    Console.WriteLine($"Строка \"{incorrectInput}\": true, результат = {incorrectRank}");
}
else
{
    Console.WriteLine($"Строка \"{incorrectInput}\": false, значение не распознано");
}
