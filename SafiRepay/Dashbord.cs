using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialDesignColors;
using ToggleSwitch;

namespace SafiRepay
{
    public partial class frm_dashboard : MaterialForm
    {
        public frm_dashboard()
        {
            
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green400, Primary.Green600,
                Primary.Green900, Accent.Green400,
                TextShade.WHITE
            );
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.MaximizeBox = false;
            this.Sizable = false;
            this.AutoScaleMode = 0;
            this.AutoSize = false;
            this.AutoSizeMode = 0;
            this.StartPosition = 0;
        }

        private void frm_dashbord_Load(object sender, EventArgs e)
        {
            //tbc_dashboard.TabPages.Remove(tbp_utilisateurs); // todo if user isn't admin
        }

        private void frm_dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tbc_dashboard_Click(object sender, EventArgs e)
        {

        }


        private void tbc_dashboard_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tbc_dashboard.SelectedIndex == 0)
            {
                this.SkinManager.ColorScheme = new ColorScheme(
                Primary.Green400, Primary.Green600,
                Primary.Green900, Accent.Green400,
                TextShade.WHITE
                );
                /*foreach (Control x in this.Controls)
                {
                    if (x is TextBox)
                    {
                        ((TextBox)x).Text = String.Empty;
                    }

                }*/
            }
            if (this.tbc_dashboard.SelectedIndex == 1)
            {
                this.SkinManager.ColorScheme = new ColorScheme(
                Primary.Yellow800, Primary.Yellow900,
                Primary.Yellow900, Accent.Yellow400,
                TextShade.WHITE
                );
                
                /*foreach (Control x in this.Controls)
                {
                    if (x is TextBox)
                    {
                        ((TextBox)x).Text = String.Empty;
                    }

                }*/
            }
            if (this.tbc_dashboard.SelectedIndex == 2)
            {
                this.SkinManager.ColorScheme = new ColorScheme(
                Primary.Red400, Primary.Red600,
                Primary.Red900, Accent.Red400,
                TextShade.WHITE
                );
                /*foreach (Control x in this.Controls)
                {
                    if (x is TextBox)
                    {
                        ((TextBox)x).Text = String.Empty;
                    }

                }*/
            }
            if (this.tbc_dashboard.SelectedIndex == 3)
            {
                this.SkinManager.ColorScheme = new ColorScheme(
                Primary.Purple400, Primary.Purple600,
                Primary.Purple900, Accent.Purple400,
                TextShade.WHITE
                );
                /*foreach (Control x in this.Controls)
                {
                    if (x is TextBox)
                    {
                        ((TextBox)x).Text = String.Empty;
                    }
                    https://www.codeproject.com/Articles/451742/Extending-Csharp-ListView-with-Collapsible-Groups
                }*/
            }
        }
    }
}

