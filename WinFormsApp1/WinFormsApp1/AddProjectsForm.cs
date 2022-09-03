using System.ComponentModel;

namespace ProjectStopwatchApp
{
    public partial class AddProjectsForm : Form
    {
        #region Constructor
        public AddProjectsForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _projectNames = new BindingList<string>();
            _allProjectProperties = new StopwatchWidgetProperties[] {
                mainForm.Project1_Properties,
                mainForm.Project2_Properties,
                mainForm.Project3_Properties,
                mainForm.Project4_Properties,
                mainForm.Project5_Properties,
                mainForm.Project6_Properties,            
                mainForm.Project7_Properties,
                mainForm.Project8_Properties,
            };           

            foreach (StopwatchWidgetProperties widgetPropertes in _allProjectProperties)
            {
                if (widgetPropertes.IsEnabled == true)
                {
                    _projectNames.Add(widgetPropertes.Name);
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
                if (_projectNames.Count < _allProjectProperties.Length)
                {
                    _projectNames.Add(NewProjectName_TextBox.Text);
                    NewProjectName_TextBox.Text = string.Empty;
                    NewProjectName_TextBox.Focus();
                }
            }
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to clear all projects?";
            string caption = "Clear Projects";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _projectNames.Clear();
                _mainForm.TotalStopwatchWidget.Reset();
                foreach (var widgetProperties in _allProjectProperties)
                {
                    widgetProperties.TimeElapsed = TimeSpan.Zero;
                }
            }

            NewProjectName_TextBox.Focus();
        }

        private void SaveAndExit_Button_Click(object sender, EventArgs e)
        {
            List<StopwatchWidget> stopwatchWidgets = _mainForm.TotalStopwatchWidget.GetAllSubWidgets();

            for (int i = 0; i < _allProjectProperties.Length; i++)
            {
                if (i < _projectNames.Count)
                {
                    _allProjectProperties[i].Name = _projectNames[i];
                    _allProjectProperties[i].IsEnabled = true;
                }
                else
                {
                    _allProjectProperties[i].Name = "";
                    _allProjectProperties[i].IsEnabled = false;
                }
                stopwatchWidgets[i].LoadProperties(_allProjectProperties[i]);
            }

            _mainForm.TotalStopwatchWidget.UpdateAllWidgets();

            Close();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            Invoke(new MethodInvoker(() => _mainForm.Enabled = true));
        }
        #endregion


        #region Private Fields
        private readonly MainForm _mainForm;
        private readonly BindingList<string> _projectNames;
        private readonly StopwatchWidgetProperties[] _allProjectProperties;
        #endregion
    }
}
