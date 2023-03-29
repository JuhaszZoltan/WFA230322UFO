using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA230322UFO
{
    public partial class FrmKereso : Form
    {
        public FrmMain FrmMain { get; set; }
        public FrmKereso(FrmMain frmMain)
        {
            FrmMain = frmMain;
            InitializeComponent();
            this.Load += OnKeresesiFeltetelValtozas;
            txtTipusNev.TextChanged += OnKeresesiFeltetelValtozas;
            txtVevoNev.TextChanged += OnKeresesiFeltetelValtozas;
        }

        private void OnKeresesiFeltetelValtozas(object? sender, EventArgs e)
        {
            dgvKereso.Rows.Clear();

            using MySqlConnection conn = new(FrmMain.ConnectionString);
            conn.Open();

            MySqlDataReader reader = new MySqlCommand(
                cmdText: "SELECT tipusok.nev, vevok.nev " +
                "FROM tipusok " +
                "INNER JOIN jarmuvek ON tipusId = jarmuvek.tipus " +
                "INNER JOIN vevok ON vevoId = jarmuvek.foglalo " +
                $"WHERE vevok.nev LIKE '{txtVevoNev.Text}%' " +
                $"AND tipusok.nev LIKE '{txtTipusNev.Text}%';",
                connection: conn)
                .ExecuteReader();

            while (reader.Read()) dgvKereso.Rows.Add(reader[0], reader[1]);

        }
    }
}
