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
        int value1 = 0,
            value2;

        public MainForm()
        {
            InitializeComponent();

            NumberInput.Text = value1.ToString();
        }

        /// <summary>
        /// Обработчик нажатия клавиши цифры.
        /// </summary>
        private void HandleNumberButton_Click(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            string numberValue = currentButton.Text;
            addNumber(numberValue);
        }

        /// <summary>
        /// Обработчик нажатия клавиши действия.
        /// </summary>
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
                case "ClearAll": // Очистить все.
                {
                    clearAll();
                    break;
                }
            }
        }

        /// <summary>
        /// Добавляет цифру в поле и память. (Не сделано добавление в память)
        /// </summary>
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

        private void clearAll()
        {
            value1 = 0;
            value2 = 0;
            NumberInput.Text = value1.ToString();
        }
    }
}
