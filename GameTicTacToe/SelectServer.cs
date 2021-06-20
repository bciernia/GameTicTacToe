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
using System.Net.Sockets;

namespace GameTicTacToe
{
    public partial class SelectServer : Form
    {
        private Player player = new Player();
        private PlayerRepository playerRepository = new PlayerRepository();
        private GamesRepository gamesRepository = new GamesRepository();
        public SelectServer()
        {
            InitializeComponent();
        }

        private void SelectServer_Load(object sender, EventArgs e)
        {
            player = playerRepository.GetPlayerByNick(SelectPlayer.PlayerOneName);
            labelPlayerNick.Text = player.Nick;
            labelPlayerScore.Text = player.Score.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.DataSource = gamesRepository.GetPlayerGamesByHisId(player);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game GameForm = new Game(false, tbAddress.Text);
            Visible = false;
            if(!GameForm.IsDisposed)
            {
                GameForm.ShowDialog();
            }
            Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Game GameForm = new Game(true);
            Visible = false;
            if(!GameForm.IsDisposed)
            {
                GameForm.ShowDialog();
            }
            Visible = true;
        }
    }
}
