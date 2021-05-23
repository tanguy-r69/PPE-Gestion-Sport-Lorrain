
namespace PPE_Maison_Des_Ligues
{
    partial class Form1
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.buttonCreateParticipant = new System.Windows.Forms.Button();
            this.comboBoxAtelier = new System.Windows.Forms.ComboBox();
            this.comboBoxBenevole = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.tabAtelier = new System.Windows.Forms.TabPage();
            this.btnValiderHoraire = new System.Windows.Forms.Button();
            this.dtPickerFin = new System.Windows.Forms.DateTimePicker();
            this.dtPickerDebut = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbxAtelier = new System.Windows.Forms.ComboBox();
            this.dgvAtelier = new System.Windows.Forms.DataGridView();
            this.Libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvParticipant = new System.Windows.Forms.DataGridView();
            this.idParticipant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomParticipant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomParticipant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTypeParticipant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseParticipant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailParticipant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numPortableParticipant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAtelierParticipant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idHorraireBenevolesParticipant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabAtelier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvAtelier)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvParticipant)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(821, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabAtelier);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(821, 432);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnLogOut);
            this.tabPage1.Controls.Add(this.btnEnd);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(813, 406);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Accueil";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogOut.Location = new System.Drawing.Point(595, 362);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(106, 41);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnEnd.Location = new System.Drawing.Point(705, 362);
            this.btnEnd.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(106, 41);
            this.btnEnd.TabIndex = 1;
            this.btnEnd.Text = "Quitter";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(64, 72);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(698, 32);
            this.label13.TabIndex = 0;
            this.label13.Text = "Bienvenue sur l\'application de gestion des Assises du Sport Lorrain";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textBoxTel);
            this.tabPage2.Controls.Add(this.textBoxAdresse);
            this.tabPage2.Controls.Add(this.textBoxPrenom);
            this.tabPage2.Controls.Add(this.textBoxNom);
            this.tabPage2.Controls.Add(this.textBoxMail);
            this.tabPage2.Controls.Add(this.buttonCreateParticipant);
            this.tabPage2.Controls.Add(this.comboBoxAtelier);
            this.tabPage2.Controls.Add(this.comboBoxBenevole);
            this.tabPage2.Controls.Add(this.comboBoxType);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(813, 406);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Inscription";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label11.Location = new System.Drawing.Point(63, 336);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(378, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Tous les champs de saisie de cette page sont obligatoires.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(63, 67);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(336, 24);
            this.label10.TabIndex = 20;
            this.label10.Text = "Informations à remplir pour l\'inscription:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 213);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(538, 223);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 24);
            this.label9.TabIndex = 18;
            this.label9.Text = "A choisir si bénévole:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(590, 156);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "Atelier";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(590, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Téléphone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 241);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Adresse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Prénom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(120, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Inscription d\'un nouveau participant";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(202, 175);
            this.textBoxTel.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(107, 29);
            this.textBoxTel.TabIndex = 9;
            this.textBoxTel.TextChanged += new System.EventHandler(this.textBoxTel_TextChanged);
            this.textBoxTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTel_KeyPress);
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(65, 264);
            this.textBoxAdresse.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(107, 29);
            this.textBoxAdresse.TabIndex = 8;
            this.textBoxAdresse.TextChanged += new System.EventHandler(this.textBoxAdresse_TextChanged);
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(65, 204);
            this.textBoxPrenom.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(107, 29);
            this.textBoxPrenom.TabIndex = 7;
            this.textBoxPrenom.TextChanged += new System.EventHandler(this.textBoxPrenom_TextChanged);
            this.textBoxPrenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrenom_KeyPress);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(65, 144);
            this.textBoxNom.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(107, 29);
            this.textBoxNom.TabIndex = 6;
            this.textBoxNom.TextChanged += new System.EventHandler(this.textBoxNom_TextChanged);
            this.textBoxNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNom_KeyPress);
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(204, 236);
            this.textBoxMail.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(107, 29);
            this.textBoxMail.TabIndex = 5;
            this.textBoxMail.TextChanged += new System.EventHandler(this.textBoxMail_TextChanged);
            // 
            // buttonCreateParticipant
            // 
            this.buttonCreateParticipant.Location = new System.Drawing.Point(531, 312);
            this.buttonCreateParticipant.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreateParticipant.Name = "buttonCreateParticipant";
            this.buttonCreateParticipant.Size = new System.Drawing.Size(192, 60);
            this.buttonCreateParticipant.TabIndex = 4;
            this.buttonCreateParticipant.Text = "Créer le participant";
            this.buttonCreateParticipant.UseVisualStyleBackColor = true;
            this.buttonCreateParticipant.Click += new System.EventHandler(this.buttonCreateParticipant_Click);
            // 
            // comboBoxAtelier
            // 
            this.comboBoxAtelier.FormattingEnabled = true;
            this.comboBoxAtelier.Location = new System.Drawing.Point(459, 179);
            this.comboBoxAtelier.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxAtelier.Name = "comboBoxAtelier";
            this.comboBoxAtelier.Size = new System.Drawing.Size(325, 32);
            this.comboBoxAtelier.TabIndex = 3;
            this.comboBoxAtelier.SelectedIndexChanged += new System.EventHandler(this.comboBoxAtelier_SelectedIndexChanged);
            // 
            // comboBoxBenevole
            // 
            this.comboBoxBenevole.FormattingEnabled = true;
            this.comboBoxBenevole.Location = new System.Drawing.Point(531, 245);
            this.comboBoxBenevole.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxBenevole.Name = "comboBoxBenevole";
            this.comboBoxBenevole.Size = new System.Drawing.Size(193, 32);
            this.comboBoxBenevole.TabIndex = 2;
            this.comboBoxBenevole.SelectedIndexChanged += new System.EventHandler(this.comboBoxBenevole_SelectedIndexChanged);
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(531, 114);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(193, 32);
            this.comboBoxType.TabIndex = 1;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // tabAtelier
            // 
            this.tabAtelier.Controls.Add(this.btnValiderHoraire);
            this.tabAtelier.Controls.Add(this.dtPickerFin);
            this.tabAtelier.Controls.Add(this.dtPickerDebut);
            this.tabAtelier.Controls.Add(this.label15);
            this.tabAtelier.Controls.Add(this.label14);
            this.tabAtelier.Controls.Add(this.cbxAtelier);
            this.tabAtelier.Controls.Add(this.dgvAtelier);
            this.tabAtelier.Location = new System.Drawing.Point(4, 22);
            this.tabAtelier.Name = "tabAtelier";
            this.tabAtelier.Size = new System.Drawing.Size(813, 406);
            this.tabAtelier.TabIndex = 2;
            this.tabAtelier.Text = "Atelier";
            this.tabAtelier.UseVisualStyleBackColor = true;
            // 
            // btnValiderHoraire
            // 
            this.btnValiderHoraire.Location = new System.Drawing.Point(52, 338);
            this.btnValiderHoraire.Name = "btnValiderHoraire";
            this.btnValiderHoraire.Size = new System.Drawing.Size(121, 47);
            this.btnValiderHoraire.TabIndex = 9;
            this.btnValiderHoraire.Text = "Valider";
            this.btnValiderHoraire.UseVisualStyleBackColor = true;
            this.btnValiderHoraire.Click += new System.EventHandler(this.btnValiderHoraire_Click);
            // 
            // dtPickerFin
            // 
            this.dtPickerFin.CustomFormat = "ddMMMM yyyy  HH:mm";
            this.dtPickerFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickerFin.Location = new System.Drawing.Point(592, 277);
            this.dtPickerFin.MinDate = new System.DateTime(2021, 5, 22, 0, 0, 0, 0);
            this.dtPickerFin.Name = "dtPickerFin";
            this.dtPickerFin.Size = new System.Drawing.Size(200, 20);
            this.dtPickerFin.TabIndex = 8;
            // 
            // dtPickerDebut
            // 
            this.dtPickerDebut.CustomFormat = "ddMMMM yyyy  HH:mm";
            this.dtPickerDebut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickerDebut.Location = new System.Drawing.Point(364, 277);
            this.dtPickerDebut.MaxDate = new System.DateTime(2111, 1, 4, 0, 0, 0, 0);
            this.dtPickerDebut.MinDate = new System.DateTime(2021, 5, 22, 0, 0, 0, 0);
            this.dtPickerDebut.Name = "dtPickerDebut";
            this.dtPickerDebut.Size = new System.Drawing.Size(200, 20);
            this.dtPickerDebut.TabIndex = 7;
            this.dtPickerDebut.Value = new System.DateTime(2021, 5, 22, 0, 0, 0, 0);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label15.Location = new System.Drawing.Point(364, 237);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(428, 37);
            this.label15.TabIndex = 4;
            this.label15.Text = "Selectionner le jour et l\'heure de début et de fin \r\n\r\n";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label14.Location = new System.Drawing.Point(16, 237);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(271, 37);
            this.label14.TabIndex = 3;
            this.label14.Text = "Selectionner l\'atelier à modifier";
            // 
            // cbxAtelier
            // 
            this.cbxAtelier.FormattingEnabled = true;
            this.cbxAtelier.Location = new System.Drawing.Point(37, 276);
            this.cbxAtelier.Margin = new System.Windows.Forms.Padding(2);
            this.cbxAtelier.Name = "cbxAtelier";
            this.cbxAtelier.Size = new System.Drawing.Size(224, 21);
            this.cbxAtelier.TabIndex = 1;
            // 
            // dgvAtelier
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAtelier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAtelier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtelier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.Libelle, this.Capacite, this.debut, this.fin});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAtelier.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAtelier.Location = new System.Drawing.Point(16, 20);
            this.dgvAtelier.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAtelier.Name = "dgvAtelier";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAtelier.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAtelier.RowHeadersWidth = 62;
            this.dgvAtelier.Size = new System.Drawing.Size(776, 197);
            this.dgvAtelier.TabIndex = 0;
            // 
            // Libelle
            // 
            this.Libelle.HeaderText = "Libelle";
            this.Libelle.Name = "Libelle";
            this.Libelle.Width = 300;
            // 
            // Capacite
            // 
            this.Capacite.HeaderText = "Capacite max";
            this.Capacite.Name = "Capacite";
            // 
            // debut
            // 
            this.debut.HeaderText = "Debut";
            this.debut.Name = "debut";
            this.debut.Width = 170;
            // 
            // fin
            // 
            this.fin.HeaderText = "Fin";
            this.fin.Name = "fin";
            this.fin.Width = 170;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvParticipant);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(813, 406);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Participant";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvParticipant
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParticipant.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvParticipant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParticipant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.idParticipant, this.nomParticipant, this.prenomParticipant, this.idTypeParticipant, this.adresseParticipant, this.mailParticipant, this.numPortableParticipant, this.idAtelierParticipant, this.idHorraireBenevolesParticipant});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvParticipant.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvParticipant.Location = new System.Drawing.Point(82, 59);
            this.dgvParticipant.Margin = new System.Windows.Forms.Padding(2);
            this.dgvParticipant.Name = "dgvParticipant";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParticipant.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvParticipant.RowTemplate.Height = 28;
            this.dgvParticipant.Size = new System.Drawing.Size(629, 349);
            this.dgvParticipant.TabIndex = 2;
            this.dgvParticipant.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParticipant_CellContentClick);
            // 
            // idParticipant
            // 
            this.idParticipant.HeaderText = "id";
            this.idParticipant.Name = "idParticipant";
            // 
            // nomParticipant
            // 
            this.nomParticipant.HeaderText = "Nom";
            this.nomParticipant.Name = "nomParticipant";
            // 
            // prenomParticipant
            // 
            this.prenomParticipant.HeaderText = "Prenom";
            this.prenomParticipant.Name = "prenomParticipant";
            // 
            // idTypeParticipant
            // 
            this.idTypeParticipant.HeaderText = "Type";
            this.idTypeParticipant.Name = "idTypeParticipant";
            // 
            // adresseParticipant
            // 
            this.adresseParticipant.HeaderText = "Adresse";
            this.adresseParticipant.Name = "adresseParticipant";
            // 
            // mailParticipant
            // 
            this.mailParticipant.HeaderText = "M@il";
            this.mailParticipant.Name = "mailParticipant";
            // 
            // numPortableParticipant
            // 
            this.numPortableParticipant.HeaderText = "n°Portable";
            this.numPortableParticipant.Name = "numPortableParticipant";
            // 
            // idAtelierParticipant
            // 
            this.idAtelierParticipant.HeaderText = "Atelier";
            this.idAtelierParticipant.Name = "idAtelierParticipant";
            // 
            // idHorraireBenevolesParticipant
            // 
            this.idHorraireBenevolesParticipant.HeaderText = "Horraire Benevole";
            this.idHorraireBenevolesParticipant.Name = "idHorraireBenevolesParticipant";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label12.Location = new System.Drawing.Point(225, 15);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(329, 32);
            this.label12.TabIndex = 1;
            this.label12.Text = "Liste de tout les participants:";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(813, 406);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Animateur";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 431);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Appli PPE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabAtelier.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvAtelier)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvParticipant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TabPage tabPage4;

        private System.Windows.Forms.Button btnValiderHoraire;

        private System.Windows.Forms.DateTimePicker dtPickerDebut;
        private System.Windows.Forms.DateTimePicker dtPickerFin;

        

        private System.Windows.Forms.DataGridViewTextBoxColumn Libelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacite;
        private System.Windows.Forms.DataGridViewTextBoxColumn debut;
        private System.Windows.Forms.DataGridViewTextBoxColumn fin;

        private System.Windows.Forms.Label label16;

        private System.Windows.Forms.Label label15;

        private System.Windows.Forms.Label label14;

        

        private System.Windows.Forms.Button btnLogOut;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button btnEnd;

        private System.Windows.Forms.Label label13;

        private System.Windows.Forms.DataGridViewTextBoxColumn mailParticipant;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPortableParticipant;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAtelierParticipant;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHorraireBenevolesParticipant;

        private System.Windows.Forms.DataGridViewTextBoxColumn idParticipant;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomParticipant;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomParticipant;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTypeParticipant;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseParticipant;

        private System.Windows.Forms.DataGridView dgvParticipant;

        private System.Windows.Forms.Label label12;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.TabPage tabPage3;

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboBoxAtelier;
        private System.Windows.Forms.ComboBox comboBoxBenevole;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Button buttonCreateParticipant;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabAtelier;
        private System.Windows.Forms.DataGridView dgvAtelier;
        private System.Windows.Forms.ComboBox cbxAtelier;
    }
}

