namespace Project
{
    partial class ChangePassword
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            chkbox_changepassshow = new CheckBox();
            txtbox_changeusername = new TextBox();
            txtbox_changepass = new TextBox();
            txtbox_changepass1 = new TextBox();
            btn_changepass = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(163, 9);
            label1.Name = "label1";
            label1.Size = new Size(231, 25);
            label1.TabIndex = 0;
            label1.Text = "Şifre Değiştirme Paneli";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 69);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 1;
            label2.Text = "Kullanıcı Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 112);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 2;
            label3.Text = "Şifre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 155);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 3;
            label4.Text = "Tekrar Şifre:";
            // 
            // chkbox_changepassshow
            // 
            chkbox_changepassshow.AutoSize = true;
            chkbox_changepassshow.Location = new Point(369, 158);
            chkbox_changepassshow.Name = "chkbox_changepassshow";
            chkbox_changepassshow.Size = new Size(118, 24);
            chkbox_changepassshow.TabIndex = 4;
            chkbox_changepassshow.Text = "Şifreyi göster";
            chkbox_changepassshow.UseVisualStyleBackColor = true;
            chkbox_changepassshow.CheckedChanged += chkbox_changepassshow_CheckedChanged;
            // 
            // txtbox_changeusername
            // 
            txtbox_changeusername.Location = new Point(217, 69);
            txtbox_changeusername.Name = "txtbox_changeusername";
            txtbox_changeusername.Size = new Size(125, 27);
            txtbox_changeusername.TabIndex = 5;
            // 
            // txtbox_changepass
            // 
            txtbox_changepass.Location = new Point(217, 112);
            txtbox_changepass.Name = "txtbox_changepass";
            txtbox_changepass.PasswordChar = '*';
            txtbox_changepass.Size = new Size(125, 27);
            txtbox_changepass.TabIndex = 6;
            // 
            // txtbox_changepass1
            // 
            txtbox_changepass1.Location = new Point(217, 155);
            txtbox_changepass1.Name = "txtbox_changepass1";
            txtbox_changepass1.PasswordChar = '*';
            txtbox_changepass1.Size = new Size(125, 27);
            txtbox_changepass1.TabIndex = 7;
            // 
            // btn_changepass
            // 
            btn_changepass.Location = new Point(210, 228);
            btn_changepass.Name = "btn_changepass";
            btn_changepass.Size = new Size(132, 29);
            btn_changepass.TabIndex = 8;
            btn_changepass.Text = "Şifre değiştir";
            btn_changepass.UseVisualStyleBackColor = true;
            btn_changepass.Click += btn_changepass_Click;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(534, 288);
            Controls.Add(btn_changepass);
            Controls.Add(txtbox_changepass1);
            Controls.Add(txtbox_changepass);
            Controls.Add(txtbox_changeusername);
            Controls.Add(chkbox_changepassshow);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ChangePassword";
            Text = "ChangePassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox chkbox_changepassshow;
        private TextBox txtbox_changeusername;
        private TextBox txtbox_changepass;
        private TextBox txtbox_changepass1;
        private Button btn_changepass;
    }
}