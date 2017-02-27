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
        static int counter;
        //static int stop = 0;
        static bool muteFlag;
        public static int check = 0;
        System.Media.SoundPlayer volume = new System.Media.SoundPlayer();
        public Form2()
        {
            
            muteFlag = true;
            InitializeComponent();
            volume.Stream = Hangman.Resource.Game_background;
            volume.PlayLooping();
            panel1.Visible = true;
            panel2.Visible = false;
            buttonPanel.Visible = false;
            radioGrade1.Visible = false;
            radioGrade2.Visible = false;
            radioGrade3.Visible = false;
        }


        private void Startbutton_Click(object sender, EventArgs e)
        {
            pictureBoxintro.Visible = false;
            //GameScreenForm frm = new GameScreenForm();
            //vol_stop();
            volume.Stream = Hangman.Resource.Game_Start_Tune;
            if(muteFlag)
            { 
            volume.PlayLooping();
            }
            Startbutton.Visible = false;
            radioGrade1.Visible = true;
            radioGrade2.Visible = true;
            radioGrade3.Visible = true;
        }

        
        private void Mutebutton_Click(object sender, EventArgs e)
        {
            counter++;
            if (muteFlag == true&&counter %2 != 0)
            {
                volume.Stop();
                muteFlag = false;
                //Mutebutton.BackgroundImage = Hangman.Resource.Sound_2_icon;
                Mutebutton.BackgroundImage = Hangman.Resource.sound_off;
            }
            else
            {
                volume.PlayLooping();
                muteFlag = true;
                Mutebutton.BackgroundImage = Hangman.Resource.sound_on;
            }
        }

        private void radioGrade1_CheckedChanged(object sender, EventArgs e)
        {
            check = 1;

            panel1.Visible = false;
            panel2.Visible = true;
            buttonPanel.Visible = true;
            UpdateScore();
            SelectGrade();
            radioGrade1.Checked = false;
        }

        private void EnableButtons()
        {
            List<Button> b = panel2.Controls.OfType<Button>().ToList();

            foreach (Button button in b)
            {
                button.Enabled = true;
                button.Visible = true;
            }
        }


        private void radioGrade2_CheckedChanged(object sender, EventArgs e)
        {
            check = 2;

            panel1.Visible = false;
            panel2.Visible = true;
            buttonPanel.Visible = true;
            UpdateScore();
            SelectGrade();
            radioGrade2.Checked = false;
        }

        private void radioGrade3_CheckedChanged(object sender, EventArgs e)
        {
            check = 3;

            panel1.Visible = false;
            panel2.Visible = true;
            buttonPanel.Visible = true;
            UpdateScore();
            SelectGrade();
            radioGrade3.Checked = false;
        }

        private int guessNext()
        {
            return new Random().Next(words.Length);
        }

        private void selectword()
        {

            // counter++;

            //if (GuessNumbers.Contains(guess))
            //{

            //}
            if (GuessNumbers.Count == words.Length)
            {
                DialogResult dlg2 = MessageBox.Show("You finished the Game!! \n \t\t Congratulations!!",
                 "Well Done!",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
                //MessageBox.Show("You finished the Game!! \n \t\t Congratulations!!");
            }

            guessIndex = guessNext();

            while (GuessNumbers.Contains(guessIndex))
            {
                guessIndex = guessNext();
            }
            GuessNumbers.Add(guessIndex);


            wrongguess = 0;
            Imagebox1.Image = hang_images[wrongguess];
            

            


            //do
            //{
            //    guessIndex = new Random().Next(words.Length);
            //   // GuessNumbers.Add(guessIndex);
            //}
            //while (GuessNumbers.Contains(guessIndex));

            //if (GuessNumbers.Contains(guessIndex))
            //{
            //    guessIndex = new Random().Next(words.Length);
            //    GuessNumbers.Add(guessIndex);
            //}


            //foreach (g in GuessNumbers)
            //{
            //    if (guess == GuessNumbers)
            //    {

            //    }
            //}




            //guessIndex = ();
            currentword1 = Convert.ToString(words[guessIndex]);
            currentword = currentword1.ToUpper();
            currentword.Replace(" ","");
            copycurrentword = currentword.ToCharArray()[0].ToString();
            Console.WriteLine(copycurrentword + " copycurrentword");
            //copycurrentword = "";
            for (int index = 1; index < currentword.Length; index++)
            {
                copycurrentword += "_";
            }

            // MessageBox.Show(Hints[guessIndex]);
            displaycopycurrentword();
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
            //  if (currentword.Contains(ans.Text))
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
                // MessageBox.Show("\t\t\tGame Over!! \n The Word was: " + currentword + "\n\t\tClick OK to GO to Main Menu");
                Thread.Sleep(2500);
                DialogResult dlg1 = MessageBox.Show("Game Over!! \n The Word was: " + currentword + "\nClick OK to GO to Main Menu",
                  "Well Done!",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
                
                Form2 fm2 = new Form2();
                //score = 0;
                this.Hide();
                fm2.Show();

            }
            if (copycurrentword.Equals(currentword))
            {
                score += 100;


                // UpdateScore();



                DialogResult dlg = MessageBox.Show("You Won!! \n Score: " + score + "\n The word was: " + currentword,
                  "Well Done!",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
                

               // MessageBox.Show("You Won!! \n Score: " + score + "\n The word was: "+ currentword);
               //label1.Text = "Score:" + Convert.ToString(score);
                UpdateScore();
                EnableButtons();
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
            // Form2 newForm = new Form2();
            string[] readText = Hangman.Resource.HangmanWords.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            words = new string[readText.Length / 3];
            Hints = new string[readText.Length / 3];
            int flag = 0;



            foreach (string s in readText)
            {
                string[] line = s.Split(',');
                if (check == 1 && line[2] == "1")
                {
                    words[flag] = line[0];
                    Hints[flag++] = line[1];
                }
                else if (check == 2 && line[2] == "2")
                {
                    words[flag] = line[0];
                    Hints[flag++] = line[1];
                }
                else if (check == 3 && line[2] == "3")
                {
                    words[flag] = line[0];
                    Hints[flag++] = line[1];
                }
            }
            selectword();
        }

        private void HintButton_Click(object sender, EventArgs e)
        {
            // SvgDocument img = SvgDocument.Open(Hangman.resources);
          //  MessageBox.Show(Hints[guessIndex]);
            DialogResult dlg3 = MessageBox.Show(Hints[guessIndex],
                 "Hints!",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
        }

        private void Return_Button_Click(object sender, EventArgs e)
        {
            GuessNumbers = new List<int>();
            score = 0;
            UpdateScore();
            muteFlag = true;
            panel1.Visible = true;
            Startbutton.Visible = true;
            panel2.Visible = false;
            buttonPanel.Visible = false;
            radioGrade1.Visible = false;
            radioGrade2.Visible = false;
            radioGrade3.Visible = false;
            EnableButtons();
        }

        //private void EnableButtons()
        //{
        //    button1.Enabled = true;
        //    button2.Enabled = true;
        //    button27.Enabled = true;
        //    button4.Enabled = true;
        //    button5.Enabled = true;
        //    button6.Enabled = true;
        //    button7.Enabled = true;
        //    button8.Enabled = true;
        //    button9.Enabled = true;
        //    button10.Enabled = true;
        //    button11.Enabled = true;
        //    button12.Enabled = true;
        //    button13.Enabled = true;
        //    button14.Enabled = true;
        //    button15.Enabled = true;
        //    button16.Enabled = true;
        //    button17.Enabled = true;
        //    button18.Enabled = true;
        //    button19.Enabled = true;
        //    button20.Enabled = true;
        //    button21.Enabled = true;
        //    button22.Enabled = true;
        //    button23.Enabled = true;
        //    button24.Enabled = true;
        //    button25.Enabled = true;
        //    button26.Enabled = true;
        //}

        private void Restart_button_Click(object sender, EventArgs e)
        {
            GuessNumbers = new List<int>();
            score = 0;
            UpdateScore();
            EnableButtons();
            SelectGrade();
        }

        private void label3_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(Hints[guessIndex]);
            DialogResult dlg3 = MessageBox.Show(Hints[guessIndex],
                 "Hints!",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
