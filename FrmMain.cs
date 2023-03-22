namespace WFA230322UFO
{
    using MySql.Data.MySqlClient;

    public partial class FrmMain : Form
    {
        public string? ConnectionString { private get; set; }
        public FrmMain()
        {
            InitializeComponent();
            this.Load += OnFrmMainLoad;
        }

        private void OnFrmMainLoad(object? sender, EventArgs e)
        {
            _ = new FrmBejelentkezes(this).ShowDialog();

            using MySqlConnection conn = new(ConnectionString);
            conn.Open();
            MySqlDataReader reader = new MySqlCommand(
                cmdText: "SELECT ufoid, nev, alapar, serules, lopott FROM " +
                "jarmuvek INNER JOIN tipusok " +
                "ON jarmuvek.tipus = tipusok.tipusid " +
                "ORDER BY ufoid ASC;",
                connection: conn)
                .ExecuteReader();

            while (reader.Read())
            {
                int alapAr = reader.GetInt32(2);
                int serules = reader.GetInt32(3);
                bool lopott = reader.GetBoolean(4);
                float ar = alapAr - (serules * alapAr / 100F);
                if (lopott) ar *= .8F;

                string allapot = serules switch
                {
                    _ when serules <= 25 => "hibátlan",
                    _ when serules <= 50 => "újszerû",
                    _ when serules <= 66 => "megkímélt",
                    _ => "alkatrésznek"
                };

                dgvMain.Rows.Add(reader[1], $"{ar:0} CP", allapot);
            }
        }
    }
}