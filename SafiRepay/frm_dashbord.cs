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
        public RAO.User myActualUser;
        public frm_dashboard(RAO.User myActualUser)
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
            tbx_serviceComptable.BackColor = this.SkinManager.ColorScheme.PrimaryColor; 
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.MaximizeBox = false;
            this.Sizable = false;
            this.AutoScaleMode = 0;
            this.AutoSize = false;
            this.AutoSizeMode = 0;
            this.StartPosition = 0;
            this.myActualUser = myActualUser;
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
                    ((Button)myControl).FlatStyle = FlatStyle.Flat;
                    ((Button)myControl).FlatAppearance.BorderSize = 0;
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
                                ((Button)oneTabControl).FlatStyle = FlatStyle.Flat;
                                ((Button)oneTabControl).FlatAppearance.BorderSize = 0;
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
            tbx_nomPrenom.Text = (myActualUser.lastname).ToUpper() + ' ' + myActualUser.firstname;
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
                tbx_serviceComptable.BackColor = this.SkinManager.ColorScheme.PrimaryColor;
            }
            if (this.tbc_dashboard.SelectedIndex == 1)
            {
                this.SkinManager.ColorScheme = new ColorScheme(
                Primary.Yellow800, Primary.Yellow900,
                Primary.Yellow900, Accent.Yellow400,
                TextShade.WHITE
                );
                MyOwnColorManagement(this);
                tbx_serviceComptable.BackColor = this.SkinManager.ColorScheme.PrimaryColor;
            }
            if (this.tbc_dashboard.SelectedIndex == 2)
            {
                this.SkinManager.ColorScheme = new ColorScheme(
                Primary.Red400, Primary.Red600,
                Primary.Red900, Accent.Red400,
                TextShade.WHITE
                );
                MyOwnColorManagement(this);
                tbx_serviceComptable.BackColor = this.SkinManager.ColorScheme.PrimaryColor;
                List<RAO.PackageType> packageType = RAO.PackageType.getFixedCosts();
                foreach (RAO.PackageType OnePackageType in packageType)
                {
                    switch(Convert.ToInt32(OnePackageType.id))
                    {
                        case 1:
                            //Console.WriteLine(OnePackageType.name + " = " + OnePackageType.amountMax);
                            tbx_repasMidi.Text = OnePackageType.amountMax;
                            break;
                        case 2:
                            //Console.WriteLine(OnePackageType.name + " = " + OnePackageType.amountMax);
                            tbx_relaisEtape.Text = OnePackageType.amountMax;
                            break;
                        case 3:
                            //Console.WriteLine(OnePackageType.name + " = " + OnePackageType.amountMax);
                            tbx_nuitee.Text = OnePackageType.amountMax;
                            break;
                        case 4:
                            //Console.WriteLine(OnePackageType.name + " = " + OnePackageType.amountMax);
                            tbx_kilometre.Text = OnePackageType.amountMax;
                            break;
                        default:
                            //Console.WriteLine("default");
                            break;
                    }
                }
                
            }
            if (this.tbc_dashboard.SelectedIndex == 3)
            {
                this.SkinManager.ColorScheme = new ColorScheme(
                Primary.Purple400, Primary.Purple600,
                Primary.Purple900, Accent.Purple400,
                TextShade.WHITE
                );
                MyOwnColorManagement(this);
                tbx_serviceComptable.BackColor = this.SkinManager.ColorScheme.PrimaryColor;
                //https://www.codeproject.com/Articles/451742/Extending-Csharp-ListView-with-Collapsible-Groups
                
            }
        }

        private void btn_personnalParam_Click(object sender, EventArgs e)
        {
            frm_personnalParam paramForm = new frm_personnalParam(this);
            paramForm.Show();
        }

        private void btn_Enregistrer_Click(object sender, EventArgs e)
        {
            RAO.PackageType.updateFixedCost(1,Convert.ToInt32(tbx_repasMidi.Text));
            RAO.PackageType.updateFixedCost(2, Convert.ToInt32(tbx_relaisEtape.Text));
            RAO.PackageType.updateFixedCost(3, Convert.ToInt32(tbx_nuitee.Text));
            RAO.PackageType.updateFixedCost(4, Convert.ToInt32(tbx_kilometre.Text));
        }
    }
}

