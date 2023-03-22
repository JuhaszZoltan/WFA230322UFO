namespace WFA230322UFO
{
    partial class FrmMain
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            mnuMain = new MenuStrip();
            tsmiVevok = new ToolStripMenuItem();
            tsmiKereso = new ToolStripMenuItem();
            dgvMain = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            mnuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMain).BeginInit();
            SuspendLayout();
            // 
            // mnuMain
            // 
            mnuMain.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            mnuMain.Items.AddRange(new ToolStripItem[] { tsmiVevok, tsmiKereso });
            mnuMain.Location = new Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Size = new Size(841, 62);
            mnuMain.TabIndex = 0;
            mnuMain.Text = "menuStrip1";
            // 
            // tsmiVevok
            // 
            tsmiVevok.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            tsmiVevok.ForeColor = Color.Red;
            tsmiVevok.Name = "tsmiVevok";
            tsmiVevok.Size = new Size(166, 58);
            tsmiVevok.Text = "VEVŐK";
            // 
            // tsmiKereso
            // 
            tsmiKereso.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            tsmiKereso.ForeColor = Color.Green;
            tsmiKereso.Name = "tsmiKereso";
            tsmiKereso.Size = new Size(181, 58);
            tsmiKereso.Text = "KERESŐ";
            // 
            // dgvMain
            // 
            dgvMain.AllowUserToAddRows = false;
            dgvMain.AllowUserToDeleteRows = false;
            dgvMain.AllowUserToResizeColumns = false;
            dgvMain.AllowUserToResizeRows = false;
            dgvMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMain.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMain.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvMain.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMain.Location = new Point(12, 82);
            dgvMain.Name = "dgvMain";
            dgvMain.RowHeadersVisible = false;
            dgvMain.RowTemplate.Height = 25;
            dgvMain.Size = new Size(817, 437);
            dgvMain.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "típus";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "ár";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "állapot";
            Column3.Name = "Column3";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 531);
            Controls.Add(dgvMain);
            Controls.Add(mnuMain);
            MainMenuStrip = mnuMain;
            Name = "FrmMain";
            Text = "usedUFO.glx kínálata";
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip mnuMain;
        private ToolStripMenuItem tsmiVevok;
        private ToolStripMenuItem tsmiKereso;
        private DataGridView dgvMain;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}