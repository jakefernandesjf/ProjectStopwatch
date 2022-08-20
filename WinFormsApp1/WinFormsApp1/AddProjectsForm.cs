using System.ComponentModel;

namespace ProjectTimerApp
{
    public partial class AddProjects : Form
    {
        #region Constructor
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
        #endregion


        #region UI Methods
        private void Add_Button_Click(object sender, EventArgs e)
        {
            if (NewProjectName_TextBox.Text != string.Empty)
            { 
                if (_projectNames.Count < 8)
                {
                    _projectNames.Add(NewProjectName_TextBox.Text);
                    NewProjectName_TextBox.Text = string.Empty;
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
            Close();
        }
        #endregion


        #region Private Fields
        private readonly ProjectTimer _mainForm;
        private readonly BindingList<string> _projectNames;
        #endregion
    }
}
