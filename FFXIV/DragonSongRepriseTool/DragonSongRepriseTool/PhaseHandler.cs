using System;
using System.Collections.Generic;
using System.Threading;
using DragonSongRepriseTool.Common;
using DragonSongRepriseTool.Setting;
using DragonSongRepriseTool.Window;

namespace DragonSongRepriseTool
{
    public class PhaseHandler
    {
        public SettingForm SettingForm;

        private readonly ToolSetting _toolSetting;

        private bool _isClearing;

        public PhaseHandler()
        {
            _toolSetting = ToolSetting.ToolSettingInstance;
            PostNamazuHelper.PostNamazuHelperInstance = new PostNamazuHelper();
        }

        public void RegisterEvent(LogReader logReader)
        {
            // 进入副本
            // logReader.RegisterEvent(DetectedTypeEnum.Territory, @"(\s|\S)+",
            //     (log) => { ProcessLog(DetectedTypeEnum.Territory, log); });

            // 获取小队玩家事件
            logReader.RegisterEvent(DetectedTypeEnum.ChatLog, @"^(\s|\S)+(JJSBTT|DSRH)\s\{(\s|\S)+\}$",
                (log) => { ProcessLog(DetectedTypeEnum.ChatLog, log); });

            // 点名事件
            // logReader.RegisterEvent(DetectedTypeEnum.TargetIcon, "^(.+?)TargetIcon(\\s|\\S)+$", log =>
            // {
            //
            // });

            // P6十字火光暗点名事件
            logReader.RegisterEvent(DetectedTypeEnum.StatusAdd, "^(.+?)StatusAdd(.+?)\\:(AC6|AC7)\\:(\\s|\\S)+$", log =>
            {
                try
                {
                    if (!_toolSetting.SettingModel.IsEnable || !_toolSetting.SettingModel.PartySetting.IsSettingOk())
                    {
                        return;
                    }

                    ProcessP6WrothFlames(log);
                }
                catch (Exception ex)
                {
                    Log.Print(ex.ToString());
                }
            });
        }

        public void ProcessLog(DetectedTypeEnum detectedType, string log)
        {
            if (!_toolSetting.SettingModel.IsEnable)
            {
                return;
            }

            switch (detectedType)
            {
                case DetectedTypeEnum.ChatLog:
                    ProcessChatLog(log);
                    break;
                case DetectedTypeEnum.Territory:
                    ProcessTerritoryLog(log);
                    break;
            }

            Log.Print(log);
        }

        /// <summary>
        /// 重置战斗状态
        /// </summary>
        public void ResetCombat()
        {
            _p6WrothFlamesAttackPlayer.Clear();
            _p6WrothFlamesAttackPlayerCount = 0;
        }

        /// <summary>
        /// 测试队伍标记
        /// </summary>
        public void PartyMarkTest()
        {
            if (_toolSetting.SettingModel.PartySetting.IsSettingOk())
            {
                new Thread(() =>
                {
                    MarkPlayer(MarkEnum.Attack1, _toolSetting.SettingModel.PartySetting.Mt);
                    Thread.Sleep(100);
                    MarkPlayer(MarkEnum.Attack2, _toolSetting.SettingModel.PartySetting.St);
                    Thread.Sleep(100);
                    MarkPlayer(MarkEnum.Attack3, _toolSetting.SettingModel.PartySetting.H1);
                    Thread.Sleep(100);
                    MarkPlayer(MarkEnum.Attack4, _toolSetting.SettingModel.PartySetting.H2);
                    Thread.Sleep(100);
                    MarkPlayer(MarkEnum.Bind1, _toolSetting.SettingModel.PartySetting.D1);
                    Thread.Sleep(100);
                    MarkPlayer(MarkEnum.Bind2, _toolSetting.SettingModel.PartySetting.D2);
                    Thread.Sleep(100);
                    MarkPlayer(MarkEnum.Stop1, _toolSetting.SettingModel.PartySetting.D3);
                    Thread.Sleep(100);
                    MarkPlayer(MarkEnum.Stop2, _toolSetting.SettingModel.PartySetting.D4);
                }).Start();
            }
        }

        private void ProcessChatLog(string log)
        {
            try
            {
                var macroType = 0;
                var logSubString = log.Substring(log.IndexOf("]"));
                var playerInfos = new List<PartySetting.PlayerInfo>();

                if (logSubString.Contains("DSRH {"))
                {
                    macroType = 1;
                }

                if (logSubString.Contains("JJSBTT {"))
                {
                    macroType = 2;
                }

                if (macroType == 1)
                {
                    var index = logSubString.IndexOf("DSRH {");
                    if (index != -1)
                    {
                        var after = logSubString.Substring(index + "DSRH {".Length);
                        index = after.IndexOf("}");
                        if (index != -1)
                        {
                            var playerIds = after.Substring(0, index).Split(':');

                            for (var i = 0; i < playerIds.Length; i++)
                            {
                                var item = playerIds[i];
                                if (string.IsNullOrEmpty(item))
                                {
                                    continue;
                                }

                                playerInfos.Add(new PartySetting.PlayerInfo
                                {
                                    Index = i + 1,
                                    Name = item,
                                    Position = UtilityClass.PositionList[i]
                                });
                            }
                        }
                    }
                }

                if (macroType == 2)
                {
                    var index = logSubString.IndexOf("JJJSBTT {");
                    if (index != -1)
                    {
                        var after = logSubString.Substring(index + "JJJSBTT {".Length);
                        index = after.IndexOf("}");
                        if (index != -1)
                        {
                            var playerIds = after.Substring(0, index).Split(':');
                            for (var i = 0; i < playerIds.Length; i++)
                            {
                                var item = playerIds[i];
                                if (string.IsNullOrEmpty(item))
                                {
                                    continue;
                                }

                                playerInfos.Add(new PartySetting.PlayerInfo
                                {
                                    Index = i + 1,
                                    Name = item,
                                    Position = UtilityClass.PositionList[i]
                                });
                            }
                        }
                    }
                }

                if (playerInfos.Count > 0)
                {
                    // 不满8人填充到8人
                    for (var i = playerInfos.Count; i < 8; i++)
                    {
                        playerInfos.Add(new PartySetting.PlayerInfo()
                        {
                            Index = i + 1,
                            Name = string.Empty,
                            Position = UtilityClass.PositionList[i]
                        });
                    }

                    // 删除后边的服务器名称
                    foreach (var playerInfo in playerInfos)
                    {
                        playerInfo.Name = playerInfo.Name.Split(UtilityClass.ServerNames.ToArray(),
                            StringSplitOptions.RemoveEmptyEntries)[0];
                    }

                    SettingForm.SetPlayers(playerInfos);
                }
            }
            catch (Exception ex)
            {
                Log.Print($"[{DateTime.Now:yyyy/MM/dd HH:mm:ss}]获取小队信息错误: {ex.Message}");
            }
        }

