namespace R3_VillagePeople_Mahtimokit
{
    partial class frm_Main_Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main_Window));
            this.tab_Menu = new System.Windows.Forms.TabControl();
            this.tab_New_Order = new System.Windows.Forms.TabPage();
            this.tbl_Order_base = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_Order_1st_Col_Dates_Customers = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_Order_Customers = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_Order_1st_Col_Dates = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_Order_Date_Selection = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lbl_Order_Dates = new System.Windows.Forms.Label();
            this.tbl_Order_1st_Col_Customer = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_Order_Customer_Search = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Order_Customers_Search = new System.Windows.Forms.Button();
            this.txt_Order_Customers_Search = new System.Windows.Forms.TextBox();
            this.lbl_Order_Customers = new System.Windows.Forms.Label();
            this.btn_Order_Customers_Add = new System.Windows.Forms.Button();
            this.dgv_Order_Customers_All = new System.Windows.Forms.DataGridView();
            this.kokonimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asiakasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vP_DatabaseDataSet = new R3_VillagePeople_Mahtimokit.VP_DatabaseDataSet();
            this.tbl_Order_2nd_Col_Offices_Cottage = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Order_Cottage_Selection = new System.Windows.Forms.Label();
            this.dgv_Order_Cottages_All = new System.Windows.Forms.DataGridView();
            this.nimiDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majoitusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vP_DatabaseDataSet3 = new R3_VillagePeople_Mahtimokit.VP_DatabaseDataSet3();
            this.Btn_Order_Cottage_Add = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Order_Cottages_Search = new System.Windows.Forms.Button();
            this.txt_Order_Cottages_Search = new System.Windows.Forms.TextBox();
            this.lbl_Order_Cottage = new System.Windows.Forms.Label();
            this.lbl_Order_Office = new System.Windows.Forms.Label();
            this.cbo_Order_Office_Select = new System.Windows.Forms.ComboBox();
            this.toimipisteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vP_DatabaseDataSet1 = new R3_VillagePeople_Mahtimokit.VP_DatabaseDataSet1();
            this.tbl_Order_3rd_Col_Cottage_Summary_Services = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_Order_3rd_Col_Services = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Order_Services = new System.Windows.Forms.Label();
            this.tbl_Order_3rd_Col_Services_Quantity = new System.Windows.Forms.TableLayoutPanel();
            this.txt_Order_Services_Search = new System.Windows.Forms.TextBox();
            this.btn_Order_Services_Search = new System.Windows.Forms.Button();
            this.lbl_Order_Services_Quantity_Units = new System.Windows.Forms.Label();
            this.txt_Order_Services_Quantity = new System.Windows.Forms.TextBox();
            this.dgv_Order_Services_All = new System.Windows.Forms.DataGridView();
            this.nimiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.palveluBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vP_DatabaseDataSet2 = new R3_VillagePeople_Mahtimokit.VP_DatabaseDataSet2();
            this.btn_Order_Service_add = new System.Windows.Forms.Button();
            this.tbl_4th_Col_Summary = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_Order_Summary_Dates_Office = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Order_Summary = new System.Windows.Forms.Label();
            this.lbl_Order_Summary_Office = new System.Windows.Forms.Label();
            this.lbl_Order_Summary_Start_Date = new System.Windows.Forms.Label();
            this.lbl_Order_Summary_End_Date = new System.Windows.Forms.Label();
            this.lbl_Order_Additional_Details = new System.Windows.Forms.Label();
            this.tbl_Order_Summary_Customers_Cottages_Services = new System.Windows.Forms.TableLayoutPanel();
            this.lsv_Order_Summary_Customers = new System.Windows.Forms.ListView();
            this.lbl_Order_Summary_Customers = new System.Windows.Forms.Label();
            this.lbl_Order_Summary_Cottages = new System.Windows.Forms.Label();
            this.lsv_Order_Summary_Cottages = new System.Windows.Forms.ListView();
            this.lsv_Order_Summary_Services = new System.Windows.Forms.ListView();
            this.lbl_Order_Summary_Services = new System.Windows.Forms.Label();
            this.tbl_Order_Summary_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Order_Summary_Next_Page = new System.Windows.Forms.Button();
            this.btn_Order_Summary_Delete_From_List = new System.Windows.Forms.Button();
            this.txt_Order_Additional_Details = new System.Windows.Forms.TextBox();
            this.tab_Edit = new System.Windows.Forms.TabPage();
            this.tbl_Edit_base = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_Edit_1st_Col_Customers = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Customer_Management = new System.Windows.Forms.Label();
            this.tbl_Edit_1st_Col_Customers_Search = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Customer_Search = new System.Windows.Forms.Button();
            this.txt_Customer_Search = new System.Windows.Forms.TextBox();
            this.tbl_Edit_1st_Col_Customers_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Customer_Delete = new System.Windows.Forms.Button();
            this.btn_Customer_Edit = new System.Windows.Forms.Button();
            this.btn_Customer_Add = new System.Windows.Forms.Button();
            this.dgv_Customers_All = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asiakasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vPDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Edit_2nd_Col_Offices_Services = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_Edit_2nd_Col_Offices = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Office = new System.Windows.Forms.Label();
            this.cbo_Office_Select = new System.Windows.Forms.ComboBox();
            this.tbl_Edit_2nd_Col_Offices_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Office_Delete = new System.Windows.Forms.Button();
            this.btn_Office_Edit = new System.Windows.Forms.Button();
            this.btn_Office_Add = new System.Windows.Forms.Button();
            this.tbl_Edit_2nd_Col_Services = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Services = new System.Windows.Forms.Label();
            this.tbl_Edit_2nd_Col_Services_Search = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Services_Search = new System.Windows.Forms.Button();
            this.txt_Services_Search = new System.Windows.Forms.TextBox();
            this.tbl_Edit_2nd_Col_Services_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Services_Delete = new System.Windows.Forms.Button();
            this.btn_Services_Edit = new System.Windows.Forms.Button();
            this.btn_Services_Add = new System.Windows.Forms.Button();
            this.dgv_Services_All = new System.Windows.Forms.DataGridView();
            this.nimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbl_Edit_3rd_Col_Cottages = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Cottages = new System.Windows.Forms.Label();
            this.tbl_Edit_3rd_Col_Cottages_Search = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Cottages_Search = new System.Windows.Forms.Button();
            this.txt_Cottages_Search = new System.Windows.Forms.TextBox();
            this.tbl_Edit_3rd_Col_Cottages_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Cottages_Delete = new System.Windows.Forms.Button();
            this.btn_Cottages_Edit = new System.Windows.Forms.Button();
            this.btn_Cottages_Add = new System.Windows.Forms.Button();
            this.dgv_Cottages_all = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_History = new System.Windows.Forms.TabPage();
            this.tbl_History_Base = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_History_1st_Col_Customers_Offices = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_History_Customer_Selection = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_History_Customer_Search = new System.Windows.Forms.Button();
            this.txt_History_Customer_Search = new System.Windows.Forms.TextBox();
            this.btn_History_Limit_To_Customer = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_History_Limit_To_Office = new System.Windows.Forms.Button();
            this.lbl_History_Office = new System.Windows.Forms.Label();
            this.cbo_History_Office_Select = new System.Windows.Forms.ComboBox();
            this.dgv_History_Customers_All = new System.Windows.Forms.DataGridView();
            this.kokonimiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asiakasBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.vP_DatabaseDataSet4 = new R3_VillagePeople_Mahtimokit.VP_DatabaseDataSet4();
            this.tbl_History_2nd_Col_Orders_Dates = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_History_Order_History = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_History_Orders = new System.Windows.Forms.Label();
            this.lsv_History_Orders = new System.Windows.Forms.ListView();
            this.tbl_History_Order_Search = new System.Windows.Forms.TableLayoutPanel();
            this.btn_History_Order_Search = new System.Windows.Forms.Button();
            this.txt_History_Order_Search = new System.Windows.Forms.TextBox();
            this.tbl_History_Order_Dates_Delete = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_History_Order_Dates = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_History_Orders_Filter_Date_End = new System.Windows.Forms.Label();
            this.lbl_History_Orders_Filter_Date_Start = new System.Windows.Forms.Label();
            this.dtp_History_Orders_Filter_Date_Start = new System.Windows.Forms.DateTimePicker();
            this.dtp_History_Orders_Filter_Date_End = new System.Windows.Forms.DateTimePicker();
            this.tbl_History_3th_Col_Selected_Order_Details = new System.Windows.Forms.TableLayoutPanel();
            this.lsv_History_Order_Additional_Details = new System.Windows.Forms.ListView();
            this.lbl_History_Order_Additional_Details = new System.Windows.Forms.Label();
            this.lsv_History_Order_Services = new System.Windows.Forms.ListView();
            this.lbl_History_Order_Services = new System.Windows.Forms.Label();
            this.lbl_History_Cottage_Details = new System.Windows.Forms.Label();
            this.lsv_History_Cottage_Details = new System.Windows.Forms.ListView();
            this.lbl_History_Order_Start = new System.Windows.Forms.Label();
            this.lbl_History_Order_End = new System.Windows.Forms.Label();
            this.lbl_History_Selected_Order_Customers = new System.Windows.Forms.Label();
            this.lsv_History_Selected_Order_Customers = new System.Windows.Forms.ListView();
            this.tbl_History_Order_Details_Delete = new System.Windows.Forms.TableLayoutPanel();
            this.btn_History_Order_History_Delete = new System.Windows.Forms.Button();
            this.lbl_History_Selected_Order_Details = new System.Windows.Forms.Label();
            this.tab_Settings = new System.Windows.Forms.TabPage();
            this.tbl_Settings_Base = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_Settings_1st_Col_Common_Settings_Base = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_Settings_1st_Col_Common_Settings = new System.Windows.Forms.TableLayoutPanel();
            this.cbo_Common_Settings_Default_Office = new System.Windows.Forms.ComboBox();
            this.lbl_Settings_Common_Settings = new System.Windows.Forms.Label();
            this.lbl_Common_Settings_Default_Office = new System.Windows.Forms.Label();
            this.lbl_Common_Settings_History_Start_Date = new System.Windows.Forms.Label();
            this.dtp_Common_Settings_History_Start_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Common_Settings_History_End_Date = new System.Windows.Forms.Label();
            this.tbl_Common_Settings_History_End_Date_Today = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Common_Settings_History_End_Date_Today = new System.Windows.Forms.Label();
            this.chk_Common_Settings_History_End_Date_Today = new System.Windows.Forms.CheckBox();
            this.dtp_Common_Settings_History_End_Date_Custom = new System.Windows.Forms.DateTimePicker();
            this.lbl_Common_Settings_History_End_Date_Custom = new System.Windows.Forms.Label();
            this.tbl_Settings_2nd_Col_UI_Settings_Base = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_Settings_2nd_Col_UI_Settings = new System.Windows.Forms.TableLayoutPanel();
            this.cbo_UI_Settings_Language = new System.Windows.Forms.ComboBox();
            this.lbl_Settings_UI_Settings = new System.Windows.Forms.Label();
            this.lbl_UI_Settings_Language = new System.Windows.Forms.Label();
            this.lbl_UI_Settings_Font_Size = new System.Windows.Forms.Label();
            this.cbo_UI_Settings_Font_Size = new System.Windows.Forms.ComboBox();
            this.asiakasTableAdapter = new R3_VillagePeople_Mahtimokit.VP_DatabaseDataSetTableAdapters.AsiakasTableAdapter();
            this.toimipisteTableAdapter = new R3_VillagePeople_Mahtimokit.VP_DatabaseDataSet1TableAdapters.ToimipisteTableAdapter();
            this.palveluTableAdapter = new R3_VillagePeople_Mahtimokit.VP_DatabaseDataSet2TableAdapters.PalveluTableAdapter();
            this.majoitusTableAdapter = new R3_VillagePeople_Mahtimokit.VP_DatabaseDataSet3TableAdapters.MajoitusTableAdapter();
            this.asiakasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.asiakasTableAdapter1 = new R3_VillagePeople_Mahtimokit.VP_DatabaseDataSet4TableAdapters.AsiakasTableAdapter();
            this.tab_Menu.SuspendLayout();
            this.tab_New_Order.SuspendLayout();
            this.tbl_Order_base.SuspendLayout();
            this.tbl_Order_1st_Col_Dates_Customers.SuspendLayout();
            this.tbl_Order_1st_Col_Dates.SuspendLayout();
            this.tbl_Order_Date_Selection.SuspendLayout();
            this.tbl_Order_1st_Col_Customer.SuspendLayout();
            this.tbl_Order_Customer_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Order_Customers_All)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vP_DatabaseDataSet)).BeginInit();
            this.tbl_Order_2nd_Col_Offices_Cottage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Order_Cottages_All)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.majoitusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vP_DatabaseDataSet3)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toimipisteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vP_DatabaseDataSet1)).BeginInit();
            this.tbl_Order_3rd_Col_Cottage_Summary_Services.SuspendLayout();
            this.tbl_Order_3rd_Col_Services.SuspendLayout();
            this.tbl_Order_3rd_Col_Services_Quantity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Order_Services_All)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vP_DatabaseDataSet2)).BeginInit();
            this.tbl_4th_Col_Summary.SuspendLayout();
            this.tbl_Order_Summary_Dates_Office.SuspendLayout();
            this.tbl_Order_Summary_Customers_Cottages_Services.SuspendLayout();
            this.tbl_Order_Summary_Buttons.SuspendLayout();
            this.tab_Edit.SuspendLayout();
            this.tbl_Edit_base.SuspendLayout();
            this.tbl_Edit_1st_Col_Customers.SuspendLayout();
            this.tbl_Edit_1st_Col_Customers_Search.SuspendLayout();
            this.tbl_Edit_1st_Col_Customers_Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customers_All)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPDatabaseDataSetBindingSource)).BeginInit();
            this.tbl_Edit_2nd_Col_Offices_Services.SuspendLayout();
            this.tbl_Edit_2nd_Col_Offices.SuspendLayout();
            this.tbl_Edit_2nd_Col_Offices_Buttons.SuspendLayout();
            this.tbl_Edit_2nd_Col_Services.SuspendLayout();
            this.tbl_Edit_2nd_Col_Services_Search.SuspendLayout();
            this.tbl_Edit_2nd_Col_Services_Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Services_All)).BeginInit();
            this.tbl_Edit_3rd_Col_Cottages.SuspendLayout();
            this.tbl_Edit_3rd_Col_Cottages_Search.SuspendLayout();
            this.tbl_Edit_3rd_Col_Cottages_Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cottages_all)).BeginInit();
            this.tab_History.SuspendLayout();
            this.tbl_History_Base.SuspendLayout();
            this.tbl_History_1st_Col_Customers_Offices.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_History_Customers_All)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vP_DatabaseDataSet4)).BeginInit();
            this.tbl_History_2nd_Col_Orders_Dates.SuspendLayout();
            this.tbl_History_Order_History.SuspendLayout();
            this.tbl_History_Order_Search.SuspendLayout();
            this.tbl_History_Order_Dates_Delete.SuspendLayout();
            this.tbl_History_Order_Dates.SuspendLayout();
            this.tbl_History_3th_Col_Selected_Order_Details.SuspendLayout();
            this.tbl_History_Order_Details_Delete.SuspendLayout();
            this.tab_Settings.SuspendLayout();
            this.tbl_Settings_Base.SuspendLayout();
            this.tbl_Settings_1st_Col_Common_Settings_Base.SuspendLayout();
            this.tbl_Settings_1st_Col_Common_Settings.SuspendLayout();
            this.tbl_Common_Settings_History_End_Date_Today.SuspendLayout();
            this.tbl_Settings_2nd_Col_UI_Settings_Base.SuspendLayout();
            this.tbl_Settings_2nd_Col_UI_Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_Menu
            // 
            this.tab_Menu.Controls.Add(this.tab_New_Order);
            this.tab_Menu.Controls.Add(this.tab_Edit);
            this.tab_Menu.Controls.Add(this.tab_History);
            this.tab_Menu.Controls.Add(this.tab_Settings);
            this.tab_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tab_Menu.Location = new System.Drawing.Point(0, 0);
            this.tab_Menu.Name = "tab_Menu";
            this.tab_Menu.SelectedIndex = 0;
            this.tab_Menu.Size = new System.Drawing.Size(984, 681);
            this.tab_Menu.TabIndex = 0;
            // 
            // tab_New_Order
            // 
            this.tab_New_Order.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tab_New_Order.Controls.Add(this.tbl_Order_base);
            this.tab_New_Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_New_Order.Location = new System.Drawing.Point(4, 29);
            this.tab_New_Order.Name = "tab_New_Order";
            this.tab_New_Order.Padding = new System.Windows.Forms.Padding(3);
            this.tab_New_Order.Size = new System.Drawing.Size(976, 648);
            this.tab_New_Order.TabIndex = 0;
            this.tab_New_Order.Text = "Uusi varaus";
            // 
            // tbl_Order_base
            // 
            this.tbl_Order_base.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tbl_Order_base.ColumnCount = 6;
            this.tbl_Order_base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tbl_Order_base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tbl_Order_base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29F));
            this.tbl_Order_base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tbl_Order_base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tbl_Order_base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tbl_Order_base.Controls.Add(this.tbl_Order_1st_Col_Dates_Customers, 1, 1);
            this.tbl_Order_base.Controls.Add(this.tbl_Order_2nd_Col_Offices_Cottage, 2, 1);
            this.tbl_Order_base.Controls.Add(this.tbl_Order_3rd_Col_Cottage_Summary_Services, 3, 1);
            this.tbl_Order_base.Controls.Add(this.tbl_4th_Col_Summary, 4, 1);
            this.tbl_Order_base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_Order_base.Location = new System.Drawing.Point(3, 3);
            this.tbl_Order_base.Name = "tbl_Order_base";
            this.tbl_Order_base.RowCount = 3;
            this.tbl_Order_base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tbl_Order_base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96F));
            this.tbl_Order_base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tbl_Order_base.Size = new System.Drawing.Size(970, 642);
            this.tbl_Order_base.TabIndex = 1;
            // 
            // tbl_Order_1st_Col_Dates_Customers
            // 
            this.tbl_Order_1st_Col_Dates_Customers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_Order_1st_Col_Dates_Customers.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbl_Order_1st_Col_Dates_Customers.ColumnCount = 3;
            this.tbl_Order_1st_Col_Dates_Customers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tbl_Order_1st_Col_Dates_Customers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96F));
            this.tbl_Order_1st_Col_Dates_Customers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tbl_Order_1st_Col_Dates_Customers.Controls.Add(this.tbl_Order_Customers, 0, 1);
            this.tbl_Order_1st_Col_Dates_Customers.Controls.Add(this.tbl_Order_1st_Col_Dates, 1, 1);
            this.tbl_Order_1st_Col_Dates_Customers.Controls.Add(this.tbl_Order_1st_Col_Customer, 1, 2);
            this.tbl_Order_1st_Col_Dates_Customers.Location = new System.Drawing.Point(12, 15);
            this.tbl_Order_1st_Col_Dates_Customers.Name = "tbl_Order_1st_Col_Dates_Customers";
            this.tbl_Order_1st_Col_Dates_Customers.RowCount = 4;
            this.tbl_Order_1st_Col_Dates_Customers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tbl_Order_1st_Col_Dates_Customers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_Order_1st_Col_Dates_Customers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Order_1st_Col_Dates_Customers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tbl_Order_1st_Col_Dates_Customers.Size = new System.Drawing.Size(207, 610);
            this.tbl_Order_1st_Col_Dates_Customers.TabIndex = 0;
            // 
            // tbl_Order_Customers
            // 
            this.tbl_Order_Customers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_Order_Customers.ColumnCount = 2;
            this.tbl_Order_Customers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 97F));
            this.tbl_Order_Customers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tbl_Order_Customers.Location = new System.Drawing.Point(3, 18);
            this.tbl_Order_Customers.Name = "tbl_Order_Customers";
            this.tbl_Order_Customers.RowCount = 2;
            this.tbl_Order_Customers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.17188F));
            this.tbl_Order_Customers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.82813F));
            this.tbl_Order_Customers.Size = new System.Drawing.Size(1, 83);
            this.tbl_Order_Customers.TabIndex = 1;
            // 
            // tbl_Order_1st_Col_Dates
            // 
            this.tbl_Order_1st_Col_Dates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_Order_1st_Col_Dates.ColumnCount = 1;
            this.tbl_Order_1st_Col_Dates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Order_1st_Col_Dates.Controls.Add(this.tbl_Order_Date_Selection, 0, 1);
            this.tbl_Order_1st_Col_Dates.Controls.Add(this.lbl_Order_Dates, 0, 0);
            this.tbl_Order_1st_Col_Dates.Location = new System.Drawing.Point(7, 18);
            this.tbl_Order_1st_Col_Dates.Name = "tbl_Order_1st_Col_Dates";
            this.tbl_Order_1st_Col_Dates.RowCount = 2;
            this.tbl_Order_1st_Col_Dates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tbl_Order_1st_Col_Dates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tbl_Order_1st_Col_Dates.Size = new System.Drawing.Size(192, 83);
            this.tbl_Order_1st_Col_Dates.TabIndex = 2;
            // 
            // tbl_Order_Date_Selection
            // 
            this.tbl_Order_Date_Selection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_Order_Date_Selection.ColumnCount = 2;
            this.tbl_Order_Date_Selection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Order_Date_Selection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Order_Date_Selection.Controls.Add(this.label1, 1, 0);
            this.tbl_Order_Date_Selection.Controls.Add(this.label2, 0, 0);
            this.tbl_Order_Date_Selection.Controls.Add(this.dateTimePicker1, 0, 1);
            this.tbl_Order_Date_Selection.Controls.Add(this.dateTimePicker2, 1, 1);
            this.tbl_Order_Date_Selection.Location = new System.Drawing.Point(3, 26);
            this.tbl_Order_Date_Selection.Name = "tbl_Order_Date_Selection";
            this.tbl_Order_Date_Selection.RowCount = 2;
            this.tbl_Order_Date_Selection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.85185F));
            this.tbl_Order_Date_Selection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.14815F));
            this.tbl_Order_Date_Selection.Size = new System.Drawing.Size(186, 64);
            this.tbl_Order_Date_Selection.TabIndex = 112;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Päättyy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Alkaa";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(87, 26);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Value = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker2.Location = new System.Drawing.Point(96, 20);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(87, 26);
            this.dateTimePicker2.TabIndex = 3;
            this.dateTimePicker2.Value = new System.DateTime(2017, 4, 8, 16, 25, 31, 0);
            // 
            // lbl_Order_Dates
            // 
            this.lbl_Order_Dates.AutoSize = true;
            this.lbl_Order_Dates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Order_Dates.Location = new System.Drawing.Point(3, 0);
            this.lbl_Order_Dates.Name = "lbl_Order_Dates";
            this.lbl_Order_Dates.Size = new System.Drawing.Size(144, 20);
            this.lbl_Order_Dates.TabIndex = 0;
            this.lbl_Order_Dates.Text = "Varauksen kesto";
            // 
            // tbl_Order_1st_Col_Customer
            // 
            this.tbl_Order_1st_Col_Customer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_Order_1st_Col_Customer.ColumnCount = 1;
            this.tbl_Order_1st_Col_Customer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Order_1st_Col_Customer.Controls.Add(this.tbl_Order_Customer_Search, 0, 2);
            this.tbl_Order_1st_Col_Customer.Controls.Add(this.lbl_Order_Customers, 0, 0);
            this.tbl_Order_1st_Col_Customer.Controls.Add(this.btn_Order_Customers_Add, 0, 3);
            this.tbl_Order_1st_Col_Customer.Controls.Add(this.dgv_Order_Customers_All, 0, 1);
            this.tbl_Order_1st_Col_Customer.Location = new System.Drawing.Point(7, 107);
            this.tbl_Order_1st_Col_Customer.Name = "tbl_Order_1st_Col_Customer";
            this.tbl_Order_1st_Col_Customer.RowCount = 4;
            this.tbl_Order_1st_Col_Customer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_Order_1st_Col_Customer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Order_1st_Col_Customer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tbl_Order_1st_Col_Customer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_Order_1st_Col_Customer.Size = new System.Drawing.Size(192, 485);
            this.tbl_Order_1st_Col_Customer.TabIndex = 3;
            // 
            // tbl_Order_Customer_Search
            // 
            this.tbl_Order_Customer_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_Order_Customer_Search.ColumnCount = 2;
            this.tbl_Order_Customer_Search.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Order_Customer_Search.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tbl_Order_Customer_Search.Controls.Add(this.btn_Order_Customers_Search, 0, 0);
            this.tbl_Order_Customer_Search.Controls.Add(this.txt_Order_Customers_Search, 0, 0);
            this.tbl_Order_Customer_Search.Location = new System.Drawing.Point(3, 401);
            this.tbl_Order_Customer_Search.Name = "tbl_Order_Customer_Search";
            this.tbl_Order_Customer_Search.RowCount = 1;
            this.tbl_Order_Customer_Search.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tbl_Order_Customer_Search.Size = new System.Drawing.Size(186, 40);
            this.tbl_Order_Customer_Search.TabIndex = 0;
            // 
            // btn_Order_Customers_Search
            // 
            this.btn_Order_Customers_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Order_Customers_Search.BackgroundImage")));
            this.btn_Order_Customers_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Order_Customers_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Order_Customers_Search.Location = new System.Drawing.Point(149, 3);
            this.btn_Order_Customers_Search.Name = "btn_Order_Customers_Search";
            this.btn_Order_Customers_Search.Size = new System.Drawing.Size(32, 32);
            this.btn_Order_Customers_Search.TabIndex = 102;
            this.btn_Order_Customers_Search.UseVisualStyleBackColor = true;
            // 
            // txt_Order_Customers_Search
            // 
            this.txt_Order_Customers_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Order_Customers_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Order_Customers_Search.Location = new System.Drawing.Point(3, 3);
            this.txt_Order_Customers_Search.Name = "txt_Order_Customers_Search";
            this.txt_Order_Customers_Search.Size = new System.Drawing.Size(140, 26);
            this.txt_Order_Customers_Search.TabIndex = 101;
            this.txt_Order_Customers_Search.TextChanged += new System.EventHandler(this.txt_Order_Customers_Search_TextChanged);
            // 
            // lbl_Order_Customers
            // 
            this.lbl_Order_Customers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Order_Customers.AutoSize = true;
            this.lbl_Order_Customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Order_Customers.Location = new System.Drawing.Point(3, 0);
            this.lbl_Order_Customers.Name = "lbl_Order_Customers";
            this.lbl_Order_Customers.Size = new System.Drawing.Size(186, 20);
            this.lbl_Order_Customers.TabIndex = 103;
            this.lbl_Order_Customers.Text = "Asiakkaiden valinta";
            // 
            // btn_Order_Customers_Add
            // 
            this.btn_Order_Customers_Add.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Order_Customers_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Order_Customers_Add.Location = new System.Drawing.Point(3, 447);
            this.btn_Order_Customers_Add.Name = "btn_Order_Customers_Add";
            this.btn_Order_Customers_Add.Size = new System.Drawing.Size(186, 35);
            this.btn_Order_Customers_Add.TabIndex = 105;
            this.btn_Order_Customers_Add.Text = "Lisää varaukseen";
            this.btn_Order_Customers_Add.UseVisualStyleBackColor = true;
            // 
            // dgv_Order_Customers_All
            // 
            this.dgv_Order_Customers_All.AllowUserToAddRows = false;
            this.dgv_Order_Customers_All.AllowUserToDeleteRows = false;
            this.dgv_Order_Customers_All.AllowUserToResizeColumns = false;
            this.dgv_Order_Customers_All.AllowUserToResizeRows = false;
            this.dgv_Order_Customers_All.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Order_Customers_All.AutoGenerateColumns = false;
            this.dgv_Order_Customers_All.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Order_Customers_All.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_Order_Customers_All.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Order_Customers_All.ColumnHeadersVisible = false;
            this.dgv_Order_Customers_All.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kokonimiDataGridViewTextBoxColumn});
            this.dgv_Order_Customers_All.DataSource = this.asiakasBindingSource;
            this.dgv_Order_Customers_All.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_Order_Customers_All.Location = new System.Drawing.Point(3, 23);
            this.dgv_Order_Customers_All.Name = "dgv_Order_Customers_All";
            this.dgv_Order_Customers_All.ReadOnly = true;
            this.dgv_Order_Customers_All.RowHeadersVisible = false;
            this.dgv_Order_Customers_All.Size = new System.Drawing.Size(186, 372);
            this.dgv_Order_Customers_All.TabIndex = 106;
            // 
            // kokonimiDataGridViewTextBoxColumn
            // 
            this.kokonimiDataGridViewTextBoxColumn.DataPropertyName = "kokonimi";
            this.kokonimiDataGridViewTextBoxColumn.HeaderText = "kokonimi";
            this.kokonimiDataGridViewTextBoxColumn.Name = "kokonimiDataGridViewTextBoxColumn";
            this.kokonimiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // asiakasBindingSource
            // 
            this.asiakasBindingSource.DataMember = "Asiakas";
            this.asiakasBindingSource.DataSource = this.vP_DatabaseDataSet;
            // 
            // vP_DatabaseDataSet
            // 
            this.vP_DatabaseDataSet.DataSetName = "VP_DatabaseDataSet";
            this.vP_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_Order_2nd_Col_Offices_Cottage
            // 
            this.tbl_Order_2nd_Col_Offices_Cottage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_Order_2nd_Col_Offices_Cottage.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbl_Order_2nd_Col_Offices_Cottage.ColumnCount = 3;
            this.tbl_Order_2nd_Col_Offices_Cottage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tbl_Order_2nd_Col_Offices_Cottage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96F));
            this.tbl_Order_2nd_Col_Offices_Cottage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tbl_Order_2nd_Col_Offices_Cottage.Controls.Add(this.lbl_Order_Cottage_Selection, 1, 6);
            this.tbl_Order_2nd_Col_Offices_Cottage.Controls.Add(this.dgv_Order_Cottages_All, 1, 7);
            this.tbl_Order_2nd_Col_Offices_Cottage.Controls.Add(this.Btn_Order_Cottage_Add, 1, 9);
            this.tbl_Order_2nd_Col_Offices_Cottage.Controls.Add(this.tableLayoutPanel2, 1, 8);
            this.tbl_Order_2nd_Col_Offices_Cottage.Controls.Add(this.lbl_Order_Cottage, 0, 10);
            this.tbl_Order_2nd_Col_Offices_Cottage.Controls.Add(this.lbl_Order_Office, 1, 1);
            this.tbl_Order_2nd_Col_Offices_Cottage.Controls.Add(this.cbo_Order_Office_Select, 1, 2);
            this.tbl_Order_2nd_Col_Offices_Cottage.Location = new System.Drawing.Point(225, 15);
            this.tbl_Order_2nd_Col_Offices_Cottage.Name = "tbl_Order_2nd_Col_Offices_Cottage";
            this.tbl_Order_2nd_Col_Offices_Cottage.RowCount = 11;
            this.tbl_Order_2nd_Col_Offices_Cottage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tbl_Order_2nd_Col_Offices_Cottage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_Order_2nd_Col_Offices_Cottage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tbl_Order_2nd_Col_Offices_Cottage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_Order_2nd_Col_Offices_Cottage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_Order_2nd_Col_Offices_Cottage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_Order_2nd_Col_Offices_Cottage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_Order_2nd_Col_Offices_Cottage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Order_2nd_Col_Offices_Cottage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tbl_Order_2nd_Col_Offices_Cottage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tbl_Order_2nd_Col_Offices_Cottage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tbl_Order_2nd_Col_Offices_Cottage.Size = new System.Drawing.Size(275, 610);
            this.tbl_Order_2nd_Col_Offices_Cottage.TabIndex = 1;
            // 
            // lbl_Order_Cottage_Selection
            // 
            this.lbl_Order_Cottage_Selection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Order_Cottage_Selection.AutoSize = true;
            this.lbl_Order_Cottage_Selection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Order_Cottage_Selection.Location = new System.Drawing.Point(8, 103);
            this.lbl_Order_Cottage_Selection.Name = "lbl_Order_Cottage_Selection";
            this.lbl_Order_Cottage_Selection.Size = new System.Drawing.Size(158, 20);
            this.lbl_Order_Cottage_Selection.TabIndex = 70;
            this.lbl_Order_Cottage_Selection.Text = "Toimipisteen mökit";
            // 
            // dgv_Order_Cottages_All
            // 
            this.dgv_Order_Cottages_All.AllowUserToAddRows = false;
            this.dgv_Order_Cottages_All.AllowUserToDeleteRows = false;
            this.dgv_Order_Cottages_All.AllowUserToResizeColumns = false;
            this.dgv_Order_Cottages_All.AllowUserToResizeRows = false;
            this.dgv_Order_Cottages_All.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Order_Cottages_All.AutoGenerateColumns = false;
            this.dgv_Order_Cottages_All.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Order_Cottages_All.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_Order_Cottages_All.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Order_Cottages_All.ColumnHeadersVisible = false;
            this.dgv_Order_Cottages_All.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nimiDataGridViewTextBoxColumn2});
            this.dgv_Order_Cottages_All.DataSource = this.majoitusBindingSource;
            this.dgv_Order_Cottages_All.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_Order_Cottages_All.Location = new System.Drawing.Point(8, 126);
            this.dgv_Order_Cottages_All.Name = "dgv_Order_Cottages_All";
            this.dgv_Order_Cottages_All.ReadOnly = true;
            this.dgv_Order_Cottages_All.RowHeadersVisible = false;
            this.dgv_Order_Cottages_All.Size = new System.Drawing.Size(258, 380);
            this.dgv_Order_Cottages_All.TabIndex = 107;
            // 
            // nimiDataGridViewTextBoxColumn2
            // 
            this.nimiDataGridViewTextBoxColumn2.DataPropertyName = "nimi";
            this.nimiDataGridViewTextBoxColumn2.HeaderText = "nimi";
            this.nimiDataGridViewTextBoxColumn2.Name = "nimiDataGridViewTextBoxColumn2";
            this.nimiDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // majoitusBindingSource
            // 
            this.majoitusBindingSource.DataMember = "Majoitus";
            this.majoitusBindingSource.DataSource = this.vP_DatabaseDataSet3;
            // 
            // vP_DatabaseDataSet3
            // 
            this.vP_DatabaseDataSet3.DataSetName = "VP_DatabaseDataSet3";
            this.vP_DatabaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Btn_Order_Cottage_Add
            // 
            this.Btn_Order_Cottage_Add.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Order_Cottage_Add.Location = new System.Drawing.Point(8, 554);
            this.Btn_Order_Cottage_Add.Name = "Btn_Order_Cottage_Add";
            this.Btn_Order_Cottage_Add.Size = new System.Drawing.Size(258, 38);
            this.Btn_Order_Cottage_Add.TabIndex = 73;
            this.Btn_Order_Cottage_Add.Text = "Lisää mökki varaukseen";
            this.Btn_Order_Cottage_Add.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Controls.Add(this.btn_Order_Cottages_Search, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_Order_Cottages_Search, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(8, 512);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(258, 36);
            this.tableLayoutPanel2.TabIndex = 108;
            // 
            // btn_Order_Cottages_Search
            // 
            this.btn_Order_Cottages_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Order_Cottages_Search.BackgroundImage")));
            this.btn_Order_Cottages_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Order_Cottages_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Order_Cottages_Search.Location = new System.Drawing.Point(221, 3);
            this.btn_Order_Cottages_Search.Name = "btn_Order_Cottages_Search";
            this.btn_Order_Cottages_Search.Size = new System.Drawing.Size(32, 32);
            this.btn_Order_Cottages_Search.TabIndex = 102;
            this.btn_Order_Cottages_Search.UseVisualStyleBackColor = true;
            // 
            // txt_Order_Cottages_Search
            // 
            this.txt_Order_Cottages_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Order_Cottages_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Order_Cottages_Search.Location = new System.Drawing.Point(3, 3);
            this.txt_Order_Cottages_Search.Name = "txt_Order_Cottages_Search";
            this.txt_Order_Cottages_Search.Size = new System.Drawing.Size(212, 26);
            this.txt_Order_Cottages_Search.TabIndex = 101;
            this.txt_Order_Cottages_Search.TextChanged += new System.EventHandler(this.txt_Order_Cottages_Search_TextChanged);
            // 
            // lbl_Order_Cottage
            // 
            this.lbl_Order_Cottage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Order_Cottage.AutoSize = true;
            this.lbl_Order_Cottage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Order_Cottage.Location = new System.Drawing.Point(3, 595);
            this.lbl_Order_Cottage.Name = "lbl_Order_Cottage";
            this.lbl_Order_Cottage.Size = new System.Drawing.Size(1, 15);
            this.lbl_Order_Cottage.TabIndex = 0;
            this.lbl_Order_Cottage.Text = "Majoitus";
            // 
            // lbl_Order_Office
            // 
            this.lbl_Order_Office.AutoSize = true;
            this.lbl_Order_Office.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Order_Office.Location = new System.Drawing.Point(8, 15);
            this.lbl_Order_Office.Name = "lbl_Order_Office";
            this.lbl_Order_Office.Size = new System.Drawing.Size(167, 20);
            this.lbl_Order_Office.TabIndex = 109;
            this.lbl_Order_Office.Text = "Toimipisteen valinta";
            // 
            // cbo_Order_Office_Select
            // 
            this.cbo_Order_Office_Select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_Order_Office_Select.DataSource = this.toimipisteBindingSource;
            this.cbo_Order_Office_Select.DisplayMember = "nimi";
            this.cbo_Order_Office_Select.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Order_Office_Select.FormattingEnabled = true;
            this.cbo_Order_Office_Select.Location = new System.Drawing.Point(8, 55);
            this.cbo_Order_Office_Select.Name = "cbo_Order_Office_Select";
            this.cbo_Order_Office_Select.Size = new System.Drawing.Size(258, 28);
            this.cbo_Order_Office_Select.TabIndex = 110;
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
            // tbl_Order_3rd_Col_Cottage_Summary_Services
            // 
            this.tbl_Order_3rd_Col_Cottage_Summary_Services.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_Order_3rd_Col_Cottage_Summary_Services.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbl_Order_3rd_Col_Cottage_Summary_Services.ColumnCount = 3;
            this.tbl_Order_3rd_Col_Cottage_Summary_Services.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tbl_Order_3rd_Col_Cottage_Summary_Services.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96F));
            this.tbl_Order_3rd_Col_Cottage_Summary_Services.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tbl_Order_3rd_Col_Cottage_Summary_Services.Controls.Add(this.tbl_Order_3rd_Col_Services, 1, 3);
            this.tbl_Order_3rd_Col_Cottage_Summary_Services.Controls.Add(this.btn_Order_Service_add, 1, 4);
            this.tbl_Order_3rd_Col_Cottage_Summary_Services.Location = new System.Drawing.Point(506, 15);
            this.tbl_Order_3rd_Col_Cottage_Summary_Services.Name = "tbl_Order_3rd_Col_Cottage_Summary_Services";
            this.tbl_Order_3rd_Col_Cottage_Summary_Services.RowCount = 6;
            this.tbl_Order_3rd_Col_Cottage_Summary_Services.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tbl_Order_3rd_Col_Cottage_Summary_Services.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_Order_3rd_Col_Cottage_Summary_Services.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tbl_Order_3rd_Col_Cottage_Summary_Services.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Order_3rd_Col_Cottage_Summary_Services.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tbl_Order_3rd_Col_Cottage_Summary_Services.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tbl_Order_3rd_Col_Cottage_Summary_Services.Size = new System.Drawing.Size(217, 610);
            this.tbl_Order_3rd_Col_Cottage_Summary_Services.TabIndex = 2;
            // 
            // tbl_Order_3rd_Col_Services
            // 
            this.tbl_Order_3rd_Col_Services.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_Order_3rd_Col_Services.ColumnCount = 1;
            this.tbl_Order_3rd_Col_Services.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Order_3rd_Col_Services.Controls.Add(this.lbl_Order_Services, 0, 0);
            this.tbl_Order_3rd_Col_Services.Controls.Add(this.tbl_Order_3rd_Col_Services_Quantity, 0, 3);
            this.tbl_Order_3rd_Col_Services.Controls.Add(this.dgv_Order_Services_All, 0, 1);
            this.tbl_Order_3rd_Col_Services.Location = new System.Drawing.Point(7, 28);
            this.tbl_Order_3rd_Col_Services.Name = "tbl_Order_3rd_Col_Services";
            this.tbl_Order_3rd_Col_Services.RowCount = 4;
            this.tbl_Order_3rd_Col_Services.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_Order_3rd_Col_Services.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Order_3rd_Col_Services.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_Order_3rd_Col_Services.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tbl_Order_3rd_Col_Services.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_Order_3rd_Col_Services.Size = new System.Drawing.Size(202, 518);
            this.tbl_Order_3rd_Col_Services.TabIndex = 1;
            // 
            // lbl_Order_Services
            // 
            this.lbl_Order_Services.AutoSize = true;
            this.lbl_Order_Services.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Order_Services.Location = new System.Drawing.Point(3, 0);
            this.lbl_Order_Services.Name = "lbl_Order_Services";
            this.lbl_Order_Services.Size = new System.Drawing.Size(157, 20);
            this.lbl_Order_Services.TabIndex = 72;
            this.lbl_Order_Services.Text = "Palveluiden valinta";
            // 
            // tbl_Order_3rd_Col_Services_Quantity
            // 
            this.tbl_Order_3rd_Col_Services_Quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_Order_3rd_Col_Services_Quantity.ColumnCount = 4;
            this.tbl_Order_3rd_Col_Services_Quantity.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Order_3rd_Col_Services_Quantity.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tbl_Order_3rd_Col_Services_Quantity.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tbl_Order_3rd_Col_Services_Quantity.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tbl_Order_3rd_Col_Services_Quantity.Controls.Add(this.txt_Order_Services_Search, 0, 0);
            this.tbl_Order_3rd_Col_Services_Quantity.Controls.Add(this.btn_Order_Services_Search, 1, 0);
            this.tbl_Order_3rd_Col_Services_Quantity.Controls.Add(this.lbl_Order_Services_Quantity_Units, 3, 0);
            this.tbl_Order_3rd_Col_Services_Quantity.Controls.Add(this.txt_Order_Services_Quantity, 2, 0);
            this.tbl_Order_3rd_Col_Services_Quantity.Location = new System.Drawing.Point(3, 478);
            this.tbl_Order_3rd_Col_Services_Quantity.Name = "tbl_Order_3rd_Col_Services_Quantity";
            this.tbl_Order_3rd_Col_Services_Quantity.RowCount = 1;
            this.tbl_Order_3rd_Col_Services_Quantity.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tbl_Order_3rd_Col_Services_Quantity.Size = new System.Drawing.Size(196, 37);
            this.tbl_Order_3rd_Col_Services_Quantity.TabIndex = 107;
            // 
            // txt_Order_Services_Search
            // 
            this.txt_Order_Services_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Order_Services_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Order_Services_Search.Location = new System.Drawing.Point(3, 3);
            this.txt_Order_Services_Search.Name = "txt_Order_Services_Search";
            this.txt_Order_Services_Search.Size = new System.Drawing.Size(86, 26);
            this.txt_Order_Services_Search.TabIndex = 101;
            this.txt_Order_Services_Search.TextChanged += new System.EventHandler(this.txt_Order_Services_Search_TextChanged);
            // 
            // btn_Order_Services_Search
            // 
            this.btn_Order_Services_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Order_Services_Search.BackgroundImage")));
            this.btn_Order_Services_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Order_Services_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Order_Services_Search.Location = new System.Drawing.Point(95, 3);
            this.btn_Order_Services_Search.Name = "btn_Order_Services_Search";
            this.btn_Order_Services_Search.Size = new System.Drawing.Size(32, 32);
            this.btn_Order_Services_Search.TabIndex = 102;
            this.btn_Order_Services_Search.UseVisualStyleBackColor = true;
            // 
            // lbl_Order_Services_Quantity_Units
            // 
            this.lbl_Order_Services_Quantity_Units.AutoSize = true;
            this.lbl_Order_Services_Quantity_Units.Location = new System.Drawing.Point(164, 0);
            this.lbl_Order_Services_Quantity_Units.Name = "lbl_Order_Services_Quantity_Units";
            this.lbl_Order_Services_Quantity_Units.Size = new System.Drawing.Size(29, 20);
            this.lbl_Order_Services_Quantity_Units.TabIndex = 2;
            this.lbl_Order_Services_Quantity_Units.Text = "kpl";
            this.lbl_Order_Services_Quantity_Units.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_Order_Services_Quantity
            // 
            this.txt_Order_Services_Quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Order_Services_Quantity.Location = new System.Drawing.Point(133, 3);
            this.txt_Order_Services_Quantity.Name = "txt_Order_Services_Quantity";
            this.txt_Order_Services_Quantity.Size = new System.Drawing.Size(25, 26);
            this.txt_Order_Services_Quantity.TabIndex = 1;
            this.txt_Order_Services_Quantity.Text = "1";
            // 
            // dgv_Order_Services_All
            // 
            this.dgv_Order_Services_All.AllowUserToAddRows = false;
            this.dgv_Order_Services_All.AllowUserToDeleteRows = false;
            this.dgv_Order_Services_All.AllowUserToResizeColumns = false;
            this.dgv_Order_Services_All.AllowUserToResizeRows = false;
            this.dgv_Order_Services_All.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Order_Services_All.AutoGenerateColumns = false;
            this.dgv_Order_Services_All.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Order_Services_All.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_Order_Services_All.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Order_Services_All.ColumnHeadersVisible = false;
            this.dgv_Order_Services_All.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nimiDataGridViewTextBoxColumn1});
            this.dgv_Order_Services_All.DataSource = this.palveluBindingSource;
            this.dgv_Order_Services_All.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_Order_Services_All.Location = new System.Drawing.Point(3, 23);
            this.dgv_Order_Services_All.Name = "dgv_Order_Services_All";
            this.dgv_Order_Services_All.ReadOnly = true;
            this.dgv_Order_Services_All.RowHeadersVisible = false;
            this.dgv_Order_Services_All.Size = new System.Drawing.Size(196, 449);
            this.dgv_Order_Services_All.TabIndex = 108;
            // 
            // nimiDataGridViewTextBoxColumn1
            // 
            this.nimiDataGridViewTextBoxColumn1.DataPropertyName = "nimi";
            this.nimiDataGridViewTextBoxColumn1.HeaderText = "nimi";
            this.nimiDataGridViewTextBoxColumn1.Name = "nimiDataGridViewTextBoxColumn1";
            this.nimiDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // palveluBindingSource
            // 
            this.palveluBindingSource.DataMember = "Palvelu";
            this.palveluBindingSource.DataSource = this.vP_DatabaseDataSet2;
            // 
            // vP_DatabaseDataSet2
            // 
            this.vP_DatabaseDataSet2.DataSetName = "VP_DatabaseDataSet2";
            this.vP_DatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Order_Service_add
            // 
            this.btn_Order_Service_add.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Order_Service_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Order_Service_add.Location = new System.Drawing.Point(7, 552);
            this.btn_Order_Service_add.Name = "btn_Order_Service_add";
            this.btn_Order_Service_add.Size = new System.Drawing.Size(202, 40);
            this.btn_Order_Service_add.TabIndex = 106;
            this.btn_Order_Service_add.Text = "Lisää palvelu varaukseen";
            this.btn_Order_Service_add.UseVisualStyleBackColor = true;
            // 
            // tbl_4th_Col_Summary
            // 
            this.tbl_4th_Col_Summary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_4th_Col_Summary.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbl_4th_Col_Summary.ColumnCount = 3;
            this.tbl_4th_Col_Summary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tbl_4th_Col_Summary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96F));
            this.tbl_4th_Col_Summary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tbl_4th_Col_Summary.Controls.Add(this.tbl_Order_Summary_Dates_Office, 1, 1);
            this.tbl_4th_Col_Summary.Controls.Add(this.lbl_Order_Additional_Details, 1, 3);
            this.tbl_4th_Col_Summary.Controls.Add(this.tbl_Order_Summary_Customers_Cottages_Services, 1, 2);
            this.tbl_4th_Col_Summary.Controls.Add(this.tbl_Order_Summary_Buttons, 1, 5);
            this.tbl_4th_Col_Summary.Controls.Add(this.txt_Order_Additional_Details, 1, 4);
            this.tbl_4th_Col_Summary.Location = new System.Drawing.Point(729, 15);
            this.tbl_4th_Col_Summary.Name = "tbl_4th_Col_Summary";
            this.tbl_4th_Col_Summary.RowCount = 7;
            this.tbl_4th_Col_Summary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tbl_4th_Col_Summary.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_4th_Col_Summary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.65656F));
            this.tbl_4th_Col_Summary.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_4th_Col_Summary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.34343F));
            this.tbl_4th_Col_Summary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tbl_4th_Col_Summary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tbl_4th_Col_Summary.Size = new System.Drawing.Size(226, 610);
            this.tbl_4th_Col_Summary.TabIndex = 3;
            // 
            // tbl_Order_Summary_Dates_Office
            // 
            this.tbl_Order_Summary_Dates_Office.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_Order_Summary_Dates_Office.ColumnCount = 1;
            this.tbl_Order_Summary_Dates_Office.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Order_Summary_Dates_Office.Controls.Add(this.lbl_Order_Summary, 0, 0);
            this.tbl_Order_Summary_Dates_Office.Controls.Add(this.lbl_Order_Summary_Office, 0, 3);
            this.tbl_Order_Summary_Dates_Office.Controls.Add(this.lbl_Order_Summary_Start_Date, 0, 1);
            this.tbl_Order_Summary_Dates_Office.Controls.Add(this.lbl_Order_Summary_End_Date, 0, 2);
            this.tbl_Order_Summary_Dates_Office.Location = new System.Drawing.Point(7, 18);
            this.tbl_Order_Summary_Dates_Office.Name = "tbl_Order_Summary_Dates_Office";
            this.tbl_Order_Summary_Dates_Office.RowCount = 4;
            this.tbl_Order_Summary_Dates_Office.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tbl_Order_Summary_Dates_Office.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tbl_Order_Summary_Dates_Office.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tbl_Order_Summary_Dates_Office.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tbl_Order_Summary_Dates_Office.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_Order_Summary_Dates_Office.Size = new System.Drawing.Size(210, 141);
            this.tbl_Order_Summary_Dates_Office.TabIndex = 0;
            // 
            // lbl_Order_Summary
            // 
            this.lbl_Order_Summary.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Order_Summary.AutoSize = true;
            this.lbl_Order_Summary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Order_Summary.Location = new System.Drawing.Point(3, 10);
            this.lbl_Order_Summary.Name = "lbl_Order_Summary";
            this.lbl_Order_Summary.Size = new System.Drawing.Size(188, 20);
            this.lbl_Order_Summary.TabIndex = 46;
            this.lbl_Order_Summary.Text = "Varauksen yhteenveto";
            // 
            // lbl_Order_Summary_Office
            // 
            this.lbl_Order_Summary_Office.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Order_Summary_Office.AutoSize = true;
            this.lbl_Order_Summary_Office.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Order_Summary_Office.Location = new System.Drawing.Point(3, 104);
            this.lbl_Order_Summary_Office.Name = "lbl_Order_Summary_Office";
            this.lbl_Order_Summary_Office.Size = new System.Drawing.Size(88, 20);
            this.lbl_Order_Summary_Office.TabIndex = 91;
            this.lbl_Order_Summary_Office.Text = "Toimipiste: ";
            // 
            // lbl_Order_Summary_Start_Date
            // 
            this.lbl_Order_Summary_Start_Date.AutoSize = true;
            this.lbl_Order_Summary_Start_Date.Location = new System.Drawing.Point(3, 41);
            this.lbl_Order_Summary_Start_Date.Name = "lbl_Order_Summary_Start_Date";
            this.lbl_Order_Summary_Start_Date.Size = new System.Drawing.Size(105, 20);
            this.lbl_Order_Summary_Start_Date.TabIndex = 94;
            this.lbl_Order_Summary_Start_Date.Text = "Alkamispäivä:";
            // 
            // lbl_Order_Summary_End_Date
            // 
            this.lbl_Order_Summary_End_Date.AutoSize = true;
            this.lbl_Order_Summary_End_Date.Location = new System.Drawing.Point(3, 67);
            this.lbl_Order_Summary_End_Date.Name = "lbl_Order_Summary_End_Date";
            this.lbl_Order_Summary_End_Date.Size = new System.Drawing.Size(119, 20);
            this.lbl_Order_Summary_End_Date.TabIndex = 95;
            this.lbl_Order_Summary_End_Date.Text = "Päättymispäivä:";
            // 
            // lbl_Order_Additional_Details
            // 
            this.lbl_Order_Additional_Details.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Order_Additional_Details.AutoSize = true;
            this.lbl_Order_Additional_Details.Location = new System.Drawing.Point(71, 393);
            this.lbl_Order_Additional_Details.Name = "lbl_Order_Additional_Details";
            this.lbl_Order_Additional_Details.Size = new System.Drawing.Size(81, 20);
            this.lbl_Order_Additional_Details.TabIndex = 108;
            this.lbl_Order_Additional_Details.Text = "Lisätietoja";
            // 
            // tbl_Order_Summary_Customers_Cottages_Services
            // 
            this.tbl_Order_Summary_Customers_Cottages_Services.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_Order_Summary_Customers_Cottages_Services.ColumnCount = 1;
            this.tbl_Order_Summary_Customers_Cottages_Services.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Order_Summary_Customers_Cottages_Services.Controls.Add(this.lsv_Order_Summary_Customers, 0, 1);
            this.tbl_Order_Summary_Customers_Cottages_Services.Controls.Add(this.lbl_Order_Summary_Customers, 0, 0);
            this.tbl_Order_Summary_Customers_Cottages_Services.Controls.Add(this.lbl_Order_Summary_Cottages, 0, 2);
            this.tbl_Order_Summary_Customers_Cottages_Services.Controls.Add(this.lsv_Order_Summary_Cottages, 0, 3);
            this.tbl_Order_Summary_Customers_Cottages_Services.Controls.Add(this.lsv_Order_Summary_Services, 0, 5);
            this.tbl_Order_Summary_Customers_Cottages_Services.Controls.Add(this.lbl_Order_Summary_Services, 0, 4);
            this.tbl_Order_Summary_Customers_Cottages_Services.Location = new System.Drawing.Point(7, 165);
            this.tbl_Order_Summary_Customers_Cottages_Services.Name = "tbl_Order_Summary_Customers_Cottages_Services";
            this.tbl_Order_Summary_Customers_Cottages_Services.RowCount = 7;
            this.tbl_Order_Summary_Customers_Cottages_Services.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_Order_Summary_Customers_Cottages_Services.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_Order_Summary_Customers_Cottages_Services.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_Order_Summary_Customers_Cottages_Services.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_Order_Summary_Customers_Cottages_Services.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_Order_Summary_Customers_Cottages_Services.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_Order_Summary_Customers_Cottages_Services.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tbl_Order_Summary_Customers_Cottages_Services.Size = new System.Drawing.Size(210, 225);
            this.tbl_Order_Summary_Customers_Cottages_Services.TabIndex = 1;
            // 
            // lsv_Order_Summary_Customers
            // 
            this.lsv_Order_Summary_Customers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsv_Order_Summary_Customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lsv_Order_Summary_Customers.Location = new System.Drawing.Point(3, 23);
            this.lsv_Order_Summary_Customers.Name = "lsv_Order_Summary_Customers";
            this.lsv_Order_Summary_Customers.Size = new System.Drawing.Size(204, 46);
            this.lsv_Order_Summary_Customers.TabIndex = 93;
            this.lsv_Order_Summary_Customers.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_Order_Summary_Customers
            // 
            this.lbl_Order_Summary_Customers.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Order_Summary_Customers.AutoSize = true;
            this.lbl_Order_Summary_Customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Order_Summary_Customers.Location = new System.Drawing.Point(65, 0);
            this.lbl_Order_Summary_Customers.Name = "lbl_Order_Summary_Customers";
            this.lbl_Order_Summary_Customers.Size = new System.Drawing.Size(79, 20);
            this.lbl_Order_Summary_Customers.TabIndex = 92;
            this.lbl_Order_Summary_Customers.Text = "Asiakkaat";
            // 
            // lbl_Order_Summary_Cottages
            // 
            this.lbl_Order_Summary_Cottages.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Order_Summary_Cottages.AutoSize = true;
            this.lbl_Order_Summary_Cottages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Order_Summary_Cottages.Location = new System.Drawing.Point(71, 72);
            this.lbl_Order_Summary_Cottages.Name = "lbl_Order_Summary_Cottages";
            this.lbl_Order_Summary_Cottages.Size = new System.Drawing.Size(68, 20);
            this.lbl_Order_Summary_Cottages.TabIndex = 47;
            this.lbl_Order_Summary_Cottages.Text = "Majoitus";
            // 
            // lsv_Order_Summary_Cottages
            // 
            this.lsv_Order_Summary_Cottages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsv_Order_Summary_Cottages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lsv_Order_Summary_Cottages.Location = new System.Drawing.Point(3, 95);
            this.lsv_Order_Summary_Cottages.Name = "lsv_Order_Summary_Cottages";
            this.lsv_Order_Summary_Cottages.Size = new System.Drawing.Size(204, 46);
            this.lsv_Order_Summary_Cottages.TabIndex = 50;
            this.lsv_Order_Summary_Cottages.UseCompatibleStateImageBehavior = false;
            // 
            // lsv_Order_Summary_Services
            // 
            this.lsv_Order_Summary_Services.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsv_Order_Summary_Services.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lsv_Order_Summary_Services.Location = new System.Drawing.Point(3, 167);
            this.lsv_Order_Summary_Services.Name = "lsv_Order_Summary_Services";
            this.lsv_Order_Summary_Services.Size = new System.Drawing.Size(204, 46);
            this.lsv_Order_Summary_Services.TabIndex = 52;
            this.lsv_Order_Summary_Services.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_Order_Summary_Services
            // 
            this.lbl_Order_Summary_Services.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Order_Summary_Services.AutoSize = true;
            this.lbl_Order_Summary_Services.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Order_Summary_Services.Location = new System.Drawing.Point(49, 144);
            this.lbl_Order_Summary_Services.Name = "lbl_Order_Summary_Services";
            this.lbl_Order_Summary_Services.Size = new System.Drawing.Size(112, 20);
            this.lbl_Order_Summary_Services.TabIndex = 51;
            this.lbl_Order_Summary_Services.Text = "Valitut palvelut";
            // 
            // tbl_Order_Summary_Buttons
            // 
            this.tbl_Order_Summary_Buttons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_Order_Summary_Buttons.ColumnCount = 2;
            this.tbl_Order_Summary_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Order_Summary_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Order_Summary_Buttons.Controls.Add(this.btn_Order_Summary_Next_Page, 0, 0);
            this.tbl_Order_Summary_Buttons.Controls.Add(this.btn_Order_Summary_Delete_From_List, 0, 0);
            this.tbl_Order_Summary_Buttons.Location = new System.Drawing.Point(7, 537);
            this.tbl_Order_Summary_Buttons.Name = "tbl_Order_Summary_Buttons";
            this.tbl_Order_Summary_Buttons.RowCount = 1;
            this.tbl_Order_Summary_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Order_Summary_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tbl_Order_Summary_Buttons.Size = new System.Drawing.Size(210, 54);
            this.tbl_Order_Summary_Buttons.TabIndex = 54;
            // 
            // btn_Order_Summary_Next_Page
            // 
            this.btn_Order_Summary_Next_Page.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Order_Summary_Next_Page.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Order_Summary_Next_Page.BackgroundImage")));
            this.btn_Order_Summary_Next_Page.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Order_Summary_Next_Page.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Order_Summary_Next_Page.Location = new System.Drawing.Point(159, 3);
            this.btn_Order_Summary_Next_Page.Name = "btn_Order_Summary_Next_Page";
            this.btn_Order_Summary_Next_Page.Size = new System.Drawing.Size(48, 48);
            this.btn_Order_Summary_Next_Page.TabIndex = 53;
            this.btn_Order_Summary_Next_Page.UseVisualStyleBackColor = true;
            // 
            // btn_Order_Summary_Delete_From_List
            // 
            this.btn_Order_Summary_Delete_From_List.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Order_Summary_Delete_From_List.BackgroundImage")));
            this.btn_Order_Summary_Delete_From_List.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Order_Summary_Delete_From_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Order_Summary_Delete_From_List.Location = new System.Drawing.Point(3, 3);
            this.btn_Order_Summary_Delete_From_List.Name = "btn_Order_Summary_Delete_From_List";
            this.btn_Order_Summary_Delete_From_List.Size = new System.Drawing.Size(48, 48);
            this.btn_Order_Summary_Delete_From_List.TabIndex = 52;
            this.btn_Order_Summary_Delete_From_List.UseVisualStyleBackColor = true;
            // 
            // txt_Order_Additional_Details
            // 
            this.txt_Order_Additional_Details.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Order_Additional_Details.Location = new System.Drawing.Point(7, 416);
            this.txt_Order_Additional_Details.Multiline = true;
            this.txt_Order_Additional_Details.Name = "txt_Order_Additional_Details";
            this.txt_Order_Additional_Details.Size = new System.Drawing.Size(210, 115);
            this.txt_Order_Additional_Details.TabIndex = 109;
            // 
            // tab_Edit
            // 
            this.tab_Edit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tab_Edit.Controls.Add(this.tbl_Edit_base);
            this.tab_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_Edit.Location = new System.Drawing.Point(4, 29);
            this.tab_Edit.Name = "tab_Edit";
            this.tab_Edit.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Edit.Size = new System.Drawing.Size(976, 648);
            this.tab_Edit.TabIndex = 1;
            this.tab_Edit.Text = "Tietojen Hallinta";
            // 
            // tbl_Edit_base
            // 
            this.tbl_Edit_base.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tbl_Edit_base.ColumnCount = 5;
            this.tbl_Edit_base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tbl_Edit_base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tbl_Edit_base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tbl_Edit_base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tbl_Edit_base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tbl_Edit_base.Controls.Add(this.tbl_Edit_1st_Col_Customers, 1, 1);
            this.tbl_Edit_base.Controls.Add(this.tbl_Edit_2nd_Col_Offices_Services, 2, 1);
            this.tbl_Edit_base.Controls.Add(this.tbl_Edit_3rd_Col_Cottages, 3, 1);
            this.tbl_Edit_base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_Edit_base.Location = new System.Drawing.Point(3, 3);
            this.tbl_Edit_base.Name = "tbl_Edit_base";
            this.tbl_Edit_base.RowCount = 3;
            this.tbl_Edit_base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tbl_Edit_base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96F));
            this.tbl_Edit_base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tbl_Edit_base.Size = new System.Drawing.Size(970, 642);
            this.tbl_Edit_base.TabIndex = 0;
            // 
            // tbl_Edit_1st_Col_Customers
            // 
            this.tbl_Edit_1st_Col_Customers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_Edit_1st_Col_Customers.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbl_Edit_1st_Col_Customers.ColumnCount = 3;
            this.tbl_Edit_1st_Col_Customers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tbl_Edit_1st_Col_Customers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96F));
            this.tbl_Edit_1st_Col_Customers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tbl_Edit_1st_Col_Customers.Controls.Add(this.lbl_Customer_Management, 1, 1);
            this.tbl_Edit_1st_Col_Customers.Controls.Add(this.tbl_Edit_1st_Col_Customers_Search, 1, 3);
            this.tbl_Edit_1st_Col_Customers.Controls.Add(this.tbl_Edit_1st_Col_Customers_Buttons, 1, 4);
            this.tbl_Edit_1st_Col_Customers.Controls.Add(this.dgv_Customers_All, 1, 2);
            this.tbl_Edit_1st_Col_Customers.Location = new System.Drawing.Point(22, 15);
            this.tbl_Edit_1st_Col_Customers.Name = "tbl_Edit_1st_Col_Customers";
            this.tbl_Edit_1st_Col_Customers.RowCount = 6;
            this.tbl_Edit_1st_Col_Customers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tbl_Edit_1st_Col_Customers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_Edit_1st_Col_Customers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Edit_1st_Col_Customers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tbl_Edit_1st_Col_Customers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tbl_Edit_1st_Col_Customers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tbl_Edit_1st_Col_Customers.Size = new System.Drawing.Size(304, 610);
            this.tbl_Edit_1st_Col_Customers.TabIndex = 0;
            // 
            // lbl_Customer_Management
            // 
            this.lbl_Customer_Management.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Customer_Management.AutoSize = true;
            this.lbl_Customer_Management.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_Management.Location = new System.Drawing.Point(9, 15);
            this.lbl_Customer_Management.Name = "lbl_Customer_Management";
            this.lbl_Customer_Management.Size = new System.Drawing.Size(169, 20);
            this.lbl_Customer_Management.TabIndex = 78;
            this.lbl_Customer_Management.Text = "Asiakkaiden hallinta";
            // 
            // tbl_Edit_1st_Col_Customers_Search
            // 
            this.tbl_Edit_1st_Col_Customers_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_Edit_1st_Col_Customers_Search.ColumnCount = 2;
            this.tbl_Edit_1st_Col_Customers_Search.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Edit_1st_Col_Customers_Search.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tbl_Edit_1st_Col_Customers_Search.Controls.Add(this.btn_Customer_Search, 0, 0);
            this.tbl_Edit_1st_Col_Customers_Search.Controls.Add(this.txt_Customer_Search, 0, 0);
            this.tbl_Edit_1st_Col_Customers_Search.Location = new System.Drawing.Point(9, 488);
            this.tbl_Edit_1st_Col_Customers_Search.Name = "tbl_Edit_1st_Col_Customers_Search";
            this.tbl_Edit_1st_Col_Customers_Search.RowCount = 1;
            this.tbl_Edit_1st_Col_Customers_Search.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Edit_1st_Col_Customers_Search.Size = new System.Drawing.Size(285, 40);
            this.tbl_Edit_1st_Col_Customers_Search.TabIndex = 101;
            // 
            // btn_Customer_Search
            // 
            this.btn_Customer_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Customer_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Customer_Search.BackgroundImage")));
            this.btn_Customer_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Customer_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Customer_Search.Location = new System.Drawing.Point(250, 3);
            this.btn_Customer_Search.Name = "btn_Customer_Search";
            this.btn_Customer_Search.Size = new System.Drawing.Size(32, 32);
            this.btn_Customer_Search.TabIndex = 102;
            this.btn_Customer_Search.UseVisualStyleBackColor = true;
            // 
            // txt_Customer_Search
            // 
            this.txt_Customer_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Customer_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Customer_Search.Location = new System.Drawing.Point(3, 3);
            this.txt_Customer_Search.Name = "txt_Customer_Search";
            this.txt_Customer_Search.Size = new System.Drawing.Size(239, 26);
            this.txt_Customer_Search.TabIndex = 101;
            this.txt_Customer_Search.TextChanged += new System.EventHandler(this.txt_Customer_Search_TextChanged);
            // 
            // tbl_Edit_1st_Col_Customers_Buttons
            // 
            this.tbl_Edit_1st_Col_Customers_Buttons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_Edit_1st_Col_Customers_Buttons.ColumnCount = 3;
            this.tbl_Edit_1st_Col_Customers_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_Edit_1st_Col_Customers_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_Edit_1st_Col_Customers_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_Edit_1st_Col_Customers_Buttons.Controls.Add(this.btn_Customer_Delete, 0, 0);
            this.tbl_Edit_1st_Col_Customers_Buttons.Controls.Add(this.btn_Customer_Edit, 0, 0);
            this.tbl_Edit_1st_Col_Customers_Buttons.Controls.Add(this.btn_Customer_Add, 0, 0);
            this.tbl_Edit_1st_Col_Customers_Buttons.Location = new System.Drawing.Point(9, 534);
            this.tbl_Edit_1st_Col_Customers_Buttons.Name = "tbl_Edit_1st_Col_Customers_Buttons";
            this.tbl_Edit_1st_Col_Customers_Buttons.RowCount = 1;
            this.tbl_Edit_1st_Col_Customers_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Edit_1st_Col_Customers_Buttons.Size = new System.Drawing.Size(285, 58);
            this.tbl_Edit_1st_Col_Customers_Buttons.TabIndex = 102;
            // 
            // btn_Customer_Delete
            // 
            this.btn_Customer_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Customer_Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Customer_Delete.BackgroundImage")));
            this.btn_Customer_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Customer_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Customer_Delete.Location = new System.Drawing.Point(234, 7);
            this.btn_Customer_Delete.Name = "btn_Customer_Delete";
            this.btn_Customer_Delete.Size = new System.Drawing.Size(48, 48);
            this.btn_Customer_Delete.TabIndex = 110;
            this.btn_Customer_Delete.UseVisualStyleBackColor = true;
            this.btn_Customer_Delete.Click += new System.EventHandler(this.btn_Customer_Delete_Click_1);
            // 
            // btn_Customer_Edit
            // 
            this.btn_Customer_Edit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Customer_Edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Customer_Edit.BackgroundImage")));
            this.btn_Customer_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Customer_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Customer_Edit.Location = new System.Drawing.Point(118, 7);
            this.btn_Customer_Edit.Name = "btn_Customer_Edit";
            this.btn_Customer_Edit.Size = new System.Drawing.Size(48, 48);
            this.btn_Customer_Edit.TabIndex = 109;
            this.btn_Customer_Edit.UseVisualStyleBackColor = true;
            this.btn_Customer_Edit.Click += new System.EventHandler(this.btn_Customer_Edit_Click_1);
            // 
            // btn_Customer_Add
            // 
            this.btn_Customer_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Customer_Add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Customer_Add.BackgroundImage")));
            this.btn_Customer_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Customer_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Customer_Add.Location = new System.Drawing.Point(3, 7);
            this.btn_Customer_Add.Name = "btn_Customer_Add";
            this.btn_Customer_Add.Size = new System.Drawing.Size(48, 48);
            this.btn_Customer_Add.TabIndex = 108;
            this.btn_Customer_Add.UseVisualStyleBackColor = true;
            this.btn_Customer_Add.Click += new System.EventHandler(this.btn_Customer_Add_Click_1);
            // 
            // dgv_Customers_All
            // 
            this.dgv_Customers_All.AllowUserToAddRows = false;
            this.dgv_Customers_All.AllowUserToDeleteRows = false;
            this.dgv_Customers_All.AllowUserToResizeColumns = false;
            this.dgv_Customers_All.AllowUserToResizeRows = false;
            this.dgv_Customers_All.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Customers_All.AutoGenerateColumns = false;
            this.dgv_Customers_All.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Customers_All.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_Customers_All.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Customers_All.ColumnHeadersVisible = false;
            this.dgv_Customers_All.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgv_Customers_All.DataSource = this.asiakasBindingSource1;
            this.dgv_Customers_All.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_Customers_All.Location = new System.Drawing.Point(9, 38);
            this.dgv_Customers_All.Name = "dgv_Customers_All";
            this.dgv_Customers_All.ReadOnly = true;
            this.dgv_Customers_All.RowHeadersVisible = false;
            this.dgv_Customers_All.Size = new System.Drawing.Size(285, 444);
            this.dgv_Customers_All.TabIndex = 107;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "kokonimi";
            this.dataGridViewTextBoxColumn1.HeaderText = "kokonimi";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // asiakasBindingSource1
            // 
            this.asiakasBindingSource1.DataMember = "Asiakas";
            this.asiakasBindingSource1.DataSource = this.vPDatabaseDataSetBindingSource;
            // 
            // vPDatabaseDataSetBindingSource
            // 
            this.vPDatabaseDataSetBindingSource.DataSource = this.vP_DatabaseDataSet;
            this.vPDatabaseDataSetBindingSource.Position = 0;
            // 
            // tbl_Edit_2nd_Col_Offices_Services
            // 
            this.tbl_Edit_2nd_Col_Offices_Services.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_Edit_2nd_Col_Offices_Services.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbl_Edit_2nd_Col_Offices_Services.ColumnCount = 3;
            this.tbl_Edit_2nd_Col_Offices_Services.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tbl_Edit_2nd_Col_Offices_Services.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96F));
            this.tbl_Edit_2nd_Col_Offices_Services.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tbl_Edit_2nd_Col_Offices_Services.Controls.Add(this.tbl_Edit_2nd_Col_Offices, 1, 1);
            this.tbl_Edit_2nd_Col_Offices_Services.Controls.Add(this.tbl_Edit_2nd_Col_Services, 1, 2);
            this.tbl_Edit_2nd_Col_Offices_Services.Location = new System.Drawing.Point(332, 15);
            this.tbl_Edit_2nd_Col_Offices_Services.Name = "tbl_Edit_2nd_Col_Offices_Services";
            this.tbl_Edit_2nd_Col_Offices_Services.RowCount = 4;
            this.tbl_Edit_2nd_Col_Offices_Services.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tbl_Edit_2nd_Col_Offices_Services.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_Edit_2nd_Col_Offices_Services.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Edit_2nd_Col_Offices_Services.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tbl_Edit_2nd_Col_Offices_Services.Size = new System.Drawing.Size(304, 610);
            this.tbl_Edit_2nd_Col_Offices_Services.TabIndex = 1;
            // 
            // tbl_Edit_2nd_Col_Offices
            // 
            this.tbl_Edit_2nd_Col_Offices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_Edit_2nd_Col_Offices.ColumnCount = 1;
            this.tbl_Edit_2nd_Col_Offices.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Edit_2nd_Col_Offices.Controls.Add(this.lbl_Office, 0, 0);
            this.tbl_Edit_2nd_Col_Offices.Controls.Add(this.cbo_Office_Select, 0, 1);
            this.tbl_Edit_2nd_Col_Offices.Controls.Add(this.tbl_Edit_2nd_Col_Offices_Buttons, 0, 2);
            this.tbl_Edit_2nd_Col_Offices.Location = new System.Drawing.Point(9, 18);
            this.tbl_Edit_2nd_Col_Offices.Name = "tbl_Edit_2nd_Col_Offices";
            this.tbl_Edit_2nd_Col_Offices.RowCount = 3;
            this.tbl_Edit_2nd_Col_Offices.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_Edit_2nd_Col_Offices.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_Edit_2nd_Col_Offices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tbl_Edit_2nd_Col_Offices.Size = new System.Drawing.Size(285, 112);
            this.tbl_Edit_2nd_Col_Offices.TabIndex = 0;
            // 
            // lbl_Office
            // 
            this.lbl_Office.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Office.AutoSize = true;
            this.lbl_Office.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Office.Location = new System.Drawing.Point(3, 0);
            this.lbl_Office.Name = "lbl_Office";
            this.lbl_Office.Size = new System.Drawing.Size(187, 20);
            this.lbl_Office.TabIndex = 104;
            this.lbl_Office.Text = "Toimipisteiden hallinta";
            // 
            // cbo_Office_Select
            // 
            this.cbo_Office_Select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_Office_Select.DataSource = this.toimipisteBindingSource;
            this.cbo_Office_Select.DisplayMember = "nimi";
            this.cbo_Office_Select.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Office_Select.FormattingEnabled = true;
            this.cbo_Office_Select.Location = new System.Drawing.Point(3, 23);
            this.cbo_Office_Select.Name = "cbo_Office_Select";
            this.cbo_Office_Select.Size = new System.Drawing.Size(279, 28);
            this.cbo_Office_Select.TabIndex = 105;
            // 
            // tbl_Edit_2nd_Col_Offices_Buttons
            // 
            this.tbl_Edit_2nd_Col_Offices_Buttons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_Edit_2nd_Col_Offices_Buttons.ColumnCount = 3;
            this.tbl_Edit_2nd_Col_Offices_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_Edit_2nd_Col_Offices_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tbl_Edit_2nd_Col_Offices_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tbl_Edit_2nd_Col_Offices_Buttons.Controls.Add(this.btn_Office_Delete, 0, 0);
            this.tbl_Edit_2nd_Col_Offices_Buttons.Controls.Add(this.btn_Office_Edit, 0, 0);
            this.tbl_Edit_2nd_Col_Offices_Buttons.Controls.Add(this.btn_Office_Add, 0, 0);
            this.tbl_Edit_2nd_Col_Offices_Buttons.Location = new System.Drawing.Point(3, 57);
            this.tbl_Edit_2nd_Col_Offices_Buttons.Name = "tbl_Edit_2nd_Col_Offices_Buttons";
            this.tbl_Edit_2nd_Col_Offices_Buttons.RowCount = 1;
            this.tbl_Edit_2nd_Col_Offices_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tbl_Edit_2nd_Col_Offices_Buttons.Size = new System.Drawing.Size(279, 54);
            this.tbl_Edit_2nd_Col_Offices_Buttons.TabIndex = 106;
            // 
            // btn_Office_Delete
            // 
            this.btn_Office_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Office_Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Office_Delete.BackgroundImage")));
            this.btn_Office_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Office_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Office_Delete.Location = new System.Drawing.Point(228, 3);
            this.btn_Office_Delete.Name = "btn_Office_Delete";
            this.btn_Office_Delete.Size = new System.Drawing.Size(48, 48);
            this.btn_Office_Delete.TabIndex = 113;
            this.btn_Office_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Office_Edit
            // 
            this.btn_Office_Edit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Office_Edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Office_Edit.BackgroundImage")));
            this.btn_Office_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Office_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Office_Edit.Location = new System.Drawing.Point(114, 3);
            this.btn_Office_Edit.Name = "btn_Office_Edit";
            this.btn_Office_Edit.Size = new System.Drawing.Size(48, 48);
            this.btn_Office_Edit.TabIndex = 112;
            this.btn_Office_Edit.UseVisualStyleBackColor = true;
            this.btn_Office_Edit.Click += new System.EventHandler(this.btn_Office_Edit_Click_1);
            // 
            // btn_Office_Add
            // 
            this.btn_Office_Add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Office_Add.BackgroundImage")));
            this.btn_Office_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Office_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Office_Add.Location = new System.Drawing.Point(3, 3);
            this.btn_Office_Add.Name = "btn_Office_Add";
            this.btn_Office_Add.Size = new System.Drawing.Size(48, 48);
            this.btn_Office_Add.TabIndex = 111;
            this.btn_Office_Add.UseVisualStyleBackColor = true;
            this.btn_Office_Add.Click += new System.EventHandler(this.btn_Office_Add_Click_1);
            // 
            // tbl_Edit_2nd_Col_Services
            // 
            this.tbl_Edit_2nd_Col_Services.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_Edit_2nd_Col_Services.ColumnCount = 1;
            this.tbl_Edit_2nd_Col_Services.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Edit_2nd_Col_Services.Controls.Add(this.lbl_Services, 0, 0);
            this.tbl_Edit_2nd_Col_Services.Controls.Add(this.tbl_Edit_2nd_Col_Services_Search, 0, 2);
            this.tbl_Edit_2nd_Col_Services.Controls.Add(this.tbl_Edit_2nd_Col_Services_Buttons, 0, 3);
            this.tbl_Edit_2nd_Col_Services.Controls.Add(this.dgv_Services_All, 0, 1);
            this.tbl_Edit_2nd_Col_Services.Location = new System.Drawing.Point(9, 136);
            this.tbl_Edit_2nd_Col_Services.Name = "tbl_Edit_2nd_Col_Services";
            this.tbl_Edit_2nd_Col_Services.RowCount = 4;
            this.tbl_Edit_2nd_Col_Services.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_Edit_2nd_Col_Services.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Edit_2nd_Col_Services.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tbl_Edit_2nd_Col_Services.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tbl_Edit_2nd_Col_Services.Size = new System.Drawing.Size(285, 456);
            this.tbl_Edit_2nd_Col_Services.TabIndex = 1;
            // 
            // lbl_Services
            // 
            this.lbl_Services.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Services.AutoSize = true;
            this.lbl_Services.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Services.Location = new System.Drawing.Point(3, 0);
            this.lbl_Services.Name = "lbl_Services";
            this.lbl_Services.Size = new System.Drawing.Size(163, 20);
            this.lbl_Services.TabIndex = 78;
            this.lbl_Services.Text = "Palveluiden hallinta";
            // 
            // tbl_Edit_2nd_Col_Services_Search
            // 
            this.tbl_Edit_2nd_Col_Services_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_Edit_2nd_Col_Services_Search.ColumnCount = 2;
            this.tbl_Edit_2nd_Col_Services_Search.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Edit_2nd_Col_Services_Search.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tbl_Edit_2nd_Col_Services_Search.Controls.Add(this.btn_Services_Search, 0, 0);
            this.tbl_Edit_2nd_Col_Services_Search.Controls.Add(this.txt_Services_Search, 0, 0);
            this.tbl_Edit_2nd_Col_Services_Search.Location = new System.Drawing.Point(3, 354);
            this.tbl_Edit_2nd_Col_Services_Search.Name = "tbl_Edit_2nd_Col_Services_Search";
            this.tbl_Edit_2nd_Col_Services_Search.RowCount = 1;
            this.tbl_Edit_2nd_Col_Services_Search.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Edit_2nd_Col_Services_Search.Size = new System.Drawing.Size(279, 39);
            this.tbl_Edit_2nd_Col_Services_Search.TabIndex = 101;
            // 
            // btn_Services_Search
            // 
            this.btn_Services_Search.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Services_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Services_Search.BackgroundImage")));
            this.btn_Services_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Services_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Services_Search.Location = new System.Drawing.Point(244, 3);
            this.btn_Services_Search.Name = "btn_Services_Search";
            this.btn_Services_Search.Size = new System.Drawing.Size(32, 32);
            this.btn_Services_Search.TabIndex = 102;
            this.btn_Services_Search.UseVisualStyleBackColor = true;
            // 
            // txt_Services_Search
            // 
            this.txt_Services_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Services_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Services_Search.Location = new System.Drawing.Point(3, 6);
            this.txt_Services_Search.Name = "txt_Services_Search";
            this.txt_Services_Search.Size = new System.Drawing.Size(233, 26);
            this.txt_Services_Search.TabIndex = 101;
            this.txt_Services_Search.TextChanged += new System.EventHandler(this.txt_Services_Search_TextChanged);
            // 
            // tbl_Edit_2nd_Col_Services_Buttons
            // 
            this.tbl_Edit_2nd_Col_Services_Buttons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_Edit_2nd_Col_Services_Buttons.ColumnCount = 3;
            this.tbl_Edit_2nd_Col_Services_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_Edit_2nd_Col_Services_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_Edit_2nd_Col_Services_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_Edit_2nd_Col_Services_Buttons.Controls.Add(this.btn_Services_Delete, 2, 0);
            this.tbl_Edit_2nd_Col_Services_Buttons.Controls.Add(this.btn_Services_Edit, 1, 0);
            this.tbl_Edit_2nd_Col_Services_Buttons.Controls.Add(this.btn_Services_Add, 0, 0);
            this.tbl_Edit_2nd_Col_Services_Buttons.Location = new System.Drawing.Point(3, 399);
            this.tbl_Edit_2nd_Col_Services_Buttons.Name = "tbl_Edit_2nd_Col_Services_Buttons";
            this.tbl_Edit_2nd_Col_Services_Buttons.RowCount = 1;
            this.tbl_Edit_2nd_Col_Services_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tbl_Edit_2nd_Col_Services_Buttons.Size = new System.Drawing.Size(279, 54);
            this.tbl_Edit_2nd_Col_Services_Buttons.TabIndex = 102;
            // 
            // btn_Services_Delete
            // 
            this.btn_Services_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Services_Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Services_Delete.BackgroundImage")));
            this.btn_Services_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Services_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Services_Delete.Location = new System.Drawing.Point(228, 9);
            this.btn_Services_Delete.Name = "btn_Services_Delete";
            this.btn_Services_Delete.Size = new System.Drawing.Size(48, 48);
            this.btn_Services_Delete.TabIndex = 110;
            this.btn_Services_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Services_Edit
            // 
            this.btn_Services_Edit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Services_Edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Services_Edit.BackgroundImage")));
            this.btn_Services_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Services_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Services_Edit.Location = new System.Drawing.Point(115, 9);
            this.btn_Services_Edit.Name = "btn_Services_Edit";
            this.btn_Services_Edit.Size = new System.Drawing.Size(48, 48);
            this.btn_Services_Edit.TabIndex = 109;
            this.btn_Services_Edit.UseVisualStyleBackColor = true;
            this.btn_Services_Edit.Click += new System.EventHandler(this.btn_Services_Edit_Click_1);
            // 
            // btn_Services_Add
            // 
            this.btn_Services_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Services_Add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Services_Add.BackgroundImage")));
            this.btn_Services_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Services_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Services_Add.Location = new System.Drawing.Point(3, 9);
            this.btn_Services_Add.Name = "btn_Services_Add";
            this.btn_Services_Add.Size = new System.Drawing.Size(48, 48);
            this.btn_Services_Add.TabIndex = 108;
            this.btn_Services_Add.UseVisualStyleBackColor = true;
            this.btn_Services_Add.Click += new System.EventHandler(this.btn_Services_Add_Click_1);
            // 
            // dgv_Services_All
            // 
            this.dgv_Services_All.AllowUserToAddRows = false;
            this.dgv_Services_All.AllowUserToDeleteRows = false;
            this.dgv_Services_All.AllowUserToResizeColumns = false;
            this.dgv_Services_All.AllowUserToResizeRows = false;
            this.dgv_Services_All.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Services_All.AutoGenerateColumns = false;
            this.dgv_Services_All.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Services_All.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_Services_All.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Services_All.ColumnHeadersVisible = false;
            this.dgv_Services_All.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nimiDataGridViewTextBoxColumn});
            this.dgv_Services_All.DataSource = this.palveluBindingSource;
            this.dgv_Services_All.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_Services_All.Location = new System.Drawing.Point(3, 23);
            this.dgv_Services_All.Name = "dgv_Services_All";
            this.dgv_Services_All.ReadOnly = true;
            this.dgv_Services_All.RowHeadersVisible = false;
            this.dgv_Services_All.Size = new System.Drawing.Size(279, 325);
            this.dgv_Services_All.TabIndex = 108;
            // 
            // nimiDataGridViewTextBoxColumn
            // 
            this.nimiDataGridViewTextBoxColumn.DataPropertyName = "nimi";
            this.nimiDataGridViewTextBoxColumn.HeaderText = "nimi";
            this.nimiDataGridViewTextBoxColumn.Name = "nimiDataGridViewTextBoxColumn";
            this.nimiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tbl_Edit_3rd_Col_Cottages
            // 
            this.tbl_Edit_3rd_Col_Cottages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_Edit_3rd_Col_Cottages.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbl_Edit_3rd_Col_Cottages.ColumnCount = 3;
            this.tbl_Edit_3rd_Col_Cottages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tbl_Edit_3rd_Col_Cottages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96F));
            this.tbl_Edit_3rd_Col_Cottages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tbl_Edit_3rd_Col_Cottages.Controls.Add(this.lbl_Cottages, 1, 1);
            this.tbl_Edit_3rd_Col_Cottages.Controls.Add(this.tbl_Edit_3rd_Col_Cottages_Search, 1, 3);
            this.tbl_Edit_3rd_Col_Cottages.Controls.Add(this.tbl_Edit_3rd_Col_Cottages_Buttons, 1, 4);
            this.tbl_Edit_3rd_Col_Cottages.Controls.Add(this.dgv_Cottages_all, 1, 2);
            this.tbl_Edit_3rd_Col_Cottages.Location = new System.Drawing.Point(642, 15);
            this.tbl_Edit_3rd_Col_Cottages.Name = "tbl_Edit_3rd_Col_Cottages";
            this.tbl_Edit_3rd_Col_Cottages.RowCount = 6;
            this.tbl_Edit_3rd_Col_Cottages.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tbl_Edit_3rd_Col_Cottages.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_Edit_3rd_Col_Cottages.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Edit_3rd_Col_Cottages.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tbl_Edit_3rd_Col_Cottages.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tbl_Edit_3rd_Col_Cottages.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tbl_Edit_3rd_Col_Cottages.Size = new System.Drawing.Size(304, 610);
            this.tbl_Edit_3rd_Col_Cottages.TabIndex = 2;
            // 
            // lbl_Cottages
            // 
            this.lbl_Cottages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Cottages.AutoSize = true;
            this.lbl_Cottages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cottages.Location = new System.Drawing.Point(9, 15);
            this.lbl_Cottages.Name = "lbl_Cottages";
            this.lbl_Cottages.Size = new System.Drawing.Size(138, 20);
            this.lbl_Cottages.TabIndex = 78;
            this.lbl_Cottages.Text = "Mökkien hallinta";
            // 
            // tbl_Edit_3rd_Col_Cottages_Search
            // 
            this.tbl_Edit_3rd_Col_Cottages_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_Edit_3rd_Col_Cottages_Search.ColumnCount = 2;
            this.tbl_Edit_3rd_Col_Cottages_Search.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Edit_3rd_Col_Cottages_Search.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tbl_Edit_3rd_Col_Cottages_Search.Controls.Add(this.btn_Cottages_Search, 0, 0);
            this.tbl_Edit_3rd_Col_Cottages_Search.Controls.Add(this.txt_Cottages_Search, 0, 0);
            this.tbl_Edit_3rd_Col_Cottages_Search.Location = new System.Drawing.Point(9, 488);
            this.tbl_Edit_3rd_Col_Cottages_Search.Name = "tbl_Edit_3rd_Col_Cottages_Search";
            this.tbl_Edit_3rd_Col_Cottages_Search.RowCount = 1;
            this.tbl_Edit_3rd_Col_Cottages_Search.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Edit_3rd_Col_Cottages_Search.Size = new System.Drawing.Size(285, 40);
            this.tbl_Edit_3rd_Col_Cottages_Search.TabIndex = 101;
            // 
            // btn_Cottages_Search
            // 
            this.btn_Cottages_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cottages_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cottages_Search.BackgroundImage")));
            this.btn_Cottages_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cottages_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Cottages_Search.Location = new System.Drawing.Point(250, 3);
            this.btn_Cottages_Search.Name = "btn_Cottages_Search";
            this.btn_Cottages_Search.Size = new System.Drawing.Size(32, 32);
            this.btn_Cottages_Search.TabIndex = 102;
            this.btn_Cottages_Search.UseVisualStyleBackColor = true;
            // 
            // txt_Cottages_Search
            // 
            this.txt_Cottages_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Cottages_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Cottages_Search.Location = new System.Drawing.Point(3, 3);
            this.txt_Cottages_Search.Name = "txt_Cottages_Search";
            this.txt_Cottages_Search.Size = new System.Drawing.Size(239, 26);
            this.txt_Cottages_Search.TabIndex = 101;
            this.txt_Cottages_Search.TextChanged += new System.EventHandler(this.txt_Cottages_Search_TextChanged);
            // 
            // tbl_Edit_3rd_Col_Cottages_Buttons
            // 
            this.tbl_Edit_3rd_Col_Cottages_Buttons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_Edit_3rd_Col_Cottages_Buttons.ColumnCount = 3;
            this.tbl_Edit_3rd_Col_Cottages_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_Edit_3rd_Col_Cottages_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_Edit_3rd_Col_Cottages_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_Edit_3rd_Col_Cottages_Buttons.Controls.Add(this.btn_Cottages_Delete, 0, 0);
            this.tbl_Edit_3rd_Col_Cottages_Buttons.Controls.Add(this.btn_Cottages_Edit, 0, 0);
            this.tbl_Edit_3rd_Col_Cottages_Buttons.Controls.Add(this.btn_Cottages_Add, 0, 0);
            this.tbl_Edit_3rd_Col_Cottages_Buttons.Location = new System.Drawing.Point(9, 534);
            this.tbl_Edit_3rd_Col_Cottages_Buttons.Name = "tbl_Edit_3rd_Col_Cottages_Buttons";
            this.tbl_Edit_3rd_Col_Cottages_Buttons.RowCount = 1;
            this.tbl_Edit_3rd_Col_Cottages_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Edit_3rd_Col_Cottages_Buttons.Size = new System.Drawing.Size(285, 58);
            this.tbl_Edit_3rd_Col_Cottages_Buttons.TabIndex = 102;
            // 
            // btn_Cottages_Delete
            // 
            this.btn_Cottages_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cottages_Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cottages_Delete.BackgroundImage")));
            this.btn_Cottages_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cottages_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Cottages_Delete.Location = new System.Drawing.Point(234, 7);
            this.btn_Cottages_Delete.Name = "btn_Cottages_Delete";
            this.btn_Cottages_Delete.Size = new System.Drawing.Size(48, 48);
            this.btn_Cottages_Delete.TabIndex = 110;
            this.btn_Cottages_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Cottages_Edit
            // 
            this.btn_Cottages_Edit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Cottages_Edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cottages_Edit.BackgroundImage")));
            this.btn_Cottages_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cottages_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Cottages_Edit.Location = new System.Drawing.Point(118, 7);
            this.btn_Cottages_Edit.Name = "btn_Cottages_Edit";
            this.btn_Cottages_Edit.Size = new System.Drawing.Size(48, 48);
            this.btn_Cottages_Edit.TabIndex = 109;
            this.btn_Cottages_Edit.UseVisualStyleBackColor = true;
            this.btn_Cottages_Edit.Click += new System.EventHandler(this.btn_Cottages_Edit_Click_1);
            // 
            // btn_Cottages_Add
            // 
            this.btn_Cottages_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Cottages_Add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cottages_Add.BackgroundImage")));
            this.btn_Cottages_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cottages_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Cottages_Add.Location = new System.Drawing.Point(3, 7);
            this.btn_Cottages_Add.Name = "btn_Cottages_Add";
            this.btn_Cottages_Add.Size = new System.Drawing.Size(48, 48);
            this.btn_Cottages_Add.TabIndex = 108;
            this.btn_Cottages_Add.UseVisualStyleBackColor = true;
            this.btn_Cottages_Add.Click += new System.EventHandler(this.btn_Cottages_Add_Click_1);
            // 
            // dgv_Cottages_all
            // 
            this.dgv_Cottages_all.AllowUserToAddRows = false;
            this.dgv_Cottages_all.AllowUserToDeleteRows = false;
            this.dgv_Cottages_all.AllowUserToResizeColumns = false;
            this.dgv_Cottages_all.AllowUserToResizeRows = false;
            this.dgv_Cottages_all.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Cottages_all.AutoGenerateColumns = false;
            this.dgv_Cottages_all.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Cottages_all.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_Cottages_all.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Cottages_all.ColumnHeadersVisible = false;
            this.dgv_Cottages_all.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.dgv_Cottages_all.DataSource = this.majoitusBindingSource;
            this.dgv_Cottages_all.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_Cottages_all.Location = new System.Drawing.Point(9, 38);
            this.dgv_Cottages_all.Name = "dgv_Cottages_all";
            this.dgv_Cottages_all.ReadOnly = true;
            this.dgv_Cottages_all.RowHeadersVisible = false;
            this.dgv_Cottages_all.Size = new System.Drawing.Size(285, 444);
            this.dgv_Cottages_all.TabIndex = 108;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nimi";
            this.dataGridViewTextBoxColumn2.HeaderText = "nimi";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // tab_History
            // 
            this.tab_History.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tab_History.Controls.Add(this.tbl_History_Base);
            this.tab_History.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_History.Location = new System.Drawing.Point(4, 29);
            this.tab_History.Name = "tab_History";
            this.tab_History.Padding = new System.Windows.Forms.Padding(3);
            this.tab_History.Size = new System.Drawing.Size(976, 648);
            this.tab_History.TabIndex = 2;
            this.tab_History.Text = "Varaushistoria";
            // 
            // tbl_History_Base
            // 
            this.tbl_History_Base.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tbl_History_Base.ColumnCount = 5;
            this.tbl_History_Base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tbl_History_Base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tbl_History_Base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tbl_History_Base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tbl_History_Base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tbl_History_Base.Controls.Add(this.tbl_History_1st_Col_Customers_Offices, 1, 1);
            this.tbl_History_Base.Controls.Add(this.tbl_History_2nd_Col_Orders_Dates, 2, 1);
            this.tbl_History_Base.Controls.Add(this.tbl_History_3th_Col_Selected_Order_Details, 3, 1);
            this.tbl_History_Base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_History_Base.Location = new System.Drawing.Point(3, 3);
            this.tbl_History_Base.Name = "tbl_History_Base";
            this.tbl_History_Base.RowCount = 3;
            this.tbl_History_Base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tbl_History_Base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96F));
            this.tbl_History_Base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tbl_History_Base.Size = new System.Drawing.Size(970, 642);
            this.tbl_History_Base.TabIndex = 1;
            // 
            // tbl_History_1st_Col_Customers_Offices
            // 
            this.tbl_History_1st_Col_Customers_Offices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_History_1st_Col_Customers_Offices.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbl_History_1st_Col_Customers_Offices.ColumnCount = 3;
            this.tbl_History_1st_Col_Customers_Offices.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tbl_History_1st_Col_Customers_Offices.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96F));
            this.tbl_History_1st_Col_Customers_Offices.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tbl_History_1st_Col_Customers_Offices.Controls.Add(this.lbl_History_Customer_Selection, 1, 1);
            this.tbl_History_1st_Col_Customers_Offices.Controls.Add(this.tableLayoutPanel3, 1, 3);
            this.tbl_History_1st_Col_Customers_Offices.Controls.Add(this.btn_History_Limit_To_Customer, 1, 4);
            this.tbl_History_1st_Col_Customers_Offices.Controls.Add(this.tableLayoutPanel1, 1, 5);
            this.tbl_History_1st_Col_Customers_Offices.Controls.Add(this.dgv_History_Customers_All, 1, 2);
            this.tbl_History_1st_Col_Customers_Offices.Location = new System.Drawing.Point(22, 15);
            this.tbl_History_1st_Col_Customers_Offices.Name = "tbl_History_1st_Col_Customers_Offices";
            this.tbl_History_1st_Col_Customers_Offices.RowCount = 7;
            this.tbl_History_1st_Col_Customers_Offices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tbl_History_1st_Col_Customers_Offices.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_History_1st_Col_Customers_Offices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_History_1st_Col_Customers_Offices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tbl_History_1st_Col_Customers_Offices.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_History_1st_Col_Customers_Offices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tbl_History_1st_Col_Customers_Offices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tbl_History_1st_Col_Customers_Offices.Size = new System.Drawing.Size(304, 610);
            this.tbl_History_1st_Col_Customers_Offices.TabIndex = 0;
            // 
            // lbl_History_Customer_Selection
            // 
            this.lbl_History_Customer_Selection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_History_Customer_Selection.AutoSize = true;
            this.lbl_History_Customer_Selection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_History_Customer_Selection.Location = new System.Drawing.Point(9, 15);
            this.lbl_History_Customer_Selection.Name = "lbl_History_Customer_Selection";
            this.lbl_History_Customer_Selection.Size = new System.Drawing.Size(88, 20);
            this.lbl_History_Customer_Selection.TabIndex = 78;
            this.lbl_History_Customer_Selection.Text = "Asiakkaat";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.Controls.Add(this.btn_History_Customer_Search, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txt_History_Customer_Search, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(9, 364);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(285, 39);
            this.tableLayoutPanel3.TabIndex = 101;
            // 
            // btn_History_Customer_Search
            // 
            this.btn_History_Customer_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_History_Customer_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_History_Customer_Search.BackgroundImage")));
            this.btn_History_Customer_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_History_Customer_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_History_Customer_Search.Location = new System.Drawing.Point(250, 3);
            this.btn_History_Customer_Search.Name = "btn_History_Customer_Search";
            this.btn_History_Customer_Search.Size = new System.Drawing.Size(32, 32);
            this.btn_History_Customer_Search.TabIndex = 102;
            this.btn_History_Customer_Search.UseVisualStyleBackColor = true;
            // 
            // txt_History_Customer_Search
            // 
            this.txt_History_Customer_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_History_Customer_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_History_Customer_Search.Location = new System.Drawing.Point(3, 3);
            this.txt_History_Customer_Search.Name = "txt_History_Customer_Search";
            this.txt_History_Customer_Search.Size = new System.Drawing.Size(239, 26);
            this.txt_History_Customer_Search.TabIndex = 101;
            this.txt_History_Customer_Search.TextChanged += new System.EventHandler(this.txt_History_Customer_Search_TextChanged);
            // 
            // btn_History_Limit_To_Customer
            // 
            this.btn_History_Limit_To_Customer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_History_Limit_To_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_History_Limit_To_Customer.Location = new System.Drawing.Point(9, 409);
            this.btn_History_Limit_To_Customer.Name = "btn_History_Limit_To_Customer";
            this.btn_History_Limit_To_Customer.Size = new System.Drawing.Size(285, 58);
            this.btn_History_Limit_To_Customer.TabIndex = 102;
            this.btn_History_Limit_To_Customer.Text = "Rajoita varaushistoria asiakkaaseen";
            this.btn_History_Limit_To_Customer.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btn_History_Limit_To_Office, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_History_Office, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbo_History_Office_Select, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 473);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(285, 119);
            this.tableLayoutPanel1.TabIndex = 103;
            // 
            // btn_History_Limit_To_Office
            // 
            this.btn_History_Limit_To_Office.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_History_Limit_To_Office.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_History_Limit_To_Office.Location = new System.Drawing.Point(3, 58);
            this.btn_History_Limit_To_Office.Name = "btn_History_Limit_To_Office";
            this.btn_History_Limit_To_Office.Size = new System.Drawing.Size(279, 57);
            this.btn_History_Limit_To_Office.TabIndex = 106;
            this.btn_History_Limit_To_Office.Text = "Rajoita varaushistoria toimipisteeseen";
            this.btn_History_Limit_To_Office.UseVisualStyleBackColor = true;
            // 
            // lbl_History_Office
            // 
            this.lbl_History_Office.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_History_Office.AutoSize = true;
            this.lbl_History_Office.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_History_Office.Location = new System.Drawing.Point(3, 0);
            this.lbl_History_Office.Name = "lbl_History_Office";
            this.lbl_History_Office.Size = new System.Drawing.Size(167, 20);
            this.lbl_History_Office.TabIndex = 104;
            this.lbl_History_Office.Text = "Toimipisteen valinta";
            // 
            // cbo_History_Office_Select
            // 
            this.cbo_History_Office_Select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_History_Office_Select.DataSource = this.toimipisteBindingSource;
            this.cbo_History_Office_Select.DisplayMember = "nimi";
            this.cbo_History_Office_Select.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_History_Office_Select.FormattingEnabled = true;
            this.cbo_History_Office_Select.Location = new System.Drawing.Point(3, 23);
            this.cbo_History_Office_Select.Name = "cbo_History_Office_Select";
            this.cbo_History_Office_Select.Size = new System.Drawing.Size(279, 28);
            this.cbo_History_Office_Select.TabIndex = 105;
            // 
            // dgv_History_Customers_All
            // 
            this.dgv_History_Customers_All.AllowUserToAddRows = false;
            this.dgv_History_Customers_All.AllowUserToDeleteRows = false;
            this.dgv_History_Customers_All.AllowUserToResizeColumns = false;
            this.dgv_History_Customers_All.AllowUserToResizeRows = false;
            this.dgv_History_Customers_All.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_History_Customers_All.AutoGenerateColumns = false;
            this.dgv_History_Customers_All.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_History_Customers_All.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_History_Customers_All.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_History_Customers_All.ColumnHeadersVisible = false;
            this.dgv_History_Customers_All.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kokonimiDataGridViewTextBoxColumn1});
            this.dgv_History_Customers_All.DataSource = this.asiakasBindingSource3;
            this.dgv_History_Customers_All.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_History_Customers_All.Location = new System.Drawing.Point(9, 38);
            this.dgv_History_Customers_All.Name = "dgv_History_Customers_All";
            this.dgv_History_Customers_All.ReadOnly = true;
            this.dgv_History_Customers_All.RowHeadersVisible = false;
            this.dgv_History_Customers_All.Size = new System.Drawing.Size(285, 320);
            this.dgv_History_Customers_All.TabIndex = 108;
            // 
            // kokonimiDataGridViewTextBoxColumn1
            // 
            this.kokonimiDataGridViewTextBoxColumn1.DataPropertyName = "kokonimi";
            this.kokonimiDataGridViewTextBoxColumn1.HeaderText = "kokonimi";
            this.kokonimiDataGridViewTextBoxColumn1.Name = "kokonimiDataGridViewTextBoxColumn1";
            this.kokonimiDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // asiakasBindingSource3
            // 
            this.asiakasBindingSource3.DataMember = "Asiakas";
            this.asiakasBindingSource3.DataSource = this.vP_DatabaseDataSet4;
            // 
            // vP_DatabaseDataSet4
            // 
            this.vP_DatabaseDataSet4.DataSetName = "VP_DatabaseDataSet4";
            this.vP_DatabaseDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_History_2nd_Col_Orders_Dates
            // 
            this.tbl_History_2nd_Col_Orders_Dates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_History_2nd_Col_Orders_Dates.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbl_History_2nd_Col_Orders_Dates.ColumnCount = 3;
            this.tbl_History_2nd_Col_Orders_Dates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tbl_History_2nd_Col_Orders_Dates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96F));
            this.tbl_History_2nd_Col_Orders_Dates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tbl_History_2nd_Col_Orders_Dates.Controls.Add(this.tbl_History_Order_History, 1, 2);
            this.tbl_History_2nd_Col_Orders_Dates.Location = new System.Drawing.Point(332, 15);
            this.tbl_History_2nd_Col_Orders_Dates.Name = "tbl_History_2nd_Col_Orders_Dates";
            this.tbl_History_2nd_Col_Orders_Dates.RowCount = 4;
            this.tbl_History_2nd_Col_Orders_Dates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tbl_History_2nd_Col_Orders_Dates.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_History_2nd_Col_Orders_Dates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_History_2nd_Col_Orders_Dates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tbl_History_2nd_Col_Orders_Dates.Size = new System.Drawing.Size(304, 610);
            this.tbl_History_2nd_Col_Orders_Dates.TabIndex = 1;
            // 
            // tbl_History_Order_History
            // 
            this.tbl_History_Order_History.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_History_Order_History.ColumnCount = 1;
            this.tbl_History_Order_History.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_History_Order_History.Controls.Add(this.lbl_History_Orders, 0, 0);
            this.tbl_History_Order_History.Controls.Add(this.lsv_History_Orders, 0, 1);
            this.tbl_History_Order_History.Controls.Add(this.tbl_History_Order_Search, 0, 2);
            this.tbl_History_Order_History.Controls.Add(this.tbl_History_Order_Dates_Delete, 0, 3);
            this.tbl_History_Order_History.Location = new System.Drawing.Point(9, 17);
            this.tbl_History_Order_History.Name = "tbl_History_Order_History";
            this.tbl_History_Order_History.RowCount = 4;
            this.tbl_History_Order_History.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_History_Order_History.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_History_Order_History.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tbl_History_Order_History.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_History_Order_History.Size = new System.Drawing.Size(285, 573);
            this.tbl_History_Order_History.TabIndex = 1;
            // 
            // lbl_History_Orders
            // 
            this.lbl_History_Orders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_History_Orders.AutoSize = true;
            this.lbl_History_Orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_History_Orders.Location = new System.Drawing.Point(3, 0);
            this.lbl_History_Orders.Name = "lbl_History_Orders";
            this.lbl_History_Orders.Size = new System.Drawing.Size(125, 20);
            this.lbl_History_Orders.TabIndex = 78;
            this.lbl_History_Orders.Text = "Varaushistoria";
            // 
            // lsv_History_Orders
            // 
            this.lsv_History_Orders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsv_History_Orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lsv_History_Orders.Location = new System.Drawing.Point(3, 23);
            this.lsv_History_Orders.Name = "lsv_History_Orders";
            this.lsv_History_Orders.Size = new System.Drawing.Size(279, 443);
            this.lsv_History_Orders.TabIndex = 100;
            this.lsv_History_Orders.UseCompatibleStateImageBehavior = false;
            // 
            // tbl_History_Order_Search
            // 
            this.tbl_History_Order_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_History_Order_Search.ColumnCount = 2;
            this.tbl_History_Order_Search.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_History_Order_Search.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tbl_History_Order_Search.Controls.Add(this.btn_History_Order_Search, 0, 0);
            this.tbl_History_Order_Search.Controls.Add(this.txt_History_Order_Search, 0, 0);
            this.tbl_History_Order_Search.Location = new System.Drawing.Point(3, 472);
            this.tbl_History_Order_Search.Name = "tbl_History_Order_Search";
            this.tbl_History_Order_Search.RowCount = 1;
            this.tbl_History_Order_Search.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_History_Order_Search.Size = new System.Drawing.Size(279, 36);
            this.tbl_History_Order_Search.TabIndex = 101;
            // 
            // btn_History_Order_Search
            // 
            this.btn_History_Order_Search.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_History_Order_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_History_Order_Search.BackgroundImage")));
            this.btn_History_Order_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_History_Order_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_History_Order_Search.Location = new System.Drawing.Point(244, 3);
            this.btn_History_Order_Search.Name = "btn_History_Order_Search";
            this.btn_History_Order_Search.Size = new System.Drawing.Size(32, 30);
            this.btn_History_Order_Search.TabIndex = 102;
            this.btn_History_Order_Search.UseVisualStyleBackColor = true;
            // 
            // txt_History_Order_Search
            // 
            this.txt_History_Order_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_History_Order_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_History_Order_Search.Location = new System.Drawing.Point(3, 5);
            this.txt_History_Order_Search.Name = "txt_History_Order_Search";
            this.txt_History_Order_Search.Size = new System.Drawing.Size(233, 26);
            this.txt_History_Order_Search.TabIndex = 101;
            // 
            // tbl_History_Order_Dates_Delete
            // 
            this.tbl_History_Order_Dates_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_History_Order_Dates_Delete.ColumnCount = 1;
            this.tbl_History_Order_Dates_Delete.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.28674F));
            this.tbl_History_Order_Dates_Delete.Controls.Add(this.tbl_History_Order_Dates, 0, 0);
            this.tbl_History_Order_Dates_Delete.Location = new System.Drawing.Point(3, 514);
            this.tbl_History_Order_Dates_Delete.Name = "tbl_History_Order_Dates_Delete";
            this.tbl_History_Order_Dates_Delete.RowCount = 1;
            this.tbl_History_Order_Dates_Delete.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tbl_History_Order_Dates_Delete.Size = new System.Drawing.Size(279, 56);
            this.tbl_History_Order_Dates_Delete.TabIndex = 102;
            // 
            // tbl_History_Order_Dates
            // 
            this.tbl_History_Order_Dates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_History_Order_Dates.ColumnCount = 2;
            this.tbl_History_Order_Dates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_History_Order_Dates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_History_Order_Dates.Controls.Add(this.lbl_History_Orders_Filter_Date_End, 1, 0);
            this.tbl_History_Order_Dates.Controls.Add(this.lbl_History_Orders_Filter_Date_Start, 0, 0);
            this.tbl_History_Order_Dates.Controls.Add(this.dtp_History_Orders_Filter_Date_Start, 0, 1);
            this.tbl_History_Order_Dates.Controls.Add(this.dtp_History_Orders_Filter_Date_End, 1, 1);
            this.tbl_History_Order_Dates.Location = new System.Drawing.Point(3, 3);
            this.tbl_History_Order_Dates.Name = "tbl_History_Order_Dates";
            this.tbl_History_Order_Dates.RowCount = 2;
            this.tbl_History_Order_Dates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.85185F));
            this.tbl_History_Order_Dates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.14815F));
            this.tbl_History_Order_Dates.Size = new System.Drawing.Size(273, 66);
            this.tbl_History_Order_Dates.TabIndex = 111;
            // 
            // lbl_History_Orders_Filter_Date_End
            // 
            this.lbl_History_Orders_Filter_Date_End.AutoSize = true;
            this.lbl_History_Orders_Filter_Date_End.Location = new System.Drawing.Point(139, 0);
            this.lbl_History_Orders_Filter_Date_End.Name = "lbl_History_Orders_Filter_Date_End";
            this.lbl_History_Orders_Filter_Date_End.Size = new System.Drawing.Size(72, 17);
            this.lbl_History_Orders_Filter_Date_End.TabIndex = 1;
            this.lbl_History_Orders_Filter_Date_End.Text = "Pvm. asti";
            // 
            // lbl_History_Orders_Filter_Date_Start
            // 
            this.lbl_History_Orders_Filter_Date_Start.AutoSize = true;
            this.lbl_History_Orders_Filter_Date_Start.Location = new System.Drawing.Point(3, 0);
            this.lbl_History_Orders_Filter_Date_Start.Name = "lbl_History_Orders_Filter_Date_Start";
            this.lbl_History_Orders_Filter_Date_Start.Size = new System.Drawing.Size(94, 17);
            this.lbl_History_Orders_Filter_Date_Start.TabIndex = 0;
            this.lbl_History_Orders_Filter_Date_Start.Text = "Pvm. alkaen";
            // 
            // dtp_History_Orders_Filter_Date_Start
            // 
            this.dtp_History_Orders_Filter_Date_Start.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_History_Orders_Filter_Date_Start.Location = new System.Drawing.Point(3, 20);
            this.dtp_History_Orders_Filter_Date_Start.Name = "dtp_History_Orders_Filter_Date_Start";
            this.dtp_History_Orders_Filter_Date_Start.Size = new System.Drawing.Size(130, 26);
            this.dtp_History_Orders_Filter_Date_Start.TabIndex = 2;
            this.dtp_History_Orders_Filter_Date_Start.Value = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            // 
            // dtp_History_Orders_Filter_Date_End
            // 
            this.dtp_History_Orders_Filter_Date_End.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_History_Orders_Filter_Date_End.Location = new System.Drawing.Point(139, 20);
            this.dtp_History_Orders_Filter_Date_End.Name = "dtp_History_Orders_Filter_Date_End";
            this.dtp_History_Orders_Filter_Date_End.Size = new System.Drawing.Size(131, 26);
            this.dtp_History_Orders_Filter_Date_End.TabIndex = 3;
            this.dtp_History_Orders_Filter_Date_End.Value = new System.DateTime(2017, 4, 8, 16, 25, 31, 0);
            // 
            // tbl_History_3th_Col_Selected_Order_Details
            // 
            this.tbl_History_3th_Col_Selected_Order_Details.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_History_3th_Col_Selected_Order_Details.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbl_History_3th_Col_Selected_Order_Details.ColumnCount = 3;
            this.tbl_History_3th_Col_Selected_Order_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tbl_History_3th_Col_Selected_Order_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96F));
            this.tbl_History_3th_Col_Selected_Order_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tbl_History_3th_Col_Selected_Order_Details.Controls.Add(this.lsv_History_Order_Additional_Details, 1, 11);
            this.tbl_History_3th_Col_Selected_Order_Details.Controls.Add(this.lbl_History_Order_Additional_Details, 1, 10);
            this.tbl_History_3th_Col_Selected_Order_Details.Controls.Add(this.lsv_History_Order_Services, 1, 9);
            this.tbl_History_3th_Col_Selected_Order_Details.Controls.Add(this.lbl_History_Order_Services, 1, 8);
            this.tbl_History_3th_Col_Selected_Order_Details.Controls.Add(this.lbl_History_Cottage_Details, 1, 2);
            this.tbl_History_3th_Col_Selected_Order_Details.Controls.Add(this.lsv_History_Cottage_Details, 1, 3);
            this.tbl_History_3th_Col_Selected_Order_Details.Controls.Add(this.lbl_History_Order_Start, 1, 4);
            this.tbl_History_3th_Col_Selected_Order_Details.Controls.Add(this.lbl_History_Order_End, 1, 5);
            this.tbl_History_3th_Col_Selected_Order_Details.Controls.Add(this.lbl_History_Selected_Order_Customers, 1, 6);
            this.tbl_History_3th_Col_Selected_Order_Details.Controls.Add(this.lsv_History_Selected_Order_Customers, 1, 7);
            this.tbl_History_3th_Col_Selected_Order_Details.Controls.Add(this.tbl_History_Order_Details_Delete, 1, 1);
            this.tbl_History_3th_Col_Selected_Order_Details.Location = new System.Drawing.Point(642, 15);
            this.tbl_History_3th_Col_Selected_Order_Details.Name = "tbl_History_3th_Col_Selected_Order_Details";
            this.tbl_History_3th_Col_Selected_Order_Details.RowCount = 13;
            this.tbl_History_3th_Col_Selected_Order_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tbl_History_3th_Col_Selected_Order_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tbl_History_3th_Col_Selected_Order_Details.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_History_3th_Col_Selected_Order_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbl_History_3th_Col_Selected_Order_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tbl_History_3th_Col_Selected_Order_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tbl_History_3th_Col_Selected_Order_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tbl_History_3th_Col_Selected_Order_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbl_History_3th_Col_Selected_Order_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tbl_History_3th_Col_Selected_Order_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbl_History_3th_Col_Selected_Order_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tbl_History_3th_Col_Selected_Order_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbl_History_3th_Col_Selected_Order_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tbl_History_3th_Col_Selected_Order_Details.Size = new System.Drawing.Size(304, 610);
            this.tbl_History_3th_Col_Selected_Order_Details.TabIndex = 3;
            // 
            // lsv_History_Order_Additional_Details
            // 
            this.lsv_History_Order_Additional_Details.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsv_History_Order_Additional_Details.Location = new System.Drawing.Point(9, 505);
            this.lsv_History_Order_Additional_Details.Name = "lsv_History_Order_Additional_Details";
            this.lsv_History_Order_Additional_Details.Size = new System.Drawing.Size(285, 85);
            this.lsv_History_Order_Additional_Details.TabIndex = 104;
            this.lsv_History_Order_Additional_Details.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_History_Order_Additional_Details
            // 
            this.lbl_History_Order_Additional_Details.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_History_Order_Additional_Details.AutoSize = true;
            this.lbl_History_Order_Additional_Details.Location = new System.Drawing.Point(9, 482);
            this.lbl_History_Order_Additional_Details.Name = "lbl_History_Order_Additional_Details";
            this.lbl_History_Order_Additional_Details.Size = new System.Drawing.Size(78, 20);
            this.lbl_History_Order_Additional_Details.TabIndex = 104;
            this.lbl_History_Order_Additional_Details.Text = "Lisätiedot";
            // 
            // lsv_History_Order_Services
            // 
            this.lsv_History_Order_Services.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsv_History_Order_Services.Location = new System.Drawing.Point(9, 384);
            this.lsv_History_Order_Services.Name = "lsv_History_Order_Services";
            this.lsv_History_Order_Services.Size = new System.Drawing.Size(285, 85);
            this.lsv_History_Order_Services.TabIndex = 103;
            this.lsv_History_Order_Services.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_History_Order_Services
            // 
            this.lbl_History_Order_Services.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_History_Order_Services.AutoSize = true;
            this.lbl_History_Order_Services.Location = new System.Drawing.Point(9, 361);
            this.lbl_History_Order_Services.Name = "lbl_History_Order_Services";
            this.lbl_History_Order_Services.Size = new System.Drawing.Size(64, 20);
            this.lbl_History_Order_Services.TabIndex = 103;
            this.lbl_History_Order_Services.Text = "Palvelut";
            // 
            // lbl_History_Cottage_Details
            // 
            this.lbl_History_Cottage_Details.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_History_Cottage_Details.AutoSize = true;
            this.lbl_History_Cottage_Details.Location = new System.Drawing.Point(9, 59);
            this.lbl_History_Cottage_Details.Name = "lbl_History_Cottage_Details";
            this.lbl_History_Cottage_Details.Size = new System.Drawing.Size(68, 20);
            this.lbl_History_Cottage_Details.TabIndex = 79;
            this.lbl_History_Cottage_Details.Text = "Majoitus";
            // 
            // lsv_History_Cottage_Details
            // 
            this.lsv_History_Cottage_Details.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsv_History_Cottage_Details.Location = new System.Drawing.Point(9, 82);
            this.lsv_History_Cottage_Details.Name = "lsv_History_Cottage_Details";
            this.lsv_History_Cottage_Details.Size = new System.Drawing.Size(285, 85);
            this.lsv_History_Cottage_Details.TabIndex = 80;
            this.lsv_History_Cottage_Details.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_History_Order_Start
            // 
            this.lbl_History_Order_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_History_Order_Start.AutoSize = true;
            this.lbl_History_Order_Start.Location = new System.Drawing.Point(9, 176);
            this.lbl_History_Order_Start.Name = "lbl_History_Order_Start";
            this.lbl_History_Order_Start.Size = new System.Drawing.Size(105, 20);
            this.lbl_History_Order_Start.TabIndex = 81;
            this.lbl_History_Order_Start.Text = "Alkamispäivä:";
            // 
            // lbl_History_Order_End
            // 
            this.lbl_History_Order_End.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_History_Order_End.AutoSize = true;
            this.lbl_History_Order_End.Location = new System.Drawing.Point(9, 211);
            this.lbl_History_Order_End.Name = "lbl_History_Order_End";
            this.lbl_History_Order_End.Size = new System.Drawing.Size(119, 20);
            this.lbl_History_Order_End.TabIndex = 82;
            this.lbl_History_Order_End.Text = "Päättymispäivä:";
            // 
            // lbl_History_Selected_Order_Customers
            // 
            this.lbl_History_Selected_Order_Customers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_History_Selected_Order_Customers.AutoSize = true;
            this.lbl_History_Selected_Order_Customers.Location = new System.Drawing.Point(9, 241);
            this.lbl_History_Selected_Order_Customers.Name = "lbl_History_Selected_Order_Customers";
            this.lbl_History_Selected_Order_Customers.Size = new System.Drawing.Size(67, 20);
            this.lbl_History_Selected_Order_Customers.TabIndex = 83;
            this.lbl_History_Selected_Order_Customers.Text = "Henkilöt";
            // 
            // lsv_History_Selected_Order_Customers
            // 
            this.lsv_History_Selected_Order_Customers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsv_History_Selected_Order_Customers.Location = new System.Drawing.Point(9, 264);
            this.lsv_History_Selected_Order_Customers.Name = "lsv_History_Selected_Order_Customers";
            this.lsv_History_Selected_Order_Customers.Size = new System.Drawing.Size(285, 85);
            this.lsv_History_Selected_Order_Customers.TabIndex = 84;
            this.lsv_History_Selected_Order_Customers.UseCompatibleStateImageBehavior = false;
            // 
            // tbl_History_Order_Details_Delete
            // 
            this.tbl_History_Order_Details_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_History_Order_Details_Delete.ColumnCount = 2;
            this.tbl_History_Order_Details_Delete.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.26316F));
            this.tbl_History_Order_Details_Delete.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.73684F));
            this.tbl_History_Order_Details_Delete.Controls.Add(this.btn_History_Order_History_Delete, 0, 0);
            this.tbl_History_Order_Details_Delete.Controls.Add(this.lbl_History_Selected_Order_Details, 0, 0);
            this.tbl_History_Order_Details_Delete.Location = new System.Drawing.Point(9, 18);
            this.tbl_History_Order_Details_Delete.Name = "tbl_History_Order_Details_Delete";
            this.tbl_History_Order_Details_Delete.RowCount = 1;
            this.tbl_History_Order_Details_Delete.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_History_Order_Details_Delete.Size = new System.Drawing.Size(285, 38);
            this.tbl_History_Order_Details_Delete.TabIndex = 105;
            // 
            // btn_History_Order_History_Delete
            // 
            this.btn_History_Order_History_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_History_Order_History_Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_History_Order_History_Delete.BackgroundImage")));
            this.btn_History_Order_History_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_History_Order_History_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_History_Order_History_Delete.Location = new System.Drawing.Point(250, 3);
            this.btn_History_Order_History_Delete.Name = "btn_History_Order_History_Delete";
            this.btn_History_Order_History_Delete.Size = new System.Drawing.Size(32, 32);
            this.btn_History_Order_History_Delete.TabIndex = 114;
            this.btn_History_Order_History_Delete.UseVisualStyleBackColor = true;
            // 
            // lbl_History_Selected_Order_Details
            // 
            this.lbl_History_Selected_Order_Details.AutoSize = true;
            this.lbl_History_Selected_Order_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_History_Selected_Order_Details.Location = new System.Drawing.Point(3, 0);
            this.lbl_History_Selected_Order_Details.Name = "lbl_History_Selected_Order_Details";
            this.lbl_History_Selected_Order_Details.Size = new System.Drawing.Size(146, 20);
            this.lbl_History_Selected_Order_Details.TabIndex = 79;
            this.lbl_History_Selected_Order_Details.Text = "Varauksen tiedot";
            // 
            // tab_Settings
            // 
            this.tab_Settings.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tab_Settings.Controls.Add(this.tbl_Settings_Base);
            this.tab_Settings.Location = new System.Drawing.Point(4, 29);
            this.tab_Settings.Name = "tab_Settings";
            this.tab_Settings.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Settings.Size = new System.Drawing.Size(976, 648);
            this.tab_Settings.TabIndex = 3;
            this.tab_Settings.Text = "Asetukset";
            // 
            // tbl_Settings_Base
            // 
            this.tbl_Settings_Base.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_Settings_Base.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tbl_Settings_Base.ColumnCount = 5;
            this.tbl_Settings_Base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tbl_Settings_Base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tbl_Settings_Base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tbl_Settings_Base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tbl_Settings_Base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tbl_Settings_Base.Controls.Add(this.tbl_Settings_1st_Col_Common_Settings_Base, 1, 1);
            this.tbl_Settings_Base.Controls.Add(this.tbl_Settings_2nd_Col_UI_Settings_Base, 3, 1);
            this.tbl_Settings_Base.Location = new System.Drawing.Point(-4, 0);
            this.tbl_Settings_Base.Name = "tbl_Settings_Base";
            this.tbl_Settings_Base.RowCount = 3;
            this.tbl_Settings_Base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tbl_Settings_Base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tbl_Settings_Base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tbl_Settings_Base.Size = new System.Drawing.Size(983, 651);
            this.tbl_Settings_Base.TabIndex = 0;
            // 
            // tbl_Settings_1st_Col_Common_Settings_Base
            // 
            this.tbl_Settings_1st_Col_Common_Settings_Base.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_Settings_1st_Col_Common_Settings_Base.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbl_Settings_1st_Col_Common_Settings_Base.ColumnCount = 3;
            this.tbl_Settings_1st_Col_Common_Settings_Base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tbl_Settings_1st_Col_Common_Settings_Base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tbl_Settings_1st_Col_Common_Settings_Base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tbl_Settings_1st_Col_Common_Settings_Base.Controls.Add(this.tbl_Settings_1st_Col_Common_Settings, 1, 1);
            this.tbl_Settings_1st_Col_Common_Settings_Base.Location = new System.Drawing.Point(150, 100);
            this.tbl_Settings_1st_Col_Common_Settings_Base.Name = "tbl_Settings_1st_Col_Common_Settings_Base";
            this.tbl_Settings_1st_Col_Common_Settings_Base.RowCount = 3;
            this.tbl_Settings_1st_Col_Common_Settings_Base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tbl_Settings_1st_Col_Common_Settings_Base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94F));
            this.tbl_Settings_1st_Col_Common_Settings_Base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tbl_Settings_1st_Col_Common_Settings_Base.Size = new System.Drawing.Size(318, 449);
            this.tbl_Settings_1st_Col_Common_Settings_Base.TabIndex = 2;
            // 
            // tbl_Settings_1st_Col_Common_Settings
            // 
            this.tbl_Settings_1st_Col_Common_Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_Settings_1st_Col_Common_Settings.ColumnCount = 1;
            this.tbl_Settings_1st_Col_Common_Settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Settings_1st_Col_Common_Settings.Controls.Add(this.cbo_Common_Settings_Default_Office, 0, 2);
            this.tbl_Settings_1st_Col_Common_Settings.Controls.Add(this.lbl_Settings_Common_Settings, 0, 0);
            this.tbl_Settings_1st_Col_Common_Settings.Controls.Add(this.lbl_Common_Settings_Default_Office, 0, 1);
            this.tbl_Settings_1st_Col_Common_Settings.Controls.Add(this.lbl_Common_Settings_History_Start_Date, 0, 3);
            this.tbl_Settings_1st_Col_Common_Settings.Controls.Add(this.dtp_Common_Settings_History_Start_Date, 0, 4);
            this.tbl_Settings_1st_Col_Common_Settings.Controls.Add(this.lbl_Common_Settings_History_End_Date, 0, 6);
            this.tbl_Settings_1st_Col_Common_Settings.Controls.Add(this.tbl_Common_Settings_History_End_Date_Today, 0, 7);
            this.tbl_Settings_1st_Col_Common_Settings.Controls.Add(this.dtp_Common_Settings_History_End_Date_Custom, 0, 9);
            this.tbl_Settings_1st_Col_Common_Settings.Controls.Add(this.lbl_Common_Settings_History_End_Date_Custom, 0, 8);
            this.tbl_Settings_1st_Col_Common_Settings.Location = new System.Drawing.Point(15, 16);
            this.tbl_Settings_1st_Col_Common_Settings.Name = "tbl_Settings_1st_Col_Common_Settings";
            this.tbl_Settings_1st_Col_Common_Settings.RowCount = 11;
            this.tbl_Settings_1st_Col_Common_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.16155F));
            this.tbl_Settings_1st_Col_Common_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.89832F));
            this.tbl_Settings_1st_Col_Common_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.49577F));
            this.tbl_Settings_1st_Col_Common_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.46831F));
            this.tbl_Settings_1st_Col_Common_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.29506F));
            this.tbl_Settings_1st_Col_Common_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.680984F));
            this.tbl_Settings_1st_Col_Common_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tbl_Settings_1st_Col_Common_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_Settings_1st_Col_Common_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_Settings_1st_Col_Common_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_Settings_1st_Col_Common_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tbl_Settings_1st_Col_Common_Settings.Size = new System.Drawing.Size(286, 416);
            this.tbl_Settings_1st_Col_Common_Settings.TabIndex = 0;
            // 
            // cbo_Common_Settings_Default_Office
            // 
            this.cbo_Common_Settings_Default_Office.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_Common_Settings_Default_Office.DataSource = this.toimipisteBindingSource;
            this.cbo_Common_Settings_Default_Office.DisplayMember = "nimi";
            this.cbo_Common_Settings_Default_Office.FormattingEnabled = true;
            this.cbo_Common_Settings_Default_Office.Location = new System.Drawing.Point(3, 93);
            this.cbo_Common_Settings_Default_Office.Name = "cbo_Common_Settings_Default_Office";
            this.cbo_Common_Settings_Default_Office.Size = new System.Drawing.Size(280, 28);
            this.cbo_Common_Settings_Default_Office.TabIndex = 16;
            this.cbo_Common_Settings_Default_Office.SelectedIndexChanged += new System.EventHandler(this.cbo_Common_Settings_Default_Office_SelectedIndexChanged);
            // 
            // lbl_Settings_Common_Settings
            // 
            this.lbl_Settings_Common_Settings.AutoSize = true;
            this.lbl_Settings_Common_Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Settings_Common_Settings.Location = new System.Drawing.Point(3, 0);
            this.lbl_Settings_Common_Settings.Name = "lbl_Settings_Common_Settings";
            this.lbl_Settings_Common_Settings.Size = new System.Drawing.Size(148, 20);
            this.lbl_Settings_Common_Settings.TabIndex = 0;
            this.lbl_Settings_Common_Settings.Text = "Yleiset asetukset";
            // 
            // lbl_Common_Settings_Default_Office
            // 
            this.lbl_Common_Settings_Default_Office.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Common_Settings_Default_Office.AutoSize = true;
            this.lbl_Common_Settings_Default_Office.Location = new System.Drawing.Point(3, 70);
            this.lbl_Common_Settings_Default_Office.Name = "lbl_Common_Settings_Default_Office";
            this.lbl_Common_Settings_Default_Office.Size = new System.Drawing.Size(122, 20);
            this.lbl_Common_Settings_Default_Office.TabIndex = 1;
            this.lbl_Common_Settings_Default_Office.Text = "Oletustoimipiste";
            // 
            // lbl_Common_Settings_History_Start_Date
            // 
            this.lbl_Common_Settings_History_Start_Date.AutoSize = true;
            this.lbl_Common_Settings_History_Start_Date.Location = new System.Drawing.Point(3, 139);
            this.lbl_Common_Settings_History_Start_Date.Name = "lbl_Common_Settings_History_Start_Date";
            this.lbl_Common_Settings_History_Start_Date.Size = new System.Drawing.Size(214, 20);
            this.lbl_Common_Settings_History_Start_Date.TabIndex = 17;
            this.lbl_Common_Settings_History_Start_Date.Text = "Varaushistorian alkamispäivä";
            // 
            // dtp_Common_Settings_History_Start_Date
            // 
            this.dtp_Common_Settings_History_Start_Date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_Common_Settings_History_Start_Date.Location = new System.Drawing.Point(3, 175);
            this.dtp_Common_Settings_History_Start_Date.Name = "dtp_Common_Settings_History_Start_Date";
            this.dtp_Common_Settings_History_Start_Date.Size = new System.Drawing.Size(280, 26);
            this.dtp_Common_Settings_History_Start_Date.TabIndex = 18;
            this.dtp_Common_Settings_History_Start_Date.Value = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dtp_Common_Settings_History_Start_Date.ValueChanged += new System.EventHandler(this.dtp_Common_Settings_History_Start_Date_ValueChanged);
            // 
            // lbl_Common_Settings_History_End_Date
            // 
            this.lbl_Common_Settings_History_End_Date.AutoSize = true;
            this.lbl_Common_Settings_History_End_Date.Location = new System.Drawing.Point(3, 226);
            this.lbl_Common_Settings_History_End_Date.Name = "lbl_Common_Settings_History_End_Date";
            this.lbl_Common_Settings_History_End_Date.Size = new System.Drawing.Size(229, 20);
            this.lbl_Common_Settings_History_End_Date.TabIndex = 19;
            this.lbl_Common_Settings_History_End_Date.Text = "Varaushistorian päättymispäivä";
            // 
            // tbl_Common_Settings_History_End_Date_Today
            // 
            this.tbl_Common_Settings_History_End_Date_Today.ColumnCount = 2;
            this.tbl_Common_Settings_History_End_Date_Today.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.42857F));
            this.tbl_Common_Settings_History_End_Date_Today.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.57143F));
            this.tbl_Common_Settings_History_End_Date_Today.Controls.Add(this.lbl_Common_Settings_History_End_Date_Today, 0, 0);
            this.tbl_Common_Settings_History_End_Date_Today.Controls.Add(this.chk_Common_Settings_History_End_Date_Today, 1, 0);
            this.tbl_Common_Settings_History_End_Date_Today.Location = new System.Drawing.Point(3, 259);
            this.tbl_Common_Settings_History_End_Date_Today.Name = "tbl_Common_Settings_History_End_Date_Today";
            this.tbl_Common_Settings_History_End_Date_Today.RowCount = 1;
            this.tbl_Common_Settings_History_End_Date_Today.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Common_Settings_History_End_Date_Today.Size = new System.Drawing.Size(280, 55);
            this.tbl_Common_Settings_History_End_Date_Today.TabIndex = 22;
            // 
            // lbl_Common_Settings_History_End_Date_Today
            // 
            this.lbl_Common_Settings_History_End_Date_Today.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Common_Settings_History_End_Date_Today.AutoSize = true;
            this.lbl_Common_Settings_History_End_Date_Today.Location = new System.Drawing.Point(3, 17);
            this.lbl_Common_Settings_History_End_Date_Today.Name = "lbl_Common_Settings_History_End_Date_Today";
            this.lbl_Common_Settings_History_End_Date_Today.Size = new System.Drawing.Size(163, 20);
            this.lbl_Common_Settings_History_End_Date_Today.TabIndex = 0;
            this.lbl_Common_Settings_History_End_Date_Today.Text = "Käytä nykyistä päivää:";
            // 
            // chk_Common_Settings_History_End_Date_Today
            // 
            this.chk_Common_Settings_History_End_Date_Today.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chk_Common_Settings_History_End_Date_Today.AutoSize = true;
            this.chk_Common_Settings_History_End_Date_Today.Checked = true;
            this.chk_Common_Settings_History_End_Date_Today.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Common_Settings_History_End_Date_Today.Location = new System.Drawing.Point(174, 20);
            this.chk_Common_Settings_History_End_Date_Today.Name = "chk_Common_Settings_History_End_Date_Today";
            this.chk_Common_Settings_History_End_Date_Today.Size = new System.Drawing.Size(15, 14);
            this.chk_Common_Settings_History_End_Date_Today.TabIndex = 1;
            this.chk_Common_Settings_History_End_Date_Today.UseVisualStyleBackColor = true;
            this.chk_Common_Settings_History_End_Date_Today.CheckedChanged += new System.EventHandler(this.chk_Common_Settings_History_End_Date_Today_CheckedChanged);
            // 
            // dtp_Common_Settings_History_End_Date_Custom
            // 
            this.dtp_Common_Settings_History_End_Date_Custom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_Common_Settings_History_End_Date_Custom.Location = new System.Drawing.Point(3, 340);
            this.dtp_Common_Settings_History_End_Date_Custom.Name = "dtp_Common_Settings_History_End_Date_Custom";
            this.dtp_Common_Settings_History_End_Date_Custom.Size = new System.Drawing.Size(280, 26);
            this.dtp_Common_Settings_History_End_Date_Custom.TabIndex = 21;
            this.dtp_Common_Settings_History_End_Date_Custom.ValueChanged += new System.EventHandler(this.dtp_Common_Settings_History_End_Date_Custom_ValueChanged);
            // 
            // lbl_Common_Settings_History_End_Date_Custom
            // 
            this.lbl_Common_Settings_History_End_Date_Custom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Common_Settings_History_End_Date_Custom.AutoSize = true;
            this.lbl_Common_Settings_History_End_Date_Custom.Location = new System.Drawing.Point(3, 317);
            this.lbl_Common_Settings_History_End_Date_Custom.Name = "lbl_Common_Settings_History_End_Date_Custom";
            this.lbl_Common_Settings_History_End_Date_Custom.Size = new System.Drawing.Size(176, 20);
            this.lbl_Common_Settings_History_End_Date_Custom.TabIndex = 23;
            this.lbl_Common_Settings_History_End_Date_Custom.Text = "Mukautettu päivämäärä";
            // 
            // tbl_Settings_2nd_Col_UI_Settings_Base
            // 
            this.tbl_Settings_2nd_Col_UI_Settings_Base.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_Settings_2nd_Col_UI_Settings_Base.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbl_Settings_2nd_Col_UI_Settings_Base.ColumnCount = 3;
            this.tbl_Settings_2nd_Col_UI_Settings_Base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tbl_Settings_2nd_Col_UI_Settings_Base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tbl_Settings_2nd_Col_UI_Settings_Base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tbl_Settings_2nd_Col_UI_Settings_Base.Controls.Add(this.tbl_Settings_2nd_Col_UI_Settings, 1, 1);
            this.tbl_Settings_2nd_Col_UI_Settings_Base.Location = new System.Drawing.Point(513, 100);
            this.tbl_Settings_2nd_Col_UI_Settings_Base.Name = "tbl_Settings_2nd_Col_UI_Settings_Base";
            this.tbl_Settings_2nd_Col_UI_Settings_Base.RowCount = 3;
            this.tbl_Settings_2nd_Col_UI_Settings_Base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tbl_Settings_2nd_Col_UI_Settings_Base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94F));
            this.tbl_Settings_2nd_Col_UI_Settings_Base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tbl_Settings_2nd_Col_UI_Settings_Base.Size = new System.Drawing.Size(318, 449);
            this.tbl_Settings_2nd_Col_UI_Settings_Base.TabIndex = 3;
            // 
            // tbl_Settings_2nd_Col_UI_Settings
            // 
            this.tbl_Settings_2nd_Col_UI_Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_Settings_2nd_Col_UI_Settings.ColumnCount = 1;
            this.tbl_Settings_2nd_Col_UI_Settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Settings_2nd_Col_UI_Settings.Controls.Add(this.cbo_UI_Settings_Language, 0, 2);
            this.tbl_Settings_2nd_Col_UI_Settings.Controls.Add(this.lbl_Settings_UI_Settings, 0, 0);
            this.tbl_Settings_2nd_Col_UI_Settings.Controls.Add(this.lbl_UI_Settings_Language, 0, 1);
            this.tbl_Settings_2nd_Col_UI_Settings.Controls.Add(this.lbl_UI_Settings_Font_Size, 0, 3);
            this.tbl_Settings_2nd_Col_UI_Settings.Controls.Add(this.cbo_UI_Settings_Font_Size, 0, 4);
            this.tbl_Settings_2nd_Col_UI_Settings.Location = new System.Drawing.Point(15, 16);
            this.tbl_Settings_2nd_Col_UI_Settings.Name = "tbl_Settings_2nd_Col_UI_Settings";
            this.tbl_Settings_2nd_Col_UI_Settings.RowCount = 6;
            this.tbl_Settings_2nd_Col_UI_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.17949F));
            this.tbl_Settings_2nd_Col_UI_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.25641F));
            this.tbl_Settings_2nd_Col_UI_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.89744F));
            this.tbl_Settings_2nd_Col_UI_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.435897F));
            this.tbl_Settings_2nd_Col_UI_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.23077F));
            this.tbl_Settings_2nd_Col_UI_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tbl_Settings_2nd_Col_UI_Settings.Size = new System.Drawing.Size(286, 416);
            this.tbl_Settings_2nd_Col_UI_Settings.TabIndex = 1;
            // 
            // cbo_UI_Settings_Language
            // 
            this.cbo_UI_Settings_Language.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_UI_Settings_Language.FormattingEnabled = true;
            this.cbo_UI_Settings_Language.Location = new System.Drawing.Point(3, 110);
            this.cbo_UI_Settings_Language.Name = "cbo_UI_Settings_Language";
            this.cbo_UI_Settings_Language.Size = new System.Drawing.Size(280, 28);
            this.cbo_UI_Settings_Language.TabIndex = 16;
            this.cbo_UI_Settings_Language.Text = "Suomi";
            // 
            // lbl_Settings_UI_Settings
            // 
            this.lbl_Settings_UI_Settings.AutoSize = true;
            this.lbl_Settings_UI_Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Settings_UI_Settings.Location = new System.Drawing.Point(3, 0);
            this.lbl_Settings_UI_Settings.Name = "lbl_Settings_UI_Settings";
            this.lbl_Settings_UI_Settings.Size = new System.Drawing.Size(116, 20);
            this.lbl_Settings_UI_Settings.TabIndex = 0;
            this.lbl_Settings_UI_Settings.Text = "Käyttöliittymä";
            // 
            // lbl_UI_Settings_Language
            // 
            this.lbl_UI_Settings_Language.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_UI_Settings_Language.AutoSize = true;
            this.lbl_UI_Settings_Language.Location = new System.Drawing.Point(3, 87);
            this.lbl_UI_Settings_Language.Name = "lbl_UI_Settings_Language";
            this.lbl_UI_Settings_Language.Size = new System.Drawing.Size(37, 20);
            this.lbl_UI_Settings_Language.TabIndex = 1;
            this.lbl_UI_Settings_Language.Text = "Kieli";
            // 
            // lbl_UI_Settings_Font_Size
            // 
            this.lbl_UI_Settings_Font_Size.AutoSize = true;
            this.lbl_UI_Settings_Font_Size.Location = new System.Drawing.Point(3, 169);
            this.lbl_UI_Settings_Font_Size.Name = "lbl_UI_Settings_Font_Size";
            this.lbl_UI_Settings_Font_Size.Size = new System.Drawing.Size(163, 20);
            this.lbl_UI_Settings_Font_Size.TabIndex = 17;
            this.lbl_UI_Settings_Font_Size.Text = "Fonttikoko (oletus 12)";
            // 
            // cbo_UI_Settings_Font_Size
            // 
            this.cbo_UI_Settings_Font_Size.FormattingEnabled = true;
            this.cbo_UI_Settings_Font_Size.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26"});
            this.cbo_UI_Settings_Font_Size.Location = new System.Drawing.Point(3, 201);
            this.cbo_UI_Settings_Font_Size.Name = "cbo_UI_Settings_Font_Size";
            this.cbo_UI_Settings_Font_Size.Size = new System.Drawing.Size(64, 28);
            this.cbo_UI_Settings_Font_Size.TabIndex = 21;
            this.cbo_UI_Settings_Font_Size.Text = "12";
            // 
            // asiakasTableAdapter
            // 
            this.asiakasTableAdapter.ClearBeforeFill = true;
            // 
            // toimipisteTableAdapter
            // 
            this.toimipisteTableAdapter.ClearBeforeFill = true;
            // 
            // palveluTableAdapter
            // 
            this.palveluTableAdapter.ClearBeforeFill = true;
            // 
            // majoitusTableAdapter
            // 
            this.majoitusTableAdapter.ClearBeforeFill = true;
            // 
            // asiakasBindingSource2
            // 
            this.asiakasBindingSource2.DataMember = "Asiakas";
            this.asiakasBindingSource2.DataSource = this.vP_DatabaseDataSet;
            // 
            // asiakasTableAdapter1
            // 
            this.asiakasTableAdapter1.ClearBeforeFill = true;
            // 
            // frm_Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 681);
            this.Controls.Add(this.tab_Menu);
            this.Name = "frm_Main_Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MahtiMökit";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_window_Load);
            this.tab_Menu.ResumeLayout(false);
            this.tab_New_Order.ResumeLayout(false);
            this.tbl_Order_base.ResumeLayout(false);
            this.tbl_Order_1st_Col_Dates_Customers.ResumeLayout(false);
            this.tbl_Order_1st_Col_Dates.ResumeLayout(false);
            this.tbl_Order_1st_Col_Dates.PerformLayout();
            this.tbl_Order_Date_Selection.ResumeLayout(false);
            this.tbl_Order_Date_Selection.PerformLayout();
            this.tbl_Order_1st_Col_Customer.ResumeLayout(false);
            this.tbl_Order_1st_Col_Customer.PerformLayout();
            this.tbl_Order_Customer_Search.ResumeLayout(false);
            this.tbl_Order_Customer_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Order_Customers_All)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vP_DatabaseDataSet)).EndInit();
            this.tbl_Order_2nd_Col_Offices_Cottage.ResumeLayout(false);
            this.tbl_Order_2nd_Col_Offices_Cottage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Order_Cottages_All)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.majoitusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vP_DatabaseDataSet3)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toimipisteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vP_DatabaseDataSet1)).EndInit();
            this.tbl_Order_3rd_Col_Cottage_Summary_Services.ResumeLayout(false);
            this.tbl_Order_3rd_Col_Services.ResumeLayout(false);
            this.tbl_Order_3rd_Col_Services.PerformLayout();
            this.tbl_Order_3rd_Col_Services_Quantity.ResumeLayout(false);
            this.tbl_Order_3rd_Col_Services_Quantity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Order_Services_All)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vP_DatabaseDataSet2)).EndInit();
            this.tbl_4th_Col_Summary.ResumeLayout(false);
            this.tbl_4th_Col_Summary.PerformLayout();
            this.tbl_Order_Summary_Dates_Office.ResumeLayout(false);
            this.tbl_Order_Summary_Dates_Office.PerformLayout();
            this.tbl_Order_Summary_Customers_Cottages_Services.ResumeLayout(false);
            this.tbl_Order_Summary_Customers_Cottages_Services.PerformLayout();
            this.tbl_Order_Summary_Buttons.ResumeLayout(false);
            this.tab_Edit.ResumeLayout(false);
            this.tbl_Edit_base.ResumeLayout(false);
            this.tbl_Edit_1st_Col_Customers.ResumeLayout(false);
            this.tbl_Edit_1st_Col_Customers.PerformLayout();
            this.tbl_Edit_1st_Col_Customers_Search.ResumeLayout(false);
            this.tbl_Edit_1st_Col_Customers_Search.PerformLayout();
            this.tbl_Edit_1st_Col_Customers_Buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customers_All)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPDatabaseDataSetBindingSource)).EndInit();
            this.tbl_Edit_2nd_Col_Offices_Services.ResumeLayout(false);
            this.tbl_Edit_2nd_Col_Offices.ResumeLayout(false);
            this.tbl_Edit_2nd_Col_Offices.PerformLayout();
            this.tbl_Edit_2nd_Col_Offices_Buttons.ResumeLayout(false);
            this.tbl_Edit_2nd_Col_Services.ResumeLayout(false);
            this.tbl_Edit_2nd_Col_Services.PerformLayout();
            this.tbl_Edit_2nd_Col_Services_Search.ResumeLayout(false);
            this.tbl_Edit_2nd_Col_Services_Search.PerformLayout();
            this.tbl_Edit_2nd_Col_Services_Buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Services_All)).EndInit();
            this.tbl_Edit_3rd_Col_Cottages.ResumeLayout(false);
            this.tbl_Edit_3rd_Col_Cottages.PerformLayout();
            this.tbl_Edit_3rd_Col_Cottages_Search.ResumeLayout(false);
            this.tbl_Edit_3rd_Col_Cottages_Search.PerformLayout();
            this.tbl_Edit_3rd_Col_Cottages_Buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cottages_all)).EndInit();
            this.tab_History.ResumeLayout(false);
            this.tbl_History_Base.ResumeLayout(false);
            this.tbl_History_1st_Col_Customers_Offices.ResumeLayout(false);
            this.tbl_History_1st_Col_Customers_Offices.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_History_Customers_All)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vP_DatabaseDataSet4)).EndInit();
            this.tbl_History_2nd_Col_Orders_Dates.ResumeLayout(false);
            this.tbl_History_Order_History.ResumeLayout(false);
            this.tbl_History_Order_History.PerformLayout();
            this.tbl_History_Order_Search.ResumeLayout(false);
            this.tbl_History_Order_Search.PerformLayout();
            this.tbl_History_Order_Dates_Delete.ResumeLayout(false);
            this.tbl_History_Order_Dates.ResumeLayout(false);
            this.tbl_History_Order_Dates.PerformLayout();
            this.tbl_History_3th_Col_Selected_Order_Details.ResumeLayout(false);
            this.tbl_History_3th_Col_Selected_Order_Details.PerformLayout();
            this.tbl_History_Order_Details_Delete.ResumeLayout(false);
            this.tbl_History_Order_Details_Delete.PerformLayout();
            this.tab_Settings.ResumeLayout(false);
            this.tbl_Settings_Base.ResumeLayout(false);
            this.tbl_Settings_1st_Col_Common_Settings_Base.ResumeLayout(false);
            this.tbl_Settings_1st_Col_Common_Settings.ResumeLayout(false);
            this.tbl_Settings_1st_Col_Common_Settings.PerformLayout();
            this.tbl_Common_Settings_History_End_Date_Today.ResumeLayout(false);
            this.tbl_Common_Settings_History_End_Date_Today.PerformLayout();
            this.tbl_Settings_2nd_Col_UI_Settings_Base.ResumeLayout(false);
            this.tbl_Settings_2nd_Col_UI_Settings.ResumeLayout(false);
            this.tbl_Settings_2nd_Col_UI_Settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_Menu;
        private System.Windows.Forms.TabPage tab_Edit;
        private System.Windows.Forms.TabPage tab_History;
        private System.Windows.Forms.TabPage tab_Settings;
        private System.Windows.Forms.TabPage tab_New_Order;
        private System.Windows.Forms.TableLayoutPanel tbl_Order_base;
        private System.Windows.Forms.TableLayoutPanel tbl_Order_1st_Col_Dates_Customers;
        private System.Windows.Forms.TableLayoutPanel tbl_Order_Customers;
        private System.Windows.Forms.TableLayoutPanel tbl_Order_1st_Col_Dates;
        private System.Windows.Forms.TableLayoutPanel tbl_Order_1st_Col_Customer;
        private System.Windows.Forms.TableLayoutPanel tbl_Order_Customer_Search;
        private System.Windows.Forms.Button btn_Order_Customers_Search;
        private System.Windows.Forms.TextBox txt_Order_Customers_Search;
        private System.Windows.Forms.Label lbl_Order_Customers;
        private System.Windows.Forms.TableLayoutPanel tbl_Order_2nd_Col_Offices_Cottage;
        private System.Windows.Forms.Label lbl_Order_Cottage_Selection;
        private System.Windows.Forms.Button Btn_Order_Cottage_Add;
        private System.Windows.Forms.Button btn_Order_Customers_Add;
        private System.Windows.Forms.TableLayoutPanel tbl_Order_3rd_Col_Cottage_Summary_Services;
        private System.Windows.Forms.TableLayoutPanel tbl_4th_Col_Summary;
        private System.Windows.Forms.TableLayoutPanel tbl_Order_Summary_Dates_Office;
        private System.Windows.Forms.ListView lsv_Order_Summary_Customers;
        private System.Windows.Forms.Label lbl_Order_Summary;
        private System.Windows.Forms.Label lbl_Order_Summary_Office;
        private System.Windows.Forms.Label lbl_Order_Summary_Customers;
        private System.Windows.Forms.TableLayoutPanel tbl_Order_Summary_Customers_Cottages_Services;
        private System.Windows.Forms.Label lbl_Order_Summary_Cottages;
        private System.Windows.Forms.ListView lsv_Order_Summary_Cottages;
        private System.Windows.Forms.ListView lsv_Order_Summary_Services;
        private System.Windows.Forms.Label lbl_Order_Summary_Services;
        private System.Windows.Forms.TableLayoutPanel tbl_Edit_base;
        private System.Windows.Forms.TableLayoutPanel tbl_Edit_1st_Col_Customers;
        private System.Windows.Forms.Label lbl_Customer_Management;
        private System.Windows.Forms.TableLayoutPanel tbl_Edit_1st_Col_Customers_Search;
        private System.Windows.Forms.Button btn_Customer_Search;
        private System.Windows.Forms.TextBox txt_Customer_Search;
        private System.Windows.Forms.TableLayoutPanel tbl_Edit_1st_Col_Customers_Buttons;
        private System.Windows.Forms.Button btn_Customer_Delete;
        private System.Windows.Forms.Button btn_Customer_Edit;
        private System.Windows.Forms.Button btn_Customer_Add;
        private System.Windows.Forms.TableLayoutPanel tbl_Edit_2nd_Col_Offices_Services;
        private System.Windows.Forms.TableLayoutPanel tbl_Edit_2nd_Col_Offices;
        private System.Windows.Forms.Label lbl_Office;
        private System.Windows.Forms.TableLayoutPanel tbl_Edit_2nd_Col_Offices_Buttons;
        private System.Windows.Forms.Button btn_Office_Delete;
        private System.Windows.Forms.Button btn_Office_Edit;
        private System.Windows.Forms.Button btn_Office_Add;
        private System.Windows.Forms.TableLayoutPanel tbl_Edit_2nd_Col_Services;
        private System.Windows.Forms.Label lbl_Services;
        private System.Windows.Forms.TableLayoutPanel tbl_Edit_2nd_Col_Services_Search;
        private System.Windows.Forms.Button btn_Services_Search;
        private System.Windows.Forms.TextBox txt_Services_Search;
        private System.Windows.Forms.TableLayoutPanel tbl_Edit_2nd_Col_Services_Buttons;
        private System.Windows.Forms.Button btn_Services_Delete;
        private System.Windows.Forms.Button btn_Services_Edit;
        private System.Windows.Forms.Button btn_Services_Add;
        private System.Windows.Forms.TableLayoutPanel tbl_Edit_3rd_Col_Cottages;
        private System.Windows.Forms.Label lbl_Cottages;
        private System.Windows.Forms.TableLayoutPanel tbl_Edit_3rd_Col_Cottages_Search;
        private System.Windows.Forms.Button btn_Cottages_Search;
        private System.Windows.Forms.TextBox txt_Cottages_Search;
        private System.Windows.Forms.TableLayoutPanel tbl_Edit_3rd_Col_Cottages_Buttons;
        private System.Windows.Forms.Button btn_Cottages_Delete;
        private System.Windows.Forms.Button btn_Cottages_Edit;
        private System.Windows.Forms.Button btn_Cottages_Add;
        private System.Windows.Forms.TableLayoutPanel tbl_History_Base;
        private System.Windows.Forms.TableLayoutPanel tbl_History_1st_Col_Customers_Offices;
        private System.Windows.Forms.Label lbl_History_Customer_Selection;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btn_History_Customer_Search;
        private System.Windows.Forms.TextBox txt_History_Customer_Search;
        private System.Windows.Forms.TableLayoutPanel tbl_History_2nd_Col_Orders_Dates;
        private System.Windows.Forms.TableLayoutPanel tbl_History_Order_History;
        private System.Windows.Forms.Label lbl_History_Orders;
        private System.Windows.Forms.ListView lsv_History_Orders;
        private System.Windows.Forms.TableLayoutPanel tbl_History_Order_Search;
        private System.Windows.Forms.Button btn_History_Order_Search;
        private System.Windows.Forms.TextBox txt_History_Order_Search;
        private System.Windows.Forms.TableLayoutPanel tbl_History_Order_Dates_Delete;
        private System.Windows.Forms.Button btn_History_Limit_To_Customer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_History_Limit_To_Office;
        private System.Windows.Forms.Label lbl_History_Office;
        private System.Windows.Forms.TableLayoutPanel tbl_History_Order_Dates;
        private System.Windows.Forms.Label lbl_History_Orders_Filter_Date_End;
        private System.Windows.Forms.Label lbl_History_Orders_Filter_Date_Start;
        private System.Windows.Forms.DateTimePicker dtp_History_Orders_Filter_Date_Start;
        private System.Windows.Forms.DateTimePicker dtp_History_Orders_Filter_Date_End;
        private System.Windows.Forms.TableLayoutPanel tbl_History_3th_Col_Selected_Order_Details;
        private System.Windows.Forms.ListView lsv_History_Order_Additional_Details;
        private System.Windows.Forms.Label lbl_History_Order_Additional_Details;
        private System.Windows.Forms.ListView lsv_History_Order_Services;
        private System.Windows.Forms.Label lbl_History_Order_Services;
        private System.Windows.Forms.Label lbl_History_Cottage_Details;
        private System.Windows.Forms.ListView lsv_History_Cottage_Details;
        private System.Windows.Forms.Label lbl_History_Order_Start;
        private System.Windows.Forms.Label lbl_History_Order_End;
        private System.Windows.Forms.Label lbl_History_Selected_Order_Customers;
        private System.Windows.Forms.ListView lsv_History_Selected_Order_Customers;
        private System.Windows.Forms.TableLayoutPanel tbl_History_Order_Details_Delete;
        private System.Windows.Forms.Button btn_History_Order_History_Delete;
        private System.Windows.Forms.Label lbl_History_Selected_Order_Details;
        private System.Windows.Forms.Button btn_Order_Service_add;
        private System.Windows.Forms.TableLayoutPanel tbl_Order_3rd_Col_Services;
        private System.Windows.Forms.Label lbl_Order_Services;
        private System.Windows.Forms.TableLayoutPanel tbl_Order_3rd_Col_Services_Quantity;
        private System.Windows.Forms.TextBox txt_Order_Services_Quantity;
        private System.Windows.Forms.Label lbl_Order_Additional_Details;
        private System.Windows.Forms.TableLayoutPanel tbl_Order_Summary_Buttons;
        private System.Windows.Forms.Button btn_Order_Summary_Next_Page;
        private System.Windows.Forms.Button btn_Order_Summary_Delete_From_List;
        private System.Windows.Forms.TextBox txt_Order_Additional_Details;
        private System.Windows.Forms.TableLayoutPanel tbl_Settings_Base;
        private System.Windows.Forms.TableLayoutPanel tbl_Settings_1st_Col_Common_Settings_Base;
        private System.Windows.Forms.TableLayoutPanel tbl_Settings_2nd_Col_UI_Settings_Base;
        private System.Windows.Forms.TableLayoutPanel tbl_Settings_1st_Col_Common_Settings;
        private System.Windows.Forms.Label lbl_Settings_Common_Settings;
        private System.Windows.Forms.Label lbl_Common_Settings_Default_Office;
        private System.Windows.Forms.Label lbl_Common_Settings_History_Start_Date;
        private System.Windows.Forms.DateTimePicker dtp_Common_Settings_History_Start_Date;
        private System.Windows.Forms.Label lbl_Common_Settings_History_End_Date;
        private System.Windows.Forms.TableLayoutPanel tbl_Settings_2nd_Col_UI_Settings;
        private System.Windows.Forms.ComboBox cbo_UI_Settings_Language;
        private System.Windows.Forms.Label lbl_Settings_UI_Settings;
        private System.Windows.Forms.Label lbl_UI_Settings_Language;
        private System.Windows.Forms.Label lbl_UI_Settings_Font_Size;
        private System.Windows.Forms.ComboBox cbo_UI_Settings_Font_Size;
        private System.Windows.Forms.ComboBox cbo_Common_Settings_Default_Office;
        private System.Windows.Forms.ComboBox cbo_History_Office_Select;
        private System.Windows.Forms.ComboBox cbo_Office_Select;
        private System.Windows.Forms.TableLayoutPanel tbl_Common_Settings_History_End_Date_Today;
        private System.Windows.Forms.Label lbl_Common_Settings_History_End_Date_Today;
        private System.Windows.Forms.CheckBox chk_Common_Settings_History_End_Date_Today;
        private System.Windows.Forms.DateTimePicker dtp_Common_Settings_History_End_Date_Custom;
        private System.Windows.Forms.Label lbl_Common_Settings_History_End_Date_Custom;
        private System.Windows.Forms.DataGridView dgv_Order_Customers_All;
        private VP_DatabaseDataSet vP_DatabaseDataSet;
        private System.Windows.Forms.BindingSource asiakasBindingSource;
        private VP_DatabaseDataSetTableAdapters.AsiakasTableAdapter asiakasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kokonimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgv_Customers_All;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource vPDatabaseDataSetBindingSource;
        private System.Windows.Forms.BindingSource asiakasBindingSource1;
        private VP_DatabaseDataSet1 vP_DatabaseDataSet1;
        private System.Windows.Forms.BindingSource toimipisteBindingSource;
        private VP_DatabaseDataSet1TableAdapters.ToimipisteTableAdapter toimipisteTableAdapter;
        private System.Windows.Forms.DataGridView dgv_Services_All;
        private VP_DatabaseDataSet2 vP_DatabaseDataSet2;
        private System.Windows.Forms.BindingSource palveluBindingSource;
        private VP_DatabaseDataSet2TableAdapters.PalveluTableAdapter palveluTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgv_Order_Services_All;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dgv_Order_Cottages_All;
        private VP_DatabaseDataSet3 vP_DatabaseDataSet3;
        private System.Windows.Forms.BindingSource majoitusBindingSource;
        private VP_DatabaseDataSet3TableAdapters.MajoitusTableAdapter majoitusTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimiDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView dgv_Cottages_all;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView dgv_History_Customers_All;
        private System.Windows.Forms.DataGridViewTextBoxColumn kokonimiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource asiakasBindingSource2;
        private VP_DatabaseDataSet4 vP_DatabaseDataSet4;
        private System.Windows.Forms.BindingSource asiakasBindingSource3;
        private VP_DatabaseDataSet4TableAdapters.AsiakasTableAdapter asiakasTableAdapter1;
        private System.Windows.Forms.Button btn_Order_Services_Search;
        private System.Windows.Forms.TextBox txt_Order_Services_Search;
        private System.Windows.Forms.Label lbl_Order_Services_Quantity_Units;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_Order_Cottages_Search;
        private System.Windows.Forms.TextBox txt_Order_Cottages_Search;
        private System.Windows.Forms.TableLayoutPanel tbl_Order_Date_Selection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lbl_Order_Dates;
        private System.Windows.Forms.Label lbl_Order_Cottage;
        private System.Windows.Forms.Label lbl_Order_Office;
        private System.Windows.Forms.ComboBox cbo_Order_Office_Select;
        private System.Windows.Forms.Label lbl_Order_Summary_Start_Date;
        private System.Windows.Forms.Label lbl_Order_Summary_End_Date;
    }
}