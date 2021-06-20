using GameTicTacToe.Model;
using GameTicTacToe.Repo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTicTacToe
{
    public partial class Winner : Form
    {
        private GamesRepository gamesRepository = new GamesRepository();

        public Winner()
        {
            InitializeComponent();
        }

        private void Winner_Load(object sender, EventArgs e)
        {
            if (Game.isFirstPlayerWinner)
            {
                labelWinnerPlayer.Text = "Player X won";
            }
            else
            {
                labelWinnerPlayer.Text = "Player O won";
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
