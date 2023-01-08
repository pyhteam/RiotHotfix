using RiotHotfix.Data;

namespace RiotHotfix
{
    public partial class fmMain : Form
    {
        HotFix hotFix = new HotFix();
        LOLVersion lolVersion = new LOLVersion();
        public fmMain()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            txtFolderGame.Text = "D:\\Riot Games\\League of Legends\\Game";
            // load data from url
            var lolVersions = hotFix.LoadData("https://raw.githubusercontent.com/pyhteam/RiotHotfix/master/data.json");
            lolVersion = lolVersions.FirstOrDefault();
            // set version
            txtStatusBar.Text = "Version: " + lolVersion.Version + " | Date: " + lolVersion.UpdateDate;

        }

        private void btnPacth_Click(object sender, EventArgs e)
        {
            string folderGame = txtFolderGame.Text;
            if (folderGame == "")
            {
                MessageBox.Show("Please select folder of League of Legends", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // download file
            // get path desktop pc
            string pathDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var result = hotFix.DownloadFile(lolVersion.Link, pathDesktop);
            if (result.GetObj("Success") == "true")
            {
                MessageBox.Show(result.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // copy file
            var resultCopy = hotFix.CopyFile(pathDesktop + "\\League of Legends.exe", folderGame + "\\League of Legends.exe");
            var resultCopy2 = hotFix.CopyFile(pathDesktop + "\\stub.dll", folderGame + "\\stub.dll");
            if (resultCopy.GetObj("Success") == "true")
            {
                MessageBox.Show("Pacth success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(resultCopy.GetObj("Message").ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCheckVersion_Click(object sender, EventArgs e)
        {
            // get file version
            string folderGame = txtFolderGame.Text;
            if (folderGame == "")
            {
                MessageBox.Show("Please select folder of League of Legends", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var result = hotFix.GetFileVersion(folderGame + "\\League of Legends.exe");
            MessageBox.Show("Version: " + result, "Your LOL Version", MessageBoxButtons.OK, MessageBoxIcon.Information);
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