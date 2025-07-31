using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using DailyRoutines.Abstracts;
using DailyRoutines.Helpers;
using DailyRoutines.Managers;
using DailyRoutines.Widgets;
using FFXIVClientStructs.FFXIV.Client.Game;
using Newtonsoft.Json;
using LuminaAction = Lumina.Excel.Sheets.Action;

namespace MessageOnSkillUse;

public class MessageOnSkillUse : DailyModuleBase
{
    public override ModuleInfo Info { get; } = new()
    {
        Title = GetLoc("MessageOnSkillUseTitle"),
        Description = GetLoc("MessageOnSkillUseDescription"),
        Category = ModuleCategories.Action,
        Author = ["Hsin"]
    };

    private const string Uri = "https://dr-cache.sumemo.dev";

    public Dictionary<uint, HealAction> TargetActions = [];

    private static ModuleStorage ModuleConfig = null!;

    // ui
    private static ActionSelectCombo? ActionSelect;

    #region Init

    protected override void Init()
    {
        ModuleConfig = LoadConfig<ModuleStorage>() ?? new ModuleStorage();

        // 初始化配置名称列表
        configNames = ModuleConfig.ConfigNames ?? new List<string>();

        FetchActions().Wait();

        UseActionManager.RegUseAction(PostUseActionDelegate);
        // UseActionManager.RegUseActionLocation(PostUseActionLocationDelegate);
    }

    protected override void Uninit()
    {
        UseActionManager.UnregUseAction(PostUseActionDelegate);
        // UseActionManager.UnregUseActionLocation(PostUseActionLocationDelegate);
    }

    #endregion

    #region UI

    protected override void ConfigUI()
    {
        if (ImGui.RadioButton(GetLoc("Disable"), !ModuleConfig.IsEnabled))
        {
            ModuleConfig.IsEnabled = false;
            SaveConfig(ModuleConfig);
        }

        if (ImGui.RadioButton(GetLoc("Enable"), ModuleConfig.IsEnabled))
        {
            ModuleConfig.IsEnabled = true;
            SaveConfig(ModuleConfig);
        }

        if (ModuleConfig.IsEnabled)
            ConfigureActionUI();
    }

    private void ConfigureActionUI()
    {
        // 创建两列布局
        ImGui.Columns(2, "SkillConfig", true);

        // 左列 - 技能列表
        ConfigureLeftColumn();

        ImGui.NextColumn();

        // 右列 - 详细配置
        ConfigureRightColumn();

        ImGui.Columns(1); // 重置为单列
    }

    private int selectedConfigIndex = -1;
    private string newConfigName = "";
    private bool showAddDialog = false;
    private List<string> configNames = [];
    private string newMessageInput = "";

    private void ConfigureLeftColumn()
    {
        ImGui.TextColored(LightSkyBlue, "配置列表");

        // 添加按钮
        if (ImGui.Button("添加##AddConfig"))
        {
            showAddDialog = true;
            newConfigName = "";
        }

        // 添加配置对话框
        if (showAddDialog)
        {
            ImGui.SetNextWindowSize(new Vector2(300, 120));
            if (ImGui.Begin("添加配置##AddConfigDialog", ref showAddDialog))
            {
                ImGui.Text("配置名称:");
                ImGui.InputText("##NewConfigName", ref newConfigName, 256);

                ImGui.Separator();

                if (ImGui.Button("确认##ConfirmAdd"))
                {
                    if (!string.IsNullOrWhiteSpace(newConfigName) && !configNames.Contains(newConfigName))
                    {
                        configNames.Add(newConfigName);
                        showAddDialog = false;
                        newConfigName = "";

                        // 保存配置名称列表到ModuleConfig
                        ModuleConfig.ConfigNames = configNames;
                        SaveConfig(ModuleConfig);
                    }
                }

                ImGui.SameLine();

                if (ImGui.Button("取消##CancelAdd"))
                {
                    showAddDialog = false;
                    newConfigName = "";
                }
            }

            ImGui.End();
        }

        ImGui.Separator();

        // 配置名称列表
        for (int i = 0; i < configNames.Count; i++)
        {
            var configName = configNames[i];

            // 可选择的列表项
            if (ImGui.Selectable($"{configName}##Config{i}", selectedConfigIndex == i))
                selectedConfigIndex = i;

            // 右键菜单
            if (ImGui.BeginPopupContextItem($"ConfigContext{i}"))
            {
                if (ImGui.MenuItem("删除##DeleteConfig"))
                {
                    configNames.RemoveAt(i);

                    if (selectedConfigIndex == i)
                        selectedConfigIndex = -1;
                    else if (selectedConfigIndex > i)
                        selectedConfigIndex--;

                    // 保存到ModuleConfig
                    ModuleConfig.ConfigNames = configNames;
                    SaveConfig(ModuleConfig);
                }

                ImGui.EndPopup();
            }
        }
    }

