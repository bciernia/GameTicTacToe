
namespace GameTicTacToe
{
    partial class SelectPlayer
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.tbPlayerOne = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your nickname";
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnStartGame.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStartGame.FlatAppearance.BorderSize = 3;
            this.btnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartGame.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStartGame.Location = new System.Drawing.Point(88, 170);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(201, 123);
            this.btnStartGame.TabIndex = 1;
            this.btnStartGame.Text = "Start game!";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // tbPlayerOne
            // 
            this.tbPlayerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbPlayerOne.Location = new System.Drawing.Point(243, 21);
            this.tbPlayerOne.Name = "tbPlayerOne";
            this.tbPlayerOne.Size = new System.Drawing.Size(127, 30);
            this.tbPlayerOne.TabIndex = 3;
            // 
            // SelectPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(683, 338);
            this.Controls.Add(this.tbPlayerOne);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.label1);
            this.Name = "SelectPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectPlayers";
            this.Load += new System.EventHandler(this.SelectPlayer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.TextBox tbPlayerOne;
    }
}