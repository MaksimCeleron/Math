using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Math
{
    public partial class MathWidgetForm : Form
    {
        double num1 = 0;
        int operation = 0;
        bool clearall = false;

        public MathWidgetForm()
        {
            InitializeComponent();
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            InputTextBox.Text += '0';
            if (Control.ModifierKeys == Keys.Alt)
            {
                InputTextBox.Text += '0';
            }
            DecimalButton.Enabled = true;
            CalculateButton.Enabled = operation != 4;
            AddButton.Enabled = true;
            SubstractButton.Enabled = true;
            MultiplyButton.Enabled = true;
            DivideButton.Enabled = true;
        }

        private void DigitButton_Click(object sender, EventArgs e)
        {
            if (InputTextBox.Text == "0" || InputTextBox.Text == "-0")
            {
                bool negative = InputTextBox.Text == "-0";
                clearall = false;

                InputTextBox.Clear();
                if (negative)
                {
                    InputTextBox.Text += '-';
                }
                Button0.Enabled = true;
                ClearButton.Enabled = true;
                DeleteOneButton.Enabled = true;
            }
            InputTextBox.Text += (sender as Button).Text;
            if (operation == 5)
            {
                Num1AndOperationLabel.ResetText();
            }
            DecimalButton.Enabled = true;
            CalculateButton.Enabled = operation != 0;
            AddButton.Enabled = true;
            SubstractButton.Enabled = true;
            MultiplyButton.Enabled = true;
            DivideButton.Enabled = true;
        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            if (InputTextBox.Text == "0" || InputTextBox.Text == "-0")
            {
                clearall = false;

                Button0.Enabled = true;
                ClearButton.Enabled = true;
                DeleteOneButton.Enabled = true;
            }
            InputTextBox.Text += ',';
            DecimalButton.Enabled = false;
            AddButton.Enabled = false;
            SubstractButton.Enabled = false;
            MultiplyButton.Enabled = false;
            DivideButton.Enabled = false;
            CalculateButton.Enabled = false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control)
            {
                if (InputTextBox.Text.First() == '-')
                {
                    string tmp = InputTextBox.Text;

                    InputTextBox.Clear();
                    for (int repeats = 1; repeats < tmp.Length; repeats++)
                    {
                        InputTextBox.Text += tmp[repeats];
                    }
                    ClearButton.Enabled = InputTextBox.Text != "0";
                }
            }
            else
            {
                if (InputTextBox.Text != "0")
                {
                    if (operation == 1 || num1 == 0)
                    {
                        num1 += double.Parse(InputTextBox.Text);
                    }
                    else
                    {
                        switch (operation)
                        {
                            case 2:
                                num1 -= double.Parse(InputTextBox.Text);
                                break;
                            case 3:
                                num1 = num1 * double.Parse(InputTextBox.Text);
                                break;
                            case 4:
                                num1 = num1 / double.Parse(InputTextBox.Text);
                                break;
                        }
                    }
                }
                operation = 1;
                clearall = false;

                InputTextBox.Text = num1.ToString();
                Num1AndOperationLabel.Text = num1.ToString() + '+';
                CalculateButton.Enabled = true;
                ClearButton.Enabled = true;

                ClearButton_Click(sender, e);
            }
        }

        private void SubstractButton_Click(object sender, EventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control)
            {
                if (InputTextBox.Text.First() != '-')
                {
                    InputTextBox.Text = '-' + InputTextBox.Text;
                    ClearButton.Enabled = InputTextBox.Text != "0";
                }
            } else
            {
                if (InputTextBox.Text != "0")
                {
                    if (operation == 1 || num1 == 0)
                    {
                        num1 += double.Parse(InputTextBox.Text);
                    }
                    else
                    {
                        switch (operation)
                        {
                            case 2:
                                num1 -= double.Parse(InputTextBox.Text);
                                break;
                            case 3:
                                num1 = num1 * double.Parse(InputTextBox.Text);
                                break;
                            case 4:
                                num1 = num1 / double.Parse(InputTextBox.Text);
                                break;
                        }
                    }
                }
                operation = 2;
                clearall = false;

                InputTextBox.Text = num1.ToString();
                Num1AndOperationLabel.Text = num1.ToString() + '-';
                CalculateButton.Enabled = true;
                ClearButton.Enabled = true;

                ClearButton_Click(sender, e);
            }
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            if (InputTextBox.Text != "0")
            {
                if (operation == 1 || num1 == 0)
                {
                    num1 += double.Parse(InputTextBox.Text);
                }
                else
                {
                    switch (operation)
                    {
                        case 2:
                            num1 -= double.Parse(InputTextBox.Text);
                            break;
                        case 3:
                            num1 = num1 * double.Parse(InputTextBox.Text);
                            break;
                        case 4:
                            num1 = num1 / double.Parse(InputTextBox.Text);
                            break;
                    }
                }
            }
            operation = 3;
            clearall = false;

            InputTextBox.Text = num1.ToString();
            Num1AndOperationLabel.Text = num1.ToString() + '×';
            CalculateButton.Enabled = true;
            ClearButton.Enabled = true;

            ClearButton_Click(sender, e);
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            if (InputTextBox.Text != "0")
            {
                if (operation == 1 || num1 == 0)
                {
                    num1 += double.Parse(InputTextBox.Text);
                }
                else
                {
                    switch (operation)
                    {
                        case 2:
                            num1 -= double.Parse(InputTextBox.Text);
                            break;
                        case 3:
                            num1 = num1 * double.Parse(InputTextBox.Text);
                            break;
                        case 4:
                            num1 = num1 / double.Parse(InputTextBox.Text);
                            break;
                    }
                }
            }
            operation = 4;
            clearall = false;

            InputTextBox.Text = num1.ToString();
            Num1AndOperationLabel.Text = num1.ToString() + '÷';
            Button0.Enabled = false;
            CalculateButton.Enabled = InputTextBox.Text != "0";
            ClearButton.Enabled = num1 != 0 && num1 != -0;

            ClearButton_Click(sender, e);
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            char operationforlabel = '\0';
            double num2 = double.Parse(InputTextBox.Text);
            double answer = 0;

            switch (operation)
            {
                case 1:
                    operationforlabel = '+';
                    answer = num1 + num2;
                    break;
                case 2:
                    operationforlabel = '-';
                    answer = num1 - num2;
                    break;
                case 3:
                    operationforlabel = '×';
                    answer = num1 * num2;
                    break;
                case 4:
                    operationforlabel = '÷';
                    answer = num1 / num2;
                    break;
            }

            Num1AndOperationLabel.Text = num1.ToString() + operationforlabel + num2 + '=';

            num1 = 0;
            operation = 5;

            InputTextBox.Text = answer.ToString();
            Button0.Enabled = answer != 0 || answer != -0;
            CalculateButton.Enabled = false;
            DeleteOneButton.Enabled = answer != 0 || answer != -0;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (clearall || operation == 5)
            {
                num1 = 0;
                operation = 0;

                Num1AndOperationLabel.ResetText();
            }
            clearall = operation != 0;

            InputTextBox.ResetText();
            Button0.Enabled = false;
            DecimalButton.Enabled = true;
            AddButton.Enabled = true;
            SubstractButton.Enabled = true;
            MultiplyButton.Enabled = true;
            DivideButton.Enabled = true;
            ClearButton.Enabled = operation != 0;
            DeleteOneButton.Enabled = false;
            CalculateButton.Enabled = operation != 0 && operation != 4;
        }

        private void DeleteOneButton_Click(object sender, EventArgs e)
        {
            if (InputTextBox.Text.Length == 1 || (InputTextBox.Text.Length == 2 && InputTextBox.Text.First() == '0'))
            {
                Button0.Enabled = false;
                DecimalButton.Enabled = true;
                AddButton.Enabled = true;
                SubstractButton.Enabled = true;
                MultiplyButton.Enabled = true;
                DivideButton.Enabled = true;
                ClearButton.Enabled = operation != 0 || InputTextBox.Text != "0";
                DeleteOneButton.Enabled = false;
                CalculateButton.Enabled = operation != 0;
                InputTextBox.Text = "0";
            } else
            {
                string tmp = InputTextBox.Text;

                InputTextBox.Clear();
                for (int repeats = 0; repeats < tmp.Length - 1; repeats++)
                {
                    InputTextBox.Text += tmp[repeats];
                }
            }
        }

        private void MathForm_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyValue == (char)Keys.D0 || e.KeyValue == (char)Keys.NumPad0) && Button0.Enabled)
            {
                Button0_Click(Button0, null);
            } else if (e.KeyValue == (char)Keys.D1 || e.KeyValue == (char)Keys.NumPad1)
            {
                DigitButton_Click(Button1, null);
            } else if (e.KeyValue == (char)Keys.D2 || e.KeyValue == (char)Keys.NumPad2)
            {
                DigitButton_Click(Button2, null);
            } else if (e.KeyValue == (char)Keys.D3 || e.KeyValue == (char)Keys.NumPad3)
            {
                DigitButton_Click(Button3, null);
            } else if (e.KeyValue == (char)Keys.D4 || e.KeyValue == (char)Keys.NumPad4)
            {
                DigitButton_Click(Button4, null);
            } else if (e.KeyValue == (char)Keys.D5 || e.KeyValue == (char)Keys.NumPad5)
            {
                DigitButton_Click(Button5, null);
            } else if (e.KeyValue == (char)Keys.D6 || e.KeyValue == (char)Keys.NumPad6)
            {
                DigitButton_Click(Button6, null);
            } else if (e.KeyValue == (char)Keys.D7 || e.KeyValue == (char)Keys.NumPad7)
            {
                DigitButton_Click(Button7, null);
            } else if (e.KeyValue == (char)Keys.D8 || e.KeyValue == (char)Keys.NumPad8)
            {
                if (Control.ModifierKeys == Keys.Shift && MultiplyButton.Enabled)
                {
                    MultiplyButton_Click(MultiplyButton, null);
                }
                else
                {
                    DigitButton_Click(Button8, null);
                }
            } else if (e.KeyValue == (char)Keys.D9 || e.KeyValue == (char)Keys.NumPad9)
            {
                DigitButton_Click(Button9, null);
            } else if ((e.KeyValue == (char)Keys.Decimal || e.KeyValue == (char)Keys.Oemcomma || e.KeyValue == (char)Keys.OemPeriod) && DecimalButton.Enabled)
            {
                DecimalButton_Click(DecimalButton, null);
            } else if ((e.KeyValue == (char)Keys.Add || e.KeyValue == (char)Keys.Oemplus) && AddButton.Enabled)
            {
                AddButton_Click(AddButton, null);
            } else if ((e.KeyValue == (char)Keys.Subtract || e.KeyValue == (char)Keys.OemMinus) && SubstractButton.Enabled)
            {
                SubstractButton_Click(SubstractButton, null);
            } else if (e.KeyValue == (char)Keys.Multiply && MultiplyButton.Enabled)
            {
                MultiplyButton_Click(MultiplyButton, null);
            } else if ((e.KeyValue == (char)Keys.Divide || e.KeyValue == (char)Keys.OemQuestion) && DivideButton.Enabled)
            {
                DivideButton_Click(DivideButton, null);
            } else if (e.KeyValue == (char)Keys.Enter && CalculateButton.Enabled)
            {
                CalculateButton_Click(CalculateButton, null);
            } else if (e.KeyValue == (char)Keys.C && ClearButton.Enabled)
            {
                ClearButton_Click(ClearButton, null);
            } else if (e.KeyValue == (char)Keys.Back && DeleteOneButton.Enabled)
            {
                DeleteOneButton_Click(DeleteOneButton, null);
            } else if (Control.ModifierKeys == Keys.Control && e.KeyValue == (char)Keys.M)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void MathForm_Load(object sender, EventArgs e)
        {
            if (Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", "AppsUseLightTheme", -1) == null)
            {
                switch (Properties.Settings.Default.Theme)
                {
                    case 1:
                    case 2:
                        this.BackColor = Color.Empty;
                        Num1AndOperationLabel.ForeColor = Color.Empty;
                        break;
                    case 3:
                        this.BackColor = Color.Black;
                        Num1AndOperationLabel.ForeColor = Color.White;
                        break;
                }
            }
            else
            {
                switch (Properties.Settings.Default.Theme)
                {
                    case 1:
                        switch ((int)Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", "AppsUseLightTheme", -1))
                        {
                            case 0:
                                this.BackColor = Color.Black;
                                Num1AndOperationLabel.ForeColor = Color.White;
                                break;
                            case 1:
                                this.BackColor = Color.Empty;
                                Num1AndOperationLabel.ForeColor = Color.Empty;
                                break;
                        }
                        break;
                    case 2:
                        this.BackColor = Color.Empty;
                        Num1AndOperationLabel.ForeColor = Color.Empty;
                        break;
                    case 3:
                        this.BackColor = Color.Black;
                        Num1AndOperationLabel.ForeColor = Color.White;
                        break;
                }
            }
        }

        private void MathWidgetForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MathForm MathForm = new MathForm();
            MathForm.Show();
        }

        private void InputTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Alt && e.Button == MouseButtons.Left && DeleteOneButton.Enabled)
            {
                DeleteOneButton_Click(DeleteOneButton, null);
            }
        }
    }
}
