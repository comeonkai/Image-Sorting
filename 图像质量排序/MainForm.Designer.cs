
//主窗口，其他窗口还没写
namespace UI
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("图片1", 13, 13);
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("图片2", 13, 13);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("图片3", 13, 13);
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("图片4", 13, 13);
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("文件夹", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            this.skinToolTip1 = new CCWin.SkinToolTip(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.imageButton6 = new LT.WinForm.ImageButton.ImageButton();
            this.imageButton5 = new LT.WinForm.ImageButton.ImageButton();
            this.imageButton4 = new LT.WinForm.ImageButton.ImageButton();
            this.imageButton3 = new LT.WinForm.ImageButton.ImageButton();
            this.imageButton2 = new LT.WinForm.ImageButton.ImageButton();
            this.imageButton1 = new LT.WinForm.ImageButton.ImageButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.imageButton13 = new LT.WinForm.ImageButton.ImageButton();
            this.imageButton12 = new LT.WinForm.ImageButton.ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.roundButton1 = new RoundButton.RoundButton();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.imageButton7 = new LT.WinForm.ImageButton.ImageButton();
            this.imageButton8 = new LT.WinForm.ImageButton.ImageButton();
            this.imageButton9 = new LT.WinForm.ImageButton.ImageButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageButton11 = new LT.WinForm.ImageButton.ImageButton();
            this.imageButton10 = new LT.WinForm.ImageButton.ImageButton();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.imageButton14 = new LT.WinForm.ImageButton.ImageButton();
            this.imageButton15 = new LT.WinForm.ImageButton.ImageButton();
            this.imageButton16 = new LT.WinForm.ImageButton.ImageButton();
            this.imageButton17 = new LT.WinForm.ImageButton.ImageButton();
            this.imageButton18 = new LT.WinForm.ImageButton.ImageButton();
            this.imageButton19 = new LT.WinForm.ImageButton.ImageButton();
            this.imageButton20 = new LT.WinForm.ImageButton.ImageButton();
            this.imageButton21 = new LT.WinForm.ImageButton.ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinToolTip1
            // 
            this.skinToolTip1.AutoPopDelay = 5000;
            this.skinToolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(200)))), ((int)(((byte)(249)))));
            this.skinToolTip1.InitialDelay = 500;
            this.skinToolTip1.OwnerDraw = true;
            this.skinToolTip1.ReshowDelay = 800;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(200)))), ((int)(((byte)(249)))));
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(4, 28);
            this.splitContainer1.MinimumSize = new System.Drawing.Size(1100, 600);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1192, 600);
            this.splitContainer1.SplitterDistance = 83;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.imageButton6, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.imageButton5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.imageButton4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.imageButton3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.imageButton2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.imageButton1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1186, 86);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // imageButton6
            // 
            this.imageButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.imageButton6.BackgroundImage = global::UI.Properties.Resources.btn6;
            this.imageButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageButton6.ButtonImage = global::UI.Properties.Resources.btn6;
            this.imageButton6.ButtonText = "";
            this.imageButton6.Location = new System.Drawing.Point(886, 0);
            this.imageButton6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.imageButton6.MouseClickImage = null;
            this.imageButton6.MouseOverImage = global::UI.Properties.Resources.button6;
            this.imageButton6.Name = "imageButton6";
            this.imageButton6.Size = new System.Drawing.Size(299, 86);
            this.imageButton6.TabIndex = 5;
            this.imageButton6.Load += new System.EventHandler(this.imageButton6_Load);
            // 
            // imageButton5
            // 
            this.imageButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.imageButton5.BackgroundImage = global::UI.Properties.Resources.btn5;
            this.imageButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageButton5.ButtonImage = global::UI.Properties.Resources.btn5;
            this.imageButton5.ButtonText = "";
            this.imageButton5.Location = new System.Drawing.Point(709, 0);
            this.imageButton5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.imageButton5.MouseClickImage = null;
            this.imageButton5.MouseOverImage = global::UI.Properties.Resources.button5;
            this.imageButton5.Name = "imageButton5";
            this.imageButton5.Size = new System.Drawing.Size(175, 86);
            this.imageButton5.TabIndex = 4;
            this.imageButton5.Click += new LT.WinForm.ImageButton.ImageButton.ClickEventHandler(this.imageButton5_Click);
            this.imageButton5.Load += new System.EventHandler(this.imageButton5_Load);
            // 
            // imageButton4
            // 
            this.imageButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.imageButton4.BackgroundImage = global::UI.Properties.Resources.btn4;
            this.imageButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageButton4.ButtonImage = global::UI.Properties.Resources.btn4;
            this.imageButton4.ButtonText = "";
            this.imageButton4.Location = new System.Drawing.Point(532, 0);
            this.imageButton4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.imageButton4.MouseClickImage = null;
            this.imageButton4.MouseOverImage = global::UI.Properties.Resources.button4;
            this.imageButton4.Name = "imageButton4";
            this.imageButton4.Size = new System.Drawing.Size(175, 86);
            this.imageButton4.TabIndex = 3;
            this.imageButton4.Click += new LT.WinForm.ImageButton.ImageButton.ClickEventHandler(this.imageButton4_Click);
            this.imageButton4.Load += new System.EventHandler(this.imageButton4_Load);
            // 
            // imageButton3
            // 
            this.imageButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.imageButton3.BackgroundImage = global::UI.Properties.Resources.btn3;
            this.imageButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageButton3.ButtonImage = global::UI.Properties.Resources.btn3;
            this.imageButton3.ButtonText = "";
            this.imageButton3.Location = new System.Drawing.Point(355, 0);
            this.imageButton3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.imageButton3.MouseClickImage = null;
            this.imageButton3.MouseOverImage = global::UI.Properties.Resources.button3;
            this.imageButton3.Name = "imageButton3";
            this.imageButton3.Size = new System.Drawing.Size(175, 86);
            this.imageButton3.TabIndex = 2;
            this.imageButton3.Click += new LT.WinForm.ImageButton.ImageButton.ClickEventHandler(this.imageButton3_Click);
            this.imageButton3.Load += new System.EventHandler(this.imageButton3_Load);
            // 
            // imageButton2
            // 
            this.imageButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.imageButton2.BackgroundImage = global::UI.Properties.Resources.btn2;
            this.imageButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageButton2.ButtonImage = global::UI.Properties.Resources.btn2;
            this.imageButton2.ButtonText = "";
            this.imageButton2.Location = new System.Drawing.Point(178, 0);
            this.imageButton2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.imageButton2.MouseClickImage = null;
            this.imageButton2.MouseOverImage = global::UI.Properties.Resources.button2;
            this.imageButton2.Name = "imageButton2";
            this.imageButton2.Size = new System.Drawing.Size(175, 86);
            this.imageButton2.TabIndex = 1;
            this.imageButton2.Click += new LT.WinForm.ImageButton.ImageButton.ClickEventHandler(this.imageButton2_Click);
            this.imageButton2.Load += new System.EventHandler(this.imageButton2_Load);
            // 
            // imageButton1
            // 
            this.imageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.imageButton1.BackgroundImage = global::UI.Properties.Resources.btn1;
            this.imageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageButton1.ButtonImage = global::UI.Properties.Resources.btn1;
            this.imageButton1.ButtonText = "";
            this.imageButton1.Location = new System.Drawing.Point(1, 0);
            this.imageButton1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.imageButton1.MouseClickImage = null;
            this.imageButton1.MouseOverImage = global::UI.Properties.Resources.button1;
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.Size = new System.Drawing.Size(175, 86);
            this.imageButton1.TabIndex = 0;
            this.imageButton1.Click += new LT.WinForm.ImageButton.ImageButton.ClickEventHandler(this.imageButton1_Click);
            this.imageButton1.Load += new System.EventHandler(this.imageButton1_Load);
            this.imageButton1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imageButton1_MouseClick);
            this.imageButton1.MouseLeave += new System.EventHandler(this.imageButton1_MouseLeave_1);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(191)))), ((int)(((byte)(237)))));
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(200)))), ((int)(((byte)(249)))));
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel8);
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel7);
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel6);
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel5);
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel4);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.roundButton1);
            this.splitContainer2.Panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            this.splitContainer2.Panel1.Resize += new System.EventHandler(this.splitContainer2_Panel1_Resize);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer2.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel2_Paint);
            this.splitContainer2.Size = new System.Drawing.Size(1192, 505);
            this.splitContainer2.SplitterDistance = 905;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer2_SplitterMoved);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.imageButton13, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.imageButton12, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(177, 160);
            this.tableLayoutPanel4.TabIndex = 2;
            this.tableLayoutPanel4.Visible = false;
            this.tableLayoutPanel4.AutoSizeChanged += new System.EventHandler(this.tableLayoutPanel4_AutoSizeChanged);
            this.tableLayoutPanel4.ParentChanged += new System.EventHandler(this.tableLayoutPanel4_ParentChanged);
            // 
            // imageButton13
            // 
            this.imageButton13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButton13.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.imageButton13.BackgroundImage = global::UI.Properties.Resources.btn1;
            this.imageButton13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageButton13.ButtonImage = global::UI.Properties.Resources.btn1;
            this.imageButton13.ButtonText = "";
            this.imageButton13.Location = new System.Drawing.Point(1, 80);
            this.imageButton13.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.imageButton13.MouseClickImage = null;
            this.imageButton13.MouseOverImage = global::UI.Properties.Resources.button1;
            this.imageButton13.Name = "imageButton13";
            this.imageButton13.Size = new System.Drawing.Size(175, 80);
            this.imageButton13.TabIndex = 2;
            // 
            // imageButton12
            // 
            this.imageButton12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButton12.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.imageButton12.BackgroundImage = global::UI.Properties.Resources.btn1;
            this.imageButton12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageButton12.ButtonImage = global::UI.Properties.Resources.btn1;
            this.imageButton12.ButtonText = "";
            this.imageButton12.Location = new System.Drawing.Point(1, 0);
            this.imageButton12.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.imageButton12.MouseClickImage = null;
            this.imageButton12.MouseOverImage = global::UI.Properties.Resources.button1;
            this.imageButton12.Name = "imageButton12";
            this.imageButton12.Size = new System.Drawing.Size(175, 80);
            this.imageButton12.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(278, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "添加图片";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // roundButton1
            // 
            this.roundButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roundButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton1.Diameter = 197;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.ImageEnter = null;
            this.roundButton1.ImageIndex = 0;
            this.roundButton1.ImageList = this.imageList2;
            this.roundButton1.ImageNormal = null;
            this.roundButton1.Location = new System.Drawing.Point(257, 122);
            this.roundButton1.Margin = new System.Windows.Forms.Padding(2);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(197, 197);
            this.roundButton1.TabIndex = 0;
            this.roundButton1.UseVisualStyleBackColor = true;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click_1);
            this.roundButton1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.roundButton1_KeyDown);
            this.roundButton1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.roundButton1_KeyPress);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "addImage2.jpg");
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.Controls.Add(this.imageButton7, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.imageButton8, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.imageButton9, 3, 0);
            this.tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 435);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(295, 35);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // imageButton7
            // 
            this.imageButton7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButton7.AutoSize = true;
            this.imageButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.imageButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageButton7.ButtonImage = global::UI.Properties.Resources.addImage;
            this.imageButton7.ButtonText = "";
            this.imageButton7.Location = new System.Drawing.Point(226, 3);
            this.imageButton7.MouseClickImage = null;
            this.imageButton7.MouseOverImage = global::UI.Properties.Resources.addImage;
            this.imageButton7.Name = "imageButton7";
            this.imageButton7.Size = new System.Drawing.Size(29, 29);
            this.imageButton7.TabIndex = 0;
            this.imageButton7.Load += new System.EventHandler(this.imageButton7_Load);
            // 
            // imageButton8
            // 
            this.imageButton8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButton8.AutoSize = true;
            this.imageButton8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.imageButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageButton8.ButtonImage = global::UI.Properties.Resources.addFolder;
            this.imageButton8.ButtonText = "";
            this.imageButton8.Location = new System.Drawing.Point(191, 3);
            this.imageButton8.MouseClickImage = null;
            this.imageButton8.MouseOverImage = global::UI.Properties.Resources.addFolder_hight;
            this.imageButton8.Name = "imageButton8";
            this.imageButton8.Size = new System.Drawing.Size(29, 29);
            this.imageButton8.TabIndex = 1;
            this.imageButton8.Load += new System.EventHandler(this.imageButton8_Load);
            // 
            // imageButton9
            // 
            this.imageButton9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButton9.AutoSize = true;
            this.imageButton9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.imageButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageButton9.ButtonImage = global::UI.Properties.Resources.delete;
            this.imageButton9.ButtonText = "";
            this.imageButton9.Location = new System.Drawing.Point(261, 3);
            this.imageButton9.MouseClickImage = null;
            this.imageButton9.MouseOverImage = global::UI.Properties.Resources.delete;
            this.imageButton9.Name = "imageButton9";
            this.imageButton9.Size = new System.Drawing.Size(31, 29);
            this.imageButton9.TabIndex = 2;
            this.imageButton9.Load += new System.EventHandler(this.imageButton9_Load);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.treeView1, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(295, 467);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(0);
            this.treeView1.Name = "treeView1";
            treeNode6.ForeColor = System.Drawing.Color.White;
            treeNode6.ImageIndex = 13;
            treeNode6.Name = "node1";
            treeNode6.SelectedImageIndex = 13;
            treeNode6.Text = "图片1";
            treeNode7.ForeColor = System.Drawing.Color.White;
            treeNode7.ImageIndex = 13;
            treeNode7.Name = "node2";
            treeNode7.SelectedImageIndex = 13;
            treeNode7.Text = "图片2";
            treeNode8.ForeColor = System.Drawing.Color.White;
            treeNode8.ImageIndex = 13;
            treeNode8.Name = "node3";
            treeNode8.SelectedImageIndex = 13;
            treeNode8.Text = "图片3";
            treeNode9.ForeColor = System.Drawing.Color.White;
            treeNode9.ImageIndex = 13;
            treeNode9.Name = "node4";
            treeNode9.SelectedImageIndex = 13;
            treeNode9.Text = "图片4";
            treeNode10.ForeColor = System.Drawing.Color.White;
            treeNode10.Name = "Folder";
            treeNode10.NodeFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            treeNode10.Text = "文件夹";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.ShowLines = false;
            this.treeView1.Size = new System.Drawing.Size(295, 434);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect_2);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "addFolder.png");
            this.imageList1.Images.SetKeyName(1, "addImage.png");
            this.imageList1.Images.SetKeyName(2, "addImage2.jpg");
            this.imageList1.Images.SetKeyName(3, "check.png");
            this.imageList1.Images.SetKeyName(4, "clear.png");
            this.imageList1.Images.SetKeyName(5, "close.png");
            this.imageList1.Images.SetKeyName(6, "comparison.png");
            this.imageList1.Images.SetKeyName(7, "compress.png");
            this.imageList1.Images.SetKeyName(8, "delete.png");
            this.imageList1.Images.SetKeyName(9, "folder.png");
            this.imageList1.Images.SetKeyName(10, "ImageSort.jpg");
            this.imageList1.Images.SetKeyName(11, "maximize.png");
            this.imageList1.Images.SetKeyName(12, "minimize.png");
            this.imageList1.Images.SetKeyName(13, "optimization.png");
            this.imageList1.Images.SetKeyName(14, "person.png");
            this.imageList1.Images.SetKeyName(15, "search.png");
            this.imageList1.Images.SetKeyName(16, "settings.png");
            // 
            // imageButton11
            // 
            this.imageButton11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButton11.ButtonImage = global::UI.Properties.Resources.search;
            this.imageButton11.ButtonText = "";
            this.imageButton11.Location = new System.Drawing.Point(1029, 3);
            this.imageButton11.MouseClickImage = null;
            this.imageButton11.MouseOverImage = global::UI.Properties.Resources.search;
            this.imageButton11.Name = "imageButton11";
            this.imageButton11.Size = new System.Drawing.Size(25, 17);
            this.imageButton11.TabIndex = 2;
            this.imageButton11.Load += new System.EventHandler(this.imageButton11_Load);
            // 
            // imageButton10
            // 
            this.imageButton10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButton10.ButtonImage = global::UI.Properties.Resources.settings;
            this.imageButton10.ButtonText = "";
            this.imageButton10.Location = new System.Drawing.Point(1063, 3);
            this.imageButton10.MouseClickImage = null;
            this.imageButton10.MouseOverImage = global::UI.Properties.Resources.settings;
            this.imageButton10.Name = "imageButton10";
            this.imageButton10.Size = new System.Drawing.Size(25, 17);
            this.imageButton10.TabIndex = 1;
            this.imageButton10.Load += new System.EventHandler(this.imageButton10_Load);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.imageButton15, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.imageButton14, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(181, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(175, 157);
            this.tableLayoutPanel5.TabIndex = 3;
            this.tableLayoutPanel5.Visible = false;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.imageButton17, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.imageButton16, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(358, 0);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(175, 157);
            this.tableLayoutPanel6.TabIndex = 4;
            this.tableLayoutPanel6.Visible = false;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.imageButton19, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.imageButton18, 0, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(535, 0);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(175, 160);
            this.tableLayoutPanel7.TabIndex = 4;
            this.tableLayoutPanel7.Visible = false;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.imageButton21, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.imageButton20, 0, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(712, 0);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(175, 160);
            this.tableLayoutPanel8.TabIndex = 5;
            this.tableLayoutPanel8.Visible = false;
            // 
            // imageButton14
            // 
            this.imageButton14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButton14.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.imageButton14.BackgroundImage = global::UI.Properties.Resources.btn2;
            this.imageButton14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageButton14.ButtonImage = global::UI.Properties.Resources.btn2;
            this.imageButton14.ButtonText = "";
            this.imageButton14.Location = new System.Drawing.Point(1, 0);
            this.imageButton14.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.imageButton14.MouseClickImage = null;
            this.imageButton14.MouseOverImage = global::UI.Properties.Resources.button2;
            this.imageButton14.Name = "imageButton14";
            this.imageButton14.Size = new System.Drawing.Size(173, 78);
            this.imageButton14.TabIndex = 2;
            // 
            // imageButton15
            // 
            this.imageButton15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButton15.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.imageButton15.BackgroundImage = global::UI.Properties.Resources.btn2;
            this.imageButton15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageButton15.ButtonImage = global::UI.Properties.Resources.btn2;
            this.imageButton15.ButtonText = "";
            this.imageButton15.Location = new System.Drawing.Point(1, 78);
            this.imageButton15.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.imageButton15.MouseClickImage = null;
            this.imageButton15.MouseOverImage = global::UI.Properties.Resources.button2;
            this.imageButton15.Name = "imageButton15";
            this.imageButton15.Size = new System.Drawing.Size(173, 79);
            this.imageButton15.TabIndex = 3;
            // 
            // imageButton16
            // 
            this.imageButton16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButton16.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.imageButton16.BackgroundImage = global::UI.Properties.Resources.btn3;
            this.imageButton16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageButton16.ButtonImage = global::UI.Properties.Resources.btn3;
            this.imageButton16.ButtonText = "";
            this.imageButton16.Location = new System.Drawing.Point(1, 0);
            this.imageButton16.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.imageButton16.MouseClickImage = null;
            this.imageButton16.MouseOverImage = global::UI.Properties.Resources.button3;
            this.imageButton16.Name = "imageButton16";
            this.imageButton16.Size = new System.Drawing.Size(173, 78);
            this.imageButton16.TabIndex = 3;
            // 
            // imageButton17
            // 
            this.imageButton17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButton17.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.imageButton17.BackgroundImage = global::UI.Properties.Resources.btn3;
            this.imageButton17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageButton17.ButtonImage = global::UI.Properties.Resources.btn3;
            this.imageButton17.ButtonText = "";
            this.imageButton17.Location = new System.Drawing.Point(1, 78);
            this.imageButton17.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.imageButton17.MouseClickImage = null;
            this.imageButton17.MouseOverImage = global::UI.Properties.Resources.button3;
            this.imageButton17.Name = "imageButton17";
            this.imageButton17.Size = new System.Drawing.Size(173, 79);
            this.imageButton17.TabIndex = 4;
            // 
            // imageButton18
            // 
            this.imageButton18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButton18.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.imageButton18.BackgroundImage = global::UI.Properties.Resources.btn4;
            this.imageButton18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageButton18.ButtonImage = global::UI.Properties.Resources.btn4;
            this.imageButton18.ButtonText = "";
            this.imageButton18.Location = new System.Drawing.Point(1, 0);
            this.imageButton18.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.imageButton18.MouseClickImage = null;
            this.imageButton18.MouseOverImage = global::UI.Properties.Resources.button4;
            this.imageButton18.Name = "imageButton18";
            this.imageButton18.Size = new System.Drawing.Size(173, 80);
            this.imageButton18.TabIndex = 4;
            // 
            // imageButton19
            // 
            this.imageButton19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButton19.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.imageButton19.BackgroundImage = global::UI.Properties.Resources.btn4;
            this.imageButton19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageButton19.ButtonImage = global::UI.Properties.Resources.btn4;
            this.imageButton19.ButtonText = "";
            this.imageButton19.Location = new System.Drawing.Point(1, 80);
            this.imageButton19.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.imageButton19.MouseClickImage = null;
            this.imageButton19.MouseOverImage = global::UI.Properties.Resources.button4;
            this.imageButton19.Name = "imageButton19";
            this.imageButton19.Size = new System.Drawing.Size(173, 80);
            this.imageButton19.TabIndex = 5;
            // 
            // imageButton20
            // 
            this.imageButton20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButton20.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.imageButton20.BackgroundImage = global::UI.Properties.Resources.btn5;
            this.imageButton20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageButton20.ButtonImage = global::UI.Properties.Resources.btn5;
            this.imageButton20.ButtonText = "";
            this.imageButton20.Location = new System.Drawing.Point(1, 0);
            this.imageButton20.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.imageButton20.MouseClickImage = null;
            this.imageButton20.MouseOverImage = global::UI.Properties.Resources.button5;
            this.imageButton20.Name = "imageButton20";
            this.imageButton20.Size = new System.Drawing.Size(173, 80);
            this.imageButton20.TabIndex = 5;
            // 
            // imageButton21
            // 
            this.imageButton21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButton21.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.imageButton21.BackgroundImage = global::UI.Properties.Resources.btn5;
            this.imageButton21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageButton21.ButtonImage = global::UI.Properties.Resources.btn5;
            this.imageButton21.ButtonText = "";
            this.imageButton21.Location = new System.Drawing.Point(1, 80);
            this.imageButton21.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.imageButton21.MouseClickImage = null;
            this.imageButton21.MouseOverImage = global::UI.Properties.Resources.button5;
            this.imageButton21.Name = "imageButton21";
            this.imageButton21.Size = new System.Drawing.Size(173, 80);
            this.imageButton21.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.imageButton11);
            this.Controls.Add(this.imageButton10);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "MainForm";
            this.Text = "";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinToolTip skinToolTip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ImageList imageList1;
        private RoundButton.RoundButton roundButton1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private LT.WinForm.ImageButton.ImageButton imageButton1;
        private LT.WinForm.ImageButton.ImageButton imageButton6;
        private LT.WinForm.ImageButton.ImageButton imageButton5;
        private LT.WinForm.ImageButton.ImageButton imageButton4;
        private LT.WinForm.ImageButton.ImageButton imageButton3;
        private LT.WinForm.ImageButton.ImageButton imageButton2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private LT.WinForm.ImageButton.ImageButton imageButton7;
        private LT.WinForm.ImageButton.ImageButton imageButton8;
        private LT.WinForm.ImageButton.ImageButton imageButton9;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private LT.WinForm.ImageButton.ImageButton imageButton10;
        private LT.WinForm.ImageButton.ImageButton imageButton11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private LT.WinForm.ImageButton.ImageButton imageButton13;
        private LT.WinForm.ImageButton.ImageButton imageButton12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private LT.WinForm.ImageButton.ImageButton imageButton21;
        private LT.WinForm.ImageButton.ImageButton imageButton20;
        private LT.WinForm.ImageButton.ImageButton imageButton19;
        private LT.WinForm.ImageButton.ImageButton imageButton18;
        private LT.WinForm.ImageButton.ImageButton imageButton17;
        private LT.WinForm.ImageButton.ImageButton imageButton16;
        private LT.WinForm.ImageButton.ImageButton imageButton15;
        private LT.WinForm.ImageButton.ImageButton imageButton14;

    }
}

