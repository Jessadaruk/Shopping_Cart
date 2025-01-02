namespace ShoppingCart
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            chbcoffee = new CheckBox();
            chbGreenTea = new CheckBox();
            label1 = new Label();
            Chech_Out = new Button();
            tbCoffeePrice = new MaskedTextBox();
            tbGreenTeaPrice = new MaskedTextBox();
            tbCoffeeQuantity = new MaskedTextBox();
            tbGreenTeaQuantity = new MaskedTextBox();
            tbTotal = new MaskedTextBox();
            lavel = new Label();
            Cashmonney = new MaskedTextBox();
            ggg = new Label();
            Changemonney = new MaskedTextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            Change1000 = new MaskedTextBox();
            Change500 = new MaskedTextBox();
            Change100 = new MaskedTextBox();
            Change50 = new MaskedTextBox();
            Change10 = new MaskedTextBox();
            Change5 = new MaskedTextBox();
            Change1 = new MaskedTextBox();
            Change20 = new MaskedTextBox();
            ProcessMonney = new Button();
            ChangeBath = new MaskedTextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // chbcoffee
            // 
            chbcoffee.AutoSize = true;
            chbcoffee.Location = new Point(23, 46);
            chbcoffee.Name = "chbcoffee";
            chbcoffee.Size = new Size(61, 19);
            chbcoffee.TabIndex = 0;
            chbcoffee.Text = "Coffee";
            chbcoffee.UseVisualStyleBackColor = true;
            chbcoffee.CheckedChanged += chbcoffee_CheckedChanged;
            // 
            // chbGreenTea
            // 
            chbGreenTea.AutoSize = true;
            chbGreenTea.Location = new Point(23, 87);
            chbGreenTea.Name = "chbGreenTea";
            chbGreenTea.Size = new Size(74, 19);
            chbGreenTea.TabIndex = 1;
            chbGreenTea.Text = "GreenTea";
            chbGreenTea.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(543, 72);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 2;
            label1.Text = "Total";
            label1.Click += label1_Click;
            // 
            // Chech_Out
            // 
            Chech_Out.BackColor = Color.Firebrick;
            Chech_Out.ForeColor = Color.FromArgb(224, 224, 224);
            Chech_Out.Location = new Point(389, 46);
            Chech_Out.Name = "Chech_Out";
            Chech_Out.Size = new Size(95, 67);
            Chech_Out.TabIndex = 3;
            Chech_Out.Text = "Check_Out";
            Chech_Out.UseVisualStyleBackColor = false;
            Chech_Out.Click += button1_Click;
            // 
            // tbCoffeePrice
            // 
            tbCoffeePrice.Location = new Point(118, 46);
            tbCoffeePrice.Name = "tbCoffeePrice";
            tbCoffeePrice.Size = new Size(100, 23);
            tbCoffeePrice.TabIndex = 4;
            tbCoffeePrice.MaskInputRejected += tbCoffeePrice_MaskInputRejected;
            // 
            // tbGreenTeaPrice
            // 
            tbGreenTeaPrice.Location = new Point(118, 87);
            tbGreenTeaPrice.Name = "tbGreenTeaPrice";
            tbGreenTeaPrice.Size = new Size(100, 23);
            tbGreenTeaPrice.TabIndex = 5;
            tbGreenTeaPrice.MaskInputRejected += tbGreenTeaPrice_MaskInputRejected;
            // 
            // tbCoffeeQuantity
            // 
            tbCoffeeQuantity.Location = new Point(262, 46);
            tbCoffeeQuantity.Name = "tbCoffeeQuantity";
            tbCoffeeQuantity.Size = new Size(100, 23);
            tbCoffeeQuantity.TabIndex = 6;
            tbCoffeeQuantity.MaskInputRejected += maskedTextBox3_MaskInputRejected;
            // 
            // tbGreenTeaQuantity
            // 
            tbGreenTeaQuantity.Location = new Point(262, 90);
            tbGreenTeaQuantity.Name = "tbGreenTeaQuantity";
            tbGreenTeaQuantity.Size = new Size(100, 23);
            tbGreenTeaQuantity.TabIndex = 7;
            tbGreenTeaQuantity.MaskInputRejected += tbGreenTeaQuantity_MaskInputRejected;
            // 
            // tbTotal
            // 
            tbTotal.Location = new Point(608, 69);
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(100, 23);
            tbTotal.TabIndex = 8;
            tbTotal.MaskInputRejected += tbTotal_MaskInputRejected;
            // 
            // lavel
            // 
            lavel.AutoSize = true;
            lavel.Location = new Point(542, 132);
            lavel.Name = "lavel";
            lavel.Size = new Size(33, 15);
            lavel.TabIndex = 9;
            lavel.Text = "Cash";
            lavel.Click += lavel_Click;
            // 
            // Cashmonney
            // 
            Cashmonney.Location = new Point(608, 124);
            Cashmonney.Name = "Cashmonney";
            Cashmonney.Size = new Size(100, 23);
            Cashmonney.TabIndex = 10;
            // 
            // ggg
            // 
            ggg.AutoSize = true;
            ggg.Location = new Point(542, 168);
            ggg.Name = "ggg";
            ggg.Size = new Size(48, 15);
            ggg.TabIndex = 11;
            ggg.Text = "Change";
            // 
            // Changemonney
            // 
            Changemonney.Location = new Point(608, 168);
            Changemonney.Name = "Changemonney";
            Changemonney.Size = new Size(100, 23);
            Changemonney.TabIndex = 12;
            Changemonney.MaskInputRejected += Changemonney_MaskInputRejected;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(762, 72);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 13;
            label2.Text = "1000";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(768, 132);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 14;
            label3.Text = "500";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(768, 194);
            label4.Name = "label4";
            label4.Size = new Size(25, 15);
            label4.TabIndex = 15;
            label4.Text = "100";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(774, 242);
            label5.Name = "label5";
            label5.Size = new Size(19, 15);
            label5.TabIndex = 16;
            label5.Text = "50";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(774, 298);
            label6.Name = "label6";
            label6.Size = new Size(19, 15);
            label6.TabIndex = 17;
            label6.Text = "20";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(774, 350);
            label7.Name = "label7";
            label7.Size = new Size(19, 15);
            label7.TabIndex = 18;
            label7.Text = "10";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(780, 409);
            label8.Name = "label8";
            label8.Size = new Size(13, 15);
            label8.TabIndex = 19;
            label8.Text = "5";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(532, 556);
            label9.Name = "label9";
            label9.Size = new Size(13, 15);
            label9.TabIndex = 20;
            label9.Text = "1";
            label9.Click += label9_Click;
            // 
            // Change1000
            // 
            Change1000.Location = new Point(839, 69);
            Change1000.Name = "Change1000";
            Change1000.Size = new Size(52, 23);
            Change1000.TabIndex = 21;
            Change1000.MaskInputRejected += Change1000_MaskInputRejected;
            // 
            // Change500
            // 
            Change500.Location = new Point(839, 124);
            Change500.Name = "Change500";
            Change500.Size = new Size(52, 23);
            Change500.TabIndex = 22;
            Change500.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // Change100
            // 
            Change100.Location = new Point(839, 186);
            Change100.Name = "Change100";
            Change100.Size = new Size(52, 23);
            Change100.TabIndex = 23;
            Change100.MaskInputRejected += Change100_MaskInputRejected;
            // 
            // Change50
            // 
            Change50.Location = new Point(839, 234);
            Change50.Name = "Change50";
            Change50.Size = new Size(52, 23);
            Change50.TabIndex = 24;
            Change50.MaskInputRejected += Change50_MaskInputRejected;
            // 
            // Change10
            // 
            Change10.Location = new Point(839, 342);
            Change10.Name = "Change10";
            Change10.Size = new Size(52, 23);
            Change10.TabIndex = 25;
            Change10.MaskInputRejected += Change10_MaskInputRejected;
            // 
            // Change5
            // 
            Change5.Location = new Point(839, 401);
            Change5.Name = "Change5";
            Change5.Size = new Size(52, 23);
            Change5.TabIndex = 26;
            Change5.MaskInputRejected += Change5_MaskInputRejected;
            // 
            // Change1
            // 
            Change1.Location = new Point(608, 556);
            Change1.Name = "Change1";
            Change1.Size = new Size(100, 23);
            Change1.TabIndex = 27;
            Change1.MaskInputRejected += Change1_MaskInputRejected;
            // 
            // Change20
            // 
            Change20.Location = new Point(839, 290);
            Change20.Name = "Change20";
            Change20.Size = new Size(52, 23);
            Change20.TabIndex = 28;
            Change20.MaskInputRejected += Change20_MaskInputRejected;
            // 
            // ProcessMonney
            // 
            ProcessMonney.BackColor = Color.Firebrick;
            ProcessMonney.ForeColor = Color.White;
            ProcessMonney.Location = new Point(389, 142);
            ProcessMonney.Name = "ProcessMonney";
            ProcessMonney.Size = new Size(95, 67);
            ProcessMonney.TabIndex = 29;
            ProcessMonney.Text = "Change Monney";
            ProcessMonney.UseVisualStyleBackColor = false;
            ProcessMonney.Click += button2_Click;
            // 
            // ChangeBath
            // 
            ChangeBath.Location = new Point(839, 460);
            ChangeBath.Name = "ChangeBath";
            ChangeBath.Size = new Size(52, 23);
            ChangeBath.TabIndex = 30;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(780, 468);
            label10.Name = "label10";
            label10.Size = new Size(13, 15);
            label10.TabIndex = 31;
            label10.Text = "1";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Black;
            label11.ForeColor = Color.White;
            label11.Location = new Point(139, 18);
            label11.Name = "label11";
            label11.Size = new Size(59, 15);
            label11.TabIndex = 32;
            label11.Text = "จำนวณแก้ว";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Black;
            label12.ForeColor = Color.White;
            label12.Location = new Point(298, 18);
            label12.Name = "label12";
            label12.Size = new Size(29, 15);
            label12.TabIndex = 33;
            label12.Text = "ราคา";
            label12.Click += label12_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.ForeColor = Color.FromArgb(192, 0, 0);
            button2.Location = new Point(389, 246);
            button2.Name = "button2";
            button2.Size = new Size(95, 67);
            button2.TabIndex = 34;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1141, 545);
            Controls.Add(button2);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(ChangeBath);
            Controls.Add(ProcessMonney);
            Controls.Add(Change20);
            Controls.Add(Change1);
            Controls.Add(Change5);
            Controls.Add(Change10);
            Controls.Add(Change50);
            Controls.Add(Change100);
            Controls.Add(Change500);
            Controls.Add(Change1000);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Changemonney);
            Controls.Add(ggg);
            Controls.Add(Cashmonney);
            Controls.Add(lavel);
            Controls.Add(tbTotal);
            Controls.Add(tbGreenTeaQuantity);
            Controls.Add(tbCoffeeQuantity);
            Controls.Add(tbGreenTeaPrice);
            Controls.Add(tbCoffeePrice);
            Controls.Add(Chech_Out);
            Controls.Add(label1);
            Controls.Add(chbGreenTea);
            Controls.Add(chbcoffee);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chbcoffee;
        private CheckBox chbGreenTea;
        private Label label1;
        private Button Chech_Out;
        private MaskedTextBox tbCoffeePrice;
        private MaskedTextBox tbGreenTeaPrice;
        private MaskedTextBox tbCoffeeQuantity;
        private MaskedTextBox tbGreenTeaQuantity;
        private MaskedTextBox tbTotal;
        private Label lavel;
        private MaskedTextBox Cashmonney;
        private Label ggg;
        private MaskedTextBox Changemonney;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private MaskedTextBox Change1000;
        private MaskedTextBox Change500;
        private MaskedTextBox Change100;
        private MaskedTextBox Change50;
        private MaskedTextBox Change10;
        private MaskedTextBox Change5;
        private MaskedTextBox Change1;
        private MaskedTextBox Change20;
        private Button ProcessMonney;
        private MaskedTextBox ChangeBath;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button button2;
    }
}
