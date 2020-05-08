using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Security.Permissions;
using Microsoft.Win32;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.IO.Compression;
using System.Collections.Specialized;
using System.Threading;
using Newtonsoft.Json;

namespace Launcher
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            Animator.Start();
            UserSave Usave = new UserSave();

             try
             {

                 using (StreamReader sw = new StreamReader(Directory.GetCurrentDirectory() + "/set.json"))
                 {

                     string json = sw.ReadToEnd();
                     Usave = JsonConvert.DeserializeObject<UserSave>(json);
                     User.nickname = Usave.nickname;
                     User.path = Usave.path;
                     sw.Close();
                 }
                 this.Input_Login.TextInput = User.nickname;
             }
             catch
             {

             }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Point LastPoint;
        private void border_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void border_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void but_close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_login_Click(object sender, EventArgs e)
        {
            UserSave Usave = new UserSave();
            Usave.nickname = User.nickname = Input_Login.Text;

            Usave.path = User.path;
            String serialized = JsonConvert.SerializeObject(Usave);
            using (StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + "/set.json"))
            {
                sw.Write(serialized);
                sw.Close();
            }
        }

        private void folder_browser_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string destFileName = folderBrowserDialog1.SelectedPath + "/samp.exe";
                if (File.Exists(destFileName))
                {
                    User.path = folderBrowserDialog1.SelectedPath;
                    UserSave Usave = new UserSave();
                    Usave.path = folderBrowserDialog1.SelectedPath;
                    Usave.nickname = User.nickname;
                    string serialized = JsonConvert.SerializeObject(Usave);
                    using (StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + "/set.json"))
                    {
                        sw.Write(serialized);
                        sw.Close();
                    }
                }
                else MessageBox.Show("Указан неверный путь, samp.exe не найден!");


            }
        }

        private void inGame_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(User.path))//Если директория указана
            {
                String DestFile = User.path + "/models/txd/other.txd";
                if (File.Exists(DestFile))//Проверяем есть ли уже хоть один файл из наших TXD тогда запускаем
                    Process.Start(User.path + "//samp.exe", "127.0.0.1" + ":" + "7777" + " -n" + Input_Login.Text);
                else//Если нет файлов TXD то загружаем их, после запускаем
                {
                    string src = Directory.GetCurrentDirectory() + @"/myPack";
                    string dest = User.path + "/models/txd";
                    CopyDir.Copy(src, dest);
                    Process.Start(User.path + "//samp.exe", "127.0.0.1" + ":" + "7777" + " -n" + Input_Login.Text);
                }
            }
            else MessageBox.Show("Выберете путь с GTA SA");
        }
    }
    static public class User
    {
        public static string nickname = "Nickname";
        public static string path = " ";
    }
    public class UserSave
    {
        public string nickname = "Nickname";
        public string path = " ";
    }
}
