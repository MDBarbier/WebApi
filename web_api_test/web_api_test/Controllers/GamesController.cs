using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace web_api_test.Controllers
{
    public class GamesController : ApiController
    {
        Models.Games[] gamesList = new Models.Games[] {
            new Models.Games { ID = 1, Name = "GalCiv3", GameGenre = Models.Genre.FourX, Rating = 5},
            new Models.Games { ID = 2, Name = "FarCry3", GameGenre = Models.Genre.FPS, Rating = 8},
            new Models.Games { ID = 3, Name = "Atilla Total War", GameGenre = Models.Genre.GrandStrategy, Rating = 9},
        };
        
        public IEnumerable<Models.Games> GetAllGames()
        {
            return gamesList;
        }

        public IHttpActionResult GetGame(int id)
        {
            var game = gamesList.FirstOrDefault(g => g.ID == id);

            if (game == null)
            {
                return NotFound();
            }

            return Ok(game);
        }
    }
}
