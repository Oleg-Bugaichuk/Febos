namespace Febos
{
    partial class FormInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInventory));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelLogo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfObjectsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seryalNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfAccessDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.febosDBDataSet = new Febos.FebosDBDataSet();
            this.inventoryTableAdapter = new Febos.FebosDBDataSetTableAdapters.InventoryTableAdapter();
            this.buttonInsertOrders = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.febosDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(0, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 10);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Febos.Properties.Resources.inventory;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(25, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.BackColor = System.Drawing.Color.Transparent;
            this.labelLogo.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogo.ForeColor = System.Drawing.SystemColors.Control;
            this.labelLogo.Location = new System.Drawing.Point(81, 15);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(128, 42);
            this.labelLogo.TabIndex = 17;
            this.labelLogo.Text = "Склад";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.typeOfObjectsDataGridViewTextBoxColumn,
            this.brendDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.seryalNumberDataGridViewTextBoxColumn,
            this.dateOfAccessDataGridViewTextBoxColumn,
            this.moneyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inventoryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.Size = new System.Drawing.Size(672, 605);
            this.dataGridView1.TabIndex = 20;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 30;
            // 
            // typeOfObjectsDataGridViewTextBoxColumn
            // 
            this.typeOfObjectsDataGridViewTextBoxColumn.DataPropertyName = "TypeOfObjects";
            this.typeOfObjectsDataGridViewTextBoxColumn.HeaderText = "Тип обьекта";
            this.typeOfObjectsDataGridViewTextBoxColumn.Name = "typeOfObjectsDataGridViewTextBoxColumn";
            this.typeOfObjectsDataGridViewTextBoxColumn.Width = 130;
            // 
            // brendDataGridViewTextBoxColumn
            // 
            this.brendDataGridViewTextBoxColumn.DataPropertyName = "Brend";
            this.brendDataGridViewTextBoxColumn.HeaderText = "Бренд";
            this.brendDataGridViewTextBoxColumn.Name = "brendDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Модель";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // seryalNumberDataGridViewTextBoxColumn
            // 
            this.seryalNumberDataGridViewTextBoxColumn.DataPropertyName = "SeryalNumber";
            this.seryalNumberDataGridViewTextBoxColumn.HeaderText = "Серийный номер";
            this.seryalNumberDataGridViewTextBoxColumn.Name = "seryalNumberDataGridViewTextBoxColumn";
            // 
            // dateOfAccessDataGridViewTextBoxColumn
            // 
            this.dateOfAccessDataGridViewTextBoxColumn.DataPropertyName = "DateOfAccess";
            this.dateOfAccessDataGridViewTextBoxColumn.HeaderText = "Дата поступления";
            this.dateOfAccessDataGridViewTextBoxColumn.Name = "dateOfAccessDataGridViewTextBoxColumn";
            // 
            // moneyDataGridViewTextBoxColumn
            // 
            this.moneyDataGridViewTextBoxColumn.DataPropertyName = "Money";
            this.moneyDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.moneyDataGridViewTextBoxColumn.Name = "moneyDataGridViewTextBoxColumn";
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.febosDBDataSet;
            // 
            // febosDBDataSet
            // 
            this.febosDBDataSet.DataSetName = "FebosDBDataSet";
            this.febosDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // buttonInsertOrders
            // 
            this.buttonInsertOrders.BackColor = System.Drawing.Color.DarkGray;
            this.buttonInsertOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsertOrders.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInsertOrders.ForeColor = System.Drawing.Color.White;
            this.buttonInsertOrders.Location = new System.Drawing.Point(678, 82);
            this.buttonInsertOrders.Name = "buttonInsertOrders";
            this.buttonInsertOrders.Size = new System.Drawing.Size(170, 72);
            this.buttonInsertOrders.TabIndex = 21;
            this.buttonInsertOrders.Text = "Принять";
            this.buttonInsertOrders.UseVisualStyleBackColor = false;
            this.buttonInsertOrders.Click += new System.EventHandler(this.buttonInsertOrders_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(678, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 72);
            this.button1.TabIndex = 22;
            this.button1.Text = "Продать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1344, 687);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonInsertOrders);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1360, 726);
            this.Name = "FormInventory";
            this.Text = "Склад";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormInventory_FormClosed);
            this.Load += new System.EventHandler(this.FormInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.febosDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOfObjectsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seryalNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfAccessDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonInsertOrders;
        private System.Windows.Forms.Button button1;
        public FebosDBDataSet febosDBDataSet;
        public System.Windows.Forms.BindingSource inventoryBindingSource;
        public FebosDBDataSetTableAdapters.InventoryTableAdapter inventoryTableAdapter;

    }
}