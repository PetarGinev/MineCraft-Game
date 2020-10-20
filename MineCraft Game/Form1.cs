using System;
using System.Drawing;
using System.Windows.Forms;

namespace MineCraft_Game
{
    public partial class MineCraft : Form
    {
        public Random Randomizer = new Random();

        public int num;

        public int[] generatedNums = new int[9];

        private bool newGame = false;
 
        public MineCraft()
        {
            InitializeComponent();
            GenerateMines();
            newGame = true;       
        } 

        #region Mines

        private void mine1_Click(object sender, EventArgs e)
        {
            if (newGame == true)
            {
                mine1.Text = generatedNums[0].ToString();          

                if (mine1.Text == "0")
                {                   
                    mine1.ForeColor = System.Drawing.Color.Green;
                    mine1.BackColor = System.Drawing.Color.Green;
                }
                else
                {
                    pictureBoxBomb1.Visible = true;
                }

                RemainingLifes();
                ZeroCount();
                GameResults();
            }
        }
        
        private void mine2_Click(object sender, EventArgs e)
        {
            if (newGame == true)
            {
                mine2.Text = generatedNums[1].ToString();

                if (mine2.Text == "0")
                {
                    mine2.ForeColor = System.Drawing.Color.Green;
                    mine2.BackColor = System.Drawing.Color.Green;
                }
                else
                {
                    pictureBoxBomb2.Visible = true;
                }

                RemainingLifes();
                ZeroCount();
                GameResults();              
            }
        }

        private void mine3_Click(object sender, EventArgs e)
        {
            if (newGame == true)
            {
                mine3.Text = generatedNums[2].ToString();

                if (mine3.Text == "0")
                {
                    mine3.ForeColor = System.Drawing.Color.Green;
                    mine3.BackColor = System.Drawing.Color.Green;
                }
                else
                {
                    pictureBoxBomb3.Visible = true;
                }

                RemainingLifes();
                ZeroCount();
                GameResults();                
            }
        }

        private void mine4_Click(object sender, EventArgs e)
        {
            if (newGame == true)
            {
                mine4.Text = generatedNums[3].ToString();

                if (mine4.Text == "0")
                {
                    mine4.ForeColor = System.Drawing.Color.Green;
                    mine4.BackColor = System.Drawing.Color.Green;
                }
                else
                {
                    pictureBoxBomb4.Visible = true;
                }

                RemainingLifes();
                ZeroCount();
                GameResults();                
            }
        }

        private void mine5_Click(object sender, EventArgs e)
        {
            if (newGame == true)
            {
                mine5.Text = generatedNums[4].ToString();

                if (mine5.Text == "0")
                {
                    mine5.ForeColor = System.Drawing.Color.Green;
                    mine5.BackColor = System.Drawing.Color.Green;
                }
                else
                {
                    pictureBoxBomb5.Visible = true;
                }

                RemainingLifes();
                ZeroCount();
                GameResults();               
            }
        }

        private void mine6_Click(object sender, EventArgs e)
        {
            if (newGame == true)
            {
                mine6.Text = generatedNums[5].ToString();

                if (mine6.Text == "0")
                {
                    mine6.ForeColor = System.Drawing.Color.Green;
                    mine6.BackColor = System.Drawing.Color.Green;
                }
                else
                {
                    pictureBoxBomb6.Visible = true;
                }

                RemainingLifes();
                ZeroCount();
                GameResults();               
            }
        }

    

        private void mine7_Click(object sender, EventArgs e)
        {
            if (newGame == true)
            {
                mine7.Text = generatedNums[6].ToString();

                if (mine7.Text == "0")
                {
                    mine7.ForeColor = System.Drawing.Color.Green;
                    mine7.BackColor = System.Drawing.Color.Green;
                }
                else
                {
                    pictureBoxBomb7.Visible = true;
                }

                RemainingLifes();
                ZeroCount();
                GameResults();
            }
        }

        private void mine8_Click(object sender, EventArgs e)
        {
            if (newGame == true)
            {
                mine8.Text = generatedNums[7].ToString();

                if (mine8.Text == "0")
                {
                    mine8.ForeColor = System.Drawing.Color.Green;
                    mine8.BackColor = System.Drawing.Color.Green;
                }
                else
                {
                    pictureBoxBomb8.Visible = true;
                }

                RemainingLifes();
                ZeroCount();
                GameResults();
            }
        }

        private void mine9_Click(object sender, EventArgs e)
        {      
                if (newGame == true)
                {
                    mine9.Text = generatedNums[8].ToString();

                    if (mine9.Text == "0")
                    {
                        mine9.ForeColor = System.Drawing.Color.Green;
                        mine9.BackColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        pictureBoxBomb9.Visible = true;
                    }

                    RemainingLifes();
                    ZeroCount();
                    GameResults();
                }  
        }
        #endregion



        #region Functions

