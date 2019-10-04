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
        int value1,
            value2;

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик нажатия клавиши действия.
        /// </summary>
        private void HandleActionButton_Click()
        {

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
        /// Добавляет цифру в поле и память.
        /// </summary>
        private void addNumber(string numberValue)
        {
            NumberInput.Text += numberValue;
        }
    }
}
