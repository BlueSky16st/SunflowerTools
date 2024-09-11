using System.ComponentModel;
using System.Windows.Forms;

namespace DragonSongRepriseTool.Window
{
    partial class SettingForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbOutputMode = new System.Windows.Forms.ComboBox();
            this.cbEnableTool = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbLayoutParty = new System.Windows.Forms.TableLayoutPanel();
            this.tbPos8 = new System.Windows.Forms.TextBox();
            this.tbPlayer8 = new System.Windows.Forms.TextBox();
            this.tbPos7 = new System.Windows.Forms.TextBox();
            this.tbPlayer7 = new System.Windows.Forms.TextBox();
            this.tbPos6 = new System.Windows.Forms.TextBox();
            this.tbPlayer6 = new System.Windows.Forms.TextBox();
            this.tbPos5 = new System.Windows.Forms.TextBox();
            this.tbPlayer5 = new System.Windows.Forms.TextBox();
            this.tbPos4 = new System.Windows.Forms.TextBox();
            this.tbPlayer4 = new System.Windows.Forms.TextBox();
            this.tbPos3 = new System.Windows.Forms.TextBox();
            this.tbPlayer3 = new System.Windows.Forms.TextBox();
            this.tbPos2 = new System.Windows.Forms.TextBox();
            this.tbPlayer2 = new System.Windows.Forms.TextBox();
            this.tbPlayer1 = new System.Windows.Forms.TextBox();
            this.tbPos1 = new System.Windows.Forms.TextBox();
            this.lbPartyStatus = new System.Windows.Forms.Label();
            this.lbPartyStatusTxt = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbTip2 = new System.Windows.Forms.Label();
            this.lbTip1 = new System.Windows.Forms.Label();
            this.tbLogPlayerName = new System.Windows.Forms.TextBox();
            this.tbPostNamazuUrl = new System.Windows.Forms.TextBox();
            this.tbTips = new System.Windows.Forms.Label();
            this.btnPartyMarkTest = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.layoutP2 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbP2Reminder1 = new System.Windows.Forms.CheckBox();
            this.lbP2Reminder1 = new System.Windows.Forms.Label();
            this.cbP2Reminder2 = new System.Windows.Forms.CheckBox();
            this.lbP2Reminder2 = new System.Windows.Forms.Label();
            this.cbP2Reminder3 = new System.Windows.Forms.CheckBox();
            this.lbP2Reminder3 = new System.Windows.Forms.Label();
            this.cbP2Reminder4 = new System.Windows.Forms.CheckBox();
            this.lbP2Reminder4 = new System.Windows.Forms.Label();
            this.cbP2Reminder5 = new System.Windows.Forms.CheckBox();
            this.lbP2Reminder5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.layoutP3 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbP3Reminder1 = new System.Windows.Forms.CheckBox();
            this.lbP3Reminder1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.layoutP4 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbP4Reminder1 = new System.Windows.Forms.CheckBox();
            this.lbP4Reminder1 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.layoutP5 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbP5Reminder1 = new System.Windows.Forms.CheckBox();
            this.lbP5Reminder1 = new System.Windows.Forms.Label();
            this.cbP5Reminder2 = new System.Windows.Forms.CheckBox();
            this.lbP5Reminder2 = new System.Windows.Forms.Label();
            this.cbP5Reminder3 = new System.Windows.Forms.CheckBox();
            this.lbP5Reminder3 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.layoutP6 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbP6Reminder1 = new System.Windows.Forms.CheckBox();
            this.lbP6Reminder1 = new System.Windows.Forms.Label();
            this.cbP6Reminder2 = new System.Windows.Forms.CheckBox();
            this.lbP6Reminder2 = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbLayoutParty.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.layoutP2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.layoutP3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.layoutP4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.layoutP5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.layoutP6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Controls.Add(this.tabPage6);
            this.tabControl.Controls.Add(this.tabPage7);
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(794, 394);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbOutputMode);
            this.tabPage1.Controls.Add(this.cbEnableTool);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.lbPartyStatus);
            this.tabPage1.Controls.Add(this.lbPartyStatusTxt);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btnPartyMarkTest);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(786, 368);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "队伍设置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbOutputMode
            // 
            this.cbOutputMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbOutputMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOutputMode.FormattingEnabled = true;
            this.cbOutputMode.Items.AddRange(new object[] {
            "正常标记",
            "打印小队频道",
            "打印echo文本"});
            this.cbOutputMode.Location = new System.Drawing.Point(165, 341);
            this.cbOutputMode.Name = "cbOutputMode";
            this.cbOutputMode.Size = new System.Drawing.Size(121, 20);
            this.cbOutputMode.TabIndex = 8;
            this.cbOutputMode.SelectedIndexChanged += new System.EventHandler(this.cbOutputMode_SelectedIndexChanged);
            // 
            // cbEnableTool
            // 
            this.cbEnableTool.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbEnableTool.AutoSize = true;
            this.cbEnableTool.Location = new System.Drawing.Point(8, 343);
            this.cbEnableTool.Name = "cbEnableTool";
            this.cbEnableTool.Size = new System.Drawing.Size(72, 16);
            this.cbEnableTool.TabIndex = 5;
            this.cbEnableTool.Text = "启用工具";
            this.cbEnableTool.UseVisualStyleBackColor = true;
            this.cbEnableTool.CheckedChanged += new System.EventHandler(this.cbEnableTool_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.tbLayoutParty);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 326);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "队伍";
            // 
            // tbLayoutParty
            // 
            this.tbLayoutParty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLayoutParty.AutoScroll = true;
            this.tbLayoutParty.ColumnCount = 2;
            this.tbLayoutParty.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.69517F));
            this.tbLayoutParty.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.30483F));
            this.tbLayoutParty.Controls.Add(this.tbPos8, 1, 7);
            this.tbLayoutParty.Controls.Add(this.tbPlayer8, 0, 7);
            this.tbLayoutParty.Controls.Add(this.tbPos7, 1, 6);
            this.tbLayoutParty.Controls.Add(this.tbPlayer7, 0, 6);
            this.tbLayoutParty.Controls.Add(this.tbPos6, 1, 5);
            this.tbLayoutParty.Controls.Add(this.tbPlayer6, 0, 5);
            this.tbLayoutParty.Controls.Add(this.tbPos5, 1, 4);
            this.tbLayoutParty.Controls.Add(this.tbPlayer5, 0, 4);
            this.tbLayoutParty.Controls.Add(this.tbPos4, 1, 3);
            this.tbLayoutParty.Controls.Add(this.tbPlayer4, 0, 3);
            this.tbLayoutParty.Controls.Add(this.tbPos3, 1, 2);
            this.tbLayoutParty.Controls.Add(this.tbPlayer3, 0, 2);
            this.tbLayoutParty.Controls.Add(this.tbPos2, 1, 1);
            this.tbLayoutParty.Controls.Add(this.tbPlayer2, 0, 1);
            this.tbLayoutParty.Controls.Add(this.tbPlayer1, 0, 0);
            this.tbLayoutParty.Controls.Add(this.tbPos1, 1, 0);
            this.tbLayoutParty.Location = new System.Drawing.Point(6, 20);
            this.tbLayoutParty.Name = "tbLayoutParty";
            this.tbLayoutParty.RowCount = 8;
            this.tbLayoutParty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tbLayoutParty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tbLayoutParty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tbLayoutParty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tbLayoutParty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tbLayoutParty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tbLayoutParty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tbLayoutParty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tbLayoutParty.Size = new System.Drawing.Size(285, 320);
            this.tbLayoutParty.TabIndex = 2;
            // 
            // tbPos8
            // 
            this.tbPos8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPos8.Location = new System.Drawing.Point(224, 213);
            this.tbPos8.Name = "tbPos8";
            this.tbPos8.Size = new System.Drawing.Size(58, 21);
            this.tbPos8.TabIndex = 15;
            this.tbPos8.TextChanged += new System.EventHandler(this.tbPos8_TextChanged);
            // 
            // tbPlayer8
            // 
            this.tbPlayer8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPlayer8.Location = new System.Drawing.Point(3, 213);
            this.tbPlayer8.Name = "tbPlayer8";
            this.tbPlayer8.Size = new System.Drawing.Size(215, 21);
            this.tbPlayer8.TabIndex = 14;
            this.tbPlayer8.TextChanged += new System.EventHandler(this.tbPlayer8_TextChanged);
            // 
            // tbPos7
            // 
            this.tbPos7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPos7.Location = new System.Drawing.Point(224, 183);
            this.tbPos7.Name = "tbPos7";
            this.tbPos7.Size = new System.Drawing.Size(58, 21);
            this.tbPos7.TabIndex = 13;
            this.tbPos7.TextChanged += new System.EventHandler(this.tbPos7_TextChanged);
            // 
            // tbPlayer7
            // 
            this.tbPlayer7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPlayer7.Location = new System.Drawing.Point(3, 183);
            this.tbPlayer7.Name = "tbPlayer7";
            this.tbPlayer7.Size = new System.Drawing.Size(215, 21);
            this.tbPlayer7.TabIndex = 12;
            this.tbPlayer7.TextChanged += new System.EventHandler(this.tbPlayer7_TextChanged);
            // 
            // tbPos6
            // 
            this.tbPos6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPos6.Location = new System.Drawing.Point(224, 153);
            this.tbPos6.Name = "tbPos6";
            this.tbPos6.Size = new System.Drawing.Size(58, 21);
            this.tbPos6.TabIndex = 11;
            this.tbPos6.TextChanged += new System.EventHandler(this.tbPos6_TextChanged);
            // 
            // tbPlayer6
            // 
            this.tbPlayer6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPlayer6.Location = new System.Drawing.Point(3, 153);
            this.tbPlayer6.Name = "tbPlayer6";
            this.tbPlayer6.Size = new System.Drawing.Size(215, 21);
            this.tbPlayer6.TabIndex = 10;
            this.tbPlayer6.TextChanged += new System.EventHandler(this.tbPlayer6_TextChanged);
            // 
            // tbPos5
            // 
            this.tbPos5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPos5.Location = new System.Drawing.Point(224, 123);
            this.tbPos5.Name = "tbPos5";
            this.tbPos5.Size = new System.Drawing.Size(58, 21);
            this.tbPos5.TabIndex = 9;
            this.tbPos5.TextChanged += new System.EventHandler(this.tbPos5_TextChanged);
            // 
            // tbPlayer5
            // 
            this.tbPlayer5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPlayer5.Location = new System.Drawing.Point(3, 123);
            this.tbPlayer5.Name = "tbPlayer5";
            this.tbPlayer5.Size = new System.Drawing.Size(215, 21);
            this.tbPlayer5.TabIndex = 8;
            this.tbPlayer5.TextChanged += new System.EventHandler(this.tbPlayer5_TextChanged);
            // 
            // tbPos4
            // 
            this.tbPos4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPos4.Location = new System.Drawing.Point(224, 93);
            this.tbPos4.Name = "tbPos4";
            this.tbPos4.Size = new System.Drawing.Size(58, 21);
            this.tbPos4.TabIndex = 7;
            this.tbPos4.TextChanged += new System.EventHandler(this.tbPos4_TextChanged);
            // 
            // tbPlayer4
            // 
            this.tbPlayer4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPlayer4.Location = new System.Drawing.Point(3, 93);
            this.tbPlayer4.Name = "tbPlayer4";
            this.tbPlayer4.Size = new System.Drawing.Size(215, 21);
            this.tbPlayer4.TabIndex = 6;
            this.tbPlayer4.TextChanged += new System.EventHandler(this.tbPlayer4_TextChanged);
            // 
            // tbPos3
            // 
            this.tbPos3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPos3.Location = new System.Drawing.Point(224, 63);
            this.tbPos3.Name = "tbPos3";
            this.tbPos3.Size = new System.Drawing.Size(58, 21);
            this.tbPos3.TabIndex = 5;
            this.tbPos3.TextChanged += new System.EventHandler(this.tbPos3_TextChanged);
            // 
            // tbPlayer3
            // 
            this.tbPlayer3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPlayer3.Location = new System.Drawing.Point(3, 63);
            this.tbPlayer3.Name = "tbPlayer3";
            this.tbPlayer3.Size = new System.Drawing.Size(215, 21);
            this.tbPlayer3.TabIndex = 4;
            this.tbPlayer3.TextChanged += new System.EventHandler(this.tbPlayer3_TextChanged);
            // 
            // tbPos2
            // 
            this.tbPos2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPos2.Location = new System.Drawing.Point(224, 33);
            this.tbPos2.Name = "tbPos2";
            this.tbPos2.Size = new System.Drawing.Size(58, 21);
            this.tbPos2.TabIndex = 3;
            this.tbPos2.TextChanged += new System.EventHandler(this.tbPos2_TextChanged);
            // 
            // tbPlayer2
            // 
            this.tbPlayer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPlayer2.Location = new System.Drawing.Point(3, 33);
            this.tbPlayer2.Name = "tbPlayer2";
            this.tbPlayer2.Size = new System.Drawing.Size(215, 21);
            this.tbPlayer2.TabIndex = 2;
            this.tbPlayer2.TextChanged += new System.EventHandler(this.tbPlayer2_TextChanged);
            // 
            // tbPlayer1
            // 
            this.tbPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPlayer1.Location = new System.Drawing.Point(3, 3);
            this.tbPlayer1.Name = "tbPlayer1";
            this.tbPlayer1.Size = new System.Drawing.Size(215, 21);
            this.tbPlayer1.TabIndex = 0;
            this.tbPlayer1.TextChanged += new System.EventHandler(this.tbPlayer1_TextChanged);
            // 
            // tbPos1
            // 
            this.tbPos1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPos1.Location = new System.Drawing.Point(224, 3);
            this.tbPos1.Name = "tbPos1";
            this.tbPos1.Size = new System.Drawing.Size(58, 21);
            this.tbPos1.TabIndex = 1;
            this.tbPos1.TextChanged += new System.EventHandler(this.tbPos1_TextChanged);
            // 
            // lbPartyStatus
            // 
            this.lbPartyStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPartyStatus.AutoSize = true;
            this.lbPartyStatus.ForeColor = System.Drawing.Color.Red;
            this.lbPartyStatus.Location = new System.Drawing.Point(699, 345);
            this.lbPartyStatus.Name = "lbPartyStatus";
            this.lbPartyStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPartyStatus.Size = new System.Drawing.Size(77, 12);
            this.lbPartyStatus.TabIndex = 7;
            this.lbPartyStatus.Text = "等待配置队伍";
            // 
            // lbPartyStatusTxt
            // 
            this.lbPartyStatusTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPartyStatusTxt.AutoSize = true;
            this.lbPartyStatusTxt.Location = new System.Drawing.Point(643, 345);
            this.lbPartyStatusTxt.Name = "lbPartyStatusTxt";
            this.lbPartyStatusTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPartyStatusTxt.Size = new System.Drawing.Size(59, 12);
            this.lbPartyStatusTxt.TabIndex = 6;
            this.lbPartyStatusTxt.Text = "设置状态:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lbTip2);
            this.groupBox2.Controls.Add(this.lbTip1);
            this.groupBox2.Controls.Add(this.tbLogPlayerName);
            this.groupBox2.Controls.Add(this.tbPostNamazuUrl);
            this.groupBox2.Controls.Add(this.tbTips);
            this.groupBox2.Location = new System.Drawing.Point(309, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 320);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "说明";
            // 
            // lbTip2
            // 
            this.lbTip2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTip2.AutoSize = true;
            this.lbTip2.Location = new System.Drawing.Point(6, 297);
            this.lbTip2.Name = "lbTip2";
            this.lbTip2.Size = new System.Drawing.Size(89, 12);
            this.lbTip2.TabIndex = 4;
            this.lbTip2.Text = "读取小队信息宏";
            // 
            // lbTip1
            // 
            this.lbTip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTip1.AutoSize = true;
            this.lbTip1.Location = new System.Drawing.Point(6, 271);
            this.lbTip1.Name = "lbTip1";
            this.lbTip1.Size = new System.Drawing.Size(89, 12);
            this.lbTip1.TabIndex = 3;
            this.lbTip1.Text = "鲶鱼精邮差地址";
            // 
            // tbLogPlayerName
            // 
            this.tbLogPlayerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLogPlayerName.Location = new System.Drawing.Point(99, 293);
            this.tbLogPlayerName.Name = "tbLogPlayerName";
            this.tbLogPlayerName.ReadOnly = true;
            this.tbLogPlayerName.Size = new System.Drawing.Size(368, 21);
            this.tbLogPlayerName.TabIndex = 1;
            this.tbLogPlayerName.Text = "/e DSRH {<1>:<2>:<3>:<4>:<5>:<6>:<7>:<8>}";
            // 
            // tbPostNamazuUrl
            // 
            this.tbPostNamazuUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPostNamazuUrl.Location = new System.Drawing.Point(99, 266);
            this.tbPostNamazuUrl.Name = "tbPostNamazuUrl";
            this.tbPostNamazuUrl.Size = new System.Drawing.Size(368, 21);
            this.tbPostNamazuUrl.TabIndex = 2;
            this.tbPostNamazuUrl.Text = "http://127.0.0.1:2019/command";
            this.tbPostNamazuUrl.TextChanged += new System.EventHandler(this.tbPostNamazuUrl_TextChanged);
            // 
            // tbTips
            // 
            this.tbTips.AutoSize = true;
            this.tbTips.Location = new System.Drawing.Point(6, 17);
            this.tbTips.Name = "tbTips";
            this.tbTips.Size = new System.Drawing.Size(65, 12);
            this.tbTips.TabIndex = 0;
            this.tbTips.Text = "绝龙诗工具";
            // 
            // btnPartyMarkTest
            // 
            this.btnPartyMarkTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPartyMarkTest.Location = new System.Drawing.Point(84, 339);
            this.btnPartyMarkTest.Name = "btnPartyMarkTest";
            this.btnPartyMarkTest.Size = new System.Drawing.Size(75, 23);
            this.btnPartyMarkTest.TabIndex = 1;
            this.btnPartyMarkTest.Text = "测试标记";
            this.btnPartyMarkTest.UseVisualStyleBackColor = true;
            this.btnPartyMarkTest.Click += new System.EventHandler(this.btnPartyMarkTest_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.layoutP2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(786, 368);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "P2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // layoutP2
            // 
            this.layoutP2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutP2.Controls.Add(this.cbP2Reminder1);
            this.layoutP2.Controls.Add(this.lbP2Reminder1);
            this.layoutP2.Controls.Add(this.cbP2Reminder2);
            this.layoutP2.Controls.Add(this.lbP2Reminder2);
            this.layoutP2.Controls.Add(this.cbP2Reminder3);
            this.layoutP2.Controls.Add(this.lbP2Reminder3);
            this.layoutP2.Controls.Add(this.cbP2Reminder4);
            this.layoutP2.Controls.Add(this.lbP2Reminder4);
            this.layoutP2.Controls.Add(this.cbP2Reminder5);
            this.layoutP2.Controls.Add(this.lbP2Reminder5);
            this.layoutP2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.layoutP2.Location = new System.Drawing.Point(6, 6);
            this.layoutP2.Name = "layoutP2";
            this.layoutP2.Size = new System.Drawing.Size(774, 352);
            this.layoutP2.TabIndex = 2;
            // 
            // cbP2Reminder1
            // 
            this.cbP2Reminder1.AutoSize = true;
            this.cbP2Reminder1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbP2Reminder1.Location = new System.Drawing.Point(3, 3);
            this.cbP2Reminder1.Name = "cbP2Reminder1";
            this.cbP2Reminder1.Size = new System.Drawing.Size(142, 16);
            this.cbP2Reminder1.TabIndex = 0;
            this.cbP2Reminder1.Text = "一运: 穿天点名提醒";
            this.cbP2Reminder1.UseVisualStyleBackColor = true;
            this.cbP2Reminder1.CheckedChanged += new System.EventHandler(this.cbP2Reminder1_CheckedChanged);
            // 
            // lbP2Reminder1
            // 
            this.lbP2Reminder1.AutoSize = true;
            this.lbP2Reminder1.Location = new System.Drawing.Point(20, 22);
            this.lbP2Reminder1.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lbP2Reminder1.Name = "lbP2Reminder1";
            this.lbP2Reminder1.Size = new System.Drawing.Size(161, 12);
            this.lbP2Reminder1.TabIndex = 2;
            this.lbP2Reminder1.Text = "自动标记穿天AOE点名的3个人";
            // 
            // cbP2Reminder2
            // 
            this.cbP2Reminder2.AutoSize = true;
            this.cbP2Reminder2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbP2Reminder2.Location = new System.Drawing.Point(3, 44);
            this.cbP2Reminder2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.cbP2Reminder2.Name = "cbP2Reminder2";
            this.cbP2Reminder2.Size = new System.Drawing.Size(116, 16);
            this.cbP2Reminder2.TabIndex = 1;
            this.cbP2Reminder2.Text = "一运: 分摊提醒";
            this.cbP2Reminder2.UseVisualStyleBackColor = true;
            this.cbP2Reminder2.CheckedChanged += new System.EventHandler(this.cbP2Reminder2_CheckedChanged);
            // 
            // lbP2Reminder2
            // 
            this.lbP2Reminder2.AutoSize = true;
            this.lbP2Reminder2.Location = new System.Drawing.Point(20, 63);
            this.lbP2Reminder2.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lbP2Reminder2.Name = "lbP2Reminder2";
            this.lbP2Reminder2.Size = new System.Drawing.Size(143, 12);
            this.lbP2Reminder2.TabIndex = 3;
            this.lbP2Reminder2.Text = "自动标记需要分摊的3个人";
            // 
            // cbP2Reminder3
            // 
            this.cbP2Reminder3.AutoSize = true;
            this.cbP2Reminder3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbP2Reminder3.Location = new System.Drawing.Point(3, 85);
            this.cbP2Reminder3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.cbP2Reminder3.Name = "cbP2Reminder3";
            this.cbP2Reminder3.Size = new System.Drawing.Size(144, 16);
            this.cbP2Reminder3.TabIndex = 4;
            this.cbP2Reminder3.Text = "二运: D1D2换位提醒";
            this.cbP2Reminder3.UseVisualStyleBackColor = true;
            this.cbP2Reminder3.CheckedChanged += new System.EventHandler(this.cbP2Reminder3_CheckedChanged);
            // 
            // lbP2Reminder3
            // 
            this.lbP2Reminder3.AutoSize = true;
            this.lbP2Reminder3.Location = new System.Drawing.Point(20, 104);
            this.lbP2Reminder3.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lbP2Reminder3.Name = "lbP2Reminder3";
            this.lbP2Reminder3.Size = new System.Drawing.Size(275, 12);
            this.lbP2Reminder3.TabIndex = 5;
            this.lbP2Reminder3.Text = "如果一组同时点名, 会标记另一组的D1/D2进行补位";
            // 
            // cbP2Reminder4
            // 
            this.cbP2Reminder4.AutoSize = true;
            this.cbP2Reminder4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbP2Reminder4.Location = new System.Drawing.Point(3, 126);
            this.cbP2Reminder4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.cbP2Reminder4.Name = "cbP2Reminder4";
            this.cbP2Reminder4.Size = new System.Drawing.Size(168, 16);
            this.cbP2Reminder4.TabIndex = 6;
            this.cbP2Reminder4.Text = "二运: 陨石点名换位提醒";
            this.cbP2Reminder4.UseVisualStyleBackColor = true;
            this.cbP2Reminder4.CheckedChanged += new System.EventHandler(this.cbP2Reminder4_CheckedChanged);
            // 
            // lbP2Reminder4
            // 
            this.lbP2Reminder4.AutoSize = true;
            this.lbP2Reminder4.Location = new System.Drawing.Point(20, 145);
            this.lbP2Reminder4.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lbP2Reminder4.Name = "lbP2Reminder4";
            this.lbP2Reminder4.Size = new System.Drawing.Size(275, 12);
            this.lbP2Reminder4.TabIndex = 7;
            this.lbP2Reminder4.Text = "自动标记2个点名陨石的人, 需要换位时会进行提醒\r\n";
            // 
            // cbP2Reminder5
            // 
            this.cbP2Reminder5.AutoSize = true;
            this.cbP2Reminder5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbP2Reminder5.Location = new System.Drawing.Point(3, 167);
            this.cbP2Reminder5.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.cbP2Reminder5.Name = "cbP2Reminder5";
            this.cbP2Reminder5.Size = new System.Drawing.Size(150, 16);
            this.cbP2Reminder5.TabIndex = 8;
            this.cbP2Reminder5.Text = "二运: 120度陨石提醒";
            this.cbP2Reminder5.UseVisualStyleBackColor = true;
            this.cbP2Reminder5.CheckedChanged += new System.EventHandler(this.cbP2Reminder5_CheckedChanged);
            // 
            // lbP2Reminder5
            // 
            this.lbP2Reminder5.AutoSize = true;
            this.lbP2Reminder5.Location = new System.Drawing.Point(20, 186);
            this.lbP2Reminder5.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lbP2Reminder5.Name = "lbP2Reminder5";
            this.lbP2Reminder5.Size = new System.Drawing.Size(155, 12);
            this.lbP2Reminder5.TabIndex = 9;
            this.lbP2Reminder5.Text = "会提醒出现120度陨石的情况";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.layoutP3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(786, 368);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "P3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // layoutP3
            // 
            this.layoutP3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutP3.Controls.Add(this.cbP3Reminder1);
            this.layoutP3.Controls.Add(this.lbP3Reminder1);
            this.layoutP3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.layoutP3.Location = new System.Drawing.Point(6, 6);
            this.layoutP3.Name = "layoutP3";
            this.layoutP3.Size = new System.Drawing.Size(774, 352);
            this.layoutP3.TabIndex = 3;
            // 
            // cbP3Reminder1
            // 
            this.cbP3Reminder1.AutoSize = true;
            this.cbP3Reminder1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbP3Reminder1.Location = new System.Drawing.Point(3, 3);
            this.cbP3Reminder1.Name = "cbP3Reminder1";
            this.cbP3Reminder1.Size = new System.Drawing.Size(115, 16);
            this.cbP3Reminder1.TabIndex = 0;
            this.cbP3Reminder1.Text = "多人塔换位提醒";
            this.cbP3Reminder1.UseVisualStyleBackColor = true;
            this.cbP3Reminder1.CheckedChanged += new System.EventHandler(this.cbP3Reminder1_CheckedChanged);
            // 
            // lbP3Reminder1
            // 
            this.lbP3Reminder1.AutoSize = true;
            this.lbP3Reminder1.Location = new System.Drawing.Point(20, 22);
            this.lbP3Reminder1.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lbP3Reminder1.Name = "lbP3Reminder1";
            this.lbP3Reminder1.Size = new System.Drawing.Size(125, 12);
            this.lbP3Reminder1.TabIndex = 2;
            this.lbP3Reminder1.Text = "自动标记需要换位的人";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.layoutP4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(786, 368);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "P4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // layoutP4
            // 
            this.layoutP4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutP4.Controls.Add(this.cbP4Reminder1);
            this.layoutP4.Controls.Add(this.lbP4Reminder1);
            this.layoutP4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.layoutP4.Location = new System.Drawing.Point(6, 6);
            this.layoutP4.Name = "layoutP4";
            this.layoutP4.Size = new System.Drawing.Size(774, 352);
            this.layoutP4.TabIndex = 2;
            // 
            // cbP4Reminder1
            // 
            this.cbP4Reminder1.AutoSize = true;
            this.cbP4Reminder1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbP4Reminder1.Location = new System.Drawing.Point(3, 3);
            this.cbP4Reminder1.Name = "cbP4Reminder1";
            this.cbP4Reminder1.Size = new System.Drawing.Size(128, 16);
            this.cbP4Reminder1.TabIndex = 0;
            this.cbP4Reminder1.Text = "第一次幻象冲提醒";
            this.cbP4Reminder1.UseVisualStyleBackColor = true;
            this.cbP4Reminder1.CheckedChanged += new System.EventHandler(this.cbP4Reminder1_CheckedChanged);
            // 
            // lbP4Reminder1
            // 
            this.lbP4Reminder1.AutoSize = true;
            this.lbP4Reminder1.Location = new System.Drawing.Point(20, 22);
            this.lbP4Reminder1.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lbP4Reminder1.Name = "lbP4Reminder1";
            this.lbP4Reminder1.Size = new System.Drawing.Size(149, 12);
            this.lbP4Reminder1.TabIndex = 2;
            this.lbP4Reminder1.Text = "自动标记第一次幻象冲的人";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.layoutP5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(786, 368);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "P5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // layoutP5
            // 
            this.layoutP5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutP5.Controls.Add(this.cbP5Reminder1);
            this.layoutP5.Controls.Add(this.lbP5Reminder1);
            this.layoutP5.Controls.Add(this.cbP5Reminder2);
            this.layoutP5.Controls.Add(this.lbP5Reminder2);
            this.layoutP5.Controls.Add(this.cbP5Reminder3);
            this.layoutP5.Controls.Add(this.lbP5Reminder3);
            this.layoutP5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.layoutP5.Location = new System.Drawing.Point(6, 6);
            this.layoutP5.Name = "layoutP5";
            this.layoutP5.Size = new System.Drawing.Size(774, 352);
            this.layoutP5.TabIndex = 1;
            // 
            // cbP5Reminder1
            // 
            this.cbP5Reminder1.AutoSize = true;
            this.cbP5Reminder1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbP5Reminder1.Location = new System.Drawing.Point(3, 3);
            this.cbP5Reminder1.Name = "cbP5Reminder1";
            this.cbP5Reminder1.Size = new System.Drawing.Size(155, 16);
            this.cbP5Reminder1.TabIndex = 0;
            this.cbP5Reminder1.Text = "一运: 雷光链点名提醒";
            this.cbP5Reminder1.UseVisualStyleBackColor = true;
            this.cbP5Reminder1.CheckedChanged += new System.EventHandler(this.cbP5Reminder1_CheckedChanged);
            // 
            // lbP5Reminder1
            // 
            this.lbP5Reminder1.AutoSize = true;
            this.lbP5Reminder1.Location = new System.Drawing.Point(20, 22);
            this.lbP5Reminder1.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lbP5Reminder1.Name = "lbP5Reminder1";
            this.lbP5Reminder1.Size = new System.Drawing.Size(131, 12);
            this.lbP5Reminder1.TabIndex = 2;
            this.lbP5Reminder1.Text = "自动标记雷点名的2个人";
            // 
            // cbP5Reminder2
            // 
            this.cbP5Reminder2.AutoSize = true;
            this.cbP5Reminder2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbP5Reminder2.Location = new System.Drawing.Point(3, 44);
            this.cbP5Reminder2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.cbP5Reminder2.Name = "cbP5Reminder2";
            this.cbP5Reminder2.Size = new System.Drawing.Size(142, 16);
            this.cbP5Reminder2.TabIndex = 1;
            this.cbP5Reminder2.Text = "二运: 死宣点名提醒";
            this.cbP5Reminder2.UseVisualStyleBackColor = true;
            this.cbP5Reminder2.CheckedChanged += new System.EventHandler(this.cbP5Reminder2_CheckedChanged);
            // 
            // lbP5Reminder2
            // 
            this.lbP5Reminder2.AutoSize = true;
            this.lbP5Reminder2.Location = new System.Drawing.Point(20, 63);
            this.lbP5Reminder2.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lbP5Reminder2.Name = "lbP5Reminder2";
            this.lbP5Reminder2.Size = new System.Drawing.Size(227, 12);
            this.lbP5Reminder2.TabIndex = 3;
            this.lbP5Reminder2.Text = "按照横排法, 按顺序标记4个死宣点名的人";
            // 
            // cbP5Reminder3
            // 
            this.cbP5Reminder3.AutoSize = true;
            this.cbP5Reminder3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbP5Reminder3.Location = new System.Drawing.Point(3, 85);
            this.cbP5Reminder3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.cbP5Reminder3.Name = "cbP5Reminder3";
            this.cbP5Reminder3.Size = new System.Drawing.Size(175, 16);
            this.cbP5Reminder3.TabIndex = 4;
            this.cbP5Reminder3.Text = "二运: 索尼拉线点名X提醒";
            this.cbP5Reminder3.UseVisualStyleBackColor = true;
            this.cbP5Reminder3.CheckedChanged += new System.EventHandler(this.cbP5Reminder3_CheckedChanged);
            // 
            // lbP5Reminder3
            // 
            this.lbP5Reminder3.AutoSize = true;
            this.lbP5Reminder3.Location = new System.Drawing.Point(20, 104);
            this.lbP5Reminder3.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lbP5Reminder3.Name = "lbP5Reminder3";
            this.lbP5Reminder3.Size = new System.Drawing.Size(137, 12);
            this.lbP5Reminder3.TabIndex = 5;
            this.lbP5Reminder3.Text = "自动标记2个头上为X的人";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.layoutP6);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(786, 368);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "P6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // layoutP6
            // 
            this.layoutP6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutP6.Controls.Add(this.cbP6Reminder1);
            this.layoutP6.Controls.Add(this.lbP6Reminder1);
            this.layoutP6.Controls.Add(this.cbP6Reminder2);
            this.layoutP6.Controls.Add(this.lbP6Reminder2);
            this.layoutP6.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.layoutP6.Location = new System.Drawing.Point(6, 6);
            this.layoutP6.Name = "layoutP6";
            this.layoutP6.Size = new System.Drawing.Size(774, 352);
            this.layoutP6.TabIndex = 0;
            // 
            // cbP6Reminder1
            // 
            this.cbP6Reminder1.AutoSize = true;
            this.cbP6Reminder1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbP6Reminder1.Location = new System.Drawing.Point(3, 3);
            this.cbP6Reminder1.Name = "cbP6Reminder1";
            this.cbP6Reminder1.Size = new System.Drawing.Size(102, 16);
            this.cbP6Reminder1.TabIndex = 0;
            this.cbP6Reminder1.Text = "邪念之炎提醒";
            this.cbP6Reminder1.UseVisualStyleBackColor = true;
            this.cbP6Reminder1.CheckedChanged += new System.EventHandler(this.cbP6Reminder1_CheckedChanged);
            // 
            // lbP6Reminder1
            // 
            this.lbP6Reminder1.AutoSize = true;
            this.lbP6Reminder1.Location = new System.Drawing.Point(20, 22);
            this.lbP6Reminder1.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lbP6Reminder1.Name = "lbP6Reminder1";
            this.lbP6Reminder1.Size = new System.Drawing.Size(137, 12);
            this.lbP6Reminder1.TabIndex = 2;
            this.lbP6Reminder1.Text = "十字火阶段自动标记点名";
            // 
            // cbP6Reminder2
            // 
            this.cbP6Reminder2.AutoSize = true;
            this.cbP6Reminder2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbP6Reminder2.Location = new System.Drawing.Point(3, 44);
            this.cbP6Reminder2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.cbP6Reminder2.Name = "cbP6Reminder2";
            this.cbP6Reminder2.Size = new System.Drawing.Size(76, 16);
            this.cbP6Reminder2.TabIndex = 1;
            this.cbP6Reminder2.Text = "传毒提醒";
            this.cbP6Reminder2.UseVisualStyleBackColor = true;
            this.cbP6Reminder2.CheckedChanged += new System.EventHandler(this.cbP6Reminder2_CheckedChanged);
            // 
            // lbP6Reminder2
            // 
            this.lbP6Reminder2.AutoSize = true;
            this.lbP6Reminder2.Location = new System.Drawing.Point(20, 63);
            this.lbP6Reminder2.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lbP6Reminder2.Name = "lbP6Reminder2";
            this.lbP6Reminder2.Size = new System.Drawing.Size(413, 12);
            this.lbP6Reminder2.TabIndex = 3;
            this.lbP6Reminder2.Text = "传毒时标记需要传毒的2个人, 传毒顺序: 毒DPS - MT - ST - D1/D2 - D2/D1";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.tbLog);
            this.tabPage7.Controls.Add(this.btnClearLog);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(786, 368);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "日志";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tbLog
            // 
            this.tbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLog.Location = new System.Drawing.Point(6, 6);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLog.Size = new System.Drawing.Size(774, 327);
            this.tbLog.TabIndex = 2;
            // 
            // btnClearLog
            // 
            this.btnClearLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearLog.Location = new System.Drawing.Point(6, 339);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(75, 23);
            this.btnClearLog.TabIndex = 1;
            this.btnClearLog.Text = "清空日志";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tabControl);
            this.Name = "SettingForm";
            this.Size = new System.Drawing.Size(800, 400);
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tbLayoutParty.ResumeLayout(false);
            this.tbLayoutParty.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.layoutP2.ResumeLayout(false);
            this.layoutP2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.layoutP3.ResumeLayout(false);
            this.layoutP3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.layoutP4.ResumeLayout(false);
            this.layoutP4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.layoutP5.ResumeLayout(false);
            this.layoutP5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.layoutP6.ResumeLayout(false);
            this.layoutP6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private Button btnClearLog;
        private TextBox tbLog;
        private Button btnPartyMarkTest;
        private FlowLayoutPanel layoutP6;
        private CheckBox cbP6Reminder1;
        private Label lbP6Reminder1;
        private CheckBox cbP6Reminder2;
        private Label lbP6Reminder2;
        private FlowLayoutPanel layoutP5;
        private CheckBox cbP5Reminder1;
        private Label lbP5Reminder1;
        private CheckBox cbP5Reminder2;
        private Label lbP5Reminder2;
        private CheckBox cbP5Reminder3;
        private Label lbP5Reminder3;
        private FlowLayoutPanel layoutP4;
        private CheckBox cbP4Reminder1;
        private Label lbP4Reminder1;
        private FlowLayoutPanel layoutP3;
        private CheckBox cbP3Reminder1;
        private Label lbP3Reminder1;
        private FlowLayoutPanel layoutP2;
        private CheckBox cbP2Reminder1;
        private Label lbP2Reminder1;
        private CheckBox cbP2Reminder2;
        private Label lbP2Reminder2;
        private CheckBox cbP2Reminder3;
        private Label lbP2Reminder3;
        private CheckBox cbP2Reminder4;
        private Label lbP2Reminder4;
        private CheckBox cbP2Reminder5;
        private Label lbP2Reminder5;
        private TableLayoutPanel tbLayoutParty;
        private TextBox tbPlayer1;
        private GroupBox groupBox1;
        private TextBox tbPos8;
        private TextBox tbPlayer8;
        private TextBox tbPos7;
        private TextBox tbPlayer7;
        private TextBox tbPos6;
        private TextBox tbPlayer6;
        private TextBox tbPos5;
        private TextBox tbPlayer5;
        private TextBox tbPos4;
        private TextBox tbPlayer4;
        private TextBox tbPos3;
        private TextBox tbPlayer3;
        private TextBox tbPos2;
        private TextBox tbPlayer2;
        private TextBox tbPos1;
        private GroupBox groupBox2;
        private TextBox tbLogPlayerName;
        private Label tbTips;
        private Label lbTip2;
        private Label lbTip1;
        private TextBox tbPostNamazuUrl;
        private CheckBox cbEnableTool;
        private Label lbPartyStatusTxt;
        private Label lbPartyStatus;
        private ComboBox cbOutputMode;
    }
}