using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace 上位机
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
                Application.Run(new MainFrom());
            }
            else if (Sign.DialogResult == DialogResult.Cancel)
            {
                Sign.Dispose();
                return;
            }
        }
    }
    public class XML
    {
        public string XmlPath;
        private readonly string pasword;

        public string User { get; }
        public bool Sign(string users,string pass)
        {
            //创XML建对象
            XmlDocument XmlDoc = new XmlDocument();
            if (File.Exists(XmlPath))
            {
                XmlDoc.Load(XmlPath);
                XmlElement Root ;
                Root = XmlDoc.DocumentElement;
                XmlNode auser = Root.SelectSingleNode("user");

            }
            return false;
        }
    }
}
