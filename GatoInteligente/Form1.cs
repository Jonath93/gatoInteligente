using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GatoInteligente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int count = 0;
        string searchX = "X";
        Button[] btn = new Button[9];
        

        //verifica quien gana
        private void WhoWin()
        {
            //[0][1][2]
            //[3][4][5]
            //[6][7][8]


            if ((btn[0].Text == "X" && btn[1].Text == "X" && btn[2].Text == "X") ||
                (btn[3].Text == "X" && btn[4].Text == "X" && btn[5].Text == "X") ||
                (btn[6].Text == "X" && btn[7].Text == "X" && btn[8].Text == "X") ||
                (btn[0].Text == "X" && btn[3].Text == "X" && btn[6].Text == "X") ||
                (btn[1].Text == "X" && btn[4].Text == "X" && btn[7].Text == "X") ||
                (btn[2].Text == "X" && btn[5].Text == "X" && btn[8].Text == "X") ||
                (btn[0].Text == "X" && btn[4].Text == "X" && btn[8].Text == "X") ||
                (btn[6].Text == "X" && btn[4].Text == "X" && btn[2].Text == "X"))
            {
                MessageBox.Show("Player wins");
                reset();
            }
            else if ((btn[0].Text == "O" && btn[1].Text == "O" && btn[2].Text == "O") ||
               (btn[3].Text == "O" && btn[4].Text == "O" && btn[5].Text == "O") ||
               (btn[6].Text == "O" && btn[7].Text == "O" && btn[8].Text == "O") ||
               (btn[0].Text == "O" && btn[3].Text == "O" && btn[6].Text == "O") ||
               (btn[1].Text == "O" && btn[4].Text == "O" && btn[7].Text == "O") ||
               (btn[2].Text == "O" && btn[5].Text == "O" && btn[8].Text == "O") ||
               (btn[0].Text == "O" && btn[4].Text == "O" && btn[8].Text == "O") ||
               (btn[6].Text == "O" && btn[4].Text == "O" && btn[2].Text == "O"))
            {
                MessageBox.Show("Maquina wins");
                
                reset();
            }
            else if (btn[0].Text != "" && btn[1].Text != "" && btn[2].Text != "" &&
               btn[3].Text != "" && btn[4].Text != "" && btn[5].Text != "" &&
               btn[6].Text != "" && btn[7].Text != "" && btn[8].Text != "")
            {
                MessageBox.Show("Game Draw");
                
                reset();
            }
        }

        //private void whoScore(int juego)
        //{
        //    if (juego ==  1)
        //    {
        //        return 10;
        //    }
        //}

        private void Machine()
        {
            //[0][1][2]
            //[3][4][5]
            //[6][7][8]

            
            Random random = new Random();
            int numero = random.Next(1, 9);

                
            switch (count)
            {
                    
                case 1:
                        
                    if (btn[0].Text=="X" || btn[2].Text=="X" || btn[8].Text=="X" || btn[6].Text == "X")
                    {
                        btn[4].Text = "O";
                        count++;
                        btn[4].Enabled = false;
                                
                    }
                        
                    else if (btn[1].Text == "X" || btn[3].Text=="X"|| btn[4].Text=="X")
                    {
                        btn[0].Text = "O";
                        count++;
                        btn[0].Enabled = false;
                                
                    }
                    else if (btn[5].Text == "X")
                    {
                        btn[2].Text = "O";
                        count++;
                        btn[2].Enabled = false;

                    }
                    else if (btn[7].Text == "X")
                    {
                        btn[1].Text = "O";
                        count++;
                        btn[1].Enabled = false;

                    }


                    break;
                    
                case 3:
                        
                    if (btn[0].Text == "X" && btn[6].Text == "X" && btn[3].Enabled == true)
                    {
                        btn[3].Text = "O";
                        count++;
                        btn[3].Enabled = false;

                    }
                    else if (btn[0].Text == "X" && btn[3].Text == "X" && btn[6].Enabled == true)
                    {
                        btn[6].Text = "O";
                        count++;
                        btn[6].Enabled = false;

                    }
                    else if (btn[0].Text == "X" && btn[1].Text == "X" && btn[2].Enabled == true)
                    {
                        btn[2].Text = "O";
                        count++;
                        btn[2].Enabled = false;

                    }
                    else if (btn[4].Text == "X" && btn[6].Text == "X" && btn[2].Enabled == true)
                    {
                        btn[2].Text = "O";
                        count++;
                        btn[2].Enabled = false;

                    }
                    else if (btn[4].Text == "X" && btn[8].Text == "X" && btn[2].Enabled == true)
                    {
                        btn[2].Text = "O";
                        count++;
                        btn[2].Enabled = false;

                    }
                    else if (btn[3].Text == "X" && btn[6].Text=="X" && btn[0].Enabled == true)
                    {
                        btn[0].Text = "O";
                        count++;
                        btn[0].Enabled = false;
                                
                    }
                    else if (btn[3].Text == "X" && btn[4].Text=="X" && btn[5].Enabled == true)
                    {
                        btn[5].Text = "O";
                        count++;
                        btn[5].Enabled = false;
                                
                    }
                    else if (btn[4].Text == "X" && btn[2].Text == "X" && btn[6].Enabled == true)
                    {
                        btn[6].Text = "O";
                        count++;
                        btn[6].Enabled = false;

                    }
                    else if (btn[1].Text == "X" && btn[4].Text == "X" && btn[7].Enabled == true)
                    {
                        btn[7].Text = "O";
                        count++;
                        btn[7].Enabled = false;

                    }
                    else if (btn[7].Text == "X" && btn[4].Text == "X" && btn[1].Enabled == true)
                    {
                        btn[1].Text = "O";
                        count++;
                        btn[1].Enabled = false;

                    }
                    else if (btn[7].Text == "X" && btn[2].Text == "X" && btn[6].Enabled == true)
                    {
                        btn[6].Text = "O";
                        count++;
                        btn[6].Enabled = false;

                    }
                    else if (btn[2].Text == "X" && btn[5].Text == "X" && btn[8].Enabled == true)
                    {
                        btn[8].Text = "O";
                        count++;
                        btn[8].Enabled = false;

                    }
                    else if (btn[4].Text == "X" && btn[5].Text == "X" && btn[3].Enabled == true)
                    {
                        btn[3].Text = "O";
                        count++;
                        btn[3].Enabled = false;

                    }
                    else if (btn[0].Text == "X" && btn[2].Text == "X" && btn[1].Enabled == true)
                    {
                        btn[1].Text = "O";
                        count++;
                        btn[1].Enabled = false;

                    }
                    else if (btn[8].Text == "X" && btn[2].Text == "X" && btn[5].Enabled == true)
                    {
                        btn[5].Text = "O";
                        count++;
                        btn[5].Enabled = false;

                    }
                    else if (btn[8].Text == "X" && btn[6].Text == "X" && btn[7].Enabled == true)
                    {
                        btn[7].Text = "O";
                        count++;
                        btn[7].Enabled = false;

                    }
                    else if (btn[0].Enabled == true)
                    {
                        btn[0].Text = "O";
                        count++;
                        btn[0].Enabled = false;
                    }
                    else if (btn[4].Enabled == true)
                    {
                        btn[4].Text = "O";
                        count++;
                        btn[4].Enabled = false;
                    }
                    else if (btn[3].Enabled == true)
                    {
                        btn[3].Text = "O";
                        count++;
                        btn[3].Enabled = false;
                    }



                    break;
                    
                case 5:
                    if (btn[0].Text == "O" && btn[1].Text == "O" && btn[2].Enabled == true)
                    {
                        btn[2].Text = "O";
                        count++;
                        btn[2].Enabled = false;

                    }
                    else if (btn[0].Text == "O" && btn[2].Text == "O" && btn[1].Enabled == true)
                    {
                        btn[1].Text = "O";
                        count++;
                        btn[1].Enabled = false;

                    }
                    else if (btn[1].Text == "O" && btn[2].Text == "O" && btn[0].Enabled == true)
                    {
                        btn[0].Text = "O";
                        count++;
                        btn[0].Enabled = false;

                    }
                    else if (btn[0].Text == "O" && btn[4].Text == "O" && btn[8].Enabled == true)
                    {
                        btn[8].Text = "O";
                        count++;
                        btn[8].Enabled = false;

                    }
                    else if (btn[4].Text == "O" && btn[8].Text == "O" && btn[0].Enabled == true)
                    {
                        btn[0].Text = "O";
                        count++;
                        btn[0].Enabled = false;

                    }
                    
                    else if (btn[0].Text == "O" && btn[3].Text == "O" && btn[6].Enabled == true)
                    {
                        btn[6].Text = "O";
                        count++;
                        btn[6].Enabled = false;

                    }
                    else if (btn[0].Text == "O" && btn[6].Text == "O" && btn[3].Enabled == true)
                    {
                        btn[3].Text = "O";
                        count++;
                        btn[3].Enabled = false;

                    }
                    else if (btn[3].Text == "O" && btn[6].Text == "O" && btn[0].Enabled == true)
                    {
                        btn[0].Text = "O";
                        count++;
                        btn[0].Enabled = false;

                    }
                    else if (btn[7].Text == "O" && btn[4].Text == "O" && btn[1].Enabled == true)
                    {
                        btn[1].Text = "O";
                        count++;
                        btn[1].Enabled = false;

                    }
                    else if (btn[1].Text == "O" && btn[4].Text == "O" && btn[7].Enabled == true)
                    {
                        btn[7].Text = "O";
                        count++;
                        btn[7].Enabled = false;

                    }
                    
                    else if (btn[2].Text == "O" && btn[5].Text == "O" && btn[8].Enabled == true)
                    {
                        btn[8].Text = "O";
                        count++;
                        btn[8].Enabled = false;

                    }
                    else if (btn[5].Text == "O" && btn[8].Text == "O" && btn[2].Enabled == true)
                    {
                        btn[2].Text = "O";
                        count++;
                        btn[2].Enabled = false;

                    }
                    else if (btn[2].Text == "O" && btn[8].Text == "O" && btn[5].Enabled == true)
                    {
                        btn[5].Text = "O";
                        count++;
                        btn[5].Enabled = false;

                    }
                    else if (btn[3].Text == "O" && btn[4].Text == "O" && btn[5].Enabled == true)
                    {
                        btn[5].Text = "O";
                        count++;
                        btn[5].Enabled = false;

                    }
                    else if (btn[4].Text == "O" && btn[5].Text == "O" && btn[3].Enabled == true)
                    {
                        btn[3].Text = "O";
                        count++;
                        btn[3].Enabled = false;

                    }
                    
                    else if (btn[6].Text == "O" && btn[7].Text == "O" && btn[8].Enabled == true)
                    {
                        btn[8].Text = "O";
                        count++;
                        btn[8].Enabled = false;

                    }
                    else if (btn[7].Text == "O" && btn[8].Text == "O" && btn[6].Enabled == true)
                    {
                        btn[6].Text = "O";
                        count++;
                        btn[6].Enabled = false;

                    }
                    else if (btn[6].Text == "O" && btn[8].Text == "O" && btn[7].Enabled == true)
                    {
                        btn[7].Text = "O";
                        count++;
                        btn[7].Enabled = false;

                    }
                    else if (btn[2].Text == "O" && btn[4].Text == "O" && btn[6].Enabled == true)
                    {
                        btn[6].Text = "O";
                        count++;
                        btn[6].Enabled = false;

                    }
                    else if (btn[6].Text == "O" && btn[4].Text == "O" && btn[2].Enabled == true)
                    {
                        btn[2].Text = "O";
                        count++;
                        btn[2].Enabled = false;

                    }

                    else if (btn[1].Text=="X" && btn[4].Text=="X" && btn[7].Enabled == true)
                    {
                        btn[7].Text = "O";
                        count++;
                        btn[7].Enabled = false;
                    }
                    else if (btn[6].Text == "X" && btn[8].Text=="X" && btn[7].Enabled == true)
                    {
                        btn[7].Text = "O";
                        count++;
                        btn[7].Enabled = false;
                                
                    }
                    else if (btn[0].Text == "X" && btn[2].Text == "X" && btn[1].Enabled == true)
                    {
                        btn[1].Text = "O";
                        count++;
                        btn[1].Enabled = false;

                    }
                    else if (btn[7].Text == "X"&&btn[4].Text=="X" && btn[1].Enabled == true)
                    {
                        btn[1].Text = "O";
                        count++;
                        btn[1].Enabled = false;
                                
                    }
                    else if (btn[4].Text == "X" && btn[2].Text == "X" && btn[6].Enabled == true)
                    {
                        btn[6].Text = "O";
                        count++;
                        btn[6].Enabled = false;

                    }
                    else if (btn[3].Text == "X" && btn[4].Text == "X" && btn[5].Enabled == true)
                    {
                        btn[5].Text = "O";
                        count++;
                        btn[5].Enabled = false;

                    }
                    else if (btn[6].Text == "X" && btn[4].Text == "X" && btn[2].Enabled == true)
                    {
                        btn[2].Text = "O";
                        count++;
                        btn[2].Enabled = false;

                    }
                    else if (btn[2].Text == "X" && btn[5].Text == "X" && btn[8].Enabled == true)
                    {
                        btn[8].Text = "O";
                        count++;
                        btn[8].Enabled = false;

                    }
                    else if (btn[0].Text == "X" && btn[2].Text == "X" && btn[1].Enabled == true)
                    {
                        btn[1].Text = "O";
                        count++;
                        btn[1].Enabled = false;

                    }
                    else if (btn[4].Text == "X" && btn[5].Text == "X" && btn[3].Enabled == true)
                    {
                        btn[3].Text = "O";
                        count++;
                        btn[3].Enabled = false;

                    }
                    else if (btn[0].Text == "X" && btn[6].Text == "X" && btn[3].Enabled == true)
                    {
                        btn[3].Text = "O";
                        count++;
                        btn[3].Enabled = false;

                    }
                    else if (btn[8].Text == "X" && btn[4].Text == "X" && btn[0].Enabled == true)
                    {
                        btn[0].Text = "O";
                        count++;
                        btn[0].Enabled = false;
                    }
                    else if (btn[0].Text == "X" && btn[4].Text == "X" && btn[8].Enabled == true)
                    {
                        btn[8].Text = "O";
                        count++;
                        btn[8].Enabled = false;
                    }



                    else if (btn[4].Enabled == true)
                    {
                        btn[4].Text = "O";
                        count++;
                        btn[4].Enabled = false;
                    }
                    else if (btn[2].Enabled == true)
                    {
                        btn[2].Text = "O";
                        count++;
                        btn[2].Enabled = false;
                    }
                    else if (btn[0].Enabled == true)
                    {
                        btn[0].Text = "O";
                        count++;
                        btn[0].Enabled = false;
                    }




                    break;
                    
                case 7:
                    if (btn[0].Text == "O" && btn[1].Text == "O" && btn[2].Enabled == true)
                    {
                        btn[2].Text = "O";
                        count++;
                        btn[2].Enabled = false;

                    }
                    else if (btn[0].Text == "O" && btn[2].Text == "O" && btn[1].Enabled == true)
                    {
                        btn[1].Text = "O";
                        count++;
                        btn[1].Enabled = false;

                    }
                    else if (btn[1].Text == "O" && btn[2].Text == "O" && btn[0].Enabled == true)
                    {
                        btn[0].Text = "O";
                        count++;
                        btn[0].Enabled = false;

                    }
                    else if (btn[0].Text == "O" && btn[4].Text == "O" && btn[8].Enabled == true)
                    {
                        btn[8].Text = "O";
                        count++;
                        btn[8].Enabled = false;

                    }
                    else if (btn[4].Text == "O" && btn[8].Text == "O" && btn[0].Enabled == true)
                    {
                        btn[0].Text = "O";
                        count++;
                        btn[0].Enabled = false;

                    }

                    else if (btn[0].Text == "O" && btn[3].Text == "O" && btn[6].Enabled == true)
                    {
                        btn[6].Text = "O";
                        count++;
                        btn[6].Enabled = false;

                    }
                    else if (btn[0].Text == "O" && btn[6].Text == "O" && btn[3].Enabled == true)
                    {
                        btn[3].Text = "O";
                        count++;
                        btn[3].Enabled = false;

                    }
                    else if (btn[3].Text == "O" && btn[6].Text == "O" && btn[0].Enabled == true)
                    {
                        btn[0].Text = "O";
                        count++;
                        btn[0].Enabled = false;

                    }
                    else if (btn[7].Text == "O" && btn[4].Text == "O" && btn[1].Enabled == true)
                    {
                        btn[1].Text = "O";
                        count++;
                        btn[1].Enabled = false;

                    }
                    else if (btn[1].Text == "O" && btn[4].Text == "O" && btn[7].Enabled == true)
                    {
                        btn[7].Text = "O";
                        count++;
                        btn[7].Enabled = false;

                    }

                    else if (btn[2].Text == "O" && btn[5].Text == "O" && btn[8].Enabled == true)
                    {
                        btn[8].Text = "O";
                        count++;
                        btn[8].Enabled = false;

                    }
                    else if (btn[5].Text == "O" && btn[8].Text == "O" && btn[2].Enabled == true)
                    {
                        btn[2].Text = "O";
                        count++;
                        btn[2].Enabled = false;

                    }
                    else if (btn[2].Text == "O" && btn[8].Text == "O" && btn[5].Enabled == true)
                    {
                        btn[5].Text = "O";
                        count++;
                        btn[5].Enabled = false;

                    }
                    else if (btn[3].Text == "O" && btn[4].Text == "O" && btn[5].Enabled == true)
                    {
                        btn[5].Text = "O";
                        count++;
                        btn[5].Enabled = false;

                    }
                    else if (btn[4].Text == "O" && btn[5].Text == "O" && btn[3].Enabled == true)
                    {
                        btn[3].Text = "O";
                        count++;
                        btn[3].Enabled = false;

                    }

                    else if (btn[6].Text == "O" && btn[7].Text == "O" && btn[8].Enabled == true)
                    {
                        btn[8].Text = "O";
                        count++;
                        btn[8].Enabled = false;

                    }
                    else if (btn[7].Text == "O" && btn[8].Text == "O" && btn[6].Enabled == true)
                    {
                        btn[6].Text = "O";
                        count++;
                        btn[6].Enabled = false;

                    }
                    else if (btn[6].Text == "O" && btn[8].Text == "O" && btn[7].Enabled == true)
                    {
                        btn[7].Text = "O";
                        count++;
                        btn[7].Enabled = false;

                    }
                    else if (btn[2].Text == "O" && btn[4].Text == "O" && btn[6].Enabled == true)
                    {
                        btn[6].Text = "O";
                        count++;
                        btn[6].Enabled = false;

                    }
                    else if (btn[6].Text == "O" && btn[4].Text == "O" && btn[2].Enabled == true)
                    {
                        btn[2].Text = "O";
                        count++;
                        btn[2].Enabled = false;

                    }
                    else if (btn[6].Text == "X" && btn[8].Text == "X" && btn[7].Enabled == true)
                    {
                        btn[7].Text = "O";
                        count++;
                        btn[7].Enabled = false;

                    }
                    else if (btn[7].Text == "X" && btn[4].Text == "X" && btn[1].Enabled == true)
                    {
                        btn[1].Text = "O";
                        count++;
                        btn[1].Enabled = false;

                    }
                    else if (btn[4].Text == "X" && btn[5].Text == "X" && btn[3].Enabled == true)
                    {
                        btn[3].Text = "O";
                        count++;
                        btn[3].Enabled = false;
                    }
                    else if (btn[3].Text == "X" && btn[4].Text == "X" && btn[5].Enabled == true)
                    {
                        btn[5].Text = "O";
                        count++;
                        btn[5].Enabled = false;
                    }
                    else if (btn[8].Text == "X" && btn[4].Text == "X" && btn[0].Enabled == true)
                    {
                        btn[0].Text = "O";
                        count++;
                        btn[0].Enabled = false;
                    }
                    else if (btn[0].Text == "X" && btn[4].Text == "X" && btn[8].Enabled == true)
                    {
                        btn[8].Text = "O";
                        count++;
                        btn[8].Enabled = false;
                    }
                    else if (btn[2].Text == "X" && btn[8].Text == "X" && btn[5].Enabled == true)
                    {
                        btn[5].Text = "O";
                        count++;
                        btn[5].Enabled = false;
                    }
                    else if (btn[2].Text == "X" && btn[4].Text == "X" && btn[6].Enabled == true)
                    {
                        btn[6].Text = "O";
                        count++;
                        btn[6].Enabled = false;
                    }

                    else if (btn[2].Enabled == true)
                    {
                        btn[2].Text = "O";
                        count++;
                        btn[2].Enabled = false;
                    }
                    else if (btn[1].Enabled == true)
                    {
                        btn[1].Text = "O";
                        count++;
                        btn[1].Enabled = false;
                    }
                    else if (btn[3].Enabled == true)
                    {
                        btn[3].Text = "O";
                        count++;
                        btn[3].Enabled = false;
                    }
                    else if (btn[5].Enabled == true)
                    {
                        btn[5].Text = "O";
                        count++;
                        btn[5].Enabled = false;
                    }
                    else if (btn[7].Enabled == true)
                    {
                        btn[7].Text = "O";
                        count++;
                        btn[7].Enabled = false;
                    }


                    break;
                    

                }
            

        }

        void reset()
        {
            for (int i = 0; i < 9; i++)
            {
                btn[i].Enabled = true;
                btn[i].Text = "";
                count = 0;
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                btn[i] = new Button();
                btn[i].Width = 100;
                btn[i].Height = 100;
                btn[i].Click += new EventHandler(Form1_Click);
                flowLayoutPanel1.Controls.Add(btn[i]);
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            count++;
            if (count == 9)
            {
                boton.Text = "X";

                WhoWin();

                reset();

            }
            else if (count < 9)
            {
                boton.Text = "X";
                boton.Enabled = false;
                
                Machine();
                WhoWin();

            }
        }

        private void resete_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
