using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoomDialog
{
    public partial class DoomDialog : Form
    {
        public DoomDialog(String path)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.path = path;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            String args = "/C \"" + this.path + "\" -applaunch " + DOOM_APP_ID + " +com_gameMode ";
            args += (singlePlayerRadio.Checked ? "1" : multiplayerRadio.Checked ? "2" : "3");

            Console.WriteLine("cmd.exe " + args);

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = args;
            process.StartInfo = startInfo;
            process.Start();

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private String path;
        private const long DOOM_APP_ID = 379720;
    }
}
