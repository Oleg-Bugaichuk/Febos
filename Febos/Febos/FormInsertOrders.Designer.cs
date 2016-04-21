namespace Febos
{
    partial class FormInsertOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInsertOrders));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxOrder = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.textBoxBrend = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxSeryal = new System.Windows.Forms.TextBox();
            this.textBoxNameOfClient = new System.Windows.Forms.TextBox();
            this.textBoxMoney = new System.Windows.Forms.TextBox();
            this.comboBoxNameOfWokman = new System.Windows.Forms.ComboBox();
            this.personalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.febosDBDataSet = new Febos.FebosDBDataSet();
            this.personalTableAdapter = new Febos.FebosDBDataSetTableAdapters.PersonalTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.febosDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Заказ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата оформления";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "Предпочитаемая дата\r\nвыполнения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Тип обьекта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Бренд ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Модель";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Серийный Номер";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "Имя клиента";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 397);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 22);
            this.label9.TabIndex = 8;
            this.label9.Text = "Имя исполнителя";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(12, 443);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 22);
            this.label10.TabIndex = 9;
            this.label10.Text = "Стоимость";
            // 
            // textBoxOrder
            // 
            this.textBoxOrder.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOrder.Location = new System.Drawing.Point(130, 18);
            this.textBoxOrder.Name = "textBoxOrder";
            this.textBoxOrder.Size = new System.Drawing.Size(337, 22);
            this.textBoxOrder.TabIndex = 10;
            // 
            // textBoxType
            // 
            this.textBoxType.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxType.Location = new System.Drawing.Point(285, 165);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(182, 22);
            this.textBoxType.TabIndex = 11;
            // 
            // textBoxBrend
            // 
            this.textBoxBrend.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBrend.Location = new System.Drawing.Point(285, 214);
            this.textBoxBrend.Name = "textBoxBrend";
            this.textBoxBrend.Size = new System.Drawing.Size(182, 22);
            this.textBoxBrend.TabIndex = 12;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxModel.Location = new System.Drawing.Point(285, 256);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(182, 22);
            this.textBoxModel.TabIndex = 13;
            // 
            // textBoxSeryal
            // 
            this.textBoxSeryal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSeryal.Location = new System.Drawing.Point(256, 303);
            this.textBoxSeryal.Name = "textBoxSeryal";
            this.textBoxSeryal.Size = new System.Drawing.Size(211, 22);
            this.textBoxSeryal.TabIndex = 14;
            // 
            // textBoxNameOfClient
            // 
            this.textBoxNameOfClient.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameOfClient.Location = new System.Drawing.Point(189, 351);
            this.textBoxNameOfClient.Name = "textBoxNameOfClient";
            this.textBoxNameOfClient.Size = new System.Drawing.Size(278, 22);
            this.textBoxNameOfClient.TabIndex = 15;
            // 
            // textBoxMoney
            // 
            this.textBoxMoney.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMoney.Location = new System.Drawing.Point(334, 445);
            this.textBoxMoney.Name = "textBoxMoney";
            this.textBoxMoney.Size = new System.Drawing.Size(133, 22);
            this.textBoxMoney.TabIndex = 16;
            // 
            // comboBoxNameOfWokman
            // 
            this.comboBoxNameOfWokman.DataSource = this.personalBindingSource;
            this.comboBoxNameOfWokman.DisplayMember = "Name(All)";
            this.comboBoxNameOfWokman.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxNameOfWokman.FormattingEnabled = true;
            this.comboBoxNameOfWokman.Location = new System.Drawing.Point(189, 398);
            this.comboBoxNameOfWokman.Name = "comboBoxNameOfWokman";
            this.comboBoxNameOfWokman.Size = new System.Drawing.Size(278, 25);
            this.comboBoxNameOfWokman.TabIndex = 17;
            this.comboBoxNameOfWokman.ValueMember = "Name(All)";
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(285, 54);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(182, 22);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.Value = new System.DateTime(2016, 2, 3, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker2.Location = new System.Drawing.Point(285, 121);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(182, 22);
            this.dateTimePicker2.TabIndex = 19;
            this.dateTimePicker2.Value = new System.DateTime(2016, 2, 14, 0, 0, 0, 0);
            // 
            // buttonInsert
            // 
            this.buttonInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsert.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInsert.ForeColor = System.Drawing.Color.White;
            this.buttonInsert.Location = new System.Drawing.Point(195, 485);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(133, 38);
            this.buttonInsert.TabIndex = 20;
            this.buttonInsert.Text = "Принять";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(334, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 38);
            this.button1.TabIndex = 21;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormInsertOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(479, 535);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxNameOfWokman);
            this.Controls.Add(this.textBoxMoney);
            this.Controls.Add(this.textBoxNameOfClient);
            this.Controls.Add(this.textBoxSeryal);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.textBoxBrend);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.textBoxOrder);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInsertOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Принять заказ";
            this.Load += new System.EventHandler(this.FormInsertOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.febosDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxOrder;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.TextBox textBoxBrend;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxSeryal;
        private System.Windows.Forms.TextBox textBoxNameOfClient;
        private System.Windows.Forms.TextBox textBoxMoney;
        private System.Windows.Forms.ComboBox comboBoxNameOfWokman;
        private FebosDBDataSet febosDBDataSet;
        private System.Windows.Forms.BindingSource personalBindingSource;
        private FebosDBDataSetTableAdapters.PersonalTableAdapter personalTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button button1;
    }
}