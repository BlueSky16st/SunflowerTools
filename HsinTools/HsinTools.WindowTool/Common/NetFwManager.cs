using System;
using NetFwTypeLib;

namespace HsinTools.WindowTool.Common
{
    public static class NetFwManger
    {

        public class FwParam
        {
            public string Name { get; set; }

            public string LocalAddress { get; set; }

            public string LocalPorts { get; set; }

            public string RemoteAddress { get; set; }

            public string RemotePorts { get; set; }

            public string Protocol { get; set; }

            public bool IsEnable { get; set; }

            public NET_FW_RULE_DIRECTION_ Direction { get; set; }

            public NET_FW_ACTION_ Action { get; set; }

            public string Description { get; set; }
        }

        /// <summary>
        /// 添加防火墙例外端口
        /// </summary>
        /// <param name="param">参数名</param>
        public static void NetFwAddPorts(FwParam param)
        {
            //创建防火墙策略类的实例
            INetFwPolicy2 policy2 = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
            //创建防火墙规则类的实例
            INetFwRule rule = (INetFwRule)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwRule"));
            //为规则添加名称
            rule.Name = param.Name;
            //为规则添加描述
            rule.Description = param.Description;
            //选择入站规则还是出站规则，IN为入，OUT为出
            rule.Direction = param.Direction;
            //为规则添加协议类型
            switch (param.Protocol.ToUpper())
            {
                case "TCP":
                    rule.Protocol = (int)NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_TCP;
                    break;
                case "UDP":
                    rule.Protocol = (int)NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_UDP;
                    break;
                default:
                    rule.Protocol = (int)NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_ANY;
                    break;
            }

            //为规则添加应用程序（注意这里是应用程序的绝对路径名）
            //rule.ApplicationName = exePath;
            //为规则添加本地IP地址
            rule.LocalAddresses = param.LocalAddress;
            //为规则添加本地端口
            rule.LocalPorts = param.LocalPorts;
            //为规则添加远程IP地址
            rule.RemoteAddresses = param.RemoteAddress;
            //为规则添加远程端口
            rule.RemotePorts = param.RemotePorts;
            //设置规则是阻止还是允许（ALLOW=允许，BLOCK=阻止）
            rule.Action = param.Action;
            //是否启用规则
            rule.Enabled = param.IsEnable;
            try
            {
                //添加规则到防火墙策略
                policy2.Rules.Add(rule);
            }
            catch (Exception e)
            {
            }

        }

        /// <summary>
        /// 删除防火墙例外端口
        /// </summary>
        /// <param name="ruleName">规则名称</param>
        public static void NetFwDelApps(string ruleName)
        {
            //创建防火墙策略类的实例
            var policy2 = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
            try
            {
                //根据规则名称移除规则
                policy2.Rules.Remove(ruleName);
            }
            catch (Exception e)
            {
            }
        }

    }

}
