using Microsoft.AspNetCore.Mvc;
using Flurl.Http;
using Lab11DeckOfCardsApi.Models;

namespace Lab11DeckOfCardsApi.Controllers
{
    public class CardDeckController : Controller
    {
        public IActionResult Index()
        {
            string apiUri = "https://deckofcardsapi.com/api/deck/new/shuffle";
            var apiTask = apiUri.GetJsonAsync<CardDeckApi>();
            apiTask.Wait();
            CardDeckApi cardDeck = apiTask.Result;

            return View(cardDeck);
        }

        public IActionResult CardDetails(CardDeckApi cardDeck, string id)
        {
            string apiUri = $"https://deckofcardsapi.com/api/deck/{id}/draw/?count=5";
            var apiTask = apiUri.GetJsonAsync<CardDeckApi>();
            apiTask.Wait();
            CardDeckApi cardDraw = apiTask.Result;

            return View(cardDraw);
        }
    }
}
