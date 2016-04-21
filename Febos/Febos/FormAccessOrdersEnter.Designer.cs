namespace Febos
{
    partial class FormAccessOrdersEnter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccessOrdersEnter));
            this.comboBoxId = new System.Windows.Forms.ComboBox();
            this.febosDBDataSet = new Febos.FebosDBDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new Febos.FebosDBDataSetTableAdapters.OrdersTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonInsertOrders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.febosDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxId
            // 
            this.comboBoxId.DataSource = this.ordersBindingSource;
            this.comboBoxId.DisplayMember = "NumberOfOrder";
            this.comboBoxId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxId.FormattingEnabled = true;
            this.comboBoxId.Location = new System.Drawing.Point(367, 55);
            this.comboBoxId.Name = "comboBoxId";
            this.comboBoxId.Size = new System.Drawing.Size(50, 29);
            this.comboBoxId.TabIndex = 0;
            // 
            // febosDBDataSet
            // 
            this.febosDBDataSet.DataSetName = "FebosDBDataSet";
            this.febosDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.febosDBDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "№ Заказа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата Выполнения";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(242, 112);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(175, 27);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // buttonInsertOrders
            // 
            this.buttonInsertOrders.BackColor = System.Drawing.Color.Tan;
            this.buttonInsertOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsertOrders.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInsertOrders.ForeColor = System.Drawing.Color.White;
            this.buttonInsertOrders.Location = new System.Drawing.Point(293, 187);
            this.buttonInsertOrders.Name = "buttonInsertOrders";
            this.buttonInsertOrders.Size = new System.Drawing.Size(124, 48);
            this.buttonInsertOrders.TabIndex = 4;
            this.buttonInsertOrders.Text = "Отметить";
            this.buttonInsertOrders.UseVisualStyleBackColor = false;
            this.buttonInsertOrders.Click += new System.EventHandler(this.buttonInsertOrders_Click);
            // 
            // FormAccessOrdersEnter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(444, 247);
            this.Controls.Add(this.buttonInsertOrders);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAccessOrdersEnter";
            this.Text = "Отметить выполненный заказ";
            this.Load += new System.EventHandler(this.FormAccessOrdersEnter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.febosDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxId;
        private FebosDBDataSet febosDBDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private FebosDBDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonInsertOrders;
    }
}