namespace ProjectTimerApp
{
    public partial class ProjectTimer : Form
    {
        public ProjectTimer()
        {
            InitializeComponent();

            Project1 = new(Project1_TimeElapsed_Label, Project1_Name_Label);
            Project2 = new(Project2_TimeElapsed_Label, Project2_Name_Label);
            Project3 = new(Project3_TimeElapsed_Label, Project3_Name_Label);
            Project4 = new(Project4_TimeElapsed_Label, Project4_Name_Label);
            Project5 = new(Project5_TimeElapsed_Label, Project5_Name_Label);
            Project6 = new(Project6_TimeElapsed_Label, Project6_Name_Label);
            Project7 = new(Project7_TimeElapsed_Label, Project7_Name_Label);
            Project8 = new(Project8_TimeElapsed_Label, Project8_Name_Label);

            SubTimerWidgets = new List<TimerWidget>
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

            TotalTimerWidget = new TotalTimerWidget
            (
                TotalTimerTimeElapsedLabel,
                Subtract30_Button,
                Subtract10_Button,
                Add10_Button,
                Add30_Button,
                TotalTimerPauseButton,
                SubTimerWidgets
            );
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TotalTimerWidget.SetInactiveWidgetStyle();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            TotalTimerWidget.UpdateTimeElapsed();
        }

        #region ToolStrip Menu
        private void AddProjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProjects addProjects = new(this);
            addProjects.Show();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion


        #region TotalTimer
        private void TotalTimerPause_Click(object sender, EventArgs e)
        {
            TotalTimerWidget.Pause();
            TotalTimerWidget.UpdateTimeElapsed();
        }
        #endregion


        #region ActiveTimer Buttons
        private void Subtract30_Button_Click(object sender, EventArgs e)
        {
            TotalTimerWidget.SubtractTimeFromActiveTimerWidget(TimeSpan.FromMinutes(30));
        }

        private void Subtract10_Button_Click(object sender, EventArgs e)
        {
            TotalTimerWidget.SubtractTimeFromActiveTimerWidget(TimeSpan.FromMinutes(10));
        }

        private void Add10_Button_Click(object sender, EventArgs e)
        {
            TotalTimerWidget.AddTimeToActiveTimerWidget(TimeSpan.FromMinutes(10));
        }

        private void Add30_Button_Click(object sender, EventArgs e)
        {
            TotalTimerWidget.AddTimeToActiveTimerWidget(TimeSpan.FromMinutes(30));
        }
        #endregion


        #region SubTimers
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

        #region Public Fields
        public List<TimerWidget> SubTimerWidgets;
        public TotalTimerWidget TotalTimerWidget;
        public TimerWidget Project1;
        public TimerWidget Project2;
        public TimerWidget Project3;
        public TimerWidget Project4;
        public TimerWidget Project5;
        public TimerWidget Project6;
        public TimerWidget Project7;
        public TimerWidget Project8;
        #endregion

        private void ClickProject(TimerWidget project)
        {
            TotalTimerWidget.SetAndStartActiveSubTimerWidget(project);
        }
    }
}