        private void GenerateMines()
        {
            int mineCounter = 0;

            for (int i = 0; i < 9; i++)
            {
                if (mineCounter < 3)
                {
                    num = Randomizer.Next(0, 2);

                    if (num == 1)
                    {
                        generatedNums[i] = num;
                        mineCounter += 1;
                    }

                    else
                    {
                        generatedNums[i] = 0;
                    }
                }
            }
// Checks if mines are less than 3 and if they are less changes the first 0 with 1 (We need exactly 3 mines): 

            while (mineCounter < 3)
            {
                for (int i = 0; i < generatedNums.Length; i++)
                {
                    if (generatedNums[i] == 0)
                    {
                        generatedNums[i] = 1;
                        mineCounter += 1;
                        break;
                    }
                }
            }
        }
        private int RemainingLifes()
        {
            
            int remainingLifes = 3;          
             
            if (mine1.Text == "1")
            {
                remainingLifes -= 1;
            }
            if (mine2.Text == "1")
            {
                remainingLifes -= 1;
            }
            if (mine3.Text == "1")
            {
                remainingLifes -= 1;
            }
            if (mine4.Text == "1")
            {
                remainingLifes -= 1;
            }
            if (mine5.Text == "1")
            {
                remainingLifes -= 1;
            }
            if (mine6.Text == "1")
            {
                remainingLifes -= 1;
            }
            if (mine7.Text == "1")
            {
                remainingLifes -= 1;
            }
            if (mine8.Text == "1")
            {
                remainingLifes -= 1;
            }
            if (mine9.Text == "1")
            {
                remainingLifes -= 1;
            }              
                  
            return int.Parse(labelRemainingLife.Text = remainingLifes.ToString());
        }

        private int ZeroCount()
        {

            int zeroCount = 0;

            if (mine1.Text == "0")
            {
                zeroCount += 1;
            }
            if (mine2.Text == "0")
            {
                zeroCount += 1;
            }
            if (mine3.Text == "0")
            {
                zeroCount += 1;
            }
            if (mine4.Text == "0")
            {
                zeroCount += 1;
            }
            if (mine5.Text == "0")
            {
                zeroCount += 1;
            }
            if (mine6.Text == "0")
            {
                zeroCount += 1;
            }
            if (mine7.Text == "0")
            {
                zeroCount += 1;
            }
            if (mine8.Text == "0")
            {
                zeroCount += 1;
            }
            if (mine9.Text == "0")
            {
                zeroCount += 1;
            }
            return zeroCount;
        }
        private void GameResults()
        {
            if (RemainingLifes() == 0)
            {
                MessageBox.Show("Game Over!");
                newGame = false;
            }
            else if (ZeroCount() == 6)
            {
                MessageBox.Show("You Won!");          
                newGame = false;
            }
        }

        private void Clear()
        {
            mine1.ForeColor = default(Color);
            mine2.ForeColor = default(Color);
            mine3.ForeColor = default(Color);
            mine4.ForeColor = default(Color);
            mine5.ForeColor = default(Color);
            mine6.ForeColor = default(Color);
            mine7.ForeColor = default(Color);
            mine8.ForeColor = default(Color);
            mine9.ForeColor = default(Color);

            mine1.ResetBackColor();
            mine1.UseVisualStyleBackColor = true;            
            mine2.ResetBackColor();
            mine2.UseVisualStyleBackColor = true;            
            mine3.ResetBackColor();
            mine3.UseVisualStyleBackColor = true;            
            mine4.ResetBackColor();
            mine4.UseVisualStyleBackColor = true;            
            mine5.ResetBackColor();
            mine5.UseVisualStyleBackColor = true;            
            mine6.ResetBackColor();
            mine6.UseVisualStyleBackColor = true;            
            mine7.ResetBackColor();
            mine7.UseVisualStyleBackColor = true;            
            mine8.ResetBackColor();
            mine8.UseVisualStyleBackColor = true;            
            mine9.ResetBackColor();
            mine9.UseVisualStyleBackColor = true;

            pictureBoxBomb1.Visible = false;
            pictureBoxBomb2.Visible = false;
            pictureBoxBomb3.Visible = false;
            pictureBoxBomb4.Visible = false;
            pictureBoxBomb5.Visible = false;
            pictureBoxBomb6.Visible = false;
            pictureBoxBomb7.Visible = false;
            pictureBoxBomb8.Visible = false;
            pictureBoxBomb9.Visible = false;

            mine1.Text = "?";
            mine2.Text = "?";
            mine3.Text = "?";
            mine4.Text = "?";
            mine5.Text = "?";
            mine6.Text = "?";
            mine7.Text = "?";
            mine8.Text = "?";
            mine9.Text = "?";
        }

        #endregion

        private void newGameButton_Click(object sender, EventArgs e)
        {
            newGame = true;            
            GenerateMines();
            Clear();
            RemainingLifes();
        }
    }      
}

