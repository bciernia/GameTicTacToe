using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTicTacToe.Model
{
    public class Game
    {
        public int Id { get; set; }

        public virtual Player Winner { get; set; }
        public virtual Player FirstPlayer { get; set; }
        public virtual Player SecondPlayer { get; set; }
    }
}
