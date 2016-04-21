namespace Febos
{
    partial class FormAccessOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccessOrders));
            this.dataGridViewAccessOrders = new System.Windows.Forms.DataGridView();
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
            this.idInventoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accessOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.febosDBDataSet = new Febos.FebosDBDataSet();
            this.accessOrdersTableAdapter = new Febos.FebosDBDataSetTableAdapters.AccessOrdersTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelLogo = new System.Windows.Forms.Label();
            this.buttonAccessOrders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccessOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.febosDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAccessOrders
            // 
            this.dataGridViewAccessOrders.AutoGenerateColumns = false;
            this.dataGridViewAccessOrders.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewAccessOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccessOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.moneyDataGridViewTextBoxColumn,
            this.idInventoryDataGridViewTextBoxColumn});
            this.dataGridViewAccessOrders.DataSource = this.accessOrdersBindingSource;
            this.dataGridViewAccessOrders.Location = new System.Drawing.Point(-1, 99);
            this.dataGridViewAccessOrders.Name = "dataGridViewAccessOrders";
            this.dataGridViewAccessOrders.RowHeadersWidth = 10;
            this.dataGridViewAccessOrders.Size = new System.Drawing.Size(1111, 627);
            this.dataGridViewAccessOrders.TabIndex = 0;
            // 
            // numberOfOrderDataGridViewTextBoxColumn
            // 
            this.numberOfOrderDataGridViewTextBoxColumn.DataPropertyName = "NumberOfOrder";
            this.numberOfOrderDataGridViewTextBoxColumn.HeaderText = "№Заказа";
            this.numberOfOrderDataGridViewTextBoxColumn.Name = "numberOfOrderDataGridViewTextBoxColumn";
            // 
            // orderDataGridViewTextBoxColumn
            // 
            this.orderDataGridViewTextBoxColumn.DataPropertyName = "Order";
            this.orderDataGridViewTextBoxColumn.HeaderText = "Заказ";
            this.orderDataGridViewTextBoxColumn.Name = "orderDataGridViewTextBoxColumn";
            // 
            // dateOfAccessDataGridViewTextBoxColumn
            // 
            this.dateOfAccessDataGridViewTextBoxColumn.DataPropertyName = "DateOfAccess";
            this.dateOfAccessDataGridViewTextBoxColumn.HeaderText = "Дата Оформления";
            this.dateOfAccessDataGridViewTextBoxColumn.Name = "dateOfAccessDataGridViewTextBoxColumn";
            // 
            // dateOfEndDataGridViewTextBoxColumn
            // 
            this.dateOfEndDataGridViewTextBoxColumn.DataPropertyName = "DateOfEnd";
            this.dateOfEndDataGridViewTextBoxColumn.HeaderText = "Дата Выполнения";
            this.dateOfEndDataGridViewTextBoxColumn.Name = "dateOfEndDataGridViewTextBoxColumn";
            // 
            // typeOfObjectDataGridViewTextBoxColumn
            // 
            this.typeOfObjectDataGridViewTextBoxColumn.DataPropertyName = "TypeOfObject";
            this.typeOfObjectDataGridViewTextBoxColumn.HeaderText = "Тип обьекта";
            this.typeOfObjectDataGridViewTextBoxColumn.Name = "typeOfObjectDataGridViewTextBoxColumn";
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
            // nameOfClientDataGridViewTextBoxColumn
            // 
            this.nameOfClientDataGridViewTextBoxColumn.DataPropertyName = "NameOfClient";
            this.nameOfClientDataGridViewTextBoxColumn.HeaderText = "Имя клиента";
            this.nameOfClientDataGridViewTextBoxColumn.Name = "nameOfClientDataGridViewTextBoxColumn";
            // 
            // nameOfWorkmanDataGridViewTextBoxColumn
            // 
            this.nameOfWorkmanDataGridViewTextBoxColumn.DataPropertyName = "NameOfWorkman";
            this.nameOfWorkmanDataGridViewTextBoxColumn.HeaderText = "Имя работника";
            this.nameOfWorkmanDataGridViewTextBoxColumn.Name = "nameOfWorkmanDataGridViewTextBoxColumn";
            // 
            // moneyDataGridViewTextBoxColumn
            // 
            this.moneyDataGridViewTextBoxColumn.DataPropertyName = "Money";
            this.moneyDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.moneyDataGridViewTextBoxColumn.Name = "moneyDataGridViewTextBoxColumn";
            // 
            // idInventoryDataGridViewTextBoxColumn
            // 
            this.idInventoryDataGridViewTextBoxColumn.DataPropertyName = "IdInventory";
            this.idInventoryDataGridViewTextBoxColumn.HeaderText = "id Использованного инвентаря";
            this.idInventoryDataGridViewTextBoxColumn.Name = "idInventoryDataGridViewTextBoxColumn";
            // 
            // accessOrdersBindingSource
            // 
            this.accessOrdersBindingSource.DataMember = "AccessOrders";
            this.accessOrdersBindingSource.DataSource = this.febosDBDataSet;
            // 
            // febosDBDataSet
            // 
            this.febosDBDataSet.DataSetName = "FebosDBDataSet";
            this.febosDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accessOrdersTableAdapter
            // 
            this.accessOrdersTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(-1, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 10);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Febos.Properties.Resources.spisok;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(24, 20);
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
            this.labelLogo.Location = new System.Drawing.Point(80, 28);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(385, 42);
            this.labelLogo.TabIndex = 13;
            this.labelLogo.Text = "Выполненные заказы";
            // 
            // buttonAccessOrders
            // 
            this.buttonAccessOrders.BackColor = System.Drawing.Color.Tan;
            this.buttonAccessOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccessOrders.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAccessOrders.ForeColor = System.Drawing.Color.White;
            this.buttonAccessOrders.Location = new System.Drawing.Point(1116, 99);
            this.buttonAccessOrders.Name = "buttonAccessOrders";
            this.buttonAccessOrders.Size = new System.Drawing.Size(170, 72);
            this.buttonAccessOrders.TabIndex = 16;
            this.buttonAccessOrders.Text = "Отметить как выполненный";
            this.buttonAccessOrders.UseVisualStyleBackColor = false;
            this.buttonAccessOrders.Click += new System.EventHandler(this.buttonAccessOrders_Click);
            // 
            // FormAccessOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1354, 729);
            this.Controls.Add(this.buttonAccessOrders);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelLogo);
            this.Controls.Add(this.dataGridViewAccessOrders);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1360, 726);
            this.Name = "FormAccessOrders";
            this.Text = "Выполненные заказы";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAccessOrders_FormClosed);
            this.Load += new System.EventHandler(this.FormAccessOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccessOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.febosDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAccessOrders;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelLogo;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idInventoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonAccessOrders;
        public FebosDBDataSet febosDBDataSet;
        public System.Windows.Forms.BindingSource accessOrdersBindingSource;
        public FebosDBDataSetTableAdapters.AccessOrdersTableAdapter accessOrdersTableAdapter;
    }
}