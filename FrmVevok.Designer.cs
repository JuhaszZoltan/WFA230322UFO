namespace WFA230322UFO
{
    partial class FrmVevok
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
            cmbNevek = new ComboBox();
            lblUI01 = new Label();
            grbMegbizhatosag = new GroupBox();
            optIgen = new RadioButton();
            optNem = new RadioButton();
            rtbFoglalozottJarmuvek = new RichTextBox();
            txtCim = new TextBox();
            lblUI02 = new Label();
            grbMegbizhatosag.SuspendLayout();
            SuspendLayout();
            // 
            // cmbNevek
            // 
            cmbNevek.FormattingEnabled = true;
            cmbNevek.Location = new Point(12, 24);
            cmbNevek.Name = "cmbNevek";
            cmbNevek.Size = new Size(260, 29);
            cmbNevek.TabIndex = 0;
            cmbNevek.Text = "vevő nevének kiválasztása...";
            // 
            // lblUI01
            // 
            lblUI01.AutoSize = true;
            lblUI01.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUI01.Location = new Point(12, 84);
            lblUI01.Name = "lblUI01";
            lblUI01.Size = new Size(44, 21);
            lblUI01.TabIndex = 1;
            lblUI01.Text = "Cím:";
            // 
            // grbMegbizhatosag
            // 
            grbMegbizhatosag.Controls.Add(optNem);
            grbMegbizhatosag.Controls.Add(optIgen);
            grbMegbizhatosag.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grbMegbizhatosag.Location = new Point(12, 134);
            grbMegbizhatosag.Name = "grbMegbizhatosag";
            grbMegbizhatosag.Size = new Size(260, 89);
            grbMegbizhatosag.TabIndex = 2;
            grbMegbizhatosag.TabStop = false;
            grbMegbizhatosag.Text = "Megbízható?";
            // 
            // optIgen
            // 
            optIgen.AutoSize = true;
            optIgen.Checked = true;
            optIgen.Location = new Point(38, 38);
            optIgen.Name = "optIgen";
            optIgen.Size = new Size(66, 25);
            optIgen.TabIndex = 0;
            optIgen.TabStop = true;
            optIgen.Text = "IGEN";
            optIgen.UseVisualStyleBackColor = true;
            // 
            // optNem
            // 
            optNem.AutoSize = true;
            optNem.Location = new Point(150, 38);
            optNem.Name = "optNem";
            optNem.Size = new Size(65, 25);
            optNem.TabIndex = 1;
            optNem.Text = "NEM";
            optNem.UseVisualStyleBackColor = true;
            // 
            // rtbFoglalozottJarmuvek
            // 
            rtbFoglalozottJarmuvek.Location = new Point(12, 282);
            rtbFoglalozottJarmuvek.Name = "rtbFoglalozottJarmuvek";
            rtbFoglalozottJarmuvek.Size = new Size(260, 167);
            rtbFoglalozottJarmuvek.TabIndex = 3;
            rtbFoglalozottJarmuvek.Text = "";
            // 
            // txtCim
            // 
            txtCim.Location = new Point(62, 81);
            txtCim.Name = "txtCim";
            txtCim.Size = new Size(210, 29);
            txtCim.TabIndex = 4;
            // 
            // lblUI02
            // 
            lblUI02.AutoSize = true;
            lblUI02.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUI02.Location = new Point(12, 244);
            lblUI02.Name = "lblUI02";
            lblUI02.Size = new Size(193, 21);
            lblUI02.TabIndex = 1;
            lblUI02.Text = "Lefoglalózott járművek:";
            // 
            // FrmVevok
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 461);
            Controls.Add(txtCim);
            Controls.Add(rtbFoglalozottJarmuvek);
            Controls.Add(grbMegbizhatosag);
            Controls.Add(lblUI02);
            Controls.Add(lblUI01);
            Controls.Add(cmbNevek);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FrmVevok";
            Text = "Vevők adatai";
            grbMegbizhatosag.ResumeLayout(false);
            grbMegbizhatosag.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbNevek;
        private Label lblUI01;
        private GroupBox grbMegbizhatosag;
        private RadioButton optNem;
        private RadioButton optIgen;
        private RichTextBox rtbFoglalozottJarmuvek;
        private TextBox txtCim;
        private Label lblUI02;
    }
}