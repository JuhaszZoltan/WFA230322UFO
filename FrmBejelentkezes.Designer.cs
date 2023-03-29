namespace WFA230322UFO
{
    partial class FrmBejelentkezes
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
            txtUid = new TextBox();
            label2 = new Label();
            txtPwd = new TextBox();
            btnBejelentkezes = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(43, 26);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 99;
            label1.Text = "username:";
            // 
            // txtUid
            // 
            txtUid.Location = new Point(138, 23);
            txtUid.Name = "txtUid";
            txtUid.Size = new Size(182, 29);
            txtUid.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(46, 61);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 99;
            label2.Text = "password:";
            // 
            // txtPwd
            // 
            txtPwd.Location = new Point(138, 58);
            txtPwd.Name = "txtPwd";
            txtPwd.PasswordChar = '*';
            txtPwd.Size = new Size(182, 29);
            txtPwd.TabIndex = 1;
            // 
            // btnBejelentkezes
            // 
            btnBejelentkezes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBejelentkezes.Location = new Point(12, 98);
            btnBejelentkezes.Name = "btnBejelentkezes";
            btnBejelentkezes.Size = new Size(308, 38);
            btnBejelentkezes.TabIndex = 2;
            btnBejelentkezes.Text = "Bejelentkezés";
            btnBejelentkezes.UseVisualStyleBackColor = true;
            // 
            // FrmBejelentkezes
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 148);
            Controls.Add(btnBejelentkezes);
            Controls.Add(txtPwd);
            Controls.Add(txtUid);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FrmBejelentkezes";
            Text = "Bejelentkezés az adatbázis serverre";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUid;
        private Label label2;
        private TextBox txtPwd;
        private Button btnBejelentkezes;
    }
}