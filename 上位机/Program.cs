using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace HostComputer
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(){
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainFrom());
            SignForm Sign = new SignForm();
            //界面转换
            Sign.ShowDialog();
            if (Sign.DialogResult == DialogResult.OK)
            {
                Sign.Dispose();
                Application.Run(new MainForm());
            }
            else if (Sign.DialogResult == DialogResult.Cancel)
            {
                Sign.Dispose();
                return;
            }
        }
    }
}
