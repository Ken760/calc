using System;
using System.Windows.Forms;

namespace calc
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Перечень действий.
        /// </summary>
        enum Action
        {
            Amount, // Сумма.
            Subtraction, // Разность.
            Multiplication, // Умножение.
            Division, // Деление.
        }

        /// <summary>
        /// Переменные для вычислений.
        /// </summary>
        double value1 = 0,
               value2;

        Action action; // Переменная, в которой будет храниться значение для действия.

        public MainForm()
        {
            InitializeComponent();

            NumberInput.Text = value1.ToString();
        }

        /// <summary>
        /// Обработчик для клика на кнопки циферблата.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HandleNumberButton_Click(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            string numberValue = currentButton.Text;
            addNumber(numberValue);
        }

        /// <summary>
        /// Обработчик для клика на кнопки действий.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    setAction(Action.Amount);
                    break;
                }
                case "Minus":
                {
                    setAction(Action.Subtraction);
                    break;
                }
                case "Multi":
                {
                    setAction(Action.Multiplication);
                    break;
                }
                case "Division":
                {
                    setAction(Action.Division);
                    break;
                }
                case "Match":
                {
                    setResult(action);
                    break;
                }
                case "Comma":
                {
                    setComma();
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
                case "Clear":
                {
                    clearCurrent();
                    break;
                }
                case "ClearAll":
                {
                    clearAll();
                    break;
                }
            }
        }

        /// <summary>
        /// Установить действие для вычислений (action)
        /// </summary>
        /// <param name="_action"></param>
        private void setAction(Action _action)
        {
            if (value2 == 0)
            {
                value1 = Convert.ToDouble(NumberInput.Text);
                NumberInput.Text = value2.ToString();
                action = _action;
            }
        }

        /// <summary>
        /// Вычислить результат в зависимости от установленного значения action.
        /// </summary>
        /// <param name="action"></param>
        private void setResult(Action action)
        {
            if (value2 == 0)
            {
                value2 = Convert.ToDouble(NumberInput.Text);

                double result = 0;
                switch (action)
                {
                    case Action.Amount:
                    {
                        result = value1 + value2;
                        break;
                    }
                    case Action.Subtraction:
                    {
                        result = value1 - value2;
                        break;
                    }
                    case Action.Multiplication:
                    {
                        result = value1 * value2;
                        break;
                    }
                    case Action.Division:
                    {
                        result = value1 / value2;
                        break;
                    }
                }

                NumberInput.Text = result.ToString();
                clearValues();
            }
        }

        /// <summary>
        /// Установить запятую в поле.
        /// </summary>
        private void setComma()
        {
            string currentValue = NumberInput.Text;
            int isHaveComma = currentValue.IndexOf(',');
            
            if (isHaveComma == -1)
            {
                currentValue += ",";
                NumberInput.Text = currentValue;
            }
        }

        /// <summary>
        /// Добавление числа в поле.
        /// </summary>
        /// <param name="numberValue">Число, которое добавляется в поле.</param>
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

        /// <summary>
        /// Удаление последнего числа из поля.
        /// </summary>
        private void deleteNumber()
        {
            string newValue = NumberInput.Text.Substring(0, NumberInput.Text.Length - 1);
            if (newValue == String.Empty || newValue == "-")
            {
                NumberInput.Text = 0.ToString();
            }
            else
            {
                NumberInput.Text = newValue;
            }
        }

        /// <summary>
        /// Смена знака в поле.
        /// </summary>
        private void signChange()
        {
            int newValue = Convert.ToInt32(NumberInput.Text) * -1;
            NumberInput.Text = newValue.ToString();
        }

        /// <summary>
        /// Очистка поля, очистка значений.
        /// </summary>
        private void clearAll()
        {
            clearValues();
            clearInput();
        }

        /// <summary>
        /// Очистка поля ввода - вставляем в поле 0.
        /// </summary>
        private void clearCurrent()
        {
            NumberInput.Text = 0.ToString();
        }

        /// <summary>
        /// Очищаем текущие значения переменных для вычислений.
        /// </summary>
        private void clearValues()
        {
            value1 = 0;
            value2 = 0;
        }

        /// <summary>
        /// Очистка поля ввода - вставляем в поле значение результата после вычислений.
        /// </summary>
        private void clearInput()
        {
            NumberInput.Text = value1.ToString();
        }
    }
}
