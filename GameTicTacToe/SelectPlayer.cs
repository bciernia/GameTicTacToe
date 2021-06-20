using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameTicTacToe.Model;
using GameTicTacToe.Repo;

namespace GameTicTacToe
{
    public partial class SelectPlayer : Form
    {
        //private Game Game;
        private SelectServer SelectServer;
        public static string PlayerOneName;
        public static string PlayerTwoName;
        private PlayerRepository playerRepository = new PlayerRepository();

        public SelectPlayer()
        {
            InitializeComponent();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            tbPlayerOne.Text = tbPlayerOne.Text.Replace(" ", "");


            if (String.IsNullOrEmpty(tbPlayerOne.Text))
            {
                MessageBox.Show("Both players need names", "Missing name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbPlayerOne.Text.Length < 4)
            {
                MessageBox.Show("Nick has to be longer (At least 4 characters)", "Too short name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbPlayerOne.Text.Length > 15)
            {
                MessageBox.Show("Nick has to be shorter (Max 15 characters)", "Too long name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                PlayerOneName = tbPlayerOne.Text;

                Player player1 = new Player();
                player1.Nick = PlayerOneName;
                player1.Score = 0;

                var isPlayerNew = playerRepository.IsPlayerInDb(player1);

                if(!isPlayerNew)
                {
                    MessageBox.Show("Hello new player!");
                    playerRepository.AddPlayer(player1);
                }
                else
                {
                    MessageBox.Show("Welcome back " + player1.Nick + "!");
                }

                tbPlayerOne.Text = "";

                Visible = false;
                SelectServer = new SelectServer();
                SelectServer.ShowDialog();

            }
        }

        private void SelectPlayer_Load(object sender, EventArgs e)
        {

        }
    }
}
