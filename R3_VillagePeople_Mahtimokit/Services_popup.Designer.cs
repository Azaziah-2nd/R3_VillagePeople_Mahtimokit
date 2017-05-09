namespace R3_VillagePeople_Mahtimokit
{
    partial class frm_Services_Popup
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
            this.btn_Service_Save = new System.Windows.Forms.Button();
            this.btn_Service_Cancel = new System.Windows.Forms.Button();
            this.grb_Service_Details = new System.Windows.Forms.GroupBox();
            this.lbl_Service_Office = new System.Windows.Forms.Label();
            this.cbo_Service_Office_Select = new System.Windows.Forms.ComboBox();
            this.toimipisteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vP_DatabaseDataSet1 = new R3_VillagePeople_Mahtimokit.VP_DatabaseDataSet1();
            this.txt_Service_alv = new System.Windows.Forms.TextBox();
            this.lbl_Service_alv = new System.Windows.Forms.Label();
            this.txt_Service_Max_Visitors = new System.Windows.Forms.TextBox();
            this.lbl_Service_Max_Visitors = new System.Windows.Forms.Label();
            this.txt_Service_Price = new System.Windows.Forms.TextBox();
            this.lbl_Service_Price = new System.Windows.Forms.Label();
            this.txt_Service_Description = new System.Windows.Forms.TextBox();
            this.lbl_Service_Description = new System.Windows.Forms.Label();
            this.txt_Service_Name = new System.Windows.Forms.TextBox();
            this.lbl_Service_Name = new System.Windows.Forms.Label();
            this.grb_Service_Cancel_Save_Buttons = new System.Windows.Forms.GroupBox();
            this.toimipisteTableAdapter = new R3_VillagePeople_Mahtimokit.VP_DatabaseDataSet1TableAdapters.ToimipisteTableAdapter();
            this.majoitusTableAdapter = new R3_VillagePeople_Mahtimokit.VP_DatabaseDataSet3TableAdapters.MajoitusTableAdapter();
            this.grb_Service_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toimipisteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vP_DatabaseDataSet1)).BeginInit();
            this.grb_Service_Cancel_Save_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Service_Save
            // 
            this.btn_Service_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Service_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Service_Save.Location = new System.Drawing.Point(442, 19);
            this.btn_Service_Save.Name = "btn_Service_Save";
            this.btn_Service_Save.Size = new System.Drawing.Size(85, 30);
            this.btn_Service_Save.TabIndex = 90;
            this.btn_Service_Save.Text = "Tallenna";
            this.btn_Service_Save.UseVisualStyleBackColor = true;
            this.btn_Service_Save.Click += new System.EventHandler(this.btn_Service_Save_Click);
            // 
            // btn_Service_Cancel
            // 
            this.btn_Service_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Service_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Service_Cancel.Location = new System.Drawing.Point(351, 19);
            this.btn_Service_Cancel.Name = "btn_Service_Cancel";
            this.btn_Service_Cancel.Size = new System.Drawing.Size(85, 30);
            this.btn_Service_Cancel.TabIndex = 91;
            this.btn_Service_Cancel.Text = "Peruuta";
            this.btn_Service_Cancel.UseVisualStyleBackColor = true;
            this.btn_Service_Cancel.Click += new System.EventHandler(this.btn_Service_Cancel_Click_1);
            // 
            // grb_Service_Details
            // 
            this.grb_Service_Details.Controls.Add(this.lbl_Service_Office);
            this.grb_Service_Details.Controls.Add(this.cbo_Service_Office_Select);
            this.grb_Service_Details.Controls.Add(this.txt_Service_alv);
            this.grb_Service_Details.Controls.Add(this.lbl_Service_alv);
            this.grb_Service_Details.Controls.Add(this.txt_Service_Max_Visitors);
            this.grb_Service_Details.Controls.Add(this.lbl_Service_Max_Visitors);
            this.grb_Service_Details.Controls.Add(this.txt_Service_Price);
            this.grb_Service_Details.Controls.Add(this.lbl_Service_Price);
            this.grb_Service_Details.Controls.Add(this.txt_Service_Description);
            this.grb_Service_Details.Controls.Add(this.lbl_Service_Description);
            this.grb_Service_Details.Controls.Add(this.txt_Service_Name);
            this.grb_Service_Details.Controls.Add(this.lbl_Service_Name);
            this.grb_Service_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_Service_Details.Location = new System.Drawing.Point(13, 13);
            this.grb_Service_Details.Name = "grb_Service_Details";
            this.grb_Service_Details.Size = new System.Drawing.Size(533, 272);
            this.grb_Service_Details.TabIndex = 92;
            this.grb_Service_Details.TabStop = false;
            this.grb_Service_Details.Text = "Palvelun tiedot";
            // 
            // lbl_Service_Office
            // 
            this.lbl_Service_Office.AutoSize = true;
            this.lbl_Service_Office.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Service_Office.Location = new System.Drawing.Point(6, 28);
            this.lbl_Service_Office.Name = "lbl_Service_Office";
            this.lbl_Service_Office.Size = new System.Drawing.Size(84, 20);
            this.lbl_Service_Office.TabIndex = 107;
            this.lbl_Service_Office.Text = "Toimipiste:";
            // 
            // cbo_Service_Office_Select
            // 
            this.cbo_Service_Office_Select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_Service_Office_Select.DataSource = this.toimipisteBindingSource;
            this.cbo_Service_Office_Select.DisplayMember = "nimi";
            this.cbo_Service_Office_Select.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Service_Office_Select.FormattingEnabled = true;
            this.cbo_Service_Office_Select.Location = new System.Drawing.Point(240, 25);
            this.cbo_Service_Office_Select.Name = "cbo_Service_Office_Select";
            this.cbo_Service_Office_Select.Size = new System.Drawing.Size(287, 28);
            this.cbo_Service_Office_Select.TabIndex = 106;
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
            // txt_Service_alv
            // 
            this.txt_Service_alv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Service_alv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Service_alv.Location = new System.Drawing.Point(240, 244);
            this.txt_Service_alv.Name = "txt_Service_alv";
            this.txt_Service_alv.Size = new System.Drawing.Size(287, 21);
            this.txt_Service_alv.TabIndex = 103;
            // 
            // lbl_Service_alv
            // 
            this.lbl_Service_alv.AutoSize = true;
            this.lbl_Service_alv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Service_alv.Location = new System.Drawing.Point(6, 244);
            this.lbl_Service_alv.Name = "lbl_Service_alv";
            this.lbl_Service_alv.Size = new System.Drawing.Size(110, 20);
            this.lbl_Service_alv.TabIndex = 102;
            this.lbl_Service_alv.Text = "ALV prosentti:";
            // 
            // txt_Service_Max_Visitors
            // 
            this.txt_Service_Max_Visitors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Service_Max_Visitors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Service_Max_Visitors.Location = new System.Drawing.Point(240, 218);
            this.txt_Service_Max_Visitors.Name = "txt_Service_Max_Visitors";
            this.txt_Service_Max_Visitors.Size = new System.Drawing.Size(287, 21);
            this.txt_Service_Max_Visitors.TabIndex = 99;
            // 
            // lbl_Service_Max_Visitors
            // 
            this.lbl_Service_Max_Visitors.AutoSize = true;
            this.lbl_Service_Max_Visitors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Service_Max_Visitors.Location = new System.Drawing.Point(6, 218);
            this.lbl_Service_Max_Visitors.Name = "lbl_Service_Max_Visitors";
            this.lbl_Service_Max_Visitors.Size = new System.Drawing.Size(101, 20);
            this.lbl_Service_Max_Visitors.TabIndex = 98;
            this.lbl_Service_Max_Visitors.Text = "Max henkilöt:";
            // 
            // txt_Service_Price
            // 
            this.txt_Service_Price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Service_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Service_Price.Location = new System.Drawing.Point(240, 192);
            this.txt_Service_Price.Name = "txt_Service_Price";
            this.txt_Service_Price.Size = new System.Drawing.Size(100, 21);
            this.txt_Service_Price.TabIndex = 97;
            // 
            // lbl_Service_Price
            // 
            this.lbl_Service_Price.AutoSize = true;
            this.lbl_Service_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Service_Price.Location = new System.Drawing.Point(6, 192);
            this.lbl_Service_Price.Name = "lbl_Service_Price";
            this.lbl_Service_Price.Size = new System.Drawing.Size(51, 20);
            this.lbl_Service_Price.TabIndex = 96;
            this.lbl_Service_Price.Text = "Hinta:";
            // 
            // txt_Service_Description
            // 
            this.txt_Service_Description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Service_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Service_Description.Location = new System.Drawing.Point(240, 89);
            this.txt_Service_Description.Multiline = true;
            this.txt_Service_Description.Name = "txt_Service_Description";
            this.txt_Service_Description.Size = new System.Drawing.Size(287, 97);
            this.txt_Service_Description.TabIndex = 95;
            // 
            // lbl_Service_Description
            // 
            this.lbl_Service_Description.AutoSize = true;
            this.lbl_Service_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Service_Description.Location = new System.Drawing.Point(6, 89);
            this.lbl_Service_Description.Name = "lbl_Service_Description";
            this.lbl_Service_Description.Size = new System.Drawing.Size(65, 20);
            this.lbl_Service_Description.TabIndex = 94;
            this.lbl_Service_Description.Text = "Kuvaus:";
            // 
            // txt_Service_Name
            // 
            this.txt_Service_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Service_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Service_Name.Location = new System.Drawing.Point(240, 63);
            this.txt_Service_Name.Name = "txt_Service_Name";
            this.txt_Service_Name.Size = new System.Drawing.Size(287, 21);
            this.txt_Service_Name.TabIndex = 93;
            // 
            // lbl_Service_Name
            // 
            this.lbl_Service_Name.AutoSize = true;
            this.lbl_Service_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Service_Name.Location = new System.Drawing.Point(6, 63);
            this.lbl_Service_Name.Name = "lbl_Service_Name";
            this.lbl_Service_Name.Size = new System.Drawing.Size(43, 20);
            this.lbl_Service_Name.TabIndex = 92;
            this.lbl_Service_Name.Text = "Nimi:";
            // 
            // grb_Service_Cancel_Save_Buttons
            // 
            this.grb_Service_Cancel_Save_Buttons.Controls.Add(this.btn_Service_Save);
            this.grb_Service_Cancel_Save_Buttons.Controls.Add(this.btn_Service_Cancel);
            this.grb_Service_Cancel_Save_Buttons.Location = new System.Drawing.Point(13, 292);
            this.grb_Service_Cancel_Save_Buttons.Name = "grb_Service_Cancel_Save_Buttons";
            this.grb_Service_Cancel_Save_Buttons.Size = new System.Drawing.Size(533, 66);
            this.grb_Service_Cancel_Save_Buttons.TabIndex = 93;
            this.grb_Service_Cancel_Save_Buttons.TabStop = false;
            // 
            // toimipisteTableAdapter
            // 
            this.toimipisteTableAdapter.ClearBeforeFill = true;
            // 
            // majoitusTableAdapter
            // 
            this.majoitusTableAdapter.ClearBeforeFill = true;
            // 
            // frm_Services_Popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(559, 372);
            this.Controls.Add(this.grb_Service_Cancel_Save_Buttons);
            this.Controls.Add(this.grb_Service_Details);
            this.Name = "frm_Services_Popup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Palvelun tietojen hallinta";
            this.Load += new System.EventHandler(this.Services_popup_Load);
            this.grb_Service_Details.ResumeLayout(false);
            this.grb_Service_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toimipisteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vP_DatabaseDataSet1)).EndInit();
            this.grb_Service_Cancel_Save_Buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Service_Save;
        private System.Windows.Forms.Button btn_Service_Cancel;
        private System.Windows.Forms.GroupBox grb_Service_Details;
        private System.Windows.Forms.Label lbl_Service_alv;
        private System.Windows.Forms.Label lbl_Service_Max_Visitors;
        private System.Windows.Forms.Label lbl_Service_Price;
        private System.Windows.Forms.Label lbl_Service_Description;
        private System.Windows.Forms.Label lbl_Service_Name;
        private System.Windows.Forms.GroupBox grb_Service_Cancel_Save_Buttons;
        private System.Windows.Forms.Label lbl_Service_Office;
        public System.Windows.Forms.TextBox txt_Service_alv;
        public System.Windows.Forms.ComboBox cbo_Service_Office_Select;
        public System.Windows.Forms.TextBox txt_Service_Max_Visitors;
        public System.Windows.Forms.TextBox txt_Service_Price;
        public System.Windows.Forms.TextBox txt_Service_Description;
        public System.Windows.Forms.TextBox txt_Service_Name;
        private VP_DatabaseDataSet1 vP_DatabaseDataSet1;
        private System.Windows.Forms.BindingSource toimipisteBindingSource;
        private VP_DatabaseDataSet1TableAdapters.ToimipisteTableAdapter toimipisteTableAdapter;
        private VP_DatabaseDataSet3TableAdapters.MajoitusTableAdapter majoitusTableAdapter;
    }
}