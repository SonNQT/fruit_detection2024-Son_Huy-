
using System;
using System.Data.SQLite;
using FruitWorld.GUI;


namespace FruitWorld
{
    public partial class formthemthanhvien : Form
    {
        public formthemthanhvien()
        {


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
            string ten1 = ten.Text.Trim();

            if (string.IsNullOrEmpty(sdt) || string.IsNullOrEmpty(ten1))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
                return;
            }
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=D:\\Project Folder\\SQLiteDatabaseBrowserPortable\\khachhang.db"))
                {
                    conn.Open();
                    string query = "INSERT INTO Customer (Phone, Name) VALUES (@Phone, @Name)";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Phone", sdt);
                        cmd.Parameters.AddWithValue("@Name", ten1);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành viên thành công!");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm thành viên:  " + ex.Message);
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}

