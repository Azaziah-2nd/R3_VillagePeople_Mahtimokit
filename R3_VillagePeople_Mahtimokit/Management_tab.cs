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
    public partial class Management_tab : Form
    {
        public Management_tab()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void asiakkkaatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer_Edit lomake = new Customer_Edit();
            lomake.Show();
        }

        private void toimipisteetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void varauksetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order_tab lomake = new Order_tab();
            lomake.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
