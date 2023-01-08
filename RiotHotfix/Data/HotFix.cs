using System.Diagnostics;
using System.Net;
using System.Text.Json;

namespace RiotHotfix.Data
{
    public class HotFix
    {
        private List<LOLVersion> LOLVersions = new List<LOLVersion>();
        public HotFix() { }

        public object CopyFile(string sourceFile, string destinationFile)
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

        public object DownloadFile(string url, string destinationFile)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(url, destinationFile);
                }
                return new
                {
                    Success = true,
                    Message = "File downloaded"
                };
            }
            catch (Exception ex)
            {
                return new
                {
                    Success = false,
                    Message = ex.Message
                };
            }
        }

        public List<LOLVersion> LoadData(string url)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    string json = client.DownloadString(url);
                    // convert json to object using Text.Json
                    LOLVersions = JsonSerializer.Deserialize<List<LOLVersion>>(json);
                }
                LOLVersions = LOLVersions.OrderByDescending(x => x.UpdateDate).ToList();
                return LOLVersions;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public string GetFileVersion(string file)
        {
            try
            {
                FileVersionInfo myFileVersionInfo = FileVersionInfo.GetVersionInfo(file);
                return myFileVersionInfo.FileVersion;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
