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
            this.lbl_AreYouSure = new System.Windows.Forms.Label();
            this.btn_Yes = new System.Windows.Forms.Button();
            this.btn_No = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_AreYouSure
            // 
            this.lbl_AreYouSure.AutoSize = true;
            this.lbl_AreYouSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AreYouSure.Location = new System.Drawing.Point(113, 32);
            this.lbl_AreYouSure.Name = "lbl_AreYouSure";
            this.lbl_AreYouSure.Size = new System.Drawing.Size(111, 20);
            this.lbl_AreYouSure.TabIndex = 0;
            this.lbl_AreYouSure.Text = "Oletko varma?";
            // 
            // btn_Yes
            // 
            this.btn_Yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Yes.Location = new System.Drawing.Point(233, 69);
            this.btn_Yes.Name = "btn_Yes";
            this.btn_Yes.Size = new System.Drawing.Size(83, 39);
            this.btn_Yes.TabIndex = 1;
            this.btn_Yes.Text = "Ei";
            this.btn_Yes.UseVisualStyleBackColor = true;
            // 
            // btn_No
            // 
            this.btn_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_No.Location = new System.Drawing.Point(30, 69);
            this.btn_No.Name = "btn_No";
            this.btn_No.Size = new System.Drawing.Size(82, 39);
            this.btn_No.TabIndex = 2;
            this.btn_No.Text = "Kyllä";
            this.btn_No.UseVisualStyleBackColor = true;
            // 
            // AreYouSure_popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 123);
            this.Controls.Add(this.btn_No);
            this.Controls.Add(this.btn_Yes);
            this.Controls.Add(this.lbl_AreYouSure);
            this.Name = "AreYouSure_popup";
            this.Text = "Varmistus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_AreYouSure;
        private System.Windows.Forms.Button btn_Yes;
        private System.Windows.Forms.Button btn_No;
    }
}