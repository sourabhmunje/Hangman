namespace Hangman
{
    partial class Form2
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
            this.Startbutton = new System.Windows.Forms.Button();
            this.Mutebutton = new System.Windows.Forms.Button();
            this.radioGrade3 = new System.Windows.Forms.RadioButton();
            this.radioGrade2 = new System.Windows.Forms.RadioButton();
            this.radioGrade1 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxintro = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_highscore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Imagebox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelshowword = new System.Windows.Forms.Label();
            this.button26 = new System.Windows.Forms.Button();
            this.Return_Button = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.lableresult = new System.Windows.Forms.Label();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.restartBtn = new System.Windows.Forms.Button();
            this.hintBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxintro)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagebox1)).BeginInit();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Startbutton
            // 
            this.Startbutton.BackColor = System.Drawing.Color.Transparent;
            this.Startbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Startbutton.Location = new System.Drawing.Point(214, 365);
            this.Startbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(75, 23);
            this.Startbutton.TabIndex = 0;
            this.Startbutton.Text = "Start Game";
            this.Startbutton.UseVisualStyleBackColor = false;
            this.Startbutton.Click += new System.EventHandler(this.Startbutton_Click);
            // 
            // Mutebutton
            // 
            this.Mutebutton.BackColor = System.Drawing.Color.Silver;
            this.Mutebutton.BackgroundImage = global::Hangman.Resource.sound_on;
            this.Mutebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Mutebutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Mutebutton.Location = new System.Drawing.Point(571, 2);
            this.Mutebutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mutebutton.Name = "Mutebutton";
            this.Mutebutton.Size = new System.Drawing.Size(79, 60);
            this.Mutebutton.TabIndex = 1;
            this.Mutebutton.UseCompatibleTextRendering = true;
            this.Mutebutton.UseVisualStyleBackColor = false;
            this.Mutebutton.Click += new System.EventHandler(this.Mutebutton_Click);
            // 
            // radioGrade3
            // 
            this.radioGrade3.AutoSize = true;
            this.radioGrade3.BackColor = System.Drawing.Color.Transparent;
            this.radioGrade3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioGrade3.ForeColor = System.Drawing.Color.Chocolate;
            this.radioGrade3.Location = new System.Drawing.Point(168, 117);
            this.radioGrade3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioGrade3.Name = "radioGrade3";
            this.radioGrade3.Size = new System.Drawing.Size(106, 21);
            this.radioGrade3.TabIndex = 39;
            this.radioGrade3.TabStop = true;
            this.radioGrade3.Text = "Third Grade";
            this.radioGrade3.UseVisualStyleBackColor = false;
            this.radioGrade3.CheckedChanged += new System.EventHandler(this.radioGrade3_CheckedChanged);
            // 
            // radioGrade2
            // 
            this.radioGrade2.AutoSize = true;
            this.radioGrade2.BackColor = System.Drawing.Color.Transparent;
            this.radioGrade2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioGrade2.ForeColor = System.Drawing.Color.Chocolate;
            this.radioGrade2.Location = new System.Drawing.Point(168, 91);
            this.radioGrade2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioGrade2.Name = "radioGrade2";
            this.radioGrade2.Size = new System.Drawing.Size(121, 21);
            this.radioGrade2.TabIndex = 38;
            this.radioGrade2.TabStop = true;
            this.radioGrade2.Text = "Second Grade";
            this.radioGrade2.UseVisualStyleBackColor = false;
            this.radioGrade2.CheckedChanged += new System.EventHandler(this.radioGrade2_CheckedChanged);
            // 
            // radioGrade1
            // 
            this.radioGrade1.AutoSize = true;
            this.radioGrade1.BackColor = System.Drawing.Color.Transparent;
            this.radioGrade1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioGrade1.ForeColor = System.Drawing.Color.Chocolate;
            this.radioGrade1.Location = new System.Drawing.Point(171, 62);
            this.radioGrade1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioGrade1.Name = "radioGrade1";
            this.radioGrade1.Size = new System.Drawing.Size(100, 21);
            this.radioGrade1.TabIndex = 37;
            this.radioGrade1.TabStop = true;
            this.radioGrade1.Text = "First Grade";
            this.radioGrade1.UseVisualStyleBackColor = false;
            this.radioGrade1.CheckedChanged += new System.EventHandler(this.radioGrade1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.AutoScroll = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.pictureBoxintro);
            this.panel1.Controls.Add(this.radioGrade1);
            this.panel1.Controls.Add(this.radioGrade3);
            this.panel1.Controls.Add(this.Startbutton);
            this.panel1.Controls.Add(this.radioGrade2);
            this.panel1.Location = new System.Drawing.Point(10, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 433);
            this.panel1.TabIndex = 40;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBoxintro
            // 
            this.pictureBoxintro.Image = global::Hangman.Resource.Inspiration_quote;
            this.pictureBoxintro.Location = new System.Drawing.Point(41, -18);
            this.pictureBoxintro.Name = "pictureBoxintro";
            this.pictureBoxintro.Size = new System.Drawing.Size(379, 358);
            this.pictureBoxintro.TabIndex = 40;
            this.pictureBoxintro.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label_highscore);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Imagebox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labelshowword);
            this.panel2.Controls.Add(this.button26);
            this.panel2.Controls.Add(this.Return_Button);
            this.panel2.Controls.Add(this.button27);
            this.panel2.Controls.Add(this.button22);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button23);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button24);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button25);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button20);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button21);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button16);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button17);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button18);
            this.panel2.Controls.Add(this.button11);
            this.panel2.Controls.Add(this.button19);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.button12);
            this.panel2.Controls.Add(this.button15);
            this.panel2.Controls.Add(this.button13);
            this.panel2.Controls.Add(this.button14);
            this.panel2.Location = new System.Drawing.Point(53, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(489, 507);
            this.panel2.TabIndex = 41;
            // 
            // label_highscore
            // 
            this.label_highscore.BackColor = System.Drawing.Color.Transparent;
            this.label_highscore.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_highscore.Location = new System.Drawing.Point(146, 29);
            this.label_highscore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_highscore.Name = "label_highscore";
            this.label_highscore.Size = new System.Drawing.Size(231, 28);
            this.label_highscore.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 74;
            // 
            // Imagebox1
            // 
            this.Imagebox1.Image = global::Hangman.Resource.hangman1;
            this.Imagebox1.Location = new System.Drawing.Point(38, 70);
            this.Imagebox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Imagebox1.Name = "Imagebox1";
            this.Imagebox1.Size = new System.Drawing.Size(240, 194);
            this.Imagebox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Imagebox1.TabIndex = 41;
            this.Imagebox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 28);
            this.label1.TabIndex = 73;
            // 
            // labelshowword
            // 
            this.labelshowword.BackColor = System.Drawing.Color.Transparent;
            this.labelshowword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelshowword.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelshowword.Location = new System.Drawing.Point(38, 305);
            this.labelshowword.Name = "labelshowword";
            this.labelshowword.Size = new System.Drawing.Size(363, 35);
            this.labelshowword.TabIndex = 44;
            // 
            // button26
            // 
            this.button26.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button26.Location = new System.Drawing.Point(256, 457);
            this.button26.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(29, 41);
            this.button26.TabIndex = 70;
            this.button26.Text = "Z";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.GuessClick);
            // 
            // Return_Button
            // 
            this.Return_Button.AccessibleDescription = "HintButton";
            this.Return_Button.AccessibleName = "HintButton";
            this.Return_Button.BackColor = System.Drawing.Color.Black;
            this.Return_Button.BackgroundImage = global::Hangman.Resource.button_wood;
            this.Return_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Return_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Return_Button.FlatAppearance.BorderSize = 0;
            this.Return_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Return_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Return_Button.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return_Button.ForeColor = System.Drawing.Color.Yellow;
            this.Return_Button.Location = new System.Drawing.Point(376, 18);
            this.Return_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Return_Button.Name = "Return_Button";
            this.Return_Button.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Return_Button.Size = new System.Drawing.Size(95, 39);
            this.Return_Button.TabIndex = 72;
            this.Return_Button.Text = "Back";
            this.Return_Button.UseVisualStyleBackColor = false;
            this.Return_Button.Click += new System.EventHandler(this.Return_Button_Click);
            // 
            // button27
            // 
            this.button27.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button27.Location = new System.Drawing.Point(115, 363);
            this.button27.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(29, 41);
            this.button27.TabIndex = 69;
            this.button27.Text = "C";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.GuessClick);
            // 
            // button22
            // 
            this.button22.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.Location = new System.Drawing.Point(71, 457);
            this.button22.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(29, 41);
            this.button22.TabIndex = 68;
            this.button22.Text = "V";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.GuessClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(24, 363);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 41);
            this.button1.TabIndex = 42;
            this.button1.Text = "A";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GuessClick);
            // 
            // button23
            // 
            this.button23.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.Location = new System.Drawing.Point(115, 457);
            this.button23.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(29, 41);
            this.button23.TabIndex = 67;
            this.button23.Text = "W";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.GuessClick);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(71, 363);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 41);
            this.button2.TabIndex = 46;
            this.button2.Text = "B";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.GuessClick);
            // 
            // button24
            // 
            this.button24.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.Location = new System.Drawing.Point(160, 457);
            this.button24.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(29, 41);
            this.button24.TabIndex = 66;
            this.button24.Text = "X";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.GuessClick);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(212, 363);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(29, 41);
            this.button5.TabIndex = 47;
            this.button5.Text = "E";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.GuessClick);
            // 
            // button25
            // 
            this.button25.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.Location = new System.Drawing.Point(212, 457);
            this.button25.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(29, 41);
            this.button25.TabIndex = 65;
            this.button25.Text = "Y";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.GuessClick);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(160, 363);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(29, 41);
            this.button4.TabIndex = 48;
            this.button4.Text = "D";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.GuessClick);
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(432, 410);
            this.button20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(29, 41);
            this.button20.TabIndex = 64;
            this.button20.Text = "T";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.GuessClick);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(301, 363);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(29, 41);
            this.button7.TabIndex = 49;
            this.button7.Text = "G";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.GuessClick);
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Location = new System.Drawing.Point(24, 457);
            this.button21.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(29, 41);
            this.button21.TabIndex = 63;
            this.button21.Text = "U";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.GuessClick);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(256, 363);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(29, 41);
            this.button6.TabIndex = 50;
            this.button6.Text = "F";
            this.button6.UseCompatibleTextRendering = true;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.GuessClick);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(256, 410);
            this.button16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(29, 41);
            this.button16.TabIndex = 62;
            this.button16.Text = "P";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.GuessClick);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(387, 363);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(29, 41);
            this.button9.TabIndex = 51;
            this.button9.Text = "I";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.GuessClick);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(301, 410);
            this.button17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(29, 41);
            this.button17.TabIndex = 61;
            this.button17.Text = "Q";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.GuessClick);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(348, 363);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(29, 41);
            this.button8.TabIndex = 52;
            this.button8.Text = "H";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.GuessClick);
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(348, 410);
            this.button18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(29, 41);
            this.button18.TabIndex = 60;
            this.button18.Text = "R";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.GuessClick);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(24, 410);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(29, 41);
            this.button11.TabIndex = 53;
            this.button11.Text = "K";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.GuessClick);
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(387, 410);
            this.button19.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(29, 41);
            this.button19.TabIndex = 59;
            this.button19.Text = "S";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.GuessClick);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(432, 363);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(29, 41);
            this.button10.TabIndex = 54;
            this.button10.Text = "J";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.GuessClick);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(71, 410);
            this.button12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(29, 41);
            this.button12.TabIndex = 58;
            this.button12.Text = "L";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.GuessClick);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(212, 410);
            this.button15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(29, 41);
            this.button15.TabIndex = 55;
            this.button15.Text = "O";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.GuessClick);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(115, 410);
            this.button13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(29, 41);
            this.button13.TabIndex = 57;
            this.button13.Text = "M";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.GuessClick);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(160, 410);
            this.button14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(29, 41);
            this.button14.TabIndex = 56;
            this.button14.Text = "N";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.GuessClick);
            // 
            // lableresult
            // 
            this.lableresult.AutoSize = true;
            this.lableresult.Location = new System.Drawing.Point(496, 47);
            this.lableresult.Name = "lableresult";
            this.lableresult.Size = new System.Drawing.Size(0, 17);
            this.lableresult.TabIndex = 43;
            // 
            // buttonPanel
            // 
            this.buttonPanel.BackColor = System.Drawing.Color.Transparent;
            this.buttonPanel.Controls.Add(this.restartBtn);
            this.buttonPanel.Controls.Add(this.hintBtn);
            this.buttonPanel.Location = new System.Drawing.Point(520, 286);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(111, 120);
            this.buttonPanel.TabIndex = 44;
            // 
            // restartBtn
            // 
            this.restartBtn.BackgroundImage = global::Hangman.Resource.button_wood;
            this.restartBtn.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartBtn.ForeColor = System.Drawing.Color.Yellow;
            this.restartBtn.Location = new System.Drawing.Point(20, 60);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(75, 29);
            this.restartBtn.TabIndex = 1;
            this.restartBtn.Text = "Restart";
            this.restartBtn.UseVisualStyleBackColor = true;
            this.restartBtn.MouseCaptureChanged += new System.EventHandler(this.Restart_button_Click);
            // 
            // hintBtn
            // 
            this.hintBtn.BackColor = System.Drawing.Color.White;
            this.hintBtn.BackgroundImage = global::Hangman.Resource.button_wood;
            this.hintBtn.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hintBtn.ForeColor = System.Drawing.Color.Yellow;
            this.hintBtn.Location = new System.Drawing.Point(20, 27);
            this.hintBtn.Name = "hintBtn";
            this.hintBtn.Size = new System.Drawing.Size(75, 29);
            this.hintBtn.TabIndex = 0;
            this.hintBtn.Text = "Hint";
            this.hintBtn.UseVisualStyleBackColor = false;
            this.hintBtn.Click += new System.EventHandler(this.HintButton_Click);
            // 
            // Form2
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::Hangman.Resource.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(664, 507);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lableresult);
            this.Controls.Add(this.Mutebutton);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxintro)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagebox1)).EndInit();
            this.buttonPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Startbutton;
        private System.Windows.Forms.Button Mutebutton;
        public System.Windows.Forms.RadioButton radioGrade3;
        public System.Windows.Forms.RadioButton radioGrade2;
        public System.Windows.Forms.RadioButton radioGrade1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox Imagebox1;
        private System.Windows.Forms.Button Return_Button;
        private System.Windows.Forms.Label labelshowword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lableresult;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_highscore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button restartBtn;
        private System.Windows.Forms.Button hintBtn;
        private System.Windows.Forms.PictureBox pictureBoxintro;
    }
}