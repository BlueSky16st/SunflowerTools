using System;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace DragonSongRepriseTool.Setting
{
    public class ToolSetting
    {
        public static readonly ToolSetting ToolSettingInstance = new ToolSetting();

        public SettingModel SettingModel { get; private set; }

        public void LoadSetting(string path)
        {
            if (!File.Exists(path))
            {
                SettingModel = SettingModel.GetInitData();
            }
            else
            {
                try
                {
                    var data = File.ReadAllText(path);
                    SettingModel = JsonConvert.DeserializeObject<SettingModel>(data);

                    if (SettingModel.PartySetting.PlayerInfos.Count != 8)
                    {
                        SettingModel = SettingModel.GetInitData();
                    }
                }
                catch
                {
                    SettingModel = SettingModel.GetInitData();
                }
            }
        }

        public void SaveSetting(string path)
        {
            File.WriteAllText(path, SettingModel.ToJson());
        }
    }
}