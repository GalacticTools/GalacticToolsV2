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
    public partial class Launchers : Form
    {
        

        public Launchers()
        {
            this.InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        

        

        

        

        private void button5_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://www.dropbox.com/s/rgb17e0egjss5oy/SatrixTools%20%281%29.zip?dl=1", @"C:\GalacticTools\SatrixTools.zip");
            string satrixpath = @"c:\Galactic Tools\SatrixTools";
            string satrixZipFile = @"c:\Galactic Tools\SatrixTools.zip";

            ZipFile.ExtractToDirectory(satrixZipFile, satrixpath);

            File.Delete(@"C:\GalacticTools\SatrixTools.zip");

            System.Diagnostics.Process.Start(@"C:\Galactic Tools\SatrixTools\SatrixTools v1.0.exe");

            MessageBox.Show("Download Complete! Located in C:/Galactic Tools");

        }


        private void button1_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://github-releases.githubusercontent.com/355656817/2d285400-9df8-11eb-90c3-93589406d206?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=AKIAIWNJYAX4CSVEH53A%2F20210415%2Fus-east-1%2Fs3%2Faws4_request&X-Amz-Date=20210415T225100Z&X-Amz-Expires=300&X-Amz-Signature=24d1f681a901c654c6bf46c94a323892d67109a5fefb14685d62bdc3bb6da59b&X-Amz-SignedHeaders=host&actor_id=76546066&key_id=0&repo_id=355656817&response-content-disposition=attachment%3B%20filename%3DArcadeLauncher.exe&response-content-type=application%2Foctet-stream", @"C:\GalacticTools\Arcadelauncher.exe");
            System.Diagnostics.Process.Start(@"c:\Galactic Tools\Arcadelauncher.exe");
            MessageBox.Show("Download Complete! Located in C:/Galactic Tools");
        }


        private void Launchers_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon!");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile(@"https://www.dropbox.com/s/pzs5swb5e209y59/Galactic%20Tools%20V1%20%281%29.exe?dl=1", @"C:\Galactic Tools\Galacitc Tools V1");

            System.Diagnostics.Process.Start(@"C:\Galactic Tools\Galactic Tools V1.exe");
        }

        private void button_woc1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_woc2_Click(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
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

        private void button8_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Launchers launchers = new Launchers();
            launchers.ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
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

        private void button4_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Made my NotOverTaken#1839 & ÑøţĐŘÂĶË#9999 \nJoin the discord server - https://discord.gg/XayFrhB2Y4 \nFor More Games by Afonso#0128 - https://portablegames.xyz/");
        }
    }
}
