using System;
using System.Windows.Forms;
using System.Drawing;
using System.Media;

namespace JunglerRandomizer
{
    public partial class Form1 : Form
    {
        public int chosenNumber = 0;
        public Random r = new Random();
        public static Image img = Image.FromFile("Images\\non.jpg");
        public static SoundPlayer snd = new SoundPlayer("Sound\\nvm.wav");
        

        public Form1()
        {
            InitializeComponent();
        }

        public static string DetermineChampion(int i)
        {
            int I = i;
            switch (I)
            {
                case 0:
                    {
                        img = Image.FromFile("Images\\non.jpg");
                        return "Ваш результат";
                    }

                case 1: 
                    {
                        img = Image.FromFile("Images\\Hecarim.jpg");
                        return "Hecarim";                        
                    }  
                case 2:
                    {
                        img = Image.FromFile("Images\\KhaZix.jpg");
                        return "Kha'Zix";
                    }
                    
                case 3:
                    {
                        img = Image.FromFile("Images\\Kindret.jpg");
                        return "Kindret";
                    }
                    
                case 4:
                    {
                        img = Image.FromFile("Images\\Nocturne.jpg");
                        return "Nocturne";
                    }
                    
                case 5:
                    {
                        img = Image.FromFile("Images\\Olaf.jpg");
                        return "Olaf";
                    }
                    
                case 6:
                    {
                        img = Image.FromFile("Images\\Vi.jpg");
                        return "Vi"; ;
                    }
                   
                case 7:
                    {
                        img = Image.FromFile("Images\\XinZhao.jpg");
                        return "Xin-Zhao";
                    }
                    
                case 8:
                    {
                        img = Image.FromFile("Images\\Elise.jpg");
                        return "Elise";
                    }
                    
                case 9:
                    {
                        img = Image.FromFile("Images\\Evelynn.jpg");
                        return "Evelynn";
                    }
                    
                case 10:
                    {
                        img = Image.FromFile("Images\\Warwick.jpg");
                        return "Warwick";
                    }
                    
                case 11:
                    {
                        img = Image.FromFile("Images\\Sejuani.jpg");
                        return "Sejuani";
                    }
                    
                case 12:
                    {
                        img = Image.FromFile("Images\\Trundle.jpg");
                        return "Trundle";
                    }
                                        
            }            
            return "Ваш результат";

        }
        private void InitializeComponent()
        {
            this.label1 = new Label();
            this.buttonAD = new Button();
            this.buttonAP = new Button();
            this.buttonTank = new Button();
            this.buttonRND = new Button();
            this.labelResult = new Label();
            this.buttonReset = new Button();
            this.pictureChamp = new PictureBox();
            this.buttonClose = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureChamp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Point(128, 41);
            this.label1.Name = "label1";
            this.label1.Size = new Size(130, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Какой лесник нужен??";
            // 
            // buttonAD
            // 
            this.buttonAD.Location = new Point(33, 92);
            this.buttonAD.Name = "buttonAD";
            this.buttonAD.Size = new Size(75, 23);
            this.buttonAD.TabIndex = 1;
            this.buttonAD.Text = "АД";
            this.buttonAD.UseVisualStyleBackColor = true;
            this.buttonAD.Click += new EventHandler(this.buttonAD_Click);
            // 
            // buttonAP
            // 
            this.buttonAP.Location = new Point(114, 92);
            this.buttonAP.Name = "buttonAP";
            this.buttonAP.Size = new Size(75, 23);
            this.buttonAP.TabIndex = 2;
            this.buttonAP.Text = "АП";
            this.buttonAP.UseVisualStyleBackColor = true;
            this.buttonAP.Click += new EventHandler(this.buttonAP_Click_1);
            // 
            // buttonTank
            // 
            this.buttonTank.Location = new Point(195, 92);
            this.buttonTank.Name = "buttonTank";
            this.buttonTank.Size = new Size(75, 23);
            this.buttonTank.TabIndex = 3;
            this.buttonTank.Text = "Танк";
            this.buttonTank.UseVisualStyleBackColor = true;
            this.buttonTank.Click += new EventHandler(this.buttonTank_Click_1);
            // 
            // buttonRND
            // 
            this.buttonRND.Location = new Point(276, 92);
            this.buttonRND.Name = "buttonRND";
            this.buttonRND.Size = new Size(75, 23);
            this.buttonRND.TabIndex = 4;
            this.buttonRND.Text = "Ю";
            this.buttonRND.UseVisualStyleBackColor = true;
            this.buttonRND.Click += new EventHandler(this.buttonRND_Click_1);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new Point(156, 374);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new Size(60, 15);
            this.labelResult.TabIndex = 6;
            this.labelResult.Text = "Результат";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new Point(156, 403);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new Size(75, 23);
            this.buttonReset.TabIndex = 7;
            this.buttonReset.Text = "Сброс";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new EventHandler(this.buttonReset_Click_1);
            // 
            // pictureChamp
            // 
            this.pictureChamp.ImageLocation = "Images\\non.jpg";
            this.pictureChamp.Location = new Point(128, 152);
            this.pictureChamp.Name = "pictureChamp";
            this.pictureChamp.Size = new Size(142, 200);
            this.pictureChamp.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureChamp.TabIndex = 9;
            this.pictureChamp.TabStop = false;
            this.pictureChamp.Image = img;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new Point(156, 432);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new Size(75, 23);
            this.buttonClose.TabIndex = 10;
            this.buttonClose.Text = "Выход";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new EventHandler(this.buttonClose_Click);
            // 
            // Form1
            // 
            this.ClientSize = new Size(381, 469);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.pictureChamp);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonRND);
            this.Controls.Add(this.buttonTank);
            this.Controls.Add(this.buttonAP);
            this.Controls.Add(this.buttonAD);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureChamp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void buttonAD_Click(object sender, EventArgs e)
        {
            chosenNumber = r.Next(8);
            labelResult.Text = DetermineChampion(chosenNumber);
            pictureChamp.Image = img;
        }                

        private void buttonAP_Click_1(object sender, EventArgs e)
        {
            chosenNumber = r.Next(8, 10);
            labelResult.Text = DetermineChampion(chosenNumber);
            pictureChamp.Image = img;
        }

        private void buttonTank_Click_1(object sender, EventArgs e)
        {
            chosenNumber = r.Next(10, 13);
            labelResult.Text = DetermineChampion(chosenNumber);
            pictureChamp.Image = img;
        }

        private void buttonRND_Click_1(object sender, EventArgs e)
        {
            snd.Play();
            chosenNumber = r.Next(13);
            labelResult.Text = DetermineChampion(chosenNumber);
            pictureChamp.Image = img;
        }

        private void buttonReset_Click_1(object sender, EventArgs e)
        {
            chosenNumber = 0;
            labelResult.Text = DetermineChampion(chosenNumber);
            pictureChamp.Image = img;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}

