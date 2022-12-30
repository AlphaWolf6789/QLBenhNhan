using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLBenhNhan;

namespace DE_QLBenhNhan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BUS bus = new BUS();
        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = bus.Show();
            cboKhoaKham.DataSource = dt;
            cboKhoaKham.DisplayMember = "TenKhoa";
            cboKhoaKham.ValueMember = "MaKhoa";
            dataGridView1.DataSource = dt;
        }
    }
}
