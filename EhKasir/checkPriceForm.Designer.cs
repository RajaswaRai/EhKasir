namespace EhKasir
{
    partial class checkPriceForm
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
            label1 = new Label();
            checkPriceTxt = new TextBox();
            checkPriceBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 0;
            label1.Text = "Kode Produk";
            // 
            // checkPriceTxt
            // 
            checkPriceTxt.Location = new Point(112, 35);
            checkPriceTxt.Name = "checkPriceTxt";
            checkPriceTxt.Size = new Size(199, 27);
            checkPriceTxt.TabIndex = 1;
            // 
            // checkPriceBtn
            // 
            checkPriceBtn.Location = new Point(327, 35);
            checkPriceBtn.Name = "checkPriceBtn";
            checkPriceBtn.Size = new Size(146, 29);
            checkPriceBtn.TabIndex = 2;
            checkPriceBtn.Text = "checkPriceBtn";
            checkPriceBtn.UseVisualStyleBackColor = true;
            checkPriceBtn.Click += checkPriceBtn_Click;
            // 
            // checkPriceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 101);
            Controls.Add(checkPriceBtn);
            Controls.Add(checkPriceTxt);
            Controls.Add(label1);
            Name = "checkPriceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "checkPriceForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public TextBox checkPriceTxt;
        private Button checkPriceBtn;
    }
}