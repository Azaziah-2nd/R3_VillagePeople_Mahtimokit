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
    public partial class frm_Services_Popup : Form
    {
        public frm_Services_Popup()
        {
            InitializeComponent();
        }

        private void Services_popup_Load(object sender, EventArgs e)
        {

        }

        private void btn_Service_Cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
