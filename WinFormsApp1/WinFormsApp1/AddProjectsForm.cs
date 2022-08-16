using System.ComponentModel;

namespace ProjectTimerApp
{
    public partial class AddProjects : Form
    {
        public AddProjects(ProjectTimer mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _projectNames = new BindingList<string>();

            foreach (var timer in _mainForm.TotalTimerWidget.GetAllTimerWidgets())
            {
                if (timer.EnabledStatus == true)
                {
                    _projectNames.Add(timer.GetProjectName());
                }     
            }
            CurrentProjects_ListBox.DataSource = _projectNames;
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            if (NewProjectName_TextBox.Text.Equals(String.Empty))
            {
                // Do Nothing
            }
            else
            {
                if (_projectNames.Count < 8)
                {
                    _projectNames.Add(NewProjectName_TextBox.Text);
                    NewProjectName_TextBox.Text = String.Empty;
                }
            }
        }

        private void Remove_Button_Click(object sender, EventArgs e)
        {
            if (CurrentProjects_ListBox.SelectedItem != null)
            {
                _projectNames.Remove(CurrentProjects_ListBox.SelectedItem.ToString());
            }
        }

        private void SaveAndExit_Button_Click(object sender, EventArgs e)
        {
            _mainForm.TotalTimerWidget.DisableAllTimerWidgets();
            if (_projectNames != null)
            {
                for (int i = 0; i < _projectNames.Count; i++)
                {
                    string name = _projectNames[i].ToString();
                    _mainForm.SubTimerWidgets[i].SetProjectName(name);
                    _mainForm.SubTimerWidgets[i].Enable();
                }
            }
            this.Close();
        }

        #region Private Fields
        private ProjectTimer _mainForm;
        private BindingList<String> _projectNames;
        #endregion
    }
}
