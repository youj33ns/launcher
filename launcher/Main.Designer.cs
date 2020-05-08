namespace Launcher
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.border = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.inGame = new Launcher.yt_Button();
            this.folder_browser = new Launcher.yt_Button();
            this.save_login = new Launcher.yt_Button();
            this.Input_Login = new Launcher.EgoldsGoogleTextBox();
            this.but_close = new Launcher.yt_Button();
            ((System.ComponentModel.ISupportInitialize)(this.border)).BeginInit();
            this.SuspendLayout();
            // 
            // border
            // 
            this.border.BackColor = System.Drawing.SystemColors.HotTrack;
            this.border.BackgroundImage = global::Launcher.Properties.Resources.background;
            this.border.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.border.Dock = System.Windows.Forms.DockStyle.Top;
            this.border.Location = new System.Drawing.Point(0, 0);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(886, 34);
            this.border.TabIndex = 0;
            this.border.TabStop = false;
            this.border.MouseDown += new System.Windows.Forms.MouseEventHandler(this.border_MouseDown);
            this.border.MouseMove += new System.Windows.Forms.MouseEventHandler(this.border_MouseMove);
            // 
            // inGame
            // 
            this.inGame.BackColor = System.Drawing.Color.BurlyWood;
            this.inGame.BackColorAdditional = System.Drawing.Color.Gray;
            this.inGame.BackColorGradientEnabled = false;
            this.inGame.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.inGame.BorderColor = System.Drawing.Color.Tomato;
            this.inGame.BorderColorEnabled = false;
            this.inGame.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.inGame.BorderColorOnHoverEnabled = false;
            this.inGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inGame.Font = new System.Drawing.Font("Verdana", 18.8F, System.Drawing.FontStyle.Bold);
            this.inGame.ForeColor = System.Drawing.Color.White;
            this.inGame.Location = new System.Drawing.Point(682, 417);
            this.inGame.Name = "inGame";
            this.inGame.RippleColor = System.Drawing.Color.Black;
            this.inGame.RoundingEnable = false;
            this.inGame.Size = new System.Drawing.Size(190, 103);
            this.inGame.TabIndex = 5;
            this.inGame.Text = "Играть";
            this.inGame.TextHover = null;
            this.inGame.UseDownPressEffectOnClick = false;
            this.inGame.UseRippleEffect = true;
            this.inGame.UseZoomEffectOnHover = false;
            this.inGame.Click += new System.EventHandler(this.inGame_Click);
            // 
            // folder_browser
            // 
            this.folder_browser.BackColor = System.Drawing.Color.Teal;
            this.folder_browser.BackColorAdditional = System.Drawing.Color.Gray;
            this.folder_browser.BackColorGradientEnabled = false;
            this.folder_browser.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.folder_browser.BorderColor = System.Drawing.Color.Tomato;
            this.folder_browser.BorderColorEnabled = false;
            this.folder_browser.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.folder_browser.BorderColorOnHoverEnabled = false;
            this.folder_browser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.folder_browser.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.folder_browser.ForeColor = System.Drawing.Color.White;
            this.folder_browser.Location = new System.Drawing.Point(570, 427);
            this.folder_browser.Name = "folder_browser";
            this.folder_browser.RippleColor = System.Drawing.Color.Black;
            this.folder_browser.RoundingEnable = false;
            this.folder_browser.Size = new System.Drawing.Size(102, 93);
            this.folder_browser.TabIndex = 4;
            this.folder_browser.Text = "Путь к игре";
            this.folder_browser.TextHover = null;
            this.folder_browser.UseDownPressEffectOnClick = false;
            this.folder_browser.UseRippleEffect = true;
            this.folder_browser.UseZoomEffectOnHover = false;
            this.folder_browser.Click += new System.EventHandler(this.folder_browser_Click);
            // 
            // save_login
            // 
            this.save_login.BackColor = System.Drawing.Color.Transparent;
            this.save_login.BackColorAdditional = System.Drawing.Color.Gray;
            this.save_login.BackColorGradientEnabled = false;
            this.save_login.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.save_login.BorderColor = System.Drawing.Color.Tomato;
            this.save_login.BorderColorEnabled = false;
            this.save_login.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.save_login.BorderColorOnHoverEnabled = false;
            this.save_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_login.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.save_login.ForeColor = System.Drawing.Color.White;
            this.save_login.Location = new System.Drawing.Point(290, 477);
            this.save_login.Name = "save_login";
            this.save_login.RippleColor = System.Drawing.Color.Black;
            this.save_login.RoundingEnable = false;
            this.save_login.Size = new System.Drawing.Size(63, 44);
            this.save_login.TabIndex = 3;
            this.save_login.Text = "Ок";
            this.save_login.TextHover = null;
            this.save_login.UseDownPressEffectOnClick = false;
            this.save_login.UseRippleEffect = true;
            this.save_login.UseZoomEffectOnHover = false;
            this.save_login.Click += new System.EventHandler(this.save_login_Click);
            // 
            // Input_Login
            // 
            this.Input_Login.BackColor = System.Drawing.Color.White;
            this.Input_Login.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Input_Login.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.Input_Login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Input_Login.Font = new System.Drawing.Font("Arial", 11.25F);
            this.Input_Login.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.Input_Login.ForeColor = System.Drawing.Color.Black;
            this.Input_Login.Location = new System.Drawing.Point(16, 476);
            this.Input_Login.Name = "Input_Login";
            this.Input_Login.Size = new System.Drawing.Size(266, 46);
            this.Input_Login.TabIndex = 2;
            this.Input_Login.TextInput = "";
            this.Input_Login.TextPreview = "Введите логин";
            this.Input_Login.UseSystemPasswordChar = false;
            // 
            // but_close
            // 
            this.but_close.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.but_close.BackColorAdditional = System.Drawing.Color.Gray;
            this.but_close.BackColorGradientEnabled = false;
            this.but_close.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.but_close.BorderColor = System.Drawing.Color.Tomato;
            this.but_close.BorderColorEnabled = false;
            this.but_close.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.but_close.BorderColorOnHoverEnabled = false;
            this.but_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_close.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_close.ForeColor = System.Drawing.Color.White;
            this.but_close.Location = new System.Drawing.Point(778, 6);
            this.but_close.Name = "but_close";
            this.but_close.RippleColor = System.Drawing.Color.Black;
            this.but_close.RoundingEnable = false;
            this.but_close.Size = new System.Drawing.Size(95, 23);
            this.but_close.TabIndex = 1;
            this.but_close.Text = "Закрыть";
            this.but_close.TextHover = null;
            this.but_close.UseDownPressEffectOnClick = false;
            this.but_close.UseRippleEffect = true;
            this.but_close.UseZoomEffectOnHover = false;
            this.but_close.Click += new System.EventHandler(this.but_close_Click_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::Launcher.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(886, 539);
            this.ControlBox = false;
            this.Controls.Add(this.inGame);
            this.Controls.Add(this.folder_browser);
            this.Controls.Add(this.save_login);
            this.Controls.Add(this.Input_Login);
            this.Controls.Add(this.but_close);
            this.Controls.Add(this.border);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Launcher [Unreal]";
            ((System.ComponentModel.ISupportInitialize)(this.border)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox border;
        private yt_Button but_close;
        private EgoldsGoogleTextBox Input_Login;
        private yt_Button save_login;
        private yt_Button folder_browser;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private yt_Button inGame;
    }
}

