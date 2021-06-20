using GameTicTacToe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTicTacToe.Repo
{
    public class GamesRepository
    {
        private Context _context;

        public GamesRepository()
        {
            Context context = new Context();

            _context = context;
        }

        public void ArchiveGame(Player winner, Player firstPlayer, Player secondPlayer)
        {
            _context.Games.Add(new Model.Game { FirstPlayer = firstPlayer, SecondPlayer = secondPlayer, Winner = winner });
            _context.SaveChanges();
        }

        public IQueryable<Model.Game> GetPlayerGamesByHisId(Player player)
        {
            var gameList = _context.Games.Where(g => g.FirstPlayer.Id == player.Id || g.SecondPlayer.Id == player.Id);

            return gameList;
        }
    }
}
