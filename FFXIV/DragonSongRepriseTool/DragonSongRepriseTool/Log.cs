using System.Windows.Forms;

namespace DragonSongRepriseTool
{
    public class Log
    {
        public static TextBox TextBox;

        private delegate void UpdateTxt(string msg);

        public static void Print(string str)
        {
            if (TextBox != null && TextBox.IsHandleCreated)
            {
                TextBox?.BeginInvoke(new UpdateTxt((msg) => { TextBox.AppendText($"{msg}\r\n"); }), str);
            }
        }
    }
}