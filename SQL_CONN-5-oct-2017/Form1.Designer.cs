namespace SQL_CONN_5_oct_2017 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txbCurrTextDSte = new System.Windows.Forms.TextBox();
            this.btnSaveTextDSte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbCurrTextDSte
            // 
            this.txbCurrTextDSte.Location = new System.Drawing.Point(12, 12);
            this.txbCurrTextDSte.Name = "txbCurrTextDSte";
            this.txbCurrTextDSte.Size = new System.Drawing.Size(260, 20);
            this.txbCurrTextDSte.TabIndex = 1;
            // 
            // btnSaveTextDSte
            // 
            this.btnSaveTextDSte.Location = new System.Drawing.Point(12, 39);
            this.btnSaveTextDSte.Name = "btnSaveTextDSte";
            this.btnSaveTextDSte.Size = new System.Drawing.Size(260, 30);
            this.btnSaveTextDSte.TabIndex = 2;
            this.btnSaveTextDSte.Text = "Save";
            this.btnSaveTextDSte.UseVisualStyleBackColor = true;
            this.btnSaveTextDSte.Click += new System.EventHandler(this.btnSaveTextDSte_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 81);
            this.Controls.Add(this.btnSaveTextDSte);
            this.Controls.Add(this.txbCurrTextDSte);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbCurrTextDSte;
        private System.Windows.Forms.Button btnSaveTextDSte;
    }
}

