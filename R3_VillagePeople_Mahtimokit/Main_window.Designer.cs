namespace R3_VillagePeople_Mahtimokit
{
    partial class Main_window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_window));
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("Toimipisteen valinta");
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("Asiakkaiden valinta");
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("Mökin valinta");
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("Mökin yhteenveto");
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("Lisäpalveluiden valinta");
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("Tilauksen yhteenveto");
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("Uusi varaus", new System.Windows.Forms.TreeNode[] {
            treeNode57,
            treeNode58,
            treeNode59,
            treeNode60,
            treeNode61,
            treeNode62});
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("Asiakkaiden hallinta");
            System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("Toimipisteen valinta");
            System.Windows.Forms.TreeNode treeNode66 = new System.Windows.Forms.TreeNode("Toimipisteen palvelut");
            System.Windows.Forms.TreeNode treeNode67 = new System.Windows.Forms.TreeNode("Toimipisteen mökit");
            System.Windows.Forms.TreeNode treeNode68 = new System.Windows.Forms.TreeNode("Tietojen hallinta", new System.Windows.Forms.TreeNode[] {
            treeNode64,
            treeNode65,
            treeNode66,
            treeNode67});
            System.Windows.Forms.TreeNode treeNode69 = new System.Windows.Forms.TreeNode("Varaushistoria");
            System.Windows.Forms.TreeNode treeNode70 = new System.Windows.Forms.TreeNode("Asetukset");
            this.tab_Menu = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbl_Order_base = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_Order_1st_Col_Office_Customer = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_Order_Customers = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_Order_1st_Col_Office = new System.Windows.Forms.TableLayoutPanel();
            this.cmb_Order_Office_Select = new System.Windows.Forms.ComboBox();
            this.lbl_Order_Office = new System.Windows.Forms.Label();
            this.tbl_Order_1st_Col_Customer = new System.Windows.Forms.TableLayoutPanel();
            this.lsv_Order_Customers_All = new System.Windows.Forms.ListView();
            this.tbl_Order_Customer_Search = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Order_Customers_Search = new System.Windows.Forms.Button();
            this.txt_Order_Customers_Search = new System.Windows.Forms.TextBox();
            this.lbl_Order_Customers = new System.Windows.Forms.Label();
            this.btn_Order_Customers_Add = new System.Windows.Forms.Button();
            this.tbl_Order_2nd_Col_Cottage = new System.Windows.Forms.TableLayoutPanel();
            this.cal_Order_Cottage_Begin = new System.Windows.Forms.MonthCalendar();
            this.lbl_Order_Cottage_End = new System.Windows.Forms.Label();
            this.cal_Order_Cottage_End = new System.Windows.Forms.MonthCalendar();
            this.lbl_Order_Cottage_Selection = new System.Windows.Forms.Label();
            this.Btn_Order_Cottage_Add = new System.Windows.Forms.Button();
            this.lsv_Order_Cottages_All = new System.Windows.Forms.ListView();
            this.lbl_Order_Cottage = new System.Windows.Forms.Label();
            this.lbl_Order_Cottage_Begin = new System.Windows.Forms.Label();
            this.tbl_Order_3rd_Col_Cottage_Summary_Services = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_Order_3rd_Col_Cottage_Summary = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Order_Cottage_Summary_Price = new System.Windows.Forms.Label();
            this.lbl_Order_Cottage_Summary = new System.Windows.Forms.Label();
            this.lbl_Order_Cottage_Summary_End = new System.Windows.Forms.Label();
            this.lbl_Order_Cottage_Summary_Begin = new System.Windows.Forms.Label();
            this.lbl_Order_Cottage_Summary_Customers = new System.Windows.Forms.Label();
            this.lbl_Order_Cottage_Max_Customers = new System.Windows.Forms.Label();
            this.tbl_Order_3rd_Col_Services = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Order_Services = new System.Windows.Forms.Label();
            this.lsv_Order_Services_All = new System.Windows.Forms.ListView();
            this.btn_Order_Service_add = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grb_Services = new System.Windows.Forms.GroupBox();
            this.btn_Services_delete = new System.Windows.Forms.Button();
            this.btn_Services_edit = new System.Windows.Forms.Button();
            this.btn_Services_add = new System.Windows.Forms.Button();
            this.btn_Services_search = new System.Windows.Forms.Button();
            this.lbl_Services = new System.Windows.Forms.Label();
            this.txt_Services_search = new System.Windows.Forms.TextBox();
            this.lsv_Services_all = new System.Windows.Forms.ListView();
            this.grb_Cottages = new System.Windows.Forms.GroupBox();
            this.btn_Cottages_delete = new System.Windows.Forms.Button();
            this.btn_Cottages_edit = new System.Windows.Forms.Button();
            this.btn_Cottages_add = new System.Windows.Forms.Button();
            this.btn_Cottages_search = new System.Windows.Forms.Button();
            this.lbl_Cottages = new System.Windows.Forms.Label();
            this.txt_Cottages_search = new System.Windows.Forms.TextBox();
            this.lsv_Cottages_all = new System.Windows.Forms.ListView();
            this.grb_Customer_Management = new System.Windows.Forms.GroupBox();
            this.btn_Customer_delete = new System.Windows.Forms.Button();
            this.btn_Customer_edit = new System.Windows.Forms.Button();
            this.btn_Customer_add = new System.Windows.Forms.Button();
            this.btn_Customer_search = new System.Windows.Forms.Button();
            this.lbl_Customer_Management = new System.Windows.Forms.Label();
            this.txt_Customer_search = new System.Windows.Forms.TextBox();
            this.lsv_Customers_all = new System.Windows.Forms.ListView();
            this.grb_Office = new System.Windows.Forms.GroupBox();
            this.btn_Office_delete = new System.Windows.Forms.Button();
            this.btn_Office_edit = new System.Windows.Forms.Button();
            this.btn_Office_add = new System.Windows.Forms.Button();
            this.cbo_Office_select = new System.Windows.Forms.ComboBox();
            this.lbl_Office = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_Remove_All_Files = new System.Windows.Forms.Button();
            this.lbl_Remove_All_Files = new System.Windows.Forms.Label();
            this.cbo_Default_Office_select = new System.Windows.Forms.ComboBox();
            this.lbl_Default_Office = new System.Windows.Forms.Label();
            this.lbl_Font_Example = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_System_Font = new System.Windows.Forms.Label();
            this.cbo_Language_Select = new System.Windows.Forms.ComboBox();
            this.lbl_System_Language = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tbl_4th_Col_Summary = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_Order_Summary_Office_Customers = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Order_Summary = new System.Windows.Forms.Label();
            this.lbl_Order_Summary_Office = new System.Windows.Forms.Label();
            this.lbl_Order_Summary_Customers = new System.Windows.Forms.Label();
            this.lsv_Order_Summary_Customers = new System.Windows.Forms.ListView();
            this.tbl_Order_Summary_Cottage_Services = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Order_Summary_Cottages = new System.Windows.Forms.Label();
            this.lsv_Order_Summary_Cottages = new System.Windows.Forms.ListView();
            this.lbl_Order_Summary_Services = new System.Windows.Forms.Label();
            this.lsv_Order_Summary_Services = new System.Windows.Forms.ListView();
            this.tbl_Order_Summary_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Order_Summary_Delete_From_List = new System.Windows.Forms.Button();
            this.btn_Order_Summary_Next_Page = new System.Windows.Forms.Button();
            this.tab_Menu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tbl_Order_base.SuspendLayout();
            this.tbl_Order_1st_Col_Office_Customer.SuspendLayout();
            this.tbl_Order_1st_Col_Office.SuspendLayout();
            this.tbl_Order_1st_Col_Customer.SuspendLayout();
            this.tbl_Order_Customer_Search.SuspendLayout();
            this.tbl_Order_2nd_Col_Cottage.SuspendLayout();
            this.tbl_Order_3rd_Col_Cottage_Summary_Services.SuspendLayout();
            this.tbl_Order_3rd_Col_Cottage_Summary.SuspendLayout();
            this.tbl_Order_3rd_Col_Services.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grb_Services.SuspendLayout();
            this.grb_Cottages.SuspendLayout();
            this.grb_Customer_Management.SuspendLayout();
            this.grb_Office.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tbl_4th_Col_Summary.SuspendLayout();
            this.tbl_Order_Summary_Office_Customers.SuspendLayout();
            this.tbl_Order_Summary_Cottage_Services.SuspendLayout();
            this.tbl_Order_Summary_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_Menu
            // 
            this.tab_Menu.Controls.Add(this.tabPage1);
            this.tab_Menu.Controls.Add(this.tabPage2);
            this.tab_Menu.Controls.Add(this.tabPage3);
            this.tab_Menu.Controls.Add(this.tabPage4);
            this.tab_Menu.Controls.Add(this.tabPage5);
            this.tab_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tab_Menu.Location = new System.Drawing.Point(0, 0);
            this.tab_Menu.Name = "tab_Menu";
            this.tab_Menu.SelectedIndex = 0;
            this.tab_Menu.Size = new System.Drawing.Size(984, 681);
            this.tab_Menu.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.tbl_Order_base);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(976, 648);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Uusi tilaus";
            // 
            // tbl_Order_base
            // 
            this.tbl_Order_base.BackColor = System.Drawing.Color.Maroon;
            this.tbl_Order_base.ColumnCount = 6;
            this.tbl_Order_base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tbl_Order_base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tbl_Order_base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29F));
            this.tbl_Order_base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tbl_Order_base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tbl_Order_base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tbl_Order_base.Controls.Add(this.tbl_Order_1st_Col_Office_Customer, 1, 1);
            this.tbl_Order_base.Controls.Add(this.tbl_Order_2nd_Col_Cottage, 2, 1);
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
            // tbl_Order_1st_Col_Office_Customer
            // 
            this.tbl_Order_1st_Col_Office_Customer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_Order_1st_Col_Office_Customer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbl_Order_1st_Col_Office_Customer.ColumnCount = 3;
            this.tbl_Order_1st_Col_Office_Customer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tbl_Order_1st_Col_Office_Customer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96F));
            this.tbl_Order_1st_Col_Office_Customer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tbl_Order_1st_Col_Office_Customer.Controls.Add(this.tbl_Order_Customers, 0, 1);
            this.tbl_Order_1st_Col_Office_Customer.Controls.Add(this.tbl_Order_1st_Col_Office, 1, 1);
            this.tbl_Order_1st_Col_Office_Customer.Controls.Add(this.tbl_Order_1st_Col_Customer, 1, 2);
            this.tbl_Order_1st_Col_Office_Customer.Location = new System.Drawing.Point(12, 15);
            this.tbl_Order_1st_Col_Office_Customer.Name = "tbl_Order_1st_Col_Office_Customer";
            this.tbl_Order_1st_Col_Office_Customer.RowCount = 4;
            this.tbl_Order_1st_Col_Office_Customer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tbl_Order_1st_Col_Office_Customer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_Order_1st_Col_Office_Customer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Order_1st_Col_Office_Customer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tbl_Order_1st_Col_Office_Customer.Size = new System.Drawing.Size(207, 610);
            this.tbl_Order_1st_Col_Office_Customer.TabIndex = 0;
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
            this.tbl_Order_Customers.Size = new System.Drawing.Size(1, 64);
            this.tbl_Order_Customers.TabIndex = 1;
            // 
            // tbl_Order_1st_Col_Office
            // 
            this.tbl_Order_1st_Col_Office.ColumnCount = 1;
            this.tbl_Order_1st_Col_Office.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Order_1st_Col_Office.Controls.Add(this.cmb_Order_Office_Select, 0, 1);
            this.tbl_Order_1st_Col_Office.Controls.Add(this.lbl_Order_Office, 0, 0);
            this.tbl_Order_1st_Col_Office.Location = new System.Drawing.Point(7, 18);
            this.tbl_Order_1st_Col_Office.Name = "tbl_Order_1st_Col_Office";
            this.tbl_Order_1st_Col_Office.RowCount = 2;
            this.tbl_Order_1st_Col_Office.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_Order_1st_Col_Office.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_Order_1st_Col_Office.Size = new System.Drawing.Size(192, 64);
            this.tbl_Order_1st_Col_Office.TabIndex = 2;
            // 
            // cmb_Order_Office_Select
            // 
            this.cmb_Order_Office_Select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Order_Office_Select.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Order_Office_Select.FormattingEnabled = true;
            this.cmb_Order_Office_Select.Location = new System.Drawing.Point(3, 28);
            this.cmb_Order_Office_Select.Name = "cmb_Order_Office_Select";
            this.cmb_Order_Office_Select.Size = new System.Drawing.Size(186, 28);
            this.cmb_Order_Office_Select.TabIndex = 105;
            this.cmb_Order_Office_Select.Text = "Valitse toimipiste";
            // 
            // lbl_Order_Office
            // 
            this.lbl_Order_Office.AutoSize = true;
            this.lbl_Order_Office.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Order_Office.Location = new System.Drawing.Point(3, 0);
            this.lbl_Order_Office.Name = "lbl_Order_Office";
            this.lbl_Order_Office.Size = new System.Drawing.Size(167, 20);
            this.lbl_Order_Office.TabIndex = 104;
            this.lbl_Order_Office.Text = "Toimipisteen valinta";
            // 
            // tbl_Order_1st_Col_Customer
            // 
            this.tbl_Order_1st_Col_Customer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_Order_1st_Col_Customer.ColumnCount = 1;
            this.tbl_Order_1st_Col_Customer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Order_1st_Col_Customer.Controls.Add(this.lsv_Order_Customers_All, 0, 1);
            this.tbl_Order_1st_Col_Customer.Controls.Add(this.tbl_Order_Customer_Search, 0, 2);
            this.tbl_Order_1st_Col_Customer.Controls.Add(this.lbl_Order_Customers, 0, 0);
            this.tbl_Order_1st_Col_Customer.Controls.Add(this.btn_Order_Customers_Add, 0, 3);
            this.tbl_Order_1st_Col_Customer.Location = new System.Drawing.Point(7, 88);
            this.tbl_Order_1st_Col_Customer.Name = "tbl_Order_1st_Col_Customer";
            this.tbl_Order_1st_Col_Customer.RowCount = 4;
            this.tbl_Order_1st_Col_Customer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_Order_1st_Col_Customer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Order_1st_Col_Customer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tbl_Order_1st_Col_Customer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_Order_1st_Col_Customer.Size = new System.Drawing.Size(192, 504);
            this.tbl_Order_1st_Col_Customer.TabIndex = 3;
            // 
            // lsv_Order_Customers_All
            // 
            this.lsv_Order_Customers_All.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsv_Order_Customers_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lsv_Order_Customers_All.Location = new System.Drawing.Point(3, 23);
            this.lsv_Order_Customers_All.Name = "lsv_Order_Customers_All";
            this.lsv_Order_Customers_All.Size = new System.Drawing.Size(186, 376);
            this.lsv_Order_Customers_All.TabIndex = 104;
            this.lsv_Order_Customers_All.UseCompatibleStateImageBehavior = false;
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
            this.tbl_Order_Customer_Search.Location = new System.Drawing.Point(3, 405);
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
            this.btn_Order_Customers_Add.Location = new System.Drawing.Point(3, 451);
            this.btn_Order_Customers_Add.Name = "btn_Order_Customers_Add";
            this.btn_Order_Customers_Add.Size = new System.Drawing.Size(186, 50);
            this.btn_Order_Customers_Add.TabIndex = 105;
            this.btn_Order_Customers_Add.Text = "Lisää asiakas varaukseen";
            this.btn_Order_Customers_Add.UseVisualStyleBackColor = true;
            // 
            // tbl_Order_2nd_Col_Cottage
            // 
            this.tbl_Order_2nd_Col_Cottage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_Order_2nd_Col_Cottage.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbl_Order_2nd_Col_Cottage.ColumnCount = 3;
            this.tbl_Order_2nd_Col_Cottage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tbl_Order_2nd_Col_Cottage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96F));
            this.tbl_Order_2nd_Col_Cottage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tbl_Order_2nd_Col_Cottage.Controls.Add(this.cal_Order_Cottage_Begin, 1, 3);
            this.tbl_Order_2nd_Col_Cottage.Controls.Add(this.lbl_Order_Cottage_End, 1, 4);
            this.tbl_Order_2nd_Col_Cottage.Controls.Add(this.cal_Order_Cottage_End, 1, 5);
            this.tbl_Order_2nd_Col_Cottage.Controls.Add(this.lbl_Order_Cottage_Selection, 1, 6);
            this.tbl_Order_2nd_Col_Cottage.Controls.Add(this.Btn_Order_Cottage_Add, 1, 8);
            this.tbl_Order_2nd_Col_Cottage.Controls.Add(this.lsv_Order_Cottages_All, 1, 7);
            this.tbl_Order_2nd_Col_Cottage.Controls.Add(this.lbl_Order_Cottage, 1, 1);
            this.tbl_Order_2nd_Col_Cottage.Controls.Add(this.lbl_Order_Cottage_Begin, 1, 2);
            this.tbl_Order_2nd_Col_Cottage.Location = new System.Drawing.Point(225, 15);
            this.tbl_Order_2nd_Col_Cottage.Name = "tbl_Order_2nd_Col_Cottage";
            this.tbl_Order_2nd_Col_Cottage.RowCount = 10;
            this.tbl_Order_2nd_Col_Cottage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tbl_Order_2nd_Col_Cottage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_Order_2nd_Col_Cottage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_Order_2nd_Col_Cottage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_Order_2nd_Col_Cottage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_Order_2nd_Col_Cottage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_Order_2nd_Col_Cottage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_Order_2nd_Col_Cottage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Order_2nd_Col_Cottage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_Order_2nd_Col_Cottage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tbl_Order_2nd_Col_Cottage.Size = new System.Drawing.Size(275, 610);
            this.tbl_Order_2nd_Col_Cottage.TabIndex = 1;
            this.tbl_Order_2nd_Col_Cottage.Paint += new System.Windows.Forms.PaintEventHandler(this.tbl_Order_2nd_Col_Cottage_Paint);
            // 
            // cal_Order_Cottage_Begin
            // 
            this.cal_Order_Cottage_Begin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cal_Order_Cottage_Begin.Location = new System.Drawing.Point(14, 64);
            this.cal_Order_Cottage_Begin.Name = "cal_Order_Cottage_Begin";
            this.cal_Order_Cottage_Begin.TabIndex = 71;
            // 
            // lbl_Order_Cottage_End
            // 
            this.lbl_Order_Cottage_End.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Order_Cottage_End.AutoSize = true;
            this.lbl_Order_Cottage_End.Location = new System.Drawing.Point(93, 235);
            this.lbl_Order_Cottage_End.Name = "lbl_Order_Cottage_End";
            this.lbl_Order_Cottage_End.Size = new System.Drawing.Size(87, 20);
            this.lbl_Order_Cottage_End.TabIndex = 68;
            this.lbl_Order_Cottage_End.Text = "Lähtöpäivä";
            // 
            // cal_Order_Cottage_End
            // 
            this.cal_Order_Cottage_End.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cal_Order_Cottage_End.Location = new System.Drawing.Point(14, 264);
            this.cal_Order_Cottage_End.Name = "cal_Order_Cottage_End";
            this.cal_Order_Cottage_End.TabIndex = 69;
            // 
            // lbl_Order_Cottage_Selection
            // 
            this.lbl_Order_Cottage_Selection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Order_Cottage_Selection.AutoSize = true;
            this.lbl_Order_Cottage_Selection.Location = new System.Drawing.Point(8, 435);
            this.lbl_Order_Cottage_Selection.Name = "lbl_Order_Cottage_Selection";
            this.lbl_Order_Cottage_Selection.Size = new System.Drawing.Size(100, 20);
            this.lbl_Order_Cottage_Selection.TabIndex = 70;
            this.lbl_Order_Cottage_Selection.Text = "Mökin valinta";
            // 
            // Btn_Order_Cottage_Add
            // 
            this.Btn_Order_Cottage_Add.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Order_Cottage_Add.Location = new System.Drawing.Point(8, 535);
            this.Btn_Order_Cottage_Add.Name = "Btn_Order_Cottage_Add";
            this.Btn_Order_Cottage_Add.Size = new System.Drawing.Size(258, 57);
            this.Btn_Order_Cottage_Add.TabIndex = 73;
            this.Btn_Order_Cottage_Add.Text = "Lisää mökki varaukseen";
            this.Btn_Order_Cottage_Add.UseVisualStyleBackColor = true;
            // 
            // lsv_Order_Cottages_All
            // 
            this.lsv_Order_Cottages_All.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsv_Order_Cottages_All.Location = new System.Drawing.Point(8, 458);
            this.lsv_Order_Cottages_All.Name = "lsv_Order_Cottages_All";
            this.lsv_Order_Cottages_All.Size = new System.Drawing.Size(258, 71);
            this.lsv_Order_Cottages_All.TabIndex = 74;
            this.lsv_Order_Cottages_All.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_Order_Cottage
            // 
            this.lbl_Order_Cottage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Order_Cottage.AutoSize = true;
            this.lbl_Order_Cottage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Order_Cottage.Location = new System.Drawing.Point(8, 15);
            this.lbl_Order_Cottage.Name = "lbl_Order_Cottage";
            this.lbl_Order_Cottage.Size = new System.Drawing.Size(76, 20);
            this.lbl_Order_Cottage.TabIndex = 0;
            this.lbl_Order_Cottage.Text = "Majoitus";
            // 
            // lbl_Order_Cottage_Begin
            // 
            this.lbl_Order_Cottage_Begin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Order_Cottage_Begin.AutoSize = true;
            this.lbl_Order_Cottage_Begin.Location = new System.Drawing.Point(99, 35);
            this.lbl_Order_Cottage_Begin.Name = "lbl_Order_Cottage_Begin";
            this.lbl_Order_Cottage_Begin.Size = new System.Drawing.Size(76, 20);
            this.lbl_Order_Cottage_Begin.TabIndex = 1;
            this.lbl_Order_Cottage_Begin.Text = "Tulopäivä";
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
            this.tbl_Order_3rd_Col_Cottage_Summary_Services.Controls.Add(this.tbl_Order_3rd_Col_Cottage_Summary, 1, 1);
            this.tbl_Order_3rd_Col_Cottage_Summary_Services.Controls.Add(this.tbl_Order_3rd_Col_Services, 1, 3);
            this.tbl_Order_3rd_Col_Cottage_Summary_Services.Location = new System.Drawing.Point(506, 15);
            this.tbl_Order_3rd_Col_Cottage_Summary_Services.Name = "tbl_Order_3rd_Col_Cottage_Summary_Services";
            this.tbl_Order_3rd_Col_Cottage_Summary_Services.RowCount = 5;
            this.tbl_Order_3rd_Col_Cottage_Summary_Services.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tbl_Order_3rd_Col_Cottage_Summary_Services.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_Order_3rd_Col_Cottage_Summary_Services.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tbl_Order_3rd_Col_Cottage_Summary_Services.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Order_3rd_Col_Cottage_Summary_Services.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tbl_Order_3rd_Col_Cottage_Summary_Services.Size = new System.Drawing.Size(217, 610);
            this.tbl_Order_3rd_Col_Cottage_Summary_Services.TabIndex = 2;
            // 
            // tbl_Order_3rd_Col_Cottage_Summary
            // 
            this.tbl_Order_3rd_Col_Cottage_Summary.ColumnCount = 1;
            this.tbl_Order_3rd_Col_Cottage_Summary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Order_3rd_Col_Cottage_Summary.Controls.Add(this.lbl_Order_Cottage_Summary_Price, 0, 5);
            this.tbl_Order_3rd_Col_Cottage_Summary.Controls.Add(this.lbl_Order_Cottage_Summary, 0, 0);
            this.tbl_Order_3rd_Col_Cottage_Summary.Controls.Add(this.lbl_Order_Cottage_Summary_End, 0, 2);
            this.tbl_Order_3rd_Col_Cottage_Summary.Controls.Add(this.lbl_Order_Cottage_Summary_Begin, 0, 1);
            this.tbl_Order_3rd_Col_Cottage_Summary.Controls.Add(this.lbl_Order_Cottage_Summary_Customers, 0, 3);
            this.tbl_Order_3rd_Col_Cottage_Summary.Controls.Add(this.lbl_Order_Cottage_Max_Customers, 0, 4);
            this.tbl_Order_3rd_Col_Cottage_Summary.Location = new System.Drawing.Point(7, 18);
            this.tbl_Order_3rd_Col_Cottage_Summary.Name = "tbl_Order_3rd_Col_Cottage_Summary";
            this.tbl_Order_3rd_Col_Cottage_Summary.RowCount = 6;
            this.tbl_Order_3rd_Col_Cottage_Summary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.36735F));
            this.tbl_Order_3rd_Col_Cottage_Summary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.32653F));
            this.tbl_Order_3rd_Col_Cottage_Summary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.32653F));
            this.tbl_Order_3rd_Col_Cottage_Summary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.32653F));
            this.tbl_Order_3rd_Col_Cottage_Summary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.32653F));
            this.tbl_Order_3rd_Col_Cottage_Summary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.32653F));
            this.tbl_Order_3rd_Col_Cottage_Summary.Size = new System.Drawing.Size(202, 186);
            this.tbl_Order_3rd_Col_Cottage_Summary.TabIndex = 0;
            // 
            // lbl_Order_Cottage_Summary_Price
            // 
            this.lbl_Order_Cottage_Summary_Price.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Order_Cottage_Summary_Price.AutoSize = true;
            this.lbl_Order_Cottage_Summary_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Order_Cottage_Summary_Price.Location = new System.Drawing.Point(3, 160);
            this.lbl_Order_Cottage_Summary_Price.Name = "lbl_Order_Cottage_Summary_Price";
            this.lbl_Order_Cottage_Summary_Price.Size = new System.Drawing.Size(51, 20);
            this.lbl_Order_Cottage_Summary_Price.TabIndex = 85;
            this.lbl_Order_Cottage_Summary_Price.Text = "Hinta:";
            // 
            // lbl_Order_Cottage_Summary
            // 
            this.lbl_Order_Cottage_Summary.AutoSize = true;
            this.lbl_Order_Cottage_Summary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Order_Cottage_Summary.Location = new System.Drawing.Point(3, 0);
            this.lbl_Order_Cottage_Summary.Name = "lbl_Order_Cottage_Summary";
            this.lbl_Order_Cottage_Summary.Size = new System.Drawing.Size(168, 20);
            this.lbl_Order_Cottage_Summary.TabIndex = 79;
            this.lbl_Order_Cottage_Summary.Text = "Valitun mökin tiedot";
            // 
            // lbl_Order_Cottage_Summary_End
            // 
            this.lbl_Order_Cottage_Summary_End.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Order_Cottage_Summary_End.AutoSize = true;
            this.lbl_Order_Cottage_Summary_End.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Order_Cottage_Summary_End.Location = new System.Drawing.Point(3, 69);
            this.lbl_Order_Cottage_Summary_End.Name = "lbl_Order_Cottage_Summary_End";
            this.lbl_Order_Cottage_Summary_End.Size = new System.Drawing.Size(91, 20);
            this.lbl_Order_Cottage_Summary_End.TabIndex = 82;
            this.lbl_Order_Cottage_Summary_End.Text = "Lähtöpäivä:";
            // 
            // lbl_Order_Cottage_Summary_Begin
            // 
            this.lbl_Order_Cottage_Summary_Begin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Order_Cottage_Summary_Begin.AutoSize = true;
            this.lbl_Order_Cottage_Summary_Begin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Order_Cottage_Summary_Begin.Location = new System.Drawing.Point(3, 39);
            this.lbl_Order_Cottage_Summary_Begin.Name = "lbl_Order_Cottage_Summary_Begin";
            this.lbl_Order_Cottage_Summary_Begin.Size = new System.Drawing.Size(76, 20);
            this.lbl_Order_Cottage_Summary_Begin.TabIndex = 81;
            this.lbl_Order_Cottage_Summary_Begin.Text = "Tulopäivä";
            // 
            // lbl_Order_Cottage_Summary_Customers
            // 
            this.lbl_Order_Cottage_Summary_Customers.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Order_Cottage_Summary_Customers.AutoSize = true;
            this.lbl_Order_Cottage_Summary_Customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Order_Cottage_Summary_Customers.Location = new System.Drawing.Point(3, 99);
            this.lbl_Order_Cottage_Summary_Customers.Name = "lbl_Order_Cottage_Summary_Customers";
            this.lbl_Order_Cottage_Summary_Customers.Size = new System.Drawing.Size(142, 20);
            this.lbl_Order_Cottage_Summary_Customers.TabIndex = 83;
            this.lbl_Order_Cottage_Summary_Customers.Text = "Majoittujien määrä:";
            // 
            // lbl_Order_Cottage_Max_Customers
            // 
            this.lbl_Order_Cottage_Max_Customers.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Order_Cottage_Max_Customers.AutoSize = true;
            this.lbl_Order_Cottage_Max_Customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Order_Cottage_Max_Customers.Location = new System.Drawing.Point(3, 129);
            this.lbl_Order_Cottage_Max_Customers.Name = "lbl_Order_Cottage_Max_Customers";
            this.lbl_Order_Cottage_Max_Customers.Size = new System.Drawing.Size(101, 20);
            this.lbl_Order_Cottage_Max_Customers.TabIndex = 84;
            this.lbl_Order_Cottage_Max_Customers.Text = "Max henkilöt:";
            // 
            // tbl_Order_3rd_Col_Services
            // 
            this.tbl_Order_3rd_Col_Services.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_Order_3rd_Col_Services.ColumnCount = 1;
            this.tbl_Order_3rd_Col_Services.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Order_3rd_Col_Services.Controls.Add(this.lbl_Order_Services, 0, 0);
            this.tbl_Order_3rd_Col_Services.Controls.Add(this.lsv_Order_Services_All, 0, 1);
            this.tbl_Order_3rd_Col_Services.Controls.Add(this.btn_Order_Service_add, 0, 2);
            this.tbl_Order_3rd_Col_Services.Location = new System.Drawing.Point(7, 225);
            this.tbl_Order_3rd_Col_Services.Name = "tbl_Order_3rd_Col_Services";
            this.tbl_Order_3rd_Col_Services.RowCount = 3;
            this.tbl_Order_3rd_Col_Services.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_Order_3rd_Col_Services.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Order_3rd_Col_Services.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_Order_3rd_Col_Services.Size = new System.Drawing.Size(202, 367);
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
            // lsv_Order_Services_All
            // 
            this.lsv_Order_Services_All.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsv_Order_Services_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lsv_Order_Services_All.Location = new System.Drawing.Point(3, 23);
            this.lsv_Order_Services_All.Name = "lsv_Order_Services_All";
            this.lsv_Order_Services_All.Size = new System.Drawing.Size(196, 282);
            this.lsv_Order_Services_All.TabIndex = 105;
            this.lsv_Order_Services_All.UseCompatibleStateImageBehavior = false;
            // 
            // btn_Order_Service_add
            // 
            this.btn_Order_Service_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Order_Service_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Order_Service_add.Location = new System.Drawing.Point(3, 311);
            this.btn_Order_Service_add.Name = "btn_Order_Service_add";
            this.btn_Order_Service_add.Size = new System.Drawing.Size(196, 53);
            this.btn_Order_Service_add.TabIndex = 106;
            this.btn_Order_Service_add.Text = "Lisää palvelu varaukseen";
            this.btn_Order_Service_add.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.grb_Services);
            this.tabPage2.Controls.Add(this.grb_Cottages);
            this.tabPage2.Controls.Add(this.grb_Customer_Management);
            this.tabPage2.Controls.Add(this.grb_Office);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(976, 648);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tietojen Hallinta";
            // 
            // grb_Services
            // 
            this.grb_Services.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grb_Services.Controls.Add(this.btn_Services_delete);
            this.grb_Services.Controls.Add(this.btn_Services_edit);
            this.grb_Services.Controls.Add(this.btn_Services_add);
            this.grb_Services.Controls.Add(this.btn_Services_search);
            this.grb_Services.Controls.Add(this.lbl_Services);
            this.grb_Services.Controls.Add(this.txt_Services_search);
            this.grb_Services.Controls.Add(this.lsv_Services_all);
            this.grb_Services.Location = new System.Drawing.Point(346, 149);
            this.grb_Services.Name = "grb_Services";
            this.grb_Services.Size = new System.Drawing.Size(260, 505);
            this.grb_Services.TabIndex = 123;
            this.grb_Services.TabStop = false;
            // 
            // btn_Services_delete
            // 
            this.btn_Services_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Services_delete.BackgroundImage")));
            this.btn_Services_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Services_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Services_delete.Location = new System.Drawing.Point(182, 439);
            this.btn_Services_delete.Name = "btn_Services_delete";
            this.btn_Services_delete.Size = new System.Drawing.Size(48, 48);
            this.btn_Services_delete.TabIndex = 109;
            this.btn_Services_delete.UseVisualStyleBackColor = true;
            this.btn_Services_delete.Click += new System.EventHandler(this.btn_Services_delete_Click);
            // 
            // btn_Services_edit
            // 
            this.btn_Services_edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Services_edit.BackgroundImage")));
            this.btn_Services_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Services_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Services_edit.Location = new System.Drawing.Point(99, 439);
            this.btn_Services_edit.Name = "btn_Services_edit";
            this.btn_Services_edit.Size = new System.Drawing.Size(48, 48);
            this.btn_Services_edit.TabIndex = 108;
            this.btn_Services_edit.UseVisualStyleBackColor = true;
            this.btn_Services_edit.Click += new System.EventHandler(this.btn_Services_edit_Click);
            // 
            // btn_Services_add
            // 
            this.btn_Services_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Services_add.BackgroundImage")));
            this.btn_Services_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Services_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Services_add.Location = new System.Drawing.Point(16, 439);
            this.btn_Services_add.Name = "btn_Services_add";
            this.btn_Services_add.Size = new System.Drawing.Size(48, 48);
            this.btn_Services_add.TabIndex = 107;
            this.btn_Services_add.UseVisualStyleBackColor = true;
            this.btn_Services_add.Click += new System.EventHandler(this.btn_Services_add_Click);
            // 
            // btn_Services_search
            // 
            this.btn_Services_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Services_search.BackgroundImage")));
            this.btn_Services_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Services_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Services_search.Location = new System.Drawing.Point(198, 396);
            this.btn_Services_search.Name = "btn_Services_search";
            this.btn_Services_search.Size = new System.Drawing.Size(32, 32);
            this.btn_Services_search.TabIndex = 101;
            this.btn_Services_search.UseVisualStyleBackColor = true;
            // 
            // lbl_Services
            // 
            this.lbl_Services.AutoSize = true;
            this.lbl_Services.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Services.Location = new System.Drawing.Point(18, 16);
            this.lbl_Services.Name = "lbl_Services";
            this.lbl_Services.Size = new System.Drawing.Size(177, 20);
            this.lbl_Services.TabIndex = 77;
            this.lbl_Services.Text = "Toimipisteen palvelut";
            // 
            // txt_Services_search
            // 
            this.txt_Services_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Services_search.Location = new System.Drawing.Point(16, 398);
            this.txt_Services_search.Name = "txt_Services_search";
            this.txt_Services_search.Size = new System.Drawing.Size(179, 26);
            this.txt_Services_search.TabIndex = 100;
            // 
            // lsv_Services_all
            // 
            this.lsv_Services_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lsv_Services_all.Location = new System.Drawing.Point(16, 50);
            this.lsv_Services_all.Name = "lsv_Services_all";
            this.lsv_Services_all.Size = new System.Drawing.Size(214, 338);
            this.lsv_Services_all.TabIndex = 99;
            this.lsv_Services_all.UseCompatibleStateImageBehavior = false;
            // 
            // grb_Cottages
            // 
            this.grb_Cottages.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grb_Cottages.Controls.Add(this.btn_Cottages_delete);
            this.grb_Cottages.Controls.Add(this.btn_Cottages_edit);
            this.grb_Cottages.Controls.Add(this.btn_Cottages_add);
            this.grb_Cottages.Controls.Add(this.btn_Cottages_search);
            this.grb_Cottages.Controls.Add(this.lbl_Cottages);
            this.grb_Cottages.Controls.Add(this.txt_Cottages_search);
            this.grb_Cottages.Controls.Add(this.lsv_Cottages_all);
            this.grb_Cottages.Location = new System.Drawing.Point(644, 13);
            this.grb_Cottages.Name = "grb_Cottages";
            this.grb_Cottages.Size = new System.Drawing.Size(260, 638);
            this.grb_Cottages.TabIndex = 121;
            this.grb_Cottages.TabStop = false;
            // 
            // btn_Cottages_delete
            // 
            this.btn_Cottages_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cottages_delete.BackgroundImage")));
            this.btn_Cottages_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cottages_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Cottages_delete.Location = new System.Drawing.Point(181, 575);
            this.btn_Cottages_delete.Name = "btn_Cottages_delete";
            this.btn_Cottages_delete.Size = new System.Drawing.Size(48, 48);
            this.btn_Cottages_delete.TabIndex = 109;
            this.btn_Cottages_delete.UseVisualStyleBackColor = true;
            this.btn_Cottages_delete.Click += new System.EventHandler(this.btn_Cottages_delete_Click);
            // 
            // btn_Cottages_edit
            // 
            this.btn_Cottages_edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cottages_edit.BackgroundImage")));
            this.btn_Cottages_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cottages_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Cottages_edit.Location = new System.Drawing.Point(98, 575);
            this.btn_Cottages_edit.Name = "btn_Cottages_edit";
            this.btn_Cottages_edit.Size = new System.Drawing.Size(48, 48);
            this.btn_Cottages_edit.TabIndex = 108;
            this.btn_Cottages_edit.UseVisualStyleBackColor = true;
            this.btn_Cottages_edit.Click += new System.EventHandler(this.btn_Cottages_edit_Click);
            // 
            // btn_Cottages_add
            // 
            this.btn_Cottages_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cottages_add.BackgroundImage")));
            this.btn_Cottages_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cottages_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Cottages_add.Location = new System.Drawing.Point(15, 575);
            this.btn_Cottages_add.Name = "btn_Cottages_add";
            this.btn_Cottages_add.Size = new System.Drawing.Size(48, 48);
            this.btn_Cottages_add.TabIndex = 107;
            this.btn_Cottages_add.UseVisualStyleBackColor = true;
            this.btn_Cottages_add.Click += new System.EventHandler(this.btn_Cottages_add_Click);
            // 
            // btn_Cottages_search
            // 
            this.btn_Cottages_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cottages_search.BackgroundImage")));
            this.btn_Cottages_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cottages_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Cottages_search.Location = new System.Drawing.Point(199, 541);
            this.btn_Cottages_search.Name = "btn_Cottages_search";
            this.btn_Cottages_search.Size = new System.Drawing.Size(32, 32);
            this.btn_Cottages_search.TabIndex = 101;
            this.btn_Cottages_search.UseVisualStyleBackColor = true;
            // 
            // lbl_Cottages
            // 
            this.lbl_Cottages.AutoSize = true;
            this.lbl_Cottages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cottages.Location = new System.Drawing.Point(12, 16);
            this.lbl_Cottages.Name = "lbl_Cottages";
            this.lbl_Cottages.Size = new System.Drawing.Size(158, 20);
            this.lbl_Cottages.TabIndex = 77;
            this.lbl_Cottages.Text = "Toimipisteen mökit";
            // 
            // txt_Cottages_search
            // 
            this.txt_Cottages_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Cottages_search.Location = new System.Drawing.Point(17, 543);
            this.txt_Cottages_search.Name = "txt_Cottages_search";
            this.txt_Cottages_search.Size = new System.Drawing.Size(172, 26);
            this.txt_Cottages_search.TabIndex = 100;
            // 
            // lsv_Cottages_all
            // 
            this.lsv_Cottages_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lsv_Cottages_all.Location = new System.Drawing.Point(16, 50);
            this.lsv_Cottages_all.Name = "lsv_Cottages_all";
            this.lsv_Cottages_all.Size = new System.Drawing.Size(214, 487);
            this.lsv_Cottages_all.TabIndex = 99;
            this.lsv_Cottages_all.UseCompatibleStateImageBehavior = false;
            // 
            // grb_Customer_Management
            // 
            this.grb_Customer_Management.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grb_Customer_Management.Controls.Add(this.btn_Customer_delete);
            this.grb_Customer_Management.Controls.Add(this.btn_Customer_edit);
            this.grb_Customer_Management.Controls.Add(this.btn_Customer_add);
            this.grb_Customer_Management.Controls.Add(this.btn_Customer_search);
            this.grb_Customer_Management.Controls.Add(this.lbl_Customer_Management);
            this.grb_Customer_Management.Controls.Add(this.txt_Customer_search);
            this.grb_Customer_Management.Controls.Add(this.lsv_Customers_all);
            this.grb_Customer_Management.Location = new System.Drawing.Point(54, 13);
            this.grb_Customer_Management.Name = "grb_Customer_Management";
            this.grb_Customer_Management.Size = new System.Drawing.Size(260, 645);
            this.grb_Customer_Management.TabIndex = 124;
            this.grb_Customer_Management.TabStop = false;
            // 
            // btn_Customer_delete
            // 
            this.btn_Customer_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Customer_delete.BackgroundImage")));
            this.btn_Customer_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Customer_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Customer_delete.Location = new System.Drawing.Point(182, 578);
            this.btn_Customer_delete.Name = "btn_Customer_delete";
            this.btn_Customer_delete.Size = new System.Drawing.Size(48, 48);
            this.btn_Customer_delete.TabIndex = 109;
            this.btn_Customer_delete.UseVisualStyleBackColor = true;
            this.btn_Customer_delete.Click += new System.EventHandler(this.btn_Customer_delete_Click);
            // 
            // btn_Customer_edit
            // 
            this.btn_Customer_edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Customer_edit.BackgroundImage")));
            this.btn_Customer_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Customer_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Customer_edit.Location = new System.Drawing.Point(102, 578);
            this.btn_Customer_edit.Name = "btn_Customer_edit";
            this.btn_Customer_edit.Size = new System.Drawing.Size(48, 48);
            this.btn_Customer_edit.TabIndex = 108;
            this.btn_Customer_edit.UseVisualStyleBackColor = true;
            this.btn_Customer_edit.Click += new System.EventHandler(this.btn_Customer_edit_Click);
            // 
            // btn_Customer_add
            // 
            this.btn_Customer_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Customer_add.BackgroundImage")));
            this.btn_Customer_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Customer_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Customer_add.Location = new System.Drawing.Point(16, 576);
            this.btn_Customer_add.Name = "btn_Customer_add";
            this.btn_Customer_add.Size = new System.Drawing.Size(48, 48);
            this.btn_Customer_add.TabIndex = 107;
            this.btn_Customer_add.UseVisualStyleBackColor = true;
            this.btn_Customer_add.Click += new System.EventHandler(this.btn_Customer_add_Click);
            // 
            // btn_Customer_search
            // 
            this.btn_Customer_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Customer_search.BackgroundImage")));
            this.btn_Customer_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Customer_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Customer_search.Location = new System.Drawing.Point(198, 543);
            this.btn_Customer_search.Name = "btn_Customer_search";
            this.btn_Customer_search.Size = new System.Drawing.Size(32, 32);
            this.btn_Customer_search.TabIndex = 101;
            this.btn_Customer_search.UseVisualStyleBackColor = true;
            // 
            // lbl_Customer_Management
            // 
            this.lbl_Customer_Management.AutoSize = true;
            this.lbl_Customer_Management.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_Management.Location = new System.Drawing.Point(18, 16);
            this.lbl_Customer_Management.Name = "lbl_Customer_Management";
            this.lbl_Customer_Management.Size = new System.Drawing.Size(169, 20);
            this.lbl_Customer_Management.TabIndex = 77;
            this.lbl_Customer_Management.Text = "Asiakkaiden hallinta";
            // 
            // txt_Customer_search
            // 
            this.txt_Customer_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Customer_search.Location = new System.Drawing.Point(16, 546);
            this.txt_Customer_search.Name = "txt_Customer_search";
            this.txt_Customer_search.Size = new System.Drawing.Size(171, 26);
            this.txt_Customer_search.TabIndex = 100;
            // 
            // lsv_Customers_all
            // 
            this.lsv_Customers_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lsv_Customers_all.Location = new System.Drawing.Point(16, 50);
            this.lsv_Customers_all.Name = "lsv_Customers_all";
            this.lsv_Customers_all.Size = new System.Drawing.Size(214, 487);
            this.lsv_Customers_all.TabIndex = 99;
            this.lsv_Customers_all.UseCompatibleStateImageBehavior = false;
            // 
            // grb_Office
            // 
            this.grb_Office.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grb_Office.Controls.Add(this.btn_Office_delete);
            this.grb_Office.Controls.Add(this.btn_Office_edit);
            this.grb_Office.Controls.Add(this.btn_Office_add);
            this.grb_Office.Controls.Add(this.cbo_Office_select);
            this.grb_Office.Controls.Add(this.lbl_Office);
            this.grb_Office.Location = new System.Drawing.Point(346, 13);
            this.grb_Office.Name = "grb_Office";
            this.grb_Office.Size = new System.Drawing.Size(260, 130);
            this.grb_Office.TabIndex = 122;
            this.grb_Office.TabStop = false;
            // 
            // btn_Office_delete
            // 
            this.btn_Office_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Office_delete.BackgroundImage")));
            this.btn_Office_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Office_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Office_delete.Location = new System.Drawing.Point(182, 74);
            this.btn_Office_delete.Name = "btn_Office_delete";
            this.btn_Office_delete.Size = new System.Drawing.Size(48, 48);
            this.btn_Office_delete.TabIndex = 112;
            this.btn_Office_delete.UseVisualStyleBackColor = true;
            this.btn_Office_delete.Click += new System.EventHandler(this.btn_Office_delete_Click);
            // 
            // btn_Office_edit
            // 
            this.btn_Office_edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Office_edit.BackgroundImage")));
            this.btn_Office_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Office_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Office_edit.Location = new System.Drawing.Point(99, 74);
            this.btn_Office_edit.Name = "btn_Office_edit";
            this.btn_Office_edit.Size = new System.Drawing.Size(48, 48);
            this.btn_Office_edit.TabIndex = 111;
            this.btn_Office_edit.UseVisualStyleBackColor = true;
            this.btn_Office_edit.Click += new System.EventHandler(this.btn_Office_edit_Click);
            // 
            // btn_Office_add
            // 
            this.btn_Office_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Office_add.BackgroundImage")));
            this.btn_Office_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Office_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Office_add.Location = new System.Drawing.Point(16, 74);
            this.btn_Office_add.Name = "btn_Office_add";
            this.btn_Office_add.Size = new System.Drawing.Size(48, 48);
            this.btn_Office_add.TabIndex = 110;
            this.btn_Office_add.UseVisualStyleBackColor = true;
            this.btn_Office_add.Click += new System.EventHandler(this.btn_Office_add_Click);
            // 
            // cbo_Office_select
            // 
            this.cbo_Office_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Office_select.FormattingEnabled = true;
            this.cbo_Office_select.Location = new System.Drawing.Point(13, 40);
            this.cbo_Office_select.Name = "cbo_Office_select";
            this.cbo_Office_select.Size = new System.Drawing.Size(217, 28);
            this.cbo_Office_select.TabIndex = 104;
            this.cbo_Office_select.Text = "Valitse toimipiste";
            // 
            // lbl_Office
            // 
            this.lbl_Office.AutoSize = true;
            this.lbl_Office.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Office.Location = new System.Drawing.Point(9, 16);
            this.lbl_Office.Name = "lbl_Office";
            this.lbl_Office.Size = new System.Drawing.Size(167, 20);
            this.lbl_Office.TabIndex = 103;
            this.lbl_Office.Text = "Toimipisteen valinta";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(976, 648);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tilaushistoria";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(659, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 441);
            this.groupBox3.TabIndex = 118;
            this.groupBox3.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 20);
            this.label9.TabIndex = 107;
            this.label9.Text = "Valitut lisäpalvelut:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 20);
            this.label8.TabIndex = 106;
            this.label8.Text = "Varauksen henkilöt:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 105;
            this.label7.Text = "Lähtöpäivä:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 104;
            this.label6.Text = "Tulopäivä:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(16, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 103;
            this.label5.Text = "Varauksen tiedot";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 69;
            this.label4.Text = "Mökki:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.listView2);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(365, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 606);
            this.groupBox2.TabIndex = 117;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 488);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 20);
            this.label3.TabIndex = 108;
            this.label3.Text = "Hae tietyn vuoden varaukset";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(15, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 20);
            this.label2.TabIndex = 102;
            this.label2.Text = "Asiakkaan varaushistoria";
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button3.Location = new System.Drawing.Point(200, 511);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 32);
            this.button3.TabIndex = 101;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox2.Location = new System.Drawing.Point(19, 514);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 26);
            this.textBox2.TabIndex = 100;
            // 
            // listView2
            // 
            this.listView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listView2.Location = new System.Drawing.Point(19, 54);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(213, 387);
            this.listView2.TabIndex = 99;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button4.Location = new System.Drawing.Point(19, 546);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(213, 54);
            this.button4.TabIndex = 98;
            this.button4.Text = "Katso varauksen tiedot";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(72, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 606);
            this.groupBox1.TabIndex = 116;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 102;
            this.label1.Text = "Asiakkaiden valinta";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(200, 511);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 101;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(19, 514);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 26);
            this.textBox1.TabIndex = 100;
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listView1.Location = new System.Drawing.Point(19, 54);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(213, 387);
            this.listView1.TabIndex = 99;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(19, 546);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 54);
            this.button2.TabIndex = 98;
            this.button2.Text = "Katso asiakkaan varaushistoria";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage4.Controls.Add(this.btn_Remove_All_Files);
            this.tabPage4.Controls.Add(this.lbl_Remove_All_Files);
            this.tabPage4.Controls.Add(this.cbo_Default_Office_select);
            this.tabPage4.Controls.Add(this.lbl_Default_Office);
            this.tabPage4.Controls.Add(this.lbl_Font_Example);
            this.tabPage4.Controls.Add(this.comboBox1);
            this.tabPage4.Controls.Add(this.lbl_System_Font);
            this.tabPage4.Controls.Add(this.cbo_Language_Select);
            this.tabPage4.Controls.Add(this.lbl_System_Language);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(976, 648);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Asetukset";
            // 
            // btn_Remove_All_Files
            // 
            this.btn_Remove_All_Files.Location = new System.Drawing.Point(442, 608);
            this.btn_Remove_All_Files.Name = "btn_Remove_All_Files";
            this.btn_Remove_All_Files.Size = new System.Drawing.Size(94, 27);
            this.btn_Remove_All_Files.TabIndex = 17;
            this.btn_Remove_All_Files.Text = "POISTA";
            this.btn_Remove_All_Files.UseVisualStyleBackColor = true;
            // 
            // lbl_Remove_All_Files
            // 
            this.lbl_Remove_All_Files.AutoSize = true;
            this.lbl_Remove_All_Files.Location = new System.Drawing.Point(411, 585);
            this.lbl_Remove_All_Files.Name = "lbl_Remove_All_Files";
            this.lbl_Remove_All_Files.Size = new System.Drawing.Size(156, 20);
            this.lbl_Remove_All_Files.TabIndex = 16;
            this.lbl_Remove_All_Files.Text = "Poista KAIKKI Tiedot";
            // 
            // cbo_Default_Office_select
            // 
            this.cbo_Default_Office_select.FormattingEnabled = true;
            this.cbo_Default_Office_select.Location = new System.Drawing.Point(524, 63);
            this.cbo_Default_Office_select.Name = "cbo_Default_Office_select";
            this.cbo_Default_Office_select.Size = new System.Drawing.Size(178, 28);
            this.cbo_Default_Office_select.TabIndex = 15;
            // 
            // lbl_Default_Office
            // 
            this.lbl_Default_Office.AutoSize = true;
            this.lbl_Default_Office.Location = new System.Drawing.Point(389, 66);
            this.lbl_Default_Office.Name = "lbl_Default_Office";
            this.lbl_Default_Office.Size = new System.Drawing.Size(122, 20);
            this.lbl_Default_Office.TabIndex = 14;
            this.lbl_Default_Office.Text = "Oletustoimipiste";
            // 
            // lbl_Font_Example
            // 
            this.lbl_Font_Example.AutoSize = true;
            this.lbl_Font_Example.Location = new System.Drawing.Point(81, 186);
            this.lbl_Font_Example.Name = "lbl_Font_Example";
            this.lbl_Font_Example.Size = new System.Drawing.Size(77, 20);
            this.lbl_Font_Example.TabIndex = 13;
            this.lbl_Font_Example.Text = "Esimerkki";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
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
            this.comboBox1.Location = new System.Drawing.Point(142, 115);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(64, 28);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Text = "12";
            // 
            // lbl_System_Font
            // 
            this.lbl_System_Font.AutoSize = true;
            this.lbl_System_Font.Location = new System.Drawing.Point(7, 118);
            this.lbl_System_Font.Name = "lbl_System_Font";
            this.lbl_System_Font.Size = new System.Drawing.Size(84, 20);
            this.lbl_System_Font.TabIndex = 11;
            this.lbl_System_Font.Text = "Fonttikoko";
            // 
            // cbo_Language_Select
            // 
            this.cbo_Language_Select.FormattingEnabled = true;
            this.cbo_Language_Select.Items.AddRange(new object[] {
            "Suomi",
            "English (TBA)"});
            this.cbo_Language_Select.Location = new System.Drawing.Point(85, 58);
            this.cbo_Language_Select.Name = "cbo_Language_Select";
            this.cbo_Language_Select.Size = new System.Drawing.Size(121, 28);
            this.cbo_Language_Select.TabIndex = 10;
            this.cbo_Language_Select.Text = "Suomi";
            // 
            // lbl_System_Language
            // 
            this.lbl_System_Language.AutoSize = true;
            this.lbl_System_Language.Location = new System.Drawing.Point(7, 61);
            this.lbl_System_Language.Name = "lbl_System_Language";
            this.lbl_System_Language.Size = new System.Drawing.Size(37, 20);
            this.lbl_System_Language.TabIndex = 9;
            this.lbl_System_Language.Text = "Kieli";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage5.Controls.Add(this.treeView1);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(976, 648);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Ohjeet";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(23, 25);
            this.treeView1.Name = "treeView1";
            treeNode57.Name = "Node4";
            treeNode57.Text = "Toimipisteen valinta";
            treeNode58.Name = "Node5";
            treeNode58.Text = "Asiakkaiden valinta";
            treeNode59.Name = "Node6";
            treeNode59.Text = "Mökin valinta";
            treeNode60.Name = "Node7";
            treeNode60.Text = "Mökin yhteenveto";
            treeNode61.Name = "Node8";
            treeNode61.Text = "Lisäpalveluiden valinta";
            treeNode62.Name = "Node9";
            treeNode62.Text = "Tilauksen yhteenveto";
            treeNode63.Name = "Node0";
            treeNode63.Text = "Uusi varaus";
            treeNode64.Name = "Node10";
            treeNode64.Text = "Asiakkaiden hallinta";
            treeNode65.Name = "Node11";
            treeNode65.Text = "Toimipisteen valinta";
            treeNode66.Name = "Node12";
            treeNode66.Text = "Toimipisteen palvelut";
            treeNode67.Name = "Node13";
            treeNode67.Text = "Toimipisteen mökit";
            treeNode68.Name = "Node1";
            treeNode68.Text = "Tietojen hallinta";
            treeNode69.Name = "Node2";
            treeNode69.Text = "Varaushistoria";
            treeNode70.Name = "Node3";
            treeNode70.Text = "Asetukset";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode63,
            treeNode68,
            treeNode69,
            treeNode70});
            this.treeView1.Size = new System.Drawing.Size(308, 586);
            this.treeView1.TabIndex = 0;
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
            this.tbl_4th_Col_Summary.Controls.Add(this.tbl_Order_Summary_Office_Customers, 1, 1);
            this.tbl_4th_Col_Summary.Controls.Add(this.tbl_Order_Summary_Cottage_Services, 1, 2);
            this.tbl_4th_Col_Summary.Location = new System.Drawing.Point(729, 15);
            this.tbl_4th_Col_Summary.Name = "tbl_4th_Col_Summary";
            this.tbl_4th_Col_Summary.RowCount = 4;
            this.tbl_4th_Col_Summary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tbl_4th_Col_Summary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tbl_4th_Col_Summary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tbl_4th_Col_Summary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tbl_4th_Col_Summary.Size = new System.Drawing.Size(226, 610);
            this.tbl_4th_Col_Summary.TabIndex = 3;
            // 
            // tbl_Order_Summary_Office_Customers
            // 
            this.tbl_Order_Summary_Office_Customers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_Order_Summary_Office_Customers.ColumnCount = 1;
            this.tbl_Order_Summary_Office_Customers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Order_Summary_Office_Customers.Controls.Add(this.lsv_Order_Summary_Customers, 0, 3);
            this.tbl_Order_Summary_Office_Customers.Controls.Add(this.lbl_Order_Summary, 0, 0);
            this.tbl_Order_Summary_Office_Customers.Controls.Add(this.lbl_Order_Summary_Office, 0, 1);
            this.tbl_Order_Summary_Office_Customers.Controls.Add(this.lbl_Order_Summary_Customers, 0, 2);
            this.tbl_Order_Summary_Office_Customers.Location = new System.Drawing.Point(7, 18);
            this.tbl_Order_Summary_Office_Customers.Name = "tbl_Order_Summary_Office_Customers";
            this.tbl_Order_Summary_Office_Customers.RowCount = 4;
            this.tbl_Order_Summary_Office_Customers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tbl_Order_Summary_Office_Customers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tbl_Order_Summary_Office_Customers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_Order_Summary_Office_Customers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Order_Summary_Office_Customers.Size = new System.Drawing.Size(209, 281);
            this.tbl_Order_Summary_Office_Customers.TabIndex = 0;
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
            this.lbl_Order_Summary_Office.Location = new System.Drawing.Point(3, 47);
            this.lbl_Order_Summary_Office.Name = "lbl_Order_Summary_Office";
            this.lbl_Order_Summary_Office.Size = new System.Drawing.Size(88, 20);
            this.lbl_Order_Summary_Office.TabIndex = 91;
            this.lbl_Order_Summary_Office.Text = "Toimipiste: ";
            // 
            // lbl_Order_Summary_Customers
            // 
            this.lbl_Order_Summary_Customers.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Order_Summary_Customers.AutoSize = true;
            this.lbl_Order_Summary_Customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Order_Summary_Customers.Location = new System.Drawing.Point(65, 75);
            this.lbl_Order_Summary_Customers.Name = "lbl_Order_Summary_Customers";
            this.lbl_Order_Summary_Customers.Size = new System.Drawing.Size(79, 20);
            this.lbl_Order_Summary_Customers.TabIndex = 92;
            this.lbl_Order_Summary_Customers.Text = "Asiakkaat";
            // 
            // lsv_Order_Summary_Customers
            // 
            this.lsv_Order_Summary_Customers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsv_Order_Summary_Customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lsv_Order_Summary_Customers.Location = new System.Drawing.Point(3, 98);
            this.lsv_Order_Summary_Customers.Name = "lsv_Order_Summary_Customers";
            this.lsv_Order_Summary_Customers.Size = new System.Drawing.Size(203, 180);
            this.lsv_Order_Summary_Customers.TabIndex = 93;
            this.lsv_Order_Summary_Customers.UseCompatibleStateImageBehavior = false;
            // 
            // tbl_Order_Summary_Cottage_Services
            // 
            this.tbl_Order_Summary_Cottage_Services.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_Order_Summary_Cottage_Services.ColumnCount = 1;
            this.tbl_Order_Summary_Cottage_Services.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Order_Summary_Cottage_Services.Controls.Add(this.lbl_Order_Summary_Cottages, 0, 0);
            this.tbl_Order_Summary_Cottage_Services.Controls.Add(this.lsv_Order_Summary_Cottages, 0, 1);
            this.tbl_Order_Summary_Cottage_Services.Controls.Add(this.lsv_Order_Summary_Services, 0, 3);
            this.tbl_Order_Summary_Cottage_Services.Controls.Add(this.lbl_Order_Summary_Services, 0, 2);
            this.tbl_Order_Summary_Cottage_Services.Controls.Add(this.tbl_Order_Summary_Buttons, 0, 4);
            this.tbl_Order_Summary_Cottage_Services.Location = new System.Drawing.Point(8, 308);
            this.tbl_Order_Summary_Cottage_Services.Name = "tbl_Order_Summary_Cottage_Services";
            this.tbl_Order_Summary_Cottage_Services.RowCount = 5;
            this.tbl_Order_Summary_Cottage_Services.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_Order_Summary_Cottage_Services.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.63388F));
            this.tbl_Order_Summary_Cottage_Services.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_Order_Summary_Cottage_Services.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.36612F));
            this.tbl_Order_Summary_Cottage_Services.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tbl_Order_Summary_Cottage_Services.Size = new System.Drawing.Size(213, 284);
            this.tbl_Order_Summary_Cottage_Services.TabIndex = 1;
            // 
            // lbl_Order_Summary_Cottages
            // 
            this.lbl_Order_Summary_Cottages.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Order_Summary_Cottages.AutoSize = true;
            this.lbl_Order_Summary_Cottages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Order_Summary_Cottages.Location = new System.Drawing.Point(72, 0);
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
            this.lsv_Order_Summary_Cottages.Location = new System.Drawing.Point(3, 23);
            this.lsv_Order_Summary_Cottages.Name = "lsv_Order_Summary_Cottages";
            this.lsv_Order_Summary_Cottages.Size = new System.Drawing.Size(207, 83);
            this.lsv_Order_Summary_Cottages.TabIndex = 50;
            this.lsv_Order_Summary_Cottages.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_Order_Summary_Services
            // 
            this.lbl_Order_Summary_Services.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Order_Summary_Services.AutoSize = true;
            this.lbl_Order_Summary_Services.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Order_Summary_Services.Location = new System.Drawing.Point(50, 109);
            this.lbl_Order_Summary_Services.Name = "lbl_Order_Summary_Services";
            this.lbl_Order_Summary_Services.Size = new System.Drawing.Size(112, 20);
            this.lbl_Order_Summary_Services.TabIndex = 51;
            this.lbl_Order_Summary_Services.Text = "Valitut palvelut";
            // 
            // lsv_Order_Summary_Services
            // 
            this.lsv_Order_Summary_Services.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsv_Order_Summary_Services.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lsv_Order_Summary_Services.Location = new System.Drawing.Point(3, 132);
            this.lsv_Order_Summary_Services.Name = "lsv_Order_Summary_Services";
            this.lsv_Order_Summary_Services.Size = new System.Drawing.Size(207, 88);
            this.lsv_Order_Summary_Services.TabIndex = 52;
            this.lsv_Order_Summary_Services.UseCompatibleStateImageBehavior = false;
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
            this.tbl_Order_Summary_Buttons.Location = new System.Drawing.Point(3, 226);
            this.tbl_Order_Summary_Buttons.Name = "tbl_Order_Summary_Buttons";
            this.tbl_Order_Summary_Buttons.RowCount = 1;
            this.tbl_Order_Summary_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Order_Summary_Buttons.Size = new System.Drawing.Size(207, 55);
            this.tbl_Order_Summary_Buttons.TabIndex = 53;
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
            // btn_Order_Summary_Next_Page
            // 
            this.btn_Order_Summary_Next_Page.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Order_Summary_Next_Page.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Order_Summary_Next_Page.BackgroundImage")));
            this.btn_Order_Summary_Next_Page.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Order_Summary_Next_Page.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Order_Summary_Next_Page.Location = new System.Drawing.Point(156, 3);
            this.btn_Order_Summary_Next_Page.Name = "btn_Order_Summary_Next_Page";
            this.btn_Order_Summary_Next_Page.Size = new System.Drawing.Size(48, 48);
            this.btn_Order_Summary_Next_Page.TabIndex = 53;
            this.btn_Order_Summary_Next_Page.UseVisualStyleBackColor = true;
            // 
            // Main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 681);
            this.Controls.Add(this.tab_Menu);
            this.Name = "Main_window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MahtiMökit";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_window_Load);
            this.tab_Menu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tbl_Order_base.ResumeLayout(false);
            this.tbl_Order_1st_Col_Office_Customer.ResumeLayout(false);
            this.tbl_Order_1st_Col_Office.ResumeLayout(false);
            this.tbl_Order_1st_Col_Office.PerformLayout();
            this.tbl_Order_1st_Col_Customer.ResumeLayout(false);
            this.tbl_Order_1st_Col_Customer.PerformLayout();
            this.tbl_Order_Customer_Search.ResumeLayout(false);
            this.tbl_Order_Customer_Search.PerformLayout();
            this.tbl_Order_2nd_Col_Cottage.ResumeLayout(false);
            this.tbl_Order_2nd_Col_Cottage.PerformLayout();
            this.tbl_Order_3rd_Col_Cottage_Summary_Services.ResumeLayout(false);
            this.tbl_Order_3rd_Col_Cottage_Summary.ResumeLayout(false);
            this.tbl_Order_3rd_Col_Cottage_Summary.PerformLayout();
            this.tbl_Order_3rd_Col_Services.ResumeLayout(false);
            this.tbl_Order_3rd_Col_Services.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.grb_Services.ResumeLayout(false);
            this.grb_Services.PerformLayout();
            this.grb_Cottages.ResumeLayout(false);
            this.grb_Cottages.PerformLayout();
            this.grb_Customer_Management.ResumeLayout(false);
            this.grb_Customer_Management.PerformLayout();
            this.grb_Office.ResumeLayout(false);
            this.grb_Office.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tbl_4th_Col_Summary.ResumeLayout(false);
            this.tbl_Order_Summary_Office_Customers.ResumeLayout(false);
            this.tbl_Order_Summary_Office_Customers.PerformLayout();
            this.tbl_Order_Summary_Cottage_Services.ResumeLayout(false);
            this.tbl_Order_Summary_Cottage_Services.PerformLayout();
            this.tbl_Order_Summary_Buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_Menu;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox grb_Services;
        private System.Windows.Forms.Button btn_Services_delete;
        private System.Windows.Forms.Button btn_Services_edit;
        private System.Windows.Forms.Button btn_Services_add;
        private System.Windows.Forms.Button btn_Services_search;
        private System.Windows.Forms.Label lbl_Services;
        private System.Windows.Forms.TextBox txt_Services_search;
        private System.Windows.Forms.ListView lsv_Services_all;
        private System.Windows.Forms.GroupBox grb_Cottages;
        private System.Windows.Forms.Button btn_Cottages_delete;
        private System.Windows.Forms.Button btn_Cottages_edit;
        private System.Windows.Forms.Button btn_Cottages_add;
        private System.Windows.Forms.Button btn_Cottages_search;
        private System.Windows.Forms.Label lbl_Cottages;
        private System.Windows.Forms.TextBox txt_Cottages_search;
        private System.Windows.Forms.ListView lsv_Cottages_all;
        private System.Windows.Forms.GroupBox grb_Customer_Management;
        private System.Windows.Forms.Button btn_Customer_delete;
        private System.Windows.Forms.Button btn_Customer_edit;
        private System.Windows.Forms.Button btn_Customer_add;
        private System.Windows.Forms.Button btn_Customer_search;
        private System.Windows.Forms.Label lbl_Customer_Management;
        private System.Windows.Forms.TextBox txt_Customer_search;
        private System.Windows.Forms.ListView lsv_Customers_all;
        private System.Windows.Forms.GroupBox grb_Office;
        private System.Windows.Forms.Button btn_Office_delete;
        private System.Windows.Forms.Button btn_Office_edit;
        private System.Windows.Forms.Button btn_Office_add;
        private System.Windows.Forms.ComboBox cbo_Office_select;
        private System.Windows.Forms.Label lbl_Office;
        private System.Windows.Forms.Button btn_Remove_All_Files;
        private System.Windows.Forms.Label lbl_Remove_All_Files;
        private System.Windows.Forms.ComboBox cbo_Default_Office_select;
        private System.Windows.Forms.Label lbl_Default_Office;
        private System.Windows.Forms.Label lbl_Font_Example;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_System_Font;
        private System.Windows.Forms.ComboBox cbo_Language_Select;
        private System.Windows.Forms.Label lbl_System_Language;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tbl_Order_base;
        private System.Windows.Forms.TableLayoutPanel tbl_Order_1st_Col_Office_Customer;
        private System.Windows.Forms.TableLayoutPanel tbl_Order_Customers;
        private System.Windows.Forms.TableLayoutPanel tbl_Order_1st_Col_Office;
        private System.Windows.Forms.ComboBox cmb_Order_Office_Select;
        private System.Windows.Forms.Label lbl_Order_Office;
        private System.Windows.Forms.TableLayoutPanel tbl_Order_1st_Col_Customer;
        private System.Windows.Forms.TableLayoutPanel tbl_Order_Customer_Search;
        private System.Windows.Forms.ListView lsv_Order_Customers_All;
        private System.Windows.Forms.Button btn_Order_Customers_Search;
        private System.Windows.Forms.TextBox txt_Order_Customers_Search;
        private System.Windows.Forms.Label lbl_Order_Customers;
        private System.Windows.Forms.TableLayoutPanel tbl_Order_2nd_Col_Cottage;
        private System.Windows.Forms.Label lbl_Order_Cottage;
        private System.Windows.Forms.Label lbl_Order_Cottage_Begin;
        private System.Windows.Forms.Label lbl_Order_Cottage_End;
        private System.Windows.Forms.MonthCalendar cal_Order_Cottage_End;
        private System.Windows.Forms.Label lbl_Order_Cottage_Selection;
        private System.Windows.Forms.MonthCalendar cal_Order_Cottage_Begin;
        private System.Windows.Forms.Button Btn_Order_Cottage_Add;
        private System.Windows.Forms.ListView lsv_Order_Cottages_All;
        private System.Windows.Forms.Button btn_Order_Customers_Add;
        private System.Windows.Forms.TableLayoutPanel tbl_Order_3rd_Col_Cottage_Summary_Services;
        private System.Windows.Forms.TableLayoutPanel tbl_Order_3rd_Col_Cottage_Summary;
        private System.Windows.Forms.Label lbl_Order_Cottage_Summary_Price;
        private System.Windows.Forms.Label lbl_Order_Cottage_Summary;
        private System.Windows.Forms.Label lbl_Order_Cottage_Summary_End;
        private System.Windows.Forms.Label lbl_Order_Cottage_Summary_Begin;
        private System.Windows.Forms.Label lbl_Order_Cottage_Summary_Customers;
        private System.Windows.Forms.Label lbl_Order_Cottage_Max_Customers;
        private System.Windows.Forms.TableLayoutPanel tbl_Order_3rd_Col_Services;
        private System.Windows.Forms.Button btn_Order_Service_add;
        private System.Windows.Forms.Label lbl_Order_Services;
        private System.Windows.Forms.ListView lsv_Order_Services_All;
        private System.Windows.Forms.TableLayoutPanel tbl_4th_Col_Summary;
        private System.Windows.Forms.TableLayoutPanel tbl_Order_Summary_Office_Customers;
        private System.Windows.Forms.ListView lsv_Order_Summary_Customers;
        private System.Windows.Forms.Label lbl_Order_Summary;
        private System.Windows.Forms.Label lbl_Order_Summary_Office;
        private System.Windows.Forms.Label lbl_Order_Summary_Customers;
        private System.Windows.Forms.TableLayoutPanel tbl_Order_Summary_Cottage_Services;
        private System.Windows.Forms.Label lbl_Order_Summary_Cottages;
        private System.Windows.Forms.ListView lsv_Order_Summary_Cottages;
        private System.Windows.Forms.ListView lsv_Order_Summary_Services;
        private System.Windows.Forms.Label lbl_Order_Summary_Services;
        private System.Windows.Forms.TableLayoutPanel tbl_Order_Summary_Buttons;
        private System.Windows.Forms.Button btn_Order_Summary_Next_Page;
        private System.Windows.Forms.Button btn_Order_Summary_Delete_From_List;
    }
}