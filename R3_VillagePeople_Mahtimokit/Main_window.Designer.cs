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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Toimipisteen valinta");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Asiakkaiden valinta");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Mökin valinta");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Mökin yhteenveto");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Lisäpalveluiden valinta");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Tilauksen yhteenveto");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Uusi varaus", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Asiakkaiden hallinta");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Toimipisteen valinta");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Toimipisteen palvelut");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Toimipisteen mökit");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Tietojen hallinta", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Varaushistoria");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Asetukset");
            this.tab_Menu = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grb_Order_Customers = new System.Windows.Forms.GroupBox();
            this.lbl_Order_Customers = new System.Windows.Forms.Label();
            this.btn_Order_Customers_Search = new System.Windows.Forms.Button();
            this.txt_Order_Customers_Search = new System.Windows.Forms.TextBox();
            this.lsv_Order_Customers_All = new System.Windows.Forms.ListView();
            this.btn_Order_Customers_Add = new System.Windows.Forms.Button();
            this.grb_Order_Office = new System.Windows.Forms.GroupBox();
            this.cmb_Order_Office_Select = new System.Windows.Forms.ComboBox();
            this.lbl_Order_Office = new System.Windows.Forms.Label();
            this.grb_Order_Summary = new System.Windows.Forms.GroupBox();
            this.lbl_Order_Summary_Office = new System.Windows.Forms.Label();
            this.btn_Order_Summary_Delete_From_List = new System.Windows.Forms.Button();
            this.lsv_Order_Summary_Customers = new System.Windows.Forms.ListView();
            this.lsv_Order_Summary_Cottages = new System.Windows.Forms.ListView();
            this.lbl_Order_Summary_Services = new System.Windows.Forms.Label();
            this.lbl_Order_Summary_Customers = new System.Windows.Forms.Label();
            this.lbl_Order_Summary_Cottages = new System.Windows.Forms.Label();
            this.lbl_Order_Summary = new System.Windows.Forms.Label();
            this.lsv_Order_Summary_Services = new System.Windows.Forms.ListView();
            this.btn_Order_Summary_Next_Page = new System.Windows.Forms.Button();
            this.grb_Order_Services = new System.Windows.Forms.GroupBox();
            this.lbl_Order_Service_Price = new System.Windows.Forms.Label();
            this.lbl_Order_Service_Description = new System.Windows.Forms.Label();
            this.lbl_Order_Service_Max_Persons = new System.Windows.Forms.Label();
            this.lbl_Order_Service_Details = new System.Windows.Forms.Label();
            this.cmb_Order_Service_Selection = new System.Windows.Forms.ComboBox();
            this.lbl_Order_Services = new System.Windows.Forms.Label();
            this.btn_Order_Service_add = new System.Windows.Forms.Button();
            this.grb_Order_Cottage_Summary = new System.Windows.Forms.GroupBox();
            this.lbl_Order_Cottage_Summary_Price = new System.Windows.Forms.Label();
            this.lbl_Order_Cottage_Summary_Customers = new System.Windows.Forms.Label();
            this.lbl_Order_Cottage_Summary_End = new System.Windows.Forms.Label();
            this.lbl_Order_Cottage_Summary_Begin = new System.Windows.Forms.Label();
            this.lbl_Order_Cottage_Max_Customers = new System.Windows.Forms.Label();
            this.lbl_Order_Cottage_Summary = new System.Windows.Forms.Label();
            this.grb_Order_Cottage = new System.Windows.Forms.GroupBox();
            this.Btn_Order_Cottage_Add = new System.Windows.Forms.Button();
            this.lbl_Order_Cottage = new System.Windows.Forms.Label();
            this.cmb_Order_Cottage_Selection = new System.Windows.Forms.ComboBox();
            this.lbl_Order_Cottage_Selection = new System.Windows.Forms.Label();
            this.lbl_Order_Cottage_End = new System.Windows.Forms.Label();
            this.lbl_Order_Cottage_Begin = new System.Windows.Forms.Label();
            this.cal_Order_Cottage_End = new System.Windows.Forms.MonthCalendar();
            this.cal_Order_Cottage_Begin = new System.Windows.Forms.MonthCalendar();
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
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btn_Remove_All_Files = new System.Windows.Forms.Button();
            this.lbl_Remove_All_Files = new System.Windows.Forms.Label();
            this.cbo_Default_Office_select = new System.Windows.Forms.ComboBox();
            this.lbl_Default_Office = new System.Windows.Forms.Label();
            this.lbl_Font_Example = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_System_Font = new System.Windows.Forms.Label();
            this.cbo_Language_Select = new System.Windows.Forms.ComboBox();
            this.lbl_System_Language = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tab_Menu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grb_Order_Customers.SuspendLayout();
            this.grb_Order_Office.SuspendLayout();
            this.grb_Order_Summary.SuspendLayout();
            this.grb_Order_Services.SuspendLayout();
            this.grb_Order_Cottage_Summary.SuspendLayout();
            this.grb_Order_Cottage.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grb_Services.SuspendLayout();
            this.grb_Cottages.SuspendLayout();
            this.grb_Customer_Management.SuspendLayout();
            this.grb_Office.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_Menu
            // 
            this.tab_Menu.Controls.Add(this.tabPage1);
            this.tab_Menu.Controls.Add(this.tabPage2);
            this.tab_Menu.Controls.Add(this.tabPage3);
            this.tab_Menu.Controls.Add(this.tabPage4);
            this.tab_Menu.Controls.Add(this.tabPage5);
            this.tab_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tab_Menu.Location = new System.Drawing.Point(-3, -2);
            this.tab_Menu.Name = "tab_Menu";
            this.tab_Menu.SelectedIndex = 0;
            this.tab_Menu.Size = new System.Drawing.Size(995, 680);
            this.tab_Menu.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.grb_Order_Customers);
            this.tabPage1.Controls.Add(this.grb_Order_Office);
            this.tabPage1.Controls.Add(this.grb_Order_Summary);
            this.tabPage1.Controls.Add(this.grb_Order_Services);
            this.tabPage1.Controls.Add(this.grb_Order_Cottage_Summary);
            this.tabPage1.Controls.Add(this.grb_Order_Cottage);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(987, 647);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Uusi tilaus";
            // 
            // grb_Order_Customers
            // 
            this.grb_Order_Customers.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grb_Order_Customers.Controls.Add(this.lbl_Order_Customers);
            this.grb_Order_Customers.Controls.Add(this.btn_Order_Customers_Search);
            this.grb_Order_Customers.Controls.Add(this.txt_Order_Customers_Search);
            this.grb_Order_Customers.Controls.Add(this.lsv_Order_Customers_All);
            this.grb_Order_Customers.Controls.Add(this.btn_Order_Customers_Add);
            this.grb_Order_Customers.Location = new System.Drawing.Point(15, 91);
            this.grb_Order_Customers.Name = "grb_Order_Customers";
            this.grb_Order_Customers.Size = new System.Drawing.Size(220, 533);
            this.grb_Order_Customers.TabIndex = 112;
            this.grb_Order_Customers.TabStop = false;
            // 
            // lbl_Order_Customers
            // 
            this.lbl_Order_Customers.AutoSize = true;
            this.lbl_Order_Customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Order_Customers.Location = new System.Drawing.Point(22, 11);
            this.lbl_Order_Customers.Name = "lbl_Order_Customers";
            this.lbl_Order_Customers.Size = new System.Drawing.Size(163, 20);
            this.lbl_Order_Customers.TabIndex = 102;
            this.lbl_Order_Customers.Text = "Asiakkaiden valinta";
            // 
            // btn_Order_Customers_Search
            // 
            this.btn_Order_Customers_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Order_Customers_Search.BackgroundImage")));
            this.btn_Order_Customers_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Order_Customers_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Order_Customers_Search.Location = new System.Drawing.Point(153, 442);
            this.btn_Order_Customers_Search.Name = "btn_Order_Customers_Search";
            this.btn_Order_Customers_Search.Size = new System.Drawing.Size(32, 32);
            this.btn_Order_Customers_Search.TabIndex = 101;
            this.btn_Order_Customers_Search.UseVisualStyleBackColor = true;
            // 
            // txt_Order_Customers_Search
            // 
            this.txt_Order_Customers_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Order_Customers_Search.Location = new System.Drawing.Point(19, 446);
            this.txt_Order_Customers_Search.Name = "txt_Order_Customers_Search";
            this.txt_Order_Customers_Search.Size = new System.Drawing.Size(131, 26);
            this.txt_Order_Customers_Search.TabIndex = 100;
            // 
            // lsv_Order_Customers_All
            // 
            this.lsv_Order_Customers_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lsv_Order_Customers_All.Location = new System.Drawing.Point(19, 39);
            this.lsv_Order_Customers_All.Name = "lsv_Order_Customers_All";
            this.lsv_Order_Customers_All.Size = new System.Drawing.Size(193, 402);
            this.lsv_Order_Customers_All.TabIndex = 99;
            this.lsv_Order_Customers_All.UseCompatibleStateImageBehavior = false;
            // 
            // btn_Order_Customers_Add
            // 
            this.btn_Order_Customers_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Order_Customers_Add.Location = new System.Drawing.Point(19, 483);
            this.btn_Order_Customers_Add.Name = "btn_Order_Customers_Add";
            this.btn_Order_Customers_Add.Size = new System.Drawing.Size(193, 41);
            this.btn_Order_Customers_Add.TabIndex = 98;
            this.btn_Order_Customers_Add.Text = "Lisää asiakas tilaukseen";
            this.btn_Order_Customers_Add.UseVisualStyleBackColor = true;
            // 
            // grb_Order_Office
            // 
            this.grb_Order_Office.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grb_Order_Office.Controls.Add(this.cmb_Order_Office_Select);
            this.grb_Order_Office.Controls.Add(this.lbl_Order_Office);
            this.grb_Order_Office.Location = new System.Drawing.Point(17, 10);
            this.grb_Order_Office.Name = "grb_Order_Office";
            this.grb_Order_Office.Size = new System.Drawing.Size(218, 73);
            this.grb_Order_Office.TabIndex = 111;
            this.grb_Order_Office.TabStop = false;
            // 
            // cmb_Order_Office_Select
            // 
            this.cmb_Order_Office_Select.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Order_Office_Select.FormattingEnabled = true;
            this.cmb_Order_Office_Select.Location = new System.Drawing.Point(13, 40);
            this.cmb_Order_Office_Select.Name = "cmb_Order_Office_Select";
            this.cmb_Order_Office_Select.Size = new System.Drawing.Size(186, 28);
            this.cmb_Order_Office_Select.TabIndex = 104;
            this.cmb_Order_Office_Select.Text = "Valitse toimipiste";
            // 
            // lbl_Order_Office
            // 
            this.lbl_Order_Office.AutoSize = true;
            this.lbl_Order_Office.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Order_Office.Location = new System.Drawing.Point(9, 5);
            this.lbl_Order_Office.Name = "lbl_Order_Office";
            this.lbl_Order_Office.Size = new System.Drawing.Size(167, 20);
            this.lbl_Order_Office.TabIndex = 103;
            this.lbl_Order_Office.Text = "Toimipisteen valinta";
            // 
            // grb_Order_Summary
            // 
            this.grb_Order_Summary.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grb_Order_Summary.Controls.Add(this.lbl_Order_Summary_Office);
            this.grb_Order_Summary.Controls.Add(this.btn_Order_Summary_Delete_From_List);
            this.grb_Order_Summary.Controls.Add(this.lsv_Order_Summary_Customers);
            this.grb_Order_Summary.Controls.Add(this.lsv_Order_Summary_Cottages);
            this.grb_Order_Summary.Controls.Add(this.lbl_Order_Summary_Services);
            this.grb_Order_Summary.Controls.Add(this.lbl_Order_Summary_Customers);
            this.grb_Order_Summary.Controls.Add(this.lbl_Order_Summary_Cottages);
            this.grb_Order_Summary.Controls.Add(this.lbl_Order_Summary);
            this.grb_Order_Summary.Controls.Add(this.lsv_Order_Summary_Services);
            this.grb_Order_Summary.Controls.Add(this.btn_Order_Summary_Next_Page);
            this.grb_Order_Summary.Location = new System.Drawing.Point(729, 10);
            this.grb_Order_Summary.Name = "grb_Order_Summary";
            this.grb_Order_Summary.Size = new System.Drawing.Size(242, 614);
            this.grb_Order_Summary.TabIndex = 110;
            this.grb_Order_Summary.TabStop = false;
            // 
            // lbl_Order_Summary_Office
            // 
            this.lbl_Order_Summary_Office.AutoSize = true;
            this.lbl_Order_Summary_Office.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Order_Summary_Office.Location = new System.Drawing.Point(18, 57);
            this.lbl_Order_Summary_Office.Name = "lbl_Order_Summary_Office";
            this.lbl_Order_Summary_Office.Size = new System.Drawing.Size(88, 20);
            this.lbl_Order_Summary_Office.TabIndex = 90;
            this.lbl_Order_Summary_Office.Text = "Toimipiste: ";
            // 
            // btn_Order_Summary_Delete_From_List
            // 
            this.btn_Order_Summary_Delete_From_List.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Order_Summary_Delete_From_List.BackgroundImage")));
            this.btn_Order_Summary_Delete_From_List.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Order_Summary_Delete_From_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Order_Summary_Delete_From_List.Location = new System.Drawing.Point(22, 559);
            this.btn_Order_Summary_Delete_From_List.Name = "btn_Order_Summary_Delete_From_List";
            this.btn_Order_Summary_Delete_From_List.Size = new System.Drawing.Size(44, 43);
            this.btn_Order_Summary_Delete_From_List.TabIndex = 51;
            this.btn_Order_Summary_Delete_From_List.UseVisualStyleBackColor = true;
            // 
            // lsv_Order_Summary_Customers
            // 
            this.lsv_Order_Summary_Customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lsv_Order_Summary_Customers.Location = new System.Drawing.Point(22, 136);
            this.lsv_Order_Summary_Customers.Name = "lsv_Order_Summary_Customers";
            this.lsv_Order_Summary_Customers.Size = new System.Drawing.Size(197, 53);
            this.lsv_Order_Summary_Customers.TabIndex = 50;
            this.lsv_Order_Summary_Customers.UseCompatibleStateImageBehavior = false;
            // 
            // lsv_Order_Summary_Cottages
            // 
            this.lsv_Order_Summary_Cottages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lsv_Order_Summary_Cottages.Location = new System.Drawing.Point(22, 236);
            this.lsv_Order_Summary_Cottages.Name = "lsv_Order_Summary_Cottages";
            this.lsv_Order_Summary_Cottages.Size = new System.Drawing.Size(197, 70);
            this.lsv_Order_Summary_Cottages.TabIndex = 49;
            this.lsv_Order_Summary_Cottages.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_Order_Summary_Services
            // 
            this.lbl_Order_Summary_Services.AutoSize = true;
            this.lbl_Order_Summary_Services.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Order_Summary_Services.Location = new System.Drawing.Point(63, 325);
            this.lbl_Order_Summary_Services.Name = "lbl_Order_Summary_Services";
            this.lbl_Order_Summary_Services.Size = new System.Drawing.Size(112, 20);
            this.lbl_Order_Summary_Services.TabIndex = 48;
            this.lbl_Order_Summary_Services.Text = "Valitut palvelut";
            // 
            // lbl_Order_Summary_Customers
            // 
            this.lbl_Order_Summary_Customers.AutoSize = true;
            this.lbl_Order_Summary_Customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Order_Summary_Customers.Location = new System.Drawing.Point(70, 108);
            this.lbl_Order_Summary_Customers.Name = "lbl_Order_Summary_Customers";
            this.lbl_Order_Summary_Customers.Size = new System.Drawing.Size(79, 20);
            this.lbl_Order_Summary_Customers.TabIndex = 47;
            this.lbl_Order_Summary_Customers.Text = "Asiakkaat";
            // 
            // lbl_Order_Summary_Cottages
            // 
            this.lbl_Order_Summary_Cottages.AutoSize = true;
            this.lbl_Order_Summary_Cottages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Order_Summary_Cottages.Location = new System.Drawing.Point(81, 203);
            this.lbl_Order_Summary_Cottages.Name = "lbl_Order_Summary_Cottages";
            this.lbl_Order_Summary_Cottages.Size = new System.Drawing.Size(68, 20);
            this.lbl_Order_Summary_Cottages.TabIndex = 46;
            this.lbl_Order_Summary_Cottages.Text = "Majoitus";
            // 
            // lbl_Order_Summary
            // 
            this.lbl_Order_Summary.AutoSize = true;
            this.lbl_Order_Summary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Order_Summary.Location = new System.Drawing.Point(18, 15);
            this.lbl_Order_Summary.Name = "lbl_Order_Summary";
            this.lbl_Order_Summary.Size = new System.Drawing.Size(178, 20);
            this.lbl_Order_Summary.TabIndex = 45;
            this.lbl_Order_Summary.Text = "Tilauksen yhteenveto";
            // 
            // lsv_Order_Summary_Services
            // 
            this.lsv_Order_Summary_Services.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lsv_Order_Summary_Services.Location = new System.Drawing.Point(22, 348);
            this.lsv_Order_Summary_Services.Name = "lsv_Order_Summary_Services";
            this.lsv_Order_Summary_Services.Size = new System.Drawing.Size(197, 205);
            this.lsv_Order_Summary_Services.TabIndex = 44;
            this.lsv_Order_Summary_Services.UseCompatibleStateImageBehavior = false;
            // 
            // btn_Order_Summary_Next_Page
            // 
            this.btn_Order_Summary_Next_Page.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Order_Summary_Next_Page.BackgroundImage")));
            this.btn_Order_Summary_Next_Page.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Order_Summary_Next_Page.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Order_Summary_Next_Page.Location = new System.Drawing.Point(173, 559);
            this.btn_Order_Summary_Next_Page.Name = "btn_Order_Summary_Next_Page";
            this.btn_Order_Summary_Next_Page.Size = new System.Drawing.Size(46, 43);
            this.btn_Order_Summary_Next_Page.TabIndex = 43;
            this.btn_Order_Summary_Next_Page.UseVisualStyleBackColor = true;
            // 
            // grb_Order_Services
            // 
            this.grb_Order_Services.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grb_Order_Services.Controls.Add(this.lbl_Order_Service_Price);
            this.grb_Order_Services.Controls.Add(this.lbl_Order_Service_Description);
            this.grb_Order_Services.Controls.Add(this.lbl_Order_Service_Max_Persons);
            this.grb_Order_Services.Controls.Add(this.lbl_Order_Service_Details);
            this.grb_Order_Services.Controls.Add(this.cmb_Order_Service_Selection);
            this.grb_Order_Services.Controls.Add(this.lbl_Order_Services);
            this.grb_Order_Services.Controls.Add(this.btn_Order_Service_add);
            this.grb_Order_Services.Location = new System.Drawing.Point(509, 221);
            this.grb_Order_Services.Name = "grb_Order_Services";
            this.grb_Order_Services.Size = new System.Drawing.Size(205, 403);
            this.grb_Order_Services.TabIndex = 109;
            this.grb_Order_Services.TabStop = false;
            // 
            // lbl_Order_Service_Price
            // 
            this.lbl_Order_Service_Price.AutoSize = true;
            this.lbl_Order_Service_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Order_Service_Price.Location = new System.Drawing.Point(3, 270);
            this.lbl_Order_Service_Price.Name = "lbl_Order_Service_Price";
            this.lbl_Order_Service_Price.Size = new System.Drawing.Size(51, 20);
            this.lbl_Order_Service_Price.TabIndex = 89;
            this.lbl_Order_Service_Price.Text = "Hinta:";
            // 
            // lbl_Order_Service_Description
            // 
            this.lbl_Order_Service_Description.AutoSize = true;
            this.lbl_Order_Service_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Order_Service_Description.Location = new System.Drawing.Point(5, 139);
            this.lbl_Order_Service_Description.Name = "lbl_Order_Service_Description";
            this.lbl_Order_Service_Description.Size = new System.Drawing.Size(61, 20);
            this.lbl_Order_Service_Description.TabIndex = 87;
            this.lbl_Order_Service_Description.Text = "Kuvaus";
            // 
            // lbl_Order_Service_Max_Persons
            // 
            this.lbl_Order_Service_Max_Persons.AutoSize = true;
            this.lbl_Order_Service_Max_Persons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Order_Service_Max_Persons.Location = new System.Drawing.Point(2, 226);
            this.lbl_Order_Service_Max_Persons.Name = "lbl_Order_Service_Max_Persons";
            this.lbl_Order_Service_Max_Persons.Size = new System.Drawing.Size(101, 20);
            this.lbl_Order_Service_Max_Persons.TabIndex = 85;
            this.lbl_Order_Service_Max_Persons.Text = "Max henkilöt:";
            // 
            // lbl_Order_Service_Details
            // 
            this.lbl_Order_Service_Details.AutoSize = true;
            this.lbl_Order_Service_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Order_Service_Details.Location = new System.Drawing.Point(2, 109);
            this.lbl_Order_Service_Details.Name = "lbl_Order_Service_Details";
            this.lbl_Order_Service_Details.Size = new System.Drawing.Size(127, 20);
            this.lbl_Order_Service_Details.TabIndex = 84;
            this.lbl_Order_Service_Details.Text = "Palvelun tiedot";
            // 
            // cmb_Order_Service_Selection
            // 
            this.cmb_Order_Service_Selection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Order_Service_Selection.FormattingEnabled = true;
            this.cmb_Order_Service_Selection.Items.AddRange(new object[] {
            "Airsoftaus",
            "Hevosajelu",
            "Koiravaljakkoajelu",
            "Porosafari",
            "Vesiskootteriajelu"});
            this.cmb_Order_Service_Selection.Location = new System.Drawing.Point(6, 58);
            this.cmb_Order_Service_Selection.Name = "cmb_Order_Service_Selection";
            this.cmb_Order_Service_Selection.Size = new System.Drawing.Size(185, 28);
            this.cmb_Order_Service_Selection.TabIndex = 73;
            // 
            // lbl_Order_Services
            // 
            this.lbl_Order_Services.AutoSize = true;
            this.lbl_Order_Services.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Order_Services.Location = new System.Drawing.Point(2, 13);
            this.lbl_Order_Services.Name = "lbl_Order_Services";
            this.lbl_Order_Services.Size = new System.Drawing.Size(189, 20);
            this.lbl_Order_Services.TabIndex = 71;
            this.lbl_Order_Services.Text = "Lisäpalveluiden valinta";
            // 
            // btn_Order_Service_add
            // 
            this.btn_Order_Service_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Order_Service_add.Location = new System.Drawing.Point(6, 353);
            this.btn_Order_Service_add.Name = "btn_Order_Service_add";
            this.btn_Order_Service_add.Size = new System.Drawing.Size(185, 41);
            this.btn_Order_Service_add.TabIndex = 60;
            this.btn_Order_Service_add.Text = "Lisää palvelu tilaukseen";
            this.btn_Order_Service_add.UseVisualStyleBackColor = true;
            // 
            // grb_Order_Cottage_Summary
            // 
            this.grb_Order_Cottage_Summary.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grb_Order_Cottage_Summary.Controls.Add(this.lbl_Order_Cottage_Summary_Price);
            this.grb_Order_Cottage_Summary.Controls.Add(this.lbl_Order_Cottage_Summary_Customers);
            this.grb_Order_Cottage_Summary.Controls.Add(this.lbl_Order_Cottage_Summary_End);
            this.grb_Order_Cottage_Summary.Controls.Add(this.lbl_Order_Cottage_Summary_Begin);
            this.grb_Order_Cottage_Summary.Controls.Add(this.lbl_Order_Cottage_Max_Customers);
            this.grb_Order_Cottage_Summary.Controls.Add(this.lbl_Order_Cottage_Summary);
            this.grb_Order_Cottage_Summary.Location = new System.Drawing.Point(509, 10);
            this.grb_Order_Cottage_Summary.Name = "grb_Order_Cottage_Summary";
            this.grb_Order_Cottage_Summary.Size = new System.Drawing.Size(205, 198);
            this.grb_Order_Cottage_Summary.TabIndex = 108;
            this.grb_Order_Cottage_Summary.TabStop = false;
            // 
            // lbl_Order_Cottage_Summary_Price
            // 
            this.lbl_Order_Cottage_Summary_Price.AutoSize = true;
            this.lbl_Order_Cottage_Summary_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Order_Cottage_Summary_Price.Location = new System.Drawing.Point(12, 161);
            this.lbl_Order_Cottage_Summary_Price.Name = "lbl_Order_Cottage_Summary_Price";
            this.lbl_Order_Cottage_Summary_Price.Size = new System.Drawing.Size(51, 20);
            this.lbl_Order_Cottage_Summary_Price.TabIndex = 83;
            this.lbl_Order_Cottage_Summary_Price.Text = "Hinta:";
            // 
            // lbl_Order_Cottage_Summary_Customers
            // 
            this.lbl_Order_Cottage_Summary_Customers.AutoSize = true;
            this.lbl_Order_Cottage_Summary_Customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Order_Cottage_Summary_Customers.Location = new System.Drawing.Point(12, 95);
            this.lbl_Order_Cottage_Summary_Customers.Name = "lbl_Order_Cottage_Summary_Customers";
            this.lbl_Order_Cottage_Summary_Customers.Size = new System.Drawing.Size(139, 20);
            this.lbl_Order_Cottage_Summary_Customers.TabIndex = 82;
            this.lbl_Order_Cottage_Summary_Customers.Text = "Tilauksen henkilöt:";
            // 
            // lbl_Order_Cottage_Summary_End
            // 
            this.lbl_Order_Cottage_Summary_End.AutoSize = true;
            this.lbl_Order_Cottage_Summary_End.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Order_Cottage_Summary_End.Location = new System.Drawing.Point(12, 67);
            this.lbl_Order_Cottage_Summary_End.Name = "lbl_Order_Cottage_Summary_End";
            this.lbl_Order_Cottage_Summary_End.Size = new System.Drawing.Size(91, 20);
            this.lbl_Order_Cottage_Summary_End.TabIndex = 81;
            this.lbl_Order_Cottage_Summary_End.Text = "Lähtöpäivä:";
            // 
            // lbl_Order_Cottage_Summary_Begin
            // 
            this.lbl_Order_Cottage_Summary_Begin.AutoSize = true;
            this.lbl_Order_Cottage_Summary_Begin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Order_Cottage_Summary_Begin.Location = new System.Drawing.Point(12, 40);
            this.lbl_Order_Cottage_Summary_Begin.Name = "lbl_Order_Cottage_Summary_Begin";
            this.lbl_Order_Cottage_Summary_Begin.Size = new System.Drawing.Size(76, 20);
            this.lbl_Order_Cottage_Summary_Begin.TabIndex = 80;
            this.lbl_Order_Cottage_Summary_Begin.Text = "Tulopäivä";
            // 
            // lbl_Order_Cottage_Max_Customers
            // 
            this.lbl_Order_Cottage_Max_Customers.AutoSize = true;
            this.lbl_Order_Cottage_Max_Customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Order_Cottage_Max_Customers.Location = new System.Drawing.Point(12, 128);
            this.lbl_Order_Cottage_Max_Customers.Name = "lbl_Order_Cottage_Max_Customers";
            this.lbl_Order_Cottage_Max_Customers.Size = new System.Drawing.Size(101, 20);
            this.lbl_Order_Cottage_Max_Customers.TabIndex = 79;
            this.lbl_Order_Cottage_Max_Customers.Text = "Max henkilöt:";
            // 
            // lbl_Order_Cottage_Summary
            // 
            this.lbl_Order_Cottage_Summary.AutoSize = true;
            this.lbl_Order_Cottage_Summary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Order_Cottage_Summary.Location = new System.Drawing.Point(12, 12);
            this.lbl_Order_Cottage_Summary.Name = "lbl_Order_Cottage_Summary";
            this.lbl_Order_Cottage_Summary.Size = new System.Drawing.Size(149, 20);
            this.lbl_Order_Cottage_Summary.TabIndex = 78;
            this.lbl_Order_Cottage_Summary.Text = "Mökin yhteenveto";
            // 
            // grb_Order_Cottage
            // 
            this.grb_Order_Cottage.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grb_Order_Cottage.Controls.Add(this.Btn_Order_Cottage_Add);
            this.grb_Order_Cottage.Controls.Add(this.lbl_Order_Cottage);
            this.grb_Order_Cottage.Controls.Add(this.cmb_Order_Cottage_Selection);
            this.grb_Order_Cottage.Controls.Add(this.lbl_Order_Cottage_Selection);
            this.grb_Order_Cottage.Controls.Add(this.lbl_Order_Cottage_End);
            this.grb_Order_Cottage.Controls.Add(this.lbl_Order_Cottage_Begin);
            this.grb_Order_Cottage.Controls.Add(this.cal_Order_Cottage_End);
            this.grb_Order_Cottage.Controls.Add(this.cal_Order_Cottage_Begin);
            this.grb_Order_Cottage.Location = new System.Drawing.Point(251, 10);
            this.grb_Order_Cottage.Name = "grb_Order_Cottage";
            this.grb_Order_Cottage.Size = new System.Drawing.Size(252, 614);
            this.grb_Order_Cottage.TabIndex = 107;
            this.grb_Order_Cottage.TabStop = false;
            // 
            // Btn_Order_Cottage_Add
            // 
            this.Btn_Order_Cottage_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_Order_Cottage_Add.Location = new System.Drawing.Point(6, 564);
            this.Btn_Order_Cottage_Add.Name = "Btn_Order_Cottage_Add";
            this.Btn_Order_Cottage_Add.Size = new System.Drawing.Size(233, 41);
            this.Btn_Order_Cottage_Add.TabIndex = 91;
            this.Btn_Order_Cottage_Add.Text = "Lisää mökki tilaukseen";
            this.Btn_Order_Cottage_Add.UseVisualStyleBackColor = true;
            // 
            // lbl_Order_Cottage
            // 
            this.lbl_Order_Cottage.AutoSize = true;
            this.lbl_Order_Cottage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Order_Cottage.Location = new System.Drawing.Point(8, 8);
            this.lbl_Order_Cottage.Name = "lbl_Order_Cottage";
            this.lbl_Order_Cottage.Size = new System.Drawing.Size(113, 20);
            this.lbl_Order_Cottage.TabIndex = 77;
            this.lbl_Order_Cottage.Text = "Mökin valinta";
            // 
            // cmb_Order_Cottage_Selection
            // 
            this.cmb_Order_Cottage_Selection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Order_Cottage_Selection.FormattingEnabled = true;
            this.cmb_Order_Cottage_Selection.Location = new System.Drawing.Point(12, 504);
            this.cmb_Order_Cottage_Selection.Name = "cmb_Order_Cottage_Selection";
            this.cmb_Order_Cottage_Selection.Size = new System.Drawing.Size(227, 28);
            this.cmb_Order_Cottage_Selection.TabIndex = 72;
            this.cmb_Order_Cottage_Selection.Text = "Valitse Mökki";
            // 
            // lbl_Order_Cottage_Selection
            // 
            this.lbl_Order_Cottage_Selection.AutoSize = true;
            this.lbl_Order_Cottage_Selection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Order_Cottage_Selection.Location = new System.Drawing.Point(8, 481);
            this.lbl_Order_Cottage_Selection.Name = "lbl_Order_Cottage_Selection";
            this.lbl_Order_Cottage_Selection.Size = new System.Drawing.Size(100, 20);
            this.lbl_Order_Cottage_Selection.TabIndex = 70;
            this.lbl_Order_Cottage_Selection.Text = "Mökin valinta";
            // 
            // lbl_Order_Cottage_End
            // 
            this.lbl_Order_Cottage_End.AutoSize = true;
            this.lbl_Order_Cottage_End.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Order_Cottage_End.Location = new System.Drawing.Point(65, 279);
            this.lbl_Order_Cottage_End.Name = "lbl_Order_Cottage_End";
            this.lbl_Order_Cottage_End.Size = new System.Drawing.Size(87, 20);
            this.lbl_Order_Cottage_End.TabIndex = 69;
            this.lbl_Order_Cottage_End.Text = "Lähtöpäivä";
            // 
            // lbl_Order_Cottage_Begin
            // 
            this.lbl_Order_Cottage_Begin.AutoSize = true;
            this.lbl_Order_Cottage_Begin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Order_Cottage_Begin.Location = new System.Drawing.Point(76, 67);
            this.lbl_Order_Cottage_Begin.Name = "lbl_Order_Cottage_Begin";
            this.lbl_Order_Cottage_Begin.Size = new System.Drawing.Size(76, 20);
            this.lbl_Order_Cottage_Begin.TabIndex = 68;
            this.lbl_Order_Cottage_Begin.Text = "Tulopäivä";
            // 
            // cal_Order_Cottage_End
            // 
            this.cal_Order_Cottage_End.Location = new System.Drawing.Point(12, 308);
            this.cal_Order_Cottage_End.Name = "cal_Order_Cottage_End";
            this.cal_Order_Cottage_End.TabIndex = 67;
            this.cal_Order_Cottage_End.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateChanged);
            // 
            // cal_Order_Cottage_Begin
            // 
            this.cal_Order_Cottage_Begin.Location = new System.Drawing.Point(12, 95);
            this.cal_Order_Cottage_Begin.Name = "cal_Order_Cottage_Begin";
            this.cal_Order_Cottage_Begin.TabIndex = 66;
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
            this.tabPage2.Size = new System.Drawing.Size(987, 647);
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
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(987, 647);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tilaushistoria";
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
            this.tabPage4.Size = new System.Drawing.Size(987, 647);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Asetukset";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage5.Controls.Add(this.treeView1);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(987, 647);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Ohjeet";
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
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(23, 25);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node4";
            treeNode1.Text = "Toimipisteen valinta";
            treeNode2.Name = "Node5";
            treeNode2.Text = "Asiakkaiden valinta";
            treeNode3.Name = "Node6";
            treeNode3.Text = "Mökin valinta";
            treeNode4.Name = "Node7";
            treeNode4.Text = "Mökin yhteenveto";
            treeNode5.Name = "Node8";
            treeNode5.Text = "Lisäpalveluiden valinta";
            treeNode6.Name = "Node9";
            treeNode6.Text = "Tilauksen yhteenveto";
            treeNode7.Name = "Node0";
            treeNode7.Text = "Uusi varaus";
            treeNode8.Name = "Node10";
            treeNode8.Text = "Asiakkaiden hallinta";
            treeNode9.Name = "Node11";
            treeNode9.Text = "Toimipisteen valinta";
            treeNode10.Name = "Node12";
            treeNode10.Text = "Toimipisteen palvelut";
            treeNode11.Name = "Node13";
            treeNode11.Text = "Toimipisteen mökit";
            treeNode12.Name = "Node1";
            treeNode12.Text = "Tietojen hallinta";
            treeNode13.Name = "Node2";
            treeNode13.Text = "Varaushistoria";
            treeNode14.Name = "Node3";
            treeNode14.Text = "Asetukset";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode12,
            treeNode13,
            treeNode14});
            this.treeView1.Size = new System.Drawing.Size(308, 586);
            this.treeView1.TabIndex = 0;
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
            this.Load += new System.EventHandler(this.Main_window_Load);
            this.tab_Menu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grb_Order_Customers.ResumeLayout(false);
            this.grb_Order_Customers.PerformLayout();
            this.grb_Order_Office.ResumeLayout(false);
            this.grb_Order_Office.PerformLayout();
            this.grb_Order_Summary.ResumeLayout(false);
            this.grb_Order_Summary.PerformLayout();
            this.grb_Order_Services.ResumeLayout(false);
            this.grb_Order_Services.PerformLayout();
            this.grb_Order_Cottage_Summary.ResumeLayout(false);
            this.grb_Order_Cottage_Summary.PerformLayout();
            this.grb_Order_Cottage.ResumeLayout(false);
            this.grb_Order_Cottage.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.grb_Services.ResumeLayout(false);
            this.grb_Services.PerformLayout();
            this.grb_Cottages.ResumeLayout(false);
            this.grb_Cottages.PerformLayout();
            this.grb_Customer_Management.ResumeLayout(false);
            this.grb_Customer_Management.PerformLayout();
            this.grb_Office.ResumeLayout(false);
            this.grb_Office.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_Menu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grb_Order_Customers;
        private System.Windows.Forms.Label lbl_Order_Customers;
        private System.Windows.Forms.Button btn_Order_Customers_Search;
        private System.Windows.Forms.TextBox txt_Order_Customers_Search;
        private System.Windows.Forms.ListView lsv_Order_Customers_All;
        private System.Windows.Forms.Button btn_Order_Customers_Add;
        private System.Windows.Forms.GroupBox grb_Order_Office;
        private System.Windows.Forms.ComboBox cmb_Order_Office_Select;
        private System.Windows.Forms.Label lbl_Order_Office;
        private System.Windows.Forms.GroupBox grb_Order_Summary;
        private System.Windows.Forms.Label lbl_Order_Summary_Office;
        private System.Windows.Forms.Button btn_Order_Summary_Delete_From_List;
        private System.Windows.Forms.ListView lsv_Order_Summary_Customers;
        private System.Windows.Forms.ListView lsv_Order_Summary_Cottages;
        private System.Windows.Forms.Label lbl_Order_Summary_Services;
        private System.Windows.Forms.Label lbl_Order_Summary_Customers;
        private System.Windows.Forms.Label lbl_Order_Summary_Cottages;
        private System.Windows.Forms.Label lbl_Order_Summary;
        private System.Windows.Forms.ListView lsv_Order_Summary_Services;
        private System.Windows.Forms.Button btn_Order_Summary_Next_Page;
        private System.Windows.Forms.GroupBox grb_Order_Services;
        private System.Windows.Forms.Label lbl_Order_Service_Price;
        private System.Windows.Forms.Label lbl_Order_Service_Description;
        private System.Windows.Forms.Label lbl_Order_Service_Max_Persons;
        private System.Windows.Forms.Label lbl_Order_Service_Details;
        private System.Windows.Forms.ComboBox cmb_Order_Service_Selection;
        private System.Windows.Forms.Label lbl_Order_Services;
        private System.Windows.Forms.Button btn_Order_Service_add;
        private System.Windows.Forms.GroupBox grb_Order_Cottage_Summary;
        private System.Windows.Forms.Label lbl_Order_Cottage_Summary_Price;
        private System.Windows.Forms.Label lbl_Order_Cottage_Summary_Customers;
        private System.Windows.Forms.Label lbl_Order_Cottage_Summary_End;
        private System.Windows.Forms.Label lbl_Order_Cottage_Summary_Begin;
        private System.Windows.Forms.Label lbl_Order_Cottage_Max_Customers;
        private System.Windows.Forms.Label lbl_Order_Cottage_Summary;
        private System.Windows.Forms.GroupBox grb_Order_Cottage;
        private System.Windows.Forms.Button Btn_Order_Cottage_Add;
        private System.Windows.Forms.Label lbl_Order_Cottage;
        private System.Windows.Forms.ComboBox cmb_Order_Cottage_Selection;
        private System.Windows.Forms.Label lbl_Order_Cottage_Selection;
        private System.Windows.Forms.Label lbl_Order_Cottage_End;
        private System.Windows.Forms.Label lbl_Order_Cottage_Begin;
        private System.Windows.Forms.MonthCalendar cal_Order_Cottage_End;
        private System.Windows.Forms.MonthCalendar cal_Order_Cottage_Begin;
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

    }
}