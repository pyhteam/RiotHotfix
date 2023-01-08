using System.Diagnostics;
using System.Net;
using System.Text.Json;

namespace RiotHotfix.Data
{
    public class HotFix
    {
        private List<LOLVersion> LOLVersions = new List<LOLVersion>();
        public HotFix() { }

        public Response CopyFile(string sourceFile, string destinationFile)
        {
            try
            {
                File.Copy(sourceFile, destinationFile, true);
                return new Response()
                {
                    Success = true,
                    Messages = "Copy file success"
                };
            }
            catch (Exception ex)
            {
                return new Response()
                {
                    Success = false,
                    Messages = ex.Message
                };
            }
        }
        public Response DeleteFile(string file)
        {
            try
            {
                if (File.Exists(file))
                {
                    File.Delete(file);
                    return new Response()
                    {
                        Success = true,
                        Messages = "Delete file success"
                    };
                }
                return new Response()
                {
                    Success = false,
                    Messages = "File not found"
                };
            }
            catch (Exception ex)
            {
                return new Response()
                {
                    Success = false,
                    Messages = ex.Message
                };
            }
        }

        public Response DownloadFile(string url, string destinationFile, string folderName)
        {
            //check exist folder

            if (!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);
            }
            try
            {
                // download 
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(url, destinationFile);
                }

                return new Response()
                {
                    Success = true,
                    Messages = "Download file success"
                };
            }
            catch (Exception ex)
            {
                return new Response()
                {
                    Success = false,
                    Messages = ex.Message
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
        public bool CheckExistFile(string file, string? version = null)
        {
            try
            {
                if (version != null)
                {

                    if (File.Exists(file) && GetFileVersion(file) == version)
                    {
                        return true;
                    }
                }
                else
                {
                    if (File.Exists(file))
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
