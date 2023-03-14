using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace bichthuhanhbuoi3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           

        }

        string KETNOISQL = "data source = DESKTOP-H73OOCD\\MSSQLSERVER03;" +
            "Initial Catalog = BAITAPLON;" + "Integrated Security=True";
        SqlConnection conn = null;
        string GioiTinh;
        DataTable dtSanpham = new DataTable("Sản Phẩm");
        DataTable dt = new DataTable("Khoa");
        DataTable dtLop = new DataTable("Lớp");
        DataTable dtSinhVien = new DataTable("Sinh Viên");
        string jsonSanpham, jsonKhoa, jsonSinhVien, jsonLop;

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void tabPagesinhvien_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer4_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPagetinh_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Themtttt(object sender, EventArgs e)
        {
            dtSanpham.Rows.Add(tbMasanpham.Text, tbTensanpham.Text, tbLoaiSP.Text, tbGia.Text, tbSL.Text);
            jsonSanpham = JsonConvert.SerializeObject(dtSanpham);
            System.IO.File.WriteAllText("Sanpham.json", jsonSanpham);
            tbMasanpham.Text = "";
            tbTensanpham.Text = "";
            tbLoaiSP.Text = "";
            tbGia.Text = "";
            tbSL.Text = "";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(KETNOISQL);
            conn.Open();
            string sql = "select * from SanPham";
            SqlDataAdapter sanpham = new SqlDataAdapter(sql, conn);
            DataTable DTSP = new DataTable();
           sanpham.Fill(DTSP);


        }

        private void themTinh_click(object sender, EventArgs e)
        {
            dtSanpham.Rows.Add(tbMasanpham.Text, tbTensanpham.Text, tbLoaiSP.Text, tbGia.Text, tbSL.Text);
            jsonSanpham = JsonConvert.SerializeObject(dtSanpham);
            System.IO.File.WriteAllText("Tinh.json", jsonSanpham);
            tbMasanpham.Text = "";
            tbTensanpham.Text = "";
            tbLoaiSP.Text = "";
            tbGia.Text = "";
            tbSL.Text = "";
        }
    }
}
