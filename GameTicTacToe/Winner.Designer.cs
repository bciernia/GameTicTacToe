
namespace GameTicTacToe
{
    partial class Winner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelWinnerPlayer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWinnerPlayer
            // 
            this.labelWinnerPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWinnerPlayer.BackColor = System.Drawing.Color.PaleTurquoise;
            this.labelWinnerPlayer.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWinnerPlayer.Location = new System.Drawing.Point(9, 65);
            this.labelWinnerPlayer.Name = "labelWinnerPlayer";
            this.labelWinnerPlayer.Size = new System.Drawing.Size(306, 58);
            this.labelWinnerPlayer.TabIndex = 1;
            this.labelWinnerPlayer.Text = "winner";
            this.labelWinnerPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(67, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "won this match!";
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnNewGame.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNewGame.FlatAppearance.BorderSize = 3;
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGame.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNewGame.Location = new System.Drawing.Point(38, 246);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(128, 60);
            this.btnNewGame.TabIndex = 3;
            this.btnNewGame.Text = "New game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.BorderSize = 3;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.Location = new System.Drawing.Point(172, 246);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 60);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Winner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(330, 331);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelWinnerPlayer);
            this.MaximumSize = new System.Drawing.Size(346, 370);
            this.MinimumSize = new System.Drawing.Size(346, 370);
            this.Name = "Winner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Winner";
            this.Load += new System.EventHandler(this.Winner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelWinnerPlayer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnExit;
    }
}