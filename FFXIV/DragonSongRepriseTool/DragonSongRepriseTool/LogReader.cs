using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Advanced_Combat_Tracker;
using DragonSongRepriseTool.Common;

namespace DragonSongRepriseTool
{
    public class LogEvent
    {
        public int EventCode { get; set; }

        public string EventRegexp { get; set; }

        public Action<string> CallBack { get; set; }
    }

    public class LogReader : IDisposable
    {
        private List<LogEvent> _events = new List<LogEvent>();

        public void Init()
        {
            ActGlobals.oFormActMain.OnLogLineRead += OFormActMain_OnLogLineRead;
        }

        public void RegisterEvent(DetectedTypeEnum detectedType, string regexp, Action<string> callBack)
        {
            _events.Add(new LogEvent()
            {
                CallBack = callBack,
                EventCode = (int)detectedType,
                EventRegexp = regexp
            });
        }

        private void OFormActMain_OnLogLineRead(bool isImport, LogLineEventArgs logInfo)
        {
            try
            {
                // // 测试
                // var detectedTypes = new List<int>() { 27, 20, 26, 01, 21, 35 };
                //
                // if (detectedTypes.Contains(logInfo.detectedType))
                // {
                //     Log.Print($"{logInfo.logLine}");
                // }

                foreach (var item in _events)
                {
                    if (logInfo.detectedType == item.EventCode &&
                        !string.IsNullOrEmpty(Regex.Match(logInfo.logLine, item.EventRegexp).Value))
                    {
                        Log.Print(logInfo.logLine);
                        item.CallBack(logInfo.logLine);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Print(ex.ToString());
            }
        }

        public void Dispose()
        {
            ActGlobals.oFormActMain.OnLogLineRead -= OFormActMain_OnLogLineRead;
        }
    }
}