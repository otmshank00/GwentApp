using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GwentApp.Models;

namespace GwentApp.Controllers
{
    public class SetupController : Controller
    {
        // GET: Setup
        public ActionResult Index()
        {
            Player player = new Player();
            return View(player);
        }
        [HttpPost]
        public ActionResult ProcessIndexFormView(Player player)
        {
            return View(player);
        }
        public ActionResult CreateDeck()
        {
            List<Card> deck = new List<Card>()
            {
                new Card() {name="Archer", power=1 },
                new Card() {name="Catapult", power=10 },
                new Card() {name="Spy", power=9 },
                new Card() {name="Geralt", power=15 }
            };
            return View(deck);
        }
    }
}