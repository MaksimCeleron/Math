using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Math
{
    public partial class MathForm : Form
    {
        float num1 = 0;
        int operation = 0;
        bool clearall = false;

        public MathForm()
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

        private void Button1_Click(object sender, EventArgs e)
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
            InputTextBox.Text += '1';
            DecimalButton.Enabled = true;
            CalculateButton.Enabled = operation != 0;
            AddButton.Enabled = true;
            SubstractButton.Enabled = true;
            MultiplyButton.Enabled = true;
            DivideButton.Enabled = true;
        }

        private void Button2_Click(object sender, EventArgs e)
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
            InputTextBox.Text += '2';
            DecimalButton.Enabled = true;
            CalculateButton.Enabled = operation != 0;
            AddButton.Enabled = true;
            SubstractButton.Enabled = true;
            MultiplyButton.Enabled = true;
            DivideButton.Enabled = true;
        }

        private void Button3_Click(object sender, EventArgs e)
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
            InputTextBox.Text += '3';
            DecimalButton.Enabled = true;
            CalculateButton.Enabled = operation != 0;
            AddButton.Enabled = true;
            SubstractButton.Enabled = true;
            MultiplyButton.Enabled = true;
            DivideButton.Enabled = true;
        }

        private void Button4_Click(object sender, EventArgs e)
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
            InputTextBox.Text += '4';
            DecimalButton.Enabled = true;
            CalculateButton.Enabled = operation != 0;
            AddButton.Enabled = true;
            SubstractButton.Enabled = true;
            MultiplyButton.Enabled = true;
            DivideButton.Enabled = true;
        }

        private void Button5_Click(object sender, EventArgs e)
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
            InputTextBox.Text += '5';
            DecimalButton.Enabled = true;
            CalculateButton.Enabled = operation != 0;
            AddButton.Enabled = true;
            SubstractButton.Enabled = true;
            MultiplyButton.Enabled = true;
            DivideButton.Enabled = true;
        }

        private void Button6_Click(object sender, EventArgs e)
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
            InputTextBox.Text += '6';
            DecimalButton.Enabled = true;
            CalculateButton.Enabled = operation != 0;
            AddButton.Enabled = true;
            SubstractButton.Enabled = true;
            MultiplyButton.Enabled = true;
            DivideButton.Enabled = true;
        }

        private void Button7_Click(object sender, EventArgs e)
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
            InputTextBox.Text += '7';
            DecimalButton.Enabled = true;
            CalculateButton.Enabled = operation != 0;
            AddButton.Enabled = true;
            SubstractButton.Enabled = true;
            MultiplyButton.Enabled = true;
            DivideButton.Enabled = true;
        }

        private void Button8_Click(object sender, EventArgs e)
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
            InputTextBox.Text += '8';
            DecimalButton.Enabled = true;
            CalculateButton.Enabled = operation != 0;
            AddButton.Enabled = true;
            SubstractButton.Enabled = true;
            MultiplyButton.Enabled = true;
            DivideButton.Enabled = true;
        }

        private void Button9_Click(object sender, EventArgs e)
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
            InputTextBox.Text += '9';
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
                if (InputTextBox.Text[0] == '-')
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
                if (operation == 1 || num1 == 0)
                {
                    num1 += float.Parse(InputTextBox.Text);
                }
                else
                {
                    switch (operation)
                    {
                        case 2:
                            num1 -= float.Parse(InputTextBox.Text);
                            break;
                        case 3:
                            num1 = num1 * float.Parse(InputTextBox.Text);
                            break;
                        case 4:
                            num1 = num1 / float.Parse(InputTextBox.Text);
                            break;
                    }
                }
                operation = 1;
                clearall = InputTextBox.Text == "0";

                InputTextBox.Text = num1.ToString();
                Num1AndOperationLabel.Text = num1.ToString() + '+';
                CalculateButton.Enabled = true;
                ClearButton.Enabled = true;
            }
        }

        private void SubstractButton_Click(object sender, EventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control)
            {
                if (InputTextBox.Text[0] != '-')
                {
                    InputTextBox.Text = '-' + InputTextBox.Text;
                    ClearButton.Enabled = InputTextBox.Text != "0";
                }
            } else
            {
                if (operation == 1 || num1 == 0)
                {
                    num1 += float.Parse(InputTextBox.Text);
                }
                else
                {
                    switch (operation)
                    {
                        case 2:
                            num1 -= float.Parse(InputTextBox.Text);
                            break;
                        case 3:
                            num1 = num1 * float.Parse(InputTextBox.Text);
                            break;
                        case 4:
                            num1 = num1 / float.Parse(InputTextBox.Text);
                            break;
                    }
                }
                operation = 2;
                clearall = InputTextBox.Text == "0";

                InputTextBox.Text = num1.ToString();
                Num1AndOperationLabel.Text = num1.ToString() + '-';
                CalculateButton.Enabled = true;
                ClearButton.Enabled = true;
            }
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            if (operation == 1 || num1 == 0)
            {
                num1 += float.Parse(InputTextBox.Text);
            }
            else
            {
                switch (operation)
                {
                    case 2:
                        num1 -= float.Parse(InputTextBox.Text);
                        break;
                    case 3:
                        num1 = num1 * float.Parse(InputTextBox.Text);
                        break;
                    case 4:
                        num1 = num1 / float.Parse(InputTextBox.Text);
                        break;
                }
            }
            operation = 3;
            clearall = InputTextBox.Text == "0";

            InputTextBox.Text = num1.ToString();
            Num1AndOperationLabel.Text = num1.ToString() + '+';
            CalculateButton.Enabled = true;
            ClearButton.Enabled = true;
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            if (operation == 1 || num1 == 0)
            {
                num1 += float.Parse(InputTextBox.Text);
            }
            else
            {
                switch (operation)
                {
                    case 2:
                        num1 -= float.Parse(InputTextBox.Text);
                        break;
                    case 3:
                        num1 = num1 * float.Parse(InputTextBox.Text);
                        break;
                    case 4:
                        num1 = num1 / float.Parse(InputTextBox.Text);
                        break;
                }
            }
            operation = 4;
            clearall = InputTextBox.Text == "0";

            InputTextBox.Text = num1.ToString();
            Num1AndOperationLabel.Text = num1.ToString() + '+';
            Button0.Enabled = false;
            CalculateButton.Enabled = InputTextBox.Text != "0";
            ClearButton.Enabled = num1 != 0 && num1 != -0;
        }

        private void PositiveNegativeButton_Click(object sender, EventArgs e)
        {
            if (InputTextBox.Text[0] == '-')
            {
                string tmp = InputTextBox.Text;

                InputTextBox.Clear();
                for (int repeats = 1; repeats < tmp.Length; repeats++)
                {
                    InputTextBox.Text += tmp[repeats];
                }
            }
            else
            {
                InputTextBox.Text = '-' + InputTextBox.Text;
            }
            ClearButton.Enabled = InputTextBox.Text != "0";
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            float answer = 0;

            switch (operation)
            {
                case 1:
                    answer = num1 + float.Parse(InputTextBox.Text);
                    break;
                case 2:
                    answer = num1 - float.Parse(InputTextBox.Text);
                    break;
                case 3:
                    answer = num1 * float.Parse(InputTextBox.Text);
                    break;
                case 4:
                    answer = num1 / float.Parse(InputTextBox.Text);
                    break;
            }

            num1 = 0;
            operation = 5;

            InputTextBox.Text = answer.ToString();
            Num1AndOperationLabel.Text = "";
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

                Num1AndOperationLabel.Text = "";
            }
            clearall = operation != 0;

            InputTextBox.Text = "0";
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
            if (InputTextBox.Text.Length == 1 || (InputTextBox.Text.Length == 2 && InputTextBox.Text[0] == '0'))
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
                Button1_Click(Button1, null);
            } else if (e.KeyValue == (char)Keys.D2 || e.KeyValue == (char)Keys.NumPad2)
            {
                Button2_Click(Button2, null);
            } else if (e.KeyValue == (char)Keys.D3 || e.KeyValue == (char)Keys.NumPad3)
            {
                Button3_Click(Button3, null);
            } else if (e.KeyValue == (char)Keys.D4 || e.KeyValue == (char)Keys.NumPad4)
            {
                Button4_Click(Button4, null);
            } else if (e.KeyValue == (char)Keys.D5 || e.KeyValue == (char)Keys.NumPad5)
            {
                Button5_Click(Button5, null);
            } else if (e.KeyValue == (char)Keys.D6 || e.KeyValue == (char)Keys.NumPad6)
            {
                Button6_Click(Button6, null);
            } else if (e.KeyValue == (char)Keys.D7 || e.KeyValue == (char)Keys.NumPad7)
            {
                Button7_Click(Button7, null);
            } else if (e.KeyValue == (char)Keys.D8 || e.KeyValue == (char)Keys.NumPad8)
            {
                if (Control.ModifierKeys == Keys.Shift && MultiplyButton.Enabled)
                {
                    MultiplyButton_Click(MultiplyButton, null);
                }
                else
                {
                    Button8_Click(Button8, null);
                }
            } else if (e.KeyValue == (char)Keys.D9 || e.KeyValue == (char)Keys.NumPad9)
            {
                Button9_Click(Button9, null);
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
            }
        }

        private void AutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch ((int)Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", "AppsUseLightTheme", -1))
            {
                case 0:
                    DarkToolStripMenuItem_Click(DarkToolStripMenuItem, null);
                    break;
                case 1:
                    LightToolStripMenuItem_Click(LightToolStripMenuItem, null);
                    break;
            }

            Properties.Settings.Default.Theme = 1;
            Properties.Settings.Default.Save();

            AutoToolStripMenuItem.Checked = true;
            LightToolStripMenuItem.Checked = false;
            DarkToolStripMenuItem.Checked = false;
        }

        private void LightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Empty;
            MenuStrip.BackColor = Color.FromArgb(255, 227, 227, 227);
            AutoToolStripMenuItem.BackColor = Color.Empty;
            AutoToolStripMenuItem.ForeColor = Color.Empty;
            LightToolStripMenuItem.BackColor = Color.Empty;
            LightToolStripMenuItem.ForeColor = Color.Empty;
            DarkToolStripMenuItem.BackColor = Color.Empty;
            DarkToolStripMenuItem.ForeColor = Color.Empty;
            Num1AndOperationLabel.ForeColor = Color.Empty;

            Properties.Settings.Default.Theme = 2;
            Properties.Settings.Default.Save();

            AutoToolStripMenuItem.Checked = false;
            LightToolStripMenuItem.Checked = true;
            DarkToolStripMenuItem.Checked = false;
        }

        private void DarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            MenuStrip.BackColor = Color.LightGray;
            AutoToolStripMenuItem.BackColor = Color.Black;
            AutoToolStripMenuItem.ForeColor = Color.White;
            LightToolStripMenuItem.BackColor = Color.Black;
            LightToolStripMenuItem.ForeColor = Color.White;
            DarkToolStripMenuItem.BackColor = Color.Black;
            DarkToolStripMenuItem.ForeColor = Color.White;
            Num1AndOperationLabel.ForeColor = Color.White;

            Properties.Settings.Default.Theme = 3;
            Properties.Settings.Default.Save();

            AutoToolStripMenuItem.Checked = false;
            LightToolStripMenuItem.Checked = false;
            DarkToolStripMenuItem.Checked = true;
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm AboutForm = new AboutForm();
            AboutForm.ShowDialog();
        }

        private void MathForm_Load(object sender, EventArgs e)
        {
            if (Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", "AppsUseLightTheme", -1) == null)
            {
                AutoToolStripMenuItem.Available = false;

                switch (Properties.Settings.Default.Theme)
                {
                    case 1: case 2:
                        LightToolStripMenuItem_Click(LightToolStripMenuItem, null);
                        break;
                    case 3:
                        DarkToolStripMenuItem_Click(DarkToolStripMenuItem, null);
                        break;
                }
            } else
            {
                switch (Properties.Settings.Default.Theme)
                {
                    case 1:
                        AutoToolStripMenuItem_Click(AutoToolStripMenuItem, null);
                        break;
                    case 2:
                        LightToolStripMenuItem_Click(LightToolStripMenuItem, null);
                        break;
                    case 3:
                        DarkToolStripMenuItem_Click(DarkToolStripMenuItem, null);
                        break;
                }
            }
        }
    }
}
