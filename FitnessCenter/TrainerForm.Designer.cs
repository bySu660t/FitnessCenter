namespace FitnessCenter
{
    partial class TrainerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainerForm));
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
            this.customerLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trainerLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gender_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.femaleRB = new System.Windows.Forms.RadioButton();
            this.middlename_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maleRB = new System.Windows.Forms.RadioButton();
            this.surnameTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.middleNameTB = new System.Windows.Forms.TextBox();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.skillTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.occupation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDate = new System.Windows.Forms.DateTimePicker();
            this.birthdate_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientdataGridView = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.hireD = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.passpSer = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.passpNoTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trainersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientdataGridView)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.trainersDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.trainersDataGridView.Location = new System.Drawing.Point(682, 133);
            this.trainersDataGridView.MultiSelect = false;
            this.trainersDataGridView.Name = "trainersDataGridView";
            this.trainersDataGridView.ReadOnly = true;
            this.trainersDataGridView.RowHeadersWidth = 51;
            this.trainersDataGridView.RowTemplate.Height = 24;
            this.trainersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.trainersDataGridView.Size = new System.Drawing.Size(892, 260);
            this.trainersDataGridView.TabIndex = 136;
            this.trainersDataGridView.DoubleClick += new System.EventHandler(this.trainersDataGridView_DoubleClick);
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
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerLabel.Location = new System.Drawing.Point(676, 418);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(158, 32);
            this.customerLabel.TabIndex = 134;
            this.customerLabel.Text = "Все клиенты:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(100, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 32);
            this.label8.TabIndex = 133;
            this.label8.Text = "Отчество:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(156, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 32);
            this.label7.TabIndex = 132;
            this.label7.Text = "Имя:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(107, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 32);
            this.label6.TabIndex = 131;
            this.label6.Text = "Фамилия:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(159, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 32);
            this.label5.TabIndex = 130;
            this.label5.Text = "Пол:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label4.Location = new System.Drawing.Point(33, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 32);
            this.label4.TabIndex = 129;
            this.label4.Text = "Дата рождения:";
            // 
            // trainerLabel
            // 
            this.trainerLabel.AutoSize = true;
            this.trainerLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trainerLabel.Location = new System.Drawing.Point(673, 78);
            this.trainerLabel.Name = "trainerLabel";
            this.trainerLabel.Size = new System.Drawing.Size(155, 32);
            this.trainerLabel.TabIndex = 138;
            this.trainerLabel.Text = "Все тренера:";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Gold;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchButton.Location = new System.Drawing.Point(87, 652);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(136, 61);
            this.searchButton.TabIndex = 137;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(110, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 32);
            this.label2.TabIndex = 127;
            this.label2.Text = "Телефон:";
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
            // name_2
            // 
            this.name_2.DataPropertyName = "name";
            this.name_2.HeaderText = "Имя";
            this.name_2.MinimumWidth = 6;
            this.name_2.Name = "name_2";
            this.name_2.ReadOnly = true;
            this.name_2.Width = 125;
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
            // femaleRB
            // 
            this.femaleRB.AutoSize = true;
            this.femaleRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.femaleRB.Location = new System.Drawing.Point(417, 306);
            this.femaleRB.Name = "femaleRB";
            this.femaleRB.Size = new System.Drawing.Size(135, 33);
            this.femaleRB.TabIndex = 126;
            this.femaleRB.TabStop = true;
            this.femaleRB.Text = "женский";
            this.femaleRB.UseVisualStyleBackColor = true;
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
            // maleRB
            // 
            this.maleRB.AutoSize = true;
            this.maleRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maleRB.Location = new System.Drawing.Point(239, 306);
            this.maleRB.Name = "maleRB";
            this.maleRB.Size = new System.Drawing.Size(134, 33);
            this.maleRB.TabIndex = 125;
            this.maleRB.TabStop = true;
            this.maleRB.Text = "мужской";
            this.maleRB.UseVisualStyleBackColor = true;
            // 
            // surnameTB
            // 
            this.surnameTB.BackColor = System.Drawing.SystemColors.Menu;
            this.surnameTB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameTB.Location = new System.Drawing.Point(239, 133);
            this.surnameTB.Name = "surnameTB";
            this.surnameTB.Size = new System.Drawing.Size(417, 39);
            this.surnameTB.TabIndex = 124;
            // 
            // nameTB
            // 
            this.nameTB.BackColor = System.Drawing.SystemColors.Menu;
            this.nameTB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTB.Location = new System.Drawing.Point(239, 191);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(417, 39);
            this.nameTB.TabIndex = 123;
            // 
            // middleNameTB
            // 
            this.middleNameTB.BackColor = System.Drawing.SystemColors.Menu;
            this.middleNameTB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.middleNameTB.Location = new System.Drawing.Point(239, 248);
            this.middleNameTB.Name = "middleNameTB";
            this.middleNameTB.Size = new System.Drawing.Size(417, 39);
            this.middleNameTB.TabIndex = 122;
            // 
            // phoneTB
            // 
            this.phoneTB.BackColor = System.Drawing.SystemColors.Menu;
            this.phoneTB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneTB.Location = new System.Drawing.Point(239, 418);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(417, 39);
            this.phoneTB.TabIndex = 120;
            // 
            // skillTB
            // 
            this.skillTB.BackColor = System.Drawing.SystemColors.Menu;
            this.skillTB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.skillTB.Location = new System.Drawing.Point(239, 592);
            this.skillTB.Name = "skillTB";
            this.skillTB.Size = new System.Drawing.Size(417, 39);
            this.skillTB.TabIndex = 119;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 594);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 32);
            this.label1.TabIndex = 118;
            this.label1.Text = "Вид тренировок:";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelButton.Location = new System.Drawing.Point(520, 652);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(136, 61);
            this.cancelButton.TabIndex = 117;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Crimson;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteButton.Location = new System.Drawing.Point(378, 652);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(136, 61);
            this.deleteButton.TabIndex = 116;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveButton.Location = new System.Drawing.Point(236, 652);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(136, 61);
            this.saveButton.TabIndex = 115;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(77, 622);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(0, 0);
            this.metroLabel7.TabIndex = 114;
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
            this.bDate.Location = new System.Drawing.Point(239, 354);
            this.bDate.Name = "bDate";
            this.bDate.Size = new System.Drawing.Size(417, 39);
            this.bDate.TabIndex = 113;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.clientdataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.clientdataGridView.Location = new System.Drawing.Point(679, 470);
            this.clientdataGridView.MultiSelect = false;
            this.clientdataGridView.Name = "clientdataGridView";
            this.clientdataGridView.ReadOnly = true;
            this.clientdataGridView.RowHeadersWidth = 51;
            this.clientdataGridView.RowTemplate.Height = 24;
            this.clientdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientdataGridView.Size = new System.Drawing.Size(892, 243);
            this.clientdataGridView.TabIndex = 112;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label9.Location = new System.Drawing.Point(81, 477);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 32);
            this.label9.TabIndex = 140;
            this.label9.Text = "Дата найма:";
            // 
            // hireD
            // 
            this.hireD.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hireD.Location = new System.Drawing.Point(239, 474);
            this.hireD.Name = "hireD";
            this.hireD.Size = new System.Drawing.Size(417, 39);
            this.hireD.TabIndex = 139;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(43, 535);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 32);
            this.label10.TabIndex = 142;
            this.label10.Text = "Паспорт серия:";
            // 
            // passpSer
            // 
            this.passpSer.BackColor = System.Drawing.SystemColors.Menu;
            this.passpSer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passpSer.Location = new System.Drawing.Point(239, 532);
            this.passpSer.Name = "passpSer";
            this.passpSer.Size = new System.Drawing.Size(79, 39);
            this.passpSer.TabIndex = 141;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(334, 535);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 32);
            this.label11.TabIndex = 143;
            this.label11.Text = "номер:";
            // 
            // passpNoTB
            // 
            this.passpNoTB.BackColor = System.Drawing.SystemColors.Menu;
            this.passpNoTB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passpNoTB.Location = new System.Drawing.Point(432, 532);
            this.passpNoTB.Name = "passpNoTB";
            this.passpNoTB.Size = new System.Drawing.Size(224, 39);
            this.passpNoTB.TabIndex = 144;
            // 
            // TrainerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1610, 760);
            this.Controls.Add(this.passpNoTB);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.passpSer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.hireD);
            this.Controls.Add(this.trainersDataGridView);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trainerLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.femaleRB);
            this.Controls.Add(this.maleRB);
            this.Controls.Add(this.surnameTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.middleNameTB);
            this.Controls.Add(this.phoneTB);
            this.Controls.Add(this.skillTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.bDate);
            this.Controls.Add(this.clientdataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TrainerForm";
            this.Text = "Управление тренерами";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrainerForm_FormClosing);
            this.Load += new System.EventHandler(this.TrainerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trainersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label trainerLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_2;
        private System.Windows.Forms.RadioButton femaleRB;
        private System.Windows.Forms.DataGridViewTextBoxColumn middlename_2;
        private System.Windows.Forms.RadioButton maleRB;
        private System.Windows.Forms.TextBox surnameTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox middleNameTB;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.TextBox skillTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn occupation;
        private System.Windows.Forms.DateTimePicker bDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdate_2;
        private System.Windows.Forms.DataGridView clientdataGridView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker hireD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox passpSer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox passpNoTB;
    }
}