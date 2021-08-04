using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Galactic_Tools_V2
{

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            TrinitySeal.Seal.Secret = "fDGkhXeEQjxnBqYbjbN2VzToRaHbscYZm4N8rFYkFLvQS";
            panel1.MouseDown += Login_MouseDown;
        }

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(base.Handle, 161, 2, 0);
            }
        }

       

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            bool response = TrinitySeal.Seal.Login(guna2TextBox5.Text, guna2TextBox1.Text);
            if (response)
            {
                Properties.Settings.Default.Username = guna2TextBox5.Text;
                (new Apps()).Show();
                this.Hide();
            }
            else
            {

            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

     

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button_WOC3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_WOC4_Click_1(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            register.Visible = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            register.Visible = false;
        }

        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userPlaceholder_Click(object sender, EventArgs e)
        {

        }

        

        private void label6_Click(object sender, EventArgs e)
        {

        }

        
        
       

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            
        }

        

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            bool responde = TrinitySeal.Seal.Register(guna2TextBox6.Text, guna2TextBox2.Text, guna2TextBox3.Text, guna2TextBox4.Text);
            if (responde)
            {
                
            }
            else
            {
                
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void windowTitle_Click(object sender, EventArgs e)
        {

        }

        private void errorLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_WOC2_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_WOC1_Click_2(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Minimized;
        }


        
    }
}
