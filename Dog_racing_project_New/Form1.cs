using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dog_racing_project_New
{
    public partial class Form1 : Form
    {
        Player[] plyer = new Player[3];
        Dog dog = new Dog();

        int harry = 100,henry=100,smith=100;

        public Form1()
        {
            InitializeComponent();
            
            plyer[0] = new Player("Harry", 0,0,harry);
            plyer[1] = new Player("Henry", 0, 0, henry);
            plyer[2] = new Player("Smith", 0, 0,smith);

            //Harry
            //Henry
            //Smith
        }

        private void race_btn_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        // timer workings
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Dog_no1.Left>680) {
                timer1.Stop();
                if (plyer[0].betAmount>0) {
                    harry = plyer[0].restResult(1);
                }

                if (plyer[1].betAmount > 0)
                {
                    henry = plyer[1].restResult(1);
                }

                if (plyer[2].betAmount > 0)
                {
                    smith = plyer[2].restResult(1);
                }
                
                MessageBox.Show("Dog 1 win the race");
                Dog_no1.Left = 10;
                Dog_no2.Left = 10;
                Dog_no3.Left = 10;
                Dog_no4.Left = 10;

                player1.Text = "Player 1 has "+harry;
                player2.Text = "Player 2 has "+henry;
                player3.Text = "Player 3 has "+smith;
                
                PlayerBox.Text = "";
                AmountBox.Text = "";
                dogBox.Text = "";
                race_btn.Enabled = false;
                plyer = new Player[3];
                plyer[0] = new Player("Harry", 0, 0, harry);
                plyer[1] = new Player("Henry", 0, 0, henry);
                plyer[2] = new Player("Smith", 0, 0, smith);
            }

            if (Dog_no2.Left > 680)
            {
                timer1.Stop();
                if (plyer[0].betAmount > 0)
                {
                    harry = plyer[0].restResult(2);
                }

                if (plyer[1].betAmount > 0)
                {
                    henry = plyer[1].restResult(2);
                }

                

                if (plyer[2].betAmount > 0)
                {
                    smith = plyer[2].restResult(2);
                }
                MessageBox.Show("Dog 2 win the race");
                Dog_no1.Left = 10;
                Dog_no2.Left = 10;
                Dog_no3.Left = 10;
                Dog_no4.Left = 10;

                player1.Text = "Player 1 has " + harry;
                player2.Text = "Player 2 has "+henry;
                player3.Text = "Player 3 has "+smith;

                PlayerBox.Text = "";
                AmountBox.Text = "";
                dogBox.Text = "";
                race_btn.Enabled = false;

                plyer = new Player[3];
                plyer[0] = new Player("Harry", 0, 0, harry);
                plyer[1] = new Player("Henry", 0, 0, henry);
                plyer[2] = new Player("Smith", 0, 0, smith);
            }

            // timer works according conditions given

            if (Dog_no3.Left > 680)
            {
                timer1.Stop();

                if (plyer[0].betAmount > 0)
                {
                    harry = plyer[0].restResult(3);
                }

                if (plyer[1].betAmount > 0)
                {
                    henry = plyer[1].restResult(3);
                }

                if (plyer[2].betAmount > 0)
                {
                    smith = plyer[2].restResult(3);
                }
                MessageBox.Show("Dog 3 win the race");
                Dog_no1.Left = 10;
                Dog_no2.Left = 10;
                Dog_no3.Left = 10;
                Dog_no4.Left = 10;

                player1.Text = "Player 1 has "+harry;
                player2.Text = "Player 2 has "+henry;
                player3.Text = "Player 3 has "+smith;

                PlayerBox.Text = "";
                AmountBox.Text = "";
                dogBox.Text = "";
                race_btn.Enabled = false;

                plyer = new Player[3];
                plyer[0] = new Player("Harry", 0, 0, harry);
                plyer[1] = new Player("Henry", 0, 0, henry);
                plyer[2] = new Player("Smith", 0, 0, smith);
            }


            if (Dog_no4.Left > 680)
            {
                timer1.Stop();

                if (plyer[0].betAmount > 0)
                {
                    harry = plyer[0].restResult(4);
                }

                if (plyer[1].betAmount > 0)
                {
                    henry = plyer[1].restResult(4);
                }

                if (plyer[2].betAmount > 0)
                {
                    smith = plyer[2].restResult(4);
                }
                MessageBox.Show("Dog 4 win the race");
                Dog_no1.Left = 10;
                Dog_no2.Left = 10;
                Dog_no3.Left = 10;
                Dog_no4.Left = 10;

                player1.Text = "Player 1 has "+harry;
                player2.Text = "Player 2 has "+henry;
                player3.Text = "Player 3 has "+smith;

                PlayerBox.Text = "";
                AmountBox.Text = "";
                dogBox.Text = "";

                race_btn.Enabled = false;

                plyer = new Player[3];
                plyer[0] = new Player("Harry", 0, 0, harry);
                plyer[1] = new Player("Henry", 0, 0, henry);
                plyer[2] = new Player("Smith", 0, 0, smith);
            }

            Player pl1 = new Player("", 0, 0, 0);
            Player pl2 = new Player("", 0, 0, 0);
            Player pl3 = new Player("", 0, 0, 0);
            Player pl4 = new Player("", 0, 0, 0);
            Dog_no1.Left += dog.jump();
            Dog_no2.Left += dog.jump();
            Dog_no3.Left += dog.jump();
            Dog_no4.Left += dog.jump();
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void bet_btn_Click(object sender, EventArgs e)
        {
            //here crete the setting of the gme to strt the gme 
            if (PlayerBox.SelectedItem.ToString().Equals("Harry"))
            {
                if (Convert.ToInt32(AmountBox.SelectedItem.ToString()) < harry && !dogBox.Text.Equals(""))
                {
                    plyer[0] = new Player("Harry", Convert.ToInt32(AmountBox.SelectedItem.ToString()), Convert.ToInt32(dogBox.SelectedItem.ToString()), harry);
                    player1.Text = "Harry interested to " + Convert.ToInt32(dogBox.SelectedItem.ToString()) + " with " + Convert.ToInt32(AmountBox.SelectedItem.ToString());
                    race_btn.Enabled = true;

                }
            }
            else if (PlayerBox.SelectedItem.ToString().Equals("Henry"))
            {
                if (Convert.ToInt32(AmountBox.SelectedItem.ToString()) < henry && !dogBox.Text.Equals(""))
                {
                    plyer[1] = new Player("Henry", Convert.ToInt32(AmountBox.SelectedItem.ToString()), Convert.ToInt32(dogBox.SelectedItem.ToString()), henry);
                    player2.Text = "Henry interested to " + Convert.ToInt32(dogBox.SelectedItem.ToString()) + " with " + Convert.ToInt32(AmountBox.SelectedItem.ToString());
                    race_btn.Enabled = true;
                }

            }

            else if (PlayerBox.SelectedItem.ToString().Equals("Smith"))
            {
                if (Convert.ToInt32(AmountBox.SelectedItem.ToString()) < smith && !dogBox.Text.Equals(""))
                {
                    plyer[2] = new Player("Smith", Convert.ToInt32(AmountBox.SelectedItem.ToString()), Convert.ToInt32(dogBox.SelectedItem.ToString()), smith);
                    player3.Text = "Smith interested to " + Convert.ToInt32(dogBox.SelectedItem.ToString()) + " with " + Convert.ToInt32(AmountBox.SelectedItem.ToString());
                    race_btn.Enabled = true;
                }

            }
            else {
                MessageBox.Show("Please follow the guidelines to ply the game ");
            }



        }
    }
}
