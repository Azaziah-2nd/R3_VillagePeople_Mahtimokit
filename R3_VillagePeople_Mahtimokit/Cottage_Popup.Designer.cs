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
            this.grb_Cottage_Details = new System.Windows.Forms.GroupBox();
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
            this.grb_Cottage_Save_Cancel_Buttons = new System.Windows.Forms.GroupBox();
            this.btn_Cottage_Save = new System.Windows.Forms.Button();
            this.btn_Cottage_Cancel = new System.Windows.Forms.Button();
            this.vP_DatabaseDataSet3 = new R3_VillagePeople_Mahtimokit.VP_DatabaseDataSet3();
            this.majoitusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vP_DatabaseDataSet1 = new R3_VillagePeople_Mahtimokit.VP_DatabaseDataSet1();
            this.toimipisteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toimipisteTableAdapter = new R3_VillagePeople_Mahtimokit.VP_DatabaseDataSet1TableAdapters.ToimipisteTableAdapter();
            this.txt_Cottage_Size = new System.Windows.Forms.TextBox();
            this.grb_Cottage_Details.SuspendLayout();
            this.grb_Cottage_Save_Cancel_Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vP_DatabaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.majoitusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vP_DatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimipisteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_Cottage_Details
            // 
            this.grb_Cottage_Details.Controls.Add(this.txt_Cottage_Size);
            this.grb_Cottage_Details.Controls.Add(this.lbl_Cottage_Office);
            this.grb_Cottage_Details.Controls.Add(this.cbo_Cottage_Office_Select);
            this.grb_Cottage_Details.Controls.Add(this.rbu_Cottage_Wlan_No);
            this.grb_Cottage_Details.Controls.Add(this.rbu_Cottage_Wlan_Yes);
            this.grb_Cottage_Details.Controls.Add(this.lbl_Cottage_Wlan);
            this.grb_Cottage_Details.Controls.Add(this.lbl_Cottage_Size);
            this.grb_Cottage_Details.Controls.Add(this.txt_Cottage_Max_Visitors);
            this.grb_Cottage_Details.Controls.Add(this.lbl_Cottage_Max_Visitors);
            this.grb_Cottage_Details.Controls.Add(this.txt_Cottage_Price);
            this.grb_Cottage_Details.Controls.Add(this.lbl_Cottage_Price);
            this.grb_Cottage_Details.Controls.Add(this.txt_Cottage_Description);
            this.grb_Cottage_Details.Controls.Add(this.lbl_Cottage_Description);
            this.grb_Cottage_Details.Controls.Add(this.txt_Cottage_Name);
            this.grb_Cottage_Details.Controls.Add(this.lbl_Cottage_Name);
            this.grb_Cottage_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_Cottage_Details.Location = new System.Drawing.Point(12, 12);
            this.grb_Cottage_Details.Name = "grb_Cottage_Details";
            this.grb_Cottage_Details.Size = new System.Drawing.Size(533, 338);
            this.grb_Cottage_Details.TabIndex = 0;
            this.grb_Cottage_Details.TabStop = false;
            this.grb_Cottage_Details.Text = "Mökin tiedot";
            // 
            // lbl_Cottage_Office
            // 
            this.lbl_Cottage_Office.AutoSize = true;
            this.lbl_Cottage_Office.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cottage_Office.Location = new System.Drawing.Point(6, 51);
            this.lbl_Cottage_Office.Name = "lbl_Cottage_Office";
            this.lbl_Cottage_Office.Size = new System.Drawing.Size(84, 20);
            this.lbl_Cottage_Office.TabIndex = 109;
            this.lbl_Cottage_Office.Text = "Toimipiste:";
            // 
            // cbo_Cottage_Office_Select
            // 
            this.cbo_Cottage_Office_Select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_Cottage_Office_Select.DataSource = this.toimipisteBindingSource;
            this.cbo_Cottage_Office_Select.DisplayMember = "nimi";
            this.cbo_Cottage_Office_Select.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Cottage_Office_Select.FormattingEnabled = true;
            this.cbo_Cottage_Office_Select.Location = new System.Drawing.Point(240, 48);
            this.cbo_Cottage_Office_Select.Name = "cbo_Cottage_Office_Select";
            this.cbo_Cottage_Office_Select.Size = new System.Drawing.Size(287, 28);
            this.cbo_Cottage_Office_Select.TabIndex = 108;
            // 
            // rbu_Cottage_Wlan_No
            // 
            this.rbu_Cottage_Wlan_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbu_Cottage_Wlan_No.AutoSize = true;
            this.rbu_Cottage_Wlan_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbu_Cottage_Wlan_No.Location = new System.Drawing.Point(346, 307);
            this.rbu_Cottage_Wlan_No.Name = "rbu_Cottage_Wlan_No";
            this.rbu_Cottage_Wlan_No.Size = new System.Drawing.Size(36, 19);
            this.rbu_Cottage_Wlan_No.TabIndex = 98;
            this.rbu_Cottage_Wlan_No.Text = "Ei";
            this.rbu_Cottage_Wlan_No.UseVisualStyleBackColor = true;
            // 
            // rbu_Cottage_Wlan_Yes
            // 
            this.rbu_Cottage_Wlan_Yes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbu_Cottage_Wlan_Yes.AutoSize = true;
            this.rbu_Cottage_Wlan_Yes.Checked = true;
            this.rbu_Cottage_Wlan_Yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbu_Cottage_Wlan_Yes.Location = new System.Drawing.Point(240, 304);
            this.rbu_Cottage_Wlan_Yes.Name = "rbu_Cottage_Wlan_Yes";
            this.rbu_Cottage_Wlan_Yes.Size = new System.Drawing.Size(51, 19);
            this.rbu_Cottage_Wlan_Yes.TabIndex = 97;
            this.rbu_Cottage_Wlan_Yes.TabStop = true;
            this.rbu_Cottage_Wlan_Yes.Text = "Kyllä";
            this.rbu_Cottage_Wlan_Yes.UseVisualStyleBackColor = true;
            // 
            // lbl_Cottage_Wlan
            // 
            this.lbl_Cottage_Wlan.AutoSize = true;
            this.lbl_Cottage_Wlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cottage_Wlan.Location = new System.Drawing.Point(6, 304);
            this.lbl_Cottage_Wlan.Name = "lbl_Cottage_Wlan";
            this.lbl_Cottage_Wlan.Size = new System.Drawing.Size(49, 20);
            this.lbl_Cottage_Wlan.TabIndex = 89;
            this.lbl_Cottage_Wlan.Text = "Wlan:";
            // 
            // lbl_Cottage_Size
            // 
            this.lbl_Cottage_Size.AutoSize = true;
            this.lbl_Cottage_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cottage_Size.Location = new System.Drawing.Point(6, 278);
            this.lbl_Cottage_Size.Name = "lbl_Cottage_Size";
            this.lbl_Cottage_Size.Size = new System.Drawing.Size(49, 20);
            this.lbl_Cottage_Size.TabIndex = 88;
            this.lbl_Cottage_Size.Text = "Koko:";
            // 
            // txt_Cottage_Max_Visitors
            // 
            this.txt_Cottage_Max_Visitors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Cottage_Max_Visitors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cottage_Max_Visitors.Location = new System.Drawing.Point(240, 252);
            this.txt_Cottage_Max_Visitors.Name = "txt_Cottage_Max_Visitors";
            this.txt_Cottage_Max_Visitors.Size = new System.Drawing.Size(287, 21);
            this.txt_Cottage_Max_Visitors.TabIndex = 87;
            // 
            // lbl_Cottage_Max_Visitors
            // 
            this.lbl_Cottage_Max_Visitors.AutoSize = true;
            this.lbl_Cottage_Max_Visitors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cottage_Max_Visitors.Location = new System.Drawing.Point(6, 252);
            this.lbl_Cottage_Max_Visitors.Name = "lbl_Cottage_Max_Visitors";
            this.lbl_Cottage_Max_Visitors.Size = new System.Drawing.Size(101, 20);
            this.lbl_Cottage_Max_Visitors.TabIndex = 86;
            this.lbl_Cottage_Max_Visitors.Text = "Max henkilöt:";
            // 
            // txt_Cottage_Price
            // 
            this.txt_Cottage_Price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Cottage_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cottage_Price.Location = new System.Drawing.Point(240, 226);
            this.txt_Cottage_Price.Name = "txt_Cottage_Price";
            this.txt_Cottage_Price.Size = new System.Drawing.Size(287, 21);
            this.txt_Cottage_Price.TabIndex = 85;
            // 
            // lbl_Cottage_Price
            // 
            this.lbl_Cottage_Price.AutoSize = true;
            this.lbl_Cottage_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cottage_Price.Location = new System.Drawing.Point(6, 226);
            this.lbl_Cottage_Price.Name = "lbl_Cottage_Price";
            this.lbl_Cottage_Price.Size = new System.Drawing.Size(51, 20);
            this.lbl_Cottage_Price.TabIndex = 84;
            this.lbl_Cottage_Price.Text = "Hinta:";
            // 
            // txt_Cottage_Description
            // 
            this.txt_Cottage_Description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Cottage_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cottage_Description.Location = new System.Drawing.Point(240, 123);
            this.txt_Cottage_Description.Multiline = true;
            this.txt_Cottage_Description.Name = "txt_Cottage_Description";
            this.txt_Cottage_Description.Size = new System.Drawing.Size(287, 97);
            this.txt_Cottage_Description.TabIndex = 83;
            // 
            // lbl_Cottage_Description
            // 
            this.lbl_Cottage_Description.AutoSize = true;
            this.lbl_Cottage_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cottage_Description.Location = new System.Drawing.Point(6, 123);
            this.lbl_Cottage_Description.Name = "lbl_Cottage_Description";
            this.lbl_Cottage_Description.Size = new System.Drawing.Size(65, 20);
            this.lbl_Cottage_Description.TabIndex = 82;
            this.lbl_Cottage_Description.Text = "Kuvaus:";
            // 
            // txt_Cottage_Name
            // 
            this.txt_Cottage_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Cottage_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cottage_Name.Location = new System.Drawing.Point(240, 97);
            this.txt_Cottage_Name.Name = "txt_Cottage_Name";
            this.txt_Cottage_Name.Size = new System.Drawing.Size(287, 21);
            this.txt_Cottage_Name.TabIndex = 81;
            // 
            // lbl_Cottage_Name
            // 
            this.lbl_Cottage_Name.AutoSize = true;
            this.lbl_Cottage_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cottage_Name.Location = new System.Drawing.Point(6, 97);
            this.lbl_Cottage_Name.Name = "lbl_Cottage_Name";
            this.lbl_Cottage_Name.Size = new System.Drawing.Size(43, 20);
            this.lbl_Cottage_Name.TabIndex = 80;
            this.lbl_Cottage_Name.Text = "Nimi:";
            // 
            // grb_Cottage_Save_Cancel_Buttons
            // 
            this.grb_Cottage_Save_Cancel_Buttons.Controls.Add(this.btn_Cottage_Save);
            this.grb_Cottage_Save_Cancel_Buttons.Controls.Add(this.btn_Cottage_Cancel);
            this.grb_Cottage_Save_Cancel_Buttons.Location = new System.Drawing.Point(12, 356);
            this.grb_Cottage_Save_Cancel_Buttons.Name = "grb_Cottage_Save_Cancel_Buttons";
            this.grb_Cottage_Save_Cancel_Buttons.Size = new System.Drawing.Size(533, 66);
            this.grb_Cottage_Save_Cancel_Buttons.TabIndex = 99;
            this.grb_Cottage_Save_Cancel_Buttons.TabStop = false;
            // 
            // btn_Cottage_Save
            // 
            this.btn_Cottage_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cottage_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cottage_Save.Location = new System.Drawing.Point(442, 19);
            this.btn_Cottage_Save.Name = "btn_Cottage_Save";
            this.btn_Cottage_Save.Size = new System.Drawing.Size(85, 30);
            this.btn_Cottage_Save.TabIndex = 90;
            this.btn_Cottage_Save.Text = "Tallenna";
            this.btn_Cottage_Save.UseVisualStyleBackColor = true;
            this.btn_Cottage_Save.Click += new System.EventHandler(this.btn_Cottage_Save_Click);
            // 
            // btn_Cottage_Cancel
            // 
            this.btn_Cottage_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cottage_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cottage_Cancel.Location = new System.Drawing.Point(351, 19);
            this.btn_Cottage_Cancel.Name = "btn_Cottage_Cancel";
            this.btn_Cottage_Cancel.Size = new System.Drawing.Size(85, 30);
            this.btn_Cottage_Cancel.TabIndex = 91;
            this.btn_Cottage_Cancel.Text = "Peruuta";
            this.btn_Cottage_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cottage_Cancel.Click += new System.EventHandler(this.btn_Cottage_Cancel_Click_1);
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
            // vP_DatabaseDataSet1
            // 
            this.vP_DatabaseDataSet1.DataSetName = "VP_DatabaseDataSet1";
            this.vP_DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toimipisteBindingSource
            // 
            this.toimipisteBindingSource.DataMember = "Toimipiste";
            this.toimipisteBindingSource.DataSource = this.vP_DatabaseDataSet1;
            // 
            // toimipisteTableAdapter
            // 
            this.toimipisteTableAdapter.ClearBeforeFill = true;
            // 
            // txt_Cottage_Size
            // 
            this.txt_Cottage_Size.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Cottage_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cottage_Size.Location = new System.Drawing.Point(240, 277);
            this.txt_Cottage_Size.Name = "txt_Cottage_Size";
            this.txt_Cottage_Size.Size = new System.Drawing.Size(287, 21);
            this.txt_Cottage_Size.TabIndex = 110;
            // 
            // frm_Cottage_Popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 438);
            this.Controls.Add(this.grb_Cottage_Save_Cancel_Buttons);
            this.Controls.Add(this.grb_Cottage_Details);
            this.Name = "frm_Cottage_Popup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mökkien tietojen hallinta";
            this.Load += new System.EventHandler(this.frm_Cottage_Popup_Load);
            this.grb_Cottage_Details.ResumeLayout(false);
            this.grb_Cottage_Details.PerformLayout();
            this.grb_Cottage_Save_Cancel_Buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vP_DatabaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.majoitusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vP_DatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimipisteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_Cottage_Details;
        private System.Windows.Forms.Label lbl_Cottage_Wlan;
        private System.Windows.Forms.Label lbl_Cottage_Size;
        private System.Windows.Forms.Label lbl_Cottage_Max_Visitors;
        private System.Windows.Forms.Label lbl_Cottage_Price;
        private System.Windows.Forms.Label lbl_Cottage_Description;
        private System.Windows.Forms.Label lbl_Cottage_Name;
        private System.Windows.Forms.GroupBox grb_Cottage_Save_Cancel_Buttons;
        private System.Windows.Forms.Button btn_Cottage_Save;
        private System.Windows.Forms.Button btn_Cottage_Cancel;
        private System.Windows.Forms.Label lbl_Cottage_Office;
        public System.Windows.Forms.ComboBox cbo_Cottage_Office_Select;
        private System.Windows.Forms.BindingSource majoitusBindingSource;
        private VP_DatabaseDataSet3 vP_DatabaseDataSet3;
        private VP_DatabaseDataSet1 vP_DatabaseDataSet1;
        private System.Windows.Forms.BindingSource toimipisteBindingSource;
        private VP_DatabaseDataSet1TableAdapters.ToimipisteTableAdapter toimipisteTableAdapter;
        public System.Windows.Forms.RadioButton rbu_Cottage_Wlan_No;
        public System.Windows.Forms.RadioButton rbu_Cottage_Wlan_Yes;
        public System.Windows.Forms.TextBox txt_Cottage_Max_Visitors;
        public System.Windows.Forms.TextBox txt_Cottage_Price;
        public System.Windows.Forms.TextBox txt_Cottage_Description;
        public System.Windows.Forms.TextBox txt_Cottage_Name;
        public System.Windows.Forms.TextBox txt_Cottage_Size;
    }
}