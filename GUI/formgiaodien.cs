using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace FruitWorld.GUI
{
    public partial class formgiaodien : Form
    {
        private string tenNguoiDung;

        public formgiaodien(string Name)
        {
            InitializeComponent();
            tenNguoiDung = Name;
        }

        private void formgiaodien_Load(object sender, EventArgs e)
        {
            labelChao.Text = "Chào quý khách " + tenNguoiDung + "!";
        }
    }
}
