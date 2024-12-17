namespace Project
{
    partial class Register
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
            lbl_info = new Label();
            lbl_registerusername = new Label();
            lbl_registerpass = new Label();
            lbl_registerpass2 = new Label();
            txtbox_registerusername = new TextBox();
            txtbox_registerpass = new TextBox();
            txtbox_registerpass1 = new TextBox();
            btn_register = new Button();
            chkbox_registerpassshow = new CheckBox();
            SuspendLayout();
            // 
            // lbl_info
            // 
            lbl_info.AutoSize = true;
            lbl_info.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbl_info.Location = new Point(118, 9);
            lbl_info.Name = "lbl_info";
            lbl_info.Size = new Size(232, 25);
            lbl_info.TabIndex = 0;
            lbl_info.Text = "Kayıt Oluşturma Paneli";
            // 
            // lbl_registerusername
            // 
            lbl_registerusername.AutoSize = true;
            lbl_registerusername.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lbl_registerusername.Location = new Point(60, 78);
            lbl_registerusername.Name = "lbl_registerusername";
            lbl_registerusername.Size = new Size(113, 22);
            lbl_registerusername.TabIndex = 1;
            lbl_registerusername.Text = "Kullanıcı Adı:";
            // 
            // lbl_registerpass
            // 
            lbl_registerpass.AutoSize = true;
            lbl_registerpass.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lbl_registerpass.Location = new Point(60, 126);
            lbl_registerpass.Name = "lbl_registerpass";
            lbl_registerpass.Size = new Size(52, 22);
            lbl_registerpass.TabIndex = 2;
            lbl_registerpass.Text = "Şifre:";
            // 
            // lbl_registerpass2
            // 
            lbl_registerpass2.AutoSize = true;
            lbl_registerpass2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lbl_registerpass2.Location = new Point(60, 173);
            lbl_registerpass2.Name = "lbl_registerpass2";
            lbl_registerpass2.Size = new Size(110, 22);
            lbl_registerpass2.TabIndex = 3;
            lbl_registerpass2.Text = "Tekrar Şifre:";
            // 
            // txtbox_registerusername
            // 
            txtbox_registerusername.Location = new Point(199, 78);
            txtbox_registerusername.Name = "txtbox_registerusername";
            txtbox_registerusername.Size = new Size(203, 27);
            txtbox_registerusername.TabIndex = 4;
            // 
            // txtbox_registerpass
            // 
            txtbox_registerpass.Location = new Point(199, 126);
            txtbox_registerpass.Name = "txtbox_registerpass";
            txtbox_registerpass.PasswordChar = '*';
            txtbox_registerpass.Size = new Size(203, 27);
            txtbox_registerpass.TabIndex = 5;
            // 
            // txtbox_registerpass1
            // 
            txtbox_registerpass1.Location = new Point(199, 172);
            txtbox_registerpass1.Name = "txtbox_registerpass1";
            txtbox_registerpass1.PasswordChar = '*';
            txtbox_registerpass1.Size = new Size(203, 27);
            txtbox_registerpass1.TabIndex = 6;
            // 
            // btn_register
            // 
            btn_register.BackColor = Color.Lime;
            btn_register.FlatStyle = FlatStyle.Popup;
            btn_register.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btn_register.Location = new Point(256, 250);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(94, 29);
            btn_register.TabIndex = 7;
            btn_register.Text = "Kayıt Ol";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // chkbox_registerpassshow
            // 
            chkbox_registerpassshow.AutoSize = true;
            chkbox_registerpassshow.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            chkbox_registerpassshow.Location = new Point(234, 205);
            chkbox_registerpassshow.Name = "chkbox_registerpassshow";
            chkbox_registerpassshow.Size = new Size(137, 26);
            chkbox_registerpassshow.TabIndex = 8;
            chkbox_registerpassshow.Text = "Şifreyi göster";
            chkbox_registerpassshow.UseVisualStyleBackColor = true;
            chkbox_registerpassshow.Click += chkbox_registerpassshow_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(526, 317);
            Controls.Add(chkbox_registerpassshow);
            Controls.Add(btn_register);
            Controls.Add(txtbox_registerpass1);
            Controls.Add(txtbox_registerpass);
            Controls.Add(txtbox_registerusername);
            Controls.Add(lbl_registerpass2);
            Controls.Add(lbl_registerpass);
            Controls.Add(lbl_registerusername);
            Controls.Add(lbl_info);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_info;
        private Label lbl_registerusername;
        private Label lbl_registerpass;
        private Label lbl_registerpass2;
        private TextBox txtbox_registerusername;
        private TextBox txtbox_registerpass;
        private TextBox txtbox_registerpass1;
        private Button btn_register;
        private CheckBox chkbox_registerpassshow;
    }
}