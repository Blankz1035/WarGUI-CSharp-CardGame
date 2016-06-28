namespace WarGUI
{
    partial class Form1
    {
        
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbcCard = new System.Windows.Forms.PictureBox();
            this.pbpCard = new System.Windows.Forms.PictureBox();
            this.pbDeck = new System.Windows.Forms.PictureBox();
            this.btnDrawCard = new System.Windows.Forms.Button();
            this.tbMyScore = new System.Windows.Forms.TextBox();
            this.tbHisScore = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnReplay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbcCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeck)).BeginInit();
            this.SuspendLayout();
            // 
            // pbcCard
            // 
            this.pbcCard.Location = new System.Drawing.Point(419, 84);
            this.pbcCard.Margin = new System.Windows.Forms.Padding(2);
            this.pbcCard.Name = "pbcCard";
            this.pbcCard.Size = new System.Drawing.Size(90, 133);
            this.pbcCard.TabIndex = 0;
            this.pbcCard.TabStop = false;
            // 
            // pbpCard
            // 
            this.pbpCard.Location = new System.Drawing.Point(34, 84);
            this.pbpCard.Margin = new System.Windows.Forms.Padding(2);
            this.pbpCard.Name = "pbpCard";
            this.pbpCard.Size = new System.Drawing.Size(90, 133);
            this.pbpCard.TabIndex = 1;
            this.pbpCard.TabStop = false;
            // 
            // pbDeck
            // 
            this.pbDeck.Image = ((System.Drawing.Image)(resources.GetObject("pbDeck.Image")));
            this.pbDeck.Location = new System.Drawing.Point(224, 84);
            this.pbDeck.Margin = new System.Windows.Forms.Padding(2);
            this.pbDeck.Name = "pbDeck";
            this.pbDeck.Size = new System.Drawing.Size(90, 133);
            this.pbDeck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDeck.TabIndex = 2;
            this.pbDeck.TabStop = false;
            // 
            // btnDrawCard
            // 
            this.btnDrawCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrawCard.Location = new System.Drawing.Point(211, 271);
            this.btnDrawCard.Margin = new System.Windows.Forms.Padding(2);
            this.btnDrawCard.Name = "btnDrawCard";
            this.btnDrawCard.Size = new System.Drawing.Size(104, 34);
            this.btnDrawCard.TabIndex = 3;
            this.btnDrawCard.Text = "Draw Card";
            this.btnDrawCard.UseVisualStyleBackColor = true;
            this.btnDrawCard.Click += new System.EventHandler(this.btnDrawCard_Click);
            // 
            // tbMyScore
            // 
            this.tbMyScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMyScore.Location = new System.Drawing.Point(47, 273);
            this.tbMyScore.Margin = new System.Windows.Forms.Padding(2);
            this.tbMyScore.Name = "tbMyScore";
            this.tbMyScore.ReadOnly = true;
            this.tbMyScore.Size = new System.Drawing.Size(76, 32);
            this.tbMyScore.TabIndex = 4;
            // 
            // tbHisScore
            // 
            this.tbHisScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHisScore.Location = new System.Drawing.Point(419, 269);
            this.tbHisScore.Margin = new System.Windows.Forms.Padding(2);
            this.tbHisScore.Name = "tbHisScore";
            this.tbHisScore.ReadOnly = true;
            this.tbHisScore.Size = new System.Drawing.Size(76, 32);
            this.tbHisScore.TabIndex = 5;
            this.tbHisScore.TabStop = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(192, 302);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 26);
            this.lblResult.TabIndex = 6;
            // 
            // btnReplay
            // 
            this.btnReplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplay.Location = new System.Drawing.Point(211, 271);
            this.btnReplay.Margin = new System.Windows.Forms.Padding(2);
            this.btnReplay.Name = "btnReplay";
            this.btnReplay.Size = new System.Drawing.Size(104, 34);
            this.btnReplay.TabIndex = 7;
            this.btnReplay.Text = "Play Again";
            this.btnReplay.UseVisualStyleBackColor = true;
            this.btnReplay.Visible = false;
            this.btnReplay.Click += new System.EventHandler(this.btnReplay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(31, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Player 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Fuchsia;
            this.label2.Location = new System.Drawing.Point(416, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Player 2";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Silver;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.richTextBox1.Location = new System.Drawing.Point(82, 10);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(384, 47);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "WAR CARD GAME!!";
            this.richTextBox1.WordWrap = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(150, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "SHUFFLE THEM CARDS!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(474, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 12;
            this.button2.Text = "QUIT!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(4, 339);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "by Andrew Blankley";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(561, 360);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReplay);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.tbHisScore);
            this.Controls.Add(this.tbMyScore);
            this.Controls.Add(this.btnDrawCard);
            this.Controls.Add(this.pbDeck);
            this.Controls.Add(this.pbpCard);
            this.Controls.Add(this.pbcCard);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "   War";
            ((System.ComponentModel.ISupportInitialize)(this.pbcCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbcCard;
        private System.Windows.Forms.PictureBox pbpCard;
        private System.Windows.Forms.PictureBox pbDeck;
        private System.Windows.Forms.Button btnDrawCard;
        private System.Windows.Forms.TextBox tbMyScore;
        private System.Windows.Forms.TextBox tbHisScore;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnReplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

