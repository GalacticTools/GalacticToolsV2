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
    public partial class Apps : Form
    {
        public Apps()
        {
            this.InitializeComponent();
        }

        private void btnGames_Click(object sender, EventArgs e)
        {
            this.Hide();
            Games games = new Games();
            games.ShowDialog();
            this.Close();
        }

        private void btnApps_Click(object sender, EventArgs e)
        {
            this.Hide();
            Apps apps = new Apps();
            apps.ShowDialog();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://www.dropbox.com/s/kpaeeme8j58jayd/Galactic_Explorer%20%283%29.exe?dl=1", @"C:\Galactic Tools\Galactic_Explorer.exe");
            System.Diagnostics.Process.Start(@"C:\Galactic Tools\Galactic_Explorer.exe");
            MessageBox.Show("Download Complete! Located in C:/Galactic Tools");
        }

        private void Apps_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory(@"C:\Galactic Tools");
        }

        private void button_woc1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_woc2_Click(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://www.dropbox.com/s/j4qiio20dcaid2i/Firefox%20%281%29%20%282%29.zip?dl=1", @"C:\Galactic Tools\Firefox.zip");

            string firefoxpath = @"C:\Galactic Tools";
            string firefoxZipFile = @"C:\Galactic Tools\Firefox.zip";

            ZipFile.ExtractToDirectory(firefoxZipFile, firefoxpath);

            File.Delete(@"C:\Galactic Tools\Firefox.zip");

            System.Diagnostics.Process.Start(@"C:\Galactic Tools\Firefox\runthis.exe");

            MessageBox.Show("Download Complete! Located in C:/Galactic Tools");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://www.dropbox.com/s/me2hys7qv01rpvb/Moonlight.zip?dl=1", @"C:\Galactic Tools\Moonlight.zip");

            string moonlightpath = @"C:\Galactic Tools";
            string moonlightZipFile = @"C:\Galactic Tools\Moonlight.zip";

            ZipFile.ExtractToDirectory(moonlightZipFile, moonlightpath);

            File.Delete(@"C:\Galactic Tools\Moonlight.zip");

            System.Diagnostics.Process.Start(@"C:\Galactic Tools\MoonlightPortable-x64-3.1.1\Moonlight.exe");

            MessageBox.Show("Download Complete! Located in C:/Galactic Tools");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://www.dropbox.com/s/ojag2zvl51gckxq/Spotify%20%281%29.zip?dl=1", @"C:\Galactic Tools\Spotify.zip");

            string spotifypath = @"C:\Galactic Tools";
            string spotifyZipFile = @"C:\Galactic Tools\Spotify.zip";

            ZipFile.ExtractToDirectory(spotifyZipFile, spotifypath);

            File.Delete(@"C:\Galactic Tools\Spotify.zip");

            System.Diagnostics.Process.Start(@"C:\Galactic Tools\Spotify\Spotify.exe");

            MessageBox.Show("Download Complete! Located in C:/Galactic Tools");

        }

        private void button10_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://www.dropbox.com/s/v66yvxzmzr5r687/Chrome.zip?dl=1", @"C:\Galactic Tools\GoogleChrome.zip");

            string chromepath = @"C:\Galactic Tools";
            string chromeZipFile = @"C:\Galactic Tools\GoogleChrome.zip";

            ZipFile.ExtractToDirectory(chromeZipFile, chromepath);

            File.Delete(@"C:\Galactic Tools\GoogleChrome.zip");

            System.Diagnostics.Process.Start(@"C:\Galactic Tools\Chrome\GoogleChromePortable.exe");

            MessageBox.Show("Download Complete! Located in C:/Galactic Tools");

        }

        private void button12_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://www.dropbox.com/s/795l65apgob9vzt/GalacticUnzipper.exe?dl=1", @"C:\Galactic Tools\GalacticUnzipper.exe");

            System.Diagnostics.Process.Start(@"C:\Galactic Tools\GalacticUnzipper.exe");

            MessageBox.Show("Download Complete! Located in C:/Galactic Tools");

        }

        private void button15_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://www.dropbox.com/s/ri6c1kzcw6sjc2i/OperaGX%20%281%29.zip?dl=1", @"C:\Galactic Tools\OBS-Studio.zip");

            string obspath = @"C:\Galactic Tools";
            string obsZipFile = @"C:\Galactic Tools\OBS-Studio.zip";

            ZipFile.ExtractToDirectory(obsZipFile, obspath);

            File.Delete(@"C:\Galactic Tools\OBS-Studio.zip");

            MessageBox.Show("Please launch OBS manually in C:/Galactic Tools/OBS-Studio/bin/64bit/obs64.exe");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://www.dropbox.com/s/x9b00v8mrix3oak/Steam%20%282%29.zip?dl=1", @"C:\Galactic Tools\Steam.zip");

            string steampath = @"C:\Galactic Tools";
            string steamZipFile = @"C:\Galactic Tools\Steam.zip";

            ZipFile.ExtractToDirectory(steamZipFile, steampath);

            File.Delete(@"C:\Galactic Tools\Steam.zip");

            System.Diagnostics.Process.Start(@"C:\Galactic Tools\Steam\Steam.exe");

            MessageBox.Show("Download Complete! Located in C:/Galactic Tools");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://www.dropbox.com/s/18t8cw4b8zmfv2s/Ubisoft%20Connect%20%281%29.zip?dl=1", @"C:\Galactic Tools\UbisoftConnect.zip");

            string connectpath = @"C:\Galactic Tools";
            string connectZipFile = @"C:\Galactic Tools\UbisoftConnect.zip";

            ZipFile.ExtractToDirectory(connectZipFile, connectpath);

            File.Delete(@"C:\Galactic Tools\UbisoftConnect.zip");

            System.Diagnostics.Process.Start(@"C:\Galactic Tools\Ubisoft Connect\Ubisoft Game Launcher\UbisoftConnect.exe");

            MessageBox.Show("Download Complete! Located in C:/Galactic Tools");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://www.dropbox.com/s/jcq9tq2ww2s0tjg/ProcessHacker%20%282%29.zip?dl=1", @"C:\Galactic Tools\ProcessHacker.zip");

            string hackerpath = @"C:\Galactic Tools";
            string hackerZipFile = @"C:\Galactic Tools\ProcessHacker.zip";

            ZipFile.ExtractToDirectory(hackerZipFile, hackerpath);

            File.Delete(@"C:\Galactic Tools\ProcessHacker.zip");

            System.Diagnostics.Process.Start(@"C:\Galactic Tools\ProcessHacker\ProcessHacker.exe");

            MessageBox.Show("Download Complete! Located in C:/Galactic Tools");
        }

        private void button17_Click(object sender, EventArgs e)
        {

            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://www.dropbox.com/s/ycv69ohg9c1cvt3/Origin%20%281%29%20%282%29.zip?dl=1", @"C:\Galactic Tools\Origin.zip");

            string originpath = @"C:\Galactic Tools";
            string originZipFile = @"C:\Galactic Tools\Origin.zip";

            ZipFile.ExtractToDirectory(originZipFile, originpath);

            File.Delete(@"C:\Galactic Tools\Origin.zip");

            System.Diagnostics.Process.Start(@"C:\Galactic Tools\Origin\Origin.exe");

            MessageBox.Show("Download Complete! Located in C:/Galactic Tools");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://www.dropbox.com/s/jmvrg7gbbuah90a/Ezcmd.exe?dl=1", @"C:\Galactic Tools\Ezcmd.exe");

            System.Diagnostics.Process.Start(@"C:\Galactic Tools\Ezcmd.exe");

        }

        private void button19_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://www.dropbox.com/s/b5ad8bybb9uncgb/Discord%20%281%29%20%282%29.zip?dl=1", @"C:\Galactic Tools\Discord.zip");

            string discordpath = @"C:\Galactic Tools\";
            string discordZipFile = @"C:\Galactic Tools\Discord.zip";

            ZipFile.ExtractToDirectory(discordZipFile, discordpath);

            File.Delete(@"C:\Galactic Tools\Discord.zip");

            System.Diagnostics.Process.Start(@"C:\Galactic Tools\discord2\discord-portable.exe");

            MessageBox.Show("Download Complete! Located in C:/Galactic Tools");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://www.dropbox.com/s/304qt0hl5qk2e3v/Parsec%20%282%29.zip?dl=1", @"C:\Galactic Tools\Parsec.zip");

            string parsecpath = @"C:\Galactic Tools\Parsec";
            string parsecZipFile = @"C:\Galactic Tools\Parsec.zip";

            ZipFile.ExtractToDirectory(parsecZipFile, parsecpath);

            File.Delete(@"C:\Galactic Tools\Parsec.zip");

            MessageBox.Show("Please launch manually in C:/Galactic Tools/Parsec/parsecd.exe");

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://www.dropbox.com/s/drfv5v9y6hyrvh2/Zoom.zip?dl=1", @"C:\Galactic Tools\Zoom.zip");

            string zoompath = @"C:\Galactic Tools\";
            string zoomZipFile = @"C:\Galactic Tools\Zoom.zip";

            ZipFile.ExtractToDirectory(zoomZipFile, zoompath);

            File.Delete(@"C:\Galactic Tools\Zoom.zip");

            System.Diagnostics.Process.Start(@"C:\Galactic Tools\Zoom\bin\Zoom.exe");

            MessageBox.Show("Download Complete! Located in C:/Galactic Tools");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://www.dropbox.com/s/4lt9wpu7wvg9gdn/CtrlTab%20%282%29.exe?dl=1", @"C:\Galactic Tools\CtrlTab.exe");

            System.Diagnostics.Process.Start(@"C:\Galactic Tools\CtrlTab.exe");

            MessageBox.Show("Download Complete! Located in C:/Galactic Tools");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://download.anydesk.com/AnyDesk.exe?_ga=2.196537775.2084458682.1617499624-914223652.1617499624&_gac=1.16387652.1617499624.CjwKCAjwpKCDBhBPEiwAFgBzjyPkffU_uwvWgOSYnCZQNNpNCk2d2xR3Nika1VcuSAibPFzm7k59cxoCy3QQAvD_BwE", @"C:\Galactic Tools\Anydesk.exe");

            System.Diagnostics.Process.Start(@"C:\Galactic Tools\Anydesk.exe");

            MessageBox.Show("Download Complete! Located in C:/Galactic Tools");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://www.dropbox.com/s/ri6c1kzcw6sjc2i/OperaGX%20%281%29.zip?dl=1", @"C:\Galactic Tools\OperaGX.zip");

            string OperaGXpath = @"C:\Galactic Tools\";
            string OperaGXZipFile = @"C:\Galactic Tools\OperaGX.zip";

            ZipFile.ExtractToDirectory(OperaGXZipFile, OperaGXpath);

            File.Delete(@"C:\Galactic Tools\OperaGX.zip");

            System.Diagnostics.Process.Start(@"C:\Galactic Tools\OperaGX\73.0.3856.415\opera.exe");

            MessageBox.Show("Download Complete! Located in C:/GalacticTools");
        }

       
        private void button24_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://www.dropbox.com/s/b2r6j8diqs9jc7q/Battle.net%20%281%29%20%282%29.zip?dl=1", @"C:\Galactic Tools\Battlenet.zip");

            MessageBox.Show("Please extract manually with Zortos Unzipper");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://www.dropbox.com/s/szt3y3qigjcmrrb/VegasPro16.0.zip?dl=1", @"C:\Galactic Tools\Sony Vegas Pro.zip");

            string sonypath = @"C:\Galactic Tools\";
            string sonyZipFile = @"C:\Galactic Tools\Sony Vegas Pro.zip";

            ZipFile.ExtractToDirectory(sonyZipFile, sonypath);

            File.Delete(@"C:\Galactic Tools\Sony Vegas Pro.zip");

            System.Diagnostics.Process.Start(@"C:\Galactic Tools\VegasPro16.0\Vegas Pro 16.0\VEGAS Pro 16.0\vegas160.exe");

            MessageBox.Show("Download Complete! Located in C:/GalacticTools");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://www.dropbox.com/s/dm7lywsnz8sb6li/PowerISO.zip?dl=1", @"C:\Galactic Tools\PowerISO.zip");

            string isopath = @"C:\Galactic Tools\";
            string isoZipFile = @"C:\Galactic Tools\PowerISO.zip";

            ZipFile.ExtractToDirectory(isoZipFile, isopath);

            File.Delete(@"C:\Galactic Tools\PowerISO.zip");

            System.Diagnostics.Process.Start(@"C:\Galactic Tools\PowerISO\PowerISO.exe");

            MessageBox.Show("Download Complete! Located in C:/GalacticTools");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://www.dropbox.com/s/p4fbel8lvunt4ap/Gimp.zip?dl=1", @"C:\Galactic Tools\Gimp.zip");

            string gimppath = @"C:\Galactic Tools\";
            string gimpZipFile = @"C:\Galactic Tools\Gimp.zip";

            ZipFile.ExtractToDirectory(gimpZipFile, gimppath);

            File.Delete(@"C:\Galactic Tools\Gimp.zip");

            System.Diagnostics.Process.Start(@"C:\Galactic Tools\Gimp\GIMPPortable.exe");

            MessageBox.Show("Download Complete! Located in C:/GalacticTools");

        }

        private void button27_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://www.dropbox.com/s/a647jh8had9xlwg/qBitTorrent.zip?dl=1", @"C:\Galactic Tools\qBitTorrent.zip");

            string torrentpath = @"C:\Galactic Tools\qBitTorrent";
            string torrentZipFile = @"C:\Galactic Tools\qBitTorrent.zip";

            ZipFile.ExtractToDirectory(torrentZipFile, torrentpath);

            File.Delete(@"C:\Galactic Tools\qBitTorrent.zip");

            System.Diagnostics.Process.Start(@"C:\Galactic Tools\qBitTorrent\biter\biter.exe");

            MessageBox.Show("Download Complete! Located in C:/GalacticTools");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://www.dropbox.com/s/3zkzlogost2bces/Creative%20Cloud.zip?dl=1", @"C:\Galactic Tools\Creative Cloud.zip");

            string cloudpath = @"C:\Galactic Tools\";
            string cloudZipFile = @"C:\Galactic Tools\Creative Cloud.zip";

            ZipFile.ExtractToDirectory(cloudZipFile, cloudpath);

            File.Delete(@"C:\Galactic Tools\Creative Cloud.zip");

            System.Diagnostics.Process.Start(@"C:\Galactic Tools\Adobe\Adobe Creative Cloud\ACC\Creative Cloud.exe");

            MessageBox.Show("Download Complete! Located in C:/GalacticTools");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://www.dropbox.com/s/309h339tyqzapp3/TeamViewer%20%281%29.zip?dl=1", @"C:\Galactic Tools\TeamViewer.zip");

            string teampath = @"C:\Galactic Tools\";
            string teamZipFile = @"C:\Galactic Tools\TeamViewer.zip";

            ZipFile.ExtractToDirectory(teamZipFile, teampath);

            File.Delete(@"C:\Galactic Tools\TeamViewer.zip");

            System.Diagnostics.Process.Start(@"C:\Galactic Tools\TeamViewer\TeamViewer_Desktop.exe");

            MessageBox.Show("Download Complete! Located in C:/GalacticTools");
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made my NotOverTaken#1839 & ÑøţĐŘÂĶË#9999 \nJoin the discord server - https://discord.gg/XayFrhB2Y4 \nFor More Games by Afonso#0128 - https://portablegames.xyz/");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        

        private void button_WOC3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_WOC4_Click(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void panel30_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
