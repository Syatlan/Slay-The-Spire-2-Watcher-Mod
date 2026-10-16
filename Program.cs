//string characterName = "Watcher";

//Name,Cost,Damage,Block,Type
Card strike = new Card("Strike", 1, 6, 0, CardType.Attack);
Card defend = new Card("Defend", 1, 0, 5, CardType.Skill);
Card eruption = new Card("Eruption", 2, 9, 0, CardType.Attack);
Card vigilance = new Card("Vigilance", 2, 0, 8, CardType.Skill);

List<Card> deck = new List<Card>();

for (int i = 0; i < 4; i++)
{
    deck.Add(strike);
    deck.Add(defend);
}

deck.Add(eruption);
deck.Add(vigilance);    