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
            MyOwnColorManagement(this);
        }
        public static void MyOwnColorManagement(MaterialForm myForm)
        {
            //Initialisation
            ColorScheme materialColor = myForm.SkinManager.ColorScheme;
            var materialPrimaryDarkColor = materialColor.DarkPrimaryColor;
            var materialPrimaryColor = materialColor.PrimaryColor;
            var materialLightPrimaryColor = materialColor.LightPrimaryColor;
            var materialAccentColor = materialColor.AccentColor;
            foreach (Control myControl in myForm.Controls)
            {
                //Changes the colors depending of the control, if special colors need to apply for a certain control call it with GetMyColor(colorYouNeeds) after using MyOwnColorManagement
                if (myControl is Label)
                {

                    ((Label)myControl).ForeColor = GetMyColor(TextShade.WHITE);
                    ((Label)myControl).Font = new Font("Roboto", ((Label)myControl).Font.Size); //Just Exemples
                }
                if (myControl is Button)
                {
                    ((Button)myControl).ForeColor = GetMyColor(TextShade.WHITE); //Here is another way to set a personal color
                    ((Button)myControl).BackColor = materialPrimaryColor;
                }
                if (myControl is MaterialTabControl) // To apply special colors for controls into TabControls, we must do this : 
                {
                    MaterialTabControl.TabPageCollection myTabPages = ((MaterialTabControl)myControl).TabPages;
                    foreach (TabPage myTabPage in myTabPages)
                    {
                        foreach (Control oneTabControl in myTabPage.Controls)
                        {
                            if (oneTabControl is Label)
                            {

                                ((Label)oneTabControl).ForeColor = GetMyColor(TextShade.WHITE);
                                ((Label)oneTabControl).Font = new Font("Roboto", ((Label)oneTabControl).Font.Size); //Just Exemples
                            }
                            if (oneTabControl is Button)
                            {
                                ((Button)oneTabControl).ForeColor = GetMyColor(TextShade.WHITE); //Here is another way to set a personal color
                                ((Button)oneTabControl).BackColor = materialPrimaryColor;
                            }
                        }
                    }
                }
            }
        }
        public static Color GetMyColor(Enum colorToConvert) //get a color from Material's value like TextShade.WHITE or Primary.Yellow800 or Accent.Red500
        {
            return ColorTranslator.FromHtml("#" + (Convert.ToInt32(colorToConvert.GetHashCode())).ToString("X"));
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void Btn_connection_Click(object sender, EventArgs e)
        {
            try
            {
                string username = tbx_login.Text;
                string psw = tbx_password.Text;

                RAO.User userWantsConnection = RAO.User.getLogin(username, psw);
                //userWantsConnection est forcément différent de null
                //Si Connection ok
                if (userWantsConnection != null)
                {

                    // Revenir au Dashboard qui montre les données du user connecté
                    MaterialForm dashboard = new frm_dashboard(userWantsConnection);
                    dashboard.Show();
                    // Kill le frm_login
                    Hide();
                }
            }
            catch { MessageBox.Show("connection impossible"); }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btn_showParameters_MouseHover(object sender, EventArgs e)
        {
            btn_showParameters.Visible = true;
        }

        private void btn_showParameters_Click(object sender, EventArgs e)
        {
            if(btn_apiValider.Visible == false)
            {
                btn_apiValider.Visible = true;
                lbl_changeIp.Visible = true;
                tbx_ipApi.Visible = true;
            }
            else
            {
                btn_apiValider.Visible = false;
                lbl_changeIp.Visible = false;
                tbx_ipApi.Visible = false;
            }
            
        }

        private void btn_showParameters_MouseLeave(object sender, EventArgs e)
        {
            btn_showParameters.Visible = false;
        }

        private void pbx_safi_Click(object sender, EventArgs e)
        {
            if (btn_apiValider.Visible == false)
            {
                btn_apiValider.Visible = true;
                lbl_changeIp.Visible = true;
                tbx_ipApi.Visible = true;
            }
            else
            {
                btn_apiValider.Visible = false;
                lbl_changeIp.Visible = false;
                tbx_ipApi.Visible = false;
            }
        }

        private void btn_apiValider_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.routeApi = "http://"+tbx_ipApi.Text+":8000/api/";
            MessageBox.Show("Changement effectué, les données seront maintenant récupérés à l'adresse : " + Properties.Settings.Default.routeApi);
            btn_apiValider.Visible = false;
            lbl_changeIp.Visible = false;
            tbx_ipApi.Visible = false;
        }
    }
}
