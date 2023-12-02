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
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            if (Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", "AppsUseLightTheme", -1) == null)
            {
                switch (Properties.Settings.Default.Theme)
                {
                    case 1: case 2:
                        this.BackColor = Color.Empty;
                        ProgramNameLabel.ForeColor = Color.Empty;
                        ProgramVersionLabel.ForeColor = Color.Empty;
                        ProgramDeveloperLabel.ForeColor = Color.Empty;
                        ProgramDescriptionLabel.ForeColor = Color.Empty;
                        break;
                    case 3:
                        this.BackColor = Color.Black;
                        ProgramNameLabel.ForeColor = Color.White;
                        ProgramVersionLabel.ForeColor = Color.White;
                        ProgramDeveloperLabel.ForeColor = Color.White;
                        ProgramDescriptionLabel.ForeColor = Color.White;
                        break;
                }
            } else
            {
                switch (Properties.Settings.Default.Theme)
                {
                    case 1:
                        switch ((int)Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", "AppsUseLightTheme", -1))
                        {
                            case 0:
                                this.BackColor = Color.Black;
                                ProgramNameLabel.ForeColor = Color.White;
                                ProgramVersionLabel.ForeColor = Color.White;
                                ProgramDeveloperLabel.ForeColor = Color.White;
                                ProgramDescriptionLabel.ForeColor = Color.White;
                                break;
                            case 1:
                                this.BackColor = Color.Empty;
                                ProgramNameLabel.ForeColor = Color.Empty;
                                ProgramVersionLabel.ForeColor = Color.Empty;
                                ProgramDeveloperLabel.ForeColor = Color.Empty;
                                ProgramDescriptionLabel.ForeColor = Color.Empty;
                                break;
                        }
                        break;
                    case 2:
                        this.BackColor = Color.Empty;
                        ProgramNameLabel.ForeColor = Color.Empty;
                        ProgramVersionLabel.ForeColor = Color.Empty;
                        ProgramDeveloperLabel.ForeColor = Color.Empty;
                        ProgramDescriptionLabel.ForeColor = Color.Empty;
                        break;
                    case 3:
                        this.BackColor = Color.Black;
                        ProgramNameLabel.ForeColor = Color.White;
                        ProgramVersionLabel.ForeColor = Color.White;
                        ProgramDeveloperLabel.ForeColor = Color.White;
                        ProgramDescriptionLabel.ForeColor = Color.White;
                        break;
                }
            }
        }
    }
}
