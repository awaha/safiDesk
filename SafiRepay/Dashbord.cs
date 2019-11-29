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
            MyOwnColorManagement(this);
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
                    ((Label)myControl).BackColor = materialPrimaryColor;
                    ((Label)myControl).ForeColor = GetMyColor(TextShade.WHITE);
                    ((Label)myControl).Font = new Font("Roboto", ((Label)myControl).Font.Size); //Just Exemples
                }
                if (myControl is Button)
                {
                    ((Button)myControl).ForeColor = Color.FromArgb(255, 0, 0); //Here is another way to set a personal color
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
                                ((Label)oneTabControl).BackColor = materialPrimaryColor;
                                ((Label)oneTabControl).ForeColor = GetMyColor(TextShade.WHITE);
                                ((Label)oneTabControl).Font = new Font("Roboto", ((Label)oneTabControl).Font.Size); //Just Exemples
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
                MyOwnColorManagement(this);
            }
            if (this.tbc_dashboard.SelectedIndex == 1)
            {
                this.SkinManager.ColorScheme = new ColorScheme(
                Primary.Yellow800, Primary.Yellow900,
                Primary.Yellow900, Accent.Yellow400,
                TextShade.WHITE
                );
                MyOwnColorManagement(this);
            }
            if (this.tbc_dashboard.SelectedIndex == 2)
            {
                this.SkinManager.ColorScheme = new ColorScheme(
                Primary.Red400, Primary.Red600,
                Primary.Red900, Accent.Red400,
                TextShade.WHITE
                );
                MyOwnColorManagement(this);
            }
            if (this.tbc_dashboard.SelectedIndex == 3)
            {
                this.SkinManager.ColorScheme = new ColorScheme(
                Primary.Purple400, Primary.Purple600,
                Primary.Purple900, Accent.Purple400,
                TextShade.WHITE
                );
                MyOwnColorManagement(this);
                   //https://www.codeproject.com/Articles/451742/Extending-Csharp-ListView-with-Collapsible-Groups

            }
        }

    }
}

