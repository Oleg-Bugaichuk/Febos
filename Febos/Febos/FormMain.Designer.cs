namespace Febos
{
    partial class FormMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonOrders = new System.Windows.Forms.Button();
            this.buttonPersonal = new System.Windows.Forms.Button();
            this.buttonInventory = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonKassa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelLogo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOrders
            // 
            this.buttonOrders.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOrders.BackColor = System.Drawing.Color.Transparent;
            this.buttonOrders.BackgroundImage = global::Febos.Properties.Resources.spisok;
            this.buttonOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonOrders.Enabled = false;
            this.buttonOrders.FlatAppearance.BorderSize = 0;
            this.buttonOrders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.buttonOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrders.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOrders.ForeColor = System.Drawing.Color.White;
            this.buttonOrders.Location = new System.Drawing.Point(74, 138);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(300, 180);
            this.buttonOrders.TabIndex = 1;
            this.buttonOrders.Text = "Заказы";
            this.buttonOrders.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonOrders.UseVisualStyleBackColor = false;
            this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
            // 
            // buttonPersonal
            // 
            this.buttonPersonal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPersonal.BackColor = System.Drawing.Color.Transparent;
            this.buttonPersonal.BackgroundImage = global::Febos.Properties.Resources.personal;
            this.buttonPersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPersonal.Enabled = false;
            this.buttonPersonal.FlatAppearance.BorderSize = 0;
            this.buttonPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.buttonPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPersonal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPersonal.ForeColor = System.Drawing.Color.White;
            this.buttonPersonal.Location = new System.Drawing.Point(74, 429);
            this.buttonPersonal.Name = "buttonPersonal";
            this.buttonPersonal.Size = new System.Drawing.Size(300, 180);
            this.buttonPersonal.TabIndex = 2;
            this.buttonPersonal.Text = "Персонал";
            this.buttonPersonal.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonPersonal.UseVisualStyleBackColor = false;
            this.buttonPersonal.Click += new System.EventHandler(this.buttonPersonal_Click);
            // 
            // buttonInventory
            // 
            this.buttonInventory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonInventory.BackColor = System.Drawing.Color.Transparent;
            this.buttonInventory.BackgroundImage = global::Febos.Properties.Resources.inventory;
            this.buttonInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonInventory.Enabled = false;
            this.buttonInventory.FlatAppearance.BorderSize = 0;
            this.buttonInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.buttonInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInventory.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInventory.ForeColor = System.Drawing.Color.White;
            this.buttonInventory.Location = new System.Drawing.Point(497, 138);
            this.buttonInventory.Name = "buttonInventory";
            this.buttonInventory.Size = new System.Drawing.Size(300, 180);
            this.buttonInventory.TabIndex = 3;
            this.buttonInventory.Text = "Склад";
            this.buttonInventory.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonInventory.UseVisualStyleBackColor = false;
            this.buttonInventory.Click += new System.EventHandler(this.buttonInventory_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAbout.BackColor = System.Drawing.Color.Transparent;
            this.buttonAbout.BackgroundImage = global::Febos.Properties.Resources.information;
            this.buttonAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAbout.FlatAppearance.BorderSize = 0;
            this.buttonAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbout.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAbout.ForeColor = System.Drawing.Color.White;
            this.buttonAbout.Location = new System.Drawing.Point(497, 429);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(300, 180);
            this.buttonAbout.TabIndex = 4;
            this.buttonAbout.Text = "О Системе";
            this.buttonAbout.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonAbout.UseVisualStyleBackColor = false;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEnter.BackColor = System.Drawing.Color.Transparent;
            this.buttonEnter.BackgroundImage = global::Febos.Properties.Resources.enter;
            this.buttonEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEnter.FlatAppearance.BorderSize = 0;
            this.buttonEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.buttonEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnter.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnter.ForeColor = System.Drawing.Color.White;
            this.buttonEnter.Location = new System.Drawing.Point(903, 138);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(300, 180);
            this.buttonEnter.TabIndex = 5;
            this.buttonEnter.Text = "Регистрация";
            this.buttonEnter.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.buttonEnter.UseVisualStyleBackColor = false;
            this.buttonEnter.Visible = false;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // buttonKassa
            // 
            this.buttonKassa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonKassa.BackColor = System.Drawing.Color.Transparent;
            this.buttonKassa.BackgroundImage = global::Febos.Properties.Resources.Kassa;
            this.buttonKassa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonKassa.Enabled = false;
            this.buttonKassa.FlatAppearance.BorderSize = 0;
            this.buttonKassa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.buttonKassa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKassa.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonKassa.ForeColor = System.Drawing.Color.White;
            this.buttonKassa.Location = new System.Drawing.Point(903, 429);
            this.buttonKassa.Name = "buttonKassa";
            this.buttonKassa.Size = new System.Drawing.Size(300, 180);
            this.buttonKassa.TabIndex = 6;
            this.buttonKassa.Text = "Касса";
            this.buttonKassa.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonKassa.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Location = new System.Drawing.Point(0, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 10);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.BackColor = System.Drawing.Color.Transparent;
            this.labelLogo.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogo.ForeColor = System.Drawing.Color.Coral;
            this.labelLogo.Location = new System.Drawing.Point(110, 31);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(162, 58);
            this.labelLogo.TabIndex = 8;
            this.labelLogo.Text = "Febos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Febos.Properties.Resources.Logo1;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(36, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExit.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonExit.BackgroundImage = global::Febos.Properties.Resources.exit;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(1108, 26);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(83, 62);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "Выход";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Febos.Properties.Resources.kamni_fon_priroda;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1240, 726);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelLogo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonKassa);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonInventory);
            this.Controls.Add(this.buttonPersonal);
            this.Controls.Add(this.buttonOrders);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1240, 726);
            this.Name = "FormMain";
            this.Text = "Febos ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonExit;
        public System.Windows.Forms.Button buttonOrders;
        public System.Windows.Forms.Button buttonPersonal;
        public System.Windows.Forms.Button buttonInventory;
        public System.Windows.Forms.Button buttonEnter;
        public System.Windows.Forms.Button buttonKassa;
    }
}

