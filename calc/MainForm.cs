using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class MainForm : Form
    {
        double value1 = 0,
               value2;

        public MainForm()
        {
            InitializeComponent();

            NumberInput.Text = value1.ToString();
        }

        private void HandleNumberButton_Click(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            string numberValue = currentButton.Text;
            addNumber(numberValue);
        }

        private void HandleActionButton_Click(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;

            if (currentButton.Tag == null) // Временная заглушка.
            {
                return;
            }

            string buttonType = currentButton.Tag.ToString();

            switch(buttonType)
            {            
                case "Plus":
                {
                    setSum();
                    break;
                }
                case "Match":
                {
                    setResult();
                    break;
                }
                case "DeleteNumber":
                {
                    deleteNumber();
                    break;
                }
                case "SignChange":
                {
                    signChange();
                    break;
                }
                case "ClearAll":
                {
                    clearAll();
                    break;
                }
            }
        }

        private void setResult()
        {
            if (value2 == 0)
            {
                value2 = Convert.ToInt32(NumberInput.Text);

                double result = value1 + value2;
                NumberInput.Text = result.ToString();

                clearValues();
            }
        }

        private void setSum()
        {
            if (value2 == 0)
            {
                value1 = Convert.ToInt32(NumberInput.Text);
                NumberInput.Text = value2.ToString();
            }
        }

        private void addNumber(string numberValue)
        {
            if (NumberInput.Text == 0.ToString())
            {
                NumberInput.Text = numberValue;
            } 
            else
            {
                NumberInput.Text += numberValue;
            }       
        }

        private void deleteNumber()
        {
            string newValue = NumberInput.Text.Substring(0, NumberInput.Text.Length - 1);
            if (newValue == String.Empty)
            {
                NumberInput.Text = 0.ToString();
            }
            else
            {
                NumberInput.Text = newValue;
            }
        }

        private void signChange()
        {
            int newValue = Convert.ToInt32(NumberInput.Text) * -1;
            NumberInput.Text = newValue.ToString();
        }

        private void clearAll()
        {
            clearValues();
            clearInput();
        }

        private void clearValues()
        {
            value1 = 0;
            value2 = 0;
        }

        private void clearInput()
        {
            NumberInput.Text = value1.ToString();
        }
    }
}
