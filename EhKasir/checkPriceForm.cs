using KasirPBO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EhKasir
{
    public partial class checkPriceForm : Form
    {
        public checkPriceForm()
        {
            InitializeComponent();
        }

        private void checkPriceBtn_Click(object sender, EventArgs e)
        {
            string code = checkPriceTxt.Text.Trim();
            var product = SqliteDataAccess.LoadProducts().FirstOrDefault(p => p.code == code);

            if (product != null)
            {
                MessageBox.Show($"Harga produk \"{product.name}\" adalah Rp. {product.price:N0}",
                                "Informasi Harga", MessageBoxButtons.OK, MessageBoxIcon.Information);

                checkPriceTxt.Text = "";
            }
            else
            {
                MessageBox.Show("Produk dengan kode tersebut tidak ditemukan.",
                                "Tidak Ditemukan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
