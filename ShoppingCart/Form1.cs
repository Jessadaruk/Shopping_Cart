using System;
using System.Numerics;

namespace ShoppingCart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbCoffeePrice_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tbGreenTeaPrice_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tbGreenTeaQuantity_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tbTotal_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sumTotal = 0;

            if (chbcoffee.Checked) // ตรวจสอบว่า Coffee ถูกติ๊กหรือไม่
            {
                string inputNum1 = tbCoffeePrice.Text;
                int iNum1 = string.IsNullOrWhiteSpace(inputNum1) ? 0 : int.Parse(inputNum1);

                string inputNum2 = tbCoffeeQuantity.Text;
                int iNum2 = string.IsNullOrWhiteSpace(inputNum2) ? 0 : int.Parse(inputNum2);

                int iTotal = iNum1 * iNum2;
                sumTotal += iTotal;
            }

            if (chbGreenTea.Checked) // ตรวจสอบว่า GreenTea ถูกติ๊กหรือไม่
            {
                string inputNum3 = tbGreenTeaPrice.Text;
                int iNum3 = string.IsNullOrWhiteSpace(inputNum3) ? 0 : int.Parse(inputNum3);

                string inputNum4 = tbGreenTeaQuantity.Text;
                int iNum4 = string.IsNullOrWhiteSpace(inputNum4) ? 0 : int.Parse(inputNum4);

                int oTotal = iNum3 * iNum4;
                sumTotal += oTotal;
            }

            tbTotal.Text = sumTotal.ToString();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void chbcoffee_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            // รับค่าจาก SumTotal โดยตรง
            int total = string.IsNullOrWhiteSpace(tbTotal.Text) ? 0 : int.Parse(tbTotal.Text);

            // รับจำนวนเงินสดที่ลูกค้าจ่าย (Cash)
            string inputCash = Cashmonney.Text;
            int cash = string.IsNullOrWhiteSpace(inputCash) ? 0 : int.Parse(inputCash);

            // คำนวณเงินทอน
            int change = cash - total;

            if (change < 0)
            {
                MessageBox.Show("เงินสดไม่เพียงพอ!  ใส่เงินใหม่อีกครั้งที่ช่อง  Cash");
                return;
            }


            // คำนวณจำนวนแบงค์ ที่ต้องจ่าย

            int banknotes1000 = change / 1000;
            int remainingChange = change % 1000;

            int banknotes500 = remainingChange / 500;
            remainingChange %= 500;

            int banknotes100 = remainingChange / 100;
            remainingChange %= 100;

            int banknotes50 = remainingChange / 50;
            remainingChange %= 50;

            int banknotes20 = remainingChange / 20;
            remainingChange %= 20;

            int banknotes10 = remainingChange / 10;
            remainingChange %= 10;

            int banknotes5 = remainingChange / 5;
            remainingChange %= 5;

            int banknotes1 = remainingChange; // เงินทอนที่เหลือเป็นเศษ 1 บาท

            Changemonney.Text = change.ToString();
            Change1000.Text = banknotes1000.ToString();
            Change500.Text = banknotes500.ToString();
            Change100.Text = banknotes100.ToString();
            Change50.Text = banknotes50.ToString();
            Change20.Text = banknotes20.ToString();
            Change10.Text = banknotes10.ToString();
            Change5.Text = banknotes5.ToString();
            ChangeBath.Text = banknotes1.ToString();


        }

        private void lavel_Click(object sender, EventArgs e)
        {

        }

        private void Change1000_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Change1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Change5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Change10_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Change20_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Change50_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Change100_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Changemonney_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            // ลบ ระบุจำนวณ 
            tbCoffeePrice.Clear();
            tbGreenTeaPrice.Clear();
            tbCoffeeQuantity.Clear();
            tbGreenTeaQuantity.Clear();

            // ลบตัวแสดงผล
            tbTotal.Clear();
            Cashmonney.Clear();
            Changemonney.Clear();

            // ลบเงินทอน
            Change1000.Clear();
            Change500.Clear();
            Change100.Clear();
            Change50.Clear();
            Change20.Clear();
            Change10.Clear();
            Change5.Clear();
            ChangeBath.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
