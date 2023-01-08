using Newtonsoft.Json;
using System.Net;

namespace RiotHotfix.Data
{
    public class HotFix
    {
        private List<LOLVersion> LOLVersions = new List<LOLVersion>();
        public HotFix() { }

        public string CopyFile(string sourceFile, string destinationFile)
        {
            try
            {
                File.Copy(sourceFile, destinationFile, true);
                return "File copied";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string DeleteFile(string file)
        {
            try
            {
                if (File.Exists(file))
                {
                    File.Delete(file);
                    return "File deleted";
                }
                return "File not found";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string DownloadFile(string url, string destinationFile)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(url, destinationFile);
                }
                return "File downloaded";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<LOLVersion> LoadData(string url)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    string json = client.DownloadString(url);
                    LOLVersions = JsonConvert.DeserializeObject<List<LOLVersion>>(json);
                }
                LOLVersions = LOLVersions.OrderByDescending(x => x.UpdateDate).ToList();
                return LOLVersions;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
