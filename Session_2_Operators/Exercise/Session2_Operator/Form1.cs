using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session2_Operator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //加法按鈕清空控制向

        //加法按鈕計算 
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //字串相加
            txtAnswerA.Text = txtAdd1.Text + txtAdd2.Text;
            //.Trim()去除多餘空白
            txtAnswerA.Text = txtAdd1.Text.Trim() + txtAdd2.Text.Trim();
            //int.TryParse 將數字的字串表示轉換成它的對等 32 位元帶正負號的整數。 傳回指示轉換是否成功的值。
            int iAdd1;
            int iAdd2;
            int.TryParse(txtAdd1.Text,out iAdd1);
            int.TryParse(txtAdd2.Text, out iAdd2);
            //數字相加後放回畫面上控制項txtAnswerA 因TextBox是需要放入String 所以要 .ToStrint()
            txtAnswerA.Text = (iAdd1 + iAdd2).ToString();
            //Convert強制轉型態 如沒增加錯誤判斷會造成 系統例外錯誤導致程式關閉
            txtAnswerA.Text = (Convert.ToInt16(txtAdd1.Text) + Convert.ToInt16(txtAdd2.Text)).ToString();
        }


        private void btnCalculateSub_Click(object sender, EventArgs e)
        {
            int iSub1;
            int iSub2;
            //判斷txtSub1.Text輸入的是否是整數
            if (!int.TryParse(txtSub1.Text, out iSub1))
            {
                MessageBox.Show("您輸入的不是整數喔");
                txtSub1.Focus();
                return;
            }
            if (!int.TryParse(txtSub2.Text, out iSub2))
            {
                MessageBox.Show("您輸入的不是整數喔");
                txtSub2.Focus();
                return;
            }
            //iSub1-iSub2
            txtAnswerSub.Text = (iSub1 - iSub2).ToString();
        }

        private void btnCalculateMut_Click(object sender, EventArgs e)
        {
            int iMut1;
            int iMut2;
            //判斷txtMut1.Text輸入的是否是整數
            if (!int.TryParse(txtMut1.Text, out iMut1))
            {
                MessageBox.Show("您輸入的不是整數喔");
                txtMut1.Focus();
                return;
            }
            if (!int.TryParse(txtMut2.Text, out iMut2))
            {
                MessageBox.Show("您輸入的不是整數喔");
                txtMut2.Focus();
                return;
            }
            //iMut1*iMut2
            txtAnswerMut.Text = (iMut1 * iMut2).ToString();
        }

        private void btnCalculateDiv_Click(object sender, EventArgs e)
        {
            int iDiv1;
            int iDiv2;
            //判斷txtDiv1.Text輸入的是否是整數
            if (!int.TryParse(txtDiv1.Text, out iDiv1))
            {
                MessageBox.Show("您輸入的不是整數喔");
                txtDiv1.Focus();
                return;
            }
            if (!int.TryParse(txtDiv2.Text, out iDiv2))
            {
                MessageBox.Show("您輸入的不是整數喔");
                txtDiv2.Focus();
                return;
            }
            //iMut1/iMut2
            txtAnswerDiv.Text = (iDiv1 / iDiv2).ToString();
        }

        private void btnCalculateMod_Click(object sender, EventArgs e)
        {
            int iMod1;
            int iMod2;
            //判斷txtMod1.Text輸入的是否是整數
            if (!int.TryParse(txtMod1.Text, out iMod1))
            {
                MessageBox.Show("您輸入的不是整數喔");
                txtMod1.Focus();
                return;
            }
            if (!int.TryParse(txtMod2.Text, out iMod2))
            {
                MessageBox.Show("您輸入的不是整數喔");
                txtMod2.Focus();
                return;
            }
            //iMod1/iMod2
            txtAnswerMod.Text = (iMod1 % iMod2).ToString();
        }
        private void btnClearAdd_Click(object sender, EventArgs e)
        {
            txtAdd1.Clear();
            txtAdd2.Text = "";
            txtAnswerA.Text = "";
        }
        private void btnClearSub_Click(object sender, EventArgs e)
        {
            txtSub1.Text = "";
            txtSub2.Text = "";
            txtAnswerSub.Text = "";
        }

        private void btnClearMut_Click(object sender, EventArgs e)
        {
            txtMut1.Text = "";
            txtMut2.Text = "";
            txtAnswerMut.Text = "";
        }

        private void btnClearDiv_Click(object sender, EventArgs e)
        {
            txtDiv1.Text = "";
            txtDiv2.Text = "";
            txtAnswerDiv.Text = "";
        }

        private void btnClearMod_Click(object sender, EventArgs e)
        {
            txtMod1.Text = "";
            txtMod2.Text = "";
            txtAnswerMod.Text = "";
        }


        //---------暫時先不看-------------------
        private void txtAdd1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Char.IsNumber 判斷書入是否為數字
            //Char.IsControl 判斷是否為控制字元 ex:enter backspace
            //if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            //{
            //    e.Handled = true;//事件已處理--->這裡為消除非數字及控制項之字元
            //}

        }

        private void txtAdd2_TextChanged(object sender, EventArgs e)
        {
            // Regex.IsMatch 運算式是否在輸入字串中尋找比對 是否符合條件
            //if (txtAdd2.Text !="" && !Regex.IsMatch(txtAdd2.Text, @"^[0-9]*$"))
            //{
            //    txtAdd2.Text = txtAdd2.Text.Substring(0, txtAdd2.Text.Length - 1);
            //}
        }
    }
}
