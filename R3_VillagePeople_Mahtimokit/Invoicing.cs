﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            // Tehhään tiedostostalukija eli streamreader
            StreamReader strm = new StreamReader("lasku.txt");
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
            txt_Invoicing_Penalty_Interest.Text = strm.ReadLine();
            txt_Invoicing_Due_Date_1.Text = invoice_date.AddDays(30).ToString("dd.MM.yyyy");
            txt_Invoicing_Due_Date_2.Text = invoice_date.AddDays(30).ToString("dd.MM.yyyy");
            // Luetaan filestä huomautusaika
            txt_Invoicing_Remark_Time.Text = strm.ReadLine();
            // Luetaan filestä infotekstejä laskuun
            txt_Invoicing_3rd_Row_Village_People_Info_1.Text = strm.ReadLine() + "\r\n" + strm.ReadLine() + "\r\n" + strm.ReadLine();
            txt_Invoicing_3rd_Row_Village_People_Info_2.Text = strm.ReadLine() + "\r\n" + strm.ReadLine() + "\r\n" + strm.ReadLine();
            txt_Invoicing_3rd_Row_Village_People_Info_3.Text = strm.ReadLine() + "\r\n" + strm.ReadLine() + "\r\n" + strm.ReadLine();
            txt_Invoicing_3rd_Row_Village_People_Info_4.Text = strm.ReadLine() + "\r\n" + strm.ReadLine() + "\r\n" + strm.ReadLine();
            txt_Invoicing_3rd_Row_Village_People_Info_5.Text = strm.ReadLine() + "\r\n" + strm.ReadLine() + "\r\n" + strm.ReadLine();
            txt_Invoicing_Virtual_Barcode.Text = "123456789123456789";
            txt_Invoicing_Receiver_IBAN.Text = strm.ReadLine();
            txt_Invoicing_Receiver_BIC.Text = strm.ReadLine();
            txt_Invoicing_Receiver.Text = strm.ReadLine();
            txt_Invoicing_Reference_Number.Text = reference_number;
            txt_Invoicing_Total.Text = total;
            strm.Close();
            

            //tekköö siitä details kohasta just sen korkusen ku tarvii, ainakii melkei
            lst_Invoicing.Height = lst_Invoicing.Height + (lst_Invoicing.Items.Count * 13);
            
        }
    }
}
