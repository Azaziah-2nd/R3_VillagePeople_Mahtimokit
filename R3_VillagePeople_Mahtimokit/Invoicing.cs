using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R3_VillagePeople_Mahtimokit
{
    public partial class frm_Invoicing : Form
    {
        public frm_Invoicing()
        {
            InitializeComponent();
        }

        private void Invoicing_Load(object sender, EventArgs e)
        {
            string[] arr = new string[6];
            ListViewItem itm;
            //add items to ListView
            arr[0] = "Mökki 1";
            arr[1] = "1.10.2010";
            arr[2] = "2.10.2010";
            arr[3] = "130e";
            arr[4] = "";
            arr[5] = "130e";
            itm = new ListViewItem(arr);
            lst_Invoicing.Items.Add(itm);

            arr[0] = "Palvelu 1";
            arr[1] = "2.10.2010";
            arr[2] = "2.10.2010";
            arr[3] = "35e";
            arr[4] = "3";
            arr[5] = "105e";
            itm = new ListViewItem(arr);
            lst_Invoicing.Items.Add(itm);

            arr[0] = "Palvelu 14";
            arr[1] = "2.10.2010";
            arr[2] = "2.10.2010";
            arr[3] = "35e";
            arr[4] = "2";
            arr[5] = "70e";
            itm = new ListViewItem(arr);
            lst_Invoicing.Items.Add(itm);

            arr[0] = "Palvelu 3";
            arr[1] = "2.10.2010";
            arr[2] = "2.10.2010";
            arr[3] = "35e";
            arr[4] = "2";
            arr[5] = "70e";
            itm = new ListViewItem(arr);
            lst_Invoicing.Items.Add(itm);

            lst_Invoicing.Height = lst_Invoicing.Height + (lst_Invoicing.Items.Count * 14);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_Invoicing_Penalty_Interest_Click(object sender, EventArgs e)
        {

        }

        private void tbl_Invoicing_1st_Row_Invoice_Info_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_Invoicing_3rd_Row_Village_People_Info_3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
