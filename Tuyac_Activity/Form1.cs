using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuyac_Activity
{
    public partial class Form1 : Form
    {
        private double totalDanielle = 0;
        private double totalEdward = 0;
        private double totalFatima = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void getSalesPerson_Amount(string salesInitial, double salesAmount)
        {
            string message = " ";

            switch (salesInitial.ToUpper())
            {
                case "D":
                    totalDanielle += salesAmount;
                    message = "Sale recorded: Danielle = P" + salesAmount.ToString("F2") + "\n";
                    break;
                case "E":
                    totalEdward += salesAmount;
                    message = "Sale recorded: Edward = P" + salesAmount.ToString("F2") + "\n";
                    break;
                case "F":
                    totalFatima += salesAmount;
                    message = "Sale recorded: Fatima - P" + salesAmount.ToString("F2") + "\n";
                    break;
                default:
                    message = "Invalid code! Use D, E, F only. \n";
                    break;
            }
            lbl_Display.Text = message;
            UpdateTotalDisplay();
        }
        private void UpdateTotalDisplay()
        {
            lbl_Display.Text +=
                "----------------------------------------------------------\n" +
                "Danielle (D): P" + totalDanielle.ToString("F2") + "\n" +
                "Edward (E): P" + totalEdward.ToString("F2") + "\n" +
                "Fatima (F): P" + totalFatima.ToString("F2") + "\n" +
                "----------------------------------------------------------\n";
        }
        private void clearEntry()
        {
            txt_Initial.Clear();
            txt_Amount.Clear();
            lbl_Display.Text = "";
            txt_Initial.Focus();
        }
        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            string initial = txt_Initial.Text.Trim();

            if (string.IsNullOrEmpty(initial))
            {
                lbl_Display.Text = "⚠️ Please enter a salesperson code (D, E, or F).";
                return;
            }


            if (!double.TryParse(txt_Amount.Text, out double amount) || amount <= 0)
            {
                lbl_Display.Text = "⚠️ Please enter a valid positive sale amount.";
                return;
            }
            getSalesPerson_Amount(initial, amount);
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            clearEntry();
        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            double grandTotal = totalDanielle + totalEdward + totalFatima;

            lbl_Display.Text =
                "==========SALES SUMMARY==========\n" +
                "Danielle (D): P" + totalDanielle.ToString("F2") + "\n" +
                "Edward (E): P" + totalEdward.ToString("F2") + "\n" +
                "Fatima (F): P" + totalFatima.ToString("F2") + "\n" +
                "=================================\n" +
                "GRAND TOTAL: P" + grandTotal.ToString("F2") + "\n" +
                "=================================\n";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
        
        

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}