using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTicTacToe.Model
{
    public class Context : DbContext
    {
        public Context() : base("TicTacToeDbContext")
        {

        }

        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Game> Games { get; set; }
    }
}
