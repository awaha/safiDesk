namespace SafiRepay
{
    partial class frm_personnalParam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbx_horsForfait = new System.Windows.Forms.CheckBox();
            this.cbx_repasMidi = new System.Windows.Forms.CheckBox();
            this.cbx_relais = new System.Windows.Forms.CheckBox();
            this.cbx_nuitee = new System.Windows.Forms.CheckBox();
            this.cbx_move = new System.Windows.Forms.CheckBox();
            this.cbx_limitMove = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbx_horsForfait_start = new System.Windows.Forms.TextBox();
            this.tbx_horsForfait_end = new System.Windows.Forms.TextBox();
            this.tbx_repasMidi = new System.Windows.Forms.TextBox();
            this.tbx_relais = new System.Windows.Forms.TextBox();
            this.tbx_nuitee = new System.Windows.Forms.TextBox();
            this.tbx_move = new System.Windows.Forms.TextBox();
            this.tbx_move_limit_km = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tbx_repasMidi_limit = new System.Windows.Forms.TextBox();
            this.tbx_relais_limit = new System.Windows.Forms.TextBox();
            this.tbx_nuitee_limit = new System.Windows.Forms.TextBox();
            this.tbx_move_limit = new System.Windows.Forms.TextBox();
            this.cbx_justificatif = new System.Windows.Forms.CheckBox();
            this.cbx_repasMidi_limit = new System.Windows.Forms.CheckBox();
            this.cbx_relais_limit = new System.Windows.Forms.CheckBox();
            this.cbx_nuitee_limit = new System.Windows.Forms.CheckBox();
            this.cbx_move_limit = new System.Windows.Forms.CheckBox();
            this.swc_horsForfait = new Zeroit.Framework.Metro.ZeroitMetroSwitch();
            this.swc_repasMidi = new Zeroit.Framework.Metro.ZeroitMetroSwitch();
            this.swc_relais = new Zeroit.Framework.Metro.ZeroitMetroSwitch();
            this.swc_nuitee = new Zeroit.Framework.Metro.ZeroitMetroSwitch();
            this.swc_move = new Zeroit.Framework.Metro.ZeroitMetroSwitch();
            this.swc_moveLimit = new Zeroit.Framework.Metro.ZeroitMetroSwitch();
            this.label18 = new System.Windows.Forms.Label();
            this.btn_selUnsel_global = new System.Windows.Forms.Button();
            this.btn_selUnsel_limit = new System.Windows.Forms.Button();
            this.btn_selUnsel_manual = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.btn_save_modification = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbx_horsForfait
            // 
            this.cbx_horsForfait.AutoSize = true;
            this.cbx_horsForfait.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_horsForfait.Location = new System.Drawing.Point(67, 99);
            this.cbx_horsForfait.Name = "cbx_horsForfait";
            this.cbx_horsForfait.Size = new System.Drawing.Size(204, 24);
            this.cbx_horsForfait.TabIndex = 0;
            this.cbx_horsForfait.Text = "Autoriser les hors forfaits";
            this.cbx_horsForfait.UseVisualStyleBackColor = true;
            // 
            // cbx_repasMidi
            // 
            this.cbx_repasMidi.AutoSize = true;
            this.cbx_repasMidi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_repasMidi.Location = new System.Drawing.Point(67, 144);
            this.cbx_repasMidi.Name = "cbx_repasMidi";
            this.cbx_repasMidi.Size = new System.Drawing.Size(269, 24);
            this.cbx_repasMidi.TabIndex = 1;
            this.cbx_repasMidi.Text = "Autoriser les hors-frais supérieur à";
            this.cbx_repasMidi.UseVisualStyleBackColor = true;
            // 
            // cbx_relais
            // 
            this.cbx_relais.AutoSize = true;
            this.cbx_relais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_relais.Location = new System.Drawing.Point(67, 190);
            this.cbx_relais.Name = "cbx_relais";
            this.cbx_relais.Size = new System.Drawing.Size(269, 24);
            this.cbx_relais.TabIndex = 2;
            this.cbx_relais.Text = "Autoriser les hors-frais supérieur à";
            this.cbx_relais.UseVisualStyleBackColor = true;
            // 
            // cbx_nuitee
            // 
            this.cbx_nuitee.AutoSize = true;
            this.cbx_nuitee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_nuitee.Location = new System.Drawing.Point(67, 238);
            this.cbx_nuitee.Name = "cbx_nuitee";
            this.cbx_nuitee.Size = new System.Drawing.Size(269, 24);
            this.cbx_nuitee.TabIndex = 3;
            this.cbx_nuitee.Text = "Autoriser les hors-frais supérieur à";
            this.cbx_nuitee.UseVisualStyleBackColor = true;
            // 
            // cbx_move
            // 
            this.cbx_move.AutoSize = true;
            this.cbx_move.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_move.Location = new System.Drawing.Point(67, 285);
            this.cbx_move.Name = "cbx_move";
            this.cbx_move.Size = new System.Drawing.Size(269, 24);
            this.cbx_move.TabIndex = 4;
            this.cbx_move.Text = "Autoriser les hors-frais supérieur à";
            this.cbx_move.UseVisualStyleBackColor = true;
            // 
            // cbx_limitMove
            // 
            this.cbx_limitMove.AutoSize = true;
            this.cbx_limitMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_limitMove.Location = new System.Drawing.Point(67, 334);
            this.cbx_limitMove.Name = "cbx_limitMove";
            this.cbx_limitMove.Size = new System.Drawing.Size(267, 24);
            this.cbx_limitMove.TabIndex = 5;
            this.cbx_limitMove.Text = "Limiter les kilomètres parcourus à ";
            this.cbx_limitMove.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hors forfait situé entre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(578, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "et";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(658, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "€";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(928, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Avec justificatif ? ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(433, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(348, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "% du prix du repas du midi (soit XX€/repas max).";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(433, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(371, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "% du prix du relais étape (soit XX€/repas+nuit max).";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(433, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(300, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "% du prix de la nuitée (soit XX€/nuit max).";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(433, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(327, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "% du prix du déplacement (soit XX€/km max).";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(433, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "km";
            // 
            // tbx_horsForfait_start
            // 
            this.tbx_horsForfait_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_horsForfait_start.Location = new System.Drawing.Point(524, 97);
            this.tbx_horsForfait_start.Name = "tbx_horsForfait_start";
            this.tbx_horsForfait_start.Size = new System.Drawing.Size(48, 26);
            this.tbx_horsForfait_start.TabIndex = 16;
            // 
            // tbx_horsForfait_end
            // 
            this.tbx_horsForfait_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_horsForfait_end.Location = new System.Drawing.Point(607, 96);
            this.tbx_horsForfait_end.Name = "tbx_horsForfait_end";
            this.tbx_horsForfait_end.Size = new System.Drawing.Size(45, 26);
            this.tbx_horsForfait_end.TabIndex = 17;
            // 
            // tbx_repasMidi
            // 
            this.tbx_repasMidi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_repasMidi.Location = new System.Drawing.Point(342, 142);
            this.tbx_repasMidi.Name = "tbx_repasMidi";
            this.tbx_repasMidi.Size = new System.Drawing.Size(85, 26);
            this.tbx_repasMidi.TabIndex = 18;
            // 
            // tbx_relais
            // 
            this.tbx_relais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_relais.Location = new System.Drawing.Point(342, 188);
            this.tbx_relais.Name = "tbx_relais";
            this.tbx_relais.Size = new System.Drawing.Size(85, 26);
            this.tbx_relais.TabIndex = 19;
            // 
            // tbx_nuitee
            // 
            this.tbx_nuitee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_nuitee.Location = new System.Drawing.Point(342, 236);
            this.tbx_nuitee.Name = "tbx_nuitee";
            this.tbx_nuitee.Size = new System.Drawing.Size(85, 26);
            this.tbx_nuitee.TabIndex = 20;
            // 
            // tbx_move
            // 
            this.tbx_move.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_move.Location = new System.Drawing.Point(342, 283);
            this.tbx_move.Name = "tbx_move";
            this.tbx_move.Size = new System.Drawing.Size(85, 26);
            this.tbx_move.TabIndex = 21;
            // 
            // tbx_move_limit_km
            // 
            this.tbx_move_limit_km.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_move_limit_km.Location = new System.Drawing.Point(342, 332);
            this.tbx_move_limit_km.Name = "tbx_move_limit_km";
            this.tbx_move_limit_km.Size = new System.Drawing.Size(85, 26);
            this.tbx_move_limit_km.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(829, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Avec pour limite :  ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(829, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Avec pour limite :  ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(829, 239);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "Avec pour limite :  ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(829, 286);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 20);
            this.label13.TabIndex = 26;
            this.label13.Text = "Avec pour limite :  ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1041, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 20);
            this.label14.TabIndex = 27;
            this.label14.Text = "€";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1041, 191);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 20);
            this.label15.TabIndex = 28;
            this.label15.Text = "€";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(1041, 239);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(18, 20);
            this.label16.TabIndex = 29;
            this.label16.Text = "€";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1041, 286);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(18, 20);
            this.label17.TabIndex = 30;
            this.label17.Text = "€";
            // 
            // tbx_repasMidi_limit
            // 
            this.tbx_repasMidi_limit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_repasMidi_limit.Location = new System.Drawing.Point(971, 142);
            this.tbx_repasMidi_limit.Name = "tbx_repasMidi_limit";
            this.tbx_repasMidi_limit.Size = new System.Drawing.Size(64, 26);
            this.tbx_repasMidi_limit.TabIndex = 31;
            // 
            // tbx_relais_limit
            // 
            this.tbx_relais_limit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_relais_limit.Location = new System.Drawing.Point(971, 188);
            this.tbx_relais_limit.Name = "tbx_relais_limit";
            this.tbx_relais_limit.Size = new System.Drawing.Size(64, 26);
            this.tbx_relais_limit.TabIndex = 32;
            // 
            // tbx_nuitee_limit
            // 
            this.tbx_nuitee_limit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_nuitee_limit.Location = new System.Drawing.Point(971, 236);
            this.tbx_nuitee_limit.Name = "tbx_nuitee_limit";
            this.tbx_nuitee_limit.Size = new System.Drawing.Size(64, 26);
            this.tbx_nuitee_limit.TabIndex = 33;
            // 
            // tbx_move_limit
            // 
            this.tbx_move_limit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_move_limit.Location = new System.Drawing.Point(971, 283);
            this.tbx_move_limit.Name = "tbx_move_limit";
            this.tbx_move_limit.Size = new System.Drawing.Size(64, 26);
            this.tbx_move_limit.TabIndex = 34;
            // 
            // cbx_justificatif
            // 
            this.cbx_justificatif.AutoSize = true;
            this.cbx_justificatif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_justificatif.Location = new System.Drawing.Point(1065, 104);
            this.cbx_justificatif.Name = "cbx_justificatif";
            this.cbx_justificatif.Size = new System.Drawing.Size(15, 14);
            this.cbx_justificatif.TabIndex = 35;
            this.cbx_justificatif.UseVisualStyleBackColor = true;
            // 
            // cbx_repasMidi_limit
            // 
            this.cbx_repasMidi_limit.AutoSize = true;
            this.cbx_repasMidi_limit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_repasMidi_limit.Location = new System.Drawing.Point(1065, 149);
            this.cbx_repasMidi_limit.Name = "cbx_repasMidi_limit";
            this.cbx_repasMidi_limit.Size = new System.Drawing.Size(15, 14);
            this.cbx_repasMidi_limit.TabIndex = 36;
            this.cbx_repasMidi_limit.UseVisualStyleBackColor = true;
            // 
            // cbx_relais_limit
            // 
            this.cbx_relais_limit.AutoSize = true;
            this.cbx_relais_limit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_relais_limit.Location = new System.Drawing.Point(1065, 195);
            this.cbx_relais_limit.Name = "cbx_relais_limit";
            this.cbx_relais_limit.Size = new System.Drawing.Size(15, 14);
            this.cbx_relais_limit.TabIndex = 37;
            this.cbx_relais_limit.UseVisualStyleBackColor = true;
            // 
            // cbx_nuitee_limit
            // 
            this.cbx_nuitee_limit.AutoSize = true;
            this.cbx_nuitee_limit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_nuitee_limit.Location = new System.Drawing.Point(1065, 243);
            this.cbx_nuitee_limit.Name = "cbx_nuitee_limit";
            this.cbx_nuitee_limit.Size = new System.Drawing.Size(15, 14);
            this.cbx_nuitee_limit.TabIndex = 38;
            this.cbx_nuitee_limit.UseVisualStyleBackColor = true;
            // 
            // cbx_move_limit
            // 
            this.cbx_move_limit.AutoSize = true;
            this.cbx_move_limit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_move_limit.Location = new System.Drawing.Point(1065, 290);
            this.cbx_move_limit.Name = "cbx_move_limit";
            this.cbx_move_limit.Size = new System.Drawing.Size(15, 14);
            this.cbx_move_limit.TabIndex = 39;
            this.cbx_move_limit.UseVisualStyleBackColor = true;
            // 
            // swc_horsForfait
            // 
            this.swc_horsForfait.BackColor = System.Drawing.Color.Transparent;
            this.swc_horsForfait.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.swc_horsForfait.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.swc_horsForfait.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.swc_horsForfait.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.swc_horsForfait.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.swc_horsForfait.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.swc_horsForfait.Location = new System.Drawing.Point(1104, 99);
            this.swc_horsForfait.Name = "swc_horsForfait";
            this.swc_horsForfait.Size = new System.Drawing.Size(75, 23);
            this.swc_horsForfait.SwitchColor = System.Drawing.Color.White;
            this.swc_horsForfait.TabIndex = 40;
            this.swc_horsForfait.Text = "zeroitMetroSwitch1";
            // 
            // swc_repasMidi
            // 
            this.swc_repasMidi.BackColor = System.Drawing.Color.Transparent;
            this.swc_repasMidi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.swc_repasMidi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.swc_repasMidi.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.swc_repasMidi.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.swc_repasMidi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.swc_repasMidi.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.swc_repasMidi.Location = new System.Drawing.Point(1104, 145);
            this.swc_repasMidi.Name = "swc_repasMidi";
            this.swc_repasMidi.Size = new System.Drawing.Size(75, 23);
            this.swc_repasMidi.SwitchColor = System.Drawing.Color.White;
            this.swc_repasMidi.TabIndex = 41;
            this.swc_repasMidi.Text = "zeroitMetroSwitch2";
            // 
            // swc_relais
            // 
            this.swc_relais.BackColor = System.Drawing.Color.Transparent;
            this.swc_relais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.swc_relais.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.swc_relais.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.swc_relais.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.swc_relais.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.swc_relais.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.swc_relais.Location = new System.Drawing.Point(1104, 190);
            this.swc_relais.Name = "swc_relais";
            this.swc_relais.Size = new System.Drawing.Size(75, 23);
            this.swc_relais.SwitchColor = System.Drawing.Color.White;
            this.swc_relais.TabIndex = 42;
            this.swc_relais.Text = "zeroitMetroSwitch3";
            // 
            // swc_nuitee
            // 
            this.swc_nuitee.BackColor = System.Drawing.Color.Transparent;
            this.swc_nuitee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.swc_nuitee.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.swc_nuitee.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.swc_nuitee.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.swc_nuitee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.swc_nuitee.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.swc_nuitee.Location = new System.Drawing.Point(1104, 238);
            this.swc_nuitee.Name = "swc_nuitee";
            this.swc_nuitee.Size = new System.Drawing.Size(75, 23);
            this.swc_nuitee.SwitchColor = System.Drawing.Color.White;
            this.swc_nuitee.TabIndex = 43;
            this.swc_nuitee.Text = "zeroitMetroSwitch4";
            // 
            // swc_move
            // 
            this.swc_move.BackColor = System.Drawing.Color.Transparent;
            this.swc_move.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.swc_move.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.swc_move.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.swc_move.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.swc_move.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.swc_move.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.swc_move.Location = new System.Drawing.Point(1104, 286);
            this.swc_move.Name = "swc_move";
            this.swc_move.Size = new System.Drawing.Size(75, 23);
            this.swc_move.SwitchColor = System.Drawing.Color.White;
            this.swc_move.TabIndex = 44;
            this.swc_move.Text = "zeroitMetroSwitch5";
            // 
            // swc_moveLimit
            // 
            this.swc_moveLimit.BackColor = System.Drawing.Color.Transparent;
            this.swc_moveLimit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.swc_moveLimit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.swc_moveLimit.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.swc_moveLimit.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.swc_moveLimit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.swc_moveLimit.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.swc_moveLimit.Location = new System.Drawing.Point(1104, 335);
            this.swc_moveLimit.Name = "swc_moveLimit";
            this.swc_moveLimit.Size = new System.Drawing.Size(75, 23);
            this.swc_moveLimit.SwitchColor = System.Drawing.Color.White;
            this.swc_moveLimit.TabIndex = 45;
            this.swc_moveLimit.Text = "zeroitMetroSwitch6";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(1041, 361);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(215, 40);
            this.label18.TabIndex = 46;
            this.label18.Text = "Si gris, les fiches \r\nseront traitées manuellement";
            // 
            // btn_selUnsel_global
            // 
            this.btn_selUnsel_global.Location = new System.Drawing.Point(12, 375);
            this.btn_selUnsel_global.Name = "btn_selUnsel_global";
            this.btn_selUnsel_global.Size = new System.Drawing.Size(161, 51);
            this.btn_selUnsel_global.TabIndex = 47;
            this.btn_selUnsel_global.Text = "Tout Selectionner/Déselectionner";
            this.btn_selUnsel_global.UseVisualStyleBackColor = true;
            this.btn_selUnsel_global.Click += new System.EventHandler(this.btn_selUnsel_global_Click);
            // 
            // btn_selUnsel_limit
            // 
            this.btn_selUnsel_limit.Location = new System.Drawing.Point(833, 404);
            this.btn_selUnsel_limit.Name = "btn_selUnsel_limit";
            this.btn_selUnsel_limit.Size = new System.Drawing.Size(161, 51);
            this.btn_selUnsel_limit.TabIndex = 48;
            this.btn_selUnsel_limit.Text = "Tout Selectionner/Déselectionner\r\n(Limites)";
            this.btn_selUnsel_limit.UseVisualStyleBackColor = true;
            this.btn_selUnsel_limit.Click += new System.EventHandler(this.btn_selUnsel_limit_Click);
            // 
            // btn_selUnsel_manual
            // 
            this.btn_selUnsel_manual.Location = new System.Drawing.Point(1065, 404);
            this.btn_selUnsel_manual.Name = "btn_selUnsel_manual";
            this.btn_selUnsel_manual.Size = new System.Drawing.Size(161, 51);
            this.btn_selUnsel_manual.TabIndex = 49;
            this.btn_selUnsel_manual.Text = "Tout Selectionner/Déselectionner\r\n(Traitement Manuel)";
            this.btn_selUnsel_manual.UseVisualStyleBackColor = true;
            this.btn_selUnsel_manual.Click += new System.EventHandler(this.btn_selUnsel_manual_Click);
            // 
            // btn_show
            // 
            this.btn_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show.Location = new System.Drawing.Point(12, 543);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(241, 102);
            this.btn_show.TabIndex = 50;
            this.btn_show.Text = "Visualiser les fiches qui seront automatisées";
            this.btn_show.UseVisualStyleBackColor = true;
            // 
            // btn_save_modification
            // 
            this.btn_save_modification.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_modification.Location = new System.Drawing.Point(922, 547);
            this.btn_save_modification.Name = "btn_save_modification";
            this.btn_save_modification.Size = new System.Drawing.Size(315, 98);
            this.btn_save_modification.TabIndex = 51;
            this.btn_save_modification.Text = "Enregistrer les modifications";
            this.btn_save_modification.UseVisualStyleBackColor = true;
            this.btn_save_modification.Click += new System.EventHandler(this.btn_save_modification_Click);
            // 
            // frm_personnalParam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 682);
            this.Controls.Add(this.btn_save_modification);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.btn_selUnsel_manual);
            this.Controls.Add(this.btn_selUnsel_limit);
            this.Controls.Add(this.btn_selUnsel_global);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.swc_moveLimit);
            this.Controls.Add(this.swc_move);
            this.Controls.Add(this.swc_nuitee);
            this.Controls.Add(this.swc_relais);
            this.Controls.Add(this.swc_repasMidi);
            this.Controls.Add(this.swc_horsForfait);
            this.Controls.Add(this.cbx_move_limit);
            this.Controls.Add(this.cbx_nuitee_limit);
            this.Controls.Add(this.cbx_relais_limit);
            this.Controls.Add(this.cbx_repasMidi_limit);
            this.Controls.Add(this.cbx_justificatif);
            this.Controls.Add(this.tbx_move_limit);
            this.Controls.Add(this.tbx_nuitee_limit);
            this.Controls.Add(this.tbx_relais_limit);
            this.Controls.Add(this.tbx_repasMidi_limit);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbx_move_limit_km);
            this.Controls.Add(this.tbx_move);
            this.Controls.Add(this.tbx_nuitee);
            this.Controls.Add(this.tbx_relais);
            this.Controls.Add(this.tbx_repasMidi);
            this.Controls.Add(this.tbx_horsForfait_end);
            this.Controls.Add(this.tbx_horsForfait_start);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_limitMove);
            this.Controls.Add(this.cbx_move);
            this.Controls.Add(this.cbx_nuitee);
            this.Controls.Add(this.cbx_relais);
            this.Controls.Add(this.cbx_repasMidi);
            this.Controls.Add(this.cbx_horsForfait);
            this.Name = "frm_personnalParam";
            this.Text = "Paramètres Personnels";
            this.Load += new System.EventHandler(this.frm_personnalParam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbx_horsForfait;
        private System.Windows.Forms.CheckBox cbx_repasMidi;
        private System.Windows.Forms.CheckBox cbx_relais;
        private System.Windows.Forms.CheckBox cbx_nuitee;
        private System.Windows.Forms.CheckBox cbx_move;
        private System.Windows.Forms.CheckBox cbx_limitMove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbx_horsForfait_start;
        private System.Windows.Forms.TextBox tbx_horsForfait_end;
        private System.Windows.Forms.TextBox tbx_repasMidi;
        private System.Windows.Forms.TextBox tbx_relais;
        private System.Windows.Forms.TextBox tbx_nuitee;
        private System.Windows.Forms.TextBox tbx_move;
        private System.Windows.Forms.TextBox tbx_move_limit_km;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbx_repasMidi_limit;
        private System.Windows.Forms.TextBox tbx_relais_limit;
        private System.Windows.Forms.TextBox tbx_nuitee_limit;
        private System.Windows.Forms.TextBox tbx_move_limit;
        private System.Windows.Forms.CheckBox cbx_justificatif;
        private System.Windows.Forms.CheckBox cbx_repasMidi_limit;
        private System.Windows.Forms.CheckBox cbx_relais_limit;
        private System.Windows.Forms.CheckBox cbx_nuitee_limit;
        private System.Windows.Forms.CheckBox cbx_move_limit;
        private Zeroit.Framework.Metro.ZeroitMetroSwitch swc_horsForfait;
        private Zeroit.Framework.Metro.ZeroitMetroSwitch swc_repasMidi;
        private Zeroit.Framework.Metro.ZeroitMetroSwitch swc_relais;
        private Zeroit.Framework.Metro.ZeroitMetroSwitch swc_nuitee;
        private Zeroit.Framework.Metro.ZeroitMetroSwitch swc_move;
        private Zeroit.Framework.Metro.ZeroitMetroSwitch swc_moveLimit;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btn_selUnsel_global;
        private System.Windows.Forms.Button btn_selUnsel_limit;
        private System.Windows.Forms.Button btn_selUnsel_manual;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button btn_save_modification;
    }
}