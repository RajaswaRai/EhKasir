namespace KasirPBO
{
    partial class homeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addProductBtn = new Button();
            title = new Label();
            panel1 = new Panel();
            logoutBtn = new Button();
            cashierLabel = new Label();
            cashierTitle = new Label();
            tanggalLabel = new Label();
            tanggalTitle = new Label();
            itemPriceLabel = new Label();
            addProductTitle = new Label();
            totalLabel = new Label();
            totalTitle = new Label();
            ItemsPanel = new Panel();
            buyerMoneyTxt = new TextBox();
            buyerChangeTxt = new Label();
            label12 = new Label();
            label11 = new Label();
            userManageBtn = new Button();
            clearTransactionBtn = new Button();
            historyBtn = new Button();
            inventoriBtn = new Button();
            checkPriceBtn = new Button();
            proccessBtn = new Button();
            transactionDgv = new DataGridView();
            kasirSplitContainer = new SplitContainer();
            productsCmb = new ComboBox();
            KasirScreen = new Panel();
            loginScreen = new Panel();
            label2 = new Label();
            label1 = new Label();
            passwordTxt = new TextBox();
            usernameTxt = new TextBox();
            titleText = new Label();
            loginBtn = new Button();
            inventoriScreen = new Panel();
            saveProductBtn = new Button();
            inventoryBackBtn = new Button();
            productQuantityTxt = new TextBox();
            productPriceTxt = new TextBox();
            productNameTxt = new TextBox();
            productCodeTxt = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            productsDataGrid = new DataGridView();
            historyScreen = new Panel();
            reloadHistoryBtn = new Button();
            historyBackBtn = new Button();
            historyDgv = new DataGridView();
            userScreen = new Panel();
            userManageLevelCmb = new ComboBox();
            userManageSaveBtn = new Button();
            userManageBackBtn = new Button();
            userManageNameTxt = new TextBox();
            userManagePasswordTxt = new TextBox();
            userManageUsernameTxt = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            userManageDgv = new DataGridView();
            maskedTextBox1 = new MaskedTextBox();
            panel1.SuspendLayout();
            ItemsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)transactionDgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kasirSplitContainer).BeginInit();
            kasirSplitContainer.Panel1.SuspendLayout();
            kasirSplitContainer.Panel2.SuspendLayout();
            kasirSplitContainer.SuspendLayout();
            KasirScreen.SuspendLayout();
            loginScreen.SuspendLayout();
            inventoriScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productsDataGrid).BeginInit();
            historyScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)historyDgv).BeginInit();
            userScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userManageDgv).BeginInit();
            SuspendLayout();
            // 
            // addProductBtn
            // 
            addProductBtn.FlatStyle = FlatStyle.Flat;
            addProductBtn.Location = new Point(325, 68);
            addProductBtn.Margin = new Padding(3, 4, 3, 4);
            addProductBtn.Name = "addProductBtn";
            addProductBtn.Size = new Size(93, 110);
            addProductBtn.TabIndex = 0;
            addProductBtn.Text = "Tambah";
            addProductBtn.UseVisualStyleBackColor = true;
            addProductBtn.Click += addProductBtn_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.BackColor = Color.Transparent;
            title.FlatStyle = FlatStyle.Flat;
            title.Font = new Font("Poppins", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.Location = new Point(12, 50);
            title.Name = "title";
            title.Size = new Size(157, 60);
            title.TabIndex = 1;
            title.Text = "EhKasir";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(logoutBtn);
            panel1.Controls.Add(cashierLabel);
            panel1.Controls.Add(cashierTitle);
            panel1.Controls.Add(tanggalLabel);
            panel1.Controls.Add(tanggalTitle);
            panel1.Controls.Add(title);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.Control;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1042, 169);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // logoutBtn
            // 
            logoutBtn.ForeColor = SystemColors.ActiveCaptionText;
            logoutBtn.Location = new Point(924, 0);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(118, 169);
            logoutBtn.TabIndex = 6;
            logoutBtn.Text = "Log Out";
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // cashierLabel
            // 
            cashierLabel.AutoSize = true;
            cashierLabel.BackColor = Color.Transparent;
            cashierLabel.FlatStyle = FlatStyle.Flat;
            cashierLabel.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cashierLabel.Location = new Point(507, 65);
            cashierLabel.Name = "cashierLabel";
            cashierLabel.Size = new Size(308, 36);
            cashierLabel.TabIndex = 5;
            cashierLabel.Text = "Admin Kasir Tampan Berani";
            // 
            // cashierTitle
            // 
            cashierTitle.AutoSize = true;
            cashierTitle.BackColor = Color.Transparent;
            cashierTitle.FlatStyle = FlatStyle.Flat;
            cashierTitle.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cashierTitle.Location = new Point(507, 37);
            cashierTitle.Name = "cashierTitle";
            cashierTitle.Size = new Size(67, 36);
            cashierTitle.TabIndex = 4;
            cashierTitle.Text = "Kasir";
            // 
            // tanggalLabel
            // 
            tanggalLabel.AutoSize = true;
            tanggalLabel.BackColor = Color.Transparent;
            tanggalLabel.FlatStyle = FlatStyle.Flat;
            tanggalLabel.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tanggalLabel.Location = new Point(208, 67);
            tanggalLabel.Name = "tanggalLabel";
            tanggalLabel.Size = new Size(243, 36);
            tanggalLabel.TabIndex = 3;
            tanggalLabel.Text = "Tuesday, 12 June 2024";
            // 
            // tanggalTitle
            // 
            tanggalTitle.AutoSize = true;
            tanggalTitle.BackColor = Color.Transparent;
            tanggalTitle.FlatStyle = FlatStyle.Flat;
            tanggalTitle.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tanggalTitle.Location = new Point(208, 37);
            tanggalTitle.Name = "tanggalTitle";
            tanggalTitle.Size = new Size(102, 36);
            tanggalTitle.TabIndex = 2;
            tanggalTitle.Text = "Tanggal";
            // 
            // itemPriceLabel
            // 
            itemPriceLabel.AutoSize = true;
            itemPriceLabel.BackColor = Color.Transparent;
            itemPriceLabel.FlatStyle = FlatStyle.Flat;
            itemPriceLabel.Font = new Font("Poppins", 10F, FontStyle.Bold);
            itemPriceLabel.Location = new Point(17, 140);
            itemPriceLabel.Name = "itemPriceLabel";
            itemPriceLabel.Size = new Size(51, 30);
            itemPriceLabel.TabIndex = 7;
            itemPriceLabel.Text = "Rp 0";
            // 
            // addProductTitle
            // 
            addProductTitle.AutoSize = true;
            addProductTitle.BackColor = Color.Transparent;
            addProductTitle.FlatStyle = FlatStyle.Flat;
            addProductTitle.Font = new Font("Poppins", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addProductTitle.Location = new Point(12, 4);
            addProductTitle.Name = "addProductTitle";
            addProductTitle.Size = new Size(262, 60);
            addProductTitle.TabIndex = 6;
            addProductTitle.Text = "Tambah Item";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.BackColor = Color.Transparent;
            totalLabel.FlatStyle = FlatStyle.Flat;
            totalLabel.Font = new Font("Poppins", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalLabel.Location = new Point(14, 96);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(110, 60);
            totalLabel.TabIndex = 9;
            totalLabel.Text = "Rp. 0";
            // 
            // totalTitle
            // 
            totalTitle.AutoSize = true;
            totalTitle.BackColor = Color.Transparent;
            totalTitle.FlatStyle = FlatStyle.Flat;
            totalTitle.Font = new Font("Poppins", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalTitle.Location = new Point(6, 6);
            totalTitle.Name = "totalTitle";
            totalTitle.Size = new Size(114, 60);
            totalTitle.TabIndex = 8;
            totalTitle.Text = "Total";
            // 
            // ItemsPanel
            // 
            ItemsPanel.BackColor = SystemColors.Control;
            ItemsPanel.Controls.Add(buyerMoneyTxt);
            ItemsPanel.Controls.Add(buyerChangeTxt);
            ItemsPanel.Controls.Add(label12);
            ItemsPanel.Controls.Add(label11);
            ItemsPanel.Controls.Add(userManageBtn);
            ItemsPanel.Controls.Add(clearTransactionBtn);
            ItemsPanel.Controls.Add(historyBtn);
            ItemsPanel.Controls.Add(inventoriBtn);
            ItemsPanel.Controls.Add(checkPriceBtn);
            ItemsPanel.Controls.Add(proccessBtn);
            ItemsPanel.Controls.Add(transactionDgv);
            ItemsPanel.Dock = DockStyle.Fill;
            ItemsPanel.Location = new Point(0, 379);
            ItemsPanel.Margin = new Padding(3, 4, 3, 4);
            ItemsPanel.Name = "ItemsPanel";
            ItemsPanel.Size = new Size(1042, 443);
            ItemsPanel.TabIndex = 4;
            // 
            // buyerMoneyTxt
            // 
            buyerMoneyTxt.Location = new Point(253, 322);
            buyerMoneyTxt.Name = "buyerMoneyTxt";
            buyerMoneyTxt.Size = new Size(551, 27);
            buyerMoneyTxt.TabIndex = 18;
            buyerMoneyTxt.TextChanged += buyerMoneyTxt_TextChanged;
            // 
            // buyerChangeTxt
            // 
            buyerChangeTxt.AutoSize = true;
            buyerChangeTxt.BackColor = Color.Transparent;
            buyerChangeTxt.FlatStyle = FlatStyle.Flat;
            buyerChangeTxt.Font = new Font("Poppins", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buyerChangeTxt.Location = new Point(253, 361);
            buyerChangeTxt.Name = "buyerChangeTxt";
            buyerChangeTxt.Size = new Size(110, 60);
            buyerChangeTxt.TabIndex = 17;
            buyerChangeTxt.Text = "Rp. 0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.FlatStyle = FlatStyle.Flat;
            label12.Font = new Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(12, 367);
            label12.Name = "label12";
            label12.Size = new Size(143, 50);
            label12.TabIndex = 16;
            label12.Text = "Kembali";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.FlatStyle = FlatStyle.Flat;
            label11.Font = new Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(12, 310);
            label11.Name = "label11";
            label11.Size = new Size(216, 50);
            label11.TabIndex = 10;
            label11.Text = "Jumlah Uang";
            // 
            // userManageBtn
            // 
            userManageBtn.Location = new Point(584, 7);
            userManageBtn.Name = "userManageBtn";
            userManageBtn.Size = new Size(220, 29);
            userManageBtn.TabIndex = 15;
            userManageBtn.Text = "User Manage";
            userManageBtn.UseVisualStyleBackColor = true;
            userManageBtn.Click += userManageBtn_Click;
            // 
            // clearTransactionBtn
            // 
            clearTransactionBtn.Location = new Point(12, 7);
            clearTransactionBtn.Name = "clearTransactionBtn";
            clearTransactionBtn.Size = new Size(94, 29);
            clearTransactionBtn.TabIndex = 14;
            clearTransactionBtn.Text = "Clear";
            clearTransactionBtn.UseVisualStyleBackColor = true;
            clearTransactionBtn.Click += clearTransactionBtn_Click;
            // 
            // historyBtn
            // 
            historyBtn.Location = new Point(810, 116);
            historyBtn.Margin = new Padding(3, 4, 3, 4);
            historyBtn.Name = "historyBtn";
            historyBtn.Size = new Size(220, 71);
            historyBtn.TabIndex = 13;
            historyBtn.Text = "Histori";
            historyBtn.UseVisualStyleBackColor = true;
            historyBtn.Click += historyBtn_Click;
            // 
            // inventoriBtn
            // 
            inventoriBtn.Location = new Point(810, 195);
            inventoriBtn.Margin = new Padding(3, 4, 3, 4);
            inventoriBtn.Name = "inventoriBtn";
            inventoriBtn.Size = new Size(220, 71);
            inventoriBtn.TabIndex = 12;
            inventoriBtn.Text = "Inventori";
            inventoriBtn.UseVisualStyleBackColor = true;
            inventoriBtn.Click += inventoriBtn_Click;
            // 
            // checkPriceBtn
            // 
            checkPriceBtn.Location = new Point(810, 37);
            checkPriceBtn.Margin = new Padding(3, 4, 3, 4);
            checkPriceBtn.Name = "checkPriceBtn";
            checkPriceBtn.Size = new Size(220, 71);
            checkPriceBtn.TabIndex = 11;
            checkPriceBtn.Text = "Cek Harga";
            checkPriceBtn.UseVisualStyleBackColor = true;
            checkPriceBtn.Click += checkPriceBtn_Click;
            // 
            // proccessBtn
            // 
            proccessBtn.Location = new Point(810, 274);
            proccessBtn.Margin = new Padding(3, 4, 3, 4);
            proccessBtn.Name = "proccessBtn";
            proccessBtn.Size = new Size(220, 150);
            proccessBtn.TabIndex = 8;
            proccessBtn.Text = "Proses";
            proccessBtn.UseVisualStyleBackColor = true;
            proccessBtn.Click += proccessBtn_Click;
            // 
            // transactionDgv
            // 
            transactionDgv.AllowUserToAddRows = false;
            transactionDgv.AllowUserToDeleteRows = false;
            transactionDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            transactionDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            transactionDgv.Location = new Point(12, 37);
            transactionDgv.Margin = new Padding(3, 4, 3, 4);
            transactionDgv.Name = "transactionDgv";
            transactionDgv.RowHeadersWidth = 51;
            transactionDgv.RowTemplate.Height = 24;
            transactionDgv.Size = new Size(792, 229);
            transactionDgv.TabIndex = 0;
            transactionDgv.CellClick += transactionDgv_CellClick;
            transactionDgv.CellContentClick += transactionDgv_CellContentClick;
            transactionDgv.CellPainting += transactionDgv_CellPainting;
            // 
            // kasirSplitContainer
            // 
            kasirSplitContainer.Dock = DockStyle.Top;
            kasirSplitContainer.Location = new Point(0, 169);
            kasirSplitContainer.Margin = new Padding(3, 4, 3, 4);
            kasirSplitContainer.Name = "kasirSplitContainer";
            // 
            // kasirSplitContainer.Panel1
            // 
            kasirSplitContainer.Panel1.Controls.Add(productsCmb);
            kasirSplitContainer.Panel1.Controls.Add(itemPriceLabel);
            kasirSplitContainer.Panel1.Controls.Add(addProductTitle);
            kasirSplitContainer.Panel1.Controls.Add(addProductBtn);
            // 
            // kasirSplitContainer.Panel2
            // 
            kasirSplitContainer.Panel2.Controls.Add(maskedTextBox1);
            kasirSplitContainer.Panel2.Controls.Add(totalLabel);
            kasirSplitContainer.Panel2.Controls.Add(totalTitle);
            kasirSplitContainer.Size = new Size(1042, 210);
            kasirSplitContainer.SplitterDistance = 425;
            kasirSplitContainer.TabIndex = 5;
            // 
            // productsCmb
            // 
            productsCmb.FormattingEnabled = true;
            productsCmb.Location = new Point(18, 109);
            productsCmb.Name = "productsCmb";
            productsCmb.Size = new Size(301, 28);
            productsCmb.TabIndex = 8;
            productsCmb.SelectedIndexChanged += productsCmb_SelectedIndexChanged;
            // 
            // KasirScreen
            // 
            KasirScreen.Controls.Add(ItemsPanel);
            KasirScreen.Controls.Add(kasirSplitContainer);
            KasirScreen.Controls.Add(panel1);
            KasirScreen.Dock = DockStyle.Fill;
            KasirScreen.Location = new Point(0, 0);
            KasirScreen.Margin = new Padding(3, 4, 3, 4);
            KasirScreen.Name = "KasirScreen";
            KasirScreen.Size = new Size(1042, 822);
            KasirScreen.TabIndex = 10;
            // 
            // loginScreen
            // 
            loginScreen.Controls.Add(label2);
            loginScreen.Controls.Add(label1);
            loginScreen.Controls.Add(passwordTxt);
            loginScreen.Controls.Add(usernameTxt);
            loginScreen.Controls.Add(titleText);
            loginScreen.Controls.Add(loginBtn);
            loginScreen.Dock = DockStyle.Fill;
            loginScreen.Location = new Point(0, 0);
            loginScreen.Margin = new Padding(3, 4, 3, 4);
            loginScreen.Name = "loginScreen";
            loginScreen.Size = new Size(1042, 822);
            loginScreen.TabIndex = 10;
            loginScreen.Paint += loginScreen_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(390, 372);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(390, 305);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // passwordTxt
            // 
            passwordTxt.Location = new Point(393, 396);
            passwordTxt.Margin = new Padding(3, 4, 3, 4);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.PasswordChar = '*';
            passwordTxt.Size = new Size(214, 27);
            passwordTxt.TabIndex = 3;
            // 
            // usernameTxt
            // 
            usernameTxt.Location = new Point(393, 335);
            usernameTxt.Margin = new Padding(3, 4, 3, 4);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(214, 27);
            usernameTxt.TabIndex = 2;
            // 
            // titleText
            // 
            titleText.AutoSize = true;
            titleText.Font = new Font("Poppins SemiBold", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleText.Location = new Point(408, 198);
            titleText.Name = "titleText";
            titleText.Size = new Size(167, 65);
            titleText.TabIndex = 1;
            titleText.Text = "EhKasir";
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(393, 452);
            loginBtn.Margin = new Padding(3, 4, 3, 4);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(214, 89);
            loginBtn.TabIndex = 0;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // inventoriScreen
            // 
            inventoriScreen.Controls.Add(saveProductBtn);
            inventoriScreen.Controls.Add(inventoryBackBtn);
            inventoriScreen.Controls.Add(productQuantityTxt);
            inventoriScreen.Controls.Add(productPriceTxt);
            inventoriScreen.Controls.Add(productNameTxt);
            inventoriScreen.Controls.Add(productCodeTxt);
            inventoriScreen.Controls.Add(label6);
            inventoriScreen.Controls.Add(label5);
            inventoriScreen.Controls.Add(label4);
            inventoriScreen.Controls.Add(label3);
            inventoriScreen.Controls.Add(productsDataGrid);
            inventoriScreen.Dock = DockStyle.Fill;
            inventoriScreen.Location = new Point(0, 0);
            inventoriScreen.Name = "inventoriScreen";
            inventoriScreen.Size = new Size(1042, 822);
            inventoriScreen.TabIndex = 13;
            // 
            // saveProductBtn
            // 
            saveProductBtn.Location = new Point(892, 167);
            saveProductBtn.Name = "saveProductBtn";
            saveProductBtn.Size = new Size(94, 29);
            saveProductBtn.TabIndex = 10;
            saveProductBtn.Text = "Save";
            saveProductBtn.UseVisualStyleBackColor = true;
            saveProductBtn.Click += saveProductBtn_Click;
            // 
            // inventoryBackBtn
            // 
            inventoryBackBtn.Location = new Point(45, 28);
            inventoryBackBtn.Name = "inventoryBackBtn";
            inventoryBackBtn.Size = new Size(94, 29);
            inventoryBackBtn.TabIndex = 9;
            inventoryBackBtn.Text = "Kembali";
            inventoryBackBtn.UseVisualStyleBackColor = true;
            inventoryBackBtn.Click += inventoryBackBtn_Click;
            // 
            // productQuantityTxt
            // 
            productQuantityTxt.Location = new Point(498, 169);
            productQuantityTxt.Name = "productQuantityTxt";
            productQuantityTxt.Size = new Size(125, 27);
            productQuantityTxt.TabIndex = 8;
            // 
            // productPriceTxt
            // 
            productPriceTxt.Location = new Point(337, 169);
            productPriceTxt.Name = "productPriceTxt";
            productPriceTxt.Size = new Size(125, 27);
            productPriceTxt.TabIndex = 7;
            // 
            // productNameTxt
            // 
            productNameTxt.Location = new Point(188, 169);
            productNameTxt.Name = "productNameTxt";
            productNameTxt.Size = new Size(125, 27);
            productNameTxt.TabIndex = 6;
            // 
            // productCodeTxt
            // 
            productCodeTxt.Location = new Point(45, 169);
            productCodeTxt.Name = "productCodeTxt";
            productCodeTxt.Size = new Size(125, 27);
            productCodeTxt.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(498, 146);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 4;
            label6.Text = "Jumlah";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(337, 146);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 3;
            label5.Text = "Harga";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 146);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 2;
            label4.Text = "Kode";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(188, 146);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 1;
            label3.Text = "Nama Produk";
            // 
            // productsDataGrid
            // 
            productsDataGrid.AllowUserToAddRows = false;
            productsDataGrid.AllowUserToDeleteRows = false;
            productsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsDataGrid.Location = new Point(45, 236);
            productsDataGrid.Name = "productsDataGrid";
            productsDataGrid.RowHeadersWidth = 51;
            productsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productsDataGrid.Size = new Size(941, 567);
            productsDataGrid.TabIndex = 0;
            productsDataGrid.CellClick += productsDataGrid_CellClick;
            productsDataGrid.CellContentClick += productsDataGrid_CellContentClick;
            // 
            // historyScreen
            // 
            historyScreen.Controls.Add(reloadHistoryBtn);
            historyScreen.Controls.Add(historyBackBtn);
            historyScreen.Controls.Add(historyDgv);
            historyScreen.Dock = DockStyle.Fill;
            historyScreen.Location = new Point(0, 0);
            historyScreen.Name = "historyScreen";
            historyScreen.Size = new Size(1042, 822);
            historyScreen.TabIndex = 14;
            // 
            // reloadHistoryBtn
            // 
            reloadHistoryBtn.Location = new Point(892, 70);
            reloadHistoryBtn.Name = "reloadHistoryBtn";
            reloadHistoryBtn.Size = new Size(94, 29);
            reloadHistoryBtn.TabIndex = 10;
            reloadHistoryBtn.Text = "Reload";
            reloadHistoryBtn.UseVisualStyleBackColor = true;
            reloadHistoryBtn.Click += reloadHistoryBtn_Click;
            // 
            // historyBackBtn
            // 
            historyBackBtn.Location = new Point(45, 28);
            historyBackBtn.Name = "historyBackBtn";
            historyBackBtn.Size = new Size(94, 29);
            historyBackBtn.TabIndex = 9;
            historyBackBtn.Text = "Kembali";
            historyBackBtn.UseVisualStyleBackColor = true;
            historyBackBtn.Click += historyBackBtn_Click;
            // 
            // historyDgv
            // 
            historyDgv.AllowUserToAddRows = false;
            historyDgv.AllowUserToDeleteRows = false;
            historyDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            historyDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            historyDgv.Location = new Point(45, 114);
            historyDgv.Name = "historyDgv";
            historyDgv.RowHeadersWidth = 51;
            historyDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            historyDgv.Size = new Size(941, 689);
            historyDgv.TabIndex = 0;
            // 
            // userScreen
            // 
            userScreen.Controls.Add(userManageLevelCmb);
            userScreen.Controls.Add(userManageSaveBtn);
            userScreen.Controls.Add(userManageBackBtn);
            userScreen.Controls.Add(userManageNameTxt);
            userScreen.Controls.Add(userManagePasswordTxt);
            userScreen.Controls.Add(userManageUsernameTxt);
            userScreen.Controls.Add(label7);
            userScreen.Controls.Add(label8);
            userScreen.Controls.Add(label9);
            userScreen.Controls.Add(label10);
            userScreen.Controls.Add(userManageDgv);
            userScreen.Dock = DockStyle.Fill;
            userScreen.Location = new Point(0, 0);
            userScreen.Name = "userScreen";
            userScreen.Size = new Size(1042, 822);
            userScreen.TabIndex = 15;
            // 
            // userManageLevelCmb
            // 
            userManageLevelCmb.FormattingEnabled = true;
            userManageLevelCmb.Location = new Point(498, 167);
            userManageLevelCmb.Name = "userManageLevelCmb";
            userManageLevelCmb.Size = new Size(151, 28);
            userManageLevelCmb.TabIndex = 11;
            // 
            // userManageSaveBtn
            // 
            userManageSaveBtn.Location = new Point(892, 167);
            userManageSaveBtn.Name = "userManageSaveBtn";
            userManageSaveBtn.Size = new Size(94, 29);
            userManageSaveBtn.TabIndex = 10;
            userManageSaveBtn.Text = "Save";
            userManageSaveBtn.UseVisualStyleBackColor = true;
            userManageSaveBtn.Click += userManageSaveBtn_Click;
            // 
            // userManageBackBtn
            // 
            userManageBackBtn.Location = new Point(45, 28);
            userManageBackBtn.Name = "userManageBackBtn";
            userManageBackBtn.Size = new Size(94, 29);
            userManageBackBtn.TabIndex = 9;
            userManageBackBtn.Text = "Kembali";
            userManageBackBtn.UseVisualStyleBackColor = true;
            userManageBackBtn.Click += userManageBackBtn_Click;
            // 
            // userManageNameTxt
            // 
            userManageNameTxt.Location = new Point(337, 169);
            userManageNameTxt.Name = "userManageNameTxt";
            userManageNameTxt.Size = new Size(125, 27);
            userManageNameTxt.TabIndex = 7;
            // 
            // userManagePasswordTxt
            // 
            userManagePasswordTxt.Location = new Point(188, 169);
            userManagePasswordTxt.Name = "userManagePasswordTxt";
            userManagePasswordTxt.PasswordChar = '*';
            userManagePasswordTxt.Size = new Size(125, 27);
            userManagePasswordTxt.TabIndex = 6;
            // 
            // userManageUsernameTxt
            // 
            userManageUsernameTxt.Location = new Point(45, 169);
            userManageUsernameTxt.Name = "userManageUsernameTxt";
            userManageUsernameTxt.Size = new Size(125, 27);
            userManageUsernameTxt.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(498, 146);
            label7.Name = "label7";
            label7.Size = new Size(48, 20);
            label7.TabIndex = 4;
            label7.Text = "Tugas";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(337, 146);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 3;
            label8.Text = "Nama";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(45, 146);
            label9.Name = "label9";
            label9.Size = new Size(75, 20);
            label9.TabIndex = 2;
            label9.Text = "Username";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(188, 146);
            label10.Name = "label10";
            label10.Size = new Size(70, 20);
            label10.TabIndex = 1;
            label10.Text = "Password";
            // 
            // userManageDgv
            // 
            userManageDgv.AllowUserToDeleteRows = false;
            userManageDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            userManageDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userManageDgv.Location = new Point(45, 236);
            userManageDgv.Name = "userManageDgv";
            userManageDgv.RowHeadersWidth = 51;
            userManageDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            userManageDgv.Size = new Size(941, 567);
            userManageDgv.TabIndex = 0;
            userManageDgv.CellClick += userManageDgv_CellClick;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(255, 123);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 27);
            maskedTextBox1.TabIndex = 10;
            // 
            // homeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 822);
            Controls.Add(KasirScreen);
            Controls.Add(userScreen);
            Controls.Add(historyScreen);
            Controls.Add(loginScreen);
            Controls.Add(inventoriScreen);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "homeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KasirPBO";
            Load += homeForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ItemsPanel.ResumeLayout(false);
            ItemsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)transactionDgv).EndInit();
            kasirSplitContainer.Panel1.ResumeLayout(false);
            kasirSplitContainer.Panel1.PerformLayout();
            kasirSplitContainer.Panel2.ResumeLayout(false);
            kasirSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kasirSplitContainer).EndInit();
            kasirSplitContainer.ResumeLayout(false);
            KasirScreen.ResumeLayout(false);
            loginScreen.ResumeLayout(false);
            loginScreen.PerformLayout();
            inventoriScreen.ResumeLayout(false);
            inventoriScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)productsDataGrid).EndInit();
            historyScreen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)historyDgv).EndInit();
            userScreen.ResumeLayout(false);
            userScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userManageDgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label tanggalTitle;
        private System.Windows.Forms.Label tanggalLabel;
        private System.Windows.Forms.Label cashierLabel;
        private System.Windows.Forms.Label cashierTitle;
        private System.Windows.Forms.Label itemPriceLabel;
        private System.Windows.Forms.Label addProductTitle;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalTitle;
        private System.Windows.Forms.Panel ItemsPanel;
        private System.Windows.Forms.Button proccessBtn;
        private System.Windows.Forms.SplitContainer kasirSplitContainer;
        private System.Windows.Forms.Panel KasirScreen;
        private System.Windows.Forms.Panel loginScreen;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label titleText;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Button inventoriBtn;
        private Panel inventoriScreen;
        private DataGridView productsDataGrid;
        private Label label3;
        private TextBox productCodeTxt;
        private Label label6;
        private Label label5;
        private Label label4;
        private DataGridView transactionDgv;
        private Button inventoryBackBtn;
        private TextBox productQuantityTxt;
        private TextBox productPriceTxt;
        private TextBox productNameTxt;
        private Button saveProductBtn;
        private ComboBox productsCmb;
        private Button checkPriceBtn;
        private Button logoutBtn;
        private Button historyBtn;
        private Button clearTransactionBtn;
        private Panel historyScreen;
        private Button historyBackBtn;
        private DataGridView historyDgv;
        private Button reloadHistoryBtn;
        private Button userManageBtn;
        private Panel userScreen;
        private Button userManageSaveBtn;
        private Button userManageBackBtn;
        private TextBox userManageNameTxt;
        private TextBox userManagePasswordTxt;
        private TextBox userManageUsernameTxt;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private DataGridView userManageDgv;
        private ComboBox userManageLevelCmb;
        private TextBox buyerMoneyTxt;
        private Label buyerChangeTxt;
        private Label label12;
        private Label label11;
        private MaskedTextBox maskedTextBox1;
    }
}

