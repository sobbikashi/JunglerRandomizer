using System;
using System.Windows.Forms;

namespace JunglerRandomizer
{
    public partial class Form1 : Form
    {
        public int chosenNumber = 0;
        public Random r = new Random();      

        public Form1()
        {
            InitializeComponent();
        }

        public static string DetermineChampion(int i)
        {
            int I = i;
            switch (I)
            {
                case 1: return "Hecarim";
                case 2: return "Kha'Zix";
                case 3: return "Kindret";
                case 4: return "Nocturne";
                case 5: return "Olaf";
                case 6: return "Vi";
                case 7: return "Xin-Zhao";
                case 8: return "Elise";
                case 9: return "Evelynn";
                case 10: return "Warwick";
                case 11: return "Sejuani";
                case 12: return "Trundle";
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
            this.pictureBox1 = new PictureBox();
            this.labelResult = new Label();
            this.buttonReset = new Button();
            this.textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Какой лесник нужен??";
            // 
            // buttonAD
            // 
            this.buttonAD.Location = new System.Drawing.Point(33, 92);
            this.buttonAD.Name = "buttonAD";
            this.buttonAD.Size = new System.Drawing.Size(75, 23);
            this.buttonAD.TabIndex = 1;
            this.buttonAD.Text = "АД";
            this.buttonAD.UseVisualStyleBackColor = true;
            this.buttonAD.Click += new EventHandler(this.buttonAD_Click);
            // 
            // buttonAP
            // 
            this.buttonAP.Location = new System.Drawing.Point(114, 92);
            this.buttonAP.Name = "buttonAP";
            this.buttonAP.Size = new System.Drawing.Size(75, 23);
            this.buttonAP.TabIndex = 2;
            this.buttonAP.Text = "АП";
            this.buttonAP.UseVisualStyleBackColor = true;
            this.buttonAP.Click += new EventHandler(this.buttonAP_Click_1);
            // 
            // buttonTank
            // 
            this.buttonTank.Location = new System.Drawing.Point(195, 92);
            this.buttonTank.Name = "buttonTank";
            this.buttonTank.Size = new System.Drawing.Size(75, 23);
            this.buttonTank.TabIndex = 3;
            this.buttonTank.Text = "Танк";
            this.buttonTank.UseVisualStyleBackColor = true;
            this.buttonTank.Click += new EventHandler(this.buttonTank_Click_1);
            // 
            // buttonRND
            // 
            this.buttonRND.Location = new System.Drawing.Point(276, 92);
            this.buttonRND.Name = "buttonRND";
            this.buttonRND.Size = new System.Drawing.Size(75, 23);
            this.buttonRND.TabIndex = 4;
            this.buttonRND.Text = "Ю";
            this.buttonRND.UseVisualStyleBackColor = true;
            this.buttonRND.Click += new EventHandler(this.buttonRND_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(114, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 220);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(156, 374);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(60, 15);
            this.labelResult.TabIndex = 6;
            this.labelResult.Text = "Результат";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(156, 424);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 7;
            this.buttonReset.Text = "Сброс";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new EventHandler(this.buttonReset_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 393);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(381, 469);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonRND);
            this.Controls.Add(this.buttonTank);
            this.Controls.Add(this.buttonAP);
            this.Controls.Add(this.buttonAD);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void buttonAD_Click(object sender, EventArgs e)
        {
            chosenNumber = r.Next(8);
            labelResult.Text = DetermineChampion(chosenNumber);
        }                

        private void buttonAP_Click_1(object sender, EventArgs e)
        {
            chosenNumber = r.Next(8, 10);
            labelResult.Text = DetermineChampion(chosenNumber);
        }

        private void buttonTank_Click_1(object sender, EventArgs e)
        {
            chosenNumber = r.Next(10, 13);
            labelResult.Text = DetermineChampion(chosenNumber);
        }

        private void buttonRND_Click_1(object sender, EventArgs e)
        {
            chosenNumber = r.Next(13);
            labelResult.Text = DetermineChampion(chosenNumber);
        }

        private void buttonReset_Click_1(object sender, EventArgs e)
        {
            chosenNumber = 0;
            labelResult.Text = DetermineChampion(chosenNumber);
        }
    }
}

