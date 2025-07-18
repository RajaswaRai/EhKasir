using EhKasir;
using KasirPBO.res;
using KasirPBO.res.Model;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace KasirPBO
{

    public partial class homeForm : Form
    {
        int total = 0;
        int change = 0;
        UserModel? currentUser = null;
        BindingList<ProductModel> transactionProducts = new BindingList<ProductModel>();

        public void screenSwitch(Panel activePanel)
        {
            Panel[] panels = { loginScreen, KasirScreen, inventoriScreen, historyScreen, userScreen };

            foreach (var panel in panels)
            {
                panel.Visible = (panel == activePanel);
            }
        }

        private void homeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (currentUser != null)
            {
                DialogResult result = MessageBox.Show(
                    "Yakin ingin menutup aplikasi?",
                    "Konfirmasi Keluar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
            }
            clearLoginSession();

        }

        public homeForm()
        {
            InitializeComponent();

        }

        private void homeForm_Load(object sender, EventArgs e)
        {
            // delete after dev
            //var users = SqliteDataAccess.LoadUser(); // Ambil semua user dari DB
            //string username = "admin";
            //string password = PasswordHelper.HashPassword("12345678"); ;
            //UserModel? user = users.FirstOrDefault(u => u.username == username && u.password == password);
            //currentUser = user;
            //cashierScreenLoad();
            RoundedButton btnLogin = new RoundedButton();
            btnLogin.Text = "Login";
            btnLogin.Size = new Size(100, 40);
            btnLogin.Location = new Point(100, 100); // posisi di form
            btnLogin.BackColor = Color.MediumSlateBlue;
            btnLogin.ForeColor = Color.White;
            btnLogin.BorderRadius = 15;
            btnLogin.BorderSize = 0;

            //btnLogin.Click += BtnLogin_Click;

            this.Controls.Add(btnLogin);

        }

        private void EnsureTransactionDgvColumns()
        {
            // Hapus kolom Aksi dulu jika ada
            if (transactionDgv.Columns.Contains("Aksi"))
            {
                transactionDgv.Columns.Remove("Aksi");
            }

            // Tambah ulang kolom Aksi
            DataGridViewButtonColumn aksiColumn = new DataGridViewButtonColumn();
            aksiColumn.Name = "Aksi";
            aksiColumn.HeaderText = "Aksi";
            aksiColumn.Text = "";
            aksiColumn.UseColumnTextForButtonValue = false;
            transactionDgv.Columns.Add(aksiColumn);
        }
        private void cashierScreenLoad()
        {
            cashierLabel.Text = currentUser!.display_name;
            tanggalLabel.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");

            var products = SqliteDataAccess.LoadProducts();
            products.Insert(0, new ProductModel { code = "", name = "-- Pilih Produk --" });
            productsCmb.DataSource = products;
            productsCmb.DisplayMember = "name";
            productsCmb.ValueMember = "code";

            transactionDgv.DataSource = transactionProducts;
            transactionDgv.Columns[0].Visible = false;
            EnsureTransactionDgvColumns();
        }

        private void transactionDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && transactionDgv.Columns[e.ColumnIndex].Name == "Aksi")
            {
                var cell = transactionDgv[e.ColumnIndex, e.RowIndex];
                Rectangle cellRect = transactionDgv.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);

                int buttonWidth = 30;
                int spacing = 5;

                Point mouse = transactionDgv.PointToClient(Cursor.Position);
                int x = mouse.X - cellRect.X;

                if (x < buttonWidth + spacing)
                {
                    // Tombol "-"
                    var item = transactionProducts[e.RowIndex];
                    if (item.quantity > 1)
                        item.quantity--;
                    else
                        transactionProducts.RemoveAt(e.RowIndex);

                    transactionDgv.Refresh();
                }
                else if (x < (buttonWidth + spacing) * 2)
                {
                    // Tombol "+"
                    transactionProducts[e.RowIndex].quantity++;
                    transactionDgv.Refresh();
                }
                else if (x < (buttonWidth + spacing) * 3)
                {
                    // Tombol "Hapus"
                    transactionProducts.RemoveAt(e.RowIndex);
                }

                // Rehitung total
                total = transactionProducts.Sum(p => p.price * p.quantity);
                totalLabel.Text = "Rp. " + total.ToString("N0");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTxt.Text.Trim();
            string password = PasswordHelper.HashPassword(passwordTxt.Text.Trim()); ;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan password harus diisi!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var users = SqliteDataAccess.LoadUser(); // Ambil semua user dari DB
                UserModel? user = users.FirstOrDefault(u => u.username == username && u.password == password);

                if (user != null)
                {
                    currentUser = user;

                    MessageBox.Show($"Login berhasil!\nSelamat datang, {user.display_name} ({user.level})",
                        "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cashierScreenLoad();

                    screenSwitch(KasirScreen);
                }
                else
                {
                    MessageBox.Show("Username atau password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loginScreen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EnsureProductDgvColumns()
        {
            // Hapus kolom Delete dulu jika sudah ada
            if (productsDataGrid.Columns.Contains("Delete"))
            {
                productsDataGrid.Columns.Remove("Delete");
            }

            // Tambahkan ulang kolom Delete
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "Delete";
            deleteButton.HeaderText = "Aksi";
            deleteButton.Text = "Hapus";
            deleteButton.UseColumnTextForButtonValue = true;

            productsDataGrid.Columns.Add(deleteButton);
        }

        void loadInventoryDataGrid()
        {
            var products = SqliteDataAccess.LoadProducts();
            productsDataGrid.DataSource = null;
            productsDataGrid.Columns.Clear(); // pastikan kolom bersih

            productsDataGrid.DataSource = products;

            productsDataGrid.Columns["code"].HeaderText = "Kode";
            productsDataGrid.Columns["name"].HeaderText = "Nama Produk";
            productsDataGrid.Columns["price"].HeaderText = "Harga";
            productsDataGrid.Columns["quantity"].HeaderText = "Stok";

            // Tambahkan kolom delete
            EnsureProductDgvColumns();
        }

        private void inventoriBtn_Click(object sender, EventArgs e)
        {
            if (transactionProducts.Count > 0)
            {
                MessageBox.Show(
                    "Tidak bisa membuka inventori saat transaksi sedang berlangsung.\nSelesaikan atau kosongkan transaksi terlebih dahulu.",
                    "Akses Ditolak",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            loadInventoryDataGrid();
            screenSwitch(inventoriScreen);
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            var selectedItem = productsCmb.SelectedItem as ProductModel;
            if (selectedItem != null && !string.IsNullOrEmpty(selectedItem.code))
            {
                // Cek apakah produk sudah ada di transaksi
                var existingItem = transactionProducts.FirstOrDefault(p => p.code == selectedItem.code);
                if (existingItem != null)
                {
                    existingItem.quantity += 1;
                }
                else
                {
                    // Clone produk supaya tidak mengubah data aslinya
                    var newItem = new ProductModel
                    {
                        code = selectedItem.code,
                        name = selectedItem.name,
                        price = selectedItem.price,
                        quantity = 1
                    };
                    transactionProducts.Add(newItem);
                }

                // Refresh tampilan DataGridView
                transactionDgv.Refresh();

                // Hitung total
                total = transactionProducts.Sum(p => p.price * p.quantity);
                totalLabel.Text = "Rp. " + total.ToString("N0");

                calculateChange();
            }
            else
            {
                MessageBox.Show("Pilih Item terlebih dahulu", null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void checkPriceBtn_Click(object sender, EventArgs e)
        {
            using (var checkPriceForm = new checkPriceForm())
            {
                checkPriceForm.ShowDialog();
            }
        }

        private void inventoryBackBtn_Click(object sender, EventArgs e)
        {
            cashierScreenLoad();
            screenSwitch(KasirScreen);
        }

        private void productsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < productsDataGrid.Rows.Count)
            {
                var selectedProduct = productsDataGrid.Rows[e.RowIndex].DataBoundItem as ProductModel;

                if (selectedProduct != null)
                {
                    productCodeTxt.Text = selectedProduct.code;
                    productNameTxt.Text = selectedProduct.name;
                    productPriceTxt.Text = selectedProduct.price.ToString();
                    productQuantityTxt.Text = selectedProduct.quantity.ToString();
                }
            }
        }

        private void productsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Cek baris valid
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            // Cek apakah kolom yang diklik adalah tombol Delete
            var clickedColumn = productsDataGrid.Columns[e.ColumnIndex];
            if (clickedColumn.Name == "Delete")
            {
                // Ambil data produk yang dipilih
                var selectedProduct = productsDataGrid.Rows[e.RowIndex].DataBoundItem as ProductModel;

                if (selectedProduct != null)
                {
                    // Tampilkan konfirmasi
                    var confirm = MessageBox.Show(
                        $"Yakin ingin menghapus produk \"{selectedProduct.name}\"?",
                        "Konfirmasi Hapus",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    // Jika Yes, hapus
                    if (confirm == DialogResult.Yes)
                    {
                        SqliteDataAccess.DeleteProductByCode(selectedProduct.code);
                        loadInventoryDataGrid(); // Refresh grid
                    }
                }
            }
        }

        private void saveProductBtn_Click(object sender, EventArgs e)
        {
            string code = productCodeTxt.Text;

            // Buat objek produk dari input
            ProductModel product = new ProductModel();
            product.code = code;
            product.name = productNameTxt.Text;

            if (int.TryParse(productPriceTxt.Text, out int price) &&
                int.TryParse(productQuantityTxt.Text, out int quantity))
            {
                product.price = price;
                product.quantity = quantity;

                // Jika kode sudah ada → update
                if (SqliteDataAccess.IsProductCodeExists(code))
                {
                    SqliteDataAccess.updateProduct(code, product);
                    MessageBox.Show("Data produk berhasil diperbarui.");
                }
                else
                {
                    SqliteDataAccess.saveProduct(product);
                    MessageBox.Show("Produk baru berhasil disimpan.");
                }

                loadInventoryDataGrid();
            }
            else
            {
                MessageBox.Show("Harga atau jumlah tidak valid");
            }
        }

        private void productsCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedProduct = productsCmb.SelectedItem as ProductModel;
            if (selectedProduct != null)
            {
                itemPriceLabel.Text = "Rp. " + selectedProduct.price.ToString();
            }
            else
            {
                itemPriceLabel.Text = "Rp. 0";
            }
        }

        private void clearLoginSession()
        {
            currentUser = null;

            // Kosongkan label nama kasir
            cashierLabel.Text = "";

            // Kosongkan data transaksi
            transactionProducts.Clear();
            transactionDgv.DataSource = null;

            // Kosongkan combo box produk
            productsCmb.DataSource = null;

            // Reset total
            totalLabel.Text = "Rp. 0";
            itemPriceLabel.Text = "Rp. 0";

            // Kosongkan textbox login
            usernameTxt.Text = "";
            passwordTxt.Text = "";

            // Tampilkan panel login
            screenSwitch(loginScreen);

        }
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Anda yakin ingin logout?",
                "Konfirmasi Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                clearLoginSession();
            }
        }

        private void clearTransaction()
        {
            transactionProducts.Clear();
            totalLabel.Text = "Rp. 0";
        }
        private void clearTransactionBtn_Click(object sender, EventArgs e)
        {
            clearTransaction();
        }

        private void proccessBtn_Click(object sender, EventArgs e)
        {
            if (transactionProducts.Count == 0)
            {
                MessageBox.Show("Tidak ada produk dalam transaksi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (int.TryParse(buyerChangeTxt.Text, out int uangPembeli) == false || uangPembeli < 0)
            {
                MessageBox.Show("Jumlah uang pembeli tidak cukup untuk membayar total transaksi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(buyerMoneyTxt.Text))
            {
                MessageBox.Show("Jumlah uang pembeli harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string itemsJson = JsonSerializer.Serialize(
                 transactionProducts.Select(p => new
                 {
                     p.name,
                     p.price,
                     p.quantity,
                 })
             );

            // Ambil user ID dari user yang sedang login (misal: userID disimpan saat login)
            string currentUserID = currentUser!.id.ToString(); // pastikan kamu punya variabel currentUser

            // Buat objek transaksi
            TransactionModel transaction = new TransactionModel
            {
                items = itemsJson,
                total = total,
                money = int.Parse(buyerMoneyTxt.Text),
                changes = change,
                user_id = currentUserID,
                timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            };

            // Simpan ke database
            SqliteDataAccess.SaveTransaction(transaction); // pastikan fungsi ini ada

            // Kosongkan transaksi
            transactionProducts.Clear();
            totalLabel.Text = "Rp. 0";
            buyerMoneyTxt.Text = "";

            MessageBox.Show("Transaksi berhasil diproses!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void historyDgvLoad()
        {
            List<TransactionModel> historyList = SqliteDataAccess.LoadTransactions();
            historyDgv.DataSource = historyList;
            historyDgv.Columns["User_id"].Visible = false;

            if (historyDgv.Columns.Count > 0)
            {
                historyDgv.Columns["User"].HeaderText = "Kasir";
                historyDgv.Columns["Total"].HeaderText = "Total";
                historyDgv.Columns["Money"].HeaderText = "Jumlah tunai";
                historyDgv.Columns["Changes"].HeaderText = "Kembalian";
                historyDgv.Columns["Timestamp"].HeaderText = "Waktu Transaksi";
                historyDgv.Columns["Items"].HeaderText = "Detail Item";
            }

            // Auto resize kolom agar sesuai konten
            historyDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void historyBtn_Click(object sender, EventArgs e)
        {
            historyDgvLoad();
            screenSwitch(historyScreen);
        }

        private void historyBackBtn_Click(object sender, EventArgs e)
        {
            screenSwitch(KasirScreen);
        }

        private void transactionDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void transactionDgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && transactionDgv.Columns[e.ColumnIndex].Name == "Aksi" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                int buttonWidth = 30;
                int spacing = 5;

                // Tombol "-"
                Rectangle minusBtn = new Rectangle(
                    e.CellBounds.Left + spacing,
                    e.CellBounds.Top + 2,
                    buttonWidth, e.CellBounds.Height - 4);
                ButtonRenderer.DrawButton(e.Graphics, minusBtn, "-", transactionDgv.Font, false, PushButtonState.Default);

                // Tombol "+"
                Rectangle plusBtn = new Rectangle(
                    minusBtn.Right + spacing,
                    e.CellBounds.Top + 2,
                    buttonWidth, e.CellBounds.Height - 4);
                ButtonRenderer.DrawButton(e.Graphics, plusBtn, "+", transactionDgv.Font, false, PushButtonState.Default);

                // Tombol "Hapus"
                Rectangle delBtn = new Rectangle(
                    plusBtn.Right + spacing,
                    e.CellBounds.Top + 2,
                    buttonWidth, e.CellBounds.Height - 4);
                ButtonRenderer.DrawButton(e.Graphics, delBtn, "X", transactionDgv.Font, false, PushButtonState.Default);

                e.Handled = true;
            }
        }

        private void reloadHistoryBtn_Click(object sender, EventArgs e)
        {
            historyDgvLoad();
        }

        private void EnsureUserDgvColumns()
        {
            if (userManageDgv.Columns.Contains("Delete"))
            {
                userManageDgv.Columns.Remove("Delete");
            }

            DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn();
            deleteBtn.Name = "Delete";
            deleteBtn.HeaderText = "Aksi";
            deleteBtn.Text = "Hapus";
            deleteBtn.UseColumnTextForButtonValue = true;

            userManageDgv.Columns.Add(deleteBtn);
        }
        private void userManageDgvLoad()
        {
            List<UserModel> users = SqliteDataAccess.LoadUser();
            userManageDgv.DataSource = null;
            userManageDgv.Columns.Clear(); // penting agar tidak dobel kolom

            userManageDgv.DataSource = users;
            userManageDgv.Columns[0].Visible = false; // id
            userManageDgv.Columns[2].Visible = false; // password (opsional: bisa juga disembunyikan)

            EnsureUserDgvColumns(); // tambahkan tombol delete
        }

        private void userManageBtn_Click(object sender, EventArgs e)
        {
            userManageDgvLoad();
            screenSwitch(userScreen);

            var levelList = Enum.GetValues(typeof(UserLevel))
                    .Cast<UserLevel>()
                    .Select(lvl => new
                    {
                        Value = lvl,
                        Display = lvl.ToString()
                    })
                    .ToList();

            // Tambahkan opsi default
            var defaultItem = new { Value = (UserLevel)(-1), Display = "-- Pilih Level --" };
            levelList.Insert(0, defaultItem);

            // Bind ke ComboBox
            userManageLevelCmb.DataSource = levelList;
            userManageLevelCmb.DisplayMember = "Display";
            userManageLevelCmb.ValueMember = "Value";

            // Pilih item default (dengan aman)
            userManageLevelCmb.SelectedItem = defaultItem;
        }

        private void userManageBackBtn_Click(object sender, EventArgs e)
        {
            screenSwitch(KasirScreen);
            cashierScreenLoad();
        }

        private void userManageDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= userManageDgv.Rows.Count)
                return;

            var selectedUser = userManageDgv.Rows[e.RowIndex].DataBoundItem as UserModel;

            if (userManageDgv.Columns[e.ColumnIndex].Name == "Delete")
            {
                MessageBox.Show("Tombol hapus diklik!"); // debug sementara

                if (selectedUser != null)
                {
                    MessageBox.Show("Akan hapus user: " + selectedUser.username); // debug

                    var confirm = MessageBox.Show(
                        $"Yakin ingin menghapus user \"{selectedUser.display_name}\"?",
                        "Konfirmasi Hapus",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (confirm == DialogResult.Yes)
                    {
                        SqliteDataAccess.DeleteUserById(selectedUser.id);
                        userManageDgvLoad(); // refresh tabel
                    }
                }
            }
            else
            {
                // Kalau bukan tombol delete, isi form
                if (selectedUser != null)
                {
                    userManageUsernameTxt.Text = selectedUser.username;
                    userManagePasswordTxt.Text = selectedUser.password;
                    userManageNameTxt.Text = selectedUser.display_name;
                    userManageLevelCmb.SelectedIndex = (int)selectedUser.level;
                }
            }
        }


        private void userManageSaveBtn_Click(object sender, EventArgs e)
        {
            string username = userManageUsernameTxt.Text.Trim();
            string password = PasswordHelper.HashPassword(userManagePasswordTxt.Text.Trim());
            string displayName = userManageNameTxt.Text.Trim();
            UserLevel selectedLevel;

            // Validasi input
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(displayName))
            {
                MessageBox.Show("Semua kolom harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (userManageLevelCmb.SelectedValue == null)
            {
                MessageBox.Show("Pilih level pengguna!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            selectedLevel = (UserLevel)userManageLevelCmb.SelectedValue;

            UserModel user = new UserModel
            {
                username = username,
                password = password,
                display_name = displayName,
                level = selectedLevel
            };

            // Cek apakah username sudah ada → update, kalau belum → insert
            if (SqliteDataAccess.IsUsernameExists(username))
            {
                SqliteDataAccess.UpdateUserByUsername(user);
                MessageBox.Show("Data user diperbarui.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqliteDataAccess.SaveUser(user);
                MessageBox.Show("User baru disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Reset
            userManageUsernameTxt.Text = "";
            userManagePasswordTxt.Text = "";
            userManageNameTxt.Text = "";
            userManageLevelCmb.SelectedIndex = -1;

            userManageDgvLoad();
        }

        private void calculateChange()
        {
            if (int.TryParse(buyerMoneyTxt.Text, out int uangPembeli))
            {
                change = uangPembeli - total;
                buyerChangeTxt.Text = change.ToString("N0");
            }
            else
            {
                buyerChangeTxt.Text = "0";
            }
        }
        private void buyerMoneyTxt_TextChanged(object sender, EventArgs e)
        {
            calculateChange();
        }

        private void totalLabel_Click(object sender, EventArgs e)
        {

        }

        private void inventoriScreen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ItemsPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
