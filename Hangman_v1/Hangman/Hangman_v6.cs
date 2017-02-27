using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Svg;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Hangman
{
    public partial class Form2 : Form, Interface1
    {

        private Image[] hang_images = { Hangman.Resource.hangman1, Hangman.Resource.hangman2, Hangman.Resource.hangman3,
                                        Hangman.Resource.hangman4,Hangman.Resource.hangman5,
                                        Hangman.Resource.hangman6,Hangman.Resource.hangman7, Hangman.Resource.hangman8};
        private int wrongguess = 0;
        private string currentword = "";
        private string currentword1 = "";
        private string copycurrentword = "";
        private string[] words;
        private string[] Hints;
        private int guessIndex;
        List<int> GuessNumbers = new List<int>();
        private int score = 0;
        static private int Highscore = 0;
        static bool muteFlag=true;
        public static int Gradecheck = 0;
        private int wordCount = 0;
        public static int Categorycheck = 0;
        System.Media.SoundPlayer volume = new System.Media.SoundPlayer();
        string[] readText;
        public Form2()
        {
            readText = Hangman.Resource.HangmanWords.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            wordCount = 0;
            InitializeComponent();
            volume.Stream = Hangman.Resource.Game_background;
            volume.PlayLooping();            
            Visibility_start();
            SelectButton.Visible = false;
            hintBtn.Text = "Hint";
        }

        public void RadioUncheck()
        {
            radioGrade1.Checked = false;
            radioGrade2.Checked = false;
            radioGrade3.Checked = false;
            btncategory1.Checked = false;
            btncategory2.Checked = false;
            btncategory3.Checked = false;            
        }

        public void Visibility_start()
        {
            if (muteFlag == true)
            {
                volume.Stream = Hangman.Resource.Game_background;
                volume.PlayLooping();
            }
            panel1.Visible = true;
            pictureBoxintro.Visible = true;
            Startbutton.Visible = true;
            panelcategory.Visible = false;
            pictureBoxcategory.Visible = false;
            pictureBoxgrade.Visible = false;
            picturewhilegrade.Visible = false;
            picturewhilecategory.Visible = false;
            labelcompanyname.Visible = true;
            radioGrade1.Visible = false;
            radioGrade2.Visible = false;
            radioGrade3.Visible = false;
            btncategory1.Visible = false;
            btncategory2.Visible = false;
            btncategory3.Visible = false;
            panel2.Visible = false;
            buttonPanel.Visible = false;
            RadioUncheck();
        }

        public void Visibility_radio1()
        {
            panel1.Visible = true;
            pictureBoxintro.Visible = false;
            Startbutton.Visible = false;
            panelcategory.Visible = true;
            pictureBoxcategory.Visible = false;
            pictureBoxgrade.Visible = true;
            picturewhilegrade.Visible = true;
            picturewhilecategory.Visible = false;
            labelcompanyname.Visible = true;
            radioGrade1.Visible = true;
            radioGrade2.Visible = true;
            radioGrade3.Visible = true;
            btncategory1.Visible = false;
            btncategory2.Visible = false;
            btncategory3.Visible = false;
            panel2.Visible = false;
            buttonPanel.Visible = false;
            RadioUncheck();
        }

        public void Visibility_radio2()
        {
            panel1.Visible = true;
            pictureBoxintro.Visible = false;
            Startbutton.Visible = false;
            pictureBoxcategory.Visible = true;
            pictureBoxgrade.Visible = false;
            picturewhilegrade.Visible = false;
            picturewhilecategory.Visible = true;
            labelcompanyname.Visible = true;
            radioGrade1.Visible = false;
            radioGrade2.Visible = false;
            radioGrade3.Visible = false;
            btncategory1.Visible = true;
            btncategory2.Visible = true;
            btncategory3.Visible = true;
            panel2.Visible = false;
            buttonPanel.Visible = false;
            RadioUncheck();
        }

        public void Visibility_game()
        {
            hintBtn.Text = "Hint";
            panel1.Visible = false;
            pictureBoxintro.Visible = false;
            Startbutton.Visible = false;
            panelcategory.Visible = false;
            pictureBoxcategory.Visible = false;
            pictureBoxgrade.Visible = false;
            picturewhilegrade.Visible = false;
            picturewhilecategory.Visible = false;
            labelcompanyname.Visible = true;
            radioGrade1.Visible = false;
            radioGrade2.Visible = false;
            radioGrade3.Visible = false;
            btncategory1.Visible = false;
            btncategory2.Visible = false;
            btncategory3.Visible = false;
            panel2.Visible = true;
            buttonPanel.Visible = true;
            RadioUncheck();
        }


        private void Startbutton_Click(object sender, EventArgs e)
        {
            wordCount = 0;
            volume.Stream = Hangman.Resource.Game_Start_Tune;
            if(muteFlag)
            { 
                volume.PlayLooping();
            }
            Visibility_radio1(); 
        }

  
        private void EnableButtons(int i)
        {
            List<Button> b = panel2.Controls.OfType<Button>().ToList();
            if (i==1)
            {
                foreach (Button button in b)
                {
                    button.Enabled = true;
                    button.Visible = false;
                }
            }
            else {            
            foreach (Button button in b)
            {
                button.Enabled = true;
                button.Visible = true;
            }
            }
        }

        private int guessNext()
        {
            return new Random().Next(wordCount);
        }

        private void selectword()
        {
            try
            {
                if (GuessNumbers.Count == wordCount)
                {
                    throw new Exception();
                }
                guessIndex = guessNext();
                while (GuessNumbers.Contains(guessIndex))
                {
                    guessIndex = guessNext();
                }
                GuessNumbers.Add(guessIndex);
                wrongguess = 0;
                Imagebox1.Image = hang_images[wrongguess];
                currentword1 = Convert.ToString(words[guessIndex]);
                currentword = currentword1.ToUpper();
                //currentword = "South Africa";
                currentword = currentword.Replace(" ", "");
                copycurrentword = currentword.ToCharArray()[0].ToString();
                Console.WriteLine(copycurrentword + " copycurrentword");
                for (int index = 1; index < currentword.Length; index++)
                {
                    copycurrentword += "_";
                }
                displaycopycurrentword();
            }
            catch
            {
                wordCount = 0;
                GuessNumbers = new List<int>();
                DialogResult dlg2 = MessageBox.Show("Congratulations!!\nYou have successfully completed the level!! \n",
                                 "Well Done!! ",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
                Visibility_radio1();
            }
        }

        private void displaycopycurrentword()
        {
            labelshowword.Text = "";
            for (int index = 0; index < copycurrentword.Length; index++)
            {
                labelshowword.Text += copycurrentword.Substring(index, 1);
                labelshowword.Text += " ";
            }
        }
        
        private void GuessClick(object sender, EventArgs e)
        {
            Button ans = sender as Button;
            ans.Enabled = false;
            ans.Visible = false;
            string currentWordWithoutFirst = currentword.Substring(1);
            if (currentWordWithoutFirst.Contains(ans.Text))
            {
                char[] temp = copycurrentword.ToCharArray();
                char[] find = currentword.ToCharArray();
                char guesschar = ans.Text.ElementAt(0);
                for (int index = 0; index < find.Length; index++)
                {
                    if (find[index] == guesschar)
                    {
                        temp[index] = guesschar;
                    }
                }
                copycurrentword = new string(temp);
                displaycopycurrentword();
            }
            else
            {
                wrongguess++;
            }

            if (wrongguess < hang_images.Length -1)
            {
                Imagebox1.Image = hang_images[wrongguess];
            }
            else
            {
                Imagebox1.Image = hang_images[wrongguess];
                if (muteFlag == true)
                {
                    volume.Stream = Hangman.Resource.Game_end_theme;
                    volume.Play();
                }
                MessageBox.Show("Game Over!! \n The Word was: " + currentword, "Well Done!",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);

                hintBtn.Text = "Quit";
                EnableButtons(1);
            }
            if (copycurrentword.Equals(currentword))
            {
                score += 100;
                DialogResult dlg = MessageBox.Show("You Won!! \n Score: " + score + "\n The word was: " + currentword,
                                                     "Well Done!",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information);
                UpdateScore();
                EnableButtons(2);
                selectword();
            }
        }

        private void UpdateScore()
        {
            if (score >= Highscore)
            {
                Highscore = score;
            }
            label1.Text = "Score: " + Convert.ToString(score);
            label_highscore.Text = "Highscore: " + Highscore;
        }

        private void SelectGrade()
        {            
            words = new string[readText.Length];
            Hints = new string[readText.Length];
            int flag = 0;
            foreach (string s in readText)
            {
                string[] line = s.Split(',');

                if (Gradecheck == 1 && line[2] == "1" && Categorycheck == 4 && line[1] == "Fruits")
                {
                    wordCount++;
                    words[flag] = line[0];
                    Hints[flag++] = line[3];
                }
                if (Gradecheck == 1 && line[2] == "1" && Categorycheck == 5 && line[1] == "Animals")
                {
                    wordCount++;
                    words[flag] = line[0];
                    Hints[flag++] = line[3];
                }
                if (Gradecheck == 1 && line[2] == "1" && Categorycheck == 6 && line[1] == "Places")
                {
                    wordCount++;
                    words[flag] = line[0];
                    Hints[flag++] = line[3];
                }

                if (Gradecheck == 2 && line[2] == "2" && Categorycheck == 4 && line[1] == "Fruits")
                {
                    wordCount++;
                    words[flag] = line[0];
                    Hints[flag++] = line[3];
                }

                if (Gradecheck == 2 && line[2] == "2" && Categorycheck == 5 && line[1] == "Animals")
                {
                    wordCount++;
                    words[flag] = line[0];
                    Hints[flag++] = line[3];
                }

                if (Gradecheck == 2 && line[2] == "2" && Categorycheck == 6 && line[1] == "Places")
                {
                    wordCount++;
                    words[flag] = line[0];
                    Hints[flag++] = line[3];
                }


                if (Gradecheck == 3 && line[2] == "3" && Categorycheck == 4 && line[1] == "Fruits")
                {
                    wordCount++;
                    words[flag] = line[0];
                    Hints[flag++] = line[3];
                }

                if (Gradecheck == 3 && line[2] == "3" && Categorycheck == 5 && line[1] == "Animals")
                {
                    wordCount++;
                    words[flag] = line[0];
                    Hints[flag++] = line[3];
                }

                if (Gradecheck == 3 && line[2] == "3" && Categorycheck == 6 && line[1] == "Places")
                {
                    wordCount++;
                    words[flag] = line[0];
                    Hints[flag++] = line[3];
                }
                
            }
            selectword();
        }

        private void HintButton_Click(object sender, EventArgs e)
        {
            Button b1 = sender as Button;
            if (b1.Text == "Quit")
            {
                Application.Exit();
            }
            else
            {
                DialogResult dlg3 = MessageBox.Show(Hints[guessIndex],
                                                 "Hints!");
            }
        }

        private void Return_Button_Click(object sender, EventArgs e)
        {
            GuessNumbers = new List<int>();
            score = 0;
            wordCount = 0;
            UpdateScore();
            Visibility_start();
            EnableButtons(2);
        }
        
        private void Restart_button_Click(object sender, EventArgs e)
        {
            GuessNumbers = new List<int>();
            score = 0;
            UpdateScore();
            EnableButtons(2);
            SelectGrade();
        }

        private void label3_Click(object sender, EventArgs e)
        {    
            DialogResult dlg3 = MessageBox.Show(Hints[guessIndex],
                                             "Hints!",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);
        }

        private void radioGrade1_CheckedChanged(object sender, EventArgs e)
        {
            Gradecheck = 1;
            wordCount = 0;
            Visibility_radio2();
        }

        private void radioGrade2_CheckedChanged(object sender, EventArgs e)
        {
            Gradecheck = 2;
            wordCount = 0;
            Visibility_radio2();
        }

        private void radioGrade3_CheckedChanged(object sender, EventArgs e)
        {
            Gradecheck = 3;
            wordCount = 0;
            Visibility_radio2();
        }

        private void btncategory1_CheckedChanged(object sender, EventArgs e)
        {
            Categorycheck = 4;
            Visibility_game();
            UpdateScore();
            wordCount = 0;
            SelectGrade();
        }

        private void btncategory2_CheckedChanged(object sender, EventArgs e)
        {
            Categorycheck = 5;
            Visibility_game();
            UpdateScore();
            wordCount = 0;
            SelectGrade();
        }

        private void btncategory3_CheckedChanged(object sender, EventArgs e)
        {
            Categorycheck = 6;
            Visibility_game();
            UpdateScore();
            wordCount = 0;
            SelectGrade();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            wordCount = 0;
            panelcategory.Visible = false;
            radioGrade1.Checked = false;
            radioGrade2.Checked = false;
            radioGrade3.Checked = false;
            btncategory1.Checked = false;
            btncategory2.Checked = false;
            btncategory3.Checked = false;
            SelectButton.Visible = false;
            panel1.Visible = false;
            panel2.Visible = true;
            buttonPanel.Visible = true;
            UpdateScore();
            SelectGrade();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (muteFlag == true)
            {
                volume.Stop();
                muteFlag = false;
                pictureBox1.BackgroundImage = Hangman.Resource.sound_off;
            }
            else
            {
                volume.PlayLooping();
                muteFlag = true;
                pictureBox1.BackgroundImage = Hangman.Resource.sound_on;
            }
        }
    }
}
