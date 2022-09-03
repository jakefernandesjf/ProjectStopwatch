using System.Diagnostics;

namespace ProjectStopwatchApp
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void GitHub_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void VisitLink()
        {
            GitHub_Link.LinkVisited = true;
            ProcessStartInfo webpage = new ProcessStartInfo("https://github.com/jakefernandesjf/ProjectStopwatch")
            {
                UseShellExecute = true,
            };
            Process.Start(webpage);
        }
    }
}
