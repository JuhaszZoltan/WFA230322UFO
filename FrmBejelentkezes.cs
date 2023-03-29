namespace WFA230322UFO
{
    public partial class FrmBejelentkezes : Form
    {
        public FrmMain FrmMain { get; set; }
        public FrmBejelentkezes(FrmMain frmMain)
        {
            this.FrmMain = frmMain;
            InitializeComponent();
            txtUid.Text = "diak171";
            txtPwd.Text = "ZDGE0W";

            btnBejelentkezes.Click += OnBtnBejelentkezesClick;
        }

        private void OnBtnBejelentkezesClick(object? sender, EventArgs e)
        {
            FrmMain.ConnectionString =
                "Server=172.16.1.241;" +
                $"Database={txtUid.Text};" +
                $"Uid={txtUid.Text};" +
                $"Pwd={txtPwd.Text};";
            this.Dispose();
        }
    }
}
