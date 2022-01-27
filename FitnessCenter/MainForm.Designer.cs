namespace FitnessCenter
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.coachesButton = new MetroFramework.Controls.MetroTile();
            this.clientButton = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // coachesButton
            // 
            this.coachesButton.BackColor = System.Drawing.Color.White;
            this.coachesButton.Location = new System.Drawing.Point(305, 105);
            this.coachesButton.Name = "coachesButton";
            this.coachesButton.Size = new System.Drawing.Size(226, 107);
            this.coachesButton.TabIndex = 1;
            this.coachesButton.Text = "Управление тренерами";
            this.coachesButton.TileImage = global::FitnessCenter.Properties.Resources.icons8_coach_641;
            this.coachesButton.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.coachesButton.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.coachesButton.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.coachesButton.UseTileImage = true;
            this.coachesButton.Click += new System.EventHandler(this.coachesButton_Click);
            // 
            // clientButton
            // 
            this.clientButton.BackColor = System.Drawing.Color.White;
            this.clientButton.Location = new System.Drawing.Point(48, 105);
            this.clientButton.Name = "clientButton";
            this.clientButton.Size = new System.Drawing.Size(224, 107);
            this.clientButton.TabIndex = 0;
            this.clientButton.Text = "Управление клиентами";
            this.clientButton.TileImage = global::FitnessCenter.Properties.Resources.icons8_trainer_64;
            this.clientButton.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clientButton.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.clientButton.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.clientButton.UseTileImage = true;
            this.clientButton.Click += new System.EventHandler(this.clientButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 235);
            this.Controls.Add(this.coachesButton);
            this.Controls.Add(this.clientButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.Text = "Главная";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile clientButton;
        private MetroFramework.Controls.MetroTile coachesButton;
    }
}

