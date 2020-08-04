using System;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows.Threading;
using System.IO;
using Newtonsoft.Json;

namespace Launcher
{
    public partial class Main : Form
    {

        private DispatcherTimer timer = null;
        public Main()
        {
            
            InitializeComponent();

            //запускаем1 раз 

            SampQuery api = new SampQuery(User.ip, 7777, 'i');

            var response = api.read();
            var online_players = response["players"];
            var maxplayers = response["maxplayers"];

            this.label1.Text = online_players + "/" + maxplayers;
            //потом обновляем в таймере


            timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 10000);
            timer.Start();

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
                String sobeitCheat = User.path + "/d3d9.dll";
                String DestFile = User.path + "/models/txd/other.txd";
                string src = Directory.GetCurrentDirectory() + @"/myPack";
                string dest = User.path + "/models/txd";


                if (File.Exists(sobeitCheat))
                {//Проверяем есть ли d3d9.dll
                    MessageBox.Show("Папка с игрой содержит запрещенный файл d3d9.dll!");
                }
                else {

                    if (File.Exists(DestFile))//если нет файлов .txd
                            CopyDir.Copy(src, dest);// - загружаем

                    Process.Start(
                            User.path + "//samp.exe",
                            User.ip + " - n" + Input_Login.Text);//запускаем
                }
                //
            }
            else MessageBox.Show("Выберете путь с GTA SA");
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            SampQuery api = new SampQuery(User.ip, 7777, 'i');

            var response = api.read();
            var online_players = response["players"];
            var maxplayers = response["maxplayers"];

            this.label1.Text = online_players + "/" + maxplayers;
        }
    }
    static public class User
    {
        public static string nickname = "Nickname";
        public static string path = " ";
        public static string ip = "54.37.142.74";
    }
    public class UserSave
    {
        public string nickname = "Nickname";
        public string path = " ";
    }
}