    private void ConfigureRightColumn()
    {
        ImGui.TextColored(LightSkyBlue, "技能配置");

        if (selectedConfigIndex >= 0 && selectedConfigIndex < configNames.Count)
        {
            var selectedConfigName = configNames[selectedConfigIndex];
            ImGui.Text($"当前配置: {selectedConfigName}");
            ImGui.Separator();

            // 确保配置数据存在
            if (!ModuleConfig.Configurations.ContainsKey(selectedConfigName))
                ModuleConfig.Configurations[selectedConfigName] = new ConfigData();

            var configData = ModuleConfig.Configurations[selectedConfigName];

            // 技能选择下拉多选框
            ImGui.Text("选择技能:");
            if (ActionSelect != null && ActionSelect.DrawCheckbox())
            {
                configData.SelectedActionIDs = ActionSelect.SelectedActionIDs.ToList();
                SaveConfig(ModuleConfig);
            }

            ImGui.Separator();

            // 消息配置
            ImGui.Text("消息列表:");

            // 显示现有消息
            for (int i = 0; i < configData.Messages.Count; i++)
            {
                ImGui.PushID($"Message{i}");

                // 消息输入框
                var message = configData.Messages[i];
                if (ImGui.InputText($"##MessageInput{i}", ref message, 512))
                {
                    configData.Messages[i] = message;
                    SaveConfig(ModuleConfig);
                }

                ImGui.SameLine();

                // 删除按钮
                if (ImGui.Button($"删除##DeleteMessage{i}"))
                {
                    configData.Messages.RemoveAt(i);
                    SaveConfig(ModuleConfig);
                    i--; // 调整索引
                }

                ImGui.PopID();
            }

            // 新消息输入
            ImGui.Separator();
            ImGui.Text("添加新消息:");

            if (ImGui.InputText("##NewMessage", ref newMessageInput, 512))
            {
                // 输入时不需要特殊处理
            }

            ImGui.SameLine();

            if (ImGui.Button("添加##AddMessage"))
            {
                if (!string.IsNullOrWhiteSpace(newMessageInput))
                {
                    configData.Messages.Add(newMessageInput);
                    newMessageInput = ""; // 清空输入框
                    SaveConfig(ModuleConfig);
                }
            }

            // 显示消息统计
            ImGui.Separator();
            ImGui.Text($"消息数量: {configData.Messages.Count}");
        }
        else
            ImGui.TextWrapped("请从左侧选择一个配置进行编辑");
    }

    #endregion

    #region Hooks

    private static void PostUseActionDelegate(
        bool result,
        ActionType actionType,
        uint actionId,
        ulong targetId,
        uint extraParam,
        ActionManager.UseActionMode queueState,
        uint comboRouteId)
    {
        if (actionType != ActionType.Action || !result || !ModuleConfig.IsEnabled)
            return;

        // 检查概率
        var random = new Random();
        if (random.Next(1, 101) > ModuleConfig.MessageProbability)
            return;

        // 查找包含此技能ID的配置
        var matchingMessages = new List<string>();

        foreach (var config in ModuleConfig.Configurations.Values)
        {
            if (config.SelectedActionIDs.Contains(actionId) && config.Messages.Count > 0)
                matchingMessages.AddRange(config.Messages);
        }

        if (matchingMessages.Count == 0)
            return;

        // 随机选择一条消息
        var selectedMessage = matchingMessages[random.Next(matchingMessages.Count)];

        // 发送消息
        SendChatMessage(selectedMessage);
    }

    private static void PostUseActionLocationDelegate(
        bool result,
        ActionType actionType,
        uint actionID,
        ulong targetID,
        Vector3 location,
        uint extraParam)
    {
        if (actionType != ActionType.Action)
            return;

        if (result == false)
            return;

        // 检查是否有配置的消息
        // if (!ModuleConfig.SkillMessages.TryGetValue(actionID, out var messages))
        //     return;
        //
        // if (messages.Count == 0)
        //     return;
        //
        // // 随机选择一条消息
        // var random = new Random();
        // var selectedMessage = messages[random.Next(messages.Count)];

        var selectedMessage = "hahahahahah";

        SendChatMessage(
            $"result: {result}, actionType: {actionType.ToString()}, actionID: {actionID}, targetID: {targetID}, location: {location.ToString()}, extraParam: {extraParam}, message: {selectedMessage}");
    }

    #endregion

    #region Cache

    private async Task FetchActions()
    {
        try
        {
            var json = await HttpClientHelper.Get().GetStringAsync($"{Uri}/heal-action");
            var resp = JsonConvert.DeserializeObject<Dictionary<string, List<HealAction>>>(json);
            if (resp == null)
                Error($"[HealerHelper] 远程治疗技能文件解析失败: {json}");
            else
                TargetActions = resp.SelectMany(kv => kv.Value).ToDictionary(act => act.Id, act => act);

            ActionSelect ??= new ActionSelectCombo("##ActionSelect", LuminaGetter.Get<LuminaAction>().Where(x => TargetActions.ContainsKey(x.RowId)));
        }
        catch (Exception ex)
        {
            Error($"[HealerHelper] 远程治疗技能文件获取失败: {ex}");
        }
    }

    #endregion

    /// <summary>
    /// 发送聊天消息
    /// </summary>
    /// <param name="message"></param>
    /// <param name="chatType"></param>
    private static void SendChatMessage(string message, string chatType = ChatType.Echo)
    {
        ChatHelper.SendMessage(chatType + message);
    }

    #region Config

    private static class ChatType
    {
        public const string Say = "/s ";

        public const string Party = "/p ";

        public const string Echo = "/e ";
    }

    private class ModuleStorage : ModuleConfiguration
    {
        // 配置名称列表
        public List<string> ConfigNames { get; set; } = [];

        // 配置名称 -> 配置数据的映射
        public Dictionary<string, ConfigData> Configurations { get; set; } = new();

        // 是否启用功能
        public bool IsEnabled { get; set; } = true;

        // 消息发送概率（0-100）
        public int MessageProbability { get; set; } = 100;
    }

    public class ConfigData
    {
        public List<uint> SelectedActionIDs { get; set; } = [];
        public List<string> Messages { get; set; } = [];
    }

    #endregion
}

public class HealAction
{
    [JsonProperty("id")]
    public uint Id { get; private set; }

    [JsonProperty("name")]
    public string Name { get; private set; }

    [JsonProperty("on")]
    public bool On { get; private set; }
}
