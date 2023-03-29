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
    public partial class FrmVevok : Form
    {
        public FrmMain MainForm { get; set; }
        public FrmVevok(FrmMain mainForm)
        {
            MainForm = mainForm;
            InitializeComponent();
            this.Load += OnFrmVevokLoad;
            cmbNevek.SelectedIndexChanged += OnCmbNevekSelectedIndexChanged;
        }

        private void OnCmbNevekSelectedIndexChanged(object? sender, EventArgs e)
        {
            rtbFoglalozottJarmuvek.Clear();

            using MySqlConnection conn = new(MainForm.ConnectionString);
            conn.Open();
            MySqlDataReader reader = new MySqlCommand(
                cmdText: "SELECT cim, megbizhato FROM vevok " +
                $"WHERE nev LIKE '{cmbNevek.Text}';",
                connection: conn)
                .ExecuteReader();

            while (reader.Read())
            {
                txtCim.Text = $"{reader[0]}";
                if (reader.GetBoolean(1)) optIgen.Checked = true;
                else optNem.Checked = true;
            }
            reader.Close();

            reader = new MySqlCommand(
                cmdText: "SELECT tipusok.nev, serules " +
                "FROM tipusok " +
                "INNER JOIN jarmuvek ON tipusId = jarmuvek.tipus " +
                "INNER JOIN vevok ON vevoId = jarmuvek.foglalo " +
                $"WHERE vevok.nev LIKE '{cmbNevek.Text}';",
                connection: conn)
                .ExecuteReader();

            while (reader.Read()) rtbFoglalozottJarmuvek
                    .Text += $"{reader[0]} {reader[1]}%\n";
        }

        private void OnFrmVevokLoad(object? sender, EventArgs e)
        {
            using MySqlConnection conn = new(MainForm.ConnectionString); 
            conn.Open();
            MySqlDataReader reader = new MySqlCommand(
                cmdText: "SELECT nev FROM vevok;",
                connection: conn)
                .ExecuteReader();
            while (reader.Read()) cmbNevek.Items.Add(reader[0]);
        }
    }
}
