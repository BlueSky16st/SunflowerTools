using System.Collections.Generic;
using System.Linq;
using DragonSongRepriseTool.Common;
using Newtonsoft.Json;

namespace DragonSongRepriseTool.Setting
{
    public class PartySetting
    {
        public class PlayerInfo
        {
            public int Index { get; set; }

            public string Name { get; set; }

            public string Position { get; set; }
        }

        public List<PlayerInfo> PlayerInfos { get; set; } = new List<PlayerInfo>();

        public string Mt { get; set; }
        public string St { get; set; }
        public string H1 { get; set; }
        public string H2 { get; set; }
        public string D1 { get; set; }
        public string D2 { get; set; }
        public string D3 { get; set; }
        public string D4 { get; set; }

        public PartySetting()
        {
        }

        public PartySetting(Dictionary<string, string> party)
        {
            var keys = party.Keys.ToList();
            for (var i = 0; i < keys.Count; ++i)
            {
                var key = keys[i];
                var value = party[key];
                FillParty(value, key, i + 1);
            }
        }

        public void FillParty(string name, string pos, int index)
        {
            switch (pos.ToLower())
            {
                case "mt":
                    Mt = name;
                    break;
                case "st":
                    St = name;
                    break;
                case "h1":
                    H1 = name;
                    break;
                case "h2":
                    H2 = name;
                    break;
                case "d1":
                    D1 = name;
                    break;
                case "d2":
                    D2 = name;
                    break;
                case "d3":
                    D3 = name;
                    break;
                case "d4":
                    D4 = name;
                    break;
            }

            var playerInfo = PlayerInfos.FirstOrDefault(x => x.Index == index);
            if (playerInfo == null)
            {
                PlayerInfos.Add(new PlayerInfo { Index = index, Name = name, Position = pos });
            }
            else
            {
                playerInfo.Name = name;
                playerInfo.Position = pos;
                playerInfo.Index = index;
            }
        }

        public int GetIndexByName(string name)
        {
            return PlayerInfos.FirstOrDefault(x => x.Name == name)?.Index ?? 0;
        }

        public bool IsSettingOk()
        {
            var isRepeat = PlayerInfos.GroupBy(p => p.Position).Select(p => p.Count()).OrderByDescending(p => p)
                .Any(p => p != 1);

            var errPos = PlayerInfos.Select(p => p.Position.ToUpper()).Any(p => !UtilityClass.PositionList.Contains(p));

            return !isRepeat && !errPos && !string.IsNullOrEmpty(Mt) && !string.IsNullOrEmpty(St) &&
                   !string.IsNullOrEmpty(H1) && !string.IsNullOrEmpty(H2) && !string.IsNullOrEmpty(D1) &&
                   !string.IsNullOrEmpty(D2) && !string.IsNullOrEmpty(D3) && !string.IsNullOrEmpty(D4);
        }

        public void Clear()
        {
            PlayerInfos.Clear();
            Mt = null;
            St = null;
            H1 = null;
            H2 = null;
            D1 = null;
            D2 = null;
            D3 = null;
            D4 = null;
        }

        public HashSet<string> GetPlayerHashSet()
        {
            var res = new HashSet<string>
            {
                Mt,
                St,
                H1,
                H2,
                D1,
                D2,
                D3,
                D4
            };

            return res;
        }
    }

    public class SettingModel
    {
        public bool IsEnable { get; set; }

        public string OutputMode { get; set; }

        public PartySetting PartySetting { get; set; }

        public string PostNamazuUrl { get; set; }

        public bool P2Reminder1 { get; set; }
        public bool P2Reminder2 { get; set; }
        public bool P2Reminder3 { get; set; }
        public bool P2Reminder4 { get; set; }
        public bool P2Reminder5 { get; set; }

        public bool P3Reminder1 { get; set; }

        public bool P4Reminder1 { get; set; }

        public bool P5Reminder1 { get; set; }
        public bool P5Reminder2 { get; set; }
        public bool P5Reminder3 { get; set; }

        public bool P6Reminder1 { get; set; }
        public bool P6Reminder2 { get; set; }

        public static SettingModel GetInitData()
        {
            return new SettingModel
            {
                IsEnable = false,
                OutputMode = "正常标记",
                PartySetting = new PartySetting(new Dictionary<string, string>()
                {
                    { "MT", "" },
                    { "ST", "" },
                    { "H1", "" },
                    { "H2", "" },
                    { "D1", "" },
                    { "D2", "" },
                    { "D3", "" },
                    { "D4", "" },
                }),
                PostNamazuUrl = "http://127.0.0.1:2019/command",
                P2Reminder1 = false,
                P2Reminder2 = false,
                P2Reminder3 = false,
                P2Reminder4 = false,
                P2Reminder5 = false,
                P3Reminder1 = false,
                P4Reminder1 = false,
                P5Reminder1 = false,
                P5Reminder2 = false,
                P5Reminder3 = false,
                P6Reminder1 = false,
                P6Reminder2 = false
            };
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}