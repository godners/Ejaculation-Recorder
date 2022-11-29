using System.Data;

namespace ER
{
    public partial class WinMain : Form
    {
        /// <summary>
        /// Define Form
        /// </summary>
        public WinMain() => InitializeComponent();

        private void WinMain_Load(object sender, EventArgs e)
        {
            InitiateDatabase.Initiate("RenTY", "Godners8");

        }







        #region Region: Form Status Control
        private void ButtonQuit_Click(object sender, EventArgs e) => Application.Exit();
        private void ButtonMinimum_Click(object sender, EventArgs e) => HideForm();
        private void NotifyIconER_DoubleClick(object sender, EventArgs e) => ShowForm();
        private void HideForm()
        {
            WindowState = FormWindowState.Minimized;
            Visible = false; ShowInTaskbar = false; NotifyIconER.Visible = true;
        }
        private void ShowForm()
        {
            NotifyIconER.Visible = false; ShowInTaskbar = true; Visible = true;
            WindowState= FormWindowState.Normal;
        }
        #endregion

    }

}