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
            _allProjectProperties = new TimerWidgetProperties[] {
                mainForm.Project1_Properties,
                mainForm.Project2_Properties,
                mainForm.Project3_Properties,
                mainForm.Project4_Properties,
                mainForm.Project5_Properties,
                mainForm.Project6_Properties,            
                mainForm.Project7_Properties,
                mainForm.Project8_Properties,
            };           

            foreach (TimerWidgetProperties widgetPropertes in _allProjectProperties)
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
                _mainForm.TotalTimerWidget.Reset();
                foreach (var widgetProperties in _allProjectProperties)
                {
                    widgetProperties.TimeElapsed = TimeSpan.Zero;
                }
            }

            NewProjectName_TextBox.Focus();
        }

        private void SaveAndExit_Button_Click(object sender, EventArgs e)
        {
            List<TimerWidget> timerWidgets = _mainForm.TotalTimerWidget.GetAllTimerWidgets();

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
                timerWidgets[i].LoadProperties(_allProjectProperties[i]);
            }

            _mainForm.TotalTimerWidget.UpdateAllTimerWidgets();
            Close();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion


        #region Private Fields
        private readonly ProjectTimer _mainForm;
        private readonly BindingList<string> _projectNames;
        private readonly TimerWidgetProperties[] _allProjectProperties;
        #endregion
    }
}
