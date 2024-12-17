namespace Project
{
    partial class UserPanel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPanel));
            lbl_baslik = new Label();
            lbl_username = new Label();
            lbl_password = new Label();
            txtbox_username = new TextBox();
            txtbox_password = new TextBox();
            chkbox1 = new CheckBox();
            btn_exit = new Button();
            btn_entry = new Button();
            btn_clean = new Button();
            btn_register = new Button();
            lbl_changepass = new Label();
            SuspendLayout();
            // 
            // lbl_baslik
            // 
            lbl_baslik.AutoSize = true;
            lbl_baslik.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbl_baslik.Location = new Point(216, 9);
            lbl_baslik.Name = "lbl_baslik";
            lbl_baslik.Size = new Size(156, 25);
            lbl_baslik.TabIndex = 0;
            lbl_baslik.Text = "HOŞGELDİNİZ";
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lbl_username.Location = new Point(27, 89);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(125, 25);
            lbl_username.TabIndex = 1;
            lbl_username.Text = "Kullanıcı Adı:";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lbl_password.Location = new Point(27, 155);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(58, 25);
            lbl_password.TabIndex = 2;
            lbl_password.Text = "Şifre:";
            // 
            // txtbox_username
            // 
            txtbox_username.Location = new Point(231, 90);
            txtbox_username.Name = "txtbox_username";
            txtbox_username.Size = new Size(125, 27);
            txtbox_username.TabIndex = 3;
            // 
            // txtbox_password
            // 
            txtbox_password.Location = new Point(231, 153);
            txtbox_password.Name = "txtbox_password";
            txtbox_password.PasswordChar = '*';
            txtbox_password.Size = new Size(125, 27);
            txtbox_password.TabIndex = 4;
            // 
            // chkbox1
            // 
            chkbox1.AutoSize = true;
            chkbox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            chkbox1.Location = new Point(393, 155);
            chkbox1.Name = "chkbox1";
            chkbox1.Size = new Size(116, 22);
            chkbox1.TabIndex = 5;
            chkbox1.Text = "Şifreyi göster";
            chkbox1.UseVisualStyleBackColor = true;
            chkbox1.CheckedChanged += chkbox1_CheckedChanged;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.Red;
            btn_exit.FlatStyle = FlatStyle.Popup;
            btn_exit.Location = new Point(124, 240);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(94, 29);
            btn_exit.TabIndex = 6;
            btn_exit.Text = "Çıkış";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // btn_entry
            // 
            btn_entry.BackColor = Color.Lime;
            btn_entry.FlatStyle = FlatStyle.Popup;
            btn_entry.Location = new Point(241, 240);
            btn_entry.Name = "btn_entry";
            btn_entry.Size = new Size(94, 29);
            btn_entry.TabIndex = 7;
            btn_entry.Text = "Giriş";
            btn_entry.UseVisualStyleBackColor = false;
            btn_entry.Click += btn_entry_Click;
            // 
            // btn_clean
            // 
            btn_clean.BackColor = Color.Yellow;
            btn_clean.FlatStyle = FlatStyle.Popup;
            btn_clean.Location = new Point(355, 240);
            btn_clean.Name = "btn_clean";
            btn_clean.Size = new Size(94, 29);
            btn_clean.TabIndex = 8;
            btn_clean.Text = "Temizle";
            btn_clean.UseVisualStyleBackColor = false;
            btn_clean.Click += btn_clean_Click;
            // 
            // btn_register
            // 
            btn_register.BackColor = Color.Cyan;
            btn_register.FlatStyle = FlatStyle.Popup;
            btn_register.Location = new Point(12, 356);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(94, 29);
            btn_register.TabIndex = 9;
            btn_register.Text = "Kayıt Ol";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // lbl_changepass
            // 
            lbl_changepass.AutoSize = true;
            lbl_changepass.ForeColor = Color.Blue;
            lbl_changepass.Location = new Point(232, 197);
            lbl_changepass.Name = "lbl_changepass";
            lbl_changepass.Size = new Size(115, 20);
            lbl_changepass.TabIndex = 10;
            lbl_changepass.Text = "Şifremi unuttum";
            lbl_changepass.Click += lbl_changepass_Click;
            // 
            // UserPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(611, 406);
            Controls.Add(lbl_changepass);
            Controls.Add(btn_register);
            Controls.Add(btn_clean);
            Controls.Add(btn_entry);
            Controls.Add(btn_exit);
            Controls.Add(chkbox1);
            Controls.Add(txtbox_password);
            Controls.Add(txtbox_username);
            Controls.Add(lbl_password);
            Controls.Add(lbl_username);
            Controls.Add(lbl_baslik);
            Name = "UserPanel";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_baslik;
        private Label lbl_username;
        private Label lbl_password;
        private TextBox txtbox_username;
        private TextBox txtbox_password;
        private CheckBox chkbox1;
        private Button btn_exit;
        private Button btn_entry;
        private Button btn_clean;
        private Button btn_register;
        private Label lbl_changepass;
    }
}
