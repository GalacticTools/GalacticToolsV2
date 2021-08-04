using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.IO.Compression;

namespace Galactic_Tools_V2
{
    public partial class Emulators : Form
    {
        public Emulators()
        {
            this.InitializeComponent();
        }

        



        

 

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon!");
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://www.dropbox.com/s/9xtuhh7vldlgy86/rpcs3-v0.0.15-11945-aff63028-win64.zip?dl=1", @"C:\Galactic Tools\RPCS3.zip");

            string RPCS3path = @"C:\Galactic Tools\RPCS3";
            string RPCS3ZipFile = @"C:\Galactic Tools\RPCS3.zip";

            ZipFile.ExtractToDirectory(RPCS3ZipFile, RPCS3path);

            File.Delete(@"C:\Galactic Tools\RPCS3.zip");

            System.Diagnostics.Process.Start(@"C:\Galactic Tools\RPCS3\rpcs3.exe");
          
            MessageBox.Show("Download Complete! Located in C:/Galactic Tools");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://www.dropbox.com/s/8zxxw638ku3ssj9/Yuzu.zip?dl=1", @"C:\Galactic Tools\Yuzu.zip");

            string yuzupath = @"C:\Galactic Tools\Yuzu";
            string yuzuZipFile = @"C:\Galactic Tools\Yuzu.zip";

            ZipFile.ExtractToDirectory(yuzuZipFile, yuzupath);

            File.Delete(@"C:\Galactic Tools\Yuzu.zip");

            System.Diagnostics.Process.Start(@"C:\Galactic Tools\Yuzu\yuzu\yuzu-windows-msvc\yuzu.exe");

            MessageBox.Show("Download Complete! Located in C:/Galactic Tools");
        }

        private void Emulators_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory(@"C:\Galactic Tools");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://www.dropbox.com/s/facphq0f1wc5dsb/xenia%20master.zip?dl=1", @"C:\Galactic Tools\Xenia.zip");

            string xeniapath = @"C:\Galactic Tools\Xenia";
            string xeniaZipFile = @"C:\Galactic Tools\Xenia.zip";

            ZipFile.ExtractToDirectory(xeniaZipFile, xeniapath);

            File.Delete(@"C:\Galactic Tools\Xenia.zip");

            System.Diagnostics.Process.Start(@"C:\Galactic Tools\Xenia\xenia.exe");

            MessageBox.Show("Download Complete! Located in C:/Galactic Tools");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://www.dropbox.com/s/fcn4b0d3qs91tqb/Citra.zip?dl=1", @"C:\Galactic Tools\Citra.zip");

            string citrapath = @"C:\Galactic Tools\";
            string citraZipFile = @"C:\Galactic Tools\Citra.zip";

            ZipFile.ExtractToDirectory(citraZipFile, citrapath);

            File.Delete(@"C:\Galactic Tools\Citra.zip");

            System.Diagnostics.Process.Start(@"C:\Galactic Tools\Citra\nightly-mingw\citra-qt.exe");

            MessageBox.Show("Download Complete! Located in C:/Galactic Tools");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://www.dropbox.com/s/gckln511qkc9vs8/cemu%201.22.10.zip?dl=1", @"C:\Galactic Tools\Cemu.zip");

            string cemupath = @"C:\Galactic Tools\";
            string cemuZipFile = @"C:\Galactic Tools\Cemu.zip";

            ZipFile.ExtractToDirectory(cemuZipFile, cemupath);

            File.Delete(@"C:\Galactic Tools\Cemu.zip");

            System.Diagnostics.Process.Start(@"C:\Galactic Tools\cemu_1.22.10\Cemu.exe");

            MessageBox.Show("Download Complete! Located in C:/Galactic Tools");
        }

        private void button_woc1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_woc2_Click(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Minimized;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnApps_Click(object sender, EventArgs e)
        {
            this.Hide();
            Apps apps = new Apps();
            apps.ShowDialog();
            this.Close();
        }

        private void btnGames_Click(object sender, EventArgs e)
        {
            this.Hide();
            Games games = new Games();
            games.ShowDialog();
            this.Close();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Launchers launchers = new Launchers();
            launchers.ShowDialog();
            this.Close();
        }

        private void button8_Click_1(object sender, EventArgs e)
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

        private void button7_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show("Made my NotOverTaken#1839 & ÑøţĐŘÂĶË#9999 \nJoin the discord server - https://discord.gg/XayFrhB2Y4 \nFor More Games by Afonso#0128 - https://portablegames.xyz/");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
