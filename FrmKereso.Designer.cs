namespace WFA230322UFO
{
    partial class FrmKereso
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            grbUI01 = new GroupBox();
            grbUI02 = new GroupBox();
            txtTipusNev = new TextBox();
            txtVevoNev = new TextBox();
            dgvKereso = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            grbUI01.SuspendLayout();
            grbUI02.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKereso).BeginInit();
            SuspendLayout();
            // 
            // grbUI01
            // 
            grbUI01.Controls.Add(txtTipusNev);
            grbUI01.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grbUI01.Location = new Point(12, 12);
            grbUI01.Name = "grbUI01";
            grbUI01.Size = new Size(337, 100);
            grbUI01.TabIndex = 0;
            grbUI01.TabStop = false;
            grbUI01.Text = "keresés jármű típusa alapján";
            // 
            // grbUI02
            // 
            grbUI02.Controls.Add(txtVevoNev);
            grbUI02.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grbUI02.Location = new Point(380, 12);
            grbUI02.Name = "grbUI02";
            grbUI02.Size = new Size(337, 100);
            grbUI02.TabIndex = 0;
            grbUI02.TabStop = false;
            grbUI02.Text = "keresés vevő neve alapján";
            // 
            // txtTipusNev
            // 
            txtTipusNev.Location = new Point(27, 42);
            txtTipusNev.Name = "txtTipusNev";
            txtTipusNev.Size = new Size(285, 29);
            txtTipusNev.TabIndex = 0;
            // 
            // txtVevoNev
            // 
            txtVevoNev.Location = new Point(25, 42);
            txtVevoNev.Name = "txtVevoNev";
            txtVevoNev.Size = new Size(285, 29);
            txtVevoNev.TabIndex = 0;
            // 
            // dgvKereso
            // 
            dgvKereso.AllowUserToAddRows = false;
            dgvKereso.AllowUserToDeleteRows = false;
            dgvKereso.AllowUserToResizeColumns = false;
            dgvKereso.AllowUserToResizeRows = false;
            dgvKereso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKereso.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvKereso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKereso.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvKereso.DefaultCellStyle = dataGridViewCellStyle2;
            dgvKereso.Location = new Point(12, 118);
            dgvKereso.Name = "dgvKereso";
            dgvKereso.RowHeadersVisible = false;
            dgvKereso.RowTemplate.Height = 25;
            dgvKereso.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKereso.Size = new Size(705, 231);
            dgvKereso.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "jármű típusa";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "foglalózó neve";
            Column2.Name = "Column2";
            // 
            // FrmKereso
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 361);
            Controls.Add(dgvKereso);
            Controls.Add(grbUI02);
            Controls.Add(grbUI01);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FrmKereso";
            Text = "keresés az adatbázisban";
            grbUI01.ResumeLayout(false);
            grbUI01.PerformLayout();
            grbUI02.ResumeLayout(false);
            grbUI02.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKereso).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbUI01;
        private TextBox txtTipusNev;
        private GroupBox grbUI02;
        private TextBox txtVevoNev;
        private DataGridView dgvKereso;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}