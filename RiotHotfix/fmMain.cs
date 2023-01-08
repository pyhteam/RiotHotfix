using RiotHotfix.Data;

namespace RiotHotfix
{
    public partial class fmMain : Form
    {
        HotFix HotFix = new HotFix();
        LOLVersion LOLVersion = new LOLVersion();
        public fmMain()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            txtFolderGame.Text = "D:\\Riot Games\\League of Legends\\Game";
            // load data from url
            var LOLVersions = HotFix.LoadData("https://drive.google.com/file/d/1b2kOWFM_eocjV4f1pFZmnSxhMp7v0_A0/view?usp=sharing");
            LOLVersion = LOLVersions.FirstOrDefault();
            // set version
            txtStatusBar.Text = "Version: " + LOLVersion.Version;

        }

        private void btnPacth_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckVersion_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // aske user if he want to exit
            var result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtFolderGame_Click(object sender, EventArgs e)
        {
            var result = new FolderBrowserDialog();
            // change design of folder browser dialog
            result.Description = "Select folder of League of Legends";
            result.ShowNewFolderButton = false;
            result.RootFolder = Environment.SpecialFolder.MyComputer;
            if (result.ShowDialog() == DialogResult.OK)
            {
                txtFolderGame.Text = result.SelectedPath;
            }
        }
    }
}