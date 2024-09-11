using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace DragonSongRepriseTool.Common
{
    public static class UtilityClass
    {
        public static List<string> PositionList { get; set; } = new List<string>()
            { "MT", "ST", "H1", "H2", "D1", "D2", "D3", "D4" };

        public static List<string> ServerNames = new List<string>()
            { "潮风亭", "神拳痕", "白银乡", "白金幻象", "旅人栈桥", "拂晓之间", "龙巢神殿", "梦羽宝境" };

        /// <summary>
        /// 扩展方法，获得枚举的Description
        /// </summary>
        /// <param name="value">枚举值</param>
        /// <param name="nameInstead">当枚举值没有定义DescriptionAttribute，是否使用枚举名代替，默认是使用</param>
        /// <returns>枚举的Description</returns>
        public static string GetDescription(this Enum value, Boolean nameInstead = true)
        {
            Type type = value.GetType();
            string name = Enum.GetName(type, value);
            if (name == null)
            {
                return null;
            }

            FieldInfo field = type.GetField(name);
            DescriptionAttribute attribute =
                System.Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;

            if (attribute == null && nameInstead == true)
            {
                return name;
            }

            return attribute?.Description;
        }
    }
}