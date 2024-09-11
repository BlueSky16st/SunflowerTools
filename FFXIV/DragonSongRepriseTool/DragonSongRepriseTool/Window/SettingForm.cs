using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using DragonSongRepriseTool.Setting;
using Newtonsoft.Json;

namespace DragonSongRepriseTool.Window
{
    public partial class SettingForm : UserControl
    {
        private readonly ToolSetting _setting;
        private readonly Action _funcPartyMarkTest;

        public SettingForm(ToolSetting setting, Action funcPartyMarkTest)
        {
            _setting = setting;
            _funcPartyMarkTest = funcPartyMarkTest;

            InitializeComponent();
        }

        public void SetPlayers(List<PartySetting.PlayerInfo> players)
        {
            _setting.SettingModel.PartySetting.Clear();

            tbPlayer1.Text = players[0].Name;
            tbPos1.Text = players[0].Position;

            tbPlayer2.Text = players[1].Name;
            tbPos2.Text = players[1].Position;

            tbPlayer3.Text = players[2].Name;
            tbPos3.Text = players[2].Position;

            tbPlayer4.Text = players[3].Name;
            tbPos4.Text = players[3].Position;

            tbPlayer5.Text = players[4].Name;
            tbPos5.Text = players[4].Position;

            tbPlayer6.Text = players[5].Name;
            tbPos6.Text = players[5].Position;

            tbPlayer7.Text = players[6].Name;
            tbPos7.Text = players[6].Position;

            tbPlayer8.Text = players[7].Name;
            tbPos8.Text = players[7].Position;
        }

        private void SettingForm_Load(object sender, System.EventArgs e)
        {
            Log.TextBox = tbLog;

            cbEnableTool.Checked = _setting.SettingModel.IsEnable;

            tbPostNamazuUrl.Text = _setting.SettingModel.PostNamazuUrl;

            cbOutputMode.SelectedItem = _setting.SettingModel.OutputMode;

            var userInfos = new List<PartySetting.PlayerInfo>(_setting.SettingModel.PartySetting.PlayerInfos);
            SetPlayers(userInfos);

            cbP2Reminder1.Checked = _setting.SettingModel.P2Reminder1;
            cbP2Reminder2.Checked = _setting.SettingModel.P2Reminder2;
            cbP2Reminder3.Checked = _setting.SettingModel.P2Reminder3;
            cbP2Reminder4.Checked = _setting.SettingModel.P2Reminder4;
            cbP2Reminder5.Checked = _setting.SettingModel.P2Reminder5;

            cbP3Reminder1.Checked = _setting.SettingModel.P3Reminder1;

            cbP4Reminder1.Checked = _setting.SettingModel.P4Reminder1;

            cbP5Reminder1.Checked = _setting.SettingModel.P5Reminder1;
            cbP5Reminder2.Checked = _setting.SettingModel.P5Reminder2;
            cbP5Reminder3.Checked = _setting.SettingModel.P5Reminder3;

            cbP6Reminder1.Checked = _setting.SettingModel.P6Reminder1;
            cbP6Reminder2.Checked = _setting.SettingModel.P6Reminder2;

            CheckPartySettingDone();
        }

        private void btnPartyMarkTest_Click(object sender, EventArgs e)
        {
            _funcPartyMarkTest();
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            tbLog.Clear();
        }

        private void tbPlayer1_TextChanged(object sender, EventArgs e)
        {
            _setting.SettingModel.PartySetting.FillParty(tbPlayer1.Text, tbPos1.Text, 1);
            CheckPartySettingDone();
        }

        private void tbPos1_TextChanged(object sender, EventArgs e)
        {
            _setting.SettingModel.PartySetting.FillParty(tbPlayer1.Text, tbPos1.Text, 1);
            CheckPartySettingDone();
        }

        private void tbPlayer2_TextChanged(object sender, EventArgs e)
        {
            _setting.SettingModel.PartySetting.FillParty(tbPlayer2.Text, tbPos2.Text, 2);
            CheckPartySettingDone();
        }

        private void tbPos2_TextChanged(object sender, EventArgs e)
        {
            _setting.SettingModel.PartySetting.FillParty(tbPlayer2.Text, tbPos2.Text, 2);
            CheckPartySettingDone();
        }

        private void tbPlayer3_TextChanged(object sender, EventArgs e)
        {
            _setting.SettingModel.PartySetting.FillParty(tbPlayer3.Text, tbPos3.Text, 3);
            CheckPartySettingDone();
        }

        private void tbPos3_TextChanged(object sender, EventArgs e)
        {
            _setting.SettingModel.PartySetting.FillParty(tbPlayer3.Text, tbPos3.Text, 3);
            CheckPartySettingDone();
        }

        private void tbPlayer4_TextChanged(object sender, EventArgs e)
        {
            _setting.SettingModel.PartySetting.FillParty(tbPlayer4.Text, tbPos4.Text, 4);
            CheckPartySettingDone();
        }

        private void tbPos4_TextChanged(object sender, EventArgs e)
        {
            _setting.SettingModel.PartySetting.FillParty(tbPlayer4.Text, tbPos4.Text, 4);
            CheckPartySettingDone();
        }

