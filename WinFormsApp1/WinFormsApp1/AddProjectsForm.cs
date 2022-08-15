using System.ComponentModel;

namespace ProjectTimerApp
{
    public partial class AddProjects : Form
    {
        public AddProjects()
        {
            InitializeComponent();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            if (NewProjectName_TextBox.Text.Equals(String.Empty))
            {
                // Do Nothing
            }
            else
            {
                if (CurrentProjects_ListBox.Items.Count < 8)
                {
                    CurrentProjects_ListBox.Items.Add(NewProjectName_TextBox.Text);
                }
            }
        }

        private void Remove_Button_Click(object sender, EventArgs e)
        {
            if (CurrentProjects_ListBox.SelectedItem != null)
            {
                CurrentProjects_ListBox.Items.Remove(CurrentProjects_ListBox.SelectedItem);
            }
        }
    }
}
