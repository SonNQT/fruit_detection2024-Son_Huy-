using FruitWorld.GUI;
using System.Data.SQLite;

namespace FruitWorld
{
    public partial class formdangnhap : Form
    {
        public formdangnhap() { 
        

        InitializeComponent();
       
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void xacnhanbutton_enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                xacnhanbutton_Click(sender, e);
            }
        }
        private void xacnhanbutton_Click(object sender, EventArgs e)
        {
            string sdt = SĐT.Text.Trim(); 

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=D:\\Project Folder\\SQLiteDatabaseBrowserPortable\\khachhang.db"))
            {
                conn.Open();
                string query = "SELECT Name FROM Customer WHERE Phone = @Phone";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Phone", sdt);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string ten = result.ToString();
                        formgiaodien giaoDien = new formgiaodien(ten);
                        giaoDien.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Số điện thoại chưa có trong hệ thống!"); this.Hide();
                        formthemthanhvien ThemTV = new formthemthanhvien();
                        ThemTV.ShowDialog();
                        
                    }
                }
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void thanks_Click(object sender, EventArgs e)
        {

        }
    }
}
