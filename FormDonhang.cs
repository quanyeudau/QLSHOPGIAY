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

namespace QLSHOPGIAY
{
    public partial class FormDonhang : Form
    {
        private SqlConnection conn; DataTable dataTable;
        public FormDonhang()
        {
            InitializeComponent();
        }
        public void connect()
        {
            //Lấy chuỗi kết nối CSDL
            string strcon = "Data Source=ANHQUAN\\SQLEXPRESS;Initial Catalog=QLGIAY;Integrated Security=True;Encrypt=False";
            try
            {
                conn = new SqlConnection(strcon);
                // Mở kết nối
                conn.Open();
                //Ko làm gì thì đóng kết nối lại
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Không kết nối được CSDL", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataTable getDH()
        {
            string strSQL = "Select * from DonHang";
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter(strSQL, conn);
            DataSet dataset = new DataSet();
            try
            {
                adapter.Fill(dataset);
                return dataset.Tables[0];
            }
            catch
            {
                return null;
            }
        }
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            connect();
            dataTable = getDH();
            dtgrvHienThiListSPChon.DataSource = dataTable;

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void txtMaDH_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHuyDH_Click(object sender, EventArgs e)
        {
            
         
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSDTKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgrvHienThiListSPChon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vbButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnTaoDonHang_Click(object sender, EventArgs e)
        {

        }

        private void btnXuatHoadon_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cboSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaSanPham_Click(object sender, EventArgs e)
        {

        }

        private void cboSanPham_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {

        }
    }
}
