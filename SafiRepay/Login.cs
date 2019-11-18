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

namespace SafiRepay
{
    public partial class frm_login : MaterialForm
    {
        public frm_login()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Cyan400, Primary.Cyan600,
                Primary.Cyan900, Accent.Cyan400,
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

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void Btn_connection_Click(object sender, EventArgs e)
        {
            frm_dashboard frm_Dashboard = new frm_dashboard();
            frm_Dashboard.Show();
            this.Hide();
        }
    }
}
