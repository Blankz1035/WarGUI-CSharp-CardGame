using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;


namespace WarGUI
{
    public partial class Form1 : Form
    {
        private bool[] FillDeck = new bool[52];

        private Random rand = new Random();

        private int pCard , cCard;
        private int myval , hisval;
        private int mypoints, hispoints;
        private PictureBox[] SelectCard;

        public Form1()
        {
            InitializeComponent();
            pCard = cCard = -1;
            myval = hisval = 0;
            mypoints = hispoints = 0;
            pbpCard.SizeMode = PictureBoxSizeMode.StretchImage;
            pbcCard.SizeMode = PictureBoxSizeMode.StretchImage;
          
            SelectCard = new PictureBox[52];            
            ResourceManager rm = WarGUI.Properties.Resources.ResourceManager;
            for (int i = 0; i < 52; ++i)
            {
                SelectCard[i] = new PictureBox();            
                SelectCard[i].Image = (Image)rm.GetObject("_"+(i+1).ToString());
            }
        }

        //draw both player cards
        private void btnDrawCard_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            //get unique cards
            do
            {
                pCard = rand.Next(52);
            }
            while (FillDeck[pCard]);

            pbpCard.Image = new Bitmap(SelectCard[pCard].Image);
            FillDeck[pCard] = true;
            myval = (pCard % 13) + 2;

            do
            {
                cCard = rand.Next(52);
            }
            while (FillDeck[cCard]);

            pbcCard.Image = new Bitmap(SelectCard[cCard].Image);
            FillDeck[cCard] = true;
            hisval = (cCard % 13) + 2;

            //divy out points
            if (myval > hisval)
                mypoints += 2;
            else if (myval < hisval)
                hispoints += 2;
            else
            {
                mypoints++;
                hispoints++;
            }
            
            //test for win
            if((mypoints + hispoints) >= 52)
            {
                pbDeck.Image = null;
                if(mypoints > hispoints)
                    lblResult.Text = "Player 1 Wins!";
                else if(hispoints > mypoints)
                    lblResult.Text = "Player 2 Wins!";
                else
                    lblResult.Text = "TIE GAME!";
                btnReplay.Visible = true;
                btnDrawCard.Visible = false;
                
            }
            //display points
            tbMyScore.Text = Convert.ToString(mypoints);
            tbHisScore.Text = Convert.ToString(hispoints);
        }

        private void btnReplay_Click(object sender, EventArgs e)
        {
            pCard = cCard = -1;
            myval = hisval = 0;
            mypoints = hispoints = 0;
            for (int i = 0; i < 52; ++i)
                FillDeck[i] = false;
            lblResult.Text = null;
            tbMyScore.Text = null;
            tbHisScore.Text = null;
            pbDeck.Image = WarGUI.Properties.Resources.back;
            pbpCard.Image = pbcCard.Image = null;
            btnDrawCard.Visible = true;
            btnReplay.Visible = false;
            button1.Visible = true;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            do
            {
                pCard = rand.Next(52);
            }
            while (FillDeck[pCard]);

            do
            {
                cCard = rand.Next(52);
            }
            while (FillDeck[cCard]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Results!\nPlayer 1 Scored: " + mypoints + "\nPlayer 2 Scored: " + hispoints + "\n\nTo the Loser... Hard Luck!\n\n THE WAR HAS BEEN WON!");

            this.Close();
        }

      
        
    }
}
