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
    public partial class frm_personnalParam : MaterialForm
    {
        MaterialForm dashboard;
        public frm_personnalParam(MaterialForm form)
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            this.dashboard = form;
            // Configure color schema
            this.SkinManager.ColorScheme = new ColorScheme(
                Primary.Red400, Primary.Red600,
                Primary.Red900, Accent.Red400,
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

                    ((Label)myControl).ForeColor = GetMyColor(TextShade.WHITE);
                    ((Label)myControl).Font = new Font("Roboto", ((Label)myControl).Font.Size); //Just Exemples
                }
                if (myControl is CheckBox)
                {
                    ((CheckBox)myControl).ForeColor = GetMyColor(TextShade.WHITE);
                    ((CheckBox)myControl).Font = new Font("Roboto", ((CheckBox)myControl).Font.Size);

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
                            if (oneTabControl is CheckBox)
                            {
                                ((CheckBox)oneTabControl).ForeColor = GetMyColor(TextShade.WHITE);
                                ((CheckBox)oneTabControl).Font = new Font("Roboto", ((CheckBox)oneTabControl).Font.Size);

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

        private void frm_personnalParam_Load(object sender, EventArgs e)
        {
            var ps = Properties.Settings.Default;
            cbx_horsForfait.Checked = ps.param_auto_HF;
            cbx_move.Checked = ps.param_auto_move;
            cbx_nuitee.Checked = ps.param_auto_nuite;
            cbx_repasMidi.Checked = ps.param_auto_repasMidi;
            cbx_relais.Checked = ps.param_auto_relais;
            cbx_limitMove.Checked = ps.param_limitMove_able;

            cbx_justificatif.Checked = ps.param_HF_justificatif;
            cbx_move_limit.Checked = ps.param_move_limit_isAble;
            cbx_nuitee_limit.Checked = ps.param_nuite_limit_isAble;
            cbx_relais_limit.Checked = ps.param_relais_limit_isAble;
            cbx_repasMidi_limit.Checked = ps.param_repasMidi_limit_isAble;

            tbx_horsForfait_start.Text = ps.param_HF_start.ToString();
            tbx_horsForfait_end.Text = ps.param_HF_end.ToString();

            tbx_repasMidi.Text = ps.param_repasMidi_value.ToString();
            tbx_repasMidi_limit.Text = ps.param_repasMidi_limit.ToString();

            tbx_relais.Text = ps.param_relais_value.ToString();
            tbx_relais_limit.Text = ps.param_relais_limit.ToString();

            tbx_nuitee.Text = ps.param_nuite_value.ToString();
            tbx_nuitee_limit.Text = ps.param_nuite_limit.ToString();

            tbx_move.Text = ps.param_move_value.ToString();
            tbx_move_limit.Text = ps.param_move_limit.ToString();
            tbx_move_limit_km.Text = ps.param_limitMove_km.ToString();

            swc_horsForfait.Checked = ps.param_HF_isManual;
            swc_repasMidi.Checked = ps.param_repasMidi_isManual;
            swc_relais.Checked = ps.param_relais_isManual;
            swc_nuitee.Checked = ps.param_nuite_isManual;
            swc_move.Checked = ps.param_move_isManual;
            swc_moveLimit.Checked = ps.param_limitMove_isManual;

            dashboard.Hide();
        }

        private void btn_selUnsel_global_Click(object sender, EventArgs e)
        {
            if(cbx_horsForfait.Checked == true)
            {
                cbx_horsForfait.Checked = false;
                cbx_move.Checked = false;
                cbx_nuitee.Checked = false;
                cbx_repasMidi.Checked = false;
                cbx_relais.Checked = false;
                cbx_limitMove.Checked = false;
            }
            else
            {
                cbx_horsForfait.Checked = true;
                cbx_move.Checked = true;
                cbx_nuitee.Checked = true;
                cbx_repasMidi.Checked = true;
                cbx_relais.Checked = true;
                cbx_limitMove.Checked = true;
            }

        }

        private void btn_selUnsel_limit_Click(object sender, EventArgs e)
        {
            if(cbx_justificatif.Checked == true)
            {
                cbx_justificatif.Checked = false;
                cbx_move_limit.Checked = false;
                cbx_nuitee_limit.Checked = false;
                cbx_relais_limit.Checked = false;
                cbx_repasMidi_limit.Checked = false;
            }
            else
            {
                cbx_justificatif.Checked = true;
                cbx_move_limit.Checked = true;
                cbx_nuitee_limit.Checked = true;
                cbx_relais_limit.Checked = true;
                cbx_repasMidi_limit.Checked = true;
            }
        }

        private void btn_selUnsel_manual_Click(object sender, EventArgs e)
        {
            if(swc_horsForfait.Checked == true)
            {
                swc_horsForfait.Checked = false;
                swc_repasMidi.Checked = false;
                swc_relais.Checked = false;
                swc_nuitee.Checked = false;
                swc_move.Checked = false;
                swc_moveLimit.Checked = false;
            }
            else
            {
                swc_horsForfait.Checked = true;
                swc_repasMidi.Checked = true;
                swc_relais.Checked = true;
                swc_nuitee.Checked = true;
                swc_move.Checked = true;
                swc_moveLimit.Checked = true;
            }
            
        }

        private void btn_save_modification_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.param_auto_HF = cbx_horsForfait.Checked;
            Properties.Settings.Default.param_auto_move = cbx_move.Checked;
            Properties.Settings.Default.param_auto_nuite = cbx_nuitee.Checked;
            Properties.Settings.Default.param_auto_repasMidi = cbx_repasMidi.Checked;
            Properties.Settings.Default.param_auto_relais = cbx_relais.Checked;
            Properties.Settings.Default.param_limitMove_able = cbx_limitMove.Checked;

            Properties.Settings.Default.param_HF_justificatif = cbx_justificatif.Checked;
            Properties.Settings.Default.param_move_limit_isAble = cbx_move_limit.Checked;
            Properties.Settings.Default.param_nuite_limit_isAble = cbx_nuitee_limit.Checked;
            Properties.Settings.Default.param_relais_limit_isAble = cbx_relais_limit.Checked;
            Properties.Settings.Default.param_repasMidi_limit_isAble = cbx_repasMidi_limit.Checked;

            Properties.Settings.Default.param_HF_start = Convert.ToInt32(tbx_horsForfait_start.Text);
            Properties.Settings.Default.param_HF_end = Convert.ToInt32(tbx_horsForfait_end.Text);

            Properties.Settings.Default.param_repasMidi_value = Convert.ToInt32(tbx_repasMidi.Text);
            Properties.Settings.Default.param_repasMidi_limit = Convert.ToInt32(tbx_repasMidi_limit.Text);

            Properties.Settings.Default.param_relais_value = Convert.ToInt32(tbx_relais.Text);
            Properties.Settings.Default.param_relais_limit = Convert.ToInt32(tbx_relais_limit.Text);

            Properties.Settings.Default.param_nuite_value = Convert.ToInt32(tbx_nuitee.Text);
            Properties.Settings.Default.param_nuite_limit = Convert.ToInt32(tbx_nuitee_limit.Text);

            Properties.Settings.Default.param_move_value = Convert.ToInt32(tbx_move.Text);
            Properties.Settings.Default.param_move_limit = Convert.ToInt32(tbx_move_limit.Text);
            Properties.Settings.Default.param_limitMove_km = Convert.ToInt32(tbx_move_limit_km.Text);

            Properties.Settings.Default.param_HF_isManual = swc_horsForfait.Checked;
            Properties.Settings.Default.param_repasMidi_isManual = swc_repasMidi.Checked;
            Properties.Settings.Default.param_relais_isManual = swc_relais.Checked;
            Properties.Settings.Default.param_nuite_isManual = swc_nuitee.Checked;
            Properties.Settings.Default.param_move_isManual = swc_move.Checked;
            Properties.Settings.Default.param_limitMove_isManual = swc_moveLimit.Checked;

            Properties.Settings.Default.Save();
            this.Hide();
            MessageBox.Show("Changement enregistrés");
            this.Close();
        }

        private void Frm_personnalParam_FormClosing(object sender, FormClosingEventArgs e)
        {
            dashboard.Show();
            System.Threading.Thread.Sleep(200);
        }


    }
}
