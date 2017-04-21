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
    public partial class frm_Customer_Popup : Form
    {
        public frm_Customer_Popup()
        {
            InitializeComponent();
        }

        private void btn_Customer_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
