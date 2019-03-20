using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace QL_HSGVTHPT
{
    public partial class frmTimKiem : Form
    {
        BLL.frmTimKiem obj = new BLL.frmTimKiem();
        DataTable dtTK = new DataTable();
        public frmTimKiem()
        {
            InitializeComponent();
            dtTK = obj.SelectTK();
            dtgvTimKiem.DataSource = dtTK;
        }
    }
}