        private void ProcessTerritoryLog(string log)
        {
        }

        #region P6

        //P6光暗点名
        const int P6LightMark = 0xAC6;
        const int P6DarkMark = 0xAC7;

        private Dictionary<string, int> _p6WrothFlamesAttackPlayer = new Dictionary<string, int>();
        private int _p6WrothFlamesAttackPlayerCount = 0;

        private void ProcessP6WrothFlames(string log)
        {
            if (!_toolSetting.SettingModel.P6Reminder1)
            {
                return;
            }

            var logSubString = log.Substring(log.IndexOf("]"));
            var gainCodeStr = logSubString.Split(':')[1];
            var gainName = logSubString.Split(':')[2];
            var playerName = logSubString.Split(':')[7];

            Log.Print($"P6光暗点名{playerName} 类型:{gainCodeStr} 技能名:{gainName}");

            var gainCode = Convert.ToInt32(gainCodeStr, 16);
            _p6WrothFlamesAttackPlayer.Add(playerName, gainCode);
            _p6WrothFlamesAttackPlayerCount++;

            if (_p6WrothFlamesAttackPlayerCount == 6)
            {
                var playerList = _toolSetting.SettingModel.PartySetting.GetPlayerHashSet();
                foreach (var item in _p6WrothFlamesAttackPlayer)
                {
                    switch (item.Value)
                    {
                        case P6LightMark:
                            // Log.Print("点名attack：" + item.Key);
                            MarkPlayer(MarkEnum.Attack, item.Key, "分散");
                            break;
                        case P6DarkMark:
                            // Log.Print("点名bind：" + item.Key);
                            MarkPlayer(MarkEnum.Bind, item.Key, "分摊");
                            break;
                    }

                    playerList.Remove(item.Key);
                }

                foreach (var item in playerList)
                {
                    // Log.Print("点名stop：" + item);
                    MarkPlayer(MarkEnum.Stop, item, "无buff_分摊");
                }

                // ClearPlayerMark(15000);
            }
        }

        #endregion

        /// <summary>
        /// 清除队伍标记
        /// </summary>
        private void ClearPlayerMark(int milliseconds = 10000)
        {
            if (!_isClearing)
            {
                new Thread(() =>
                {
                    Thread.Sleep(milliseconds);
                    PostNamazuHelper.PostNamazuHelperInstance.SendCommand("/mk off <1>");
                    Thread.Sleep(100);
                    PostNamazuHelper.PostNamazuHelperInstance.SendCommand("/mk off <2>");
                    Thread.Sleep(100);
                    PostNamazuHelper.PostNamazuHelperInstance.SendCommand("/mk off <3>");
                    Thread.Sleep(100);
                    PostNamazuHelper.PostNamazuHelperInstance.SendCommand("/mk off <4>");
                    Thread.Sleep(100);
                    PostNamazuHelper.PostNamazuHelperInstance.SendCommand("/mk off <5>");
                    Thread.Sleep(100);
                    PostNamazuHelper.PostNamazuHelperInstance.SendCommand("/mk off <6>");
                    Thread.Sleep(100);
                    PostNamazuHelper.PostNamazuHelperInstance.SendCommand("/mk off <7>");
                    Thread.Sleep(100);
                    PostNamazuHelper.PostNamazuHelperInstance.SendCommand("/mk off <8>");

                    _isClearing = false;
                }).Start();

                _isClearing = true;
            }
        }

        private void MarkPlayer(MarkEnum mark, string player, string extLog = "")
        {
            try
            {
                var command = "";
                switch (_toolSetting.SettingModel.OutputMode)
                {
                    case "打印小队频道":
                        command =
                            $"/p {mark.GetDescription()} <{_toolSetting.SettingModel.PartySetting.GetIndexByName(player)}> ({extLog})";
                        break;

                    case "打印echo文本":
                        command =
                            $"/echo {mark.GetDescription()} <{_toolSetting.SettingModel.PartySetting.GetIndexByName(player)}> ({extLog})";
                        break;

                    case "正常标记":
                    default:
                        command =
                            $"/mk {mark.GetDescription()} <{_toolSetting.SettingModel.PartySetting.GetIndexByName(player)}>";
                        break;
                }

                Log.Print($"标记用户: {command} {extLog}");
                PostNamazuHelper.PostNamazuHelperInstance.SendCommand(command);
            }
            catch (Exception ex)
            {
                Log.Print($"出现错误, {ex.Message}");
            }
        }
    }
}