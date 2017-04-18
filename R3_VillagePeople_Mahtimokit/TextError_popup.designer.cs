namespace R3_VillagePeople_Mahtimokit
{
    partial class TextError_popup
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
            this.btn_Error = new System.Windows.Forms.Button();
            this.lbl_Errortext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Error
            // 
            this.btn_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Error.Location = new System.Drawing.Point(140, 82);
            this.btn_Error.Name = "btn_Error";
            this.btn_Error.Size = new System.Drawing.Size(75, 29);
            this.btn_Error.TabIndex = 0;
            this.btn_Error.Text = "OK";
            this.btn_Error.UseVisualStyleBackColor = true;
            // 
            // lbl_Errortext
            // 
            this.lbl_Errortext.AutoSize = true;
            this.lbl_Errortext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Errortext.Location = new System.Drawing.Point(39, 24);
            this.lbl_Errortext.Name = "lbl_Errortext";
            this.lbl_Errortext.Size = new System.Drawing.Size(277, 40);
            this.lbl_Errortext.TabIndex = 1;
            this.lbl_Errortext.Text = "Virhe syöttäessä tietoja. \r\nTarkista, oletko syöttänyt tiedot oikein.";
            this.lbl_Errortext.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TextError_popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 123);
            this.Controls.Add(this.lbl_Errortext);
            this.Controls.Add(this.btn_Error);
            this.Name = "TextError_popup";
            this.Text = "Virhe!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Error;
        private System.Windows.Forms.Label lbl_Errortext;
    }
}