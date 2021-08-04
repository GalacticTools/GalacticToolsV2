using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Galactic_Tools_V2.Properties;
using System.IO.Compression;


namespace Galactic_Tools_V2
{
    public partial class Games : Form
    {
        

        public Games()
        {
            this.InitializeComponent();
     
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            base.MaximizedBounds = Screen.FromHandle(base.Handle).WorkingArea;
            base.WindowState = FormWindowState.Normal;

            Directory.CreateDirectory(@"C:\Galactic Tools");
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon");
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {
            
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

           
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Minimized;
        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {
           
        }

        

        

        


        

        

        private void button_woc1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_woc2_Click(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Minimized;
        }

        private void panel27_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon");
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon");
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon");
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon");
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://www.dropbox.com/s/9zj1jyxcd4tsh8a/The%20Elder%20Scrolls%20V%20Skyrim%20Special%20Edition.7z?dl=1", @"C:\Galactic Tools\Skyrim.7z");

            string skyrimpath = @"C:\Galactic Tools";
            string skyrimZipFile = @"C:\Galactic Tools\Skyrim.7z";

            ZipFile.ExtractToDirectory(skyrimZipFile, skyrimpath);

            File.Delete(@"C:\Galactic Tools\Skyrim.7z");

            MessageBox.Show("Download Complete! Located in C:/Galactic Tools");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://www.dropbox.com/s/6o5xiwhul7gw4z8/Assassin%27s%20Creed%201.zip?dl=1", @"C:\Galactic Tools\Assassin's Creed 1.zip");

            string ac1path = @"C:\Galactic Tools";
            string ac1ZipFile = @"C:\Galactic Tools\Assassin's Creed 1.zip";

            ZipFile.ExtractToDirectory(ac1ZipFile, ac1path);

            File.Delete(@"C:\Galactic Tools\Far Cry New Dawn.zip");

            MessageBox.Show("Download Complete! Located in C:/Galactic Tools");

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon");
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://www.dropbox.com/s/pmgebizxkveqqjb/Far%20Cry%20New%20Dawn.zip?dl=1", @"C:\Galactic Tools\Far Cry New Dawn.zip");

            string dawnpath = @"C:\Galactic Tools";
            string dawnZipFile = @"C:\Galactic Tools\Far Cry New Dawn.zip";

            ZipFile.ExtractToDirectory(dawnZipFile, dawnpath);

            File.Delete(@"C:\Galactic Tools\Far Cry New Dawn.zip");


            MessageBox.Show("Download Complete! Located in C:/Galactic Tools");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon");
        }

        

        private void btnApps_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Apps apps = new Apps();
            apps.ShowDialog();
            this.Close();
        }

        private void btnGames_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Games games = new Games();
            games.ShowDialog();
            this.Close();
        }

        private void button9_Click_3(object sender, EventArgs e)
        {
            this.Hide();
            Launchers launchers = new Launchers();
            launchers.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Emulators emulators = new Emulators();
            emulators.ShowDialog();
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings settings = new Settings();
            settings.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made my NotOverTaken#1839 & ÑøţĐŘÂĶË#9999 \nJoin the discord server - https://discord.gg/XayFrhB2Y4 \nFor More Games by Afonso#0128 - https://portablegames.xyz/");
        }
    }
}

