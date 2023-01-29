namespace Lab11DeckOfCardsApi.Models
{
    public class CardDeckApi
    {
            public bool success { get; set; }
            public string deck_id { get; set; }
            public CardDrawApi[] cards { get; set; }
            public int remaining { get; set; }

            public bool shuffled { get; set; } = true;

    }
}
