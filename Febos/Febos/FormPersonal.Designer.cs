namespace Febos
{
    partial class FormPersonal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonal));
            this.dataGridViewPersonal = new System.Windows.Forms.DataGridView();
            this.nameAllDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ntionalityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.febosDBDataSet = new Febos.FebosDBDataSet();
            this.personalTableAdapter = new Febos.FebosDBDataSetTableAdapters.PersonalTableAdapter();
            this.buttonInsertPersonal = new System.Windows.Forms.Button();
            this.buttonPrintPersonal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelLogo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.febosDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPersonal
            // 
            this.dataGridViewPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewPersonal.AutoGenerateColumns = false;
            this.dataGridViewPersonal.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameAllDataGridViewTextBoxColumn,
            this.ntionalityDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.iINDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.mobileTelDataGridViewTextBoxColumn});
            this.dataGridViewPersonal.DataSource = this.personalBindingSource;
            this.dataGridViewPersonal.Location = new System.Drawing.Point(0, 105);
            this.dataGridViewPersonal.Name = "dataGridViewPersonal";
            this.dataGridViewPersonal.ReadOnly = true;
            this.dataGridViewPersonal.RowHeadersWidth = 10;
            this.dataGridViewPersonal.Size = new System.Drawing.Size(942, 624);
            this.dataGridViewPersonal.TabIndex = 2;
            // 
            // nameAllDataGridViewTextBoxColumn
            // 
            this.nameAllDataGridViewTextBoxColumn.DataPropertyName = "Name(All)";
            this.nameAllDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.nameAllDataGridViewTextBoxColumn.Name = "nameAllDataGridViewTextBoxColumn";
            this.nameAllDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameAllDataGridViewTextBoxColumn.Width = 200;
            // 
            // ntionalityDataGridViewTextBoxColumn
            // 
            this.ntionalityDataGridViewTextBoxColumn.DataPropertyName = "Ntionality";
            this.ntionalityDataGridViewTextBoxColumn.HeaderText = "Гражданство";
            this.ntionalityDataGridViewTextBoxColumn.Name = "ntionalityDataGridViewTextBoxColumn";
            this.ntionalityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "Город проживания";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Адресс";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            this.adressDataGridViewTextBoxColumn.ReadOnly = true;
            this.adressDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Дата  Рождения";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateOfBirthDataGridViewTextBoxColumn.Width = 70;
            // 
            // iINDataGridViewTextBoxColumn
            // 
            this.iINDataGridViewTextBoxColumn.DataPropertyName = "IIN";
            this.iINDataGridViewTextBoxColumn.HeaderText = "ИИН";
            this.iINDataGridViewTextBoxColumn.Name = "iINDataGridViewTextBoxColumn";
            this.iINDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            this.positionDataGridViewTextBoxColumn.Width = 70;
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "Tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            this.telDataGridViewTextBoxColumn.ReadOnly = true;
            this.telDataGridViewTextBoxColumn.Width = 70;
            // 
            // mobileTelDataGridViewTextBoxColumn
            // 
            this.mobileTelDataGridViewTextBoxColumn.DataPropertyName = "MobileTel";
            this.mobileTelDataGridViewTextBoxColumn.HeaderText = "Мобильный";
            this.mobileTelDataGridViewTextBoxColumn.Name = "mobileTelDataGridViewTextBoxColumn";
            this.mobileTelDataGridViewTextBoxColumn.ReadOnly = true;
            this.mobileTelDataGridViewTextBoxColumn.Width = 70;
            // 
            // personalBindingSource
            // 
            this.personalBindingSource.DataMember = "Personal";
            this.personalBindingSource.DataSource = this.febosDBDataSet;
            // 
            // febosDBDataSet
            // 
            this.febosDBDataSet.DataSetName = "FebosDBDataSet";
            this.febosDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personalTableAdapter
            // 
            this.personalTableAdapter.ClearBeforeFill = true;
            // 
            // buttonInsertPersonal
            // 
            this.buttonInsertPersonal.BackColor = System.Drawing.Color.LightGreen;
            this.buttonInsertPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsertPersonal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInsertPersonal.ForeColor = System.Drawing.Color.White;
            this.buttonInsertPersonal.Location = new System.Drawing.Point(963, 92);
            this.buttonInsertPersonal.Name = "buttonInsertPersonal";
            this.buttonInsertPersonal.Size = new System.Drawing.Size(147, 72);
            this.buttonInsertPersonal.TabIndex = 4;
            this.buttonInsertPersonal.Text = "Принять На Работу";
            this.buttonInsertPersonal.UseVisualStyleBackColor = false;
            this.buttonInsertPersonal.Click += new System.EventHandler(this.buttonInsertPersonal_Click);
            // 
            // buttonPrintPersonal
            // 
            this.buttonPrintPersonal.BackColor = System.Drawing.Color.LightGreen;
            this.buttonPrintPersonal.BackgroundImage = global::Febos.Properties.Resources.Excel_15;
            this.buttonPrintPersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPrintPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrintPersonal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrintPersonal.ForeColor = System.Drawing.Color.White;
            this.buttonPrintPersonal.Location = new System.Drawing.Point(361, 34);
            this.buttonPrintPersonal.Name = "buttonPrintPersonal";
            this.buttonPrintPersonal.Size = new System.Drawing.Size(30, 30);
            this.buttonPrintPersonal.TabIndex = 5;
            this.buttonPrintPersonal.UseVisualStyleBackColor = false;
            this.buttonPrintPersonal.Click += new System.EventHandler(this.buttonPrintPersonal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(0, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(939, 10);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Febos.Properties.Resources.personal;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(26, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.BackColor = System.Drawing.Color.Transparent;
            this.labelLogo.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogo.ForeColor = System.Drawing.SystemColors.Control;
            this.labelLogo.Location = new System.Drawing.Point(82, 22);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(199, 42);
            this.labelLogo.TabIndex = 13;
            this.labelLogo.Text = "Персонал";
            // 
            // FormPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1344, 729);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelLogo);
            this.Controls.Add(this.buttonPrintPersonal);
            this.Controls.Add(this.buttonInsertPersonal);
            this.Controls.Add(this.dataGridViewPersonal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1360, 726);
            this.Name = "FormPersonal";
            this.Text = "Персонал";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPersonal_FormClosed);
            this.Load += new System.EventHandler(this.FormPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.febosDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameAllDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ntionalityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonInsertPersonal;
        public System.Windows.Forms.BindingSource personalBindingSource;
        public FebosDBDataSetTableAdapters.PersonalTableAdapter personalTableAdapter;
        public FebosDBDataSet febosDBDataSet;
        private System.Windows.Forms.Button buttonPrintPersonal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelLogo;
    }
}