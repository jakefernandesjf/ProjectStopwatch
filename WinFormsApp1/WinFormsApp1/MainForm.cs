namespace ProjectStopwatchApp
{
    public partial class MainForm : Form
    {
        #region Constructor
        public MainForm()
        {
            InitializeComponent();
            InitializeStopwatchProperties();
            InitializeStopwatchWidgets();
            InitializeTotalStopwatchWidget();

            _uITimer = new(TICK_VALUE);
        }
        #endregion


        #region UI Methods

        #region Form functions
        private void MainForm_Load(object sender, EventArgs e)
        {
            TotalStopwatchWidget.SetInactiveWidgetStyle();
            TotalStopwatchWidget.UpdateAllWidgets();

            _uITimer.Start();
            _uITimer.Elapsed += UITimer_Tick;
        }

        private void UITimer_Tick(object? sender, System.Timers.ElapsedEventArgs e)
        {
            if (!IsDisposed)
            {
                Invoke(new MethodInvoker(() => TotalStopwatchWidget.UpdateTimeElapsed()));
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _uITimer.Stop();
            TotalStopwatchWidget.Pause();
            SaveAllProperties();
        }
        #endregion


        #region ToolStrip Menu
        private void AddProjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAllProperties();
            AddProjectsForm addProjects = new(this);
            addProjects.Show();

            Invoke(new MethodInvoker(() => this.Enabled = false));
        }
        private void About_Button_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new();
            aboutForm.Show();
        }
        #endregion


        #region TotalStopwatch
        private void TotalStopwatchPause_Click(object sender, EventArgs e)
        {
            TotalStopwatchWidget.Pause();
            TotalStopwatchWidget.UpdateTimeElapsed();
            if (!TotalStopwatchWidget.GetActiveStatus())
            {
                Invoke(new MethodInvoker(() => AddProjectsToolStripMenuItem.Enabled = true));
                Invoke(new MethodInvoker(() => Reset_Button.Enabled = true));
            }
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            TotalStopwatchWidget.Reset();
        }
        #endregion


        #region ActiveStopwatch Buttons
        private void Subtract30_Button_Click(object sender, EventArgs e)
        {
            TotalStopwatchWidget.SubtractTimeFromActiveWidget(TimeSpan.FromMinutes(30));
        }

        private void Subtract10_Button_Click(object sender, EventArgs e)
        {
            TotalStopwatchWidget.SubtractTimeFromActiveWidget(TimeSpan.FromMinutes(10));
        }

        private void Add10_Button_Click(object sender, EventArgs e)
        {
            TotalStopwatchWidget.AddTimeToActiveWidget(TimeSpan.FromMinutes(10));
        }

        private void Add30_Button_Click(object sender, EventArgs e)
        {
            TotalStopwatchWidget.AddTimeToActiveWidget(TimeSpan.FromMinutes(30));
        }
        #endregion


        #region SubWidgets
        private void Project1_Click(object sender, EventArgs e)
        {
            ClickProject(Project1);
        }

        private void Project2_Click(object sender, EventArgs e)
        {
            ClickProject(Project2);
        }

        private void Project3_Click(object sender, EventArgs e)
        {
            ClickProject(Project3);
        }

        private void Project4_Click(object sender, EventArgs e)
        {
            ClickProject(Project4);
        }

        private void Project5_Click(object sender, EventArgs e)
        {
            ClickProject(Project5);
        }

        private void Project6_Click(object sender, EventArgs e)
        {
            ClickProject(Project6);
        }

        private void Project7_Click(object sender, EventArgs e)
        {
            ClickProject(Project7);
        }

        private void Project8_Click(object sender, EventArgs e)
        {
            ClickProject(Project8);
        }
        #endregion SubTimers


        #region Helper Functions
        private void ClickProject(StopwatchWidget project)
        {
            TotalStopwatchWidget.SetAndStartActiveSubWidget(project);
            if (TotalStopwatchWidget.GetActiveStatus())
            {
                Invoke(new MethodInvoker(() => AddProjectsToolStripMenuItem.Enabled = false));
                Invoke(new MethodInvoker(() => Reset_Button.Enabled = false));
            }
        }

        private void InitializeStopwatchProperties()
        {
            var Settings = Properties.Settings.Default;
            TotalStopwatch_Properties = new("TotalStopwatch", Settings.Total_TimeElapsed_Setting);
            Project1_Properties = new(Settings.P1_Name_Setting, Settings.P1_TimeElapsed_Setting);
            Project2_Properties = new(Settings.P2_Name_Setting, Settings.P2_TimeElapsed_Setting);
            Project3_Properties = new(Settings.P3_Name_Setting, Settings.P3_TimeElapsed_Setting);
            Project4_Properties = new(Settings.P4_Name_Setting, Settings.P4_TimeElapsed_Setting);
            Project5_Properties = new(Settings.P5_Name_Setting, Settings.P5_TimeElapsed_Setting);
            Project6_Properties = new(Settings.P6_Name_Setting, Settings.P6_TimeElapsed_Setting);
            Project7_Properties = new(Settings.P7_Name_Setting, Settings.P7_TimeElapsed_Setting);
            Project8_Properties = new(Settings.P8_Name_Setting, Settings.P8_TimeElapsed_Setting);
        }

        private void InitializeStopwatchWidgets()
        {
            Project1 = new(Project1_TimeElapsed_Label, Project1_Name_Label, Project1_Properties);
            Project2 = new(Project2_TimeElapsed_Label, Project2_Name_Label, Project2_Properties);
            Project3 = new(Project3_TimeElapsed_Label, Project3_Name_Label, Project3_Properties);
            Project4 = new(Project4_TimeElapsed_Label, Project4_Name_Label, Project4_Properties);
            Project5 = new(Project5_TimeElapsed_Label, Project5_Name_Label, Project5_Properties);
            Project6 = new(Project6_TimeElapsed_Label, Project6_Name_Label, Project6_Properties);
            Project7 = new(Project7_TimeElapsed_Label, Project7_Name_Label, Project7_Properties);
            Project8 = new(Project8_TimeElapsed_Label, Project8_Name_Label, Project8_Properties);
        }

        private void InitializeTotalStopwatchWidget()
        {
            SubWidgets = new List<StopwatchWidget>
            {
                Project1,
                Project2,
                Project3,
                Project4,
                Project5,
                Project6,
                Project7,
                Project8,
            };

            TotalStopwatchWidget = new TotalStopwatchWidget
            (
                TotalStopwatchTimeElapsedLabel,
                Subtract30_Button,
                Subtract10_Button,
                Add10_Button,
                Add30_Button,
                TotalStopwatchPauseButton,
                SubWidgets,
                TotalStopwatch_Properties
            );
        }

        private void SaveAllProperties()
        {
            var Settings = Properties.Settings.Default;

            TotalStopwatch_Properties.SaveFromWidget(TotalStopwatchWidget);
            Project1_Properties.SaveFromWidget(Project1);
            Project2_Properties.SaveFromWidget(Project2);
            Project3_Properties.SaveFromWidget(Project3);
            Project4_Properties.SaveFromWidget(Project4);
            Project5_Properties.SaveFromWidget(Project5);
            Project6_Properties.SaveFromWidget(Project6);
            Project7_Properties.SaveFromWidget(Project7);
            Project8_Properties.SaveFromWidget(Project8);

            Settings.Total_TimeElapsed_Setting = TotalStopwatch_Properties.TimeElapsed;
            Settings.P1_Name_Setting = Project1_Properties.Name;
            Settings.P1_TimeElapsed_Setting = Project1_Properties.TimeElapsed;
            Settings.P2_Name_Setting = Project2_Properties.Name;
            Settings.P2_TimeElapsed_Setting = Project2_Properties.TimeElapsed;
            Settings.P3_Name_Setting = Project3_Properties.Name;
            Settings.P3_TimeElapsed_Setting = Project3_Properties.TimeElapsed;
            Settings.P4_Name_Setting = Project4_Properties.Name;
            Settings.P4_TimeElapsed_Setting = Project4_Properties.TimeElapsed;
            Settings.P5_Name_Setting = Project5_Properties.Name;
            Settings.P5_TimeElapsed_Setting = Project5_Properties.TimeElapsed;
            Settings.P6_Name_Setting = Project6_Properties.Name;
            Settings.P6_TimeElapsed_Setting = Project6_Properties.TimeElapsed;
            Settings.P7_Name_Setting = Project7_Properties.Name;
            Settings.P7_TimeElapsed_Setting = Project7_Properties.TimeElapsed;
            Settings.P8_Name_Setting = Project8_Properties.Name;
            Settings.P8_TimeElapsed_Setting = Project8_Properties.TimeElapsed;

            Settings.Save();
        }
        #endregion

        #endregion


        #region Public Fields       
        public TotalStopwatchWidget TotalStopwatchWidget;

        public StopwatchWidgetProperties TotalStopwatch_Properties;
        public StopwatchWidgetProperties Project1_Properties;
        public StopwatchWidgetProperties Project2_Properties;
        public StopwatchWidgetProperties Project3_Properties;
        public StopwatchWidgetProperties Project4_Properties;
        public StopwatchWidgetProperties Project5_Properties;
        public StopwatchWidgetProperties Project6_Properties;
        public StopwatchWidgetProperties Project7_Properties;
        public StopwatchWidgetProperties Project8_Properties;
        #endregion


        #region Private Fields
        private readonly System.Timers.Timer _uITimer;
        private const int TICK_VALUE = 1000;

        private List<StopwatchWidget> SubWidgets;
        private StopwatchWidget Project1;
        private StopwatchWidget Project2;
        private StopwatchWidget Project3;
        private StopwatchWidget Project4;
        private StopwatchWidget Project5;
        private StopwatchWidget Project6;
        private StopwatchWidget Project7;
        private StopwatchWidget Project8;
        #endregion
    }
}