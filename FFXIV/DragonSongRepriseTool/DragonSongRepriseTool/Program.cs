using System.IO;
using System.Windows.Forms;
using Advanced_Combat_Tracker;
using DragonSongRepriseTool.Setting;
using DragonSongRepriseTool.Window;

namespace DragonSongRepriseTool
{
    public class DragonSongRepriseTool : IActPluginV1
    {
        private LogReader _logReader;
        private SettingForm _settingForm;
        private PhaseHandler _phaseHandler;
        private readonly ToolSetting _toolSetting = ToolSetting.ToolSettingInstance;

        public void InitPlugin(TabPage pluginScreenSpace, Label pluginStatusText)
        {
            pluginScreenSpace.Text = "绝龙诗工具";

            RegisterSettingForm(pluginScreenSpace, pluginStatusText);
            RegisterEvent();

            ActGlobals.oFormActMain.OnCombatStart += OFormActMain_OnCombatStart;
            ActGlobals.oFormActMain.OnCombatEnd += OFormActMain_OnCombatEnd;
        }

        public void DeInitPlugin()
        {
            _logReader?.Dispose();
            _toolSetting.SaveSetting(Path.Combine(ActGlobals.oFormActMain.AppDataFolder.FullName, "DragonSongRepriseToolHs.config"));

            ActGlobals.oFormActMain.OnCombatStart -= OFormActMain_OnCombatStart;
            ActGlobals.oFormActMain.OnCombatEnd -= OFormActMain_OnCombatEnd;
        }

        private void RegisterSettingForm(TabPage pluginScreenSpace, Label pluginStatusText)
        {
            _toolSetting.LoadSetting(Path.Combine(ActGlobals.oFormActMain.AppDataFolder.FullName, "DragonSongRepriseToolHs.config"));

            _settingForm = new SettingForm(_toolSetting, PartyMarkTest);
            _settingForm.Dock = DockStyle.Fill;
            _phaseHandler = new PhaseHandler
            {
                SettingForm = _settingForm
            };
            pluginScreenSpace.Controls.Add(_settingForm);

            pluginStatusText.Text = "已启用";
        }

        private void RegisterEvent()
        {
            _logReader?.Dispose();

            _logReader = new LogReader();
            _phaseHandler.RegisterEvent(_logReader);
            _logReader.Init();
        }

        private void OFormActMain_OnCombatStart(bool isImport, CombatToggleEventArgs encounterInfo)
        {
            Log.Print("战斗开始");
        }

        private void OFormActMain_OnCombatEnd(bool isImport, CombatToggleEventArgs encounterInfo)
        {
            _phaseHandler.ResetCombat();
            Log.Print("战斗结束");
        }

        /// <summary>
        /// 测试队伍标记
        /// </summary>
        private void PartyMarkTest()
        {
            _phaseHandler.PartyMarkTest();
        }

    }
}