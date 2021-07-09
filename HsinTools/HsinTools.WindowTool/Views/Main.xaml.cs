using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using HsinTools.WindowTool.Common;
using NetFwTypeLib;
using Notification.Wpf;

namespace HsinTools.WindowTool.Views
{
    /// <summary>
    /// Main.xaml 的交互逻辑
    /// </summary>
    public partial class Main : Window
    {

        public Main()
        {
            InitializeComponent();
            Loaded += WindowLoaded;
            Closed += WindowClosed;
        }

        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            // 启动时隐藏窗口
            //Visibility = Visibility.Hidden;

            var notificationManager = new NotificationManager();

            if (!Hotkey.Regist(this, Hotkey.HotkeyModifiers.MOD_CONTROL, Key.R, SwitchGw))
                notificationManager.Show("提示", "注册快捷键失败(CTRL+R)", NotificationType.Error, expirationTime: TimeSpan.FromSeconds(3));

            if (!Hotkey.Regist(this, Hotkey.HotkeyModifiers.MOD_CONTROL, Key.Q, SwitchVisible))
                notificationManager.Show("提示", "注册快捷键失败(CTRL+Q)", NotificationType.Error, expirationTime: TimeSpan.FromSeconds(3));

            notificationManager.Show("提示", "程序已启动", NotificationType.Notification, expirationTime: TimeSpan.FromSeconds(3));
        }

        private void WindowClosed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void SwitchGw()
        {
            // 切换防火墙的允许与拒绝连接
            FwIsAllow.IsChecked = !FwIsAllow.IsChecked;
            SetGsFw(false);

            var notificationManager = new NotificationManager();
            notificationManager.Show("提示", $"已{(FwIsAllow.IsChecked.Value ? "允许" : "拒绝")}防火墙规则连接", NotificationType.Notification, expirationTime: TimeSpan.FromSeconds(2));
        }

        private void SwitchVisible()
        {
            Visibility = Visibility == Visibility.Hidden ? Visibility.Visible : Visibility.Hidden;
        }

        private void SetGsFw(bool isNotice = true)
        {
            var fwProtocolSelectedItem = FwProtocol.SelectedItem as TextBlock;
            var protocol = fwProtocolSelectedItem.Text;

            var fwRuleSelectedItem = FwRule.SelectedItem as TextBlock;
            var direction = fwRuleSelectedItem.Text;

            var localAddress = FwLocalIp.Text;
            var localPorts = FwLocalPort.Text;
            var remoteAddress = FwRemoteIp.Text;
            var remotePorts = FwRemotePort.Text;
            var ruleName = FwName.Text;
            var isEnable = FwIsEnable.IsChecked ?? true;
            var isAllow = FwIsAllow.IsChecked ?? true;

            NetFwManger.NetFwDelApps(ruleName);
            NetFwManger.NetFwAddPorts(new NetFwManger.FwParam
            {
                Name = ruleName,
                LocalAddress = localAddress,
                LocalPorts = localPorts,
                RemoteAddress = remoteAddress,
                RemotePorts = remotePorts,
                Protocol = protocol,
                IsEnable = isEnable,
                Direction = direction == "出站规则" ? NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT : NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_IN,
                Action = isAllow ? NET_FW_ACTION_.NET_FW_ACTION_ALLOW : NET_FW_ACTION_.NET_FW_ACTION_BLOCK,
                Description = ""
            });

            LbStatus.Content = $"[{DateTime.Now:yyyy/MM/dd HH:mm:ss}] 修改成功";
            if (isNotice)
            {
                var notificationManager = new NotificationManager();
                notificationManager.Show("提示", "规则修改成功", NotificationType.Notification, expirationTime: TimeSpan.FromSeconds(2));
            }
        }

        private void saveGsFw_Click(object sender, RoutedEventArgs e)
        {
            SetGsFw();
        }
    }
}
