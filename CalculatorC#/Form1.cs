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

        //Evitar que se pueda escribir un operador al principio y funcion para no repetir operadores
        bool lastWasOperator = false;

        private void button11_Click(object sender, EventArgs e)
        {
            if (displayText == "0") displayText = "";
            displayText += "9";
            bool lastWasOperator = false;
            UpdateDisplay();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (displayText == "0") displayText = "";
            displayText += "4";
            bool lastWasOperator = false;
            UpdateDisplay();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (displayText == "0") displayText = "";
            displayText += "6";
            bool lastWasOperator = false;
            UpdateDisplay();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (displayText == "0") displayText = "";
            displayText += "3";
            bool lastWasOperator = false;
            UpdateDisplay();
        }

        private void DisplayTxb_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ACBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (displayText == "0") displayText = "";
            displayText = "0";
            bool lastWasOperator = false;
            UpdateDisplay();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (displayText == "0") displayText = "";
            displayText += "1";
            bool lastWasOperator = false;
            UpdateDisplay();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (displayText == "0") displayText = "";
            displayText += "2";
            bool lastWasOperator = false;
            UpdateDisplay();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (displayText == "0") displayText = "";
            displayText += "0";
            bool lastWasOperator = false;
            UpdateDisplay();
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            if (displayText == "0") displayText = "";
            displayText += ".";
            bool lastWasOperator = true;
            UpdateDisplay();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (displayText == "0") displayText = "";
            displayText += "5";
            bool lastWasOperator = false;
            UpdateDisplay();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (displayText == "0") displayText = "";
            displayText += "7";
            bool lastWasOperator = false;
            UpdateDisplay();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (displayText == "0") displayText = "";
            displayText += "8";
            bool lastWasOperator = false;
            UpdateDisplay();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (displayText != "0" && !lastWasOperator)
            {
                displayText += "+";
                lastWasOperator = true;
                UpdateDisplay();
            }
        }

        private void MenosBtn_Click(object sender, EventArgs e)
        {
            if (displayText != "0" && !lastWasOperator)
            {
                displayText += "-";
                lastWasOperator = true;
                UpdateDisplay();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (displayText != "0" && !lastWasOperator)
            {
                displayText += "*";
                lastWasOperator = true;
                UpdateDisplay();
            }
        }

        private void DivisionBtn_Click(object sender, EventArgs e)
        {
            if (displayText != "0" && !lastWasOperator)
            {
                displayText += "/";
                lastWasOperator = true;
                UpdateDisplay();
            }
        }

        private void IgualBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var result = new System.Data.DataTable().Compute(displayText, null);

                // Si el resultado es infinito (ej. dividir entre 0)
                if (double.TryParse(result.ToString(), out double val) && double.IsInfinity(val))
                {
                    displayText = "∞";
                }
                else
                {
                    displayText = result.ToString();
                }

                lastWasOperator = false;
                UpdateDisplay();
            }
            catch
            {
                displayText = "Error";
                UpdateDisplay();
            }

        }

        private void PorcentajeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double value = double.Parse(displayText);

                value = value / 100;

                displayText = value.ToString();
                UpdateDisplay();
            }
            catch
            {
                displayText = "Error";
                UpdateDisplay();
            }
        }
    }
}
