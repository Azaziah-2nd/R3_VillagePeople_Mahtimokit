namespace R3_VillagePeople_Mahtimokit
{
    partial class frm_Are_You_Sure_Popup
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
            this.lbl_Are_You_Sure = new System.Windows.Forms.Label();
            this.btn_Are_You_Sure_No = new System.Windows.Forms.Button();
            this.btn_Are_You_Sure_Yes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Are_You_Sure
            // 
            this.lbl_Are_You_Sure.AutoSize = true;
            this.lbl_Are_You_Sure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Are_You_Sure.Location = new System.Drawing.Point(113, 32);
            this.lbl_Are_You_Sure.Name = "lbl_Are_You_Sure";
            this.lbl_Are_You_Sure.Size = new System.Drawing.Size(111, 20);
            this.lbl_Are_You_Sure.TabIndex = 0;
            this.lbl_Are_You_Sure.Text = "Oletko varma?";
            // 
            // btn_Are_You_Sure_No
            // 
            this.btn_Are_You_Sure_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Are_You_Sure_No.Location = new System.Drawing.Point(233, 69);
            this.btn_Are_You_Sure_No.Name = "btn_Are_You_Sure_No";
            this.btn_Are_You_Sure_No.Size = new System.Drawing.Size(83, 39);
            this.btn_Are_You_Sure_No.TabIndex = 1;
            this.btn_Are_You_Sure_No.Text = "Ei";
            this.btn_Are_You_Sure_No.UseVisualStyleBackColor = true;
            // 
            // btn_Are_You_Sure_Yes
            // 
            this.btn_Are_You_Sure_Yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Are_You_Sure_Yes.Location = new System.Drawing.Point(30, 69);
            this.btn_Are_You_Sure_Yes.Name = "btn_Are_You_Sure_Yes";
            this.btn_Are_You_Sure_Yes.Size = new System.Drawing.Size(82, 39);
            this.btn_Are_You_Sure_Yes.TabIndex = 2;
            this.btn_Are_You_Sure_Yes.Text = "Kyllä";
            this.btn_Are_You_Sure_Yes.UseVisualStyleBackColor = true;
            // 
            // frm_Are_You_Sure_Popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 123);
            this.Controls.Add(this.btn_Are_You_Sure_Yes);
            this.Controls.Add(this.btn_Are_You_Sure_No);
            this.Controls.Add(this.lbl_Are_You_Sure);
            this.Name = "frm_Are_You_Sure_Popup";
            this.Text = "Varmistus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Are_You_Sure;
        private System.Windows.Forms.Button btn_Are_You_Sure_No;
        private System.Windows.Forms.Button btn_Are_You_Sure_Yes;
    }
}