        private void tbPlayer5_TextChanged(object sender, EventArgs e)
        {
            _setting.SettingModel.PartySetting.FillParty(tbPlayer5.Text, tbPos5.Text, 5);
            CheckPartySettingDone();
        }

        private void tbPos5_TextChanged(object sender, EventArgs e)
        {
            _setting.SettingModel.PartySetting.FillParty(tbPlayer5.Text, tbPos5.Text, 5);
            CheckPartySettingDone();
        }

        private void tbPlayer6_TextChanged(object sender, EventArgs e)
        {
            _setting.SettingModel.PartySetting.FillParty(tbPlayer6.Text, tbPos6.Text, 6);
            CheckPartySettingDone();
        }

        private void tbPos6_TextChanged(object sender, EventArgs e)
        {
            _setting.SettingModel.PartySetting.FillParty(tbPlayer6.Text, tbPos6.Text, 6);
            CheckPartySettingDone();
        }

        private void tbPlayer7_TextChanged(object sender, EventArgs e)
        {
            _setting.SettingModel.PartySetting.FillParty(tbPlayer7.Text, tbPos7.Text, 7);
            CheckPartySettingDone();
        }

        private void tbPos7_TextChanged(object sender, EventArgs e)
        {
            _setting.SettingModel.PartySetting.FillParty(tbPlayer7.Text, tbPos7.Text, 7);
            CheckPartySettingDone();
        }

        private void tbPlayer8_TextChanged(object sender, EventArgs e)
        {
            _setting.SettingModel.PartySetting.FillParty(tbPlayer8.Text, tbPos8.Text, 8);
            CheckPartySettingDone();
        }

        private void tbPos8_TextChanged(object sender, EventArgs e)
        {
            _setting.SettingModel.PartySetting.FillParty(tbPlayer8.Text, tbPos8.Text, 8);
            CheckPartySettingDone();
        }

        private void tbPostNamazuUrl_TextChanged(object sender, EventArgs e)
        {
            _setting.SettingModel.PostNamazuUrl = tbPostNamazuUrl.Text;
        }

        private void cbP2Reminder1_CheckedChanged(object sender, EventArgs e)
        {
            _setting.SettingModel.P2Reminder1 = cbP2Reminder1.Checked;
        }

        private void cbP2Reminder2_CheckedChanged(object sender, EventArgs e)
        {
            _setting.SettingModel.P2Reminder2 = cbP2Reminder2.Checked;
        }

        private void cbP2Reminder3_CheckedChanged(object sender, EventArgs e)
        {
            _setting.SettingModel.P2Reminder3 = cbP2Reminder3.Checked;
        }

        private void cbP2Reminder4_CheckedChanged(object sender, EventArgs e)
        {
            _setting.SettingModel.P2Reminder4 = cbP2Reminder4.Checked;
        }

        private void cbP2Reminder5_CheckedChanged(object sender, EventArgs e)
        {
            _setting.SettingModel.P2Reminder5 = cbP2Reminder5.Checked;
        }

        private void cbP3Reminder1_CheckedChanged(object sender, EventArgs e)
        {
            _setting.SettingModel.P3Reminder1 = cbP3Reminder1.Checked;
        }

        private void cbP4Reminder1_CheckedChanged(object sender, EventArgs e)
        {
            _setting.SettingModel.P4Reminder1 = cbP4Reminder1.Checked;
        }

        private void cbP5Reminder1_CheckedChanged(object sender, EventArgs e)
        {
            _setting.SettingModel.P5Reminder1 = cbP5Reminder1.Checked;
        }

        private void cbP5Reminder2_CheckedChanged(object sender, EventArgs e)
        {
            _setting.SettingModel.P5Reminder2 = cbP5Reminder2.Checked;
        }

        private void cbP5Reminder3_CheckedChanged(object sender, EventArgs e)
        {
            _setting.SettingModel.P5Reminder3 = cbP5Reminder3.Checked;
        }

        private void cbP6Reminder1_CheckedChanged(object sender, EventArgs e)
        {
            _setting.SettingModel.P6Reminder1 = cbP6Reminder1.Checked;
        }

        private void cbP6Reminder2_CheckedChanged(object sender, EventArgs e)
        {
            _setting.SettingModel.P6Reminder2 = cbP6Reminder2.Checked;
        }

        private void cbEnableTool_CheckedChanged(object sender, EventArgs e)
        {
            _setting.SettingModel.IsEnable = cbEnableTool.Checked;
        }

        private void cbOutputMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            _setting.SettingModel.OutputMode = cbOutputMode.SelectedItem as string;
        }

        private void CheckPartySettingDone()
        {
            if (_setting.SettingModel.PartySetting.IsSettingOk())
            {
                lbPartyStatus.Text = "队伍配置成功";
                lbPartyStatus.ForeColor = Color.Green;
            }
            else
            {
                lbPartyStatus.Text = "等待配置队伍";
                lbPartyStatus.ForeColor = Color.Red;
            }
        }

    }
}