namespace Project
{
    partial class AdminPanel
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
            dtgridusers = new DataGridView();
            lst_users = new ListBox();
            btn_back = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgridusers).BeginInit();
            SuspendLayout();
            // 
            // dtgridusers
            // 
            dtgridusers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgridusers.Location = new Point(12, 12);
            dtgridusers.Name = "dtgridusers";
            dtgridusers.RowHeadersWidth = 51;
            dtgridusers.Size = new Size(416, 318);
            dtgridusers.TabIndex = 0;
            // 
            // lst_users
            // 
            lst_users.FormattingEnabled = true;
            lst_users.Location = new Point(463, 12);
            lst_users.Name = "lst_users";
            lst_users.Size = new Size(420, 324);
            lst_users.TabIndex = 1;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(12, 393);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(94, 29);
            btn_back.TabIndex = 2;
            btn_back.Text = "Geri Dön";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 450);
            Controls.Add(btn_back);
            Controls.Add(lst_users);
            Controls.Add(dtgridusers);
            Name = "AdminPanel";
            Text = "AdminPanel";
            ((System.ComponentModel.ISupportInitialize)dtgridusers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgridusers;
        private ListBox lst_users;
        private Button btn_back;
    }
}