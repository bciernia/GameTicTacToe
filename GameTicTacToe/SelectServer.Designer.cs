
namespace GameTicTacToe
{
    partial class SelectServer
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
            this.labelPlayerNick = new System.Windows.Forms.Label();
            this.labelPlayerScore = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRanking = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPlayerNick
            // 
            this.labelPlayerNick.AutoSize = true;
            this.labelPlayerNick.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPlayerNick.Location = new System.Drawing.Point(17, 37);
            this.labelPlayerNick.Name = "labelPlayerNick";
            this.labelPlayerNick.Size = new System.Drawing.Size(109, 27);
            this.labelPlayerNick.TabIndex = 0;
            this.labelPlayerNick.Text = "playerNick";
            // 
            // labelPlayerScore
            // 
            this.labelPlayerScore.AutoSize = true;
            this.labelPlayerScore.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPlayerScore.Location = new System.Drawing.Point(189, 37);
            this.labelPlayerScore.Name = "labelPlayerScore";
            this.labelPlayerScore.Size = new System.Drawing.Size(170, 27);
            this.labelPlayerScore.TabIndex = 1;
            this.labelPlayerScore.Text = "playerTotalScore";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(337, 126);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(386, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 60);
            this.button1.TabIndex = 4;
            this.button1.Text = "Join game";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(558, 107);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 60);
            this.button3.TabIndex = 6;
            this.button3.Text = "Create game";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.BorderSize = 3;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(558, 173);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 60);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnRanking
            // 
            this.btnRanking.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnRanking.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRanking.FlatAppearance.BorderSize = 3;
            this.btnRanking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRanking.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnRanking.Location = new System.Drawing.Point(558, 20);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.Size = new System.Drawing.Size(150, 60);
            this.btnRanking.TabIndex = 8;
            this.btnRanking.Text = "Ranking";
            this.btnRanking.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(17, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "Your games";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(365, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "IP:";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(370, 197);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(182, 20);
            this.tbAddress.TabIndex = 11;
            // 
            // SelectServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(720, 259);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRanking);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelPlayerScore);
            this.Controls.Add(this.labelPlayerNick);
            this.MaximumSize = new System.Drawing.Size(736, 298);
            this.MinimumSize = new System.Drawing.Size(736, 298);
            this.Name = "SelectServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectServer";
            this.Load += new System.EventHandler(this.SelectServer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPlayerNick;
        private System.Windows.Forms.Label labelPlayerScore;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRanking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAddress;
    }
}