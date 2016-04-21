namespace Febos
{
    partial class FormTrayInformation
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
            this.labelInformation = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelInformation.ForeColor = System.Drawing.SystemColors.Control;
            this.labelInformation.Location = new System.Drawing.Point(12, 26);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(0, 16);
            this.labelInformation.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Interval = 5000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.labelStatus.Location = new System.Drawing.Point(12, 44);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 16);
            this.labelStatus.TabIndex = 1;
            // 
            // FormTrayInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(261, 69);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelInformation);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(10, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormTrayInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormTrayInformation";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelStatus;
    }
}