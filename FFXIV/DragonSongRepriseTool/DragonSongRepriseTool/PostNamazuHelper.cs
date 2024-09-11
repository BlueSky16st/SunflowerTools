using System.IO;
using System.Net;
using DragonSongRepriseTool.Setting;

namespace DragonSongRepriseTool
{
    public class PostNamazuHelper
    {
        public static PostNamazuHelper PostNamazuHelperInstance;

        public void SendCommand(string command)
        {
            try
            {
                ServicePointManager.DefaultConnectionLimit = 50;

                var request = (HttpWebRequest)WebRequest.Create(ToolSetting.ToolSettingInstance.SettingModel.PostNamazuUrl);
                request.Method = "POST";
                request.Timeout = 100;
                var sendStream = request.GetRequestStream();
                var sw = new StreamWriter(sendStream);
                sw.Write(command);
                sw.Flush();
                sw.Close();
                sendStream.Close();

                var myWebResponse = request.GetResponse();
                myWebResponse.Close();
            }
            catch
            {
            }
        }
    }
}