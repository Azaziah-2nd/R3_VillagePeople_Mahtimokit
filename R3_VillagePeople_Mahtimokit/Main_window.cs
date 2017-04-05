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
    public partial class Main_window : Form
    {
        public Main_window()
        {
            InitializeComponent();
        }
        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void Main_window_Load(object sender, EventArgs e)
        {

        }

        // Asiakkaan lisäys
        private void btn_Customer_add_Click(object sender, EventArgs e)
        {
            var form = new Customer_popup();
            form.Show(this);
        }

        // Asiakkaan muokkaus
        private void btn_Customer_edit_Click(object sender, EventArgs e)
        {
            var form = new Customer_popup();
            form.Show(this);
        }

        // Asiakkaan poisto
        private void btn_Customer_delete_Click(object sender, EventArgs e)
        {

        }

        // Toimipisteen lisäys
        private void btn_Office_add_Click(object sender, EventArgs e)
        {
            var form = new Office_popup();
            form.Show(this);
        }

        // Toimipisteen muokkaus
        private void btn_Office_edit_Click(object sender, EventArgs e)
        {
            var form = new Office_popup();
            form.Show(this);
        }

        // Toimipisteen poisto
        private void btn_Office_delete_Click(object sender, EventArgs e)
        {

        }

        // Palvelun lisäys
        private void btn_Services_add_Click(object sender, EventArgs e)
        {
            var form = new Services_popup();
            form.Show(this);
        }

        // Palvelun muokkaus
        private void btn_Services_edit_Click(object sender, EventArgs e)
        {
            var form = new Services_popup();
            form.Show(this);
        }

        // Palvelun poisto
        private void btn_Services_delete_Click(object sender, EventArgs e)
        {

        }

        // Mökin lisäys
        private void btn_Cottages_add_Click(object sender, EventArgs e)
        {
            var form = new Cottage_popup();
            form.Show(this);
        }
        
        // Mökin muokkaus
        private void btn_Cottages_edit_Click(object sender, EventArgs e)
        {
            var form = new Cottage_popup();
            form.Show(this);
        }

        // Mökin poisto
        private void btn_Cottages_delete_Click(object sender, EventArgs e)
        {

        }

        private void tbl_Order_Col_1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void lbl_Order_Office_Click(object sender, EventArgs e)
        {

        }

        private void tbl_Order_2nd_Col_Cottage_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
