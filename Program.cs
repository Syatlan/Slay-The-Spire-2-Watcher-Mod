string characterName = "Watcher";

Card strike = new Card("Strike", 1, 6, CardType.Attack);
Card defend = new Card("Defend", 1, 5, CardType.Skill);
Card eruption = new Card("Eruption", 2, 9, CardType.Attack);
Card vigilance = new Card("Vigilance", 2, 8, CardType.Skill);

List<Card> deck = new List<Card>();

for (int i = 0; i < 4; i++)
{
    deck.Add(strike);
    deck.Add(defend);
}

deck.Add(eruption);
deck.Add(vigilance);
deck.Add(eruption);
deck.Add(vigilance);    