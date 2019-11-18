namespace SafiRepay
{
    partial class frm_login
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.tbx_login = new System.Windows.Forms.TextBox();
            this.cbx_enregistrerIdentifiant = new MaterialSkin.Controls.MaterialCheckBox();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.btn_connection = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbl_login = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_password = new MaterialSkin.Controls.MaterialLabel();
            this.pbx_iconseil = new System.Windows.Forms.PictureBox();
            this.pbx_safiRepay = new System.Windows.Forms.PictureBox();
            this.pbx_safi = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_iconseil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_safiRepay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_safi)).BeginInit();
            this.SuspendLayout();
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(0, 0);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(0, 1);
            this.materialDivider1.TabIndex = 0;
            // 
            // tbx_login
            // 
            this.tbx_login.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbx_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_login.Location = new System.Drawing.Point(852, 358);
            this.tbx_login.Name = "tbx_login";
            this.tbx_login.Size = new System.Drawing.Size(193, 29);
            this.tbx_login.TabIndex = 3;
            // 
            // cbx_enregistrerIdentifiant
            // 
            this.cbx_enregistrerIdentifiant.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbx_enregistrerIdentifiant.Depth = 0;
            this.cbx_enregistrerIdentifiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbx_enregistrerIdentifiant.Location = new System.Drawing.Point(852, 518);
            this.cbx_enregistrerIdentifiant.Margin = new System.Windows.Forms.Padding(0);
            this.cbx_enregistrerIdentifiant.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbx_enregistrerIdentifiant.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbx_enregistrerIdentifiant.Name = "cbx_enregistrerIdentifiant";
            this.cbx_enregistrerIdentifiant.Ripple = true;
            this.cbx_enregistrerIdentifiant.Size = new System.Drawing.Size(193, 31);
            this.cbx_enregistrerIdentifiant.TabIndex = 4;
            this.cbx_enregistrerIdentifiant.Text = "Enregistrer l\'identifiant";
            this.cbx_enregistrerIdentifiant.UseVisualStyleBackColor = true;
            // 
            // tbx_password
            // 
            this.tbx_password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbx_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_password.Location = new System.Drawing.Point(852, 441);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.Size = new System.Drawing.Size(193, 29);
            this.tbx_password.TabIndex = 5;
            // 
            // btn_connection
            // 
            this.btn_connection.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_connection.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_connection.Depth = 0;
            this.btn_connection.Font = new System.Drawing.Font("Miriam CLM", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_connection.Location = new System.Drawing.Point(794, 594);
            this.btn_connection.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_connection.Name = "btn_connection";
            this.btn_connection.Primary = true;
            this.btn_connection.Size = new System.Drawing.Size(293, 105);
            this.btn_connection.TabIndex = 10;
            this.btn_connection.Text = "Connection";
            this.btn_connection.UseVisualStyleBackColor = true;
            this.btn_connection.Click += new System.EventHandler(this.Btn_connection_Click);
            // 
            // lbl_login
            // 
            this.lbl_login.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_login.AutoSize = true;
            this.lbl_login.Depth = 0;
            this.lbl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_login.Location = new System.Drawing.Point(922, 337);
            this.lbl_login.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(44, 18);
            this.lbl_login.TabIndex = 11;
            this.lbl_login.Text = "Login";
            // 
            // lbl_password
            // 
            this.lbl_password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_password.AutoSize = true;
            this.lbl_password.Depth = 0;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_password.Location = new System.Drawing.Point(897, 420);
            this.lbl_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(98, 18);
            this.lbl_password.TabIndex = 12;
            this.lbl_password.Text = "Mot de passe";
            // 
            // pbx_iconseil
            // 
            this.pbx_iconseil.Image = global::SafiRepay.Properties.Resources.iconseil;
            this.pbx_iconseil.Location = new System.Drawing.Point(1317, 74);
            this.pbx_iconseil.Name = "pbx_iconseil";
            this.pbx_iconseil.Size = new System.Drawing.Size(446, 353);
            this.pbx_iconseil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbx_iconseil.TabIndex = 8;
            this.pbx_iconseil.TabStop = false;
            // 
            // pbx_safiRepay
            // 
            this.pbx_safiRepay.Location = new System.Drawing.Point(794, 89);
            this.pbx_safiRepay.Name = "pbx_safiRepay";
            this.pbx_safiRepay.Size = new System.Drawing.Size(293, 199);
            this.pbx_safiRepay.TabIndex = 7;
            this.pbx_safiRepay.TabStop = false;
            // 
            // pbx_safi
            // 
            this.pbx_safi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbx_safi.Image = global::SafiRepay.Properties.Resources.safi;
            this.pbx_safi.Location = new System.Drawing.Point(161, 89);
            this.pbx_safi.Name = "pbx_safi";
            this.pbx_safi.Size = new System.Drawing.Size(344, 338);
            this.pbx_safi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbx_safi.TabIndex = 6;
            this.pbx_safi.TabStop = false;
            // 
            // frm_login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1873, 930);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.btn_connection);
            this.Controls.Add(this.pbx_iconseil);
            this.Controls.Add(this.pbx_safiRepay);
            this.Controls.Add(this.pbx_safi);
            this.Controls.Add(this.tbx_password);
            this.Controls.Add(this.cbx_enregistrerIdentifiant);
            this.Controls.Add(this.tbx_login);
            this.Controls.Add(this.materialDivider1);
            this.MaximizeBox = false;
            this.Name = "frm_login";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_iconseil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_safiRepay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_safi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.TextBox tbx_login;
        private MaterialSkin.Controls.MaterialCheckBox cbx_enregistrerIdentifiant;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.PictureBox pbx_safi;
        private System.Windows.Forms.PictureBox pbx_safiRepay;
        private System.Windows.Forms.PictureBox pbx_iconseil;
        private MaterialSkin.Controls.MaterialRaisedButton btn_connection;
        private MaterialSkin.Controls.MaterialLabel lbl_login;
        private MaterialSkin.Controls.MaterialLabel lbl_password;
    }
}

