namespace FitnessCenter
{
    partial class CustomerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.clientdataGridView = new System.Windows.Forms.DataGridView();
            this.id_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middlename_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdate_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.occupation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDate = new System.Windows.Forms.DateTimePicker();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.occupationTB = new System.Windows.Forms.TextBox();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.middleNameTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.surnameTB = new System.Windows.Forms.TextBox();
            this.maleRB = new System.Windows.Forms.RadioButton();
            this.femaleRB = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.trainerLabel = new System.Windows.Forms.Label();
            this.trainersDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middlename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hiredate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportseries = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchButton = new System.Windows.Forms.Button();
            this.customerLabel = new System.Windows.Forms.Label();
            this.showTrainersList = new System.Windows.Forms.Button();
            this.addCoachButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // clientdataGridView
            // 
            this.clientdataGridView.AllowUserToDeleteRows = false;
            this.clientdataGridView.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.clientdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_2,
            this.surname_2,
            this.name_2,
            this.middlename_2,
            this.gender_2,
            this.birthdate_2,
            this.email,
            this.phone_2,
            this.occupation});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.clientdataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.clientdataGridView.Location = new System.Drawing.Point(656, 137);
            this.clientdataGridView.MultiSelect = false;
            this.clientdataGridView.Name = "clientdataGridView";
            this.clientdataGridView.ReadOnly = true;
            this.clientdataGridView.RowHeadersWidth = 51;
            this.clientdataGridView.RowTemplate.Height = 24;
            this.clientdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientdataGridView.Size = new System.Drawing.Size(892, 313);
            this.clientdataGridView.TabIndex = 65;
            this.clientdataGridView.DoubleClick += new System.EventHandler(this.clientdataGridView_DoubleClick);
            // 
            // id_2
            // 
            this.id_2.DataPropertyName = "id";
            this.id_2.HeaderText = "Личный №";
            this.id_2.MinimumWidth = 6;
            this.id_2.Name = "id_2";
            this.id_2.ReadOnly = true;
            this.id_2.Visible = false;
            this.id_2.Width = 125;
            // 
            // surname_2
            // 
            this.surname_2.DataPropertyName = "surname";
            this.surname_2.HeaderText = "Фамилия";
            this.surname_2.MinimumWidth = 6;
            this.surname_2.Name = "surname_2";
            this.surname_2.ReadOnly = true;
            this.surname_2.Width = 125;
            // 
            // name_2
            // 
            this.name_2.DataPropertyName = "name";
            this.name_2.HeaderText = "Имя";
            this.name_2.MinimumWidth = 6;
            this.name_2.Name = "name_2";
            this.name_2.ReadOnly = true;
            this.name_2.Width = 125;
            // 
            // middlename_2
            // 
            this.middlename_2.DataPropertyName = "middlename";
            this.middlename_2.HeaderText = "Отчество";
            this.middlename_2.MinimumWidth = 6;
            this.middlename_2.Name = "middlename_2";
            this.middlename_2.ReadOnly = true;
            this.middlename_2.Width = 125;
            // 
            // gender_2
            // 
            this.gender_2.DataPropertyName = "gender";
            this.gender_2.HeaderText = "Пол";
            this.gender_2.MinimumWidth = 6;
            this.gender_2.Name = "gender_2";
            this.gender_2.ReadOnly = true;
            this.gender_2.Width = 125;
            // 
            // birthdate_2
            // 
            this.birthdate_2.DataPropertyName = "birthdate";
            this.birthdate_2.HeaderText = "Дата рождения";
            this.birthdate_2.MinimumWidth = 6;
            this.birthdate_2.Name = "birthdate_2";
            this.birthdate_2.ReadOnly = true;
            this.birthdate_2.Width = 125;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Почта";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 125;
            // 
            // phone_2
            // 
            this.phone_2.DataPropertyName = "phone";
            this.phone_2.HeaderText = "Телефон";
            this.phone_2.MinimumWidth = 6;
            this.phone_2.Name = "phone_2";
            this.phone_2.ReadOnly = true;
            this.phone_2.Width = 125;
            // 
            // occupation
            // 
            this.occupation.DataPropertyName = "occupation";
            this.occupation.HeaderText = "Профессия";
            this.occupation.MinimumWidth = 6;
            this.occupation.Name = "occupation";
            this.occupation.ReadOnly = true;
            this.occupation.Width = 125;
            // 
            // bDate
            // 
            this.bDate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bDate.Location = new System.Drawing.Point(216, 358);
            this.bDate.Name = "bDate";
            this.bDate.Size = new System.Drawing.Size(417, 39);
            this.bDate.TabIndex = 75;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(57, 535);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(0, 0);
            this.metroLabel7.TabIndex = 82;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveButton.Location = new System.Drawing.Point(216, 595);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(136, 61);
            this.saveButton.TabIndex = 83;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Crimson;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteButton.Location = new System.Drawing.Point(358, 595);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(136, 61);
            this.deleteButton.TabIndex = 85;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelButton.Location = new System.Drawing.Point(500, 595);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(136, 61);
            this.cancelButton.TabIndex = 86;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(61, 530);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 32);
            this.label1.TabIndex = 87;
            this.label1.Text = "Профессия:";
            // 
            // occupationTB
            // 
            this.occupationTB.BackColor = System.Drawing.SystemColors.Menu;
            this.occupationTB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.occupationTB.Location = new System.Drawing.Point(216, 527);
            this.occupationTB.Name = "occupationTB";
            this.occupationTB.Size = new System.Drawing.Size(417, 39);
            this.occupationTB.TabIndex = 88;
            // 
            // phoneTB
            // 
            this.phoneTB.BackColor = System.Drawing.SystemColors.Menu;
            this.phoneTB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneTB.Location = new System.Drawing.Point(216, 471);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(417, 39);
            this.phoneTB.TabIndex = 89;
            // 
            // emailTB
            // 
            this.emailTB.BackColor = System.Drawing.SystemColors.Menu;
            this.emailTB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailTB.Location = new System.Drawing.Point(216, 415);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(417, 39);
            this.emailTB.TabIndex = 90;
            // 
            // middleNameTB
            // 
            this.middleNameTB.BackColor = System.Drawing.SystemColors.Menu;
            this.middleNameTB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.middleNameTB.Location = new System.Drawing.Point(216, 252);
            this.middleNameTB.Name = "middleNameTB";
            this.middleNameTB.Size = new System.Drawing.Size(417, 39);
            this.middleNameTB.TabIndex = 91;
            // 
            // nameTB
            // 
            this.nameTB.BackColor = System.Drawing.SystemColors.Menu;
            this.nameTB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTB.Location = new System.Drawing.Point(216, 195);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(417, 39);
            this.nameTB.TabIndex = 92;
            // 
            // surnameTB
            // 
            this.surnameTB.BackColor = System.Drawing.SystemColors.Menu;
            this.surnameTB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameTB.Location = new System.Drawing.Point(216, 137);
            this.surnameTB.Name = "surnameTB";
            this.surnameTB.Size = new System.Drawing.Size(417, 39);
            this.surnameTB.TabIndex = 93;
            // 
            // maleRB
            // 
            this.maleRB.AutoSize = true;
            this.maleRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maleRB.Location = new System.Drawing.Point(216, 310);
            this.maleRB.Name = "maleRB";
            this.maleRB.Size = new System.Drawing.Size(134, 33);
            this.maleRB.TabIndex = 94;
            this.maleRB.TabStop = true;
            this.maleRB.Text = "мужской";
            this.maleRB.UseVisualStyleBackColor = true;
            // 
            // femaleRB
            // 
            this.femaleRB.AutoSize = true;
            this.femaleRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.femaleRB.Location = new System.Drawing.Point(394, 310);
            this.femaleRB.Name = "femaleRB";
            this.femaleRB.Size = new System.Drawing.Size(135, 33);
            this.femaleRB.TabIndex = 95;
            this.femaleRB.TabStop = true;
            this.femaleRB.Text = "женский";
            this.femaleRB.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(87, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 32);
            this.label2.TabIndex = 96;
            this.label2.Text = "Телефон:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(113, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 32);
            this.label3.TabIndex = 97;
            this.label3.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label4.Location = new System.Drawing.Point(10, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 32);
            this.label4.TabIndex = 98;
            this.label4.Text = "Дата рождения:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(136, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 32);
            this.label5.TabIndex = 99;
            this.label5.Text = "Пол:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(84, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 32);
            this.label6.TabIndex = 100;
            this.label6.Text = "Фамилия:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(133, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 32);
            this.label7.TabIndex = 101;
            this.label7.Text = "Имя:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(77, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 32);
            this.label8.TabIndex = 102;
            this.label8.Text = "Отчество:";
            // 
            // trainerLabel
            // 
            this.trainerLabel.AutoSize = true;
            this.trainerLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trainerLabel.Location = new System.Drawing.Point(653, 471);
            this.trainerLabel.Name = "trainerLabel";
            this.trainerLabel.Size = new System.Drawing.Size(155, 32);
            this.trainerLabel.TabIndex = 103;
            this.trainerLabel.Text = "Все тренера:";
            // 
            // trainersDataGridView
            // 
            this.trainersDataGridView.AllowUserToDeleteRows = false;
            this.trainersDataGridView.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.trainersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trainersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.surname,
            this.name,
            this.middlename,
            this.gender,
            this.skill,
            this.phone,
            this.hiredate,
            this.birthdate,
            this.passportseries,
            this.passportno});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.trainersDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.trainersDataGridView.Location = new System.Drawing.Point(656, 527);
            this.trainersDataGridView.MultiSelect = false;
            this.trainersDataGridView.Name = "trainersDataGridView";
            this.trainersDataGridView.ReadOnly = true;
            this.trainersDataGridView.RowHeadersWidth = 51;
            this.trainersDataGridView.RowTemplate.Height = 24;
            this.trainersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.trainersDataGridView.Size = new System.Drawing.Size(892, 287);
            this.trainersDataGridView.TabIndex = 107;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Личный №";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // surname
            // 
            this.surname.DataPropertyName = "surname";
            this.surname.HeaderText = "Фамилия";
            this.surname.MinimumWidth = 6;
            this.surname.Name = "surname";
            this.surname.ReadOnly = true;
            this.surname.Width = 125;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Имя";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 125;
            // 
            // middlename
            // 
            this.middlename.DataPropertyName = "middlename";
            this.middlename.HeaderText = "Отчество";
            this.middlename.MinimumWidth = 6;
            this.middlename.Name = "middlename";
            this.middlename.ReadOnly = true;
            this.middlename.Width = 125;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Пол";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Width = 125;
            // 
            // skill
            // 
            this.skill.DataPropertyName = "skill";
            this.skill.HeaderText = "Услуга";
            this.skill.MinimumWidth = 6;
            this.skill.Name = "skill";
            this.skill.ReadOnly = true;
            this.skill.Width = 125;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "Телефон";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Width = 125;
            // 
            // hiredate
            // 
            this.hiredate.DataPropertyName = "hiredate";
            this.hiredate.HeaderText = "Дата приема на работу";
            this.hiredate.MinimumWidth = 6;
            this.hiredate.Name = "hiredate";
            this.hiredate.ReadOnly = true;
            this.hiredate.Width = 125;
            // 
            // birthdate
            // 
            this.birthdate.DataPropertyName = "birthdate";
            this.birthdate.HeaderText = "Дата рождения";
            this.birthdate.MinimumWidth = 6;
            this.birthdate.Name = "birthdate";
            this.birthdate.ReadOnly = true;
            this.birthdate.Width = 125;
            // 
            // passportseries
            // 
            this.passportseries.DataPropertyName = "passportseries";
            this.passportseries.HeaderText = "Серия паспорта";
            this.passportseries.MinimumWidth = 6;
            this.passportseries.Name = "passportseries";
            this.passportseries.ReadOnly = true;
            this.passportseries.Width = 125;
            // 
            // passportno
            // 
            this.passportno.DataPropertyName = "passportno";
            this.passportno.HeaderText = "Номер паспорта";
            this.passportno.MinimumWidth = 6;
            this.passportno.Name = "passportno";
            this.passportno.ReadOnly = true;
            this.passportno.Width = 125;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Gold;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchButton.Location = new System.Drawing.Point(67, 595);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(136, 61);
            this.searchButton.TabIndex = 108;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerLabel.Location = new System.Drawing.Point(650, 83);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(158, 32);
            this.customerLabel.TabIndex = 109;
            this.customerLabel.Text = "Все клиенты:";
            // 
            // showTrainersList
            // 
            this.showTrainersList.BackColor = System.Drawing.Color.DarkBlue;
            this.showTrainersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showTrainersList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.showTrainersList.Location = new System.Drawing.Point(65, 671);
            this.showTrainersList.Name = "showTrainersList";
            this.showTrainersList.Size = new System.Drawing.Size(285, 61);
            this.showTrainersList.TabIndex = 111;
            this.showTrainersList.Text = "Весь список тренеров";
            this.showTrainersList.UseVisualStyleBackColor = false;
            // 
            // addCoachButton
            // 
            this.addCoachButton.BackColor = System.Drawing.Color.Indigo;
            this.addCoachButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCoachButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addCoachButton.Location = new System.Drawing.Point(358, 671);
            this.addCoachButton.Name = "addCoachButton";
            this.addCoachButton.Size = new System.Drawing.Size(278, 61);
            this.addCoachButton.TabIndex = 112;
            this.addCoachButton.Text = "Заниматься у тренера";
            this.addCoachButton.UseVisualStyleBackColor = false;
            this.addCoachButton.Click += new System.EventHandler(this.addCoachButton_Click_1);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.Salmon;
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stopButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.stopButton.Location = new System.Drawing.Point(216, 750);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(278, 61);
            this.stopButton.TabIndex = 113;
            this.stopButton.Text = "Перестать заниматься у тренера";
            this.stopButton.UseVisualStyleBackColor = false;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1573, 826);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.addCoachButton);
            this.Controls.Add(this.showTrainersList);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.trainersDataGridView);
            this.Controls.Add(this.trainerLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.femaleRB);
            this.Controls.Add(this.maleRB);
            this.Controls.Add(this.surnameTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.middleNameTB);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.phoneTB);
            this.Controls.Add(this.occupationTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.bDate);
            this.Controls.Add(this.clientdataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CustomerForm";
            this.Resizable = false;
            this.Text = "Управление клиентами";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerForm_FormClosing);
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView clientdataGridView;
        private System.Windows.Forms.DateTimePicker bDate;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox occupationTB;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.TextBox middleNameTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox surnameTB;
        private System.Windows.Forms.RadioButton maleRB;
        private System.Windows.Forms.RadioButton femaleRB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label trainerLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn middlename_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdate_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn occupation;
        private System.Windows.Forms.DataGridView trainersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn middlename;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn skill;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn hiredate;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportseries;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportno;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Button showTrainersList;
        private System.Windows.Forms.Button addCoachButton;
        private System.Windows.Forms.Button stopButton;
    }
}