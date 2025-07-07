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
            userManageBtn = new Button();
            clearTransactionBtn = new Button();
            historyBtn = new Button();
            inventoriBtn = new Button();
            checkPriceBtn = new Button();
            proccessBtn = new Button();
            transactionDgv = new DataGridView();
            buyerMoneyTxt = new TextBox();
            buyerChangeTxt = new Label();
            label12 = new Label();
            label11 = new Label();
            kasirSplitContainer = new SplitContainer();
            productsCmb = new ComboBox();
            KasirScreen = new Panel();
            loginScreen = new Panel();
            loginpanel = new Panel();
            label13 = new Label();
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
            panel1.SuspendLayout();
            ItemsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)transactionDgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kasirSplitContainer).BeginInit();
            kasirSplitContainer.Panel1.SuspendLayout();
            kasirSplitContainer.Panel2.SuspendLayout();
            kasirSplitContainer.SuspendLayout();
            KasirScreen.SuspendLayout();
            loginScreen.SuspendLayout();
            loginpanel.SuspendLayout();
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
            addProductBtn.BackColor = Color.MediumSpringGreen;
            addProductBtn.Font = new Font("Verdana", 10F);
            addProductBtn.ForeColor = SystemColors.ControlText;
            addProductBtn.Location = new Point(296, 52);
            addProductBtn.Name = "addProductBtn";
            addProductBtn.Size = new Size(81, 82);
            addProductBtn.TabIndex = 0;
            addProductBtn.Text = "Tambah";
            addProductBtn.UseVisualStyleBackColor = false;
            addProductBtn.Click += addProductBtn_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.BackColor = Color.Transparent;
            title.FlatStyle = FlatStyle.Flat;
            title.Font = new Font("Verdana", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.ForeColor = Color.Honeydew;
            title.Location = new Point(16, 37);
            title.Name = "title";
            title.Size = new Size(211, 48);
            title.TabIndex = 1;
            title.Text = "Eh-Kasir";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(logoutBtn);
            panel1.Controls.Add(cashierLabel);
            panel1.Controls.Add(cashierTitle);
            panel1.Controls.Add(tanggalLabel);
            panel1.Controls.Add(tanggalTitle);
            panel1.Controls.Add(title);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.Control;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 120);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // logoutBtn
            // 
            logoutBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            logoutBtn.BackColor = Color.Honeydew;
            logoutBtn.FlatStyle = FlatStyle.Popup;
            logoutBtn.Font = new Font("Verdana", 13F);
            logoutBtn.ForeColor = SystemColors.ActiveCaptionText;
            logoutBtn.Location = new Point(878, 14);
            logoutBtn.Margin = new Padding(5);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(95, 92);
            logoutBtn.TabIndex = 6;
            logoutBtn.Text = "Log Out";
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // cashierLabel
            // 
            cashierLabel.AutoSize = true;
            cashierLabel.BackColor = Color.Transparent;
            cashierLabel.FlatStyle = FlatStyle.Flat;
            cashierLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cashierLabel.ForeColor = Color.Honeydew;
            cashierLabel.Location = new Point(588, 61);
            cashierLabel.Name = "cashierLabel";
            cashierLabel.Size = new Size(230, 20);
            cashierLabel.TabIndex = 5;
            cashierLabel.Text = "Admin Kasir Tampan Berani";
            // 
            // cashierTitle
            // 
            cashierTitle.AutoSize = true;
            cashierTitle.BackColor = Color.Transparent;
            cashierTitle.FlatStyle = FlatStyle.Flat;
            cashierTitle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cashierTitle.ForeColor = Color.Honeydew;
            cashierTitle.Location = new Point(588, 40);
            cashierTitle.Name = "cashierTitle";
            cashierTitle.Size = new Size(49, 20);
            cashierTitle.TabIndex = 4;
            cashierTitle.Text = "Kasir";
            // 
            // tanggalLabel
            // 
            tanggalLabel.AutoSize = true;
            tanggalLabel.BackColor = Color.Transparent;
            tanggalLabel.FlatStyle = FlatStyle.Flat;
            tanggalLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tanggalLabel.ForeColor = Color.Honeydew;
            tanggalLabel.Location = new Point(332, 62);
            tanggalLabel.Name = "tanggalLabel";
            tanggalLabel.Size = new Size(195, 20);
            tanggalLabel.TabIndex = 3;
            tanggalLabel.Text = "Tuesday, 12 June 2024";
            // 
            // tanggalTitle
            // 
            tanggalTitle.AutoSize = true;
            tanggalTitle.BackColor = Color.Transparent;
            tanggalTitle.FlatStyle = FlatStyle.Flat;
            tanggalTitle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tanggalTitle.ForeColor = Color.Honeydew;
            tanggalTitle.Location = new Point(332, 40);
            tanggalTitle.Name = "tanggalTitle";
            tanggalTitle.Size = new Size(73, 20);
            tanggalTitle.TabIndex = 2;
            tanggalTitle.Text = "Tanggal";
            // 
            // itemPriceLabel
            // 
            itemPriceLabel.AutoSize = true;
            itemPriceLabel.BackColor = Color.Transparent;
            itemPriceLabel.FlatStyle = FlatStyle.Flat;
            itemPriceLabel.Font = new Font("Verdana", 15F, FontStyle.Bold);
            itemPriceLabel.ForeColor = Color.SeaGreen;
            itemPriceLabel.Location = new Point(16, 117);
            itemPriceLabel.Name = "itemPriceLabel";
            itemPriceLabel.Size = new Size(63, 25);
            itemPriceLabel.TabIndex = 7;
            itemPriceLabel.Text = "Rp 0";
            // 
            // addProductTitle
            // 
            addProductTitle.AutoSize = true;
            addProductTitle.BackColor = Color.Transparent;
            addProductTitle.FlatStyle = FlatStyle.Flat;
            addProductTitle.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addProductTitle.ForeColor = Color.SeaGreen;
            addProductTitle.Location = new Point(10, 12);
            addProductTitle.Name = "addProductTitle";
            addProductTitle.Size = new Size(193, 29);
            addProductTitle.TabIndex = 6;
            addProductTitle.Text = "Tambah Item";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.BackColor = Color.Transparent;
            totalLabel.FlatStyle = FlatStyle.Flat;
            totalLabel.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalLabel.ForeColor = Color.SeaGreen;
            totalLabel.Location = new Point(215, 18);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(84, 31);
            totalLabel.TabIndex = 9;
            totalLabel.Text = "Rp. 0";
            totalLabel.Click += totalLabel_Click;
            // 
            // totalTitle
            // 
            totalTitle.AutoSize = true;
            totalTitle.BackColor = Color.Transparent;
            totalTitle.FlatStyle = FlatStyle.Flat;
            totalTitle.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalTitle.ForeColor = Color.SeaGreen;
            totalTitle.Location = new Point(15, 17);
            totalTitle.Name = "totalTitle";
            totalTitle.Size = new Size(185, 31);
            totalTitle.TabIndex = 8;
            totalTitle.Text = "Total Belanja";
            // 
            // ItemsPanel
            // 
            ItemsPanel.BackColor = Color.Transparent;
            ItemsPanel.Controls.Add(userManageBtn);
            ItemsPanel.Controls.Add(clearTransactionBtn);
            ItemsPanel.Controls.Add(historyBtn);
            ItemsPanel.Controls.Add(inventoriBtn);
            ItemsPanel.Controls.Add(checkPriceBtn);
            ItemsPanel.Controls.Add(proccessBtn);
            ItemsPanel.Controls.Add(transactionDgv);
            ItemsPanel.Location = new Point(0, 285);
            ItemsPanel.Name = "ItemsPanel";
            ItemsPanel.Size = new Size(984, 371);
            ItemsPanel.TabIndex = 4;
            // 
            // userManageBtn
            // 
            userManageBtn.BackColor = Color.MediumSpringGreen;
            userManageBtn.Location = new Point(601, 5);
            userManageBtn.Margin = new Padding(3, 2, 3, 2);
            userManageBtn.Name = "userManageBtn";
            userManageBtn.Size = new Size(166, 43);
            userManageBtn.TabIndex = 15;
            userManageBtn.Text = "User Manage";
            userManageBtn.UseVisualStyleBackColor = false;
            userManageBtn.Click += userManageBtn_Click;
            // 
            // clearTransactionBtn
            // 
            clearTransactionBtn.BackColor = Color.MediumSpringGreen;
            clearTransactionBtn.Location = new Point(16, 5);
            clearTransactionBtn.Margin = new Padding(3, 2, 3, 2);
            clearTransactionBtn.Name = "clearTransactionBtn";
            clearTransactionBtn.Size = new Size(82, 43);
            clearTransactionBtn.TabIndex = 14;
            clearTransactionBtn.Text = "Clear";
            clearTransactionBtn.UseVisualStyleBackColor = false;
            clearTransactionBtn.Click += clearTransactionBtn_Click;
            // 
            // historyBtn
            // 
            historyBtn.BackColor = Color.MediumSpringGreen;
            historyBtn.Font = new Font("Verdana", 10F);
            historyBtn.Location = new Point(786, 115);
            historyBtn.Name = "historyBtn";
            historyBtn.Size = new Size(178, 53);
            historyBtn.TabIndex = 13;
            historyBtn.Text = "Histori";
            historyBtn.UseVisualStyleBackColor = false;
            historyBtn.Click += historyBtn_Click;
            // 
            // inventoriBtn
            // 
            inventoriBtn.BackColor = Color.MediumSpringGreen;
            inventoriBtn.Font = new Font("Verdana", 10F);
            inventoriBtn.Location = new Point(786, 177);
            inventoriBtn.Name = "inventoriBtn";
            inventoriBtn.Size = new Size(178, 53);
            inventoriBtn.TabIndex = 12;
            inventoriBtn.Text = "Inventori";
            inventoriBtn.UseVisualStyleBackColor = false;
            inventoriBtn.Click += inventoriBtn_Click;
            // 
            // checkPriceBtn
            // 
            checkPriceBtn.BackColor = Color.MediumSpringGreen;
            checkPriceBtn.Font = new Font("Verdana", 10F);
            checkPriceBtn.Location = new Point(786, 54);
            checkPriceBtn.Name = "checkPriceBtn";
            checkPriceBtn.Size = new Size(178, 53);
            checkPriceBtn.TabIndex = 11;
            checkPriceBtn.Text = "Cek Harga";
            checkPriceBtn.UseVisualStyleBackColor = false;
            checkPriceBtn.Click += checkPriceBtn_Click;
            // 
            // proccessBtn
            // 
            proccessBtn.BackColor = Color.SeaGreen;
            proccessBtn.Font = new Font("Verdana", 18F);
            proccessBtn.ForeColor = Color.Honeydew;
            proccessBtn.Location = new Point(786, 242);
            proccessBtn.Name = "proccessBtn";
            proccessBtn.Size = new Size(178, 112);
            proccessBtn.TabIndex = 8;
            proccessBtn.Text = "Proses";
            proccessBtn.UseVisualStyleBackColor = false;
            proccessBtn.Click += proccessBtn_Click;
            // 
            // transactionDgv
            // 
            transactionDgv.AllowUserToAddRows = false;
            transactionDgv.AllowUserToDeleteRows = false;
            transactionDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            transactionDgv.BackgroundColor = Color.Honeydew;
            transactionDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            transactionDgv.Location = new Point(17, 54);
            transactionDgv.Name = "transactionDgv";
            transactionDgv.RowHeadersWidth = 51;
            transactionDgv.RowTemplate.Height = 24;
            transactionDgv.Size = new Size(750, 300);
            transactionDgv.TabIndex = 0;
            transactionDgv.CellClick += transactionDgv_CellClick;
            transactionDgv.CellContentClick += transactionDgv_CellContentClick;
            transactionDgv.CellPainting += transactionDgv_CellPainting;
            // 
            // buyerMoneyTxt
            // 
            buyerMoneyTxt.Font = new Font("Verdana", 12F);
            buyerMoneyTxt.Location = new Point(221, 68);
            buyerMoneyTxt.Margin = new Padding(3, 2, 3, 2);
            buyerMoneyTxt.Name = "buyerMoneyTxt";
            buyerMoneyTxt.Size = new Size(274, 27);
            buyerMoneyTxt.TabIndex = 18;
            buyerMoneyTxt.TextChanged += buyerMoneyTxt_TextChanged;
            // 
            // buyerChangeTxt
            // 
            buyerChangeTxt.AutoSize = true;
            buyerChangeTxt.BackColor = Color.Transparent;
            buyerChangeTxt.FlatStyle = FlatStyle.Flat;
            buyerChangeTxt.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buyerChangeTxt.ForeColor = Color.SeaGreen;
            buyerChangeTxt.Location = new Point(218, 110);
            buyerChangeTxt.Name = "buyerChangeTxt";
            buyerChangeTxt.Size = new Size(74, 29);
            buyerChangeTxt.TabIndex = 17;
            buyerChangeTxt.Text = "Rp. 0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.FlatStyle = FlatStyle.Flat;
            label12.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.SeaGreen;
            label12.Location = new Point(18, 111);
            label12.Name = "label12";
            label12.Size = new Size(109, 29);
            label12.TabIndex = 16;
            label12.Text = "Kembali";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.FlatStyle = FlatStyle.Flat;
            label11.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.SeaGreen;
            label11.Location = new Point(18, 68);
            label11.Name = "label11";
            label11.Size = new Size(164, 29);
            label11.TabIndex = 10;
            label11.Text = "Jumlah Uang";
            // 
            // kasirSplitContainer
            // 
            kasirSplitContainer.Dock = DockStyle.Top;
            kasirSplitContainer.Location = new Point(0, 120);
            kasirSplitContainer.Name = "kasirSplitContainer";
            // 
            // kasirSplitContainer.Panel1
            // 
            kasirSplitContainer.Panel1.BackColor = Color.Transparent;
            kasirSplitContainer.Panel1.Controls.Add(productsCmb);
            kasirSplitContainer.Panel1.Controls.Add(itemPriceLabel);
            kasirSplitContainer.Panel1.Controls.Add(addProductTitle);
            kasirSplitContainer.Panel1.Controls.Add(addProductBtn);
            // 
            // kasirSplitContainer.Panel2
            // 
            kasirSplitContainer.Panel2.BackColor = Color.Transparent;
            kasirSplitContainer.Panel2.Controls.Add(buyerMoneyTxt);
            kasirSplitContainer.Panel2.Controls.Add(totalLabel);
            kasirSplitContainer.Panel2.Controls.Add(buyerChangeTxt);
            kasirSplitContainer.Panel2.Controls.Add(totalTitle);
            kasirSplitContainer.Panel2.Controls.Add(label12);
            kasirSplitContainer.Panel2.Controls.Add(label11);
            kasirSplitContainer.Size = new Size(984, 158);
            kasirSplitContainer.SplitterDistance = 399;
            kasirSplitContainer.TabIndex = 5;
            // 
            // productsCmb
            // 
            productsCmb.FormattingEnabled = true;
            productsCmb.Location = new Point(16, 82);
            productsCmb.Margin = new Padding(3, 2, 3, 2);
            productsCmb.Name = "productsCmb";
            productsCmb.Size = new Size(264, 22);
            productsCmb.TabIndex = 8;
            productsCmb.SelectedIndexChanged += productsCmb_SelectedIndexChanged;
            // 
            // KasirScreen
            // 
            KasirScreen.BackColor = Color.White;
            KasirScreen.Controls.Add(ItemsPanel);
            KasirScreen.Controls.Add(kasirSplitContainer);
            KasirScreen.Controls.Add(panel1);
            KasirScreen.Dock = DockStyle.Fill;
            KasirScreen.Font = new Font("Verdana", 9F);
            KasirScreen.Location = new Point(0, 0);
            KasirScreen.Name = "KasirScreen";
            KasirScreen.Size = new Size(984, 657);
            KasirScreen.TabIndex = 10;
            // 
            // loginScreen
            // 
            loginScreen.BackColor = Color.White;
            loginScreen.BackgroundImageLayout = ImageLayout.Stretch;
            loginScreen.Controls.Add(loginpanel);
            loginScreen.Dock = DockStyle.Fill;
            loginScreen.Location = new Point(0, 0);
            loginScreen.Name = "loginScreen";
            loginScreen.Padding = new Padding(5);
            loginScreen.Size = new Size(984, 657);
            loginScreen.TabIndex = 10;
            loginScreen.Paint += loginScreen_Paint;
            // 
            // loginpanel
            // 
            loginpanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loginpanel.BackColor = Color.MediumSpringGreen;
            loginpanel.Controls.Add(label13);
            loginpanel.Controls.Add(label2);
            loginpanel.Controls.Add(label1);
            loginpanel.Controls.Add(passwordTxt);
            loginpanel.Controls.Add(usernameTxt);
            loginpanel.Controls.Add(titleText);
            loginpanel.Controls.Add(loginBtn);
            loginpanel.Font = new Font("Verdana", 9F);
            loginpanel.Location = new Point(337, 114);
            loginpanel.Margin = new Padding(0);
            loginpanel.Name = "loginpanel";
            loginpanel.Padding = new Padding(10, 10, 10, 20);
            loginpanel.Size = new Size(300, 346);
            loginpanel.TabIndex = 6;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Verdana", 5F);
            label13.Location = new Point(134, 307);
            label13.Name = "label13";
            label13.Size = new Size(31, 24);
            label13.TabIndex = 6;
            label13.Text = "Created\r\nby\r\nHAVOC";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 158);
            label2.Name = "label2";
            label2.Size = new Size(69, 14);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 95);
            label1.Name = "label1";
            label1.Size = new Size(71, 14);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // passwordTxt
            // 
            passwordTxt.Location = new Point(51, 176);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.PasswordChar = '*';
            passwordTxt.Size = new Size(200, 22);
            passwordTxt.TabIndex = 3;
            // 
            // usernameTxt
            // 
            usernameTxt.Location = new Point(51, 113);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(200, 22);
            usernameTxt.TabIndex = 2;
            // 
            // titleText
            // 
            titleText.AutoSize = true;
            titleText.Font = new Font("Verdana", 23.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleText.Location = new Point(72, 35);
            titleText.Name = "titleText";
            titleText.Size = new Size(164, 38);
            titleText.TabIndex = 1;
            titleText.Text = "Eh-Kasir";
            // 
            // loginBtn
            // 
            loginBtn.Anchor = AnchorStyles.Bottom;
            loginBtn.BackColor = Color.SeaGreen;
            loginBtn.FlatStyle = FlatStyle.Popup;
            loginBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            loginBtn.ForeColor = SystemColors.Control;
            loginBtn.Location = new Point(51, 235);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(200, 50);
            loginBtn.TabIndex = 0;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
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
            inventoriScreen.Margin = new Padding(3, 2, 3, 2);
            inventoriScreen.Name = "inventoriScreen";
            inventoriScreen.Size = new Size(984, 657);
            inventoriScreen.TabIndex = 13;
            // 
            // saveProductBtn
            // 
            saveProductBtn.Location = new Point(780, 125);
            saveProductBtn.Margin = new Padding(3, 2, 3, 2);
            saveProductBtn.Name = "saveProductBtn";
            saveProductBtn.Size = new Size(82, 22);
            saveProductBtn.TabIndex = 10;
            saveProductBtn.Text = "Save";
            saveProductBtn.UseVisualStyleBackColor = true;
            saveProductBtn.Click += saveProductBtn_Click;
            // 
            // inventoryBackBtn
            // 
            inventoryBackBtn.Location = new Point(39, 21);
            inventoryBackBtn.Margin = new Padding(3, 2, 3, 2);
            inventoryBackBtn.Name = "inventoryBackBtn";
            inventoryBackBtn.Size = new Size(82, 22);
            inventoryBackBtn.TabIndex = 9;
            inventoryBackBtn.Text = "Kembali";
            inventoryBackBtn.UseVisualStyleBackColor = true;
            inventoryBackBtn.Click += inventoryBackBtn_Click;
            // 
            // productQuantityTxt
            // 
            productQuantityTxt.Location = new Point(436, 127);
            productQuantityTxt.Margin = new Padding(3, 2, 3, 2);
            productQuantityTxt.Name = "productQuantityTxt";
            productQuantityTxt.Size = new Size(110, 23);
            productQuantityTxt.TabIndex = 8;
            // 
            // productPriceTxt
            // 
            productPriceTxt.Location = new Point(295, 127);
            productPriceTxt.Margin = new Padding(3, 2, 3, 2);
            productPriceTxt.Name = "productPriceTxt";
            productPriceTxt.Size = new Size(110, 23);
            productPriceTxt.TabIndex = 7;
            // 
            // productNameTxt
            // 
            productNameTxt.Location = new Point(164, 127);
            productNameTxt.Margin = new Padding(3, 2, 3, 2);
            productNameTxt.Name = "productNameTxt";
            productNameTxt.Size = new Size(110, 23);
            productNameTxt.TabIndex = 6;
            // 
            // productCodeTxt
            // 
            productCodeTxt.Location = new Point(39, 127);
            productCodeTxt.Margin = new Padding(3, 2, 3, 2);
            productCodeTxt.Name = "productCodeTxt";
            productCodeTxt.Size = new Size(110, 23);
            productCodeTxt.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(436, 110);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 4;
            label6.Text = "Jumlah";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(295, 110);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 3;
            label5.Text = "Harga";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 110);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 2;
            label4.Text = "Kode";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(164, 110);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 1;
            label3.Text = "Nama Produk";
            // 
            // productsDataGrid
            // 
            productsDataGrid.AllowUserToAddRows = false;
            productsDataGrid.AllowUserToDeleteRows = false;
            productsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsDataGrid.Location = new Point(39, 177);
            productsDataGrid.Margin = new Padding(3, 2, 3, 2);
            productsDataGrid.Name = "productsDataGrid";
            productsDataGrid.RowHeadersWidth = 51;
            productsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productsDataGrid.Size = new Size(823, 425);
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
            historyScreen.Margin = new Padding(3, 2, 3, 2);
            historyScreen.Name = "historyScreen";
            historyScreen.Size = new Size(984, 657);
            historyScreen.TabIndex = 14;
            // 
            // reloadHistoryBtn
            // 
            reloadHistoryBtn.Location = new Point(780, 52);
            reloadHistoryBtn.Margin = new Padding(3, 2, 3, 2);
            reloadHistoryBtn.Name = "reloadHistoryBtn";
            reloadHistoryBtn.Size = new Size(82, 22);
            reloadHistoryBtn.TabIndex = 10;
            reloadHistoryBtn.Text = "Reload";
            reloadHistoryBtn.UseVisualStyleBackColor = true;
            reloadHistoryBtn.Click += reloadHistoryBtn_Click;
            // 
            // historyBackBtn
            // 
            historyBackBtn.Location = new Point(39, 21);
            historyBackBtn.Margin = new Padding(3, 2, 3, 2);
            historyBackBtn.Name = "historyBackBtn";
            historyBackBtn.Size = new Size(82, 22);
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
            historyDgv.Location = new Point(39, 86);
            historyDgv.Margin = new Padding(3, 2, 3, 2);
            historyDgv.Name = "historyDgv";
            historyDgv.RowHeadersWidth = 51;
            historyDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            historyDgv.Size = new Size(823, 517);
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
            userScreen.Margin = new Padding(3, 2, 3, 2);
            userScreen.Name = "userScreen";
            userScreen.Size = new Size(984, 657);
            userScreen.TabIndex = 15;
            // 
            // userManageLevelCmb
            // 
            userManageLevelCmb.FormattingEnabled = true;
            userManageLevelCmb.Location = new Point(436, 125);
            userManageLevelCmb.Margin = new Padding(3, 2, 3, 2);
            userManageLevelCmb.Name = "userManageLevelCmb";
            userManageLevelCmb.Size = new Size(133, 23);
            userManageLevelCmb.TabIndex = 11;
            // 
            // userManageSaveBtn
            // 
            userManageSaveBtn.Location = new Point(780, 125);
            userManageSaveBtn.Margin = new Padding(3, 2, 3, 2);
            userManageSaveBtn.Name = "userManageSaveBtn";
            userManageSaveBtn.Size = new Size(82, 22);
            userManageSaveBtn.TabIndex = 10;
            userManageSaveBtn.Text = "Save";
            userManageSaveBtn.UseVisualStyleBackColor = true;
            userManageSaveBtn.Click += userManageSaveBtn_Click;
            // 
            // userManageBackBtn
            // 
            userManageBackBtn.Location = new Point(39, 21);
            userManageBackBtn.Margin = new Padding(3, 2, 3, 2);
            userManageBackBtn.Name = "userManageBackBtn";
            userManageBackBtn.Size = new Size(82, 22);
            userManageBackBtn.TabIndex = 9;
            userManageBackBtn.Text = "Kembali";
            userManageBackBtn.UseVisualStyleBackColor = true;
            userManageBackBtn.Click += userManageBackBtn_Click;
            // 
            // userManageNameTxt
            // 
            userManageNameTxt.Location = new Point(295, 127);
            userManageNameTxt.Margin = new Padding(3, 2, 3, 2);
            userManageNameTxt.Name = "userManageNameTxt";
            userManageNameTxt.Size = new Size(110, 23);
            userManageNameTxt.TabIndex = 7;
            // 
            // userManagePasswordTxt
            // 
            userManagePasswordTxt.Location = new Point(164, 127);
            userManagePasswordTxt.Margin = new Padding(3, 2, 3, 2);
            userManagePasswordTxt.Name = "userManagePasswordTxt";
            userManagePasswordTxt.PasswordChar = '*';
            userManagePasswordTxt.Size = new Size(110, 23);
            userManagePasswordTxt.TabIndex = 6;
            // 
            // userManageUsernameTxt
            // 
            userManageUsernameTxt.Location = new Point(39, 127);
            userManageUsernameTxt.Margin = new Padding(3, 2, 3, 2);
            userManageUsernameTxt.Name = "userManageUsernameTxt";
            userManageUsernameTxt.Size = new Size(110, 23);
            userManageUsernameTxt.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(436, 110);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 4;
            label7.Text = "Tugas";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(295, 110);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 3;
            label8.Text = "Nama";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(39, 110);
            label9.Name = "label9";
            label9.Size = new Size(60, 15);
            label9.TabIndex = 2;
            label9.Text = "Username";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(164, 110);
            label10.Name = "label10";
            label10.Size = new Size(57, 15);
            label10.TabIndex = 1;
            label10.Text = "Password";
            // 
            // userManageDgv
            // 
            userManageDgv.AllowUserToDeleteRows = false;
            userManageDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            userManageDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userManageDgv.Location = new Point(39, 177);
            userManageDgv.Margin = new Padding(3, 2, 3, 2);
            userManageDgv.Name = "userManageDgv";
            userManageDgv.RowHeadersWidth = 51;
            userManageDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            userManageDgv.Size = new Size(823, 425);
            userManageDgv.TabIndex = 0;
            userManageDgv.CellClick += userManageDgv_CellClick;
            // 
            // homeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 657);
            Controls.Add(KasirScreen);
            Controls.Add(loginScreen);
            Controls.Add(userScreen);
            Controls.Add(historyScreen);
            Controls.Add(inventoriScreen);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "homeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KasirPBO";
            Load += homeForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ItemsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)transactionDgv).EndInit();
            kasirSplitContainer.Panel1.ResumeLayout(false);
            kasirSplitContainer.Panel1.PerformLayout();
            kasirSplitContainer.Panel2.ResumeLayout(false);
            kasirSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kasirSplitContainer).EndInit();
            kasirSplitContainer.ResumeLayout(false);
            KasirScreen.ResumeLayout(false);
            loginScreen.ResumeLayout(false);
            loginpanel.ResumeLayout(false);
            loginpanel.PerformLayout();
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
        private Panel loginpanel;
        private Label label13;
    }
}

