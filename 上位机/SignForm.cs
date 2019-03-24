using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 上位机
{
    public partial class SignForm : Form
    {
        public SignForm()
        {
            InitializeComponent();
        }

        private void But_Sign_in_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            string userPassword = textBox2.Text;

            //2. 验证数据
            // 验证用户输入是否为空，若为空，提示用户信息
            if (userName.Equals("") || userPassword.Equals(""))
            {
                MessageBox.Show("用户名或密码不能为空！");
            }
            // 若不为空，验证用户名和密码是否与数据库匹配
            // 这里只做字符串对比验证
            else
            {
                //用户名和密码验证正确，提示成功，并执行跳转界面。
                if (userName.Equals("admin") && userPassword.Equals("admin"))
                {
                    //MessageBox.Show("登录成功！");
                    DialogResult = DialogResult.OK;
                    Dispose();
                    Close();
                }
                //用户名和密码验证错误，提示错误。
                else
                {
                    MessageBox.Show("用户名或密码错误！");
                }
            }
        }
        
    }
}
