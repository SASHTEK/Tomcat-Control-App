using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TomcatControlApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TomcatPath.Text = Properties.Settings.Default.TomcatPath;
            UpdateStatus("Ready");
        }

        private void btnSavePath_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(TomcatPath.Text))
            {
                UpdateStatus("Invalid Tomcat path. Please check and try again.");
                return;
            }

            Properties.Settings.Default.TomcatPath = TomcatPath.Text;
            Properties.Settings.Default.Save();
            UpdateStatus("Path saved successfully!");
        }

        private void btnStartTomcat_Click(object sender, EventArgs e)
        {
            if (IsTomcatPathValid())
            {
                StartTomcat();
                UpdateStatus("Tomcat started.");
                picStatusIndicator.BackColor = Color.Green;
            }
            else
            {
                UpdateStatus("Please set a valid Tomcat path first.");
            }
        }

        private void btnStopTomcat_Click(object sender, EventArgs e)
        {
            if (IsTomcatPathValid())
            {
                StopTomcat();
                UpdateStatus("Tomcat stopped.");
                picStatusIndicator.BackColor = Color.Red;
            }
            else
            {
                UpdateStatus("Please set a valid Tomcat path first.");
            }
        }

        private bool IsTomcatPathValid()
        {
            string tomcatPath = Properties.Settings.Default.TomcatPath;
            return !string.IsNullOrEmpty(tomcatPath) && Directory.Exists(tomcatPath);
        }
        private void StartTomcat()
        {
            string tomcatPath = Properties.Settings.Default.TomcatPath;
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = Path.Combine(tomcatPath, "startup.bat"),
                WorkingDirectory = tomcatPath,
                WindowStyle = ProcessWindowStyle.Hidden
            };
            Process.Start(startInfo);
        }
        private void StopTomcat()
        {
            string tomcatPath = Properties.Settings.Default.TomcatPath;
            ProcessStartInfo stopInfo = new ProcessStartInfo
            {
                FileName = Path.Combine(tomcatPath, "shutdown.bat"),
                WorkingDirectory = tomcatPath,
                WindowStyle = ProcessWindowStyle.Hidden
            };
            Process.Start(stopInfo);
        }
        private void UpdateStatus(string message)
        {
            lblStatus.Text = message;
        }

    }
}
