using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Store
{
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }

        cla_crud crud = new cla_crud();
        private void btnThem_Click(object sender, EventArgs e)
        {
            Boolean check = crud.exedata("INSERT INTO Product1 (SanPham) VALUES (N'" + txtTenSP.Text + "')");
            if (check == true)
            {
                MessageBox.Show("Thành công");
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }
    }
}
