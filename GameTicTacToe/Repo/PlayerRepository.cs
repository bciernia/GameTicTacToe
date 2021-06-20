using GameTicTacToe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTicTacToe.Repo
{
    public class PlayerRepository
    {
        private Context _context;

        public PlayerRepository()
        {
            Context context = new Context();

            _context = context;
        }

        public int AddPlayer(Player player)
        {
            _context.Players.Add(new Player { Nick = player.Nick, Score = 0 });
            _context.SaveChanges();

            return player.Id;
        }

        public bool IsPlayerInDb(Player player)
        {
            var newPlayer = _context.Players.SingleOrDefault(p => p.Nick == player.Nick);
            if(newPlayer == null)
                return false;
            else
                return true;
        }

        public void UpdateScore(Player player)
        {
            var playerScoreToUpdate = _context.Players.Single(p => p.Id == player.Id);
            playerScoreToUpdate.Score += 1;
            _context.SaveChanges();
        }

        public Player GetPlayerByNick(string nick)
        {
            var playerToReturn = _context.Players.Single(p => p.Nick == nick);

            return playerToReturn;
        }
    }
}
