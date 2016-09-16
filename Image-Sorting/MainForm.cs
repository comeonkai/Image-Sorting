using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;
using System.Threading;

//界面事件函数，包括各个点击事件函数，有待补全
namespace UI
{
    public partial class MainForm :CCSkinMain
    {
        public MainForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(ThreadFuntion); //多线程画界面控件，实现动态调整大小
            thread.IsBackground = true;
            thread.Start();
        }

        private void ThreadFuntion()
        {
            while (true)
            {
                this.tableLayoutPanel4.Location = new Point(0, 0);
                this.tableLayoutPanel4.Width = (int)(this.splitContainer2.Width / 6.65);
                this.tableLayoutPanel5.Location = new Point((int)(this.splitContainer2.Width / 6.65), 0);
                this.tableLayoutPanel5.Width = (int)(this.splitContainer2.Width / 6.65);
                this.tableLayoutPanel6.Location = new Point((int)(this.splitContainer2.Width / 3.325), 0);
                this.tableLayoutPanel6.Width = (int)(this.splitContainer2.Width / 6.65);
                this.tableLayoutPanel7.Location = new Point((int)(this.splitContainer2.Width / 2.225), 0);
                this.tableLayoutPanel7.Width = (int)(this.splitContainer2.Width / 6.65);
                this.tableLayoutPanel8.Location = new Point((int)(this.splitContainer2.Width / 1.675), 0);
                this.tableLayoutPanel8.Width = (int)(this.splitContainer2.Width / 6.65);
            }
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
        }

        private void skinTreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
        }

        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void roundButton1_Click_1(object sender, EventArgs e)
        {
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void imageButton1_Load(object sender, EventArgs e)
        {
        }

        private void imageButton2_Load(object sender, EventArgs e)
        {
        }

        private void imageButton3_Load(object sender, EventArgs e)
        {
        }

        private void imageButton4_Load(object sender, EventArgs e)
        {
        }

        private void imageButton5_Load(object sender, EventArgs e)
        {
        }

        private void imageButton6_Load(object sender, EventArgs e)
        {
        }

        private void roundButton1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void roundButton1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void treeView1_AfterSelect_2(object sender, TreeViewEventArgs e)
        {
        }

        private void imageButton8_Load(object sender, EventArgs e)
        {
        }

        private void imageButton7_Load(object sender, EventArgs e)
        {
        }

        private void imageButton9_Load(object sender, EventArgs e)
        {
        }

        private void imageButton11_Load(object sender, EventArgs e)
        {

        }
        private void imageButton10_Load(object sender, EventArgs e)
        {

        }

        private void imageButton1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel4.Visible = !tableLayoutPanel4.Visible;
            tableLayoutPanel5.Visible = false;
            tableLayoutPanel6.Visible = false;
            tableLayoutPanel7.Visible = false;
            tableLayoutPanel8.Visible = false;
        }

        private void imageButton2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel5.Visible = !tableLayoutPanel5.Visible;
            tableLayoutPanel4.Visible = false;
            tableLayoutPanel6.Visible = false;
            tableLayoutPanel7.Visible = false;
            tableLayoutPanel8.Visible = false;
        }

        private void imageButton3_Click(object sender, EventArgs e)
        {
            tableLayoutPanel6.Visible = !tableLayoutPanel6.Visible;
            tableLayoutPanel4.Visible = false;
            tableLayoutPanel5.Visible = false;
            tableLayoutPanel7.Visible = false;
            tableLayoutPanel8.Visible = false;
        }

        private void imageButton4_Click(object sender, EventArgs e)
        {
            tableLayoutPanel7.Visible = !tableLayoutPanel7.Visible;
            tableLayoutPanel4.Visible = false;
            tableLayoutPanel5.Visible = false;
            tableLayoutPanel6.Visible = false;
            tableLayoutPanel8.Visible = false;
        }

        private void imageButton5_Click(object sender, EventArgs e)
        {
            tableLayoutPanel8.Visible = !tableLayoutPanel8.Visible;
            tableLayoutPanel4.Visible = false;
            tableLayoutPanel5.Visible = false;
            tableLayoutPanel6.Visible = false;
            tableLayoutPanel7.Visible = false;
        }

        private void tableLayoutPanel4_AutoSizeChanged(object sender, EventArgs e)
        {
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
        }

        private void splitContainer2_Panel1_Resize(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel4_ParentChanged(object sender, EventArgs e)
        {
        }

        private void imageButton1_MouseLeave(object sender, EventArgs e)
        {
            tableLayoutPanel4.Visible = false;
        }

        private void imageButton1_MouseClick(object sender, MouseEventArgs e)
        {
            tableLayoutPanel4.Visible = !tableLayoutPanel4.Visible;
        }

        private void imageButton1_MouseLeave_1(object sender, EventArgs e)
        {
            tableLayoutPanel4.Visible = false;
        }
    }
}
