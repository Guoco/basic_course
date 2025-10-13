using System;
using System.Drawing;
using System.Windows.Forms;

namespace Session1_HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Button1 Click事件
        private void button1_Click(object sender, EventArgs e)
        {
            //---------------------MessageBox 是否 對話框--------

            //DialogResult result;
            //result = MessageBox.Show("Welcome to C# ", "Learn C#", MessageBoxButtons.YesNo);

            //if (result == DialogResult.Yes)
            //{
            //    MessageBox.Show("您點擊了Yes", "訊息!!");
            //}

            //---------------------------------------------------

            //---------------------MessageBox Icon--------

            //MessageBox.Show("警告", "訊息!!",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //---------------------------------------------------



            if (radioButton1.Checked == true)
            {
                MessageBox.Show("Hello", "訊息!!");
                //MessageBox.Show(radioButton1.Text, "訊息!!");
            }
            else if (radioButton2.Checked == true)
            {
                MessageBox.Show("Bye", "訊息!!");
                //MessageBox.Show(radioButton2.Text, "訊息!!");
            }
            else
            {
                MessageBox.Show("請點選其中一個radioButton感恩", "警告!!");
            }
        }
        //畫面讀取
        private void Form1_Load(object sender, EventArgs e)
        {
            //int x = (SystemInformation.WorkingArea.Width - this.Size.Width) / 2;
            //int y = (SystemInformation.WorkingArea.Height - this.Size.Height) / 2;
            //this.StartPosition = FormStartPosition.Manual; //窗體的位置由Location屬性決定
            //this.Location = (Point)new Size(x, y);
        }
    }
}
