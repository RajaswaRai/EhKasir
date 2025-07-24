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
            productsCmb = new ComboBox();
            KasirScreen = new Panel();
            panel8 = new Panel();
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
            panel5 = new Panel();
            inventoryBackBtn = new Button();
            productQuantityTxt = new TextBox();
            productPriceTxt = new TextBox();
            productNameTxt = new TextBox();
            productCodeTxt = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            saveProductBtn = new Button();
            panel6 = new Panel();
            productsDataGrid = new DataGridView();
            historyScreen = new Panel();
            panel3 = new Panel();
            reloadHistoryBtn = new Button();
            historyBackBtn = new Button();
            panel4 = new Panel();
            historyDgv = new DataGridView();
            userScreen = new Panel();
            panel2 = new Panel();
            userManageSaveBtn = new Button();
            userManageBackBtn = new Button();
            userManageNameTxt = new TextBox();
            userManagePasswordTxt = new TextBox();
            userManageUsernameTxt = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            userManageLevelCmb = new ComboBox();
            panel7 = new Panel();
            userManageDgv = new DataGridView();
            panel1.SuspendLayout();
            ItemsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)transactionDgv).BeginInit();
            KasirScreen.SuspendLayout();
            panel8.SuspendLayout();
            loginScreen.SuspendLayout();
            loginpanel.SuspendLayout();
            inventoriScreen.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productsDataGrid).BeginInit();
            historyScreen.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)historyDgv).BeginInit();
            userScreen.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userManageDgv).BeginInit();
            SuspendLayout();
            // 
            // addProductBtn
            // 
            addProductBtn.BackColor = Color.MediumSpringGreen;
            addProductBtn.Font = new Font("Verdana", 10F);
            addProductBtn.ForeColor = SystemColors.ControlText;
            addProductBtn.Location = new Point(271, 54);
            addProductBtn.Name = "addProductBtn";
            addProductBtn.Size = new Size(81, 63);
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
            logoutBtn.Font = new Font("Verdana", 10F);
            logoutBtn.ForeColor = SystemColors.ActiveCaptionText;
            logoutBtn.Location = new Point(878, 18);
            logoutBtn.Margin = new Padding(5);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(95, 83);
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
            itemPriceLabel.Location = new Point(9, 94);
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
            addProductTitle.Location = new Point(11, 11);
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
            totalLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalLabel.ForeColor = Color.SeaGreen;
            totalLabel.Location = new Point(680, 10);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(74, 29);
            totalLabel.TabIndex = 9;
            totalLabel.Text = "Rp. 0";
            totalLabel.Click += totalLabel_Click;
            // 
            // totalTitle
            // 
            totalTitle.AutoSize = true;
            totalTitle.BackColor = Color.Transparent;
            totalTitle.FlatStyle = FlatStyle.Flat;
            totalTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalTitle.ForeColor = Color.SeaGreen;
            totalTitle.Location = new Point(422, 10);
            totalTitle.Name = "totalTitle";
            totalTitle.Size = new Size(168, 29);
            totalTitle.TabIndex = 8;
            totalTitle.Text = "Total Belanja";
            // 
            // ItemsPanel
            // 
            ItemsPanel.BackColor = Color.Honeydew;
            ItemsPanel.Controls.Add(userManageBtn);
            ItemsPanel.Controls.Add(clearTransactionBtn);
            ItemsPanel.Controls.Add(historyBtn);
            ItemsPanel.Controls.Add(inventoriBtn);
            ItemsPanel.Controls.Add(checkPriceBtn);
            ItemsPanel.Controls.Add(proccessBtn);
            ItemsPanel.Controls.Add(transactionDgv);
            ItemsPanel.Location = new Point(8, 264);
            ItemsPanel.Name = "ItemsPanel";
            ItemsPanel.Size = new Size(968, 385);
            ItemsPanel.TabIndex = 4;
            ItemsPanel.Paint += ItemsPanel_Paint;
            // 
            // userManageBtn
            // 
            userManageBtn.BackColor = Color.MediumSpringGreen;
            userManageBtn.Location = new Point(644, 7);
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
            clearTransactionBtn.Location = new Point(6, 7);
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
            historyBtn.Location = new Point(818, 123);
            historyBtn.Name = "historyBtn";
            historyBtn.Size = new Size(142, 65);
            historyBtn.TabIndex = 13;
            historyBtn.Text = "Histori";
            historyBtn.UseVisualStyleBackColor = false;
            historyBtn.Click += historyBtn_Click;
            // 
            // inventoriBtn
            // 
            inventoriBtn.BackColor = Color.MediumSpringGreen;
            inventoriBtn.Font = new Font("Verdana", 10F);
            inventoriBtn.Location = new Point(818, 192);
            inventoriBtn.Name = "inventoriBtn";
            inventoriBtn.Size = new Size(142, 65);
            inventoriBtn.TabIndex = 12;
            inventoriBtn.Text = "Inventori";
            inventoriBtn.UseVisualStyleBackColor = false;
            inventoriBtn.Click += inventoriBtn_Click;
            // 
            // checkPriceBtn
            // 
            checkPriceBtn.BackColor = Color.MediumSpringGreen;
            checkPriceBtn.Font = new Font("Verdana", 10F);
            checkPriceBtn.Location = new Point(818, 54);
            checkPriceBtn.Name = "checkPriceBtn";
            checkPriceBtn.Size = new Size(142, 65);
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
            proccessBtn.Location = new Point(818, 260);
            proccessBtn.Name = "proccessBtn";
            proccessBtn.Size = new Size(142, 117);
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
            transactionDgv.BackgroundColor = Color.White;
            transactionDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            transactionDgv.Location = new Point(6, 54);
            transactionDgv.Name = "transactionDgv";
            transactionDgv.RowHeadersWidth = 51;
            transactionDgv.RowTemplate.Height = 24;
            transactionDgv.Size = new Size(804, 324);
            transactionDgv.TabIndex = 0;
            transactionDgv.CellClick += transactionDgv_CellClick;
            transactionDgv.CellContentClick += transactionDgv_CellContentClick;
            transactionDgv.CellPainting += transactionDgv_CellPainting;
            // 
            // buyerMoneyTxt
            // 
            buyerMoneyTxt.Font = new Font("Verdana", 12F);
            buyerMoneyTxt.Location = new Point(680, 50);
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
            buyerChangeTxt.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buyerChangeTxt.ForeColor = Color.SeaGreen;
            buyerChangeTxt.Location = new Point(680, 92);
            buyerChangeTxt.Name = "buyerChangeTxt";
            buyerChangeTxt.Size = new Size(62, 25);
            buyerChangeTxt.TabIndex = 17;
            buyerChangeTxt.Text = "Rp. 0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.FlatStyle = FlatStyle.Flat;
            label12.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.SeaGreen;
            label12.Location = new Point(422, 92);
            label12.Name = "label12";
            label12.Size = new Size(90, 25);
            label12.TabIndex = 16;
            label12.Text = "Kembali";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.FlatStyle = FlatStyle.Flat;
            label11.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.SeaGreen;
            label11.Location = new Point(422, 52);
            label11.Name = "label11";
            label11.Size = new Size(139, 25);
            label11.TabIndex = 10;
            label11.Text = "Jumlah Uang";
            // 
            // productsCmb
            // 
            productsCmb.Font = new Font("Verdana", 12F);
            productsCmb.FormattingEnabled = true;
            productsCmb.Location = new Point(12, 54);
            productsCmb.Margin = new Padding(3, 2, 3, 2);
            productsCmb.Name = "productsCmb";
            productsCmb.Size = new Size(253, 26);
            productsCmb.TabIndex = 8;
            productsCmb.SelectedIndexChanged += productsCmb_SelectedIndexChanged;
            // 
            // KasirScreen
            // 
            KasirScreen.BackColor = Color.White;
            KasirScreen.Controls.Add(ItemsPanel);
            KasirScreen.Controls.Add(panel8);
            KasirScreen.Controls.Add(panel1);
            KasirScreen.Dock = DockStyle.Fill;
            KasirScreen.Font = new Font("Verdana", 9F);
            KasirScreen.Location = new Point(0, 0);
            KasirScreen.Name = "KasirScreen";
            KasirScreen.Size = new Size(984, 659);
            KasirScreen.TabIndex = 10;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Honeydew;
            panel8.Controls.Add(label11);
            panel8.Controls.Add(label12);
            panel8.Controls.Add(totalTitle);
            panel8.Controls.Add(buyerChangeTxt);
            panel8.Controls.Add(totalLabel);
            panel8.Controls.Add(buyerMoneyTxt);
            panel8.Controls.Add(addProductBtn);
            panel8.Controls.Add(addProductTitle);
            panel8.Controls.Add(itemPriceLabel);
            panel8.Controls.Add(productsCmb);
            panel8.Location = new Point(8, 127);
            panel8.Name = "panel8";
            panel8.Size = new Size(968, 131);
            panel8.TabIndex = 19;
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
            loginScreen.Size = new Size(984, 659);
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
            loginpanel.Size = new Size(300, 348);
            loginpanel.TabIndex = 6;
            loginpanel.Paint += loginpanel_Paint;
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
            loginBtn.Location = new Point(51, 237);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(200, 50);
            loginBtn.TabIndex = 0;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // inventoriScreen
            // 
            inventoriScreen.BackColor = Color.White;
            inventoriScreen.Controls.Add(panel5);
            inventoriScreen.Controls.Add(panel6);
            inventoriScreen.Dock = DockStyle.Fill;
            inventoriScreen.Location = new Point(0, 0);
            inventoriScreen.Margin = new Padding(3, 2, 3, 2);
            inventoriScreen.Name = "inventoriScreen";
            inventoriScreen.Size = new Size(984, 659);
            inventoriScreen.TabIndex = 13;
            inventoriScreen.Paint += inventoriScreen_Paint;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Honeydew;
            panel5.Controls.Add(inventoryBackBtn);
            panel5.Controls.Add(productQuantityTxt);
            panel5.Controls.Add(productPriceTxt);
            panel5.Controls.Add(productNameTxt);
            panel5.Controls.Add(productCodeTxt);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(saveProductBtn);
            panel5.Location = new Point(8, 11);
            panel5.Name = "panel5";
            panel5.Size = new Size(968, 120);
            panel5.TabIndex = 11;
            // 
            // inventoryBackBtn
            // 
            inventoryBackBtn.BackColor = Color.MediumSeaGreen;
            inventoryBackBtn.Font = new Font("Segoe UI", 10F);
            inventoryBackBtn.Location = new Point(10, 11);
            inventoryBackBtn.Margin = new Padding(3, 2, 3, 2);
            inventoryBackBtn.Name = "inventoryBackBtn";
            inventoryBackBtn.Size = new Size(109, 38);
            inventoryBackBtn.TabIndex = 9;
            inventoryBackBtn.Text = "Kembali";
            inventoryBackBtn.UseVisualStyleBackColor = false;
            inventoryBackBtn.Click += inventoryBackBtn_Click;
            // 
            // productQuantityTxt
            // 
            productQuantityTxt.Font = new Font("Segoe UI", 10F);
            productQuantityTxt.Location = new Point(407, 84);
            productQuantityTxt.Margin = new Padding(3, 2, 3, 2);
            productQuantityTxt.Name = "productQuantityTxt";
            productQuantityTxt.Size = new Size(110, 25);
            productQuantityTxt.TabIndex = 8;
            // 
            // productPriceTxt
            // 
            productPriceTxt.Font = new Font("Segoe UI", 10F);
            productPriceTxt.Location = new Point(266, 84);
            productPriceTxt.Margin = new Padding(3, 2, 3, 2);
            productPriceTxt.Name = "productPriceTxt";
            productPriceTxt.Size = new Size(110, 25);
            productPriceTxt.TabIndex = 7;
            // 
            // productNameTxt
            // 
            productNameTxt.Font = new Font("Segoe UI", 10F);
            productNameTxt.Location = new Point(135, 84);
            productNameTxt.Margin = new Padding(3, 2, 3, 2);
            productNameTxt.Name = "productNameTxt";
            productNameTxt.Size = new Size(110, 25);
            productNameTxt.TabIndex = 6;
            // 
            // productCodeTxt
            // 
            productCodeTxt.Font = new Font("Segoe UI", 10F);
            productCodeTxt.Location = new Point(10, 84);
            productCodeTxt.Margin = new Padding(3, 2, 3, 2);
            productCodeTxt.Name = "productCodeTxt";
            productCodeTxt.Size = new Size(110, 25);
            productCodeTxt.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = Color.SeaGreen;
            label6.Location = new Point(407, 67);
            label6.Name = "label6";
            label6.Size = new Size(52, 19);
            label6.TabIndex = 4;
            label6.Text = "Jumlah";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.SeaGreen;
            label5.Location = new Point(266, 67);
            label5.Name = "label5";
            label5.Size = new Size(46, 19);
            label5.TabIndex = 3;
            label5.Text = "Harga";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.SeaGreen;
            label4.Location = new Point(10, 67);
            label4.Name = "label4";
            label4.Size = new Size(40, 19);
            label4.TabIndex = 2;
            label4.Text = "Kode";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.SeaGreen;
            label3.Location = new Point(135, 67);
            label3.Name = "label3";
            label3.Size = new Size(93, 19);
            label3.TabIndex = 1;
            label3.Text = "Nama Produk";
            // 
            // saveProductBtn
            // 
            saveProductBtn.BackColor = Color.MediumSpringGreen;
            saveProductBtn.Font = new Font("Segoe UI", 10F);
            saveProductBtn.Location = new Point(818, 70);
            saveProductBtn.Margin = new Padding(3, 2, 3, 2);
            saveProductBtn.Name = "saveProductBtn";
            saveProductBtn.Size = new Size(138, 39);
            saveProductBtn.TabIndex = 10;
            saveProductBtn.Text = "Save";
            saveProductBtn.UseVisualStyleBackColor = false;
            saveProductBtn.Click += saveProductBtn_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Honeydew;
            panel6.Controls.Add(productsDataGrid);
            panel6.Location = new Point(8, 141);
            panel6.Name = "panel6";
            panel6.Size = new Size(968, 508);
            panel6.TabIndex = 12;
            // 
            // productsDataGrid
            // 
            productsDataGrid.AllowUserToAddRows = false;
            productsDataGrid.AllowUserToDeleteRows = false;
            productsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productsDataGrid.BackgroundColor = Color.White;
            productsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsDataGrid.Location = new Point(10, 8);
            productsDataGrid.Margin = new Padding(3, 2, 3, 2);
            productsDataGrid.Name = "productsDataGrid";
            productsDataGrid.RowHeadersWidth = 51;
            productsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productsDataGrid.Size = new Size(946, 489);
            productsDataGrid.TabIndex = 0;
            productsDataGrid.CellClick += productsDataGrid_CellClick;
            productsDataGrid.CellContentClick += productsDataGrid_CellContentClick;
            // 
            // historyScreen
            // 
            historyScreen.BackColor = Color.White;
            historyScreen.Controls.Add(panel3);
            historyScreen.Controls.Add(panel4);
            historyScreen.Dock = DockStyle.Fill;
            historyScreen.Location = new Point(0, 0);
            historyScreen.Margin = new Padding(3, 2, 3, 2);
            historyScreen.Name = "historyScreen";
            historyScreen.Size = new Size(984, 659);
            historyScreen.TabIndex = 14;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Honeydew;
            panel3.Controls.Add(reloadHistoryBtn);
            panel3.Controls.Add(historyBackBtn);
            panel3.Location = new Point(8, 8);
            panel3.Name = "panel3";
            panel3.Size = new Size(968, 70);
            panel3.TabIndex = 11;
            // 
            // reloadHistoryBtn
            // 
            reloadHistoryBtn.BackColor = Color.MediumSpringGreen;
            reloadHistoryBtn.Location = new Point(846, 13);
            reloadHistoryBtn.Margin = new Padding(3, 2, 3, 2);
            reloadHistoryBtn.Name = "reloadHistoryBtn";
            reloadHistoryBtn.Size = new Size(110, 42);
            reloadHistoryBtn.TabIndex = 10;
            reloadHistoryBtn.Text = "Reload";
            reloadHistoryBtn.UseVisualStyleBackColor = false;
            reloadHistoryBtn.Click += reloadHistoryBtn_Click;
            // 
            // historyBackBtn
            // 
            historyBackBtn.BackColor = Color.MediumSeaGreen;
            historyBackBtn.Location = new Point(10, 13);
            historyBackBtn.Margin = new Padding(3, 2, 3, 2);
            historyBackBtn.Name = "historyBackBtn";
            historyBackBtn.Size = new Size(110, 42);
            historyBackBtn.TabIndex = 9;
            historyBackBtn.Text = "Kembali";
            historyBackBtn.UseVisualStyleBackColor = false;
            historyBackBtn.Click += historyBackBtn_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Honeydew;
            panel4.Controls.Add(historyDgv);
            panel4.Location = new Point(8, 88);
            panel4.Name = "panel4";
            panel4.Size = new Size(968, 561);
            panel4.TabIndex = 12;
            // 
            // historyDgv
            // 
            historyDgv.AllowUserToAddRows = false;
            historyDgv.AllowUserToDeleteRows = false;
            historyDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            historyDgv.BackgroundColor = Color.White;
            historyDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            historyDgv.Location = new Point(9, 11);
            historyDgv.Margin = new Padding(3, 2, 3, 2);
            historyDgv.Name = "historyDgv";
            historyDgv.RowHeadersWidth = 51;
            historyDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            historyDgv.Size = new Size(947, 489);
            historyDgv.TabIndex = 0;
            // 
            // userScreen
            // 
            userScreen.BackColor = Color.White;
            userScreen.Controls.Add(panel2);
            userScreen.Controls.Add(panel7);
            userScreen.Dock = DockStyle.Fill;
            userScreen.Location = new Point(0, 0);
            userScreen.Margin = new Padding(3, 2, 3, 2);
            userScreen.Name = "userScreen";
            userScreen.Size = new Size(984, 659);
            userScreen.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Honeydew;
            panel2.Controls.Add(userManageSaveBtn);
            panel2.Controls.Add(userManageBackBtn);
            panel2.Controls.Add(userManageNameTxt);
            panel2.Controls.Add(userManagePasswordTxt);
            panel2.Controls.Add(userManageUsernameTxt);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(userManageLevelCmb);
            panel2.Location = new Point(8, 8);
            panel2.Name = "panel2";
            panel2.Size = new Size(968, 120);
            panel2.TabIndex = 12;
            // 
            // userManageSaveBtn
            // 
            userManageSaveBtn.BackColor = Color.MediumSpringGreen;
            userManageSaveBtn.Font = new Font("Segoe UI", 12F);
            userManageSaveBtn.Location = new Point(776, 69);
            userManageSaveBtn.Margin = new Padding(3, 2, 3, 2);
            userManageSaveBtn.Name = "userManageSaveBtn";
            userManageSaveBtn.Size = new Size(184, 41);
            userManageSaveBtn.TabIndex = 10;
            userManageSaveBtn.Text = "Save";
            userManageSaveBtn.UseVisualStyleBackColor = false;
            userManageSaveBtn.Click += userManageSaveBtn_Click;
            // 
            // userManageBackBtn
            // 
            userManageBackBtn.BackColor = Color.MediumSeaGreen;
            userManageBackBtn.Location = new Point(10, 11);
            userManageBackBtn.Margin = new Padding(3, 2, 3, 2);
            userManageBackBtn.Name = "userManageBackBtn";
            userManageBackBtn.Size = new Size(112, 41);
            userManageBackBtn.TabIndex = 9;
            userManageBackBtn.Text = "Kembali";
            userManageBackBtn.UseVisualStyleBackColor = false;
            userManageBackBtn.Click += userManageBackBtn_Click;
            // 
            // userManageNameTxt
            // 
            userManageNameTxt.Font = new Font("Segoe UI", 10F);
            userManageNameTxt.Location = new Point(265, 86);
            userManageNameTxt.Margin = new Padding(3, 2, 3, 2);
            userManageNameTxt.Name = "userManageNameTxt";
            userManageNameTxt.Size = new Size(110, 25);
            userManageNameTxt.TabIndex = 7;
            // 
            // userManagePasswordTxt
            // 
            userManagePasswordTxt.Font = new Font("Segoe UI", 10F);
            userManagePasswordTxt.Location = new Point(134, 86);
            userManagePasswordTxt.Margin = new Padding(3, 2, 3, 2);
            userManagePasswordTxt.Name = "userManagePasswordTxt";
            userManagePasswordTxt.PasswordChar = '*';
            userManagePasswordTxt.Size = new Size(110, 25);
            userManagePasswordTxt.TabIndex = 6;
            // 
            // userManageUsernameTxt
            // 
            userManageUsernameTxt.Font = new Font("Segoe UI", 10F);
            userManageUsernameTxt.Location = new Point(9, 86);
            userManageUsernameTxt.Margin = new Padding(3, 2, 3, 2);
            userManageUsernameTxt.Name = "userManageUsernameTxt";
            userManageUsernameTxt.Size = new Size(110, 25);
            userManageUsernameTxt.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = Color.SeaGreen;
            label7.Location = new Point(406, 63);
            label7.Name = "label7";
            label7.Size = new Size(45, 19);
            label7.TabIndex = 4;
            label7.Text = "Tugas";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.ForeColor = Color.SeaGreen;
            label8.Location = new Point(265, 63);
            label8.Name = "label8";
            label8.Size = new Size(45, 19);
            label8.TabIndex = 3;
            label8.Text = "Nama";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.ForeColor = Color.SeaGreen;
            label9.Location = new Point(9, 63);
            label9.Name = "label9";
            label9.Size = new Size(71, 19);
            label9.TabIndex = 2;
            label9.Text = "Username";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F);
            label10.ForeColor = Color.SeaGreen;
            label10.Location = new Point(134, 63);
            label10.Name = "label10";
            label10.Size = new Size(67, 19);
            label10.TabIndex = 1;
            label10.Text = "Password";
            // 
            // userManageLevelCmb
            // 
            userManageLevelCmb.Font = new Font("Segoe UI", 10F);
            userManageLevelCmb.FormattingEnabled = true;
            userManageLevelCmb.Location = new Point(406, 84);
            userManageLevelCmb.Margin = new Padding(3, 2, 3, 2);
            userManageLevelCmb.Name = "userManageLevelCmb";
            userManageLevelCmb.Size = new Size(133, 25);
            userManageLevelCmb.TabIndex = 11;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Honeydew;
            panel7.Controls.Add(userManageDgv);
            panel7.Location = new Point(8, 138);
            panel7.Name = "panel7";
            panel7.Size = new Size(968, 507);
            panel7.TabIndex = 13;
            // 
            // userManageDgv
            // 
            userManageDgv.AllowUserToDeleteRows = false;
            userManageDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            userManageDgv.BackgroundColor = Color.White;
            userManageDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userManageDgv.Location = new Point(10, 11);
            userManageDgv.Margin = new Padding(3, 2, 3, 2);
            userManageDgv.Name = "userManageDgv";
            userManageDgv.RowHeadersWidth = 51;
            userManageDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            userManageDgv.Size = new Size(950, 486);
            userManageDgv.TabIndex = 0;
            userManageDgv.CellClick += userManageDgv_CellClick;
            // 
            // homeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 659);
            Controls.Add(loginScreen);
            Controls.Add(KasirScreen);
            Controls.Add(inventoriScreen);
            Controls.Add(userScreen);
            Controls.Add(historyScreen);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "homeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KasirPBO";
            Load += homeForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ItemsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)transactionDgv).EndInit();
            KasirScreen.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            loginScreen.ResumeLayout(false);
            loginpanel.ResumeLayout(false);
            loginpanel.PerformLayout();
            inventoriScreen.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)productsDataGrid).EndInit();
            historyScreen.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)historyDgv).EndInit();
            userScreen.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)userManageDgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        internal Panel panel2;
        internal Button addProductBtn;
        internal Label title;
        internal Panel panel1;
        internal Label tanggalTitle;
        internal Label tanggalLabel;
        internal Label cashierLabel;
        internal Label cashierTitle;
        internal Label itemPriceLabel;
        internal Label addProductTitle;
        internal Label totalLabel;
        internal Label totalTitle;
        internal Panel ItemsPanel;
        internal Button proccessBtn;
        internal Panel KasirScreen;
        internal Panel loginScreen;
        internal TextBox passwordTxt;
        internal TextBox usernameTxt;
        internal Label titleText;
        internal Button loginBtn;
        internal Label label2;
        internal Label label1;
        internal Button inventoriBtn;
        internal Panel inventoriScreen;
        internal DataGridView productsDataGrid;
        internal Label label3;
        internal TextBox productCodeTxt;
        internal Label label6;
        internal Label label5;
        internal Label label4;
        internal DataGridView transactionDgv;
        internal Button inventoryBackBtn;
        internal TextBox productQuantityTxt;
        internal TextBox productPriceTxt;
        internal TextBox productNameTxt;
        internal Button saveProductBtn;
        internal ComboBox productsCmb;
        internal Button checkPriceBtn;
        internal Button logoutBtn;
        internal Button historyBtn;
        internal Button clearTransactionBtn;
        internal Panel historyScreen;
        internal Button historyBackBtn;
        internal DataGridView historyDgv;
        internal Button reloadHistoryBtn;
        internal Button userManageBtn;
        internal Panel userScreen;
        internal Button userManageSaveBtn;
        internal Button userManageBackBtn;
        internal TextBox userManageNameTxt;
        internal TextBox userManagePasswordTxt;
        internal TextBox userManageUsernameTxt;
        internal Label label7;
        internal Label label8;
        internal Label label9;
        internal Label label10;
        internal DataGridView userManageDgv;
        internal ComboBox userManageLevelCmb;
        internal TextBox buyerMoneyTxt;
        internal Label buyerChangeTxt;
        internal Label label12;
        internal Label label11;
        internal Panel loginpanel;
        internal Label label13;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
    }
}

