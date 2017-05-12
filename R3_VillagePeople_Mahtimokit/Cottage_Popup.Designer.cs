namespace R3_VillagePeople_Mahtimokit
{
    partial class frm_Cottage_Popup
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
            this.toimipisteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vP_DatabaseDataSet1 = new R3_VillagePeople_Mahtimokit.VP_DatabaseDataSet1();
            this.vP_DatabaseDataSet3 = new R3_VillagePeople_Mahtimokit.VP_DatabaseDataSet3();
            this.majoitusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toimipisteTableAdapter = new R3_VillagePeople_Mahtimokit.VP_DatabaseDataSet1TableAdapters.ToimipisteTableAdapter();
            this.txt_Cottage_Size = new System.Windows.Forms.TextBox();
            this.lbl_Cottage_Office = new System.Windows.Forms.Label();
            this.cbo_Cottage_Office_Select = new System.Windows.Forms.ComboBox();
            this.rbu_Cottage_Wlan_No = new System.Windows.Forms.RadioButton();
            this.rbu_Cottage_Wlan_Yes = new System.Windows.Forms.RadioButton();
            this.lbl_Cottage_Wlan = new System.Windows.Forms.Label();
            this.lbl_Cottage_Size = new System.Windows.Forms.Label();
            this.txt_Cottage_Max_Visitors = new System.Windows.Forms.TextBox();
            this.lbl_Cottage_Max_Visitors = new System.Windows.Forms.Label();
            this.txt_Cottage_Price = new System.Windows.Forms.TextBox();
            this.lbl_Cottage_Price = new System.Windows.Forms.Label();
            this.txt_Cottage_Description = new System.Windows.Forms.TextBox();
            this.lbl_Cottage_Description = new System.Windows.Forms.Label();
            this.txt_Cottage_Name = new System.Windows.Forms.TextBox();
            this.lbl_Cottage_Name = new System.Windows.Forms.Label();
            this.btn_Cottage_Save = new System.Windows.Forms.Button();
            this.btn_Cottage_Cancel = new System.Windows.Forms.Button();
            this.lbl_Cottage_Details = new System.Windows.Forms.Label();
            this.lbl_Euros = new System.Windows.Forms.Label();
            this.lbl_Square_Meters = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.toimipisteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vP_DatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vP_DatabaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.majoitusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toimipisteBindingSource
            // 
            this.toimipisteBindingSource.DataMember = "Toimipiste";
            this.toimipisteBindingSource.DataSource = this.vP_DatabaseDataSet1;
            // 
            // vP_DatabaseDataSet1
            // 
            this.vP_DatabaseDataSet1.DataSetName = "VP_DatabaseDataSet1";
            this.vP_DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vP_DatabaseDataSet3
            // 
            this.vP_DatabaseDataSet3.DataSetName = "VP_DatabaseDataSet3";
            this.vP_DatabaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // majoitusBindingSource
            // 
            this.majoitusBindingSource.DataMember = "Majoitus";
            this.majoitusBindingSource.DataSource = this.vP_DatabaseDataSet3;
            // 
            // toimipisteTableAdapter
            // 
            this.toimipisteTableAdapter.ClearBeforeFill = true;
            // 
            // txt_Cottage_Size
            // 
            this.txt_Cottage_Size.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Cottage_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Cottage_Size.Location = new System.Drawing.Point(182, 266);
            this.txt_Cottage_Size.Name = "txt_Cottage_Size";
            this.txt_Cottage_Size.Size = new System.Drawing.Size(95, 26);
            this.txt_Cottage_Size.TabIndex = 118;
            // 
            // lbl_Cottage_Office
            // 
            this.lbl_Cottage_Office.AutoSize = true;
            this.lbl_Cottage_Office.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cottage_Office.Location = new System.Drawing.Point(51, 105);
            this.lbl_Cottage_Office.Name = "lbl_Cottage_Office";
            this.lbl_Cottage_Office.Size = new System.Drawing.Size(95, 20);
            this.lbl_Cottage_Office.TabIndex = 124;
            this.lbl_Cottage_Office.Text = "Toimipiste:";
            // 
            // cbo_Cottage_Office_Select
            // 
            this.cbo_Cottage_Office_Select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_Cottage_Office_Select.DataSource = this.toimipisteBindingSource;
            this.cbo_Cottage_Office_Select.DisplayMember = "nimi";
            this.cbo_Cottage_Office_Select.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Cottage_Office_Select.FormattingEnabled = true;
            this.cbo_Cottage_Office_Select.Location = new System.Drawing.Point(182, 102);
            this.cbo_Cottage_Office_Select.Name = "cbo_Cottage_Office_Select";
            this.cbo_Cottage_Office_Select.Size = new System.Drawing.Size(285, 28);
            this.cbo_Cottage_Office_Select.TabIndex = 111;
            // 
            // rbu_Cottage_Wlan_No
            // 
            this.rbu_Cottage_Wlan_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbu_Cottage_Wlan_No.AutoSize = true;
            this.rbu_Cottage_Wlan_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbu_Cottage_Wlan_No.Location = new System.Drawing.Point(277, 309);
            this.rbu_Cottage_Wlan_No.Name = "rbu_Cottage_Wlan_No";
            this.rbu_Cottage_Wlan_No.Size = new System.Drawing.Size(41, 24);
            this.rbu_Cottage_Wlan_No.TabIndex = 121;
            this.rbu_Cottage_Wlan_No.Text = "Ei";
            this.rbu_Cottage_Wlan_No.UseVisualStyleBackColor = true;
            // 
            // rbu_Cottage_Wlan_Yes
            // 
            this.rbu_Cottage_Wlan_Yes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbu_Cottage_Wlan_Yes.AutoSize = true;
            this.rbu_Cottage_Wlan_Yes.Checked = true;
            this.rbu_Cottage_Wlan_Yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbu_Cottage_Wlan_Yes.Location = new System.Drawing.Point(182, 309);
            this.rbu_Cottage_Wlan_Yes.Name = "rbu_Cottage_Wlan_Yes";
            this.rbu_Cottage_Wlan_Yes.Size = new System.Drawing.Size(59, 24);
            this.rbu_Cottage_Wlan_Yes.TabIndex = 120;
            this.rbu_Cottage_Wlan_Yes.TabStop = true;
            this.rbu_Cottage_Wlan_Yes.Text = "Kyllä";
            this.rbu_Cottage_Wlan_Yes.UseVisualStyleBackColor = true;
            // 
            // lbl_Cottage_Wlan
            // 
            this.lbl_Cottage_Wlan.AutoSize = true;
            this.lbl_Cottage_Wlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cottage_Wlan.Location = new System.Drawing.Point(53, 309);
            this.lbl_Cottage_Wlan.Name = "lbl_Cottage_Wlan";
            this.lbl_Cottage_Wlan.Size = new System.Drawing.Size(54, 20);
            this.lbl_Cottage_Wlan.TabIndex = 123;
            this.lbl_Cottage_Wlan.Text = "Wlan:";
            // 
            // lbl_Cottage_Size
            // 
            this.lbl_Cottage_Size.AutoSize = true;
            this.lbl_Cottage_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cottage_Size.Location = new System.Drawing.Point(54, 266);
            this.lbl_Cottage_Size.Name = "lbl_Cottage_Size";
            this.lbl_Cottage_Size.Size = new System.Drawing.Size(54, 20);
            this.lbl_Cottage_Size.TabIndex = 122;
            this.lbl_Cottage_Size.Text = "Koko:";
            // 
            // txt_Cottage_Max_Visitors
            // 
            this.txt_Cottage_Max_Visitors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Cottage_Max_Visitors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Cottage_Max_Visitors.Location = new System.Drawing.Point(182, 224);
            this.txt_Cottage_Max_Visitors.Name = "txt_Cottage_Max_Visitors";
            this.txt_Cottage_Max_Visitors.Size = new System.Drawing.Size(95, 26);
            this.txt_Cottage_Max_Visitors.TabIndex = 117;
            // 
            // lbl_Cottage_Max_Visitors
            // 
            this.lbl_Cottage_Max_Visitors.AutoSize = true;
            this.lbl_Cottage_Max_Visitors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cottage_Max_Visitors.Location = new System.Drawing.Point(51, 227);
            this.lbl_Cottage_Max_Visitors.Name = "lbl_Cottage_Max_Visitors";
            this.lbl_Cottage_Max_Visitors.Size = new System.Drawing.Size(114, 20);
            this.lbl_Cottage_Max_Visitors.TabIndex = 119;
            this.lbl_Cottage_Max_Visitors.Text = "Max henkilöt:";
            // 
            // txt_Cottage_Price
            // 
            this.txt_Cottage_Price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Cottage_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Cottage_Price.Location = new System.Drawing.Point(182, 188);
            this.txt_Cottage_Price.Name = "txt_Cottage_Price";
            this.txt_Cottage_Price.Size = new System.Drawing.Size(95, 26);
            this.txt_Cottage_Price.TabIndex = 115;
            // 
            // lbl_Cottage_Price
            // 
            this.lbl_Cottage_Price.AutoSize = true;
            this.lbl_Cottage_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cottage_Price.Location = new System.Drawing.Point(51, 191);
            this.lbl_Cottage_Price.Name = "lbl_Cottage_Price";
            this.lbl_Cottage_Price.Size = new System.Drawing.Size(57, 20);
            this.lbl_Cottage_Price.TabIndex = 116;
            this.lbl_Cottage_Price.Text = "Hinta:";
            // 
            // txt_Cottage_Description
            // 
            this.txt_Cottage_Description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Cottage_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Cottage_Description.Location = new System.Drawing.Point(184, 352);
            this.txt_Cottage_Description.Multiline = true;
            this.txt_Cottage_Description.Name = "txt_Cottage_Description";
            this.txt_Cottage_Description.Size = new System.Drawing.Size(283, 79);
            this.txt_Cottage_Description.TabIndex = 122;
            // 
            // lbl_Cottage_Description
            // 
            this.lbl_Cottage_Description.AutoSize = true;
            this.lbl_Cottage_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cottage_Description.Location = new System.Drawing.Point(53, 352);
            this.lbl_Cottage_Description.Name = "lbl_Cottage_Description";
            this.lbl_Cottage_Description.Size = new System.Drawing.Size(72, 20);
            this.lbl_Cottage_Description.TabIndex = 112;
            this.lbl_Cottage_Description.Text = "Kuvaus:";
            // 
            // txt_Cottage_Name
            // 
            this.txt_Cottage_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Cottage_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Cottage_Name.Location = new System.Drawing.Point(182, 142);
            this.txt_Cottage_Name.Name = "txt_Cottage_Name";
            this.txt_Cottage_Name.Size = new System.Drawing.Size(285, 26);
            this.txt_Cottage_Name.TabIndex = 113;
            // 
            // lbl_Cottage_Name
            // 
            this.lbl_Cottage_Name.AutoSize = true;
            this.lbl_Cottage_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cottage_Name.Location = new System.Drawing.Point(51, 142);
            this.lbl_Cottage_Name.Name = "lbl_Cottage_Name";
            this.lbl_Cottage_Name.Size = new System.Drawing.Size(48, 20);
            this.lbl_Cottage_Name.TabIndex = 110;
            this.lbl_Cottage_Name.Text = "Nimi:";
            // 
            // btn_Cottage_Save
            // 
            this.btn_Cottage_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cottage_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cottage_Save.Location = new System.Drawing.Point(367, 454);
            this.btn_Cottage_Save.Name = "btn_Cottage_Save";
            this.btn_Cottage_Save.Size = new System.Drawing.Size(102, 30);
            this.btn_Cottage_Save.TabIndex = 126;
            this.btn_Cottage_Save.Text = "Tallenna";
            this.btn_Cottage_Save.UseVisualStyleBackColor = true;
            this.btn_Cottage_Save.Click += new System.EventHandler(this.btn_Cottage_Save_Click_1);
            // 
            // btn_Cottage_Cancel
            // 
            this.btn_Cottage_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cottage_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cottage_Cancel.Location = new System.Drawing.Point(182, 454);
            this.btn_Cottage_Cancel.Name = "btn_Cottage_Cancel";
            this.btn_Cottage_Cancel.Size = new System.Drawing.Size(95, 30);
            this.btn_Cottage_Cancel.TabIndex = 125;
            this.btn_Cottage_Cancel.Text = "Peruuta";
            this.btn_Cottage_Cancel.UseVisualStyleBackColor = true;
            // 
            // lbl_Cottage_Details
            // 
            this.lbl_Cottage_Details.AutoSize = true;
            this.lbl_Cottage_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_Cottage_Details.Location = new System.Drawing.Point(49, 51);
            this.lbl_Cottage_Details.Name = "lbl_Cottage_Details";
            this.lbl_Cottage_Details.Size = new System.Drawing.Size(123, 24);
            this.lbl_Cottage_Details.TabIndex = 127;
            this.lbl_Cottage_Details.Text = "Mökin tiedot";
            // 
            // lbl_Euros
            // 
            this.lbl_Euros.AutoSize = true;
            this.lbl_Euros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Euros.Location = new System.Drawing.Point(283, 191);
            this.lbl_Euros.Name = "lbl_Euros";
            this.lbl_Euros.Size = new System.Drawing.Size(18, 20);
            this.lbl_Euros.TabIndex = 128;
            this.lbl_Euros.Text = "€";
            // 
            // lbl_Square_Meters
            // 
            this.lbl_Square_Meters.AutoSize = true;
            this.lbl_Square_Meters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Square_Meters.Location = new System.Drawing.Point(283, 269);
            this.lbl_Square_Meters.Name = "lbl_Square_Meters";
            this.lbl_Square_Meters.Size = new System.Drawing.Size(27, 20);
            this.lbl_Square_Meters.TabIndex = 129;
            this.lbl_Square_Meters.Text = "m²";
            // 
            // frm_Cottage_Popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(569, 526);
            this.Controls.Add(this.lbl_Square_Meters);
            this.Controls.Add(this.lbl_Euros);
            this.Controls.Add(this.lbl_Cottage_Details);
            this.Controls.Add(this.btn_Cottage_Save);
            this.Controls.Add(this.btn_Cottage_Cancel);
            this.Controls.Add(this.txt_Cottage_Size);
            this.Controls.Add(this.lbl_Cottage_Office);
            this.Controls.Add(this.cbo_Cottage_Office_Select);
            this.Controls.Add(this.rbu_Cottage_Wlan_No);
            this.Controls.Add(this.rbu_Cottage_Wlan_Yes);
            this.Controls.Add(this.lbl_Cottage_Wlan);
            this.Controls.Add(this.lbl_Cottage_Size);
            this.Controls.Add(this.txt_Cottage_Max_Visitors);
            this.Controls.Add(this.lbl_Cottage_Max_Visitors);
            this.Controls.Add(this.txt_Cottage_Price);
            this.Controls.Add(this.lbl_Cottage_Price);
            this.Controls.Add(this.txt_Cottage_Description);
            this.Controls.Add(this.lbl_Cottage_Description);
            this.Controls.Add(this.txt_Cottage_Name);
            this.Controls.Add(this.lbl_Cottage_Name);
            this.Name = "frm_Cottage_Popup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mökin tiedot";
            this.Load += new System.EventHandler(this.frm_Cottage_Popup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toimipisteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vP_DatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vP_DatabaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.majoitusBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource majoitusBindingSource;
        private VP_DatabaseDataSet3 vP_DatabaseDataSet3;
        private VP_DatabaseDataSet1 vP_DatabaseDataSet1;
        private System.Windows.Forms.BindingSource toimipisteBindingSource;
        private VP_DatabaseDataSet1TableAdapters.ToimipisteTableAdapter toimipisteTableAdapter;
        public System.Windows.Forms.TextBox txt_Cottage_Size;
        private System.Windows.Forms.Label lbl_Cottage_Office;
        public System.Windows.Forms.ComboBox cbo_Cottage_Office_Select;
        public System.Windows.Forms.RadioButton rbu_Cottage_Wlan_No;
        public System.Windows.Forms.RadioButton rbu_Cottage_Wlan_Yes;
        private System.Windows.Forms.Label lbl_Cottage_Wlan;
        private System.Windows.Forms.Label lbl_Cottage_Size;
        public System.Windows.Forms.TextBox txt_Cottage_Max_Visitors;
        private System.Windows.Forms.Label lbl_Cottage_Max_Visitors;
        public System.Windows.Forms.TextBox txt_Cottage_Price;
        private System.Windows.Forms.Label lbl_Cottage_Price;
        public System.Windows.Forms.TextBox txt_Cottage_Description;
        private System.Windows.Forms.Label lbl_Cottage_Description;
        public System.Windows.Forms.TextBox txt_Cottage_Name;
        private System.Windows.Forms.Label lbl_Cottage_Name;
        private System.Windows.Forms.Button btn_Cottage_Save;
        private System.Windows.Forms.Button btn_Cottage_Cancel;
        private System.Windows.Forms.Label lbl_Cottage_Details;
        private System.Windows.Forms.Label lbl_Euros;
        private System.Windows.Forms.Label lbl_Square_Meters;
    }
}