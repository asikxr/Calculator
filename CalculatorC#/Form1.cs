using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorC_
{
    public partial class MAIN : Form
    {
        public MAIN()
        {
            InitializeComponent();
            
        }

        //Actualiza el texto del display
        private void UpdateDisplay()
        {
            DisplayTxb.Text = displayText;
        }

        string displayText = "0";
        float resultValue = 0;

        private void button11_Click(object sender, EventArgs e)
        {
            if (displayText == "0") displayText = "";
            displayText += "9";
            UpdateDisplay();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (displayText == "0") displayText = "";
            displayText += "4";
            UpdateDisplay();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (displayText == "0") displayText = "";
            displayText += "6";
            UpdateDisplay();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (displayText == "0") displayText = "";
            displayText += "3";
            UpdateDisplay();
        }

        private void DisplayTxb_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ACBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (displayText == "0") displayText = "";
            displayText = "0";
            UpdateDisplay();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (displayText == "0") displayText = "";
            displayText += "1";
            UpdateDisplay();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (displayText == "0") displayText = "";
            displayText += "2";
            UpdateDisplay();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (displayText == "0") displayText = "";
            displayText += "0";
            UpdateDisplay();
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            if (displayText == "0") displayText = "";
            displayText += ".";
            UpdateDisplay();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (displayText == "0") displayText = "";
            displayText += "5";
            UpdateDisplay();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (displayText == "0") displayText = "";
            displayText += "7";
            UpdateDisplay();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (displayText == "0") displayText = "";
            displayText += "8";
            UpdateDisplay();
        }
    }
}
