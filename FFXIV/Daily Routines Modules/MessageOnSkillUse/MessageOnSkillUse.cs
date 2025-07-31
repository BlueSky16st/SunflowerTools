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
        ModuleConfig = LoadConfig<ModuleStorage>();

        FetchActions().Wait();

        UseActionManager.RegUseAction(PreUseActionLocationDelegate);
        // UseActionManager.RegUseActionLocation(PostUseActionLocationDelegate);
    }

    protected override void Uninit()
    {
        UseActionManager.UnregUseAction(PreUseActionLocationDelegate);
        // UseActionManager.UnregUseActionLocation(PostUseActionLocationDelegate);
    }

    #endregion

    #region UI

    protected override void ConfigUI()
    {
        ConfigureActionUI();
    }

    private void ConfigureActionUI()
    {
        ImGui.TextColored(LightSkyBlue, GetLoc("配置技能"));

    }

    #endregion

    #region Hooks

    private static void PreUseActionLocationDelegate(
        bool result,
        ActionType actionType,
        uint actionId,
        ulong targetId,
        uint extraParam,
        ActionManager.UseActionMode queueState,
        uint comboRouteId)
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
            $"result: {result}, actionType: {actionType.ToString()}, actionId: {actionId}, targetId: {targetId}, extraParam: {extraParam}, queueState: {queueState.ToString()}, comboRouteId: {comboRouteId}, message: {selectedMessage}");
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
        // 技能ID -> 消息列表的映射
        public Dictionary<uint, List<string>> SkillMessages { get; set; } = new();

        // 是否启用功能
        public bool IsEnabled { get; set; } = true;

        // 消息发送概率（0-100）
        public int MessageProbability { get; set; } = 100;
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
