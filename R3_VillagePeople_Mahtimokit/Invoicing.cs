using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R3_VillagePeople_Mahtimokit
{
    public partial class frm_Invoicing : Form
    {
        public string customer_firstname;
        public string customer_secondname;
        public string customer_email;
        public string customer_address;
        public string customer_postal_code;
        public string customer_post_office;
        public string customer_country;
        DateTime invoice_date = DateTime.Now.Date;
        public string invoice_id;
        public string customer_y_id;
        public string penalty_interest;
        public string duedate;
        public string remark_date;
        public string virtual_barcode;
        public string receiver_iban;
        public string receiver_bic;
        public string reference_number;
        public string total;

        public frm_Invoicing()
        {
            InitializeComponent();


        }
        private void Invoicing_Load(object sender, EventArgs e)
        {
            // Laitettaan arvot kohilleen laskuun
            txt_Invoicing_Customer_Name_1.Text = customer_firstname + " " + customer_secondname;
            txt_Invoicing_Customer_Name_2.Text = customer_firstname + " " + customer_secondname;
            txt_Invoicing_Customer_Address_1.Text = customer_address;
            txt_Invoicing_Customer_Address_2.Text = customer_address;
            txt_Invoicing_Customer_Postal_Info_1.Text = customer_postal_code + " " + customer_post_office + " " + customer_country;
            txt_Invoicing_Customer_Postal_Info_2.Text = customer_postal_code + " " + customer_post_office;
            txt_Invoicing_Invoice_Date.Text = invoice_date.ToString("dd.MM.yyyy");
            txt_Invoicing_Invoice_Number.Text = "01";
            txt_Invoicing_Customer_Y_Id.Text = "";
            // Luetaan filestä viivästyskorko
            txt_Invoicing_Penalty_Interest.Text = Properties.Settings.Default["default_penalty_interest"].ToString().Trim('%');
            txt_Invoicing_Due_Date_1.Text = invoice_date.AddDays(30).ToString("dd.MM.yyyy");
            txt_Invoicing_Due_Date_2.Text = invoice_date.AddDays(30).ToString("dd.MM.yyyy");
            // Luetaan filestä huomautusaika
            txt_Invoicing_Remark_Time.Text = Properties.Settings.Default["default_remark_time"].ToString().Trim(' ', 'p', 'v');
            // Luetaan filestä infotekstejä laskuun
            txt_Invoicing_3rd_Row_Village_People_Info_1.Text = Properties.Settings.Default["default_infobox_1"].ToString();
            txt_Invoicing_3rd_Row_Village_People_Info_2.Text = Properties.Settings.Default["default_infobox_2"].ToString();
            txt_Invoicing_3rd_Row_Village_People_Info_3.Text = Properties.Settings.Default["default_infobox_3"].ToString();
            txt_Invoicing_3rd_Row_Village_People_Info_4.Text = Properties.Settings.Default["default_infobox_4"].ToString();
            txt_Invoicing_3rd_Row_Village_People_Info_5.Text = Properties.Settings.Default["default_infobox_5"].ToString();
            txt_Invoicing_Virtual_Barcode.Text = "123456789123456789";
            txt_Invoicing_Receiver_IBAN.Text = Properties.Settings.Default["default_IBAN"].ToString();
            txt_Invoicing_Receiver_BIC.Text = Properties.Settings.Default["default_BIC"].ToString();
            txt_Invoicing_Receiver.Text = Properties.Settings.Default["default_receiver"].ToString();
            txt_Invoicing_Reference_Number.Text = reference_number;
            txt_Invoicing_Total.Text = total;

            //tekköö siitä details kohasta just sen korkusen ku tarvii, ainakii melkei
            lst_Invoicing.Height = lst_Invoicing.Height + (lst_Invoicing.Items.Count * 13);
            
        }

        private void btn_Invoice_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Invoice_Print_Click(object sender, EventArgs e)
        {
            // Tulostaa laskun
            // Tulostuksen koko: 794 x 1123	 = A4 = 96 DPI. (Koko ulkoasusta.)
            PrintDocument to_print = new PrintDocument();
            to_print.PrintPage += this.Print_document;
            PrintDialog dlgSettings = new PrintDialog();
            dlgSettings.Document = to_print;
            if (dlgSettings.ShowDialog() == DialogResult.OK)
            {
                PrintController printController = new StandardPrintController();
                to_print.PrintController = printController;
                // Määritellään tulosteen marginaaleiksi "0".
                to_print.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
                to_print.PrinterSettings.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
                to_print.Print();
            }

        }

        private void Print_document(object sender, PrintPageEventArgs e)
        {
            // Luodaan laskusta tulostettava sivu.
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;
            Bitmap bmp = new Bitmap(this.tbl_Invoice_Invoice.Width, this.tbl_Invoice_Invoice.Height);
            this.tbl_Invoice_Invoice.DrawToBitmap(bmp, new Rectangle(0, 0, this.tbl_Invoice_Invoice.Width, this.tbl_Invoice_Invoice.Height));
            e.Graphics.DrawImage((Image)bmp, x, y);
        }
    }
}
