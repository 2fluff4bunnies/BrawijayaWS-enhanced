namespace BrawijayaWorkshop.CryptoWin32App
{
    partial class MainForm
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
            this.tbcCryptoPages = new System.Windows.Forms.TabControl();
            this.tpEncryptPage = new System.Windows.Forms.TabPage();
            this.tpDecryptPage = new System.Windows.Forms.TabPage();
            this.lblPlainText = new System.Windows.Forms.Label();
            this.txtPlainText = new System.Windows.Forms.TextBox();
            this.lblEncryptResult = new System.Windows.Forms.Label();
            this.txtEncryptResult = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txtPlainTextResult = new System.Windows.Forms.TextBox();
            this.lblDecryptedResult = new System.Windows.Forms.Label();
            this.txtEncryptedText = new System.Windows.Forms.TextBox();
            this.lblEncryptedText = new System.Windows.Forms.Label();
            this.tbcCryptoPages.SuspendLayout();
            this.tpEncryptPage.SuspendLayout();
            this.tpDecryptPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcCryptoPages
            // 
            this.tbcCryptoPages.Controls.Add(this.tpEncryptPage);
            this.tbcCryptoPages.Controls.Add(this.tpDecryptPage);
            this.tbcCryptoPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcCryptoPages.Location = new System.Drawing.Point(5, 5);
            this.tbcCryptoPages.Name = "tbcCryptoPages";
            this.tbcCryptoPages.SelectedIndex = 0;
            this.tbcCryptoPages.Size = new System.Drawing.Size(493, 126);
            this.tbcCryptoPages.TabIndex = 0;
            // 
            // tpEncryptPage
            // 
            this.tpEncryptPage.Controls.Add(this.btnEncrypt);
            this.tpEncryptPage.Controls.Add(this.txtEncryptResult);
            this.tpEncryptPage.Controls.Add(this.lblEncryptResult);
            this.tpEncryptPage.Controls.Add(this.txtPlainText);
            this.tpEncryptPage.Controls.Add(this.lblPlainText);
            this.tpEncryptPage.Location = new System.Drawing.Point(4, 22);
            this.tpEncryptPage.Name = "tpEncryptPage";
            this.tpEncryptPage.Padding = new System.Windows.Forms.Padding(3);
            this.tpEncryptPage.Size = new System.Drawing.Size(485, 100);
            this.tpEncryptPage.TabIndex = 0;
            this.tpEncryptPage.Text = "Encryption";
            this.tpEncryptPage.UseVisualStyleBackColor = true;
            // 
            // tpDecryptPage
            // 
            this.tpDecryptPage.Controls.Add(this.btnDecrypt);
            this.tpDecryptPage.Controls.Add(this.txtPlainTextResult);
            this.tpDecryptPage.Controls.Add(this.lblDecryptedResult);
            this.tpDecryptPage.Controls.Add(this.txtEncryptedText);
            this.tpDecryptPage.Controls.Add(this.lblEncryptedText);
            this.tpDecryptPage.Location = new System.Drawing.Point(4, 22);
            this.tpDecryptPage.Name = "tpDecryptPage";
            this.tpDecryptPage.Padding = new System.Windows.Forms.Padding(3);
            this.tpDecryptPage.Size = new System.Drawing.Size(485, 100);
            this.tpDecryptPage.TabIndex = 1;
            this.tpDecryptPage.Text = "Decryption";
            this.tpDecryptPage.UseVisualStyleBackColor = true;
            // 
            // lblPlainText
            // 
            this.lblPlainText.AutoSize = true;
            this.lblPlainText.Location = new System.Drawing.Point(6, 10);
            this.lblPlainText.Name = "lblPlainText";
            this.lblPlainText.Size = new System.Drawing.Size(54, 13);
            this.lblPlainText.TabIndex = 0;
            this.lblPlainText.Text = "Plain Text";
            // 
            // txtPlainText
            // 
            this.txtPlainText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlainText.Location = new System.Drawing.Point(78, 7);
            this.txtPlainText.Name = "txtPlainText";
            this.txtPlainText.Size = new System.Drawing.Size(401, 20);
            this.txtPlainText.TabIndex = 1;
            // 
            // lblEncryptResult
            // 
            this.lblEncryptResult.AutoSize = true;
            this.lblEncryptResult.Location = new System.Drawing.Point(6, 47);
            this.lblEncryptResult.Name = "lblEncryptResult";
            this.lblEncryptResult.Size = new System.Drawing.Size(37, 13);
            this.lblEncryptResult.TabIndex = 2;
            this.lblEncryptResult.Text = "Result";
            // 
            // txtEncryptResult
            // 
            this.txtEncryptResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEncryptResult.Location = new System.Drawing.Point(78, 44);
            this.txtEncryptResult.Name = "txtEncryptResult";
            this.txtEncryptResult.Size = new System.Drawing.Size(401, 20);
            this.txtEncryptResult.TabIndex = 3;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEncrypt.Location = new System.Drawing.Point(404, 71);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 4;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecrypt.Location = new System.Drawing.Point(404, 71);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 9;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // txtPlainTextResult
            // 
            this.txtPlainTextResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlainTextResult.Location = new System.Drawing.Point(104, 44);
            this.txtPlainTextResult.Name = "txtPlainTextResult";
            this.txtPlainTextResult.Size = new System.Drawing.Size(375, 20);
            this.txtPlainTextResult.TabIndex = 8;
            // 
            // lblDecryptedResult
            // 
            this.lblDecryptedResult.AutoSize = true;
            this.lblDecryptedResult.Location = new System.Drawing.Point(6, 47);
            this.lblDecryptedResult.Name = "lblDecryptedResult";
            this.lblDecryptedResult.Size = new System.Drawing.Size(37, 13);
            this.lblDecryptedResult.TabIndex = 7;
            this.lblDecryptedResult.Text = "Result";
            // 
            // txtEncryptedText
            // 
            this.txtEncryptedText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEncryptedText.Location = new System.Drawing.Point(104, 7);
            this.txtEncryptedText.Name = "txtEncryptedText";
            this.txtEncryptedText.Size = new System.Drawing.Size(375, 20);
            this.txtEncryptedText.TabIndex = 6;
            // 
            // lblEncryptedText
            // 
            this.lblEncryptedText.AutoSize = true;
            this.lblEncryptedText.Location = new System.Drawing.Point(6, 10);
            this.lblEncryptedText.Name = "lblEncryptedText";
            this.lblEncryptedText.Size = new System.Drawing.Size(79, 13);
            this.lblEncryptedText.TabIndex = 5;
            this.lblEncryptedText.Text = "Encrypted Text";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 136);
            this.Controls.Add(this.tbcCryptoPages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crypto Tool";
            this.tbcCryptoPages.ResumeLayout(false);
            this.tpEncryptPage.ResumeLayout(false);
            this.tpEncryptPage.PerformLayout();
            this.tpDecryptPage.ResumeLayout(false);
            this.tpDecryptPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcCryptoPages;
        private System.Windows.Forms.TabPage tpEncryptPage;
        private System.Windows.Forms.TabPage tpDecryptPage;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox txtEncryptResult;
        private System.Windows.Forms.Label lblEncryptResult;
        private System.Windows.Forms.TextBox txtPlainText;
        private System.Windows.Forms.Label lblPlainText;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox txtPlainTextResult;
        private System.Windows.Forms.Label lblDecryptedResult;
        private System.Windows.Forms.TextBox txtEncryptedText;
        private System.Windows.Forms.Label lblEncryptedText;
    }
}

