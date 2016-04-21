namespace Febos
{
    partial class FormOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrders));
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.numberOfOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfAccessDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfObjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seryalNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameOfClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameOfWorkmanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.febosDBDataSet = new Febos.FebosDBDataSet();
            this.ordersTableAdapter = new Febos.FebosDBDataSetTableAdapters.OrdersTableAdapter();
            this.buttonInsertOrders = new System.Windows.Forms.Button();
            this.buttonShowAccessOrders = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelLogo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonExcelOrders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.febosDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewOrders.AutoGenerateColumns = false;
            this.dataGridViewOrders.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberOfOrderDataGridViewTextBoxColumn,
            this.orderDataGridViewTextBoxColumn,
            this.dateOfAccessDataGridViewTextBoxColumn,
            this.dateOfEndDataGridViewTextBoxColumn,
            this.typeOfObjectDataGridViewTextBoxColumn,
            this.brendDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.seryalNumberDataGridViewTextBoxColumn,
            this.nameOfClientDataGridViewTextBoxColumn,
            this.nameOfWorkmanDataGridViewTextBoxColumn,
            this.moneyDataGridViewTextBoxColumn});
            this.dataGridViewOrders.DataSource = this.ordersBindingSource;
            this.dataGridViewOrders.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewOrders.Location = new System.Drawing.Point(0, 86);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.ReadOnly = true;
            this.dataGridViewOrders.RowHeadersWidth = 10;
            this.dataGridViewOrders.Size = new System.Drawing.Size(1071, 643);
            this.dataGridViewOrders.TabIndex = 2;
            // 
            // numberOfOrderDataGridViewTextBoxColumn
            // 
            this.numberOfOrderDataGridViewTextBoxColumn.DataPropertyName = "NumberOfOrder";
            this.numberOfOrderDataGridViewTextBoxColumn.HeaderText = "№ Заказа";
            this.numberOfOrderDataGridViewTextBoxColumn.Name = "numberOfOrderDataGridViewTextBoxColumn";
            this.numberOfOrderDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberOfOrderDataGridViewTextBoxColumn.Width = 50;
            // 
            // orderDataGridViewTextBoxColumn
            // 
            this.orderDataGridViewTextBoxColumn.DataPropertyName = "Order";
            this.orderDataGridViewTextBoxColumn.HeaderText = "Заказ";
            this.orderDataGridViewTextBoxColumn.Name = "orderDataGridViewTextBoxColumn";
            this.orderDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderDataGridViewTextBoxColumn.Width = 200;
            // 
            // dateOfAccessDataGridViewTextBoxColumn
            // 
            this.dateOfAccessDataGridViewTextBoxColumn.DataPropertyName = "DateOfAccess";
            this.dateOfAccessDataGridViewTextBoxColumn.HeaderText = "Дата оформления";
            this.dateOfAccessDataGridViewTextBoxColumn.Name = "dateOfAccessDataGridViewTextBoxColumn";
            this.dateOfAccessDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateOfAccessDataGridViewTextBoxColumn.Width = 70;
            // 
            // dateOfEndDataGridViewTextBoxColumn
            // 
            this.dateOfEndDataGridViewTextBoxColumn.DataPropertyName = "DateOfEnd";
            this.dateOfEndDataGridViewTextBoxColumn.HeaderText = "Предпочитаемая Дата Выполнения";
            this.dateOfEndDataGridViewTextBoxColumn.Name = "dateOfEndDataGridViewTextBoxColumn";
            this.dateOfEndDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateOfEndDataGridViewTextBoxColumn.Width = 70;
            // 
            // typeOfObjectDataGridViewTextBoxColumn
            // 
            this.typeOfObjectDataGridViewTextBoxColumn.DataPropertyName = "TypeOfObject";
            this.typeOfObjectDataGridViewTextBoxColumn.HeaderText = "Тип Обьекта";
            this.typeOfObjectDataGridViewTextBoxColumn.Name = "typeOfObjectDataGridViewTextBoxColumn";
            this.typeOfObjectDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeOfObjectDataGridViewTextBoxColumn.Width = 50;
            // 
            // brendDataGridViewTextBoxColumn
            // 
            this.brendDataGridViewTextBoxColumn.DataPropertyName = "Brend";
            this.brendDataGridViewTextBoxColumn.HeaderText = "Бренд";
            this.brendDataGridViewTextBoxColumn.Name = "brendDataGridViewTextBoxColumn";
            this.brendDataGridViewTextBoxColumn.ReadOnly = true;
            this.brendDataGridViewTextBoxColumn.Width = 50;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Модель";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            this.modelDataGridViewTextBoxColumn.Width = 50;
            // 
            // seryalNumberDataGridViewTextBoxColumn
            // 
            this.seryalNumberDataGridViewTextBoxColumn.DataPropertyName = "SeryalNumber";
            this.seryalNumberDataGridViewTextBoxColumn.HeaderText = "Серийный Номер";
            this.seryalNumberDataGridViewTextBoxColumn.Name = "seryalNumberDataGridViewTextBoxColumn";
            this.seryalNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.seryalNumberDataGridViewTextBoxColumn.Width = 50;
            // 
            // nameOfClientDataGridViewTextBoxColumn
            // 
            this.nameOfClientDataGridViewTextBoxColumn.DataPropertyName = "NameOfClient";
            this.nameOfClientDataGridViewTextBoxColumn.HeaderText = "Имя Клиента";
            this.nameOfClientDataGridViewTextBoxColumn.Name = "nameOfClientDataGridViewTextBoxColumn";
            this.nameOfClientDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameOfClientDataGridViewTextBoxColumn.Width = 200;
            // 
            // nameOfWorkmanDataGridViewTextBoxColumn
            // 
            this.nameOfWorkmanDataGridViewTextBoxColumn.DataPropertyName = "NameOfWorkman";
            this.nameOfWorkmanDataGridViewTextBoxColumn.HeaderText = "Имя Исполнителя";
            this.nameOfWorkmanDataGridViewTextBoxColumn.Name = "nameOfWorkmanDataGridViewTextBoxColumn";
            this.nameOfWorkmanDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameOfWorkmanDataGridViewTextBoxColumn.Width = 200;
            // 
            // moneyDataGridViewTextBoxColumn
            // 
            this.moneyDataGridViewTextBoxColumn.DataPropertyName = "Money";
            this.moneyDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.moneyDataGridViewTextBoxColumn.Name = "moneyDataGridViewTextBoxColumn";
            this.moneyDataGridViewTextBoxColumn.ReadOnly = true;
            this.moneyDataGridViewTextBoxColumn.Width = 70;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.febosDBDataSet;
            // 
            // febosDBDataSet
            // 
            this.febosDBDataSet.DataSetName = "FebosDBDataSet";
            this.febosDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // buttonInsertOrders
            // 
            this.buttonInsertOrders.BackColor = System.Drawing.Color.Tan;
            this.buttonInsertOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsertOrders.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInsertOrders.ForeColor = System.Drawing.Color.White;
            this.buttonInsertOrders.Location = new System.Drawing.Point(1077, 86);
            this.buttonInsertOrders.Name = "buttonInsertOrders";
            this.buttonInsertOrders.Size = new System.Drawing.Size(170, 72);
            this.buttonInsertOrders.TabIndex = 3;
            this.buttonInsertOrders.Text = "Принять Заказ";
            this.buttonInsertOrders.UseVisualStyleBackColor = false;
            this.buttonInsertOrders.Click += new System.EventHandler(this.buttonInsertOrders_Click);
            // 
            // buttonShowAccessOrders
            // 
            this.buttonShowAccessOrders.BackColor = System.Drawing.Color.Tan;
            this.buttonShowAccessOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowAccessOrders.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowAccessOrders.ForeColor = System.Drawing.Color.White;
            this.buttonShowAccessOrders.Location = new System.Drawing.Point(1077, 183);
            this.buttonShowAccessOrders.Name = "buttonShowAccessOrders";
            this.buttonShowAccessOrders.Size = new System.Drawing.Size(170, 75);
            this.buttonShowAccessOrders.TabIndex = 4;
            this.buttonShowAccessOrders.Text = "Выполненные заказы";
            this.buttonShowAccessOrders.UseVisualStyleBackColor = false;
            this.buttonShowAccessOrders.Click += new System.EventHandler(this.buttonShowAccessOrders_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Febos.Properties.Resources.spisok;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(25, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.BackColor = System.Drawing.Color.Transparent;
            this.labelLogo.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogo.ForeColor = System.Drawing.SystemColors.Control;
            this.labelLogo.Location = new System.Drawing.Point(81, 16);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(142, 42);
            this.labelLogo.TabIndex = 10;
            this.labelLogo.Text = "Заказы";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(0, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 10);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Febos.Properties.Resources.w512h5121347465000Update;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(301, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonExcelOrders
            // 
            this.buttonExcelOrders.BackgroundImage = global::Febos.Properties.Resources.Excel_15;
            this.buttonExcelOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExcelOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcelOrders.Location = new System.Drawing.Point(337, 28);
            this.buttonExcelOrders.Name = "buttonExcelOrders";
            this.buttonExcelOrders.Size = new System.Drawing.Size(30, 30);
            this.buttonExcelOrders.TabIndex = 18;
            this.buttonExcelOrders.UseVisualStyleBackColor = true;
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1344, 729);
            this.Controls.Add(this.buttonExcelOrders);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelLogo);
            this.Controls.Add(this.buttonShowAccessOrders);
            this.Controls.Add(this.buttonInsertOrders);
            this.Controls.Add(this.dataGridViewOrders);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1360, 726);
            this.Name = "FormOrders";
            this.Text = "Заказы";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormOrders_FormClosed);
            this.Load += new System.EventHandler(this.FormOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.febosDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfAccessDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfEndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOfObjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seryalNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOfClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOfWorkmanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonInsertOrders;
        public FebosDBDataSet febosDBDataSet;
        public System.Windows.Forms.BindingSource ordersBindingSource;
        public FebosDBDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.Button buttonShowAccessOrders;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonExcelOrders;
    }
}