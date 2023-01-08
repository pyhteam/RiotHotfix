using RiotHotfix.Data;

namespace RiotHotfix
{
    public partial class fmMain : Form
    {
        HotFix hotFix = new HotFix();
        LOLVersion lolVersion = new LOLVersion();
        string srcPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\HotfixLOL";
        public fmMain()
        {
            InitializeComponent();
            btnPacth.Enabled = false;
            LoadData();

        }

        private void LoadData()
        {
            txtFolderGame.Text = "D:\\Riot Games\\League of Legends\\Game";
            // load data from url
            var lolVersions = hotFix.LoadData("https://raw.githubusercontent.com/pyhteam/RiotHotfix/master/DataHotfix/data.json");
            lolVersion = lolVersions.FirstOrDefault();
            // set version
            txtStatusBar.Text = "Version: " + lolVersion.Version + " | Date: " + DateTime.Now;

            // check exist file
            var exist = hotFix.CheckExistFile(srcPath + "\\League of Legends.exe", lolVersion.Version);
            var exist2 = hotFix.CheckExistFile(srcPath + "\\stub.dll", lolVersion.Version);
            if (!exist && !exist2)
            {
                btnCheckVersion.Text = "Downloading...";
                btnCheckVersion.Enabled = false;
                btnCheckVersion.BackColor = Color.Gray;
                // download file
                var result = hotFix.DownloadFile(lolVersion.Link, srcPath + "\\League of Legends.exe", "HotfixLOL");
                var result2 = hotFix.DownloadFile(lolVersion.Link2, srcPath + "\\stub.dll", "HotfixLOL");
                // sleep 3s
                Thread.Sleep(3000);
                btnCheckVersion.Text = "Check Version";
                btnCheckVersion.Enabled = true;
                btnPacth.Enabled = true;
                if (result.Success && result2.Success)
                {
                    MessageBox.Show(result.Messages, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(result.Messages, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            btnCheckVersion.Enabled = true;
            btnPacth.Enabled = true;

        }

        private void btnPacth_Click(object sender, EventArgs e)
        {
            string folderGame = txtFolderGame.Text;
            if (folderGame == "")
            {
                MessageBox.Show("Please select folder of League of Legends", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // copy file
            btnPacth.Text = "Patching...";
            btnPacth.Enabled = false;
            btnPacth.BackColor = Color.Gray;
            //check exist file
            var exist = hotFix.CheckExistFile(srcPath + "\\League of Legends.exe", lolVersion.Version);
            var exist2 = hotFix.CheckExistFile(srcPath + "\\stub.dll");
            if (!exist || !exist2)
            {
                MessageBox.Show("Bạn chưa update data! vui lòng Ấn tải hotfix", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnPacth.Text = "Pacth";
                btnPacth.Enabled = true;
                return;
            }
            var resultCopy = hotFix.CopyFile(srcPath + "\\League of Legends.exe", folderGame + "\\League of Legends.exe");
            var resultCopy2 = hotFix.CopyFile(srcPath + "\\stub.dll", folderGame + "\\stub.dll");
            // sleep 3s
            Thread.Sleep(3000);
            btnPacth.Text = "Pacth";
            btnPacth.Enabled = true;

            if (resultCopy.Success && resultCopy2.Success)
            {
                MessageBox.Show(resultCopy.Messages, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(resultCopy.Messages, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // equal version
            if (lolVersion.Version == result)
            {
                MessageBox.Show("Bạn đã cài hotfix", "Your LOL Version", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("LOL của bạn chưa cài hotfix", "Your LOL Version", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // aske user if he want to update
                var result2 = MessageBox.Show("Bạn có muốn cài hotfix không?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result2 == DialogResult.Yes)
                {
                    btnPacth_Click(sender, e);
                }
            }
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

        private void btnDownloadHotfix_Click(object sender, EventArgs e)
        {
            // load data from url
            var lolVersions = hotFix.LoadData("https://raw.githubusercontent.com/pyhteam/RiotHotfix/master/DataHotfix/data.json");
            lolVersion = lolVersions.FirstOrDefault();
            // set version
            txtStatusBar.Text = "Version: " + lolVersion.Version + " | Date: " + lolVersion.UpdateDate;

            // check exist file
            var exist = hotFix.CheckExistFile(srcPath + "\\League of Legends.exe", lolVersion.Version);
            var exist2 = hotFix.CheckExistFile(srcPath + "\\stub.dll");
            if (!exist || !exist2)
            {
                btnDownloadHotfix.Text = " Downloading...";
                btnDownloadHotfix.Width = 150;
                btnPacth.Enabled = false;
                // download file
                var result = hotFix.DownloadFile(lolVersion.Link, srcPath + "\\League of Legends.exe", "HotfixLOL");
                var result2 = hotFix.DownloadFile(lolVersion.Link2, srcPath + "\\stub.dll", "HotfixLOL");
                // sleep 3s
                Thread.Sleep(3000);
                btnDownloadHotfix.Text = "Update";
                btnCheckVersion.Enabled = true;
                btnPacth.Enabled = true;
                btnDownloadHotfix.Width = 45;
                if (result.Success && result2.Success)
                {
                    MessageBox.Show(result.Messages, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(result.Messages, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            btnCheckVersion.Enabled = true;
            btnPacth.Enabled = true;
        }
    }
}