namespace R3_VillagePeople_Mahtimokit
{
    partial class AreYouSure_popup
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
            this.lbl_Confirm_Are_You_Sure = new System.Windows.Forms.Label();
            this.btn_Confirm_No = new System.Windows.Forms.Button();
            this.btn_Confirm_Yes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Confirm_Are_You_Sure
            // 
            this.lbl_Confirm_Are_You_Sure.AutoSize = true;
            this.lbl_Confirm_Are_You_Sure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Confirm_Are_You_Sure.Location = new System.Drawing.Point(113, 32);
            this.lbl_Confirm_Are_You_Sure.Name = "lbl_Confirm_Are_You_Sure";
            this.lbl_Confirm_Are_You_Sure.Size = new System.Drawing.Size(111, 20);
            this.lbl_Confirm_Are_You_Sure.TabIndex = 0;
            this.lbl_Confirm_Are_You_Sure.Text = "Oletko varma?";
            // 
            // btn_Confirm_No
            // 
            this.btn_Confirm_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirm_No.Location = new System.Drawing.Point(233, 69);
            this.btn_Confirm_No.Name = "btn_Confirm_No";
            this.btn_Confirm_No.Size = new System.Drawing.Size(83, 39);
            this.btn_Confirm_No.TabIndex = 1;
            this.btn_Confirm_No.Text = "Ei";
            this.btn_Confirm_No.UseVisualStyleBackColor = true;
            // 
            // btn_Confirm_Yes
            // 
            this.btn_Confirm_Yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirm_Yes.Location = new System.Drawing.Point(30, 69);
            this.btn_Confirm_Yes.Name = "btn_Confirm_Yes";
            this.btn_Confirm_Yes.Size = new System.Drawing.Size(82, 39);
            this.btn_Confirm_Yes.TabIndex = 2;
            this.btn_Confirm_Yes.Text = "Kyllä";
            this.btn_Confirm_Yes.UseVisualStyleBackColor = true;
            // 
            // AreYouSure_popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 123);
            this.Controls.Add(this.btn_Confirm_Yes);
            this.Controls.Add(this.btn_Confirm_No);
            this.Controls.Add(this.lbl_Confirm_Are_You_Sure);
            this.Name = "AreYouSure_popup";
            this.Text = "Varmistus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Confirm_Are_You_Sure;
        private System.Windows.Forms.Button btn_Confirm_No;
        private System.Windows.Forms.Button btn_Confirm_Yes;
    }
}