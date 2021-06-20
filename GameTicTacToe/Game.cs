using GameTicTacToe.Model;
using GameTicTacToe.Repo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTicTacToe
{
    public partial class Game : Form
    {
        private Winner WinnerForm;
        private int scorePlayerOne = 0;
        private int scorePlayerTwo = 0;
        private bool move = false;
        private int turnCount = 0;
        private PlayerRepository playerRepository = new PlayerRepository();

        private string charPlayer = "X";
        private string charOpponent = "O";

        private Socket socket;
        private BackgroundWorker messageReceiver = new BackgroundWorker();
        private TcpListener server = null;
        private TcpClient client;

        public static bool isFirstPlayerWinner = false;
        public static bool isSecondPlayerWinner = false;

        public static bool winX = false;
        public static bool winO = false;

        public Game(bool isHost, string serverAddress = null)
        {
            InitializeComponent();
            messageReceiver.DoWork += MessageReceiver_DoWork;

            if(isHost)
            {
                charPlayer = "X";
                charOpponent = "O";
                labelActivePlayer.Text = "Your turn";
                server = new TcpListener(System.Net.IPAddress.Any, 2222);
                server.Start();
                socket = server.AcceptSocket();
            }
            else
            {
                charPlayer = "O";
                charOpponent = "X";
                labelActivePlayer.Text = "Opponent's turn";

                try
                {
                    client = new TcpClient(serverAddress, 2222);
                    socket = client.Client;
                    messageReceiver.RunWorkerAsync();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Close();
                }
            }
        }

        private void MessageReceiver_DoWork(object sender, DoWorkEventArgs e)
        {
            if(End_Game())
            {
                DisableBoard();
                Visible = false;
            }

            DisableBoard();
            labelActivePlayer.Text = "Opponent's turn";
            GetMoveFromOpponent();
            labelActivePlayer.Text = "Your turn";

            if(!End_Game())
            {
                EnableBoard();
            }
        }

        private void EnableBoard()
        {
            if (btnUpLeft.Text == "")
                btnUpLeft.Enabled = true;
            if (btnUpMid.Text == "")
                btnUpMid.Enabled = true;
            if (btnUpRight.Text == "")
                btnUpRight.Enabled = true;
            if (btnMidLeft.Text == "")
                btnMidLeft.Enabled = true;
            if (btnMidMid.Text == "")
                btnMidMid.Enabled = true;
            if (btnMidRight.Text == "")
                btnMidRight.Enabled = true;
            if (btnDownLeft.Text == "")
                btnDownLeft.Enabled = true;
            if (btnDownMid.Text == "")
                btnDownMid.Enabled = true;
            if (btnDownRight.Text == "")
                btnDownRight.Enabled = true;
        }

        private void Player_One_Wins()
        {
            if (isSecondPlayerWinner || isSecondPlayerWinner)
                return;
            else
            {
                isFirstPlayerWinner = true;
                WinnerForm = new Winner();
                WinnerForm.ShowDialog();
            }
        }

        private void Player_Two_Wins()
        {
            if (isFirstPlayerWinner || isSecondPlayerWinner)
                return;
            else
            {
                isSecondPlayerWinner = true;
                WinnerForm = new Winner();
                WinnerForm.ShowDialog();
            }
        }

        private void End_Round()
        {
            if(scorePlayerOne == 1 || scorePlayerTwo == 1)
            {
                End_Game();
                DisableBoard();
                return;
            }

            if (btnUpLeft.Text == "X" && btnUpMid.Text == "X" && btnUpRight.Text == "X")
            {
                btnUpLeft.BackColor = Color.Gold;
                btnUpMid.BackColor = Color.Gold;
                btnUpRight.BackColor = Color.Gold;

                winX = true;
                scorePlayerOne++;
                End_Game();
                DisableBoard();
            }

            if (btnMidLeft.Text == "X" && btnMidMid.Text == "X" && btnMidRight.Text == "X")
            {
                btnMidLeft.BackColor = Color.Gold;
                btnMidMid.BackColor = Color.Gold;
                btnMidRight.BackColor = Color.Gold;

                winX = true;
                scorePlayerOne++;
                End_Game();
                DisableBoard();
            }

            if (btnDownLeft.Text == "X" && btnDownMid.Text == "X" && btnDownRight.Text == "X")
            {
                btnDownLeft.BackColor = Color.Gold;
                btnDownMid.BackColor = Color.Gold;
                btnDownRight.BackColor = Color.Gold;

                winX = true;
                scorePlayerOne++;
                End_Game();
                DisableBoard();
            }

            if (btnUpLeft.Text == "X" && btnMidLeft.Text == "X" && btnDownLeft.Text == "X")
            {
                btnUpLeft.BackColor = Color.Gold;
                btnMidLeft.BackColor = Color.Gold;
                btnDownLeft.BackColor = Color.Gold;

                winX = true;
                scorePlayerOne++;
                End_Game();
                DisableBoard();
            }

            if (btnUpMid.Text == "X" && btnMidMid.Text == "X" && btnDownMid.Text == "X")
            {
                btnUpMid.BackColor = Color.Gold;
                btnMidMid.BackColor = Color.Gold;
                btnDownMid.BackColor = Color.Gold;

                winX = true;
                scorePlayerOne++;
                End_Game();
                DisableBoard();
            }

            if (btnUpRight.Text == "X" && btnMidRight.Text == "X" && btnDownRight.Text == "X")
            {
                btnUpRight.BackColor = Color.Gold;
                btnMidRight.BackColor = Color.Gold;
                btnDownRight.BackColor = Color.Gold;

                winX = true;
                scorePlayerOne++;
                End_Game();
                DisableBoard();
            }

            if (btnUpLeft.Text == "X" && btnMidMid.Text == "X" && btnDownRight.Text == "X")
            {
                btnUpLeft.BackColor = Color.Gold;
                btnMidMid.BackColor = Color.Gold;
                btnDownRight.BackColor = Color.Gold;

                winX = true;
                scorePlayerOne++;
                End_Game();
                DisableBoard();
            }

            if (btnUpRight.Text == "X" && btnMidMid.Text == "X" && btnDownLeft.Text == "X")
            {
                btnUpRight.BackColor = Color.Gold;
                btnMidMid.BackColor = Color.Gold;
                btnDownLeft.BackColor = Color.Gold;

                winX = true;
                scorePlayerOne++;
                End_Game();
                DisableBoard();
            }

            if (btnUpLeft.Text == "O" && btnUpMid.Text == "O" && btnUpRight.Text == "O")
            {
                btnUpLeft.BackColor = Color.Gold;
                btnUpMid.BackColor = Color.Gold;
                btnUpRight.BackColor = Color.Gold;
                
                winO = true;
                scorePlayerTwo++;
                End_Game();
                DisableBoard();
            }

            if (btnMidLeft.Text == "O" && btnMidMid.Text == "O" && btnMidRight.Text == "O")
            {
                btnMidLeft.BackColor = Color.Gold;
                btnMidMid.BackColor = Color.Gold;
                btnMidRight.BackColor = Color.Gold;

                winO = true;
                scorePlayerTwo++;
                End_Game();
                DisableBoard();
            }

            if (btnDownLeft.Text == "O" && btnDownMid.Text == "O" && btnDownRight.Text == "O")
            {
                btnDownLeft.BackColor = Color.Gold;
                btnDownMid.BackColor = Color.Gold;
                btnDownRight.BackColor = Color.Gold;

                winO = true;
                scorePlayerTwo++;
                End_Game();
                DisableBoard();
            }

            if (btnUpLeft.Text == "O" && btnMidLeft.Text == "O" && btnDownLeft.Text == "O")
            {
                btnUpLeft.BackColor = Color.Gold;
                btnMidLeft.BackColor = Color.Gold;
                btnDownLeft.BackColor = Color.Gold;

                winO = true;
                scorePlayerTwo++;
                End_Game();
                DisableBoard();
            }

            if (btnUpMid.Text == "O" && btnMidMid.Text == "O" && btnDownMid.Text == "O")
            {
                btnUpMid.BackColor = Color.Gold;
                btnMidMid.BackColor = Color.Gold;
                btnDownMid.BackColor = Color.Gold;

                winO = true;
                scorePlayerTwo++;
                End_Game();
                DisableBoard();
            }

            if (btnUpRight.Text == "O" && btnMidRight.Text == "O" && btnDownRight.Text == "O")
            {
                btnUpRight.BackColor = Color.Gold;
                btnMidRight.BackColor = Color.Gold;
                btnDownRight.BackColor = Color.Gold;

                winO = true;
                scorePlayerTwo++;
                End_Game();
                DisableBoard();
            }

            if (btnUpLeft.Text == "O" && btnMidMid.Text == "O" && btnDownRight.Text == "O")
            {
                btnUpLeft.BackColor = Color.Gold;
                btnMidMid.BackColor = Color.Gold;
                btnDownRight.BackColor = Color.Gold;

                winO = true;
                scorePlayerTwo++;
                End_Game();
                DisableBoard();
            }

            if (btnUpRight.Text == "O" && btnMidMid.Text == "O" && btnDownLeft.Text == "O")
            {
                btnUpRight.BackColor = Color.Gold;
                btnMidMid.BackColor = Color.Gold;
                btnDownLeft.BackColor = Color.Gold;

                winO = true;
                scorePlayerTwo++;
                End_Game();
                DisableBoard();
            }

            if (turnCount == 9)
            {
                MessageBox.Show("Draw!", "Draw", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisableBoard();
            }
        }

        private bool End_Game()
        {
            if (scorePlayerOne == 1)
            {
                scorePlayerOne--;

                if (winX)
                {
                    var player = playerRepository.GetPlayerByNick(SelectPlayer.PlayerOneName);
                    playerRepository.UpdateScore(player);
                }

                Visible = false;

                Player_One_Wins();

                return true;
            }

            if (scorePlayerTwo == 1)
            {
                scorePlayerTwo--;
                if (winO)
                {
                    var player = playerRepository.GetPlayerByNick(SelectPlayer.PlayerTwoName);
                    playerRepository.UpdateScore(player);
                }
                Visible = false;

                Player_Two_Wins();

                return true;
            }
            return false;
        }

        private void DisableBoard()
        {
            btnUpLeft.Enabled = false;
            btnUpMid.Enabled = false;
            btnUpRight.Enabled = false;
            btnMidLeft.Enabled = false;
            btnMidMid.Enabled = false;
            btnMidRight.Enabled = false;
            btnDownLeft.Enabled = false;
            btnDownMid.Enabled = false;
            btnDownRight.Enabled = false;
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void GetMoveFromOpponent()
        {
            byte[] buffer = new byte[1];
            socket.Receive(buffer);

            if (buffer[0] == 1)
            {
                btnUpLeft.Text = charOpponent;
                End_Round();
            }
            if (buffer[0] == 2)
            {
                btnUpMid.Text = charOpponent;
                End_Round();
            }
            if (buffer[0] == 3)
            {
                btnUpRight.Text = charOpponent;
                End_Round();
            }
            if (buffer[0] == 4)
            {
                btnMidLeft.Text = charOpponent;
                End_Round();
            }
            if (buffer[0] == 5)
            {
                btnMidMid.Text = charOpponent;
                End_Round();
            }
            if (buffer[0] == 6)
            {
                btnMidRight.Text = charOpponent;
                End_Round();
            }
            if (buffer[0] == 7)
            {
                btnDownLeft.Text = charOpponent;
                End_Round();
            }
            if (buffer[0] == 8)
            {
                btnDownMid.Text = charOpponent;
                End_Round();
            }
            if (buffer[0] == 9)
            {
                btnDownRight.Text = charOpponent;
                End_Round();
            }
        }

        private void btnUpLeft_Click(object sender, EventArgs e)
        {
            //if (move == false)
            //{
            //    btnUpLeft.Text = charPlayer;
            //    move = true;
            //    labelActivePlayer.Text = SelectPlayer.PlayerTwoName;
            //}
            //else
            //{
            //    btnUpLeft.Text = charOpponent;
            //    move = false;
            //    labelActivePlayer.Text = SelectPlayer.PlayerOneName;
            //}

            byte[] num = { 1 };
            socket.Send(num);
            btnUpLeft.Text = charPlayer.ToString();
            messageReceiver.RunWorkerAsync();

            turnCount++;
        }

        private void btnUpMid_Click(object sender, EventArgs e)
        {
        //    if (move == false)
        //    {
        //        btnUpMid.Text = charPlayer;
        //        move = true;
        //        labelActivePlayer.Text = SelectPlayer.PlayerTwoName;
        //    }
        //    else
        //    {
        //        btnUpMid.Text = charOpponent;
        //        move = false;
        //        labelActivePlayer.Text = SelectPlayer.PlayerOneName;
        //    }

            byte[] num = { 2 };
            socket.Send(num);
            btnUpMid.Text = charPlayer.ToString();
            messageReceiver.RunWorkerAsync();

            turnCount++;
            End_Round();
            //btnUpMid.Enabled = false;
        }

        private void btnUpRight_Click(object sender, EventArgs e)
        {
            //if (move == false)
            //{
            //    btnUpRight.Text = charPlayer;
            //    move = true;
            //    labelActivePlayer.Text = SelectPlayer.PlayerTwoName;
            //}
            //else
            //{
            //    btnUpRight.Text = charOpponent;
            //    move = false;
            //    labelActivePlayer.Text = SelectPlayer.PlayerOneName;
            //}

            byte[] num = { 3 };
            socket.Send(num);
            btnUpRight.Text = charPlayer.ToString();
            messageReceiver.RunWorkerAsync();

            turnCount++;
            End_Round();
            //btnUpRight.Enabled = false;
        }

        private void btnMidLeft_Click(object sender, EventArgs e)
        {
            //if (move == false)
            //{
            //    btnMidLeft.Text = charPlayer;
            //    move = true;
            //    labelActivePlayer.Text = SelectPlayer.PlayerTwoName;
            //}
            //else
            //{
            //    btnMidLeft.Text = charOpponent;
            //    move = false;
            //    labelActivePlayer.Text = SelectPlayer.PlayerOneName;
            //}

            byte[] num = { 4 };
            socket.Send(num);
            btnMidLeft.Text = charPlayer.ToString();
            messageReceiver.RunWorkerAsync();

            turnCount++;
            End_Round();
            //btnMidLeft.Enabled = false;
        }

        private void btnMidMid_Click(object sender, EventArgs e)
        {
            //if (move == false)
            //{
            //    btnMidMid.Text = charPlayer;
            //    move = true;
            //    labelActivePlayer.Text = SelectPlayer.PlayerTwoName;
            //}
            //else
            //{
            //    btnMidMid.Text = charOpponent;
            //    move = false;
            //    labelActivePlayer.Text = SelectPlayer.PlayerOneName;
            //}

            byte[] num = { 5 };
            socket.Send(num);
            btnMidMid.Text = charPlayer.ToString();
            messageReceiver.RunWorkerAsync();

            turnCount++;
            End_Round();
            //btnMidMid.Enabled = false;
        }

        private void btnMidRight_Click(object sender, EventArgs e)
        {
            //if (move == false)
            //{
            //    btnMidRight.Text = charPlayer;
            //    move = true;
            //    labelActivePlayer.Text = SelectPlayer.PlayerTwoName;
            //}
            //else
            //{
            //    btnMidRight.Text = charOpponent;
            //    move = false;
            //    labelActivePlayer.Text = SelectPlayer.PlayerOneName;
            //}

            byte[] num = { 6 };
            socket.Send(num);
            btnMidRight.Text = charPlayer.ToString();
            messageReceiver.RunWorkerAsync();

            turnCount++;
            End_Round();
            //btnMidRight.Enabled = false;
        }

        private void btnDownLeft_Click(object sender, EventArgs e)
        {
            //if (move == false)
            //{
            //    btnDownLeft.Text = charPlayer;
            //    move = true;
            //    labelActivePlayer.Text = SelectPlayer.PlayerTwoName;
            //}
            //else
            //{
            //    btnDownLeft.Text = charOpponent;
            //    move = false;
            //    labelActivePlayer.Text = SelectPlayer.PlayerOneName;
            //}

            byte[] num = { 7 };
            socket.Send(num);
            btnDownLeft.Text = charPlayer.ToString();
            messageReceiver.RunWorkerAsync();

            turnCount++;
            End_Round();
            //btnDownLeft.Enabled = false;
        }

        private void btnDownMid_Click(object sender, EventArgs e)
        {
            //if (move == false)
            //{
            //    btnDownMid.Text = charPlayer;
            //    move = true;
            //    labelActivePlayer.Text = SelectPlayer.PlayerTwoName;
            //}
            //else
            //{
            //    btnDownMid.Text = charOpponent;
            //    move = false;
            //    labelActivePlayer.Text = SelectPlayer.PlayerOneName;
            //}

            byte[] num = { 8 };
            socket.Send(num);
            btnDownMid.Text = charPlayer.ToString();
            messageReceiver.RunWorkerAsync();

            turnCount++;
            End_Round();
            //btnDownMid.Enabled = false;
        }

        private void btnDownRight_Click(object sender, EventArgs e)
        {
            //if (move == false)
            //{
            //    btnDownRight.Text = charPlayer;
            //    move = true;
            //    labelActivePlayer.Text = SelectPlayer.PlayerTwoName;
            //}
            //else
            //{
            //    btnDownRight.Text = charOpponent;
            //    move = false;
            //    labelActivePlayer.Text = SelectPlayer.PlayerOneName;
            //}

            byte[] num = { 9 };
            socket.Send(num);
            btnDownRight.Text = charPlayer.ToString();
            messageReceiver.RunWorkerAsync();

            turnCount++;
            End_Round();
            //btnDownRight.Enabled = false;
        }

        private void btnResetBoard_Click(object sender, EventArgs e)
        {

            //btnUpLeft.Enabled = true;
            //btnUpMid.Enabled = true;
            //btnUpRight.Enabled = true;
            //btnMidLeft.Enabled = true;
            //btnMidMid.Enabled = true;
            //btnMidRight.Enabled = true;
            //btnDownLeft.Enabled = true;
            //btnDownMid.Enabled = true;
            //btnDownRight.Enabled = true;

            //btnUpLeft.Text = "";
            //btnUpMid.Text = "";
            //btnUpRight.Text = "";
            //btnMidLeft.Text = "";
            //btnMidMid.Text = "";
            //btnMidRight.Text = "";
            //btnDownLeft.Text = "";
            //btnDownMid.Text = "";
            //btnDownRight.Text = "";

            //btnUpLeft.BackColor = Color.WhiteSmoke;
            //btnUpMid.BackColor = Color.WhiteSmoke;
            //btnUpRight.BackColor = Color.WhiteSmoke;
            //btnMidLeft.BackColor = Color.WhiteSmoke;
            //btnMidMid.BackColor = Color.WhiteSmoke;
            //btnMidRight.BackColor = Color.WhiteSmoke;
            //btnDownLeft.BackColor = Color.WhiteSmoke;
            //btnDownMid.BackColor = Color.WhiteSmoke;
            //btnDownRight.BackColor = Color.WhiteSmoke;

            //turnCount = 0;
            //move = false;
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            messageReceiver.WorkerSupportsCancellation = true;
            messageReceiver.CancelAsync();
            if(server != null)
                server.Stop();
        }
    }
}
