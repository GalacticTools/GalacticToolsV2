using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galactic_Tools_V2
{
    public partial class Settings : Form
    {
        public Settings()
        {
            this.InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Minimized;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            textBox9.Text = fbd.SelectedPath;

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            

            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Settings_Load(object sender, EventArgs e)
        {
            textBox3.Text = Properties.Settings.Default.Username;

            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_woc2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_woc1_Click(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Minimized;
        }

       

        private void button8_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Launchers launchers = new Launchers();
            launchers.ShowDialog();
            this.Close();
        }

        private void button7_Click_1(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made my NotOverTaken#1839 & ÑøţĐŘÂĶË#9999 \nJoin the discord server - https://discord.gg/XayFrhB2Y4 \nFor More Games by Afonso#0128 - https://portablegames.xyz/");
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
    }
}