namespace DragonSongRepriseTool.Common
{
    public enum DetectedTypeEnum
    {
        /// <summary>
        /// 聊天
        /// </summary>
        ChatLog = 0x00,

        /// <summary>
        /// 切换区域
        /// </summary>
        Territory = 0x01,

        /// <summary>
        /// 读条
        /// </summary>
        StartsCasting = 0x14,

        /// <summary>
        /// 状态效果
        /// </summary>
        ActionEffect = 0x15,

        /// <summary>
        /// 添加状态
        /// </summary>
        StatusAdd = 0x1A,

        /// <summary>
        /// 点名事件
        /// </summary>
        TargetIcon = 0x1B,

        /// <summary>
        /// 点名连线
        /// </summary>
        Tether = 0x23,
    }
}