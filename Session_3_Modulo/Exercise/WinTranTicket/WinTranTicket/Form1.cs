using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTranTicket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            int iSeatNo;
            //判斷輸入的火車票是否為數字
            if (int.TryParse(txtSeatNo.Text, out iSeatNo))
            {
                if (iSeatNo > 52)
                {
                    MessageBox.Show("火車座位最多只有52個呦~~");
                    return;
                }
            }
            else
            {
                MessageBox.Show("您輸入的不是整數喔");
                txtSeatNo.Focus();
                return;
            }
            int iMod;
            iMod = iSeatNo % 4;
            if (iMod == 1 || iMod == 2)
            {
                MessageBox.Show("您輸入的車票號碼：" + iSeatNo + "是在【靠窗】的位置");
            }
            else if (iMod == 3 || iMod == 0)
            {
                MessageBox.Show("您輸入的車票號碼：" + iSeatNo + "是在【靠走道】的位置");
            }
            else
            {
				MessageBox.Show("您輸入的車票號碼：" + iSeatNo + "無法判斷!!");
			}

        }
    }
}
